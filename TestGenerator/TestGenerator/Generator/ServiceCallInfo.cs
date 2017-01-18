using AutoRest.Core.Model;
using AutoRest.CSharp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenerator.Generator
{
    class ServiceCallInfo
    {
        public MethodCs Method { get; set; }
        public Dictionary<string, string> Params { get; set; }

        /// <summary>
        /// determine formal params that we have values for
        /// </summary>
        public IEnumerable<ParameterCs> AvailableParams
        {
            get
            {
                var localParams = Method.LocalParameters;
                var argCount = localParams.TakeWhile(p => Params.ContainsKey(p.SerializedName)).Count();
                if (localParams.Skip(argCount).Any(p => p.IsRequired))
                {
                    throw new Exception("encountered more required parameters than I have values for");
                }
                return localParams.Take(argCount);
            }
        }

        public string BodyParamExpression
        {
            get
            {
                var bodyParam = Method.Body;
                if (bodyParam != null)
                {
                    var value = Params[bodyParam.SerializedName];

                    // strip BOM from payload
                    value = value.Trim('\x00EF', '\x00BB', '\x00BF', '\uFEFF', '\u200B');

                    if (bodyParam.ModelType.Name == "System.IO.Stream")
                    {
                        return $"new MemoryStream(Encoding.UTF8.GetBytes({Utilities.EscapeString(value)}))";
                    }

                    return $"Models.{bodyParam.ModelType.Name}.XmlDeserialize({Utilities.EscapeString(value)})";
                }
                return null;
            }
        }
    }
}
