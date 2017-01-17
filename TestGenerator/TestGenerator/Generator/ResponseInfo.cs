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

        public string Body { get; set; }

        public Response ExpectedReponse { get; set; }

        public bool ExpectException { get; set; }
    }
}
