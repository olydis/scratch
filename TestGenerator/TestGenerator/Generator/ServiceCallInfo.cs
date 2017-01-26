using AutoRest.Core.Model;
using AutoRest.CSharp;
using AutoRest.CSharp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
                if (localParams.Any(p => !Params.ContainsKey(p.SerializedName) && p.IsRequired))
                {
                    throw new Exception("encountered more required parameters than I have values for");
                }
                return localParams.Where(p => Params.ContainsKey(p.SerializedName));
            }
        }
        public string BodyParam
        {
            get
            {
                var bodyParam = Method.Body;
                if (bodyParam != null)
                {
                    var value = Params[bodyParam.SerializedName];
                    return value.Trim('\x00EF', '\x00BB', '\x00BF', '\uFEFF', '\u200B');
                }
                return null;
            }
        }

        public string BodyParamType
        {
            get
            {
                return Method.Body.ModelTypeName;
            }
        }

        public string BodyParamInnerType
        {
            get
            {
                var type = Method.Body.ModelType;
                type = (type as SequenceType)?.ElementType
                    ?? (type as DictionaryType)?.ValueType
                    ?? type;
                return type.Name;
            }
        }

        public string BodyInitStatement(string bodyParamName)
        {
            var bodyString = Utilities.EscapeString(BodyParam);
            if (BodyParamType == "System.IO.Stream")
                return $"{bodyParamName} = new MemoryStream(Encoding.UTF8.GetBytes({bodyString}))";
            if (string.IsNullOrEmpty(BodyParam))
                bodyString = "\"<root/>\"";
            var expression = XmlSerialization.GenerateDeserializer(Method.CodeModel, Method.Body.ModelType);
            return $"Assert.True(XmlSerialization.Root({expression})(XElement.Parse({bodyString}), out {bodyParamName}))";
        }
    }
}
