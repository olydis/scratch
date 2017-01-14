using AutoRest.Core;
using AutoRest.Core.Extensibility;
using AutoRest.Core.Logging;
using AutoRest.Core.Model;
using AutoRest.CSharp;
using AutoRest.CSharp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static AutoRest.Core.Utilities.DependencyInjection;

namespace TestGenerator.Generator
{
    class TestGenerator
    {
        private static string templatePathProject = @"Generator\Resources\test-template.xproj";
        private static string templatePathTestFile = @"Generator\Resources\test-template.cs";

        public DirectoryInfo TargetDir { get; }
        public CodeModelCs CodeModel { get; }
        public Regex UrlFilter { get; }

        public TestGenerator(DirectoryInfo targetDir, CodeModelCs codeModel, Regex urlFilter)
        {
            this.TargetDir = targetDir;
            this.CodeModel = codeModel;
            this.UrlFilter = urlFilter;
        }

        /// <summary>
        /// Matches:
        /// - /*<*/dummy/*></key>*/
        /// - /*<key/>*/
        /// - //<key/>
        /// </summary>
        private static Regex GetReplacePattern(string key) => new Regex($@"\/\*<\*\/.*?\/\*><\/{key}>\*\/|\/\*<{key}\/>\*\/|\/\/<{key}\/>");

        private string GenerateArgumentCode(ParameterCs param, string value)
        {
            var type = param.ModelType;
            if (type is CompositeType)
            {
                return $"{type.Name}XmlSerializer.Deserialize(\"{value.Replace("\"", "\\\"")}\")";
            }
            return CodeNamer.Instance.EscapeDefaultValue(value, type);
        }

        public bool GenerateTest(string testId, string recordedRequest, string recordedResponse)
        {
            var className = $"Test{testId}";
            var fileContent = File.ReadAllText(templatePathTestFile);
            fileContent = GetReplacePattern("className").Replace(fileContent, className);
            fileContent = GetReplacePattern("clientNamespace").Replace(fileContent, CodeModel.Namespace);
            fileContent = GetReplacePattern("clientConstructorCall").Replace(fileContent, $"new {CodeModel.Name}()");

            // generate body of the test
            var serviceCall = ReverseEngineering.DetermineServiceCall(recordedRequest, CodeModel, UrlFilter);
            if (serviceCall == null)
            {
                return false;
            }


            using (ExtensionsLoader.GetPlugin().Activate())
            {
                var localParams = serviceCall.Method.LocalParameters;
                var argCount = localParams.TakeWhile(p => serviceCall.Params.ContainsKey(p.SerializedName)).Count();
                if (localParams.Skip(argCount).Any(p => p.IsRequired))
                {
                    throw new Exception("encountered more required parameters than I have values for");
                }
                localParams = localParams.Take(argCount);
                var args = localParams.Select(p => GenerateArgumentCode(p, serviceCall.Params[p.SerializedName]));

                var call = $"serviceClient.{serviceCall.Method.Group.Value}.{serviceCall.Method.Name}({string.Join(", ", args)})";
                fileContent = GetReplacePattern("debug").Replace(fileContent, call);
            }

            File.WriteAllText(Path.Combine(TargetDir.FullName, $"{className}.cs"), fileContent);
            return true;
        }

        public void GenerateProjectFile()
        {
            var fileContent = File.ReadAllText(templatePathProject);
            fileContent = fileContent.Replace("<!--TestClientNamespace-->", Program.TestClientNamespace);
            File.WriteAllText(Path.Combine(TargetDir.FullName, $"{Program.TestClientNamespace}.xproj"), fileContent);
        }
    }
}
