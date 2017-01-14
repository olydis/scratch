using AutoRest.Core.Model;
using AutoRest.CSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerator.Generator
{
    class ServiceCallInfo
    {
        public MethodCs Method { get; set; }
        public Dictionary<string, string> Params { get; set; }
    }
}
