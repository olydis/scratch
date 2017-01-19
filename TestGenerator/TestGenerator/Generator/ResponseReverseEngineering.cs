using AutoRest.Core.Logging;
using AutoRest.Core.Model;
using AutoRest.CSharp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestGenerator.Generator
{
    static class ResponseReverseEngineering
    {
        public static ResponseInfo ParseResponse(string recordedResponse, Method method)
        {
            // parse
            string intro;
            Dictionary<string, string> headers;
            string body;
            Utilities.ParseRawHttpMessage(recordedResponse, out intro, out headers, out body);

            // determine response
            int statusCode = int.Parse(intro.Split()[1]);
            var response = method.Responses.Where(r => (int)r.Key == statusCode).Select(r => r.Value).FirstOrDefault();
            var expectException = response == null;
            if (expectException) response = method.DefaultResponse;

            // parse chunked body
            if (headers.ContainsKey("Transfer-Encoding") && headers["Transfer-Encoding"] == "chunked")
            {
                var enc = Encoding.GetEncoding(1252);
                Func<string, string> toByteStr = str => enc.GetString(Encoding.UTF8.GetBytes(str));
                Func<string, string> fromByteStr = str => Encoding.UTF8.GetString(enc.GetBytes(str));

                var bodyReader = new StringReader(toByteStr(body));
                body = "";
                int len;
                while ((len = Convert.ToInt32(bodyReader.ReadLine(), 16)) > 0)
                {
                    var buffer = new char[len];
                    if (bodyReader.ReadBlock(buffer, 0, len) != len)
                        throw new InvalidDataException();
                    body += fromByteStr(new string(buffer));

                    if (body != body.Trim('\x00EF', '\x00BB', '\x00BF', '\uFEFF', '\u200B'))
                    {
                        body = body.Trim('\x00EF', '\x00BB', '\x00BF', '\uFEFF', '\u200B');
                        bodyReader.Read();
                        bodyReader.Read();// apparently not accounted for in chunk length...
                    }
                }
            }

            return new ResponseInfo
            {
                Body = body,
                Headers = headers,
                ExpectedReponse = response,
                ExpectException = expectException,
                ExpectedStatusCode = statusCode
            };
        }
    }
}
