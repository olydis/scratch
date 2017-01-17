using AutoRest.Core.Logging;
using AutoRest.Core.Model;
using AutoRest.CSharp.Model;
using System;
using System.Collections.Generic;
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

            return new ResponseInfo
            {
                Body = body,
                Headers = headers,
                ExpectedReponse = response,
                ExpectException = expectException
            };
        }
    }
}
