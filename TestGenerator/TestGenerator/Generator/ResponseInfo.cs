using AutoRest.Core.Model;
using AutoRest.CSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerator.Generator
{
    class ResponseInfo
    {
        public Dictionary<string, string> Headers { get; set; }

        public int ExpectedStatusCode { get; set; }

        public Response ExpectedReponse { get; set; }

        public bool ExpectException { get; set; }

        public Dictionary<Property, string> ExpectedTypedHeaderFields
        {
            get
            {
                var headers = new Dictionary<Property, string>();
                foreach (var headerField in (ExpectedReponse.Headers as CompositeType)?.Properties ?? Enumerable.Empty<Property>())
                    if (Headers.ContainsKey(headerField.SerializedName))
                        headers[headerField] = Headers[headerField.SerializedName];
                return headers;
            }
        }
    }
}
