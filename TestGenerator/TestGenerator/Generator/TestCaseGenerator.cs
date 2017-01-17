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
    class TestCaseGenerator
    {
        private static readonly string[] staticPorjectFiles = new string[] {
            @"Generator\Resources\app.config",
            @"Generator\Resources\project.json"
        };
        private static readonly string templatePathSolution = @"Generator\Resources\template-Test.sln";
        private static readonly string templatePathProject = @"Generator\Resources\template-Test.xproj";
        private static readonly string templatePathTestFile = @"Generator\Resources\template-Test.cs";
        private static readonly string templatePathTestBaseFile = @"Generator\Resources\template-TestBase.cs";
        private static readonly string bodyParamName = "body";
        private static readonly string returnValueName = "result";
        
        public CodeModelCs CodeModel { get; }
        public Regex UrlFilter { get; }

        public TestCaseGenerator(CodeModelCs codeModel, Regex urlFilter)
        {
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
            if (param.Location == ParameterLocation.Body)
                return bodyParamName;
            return CodeNamer.Instance.EscapeDefaultValue(value, param.ModelType);
        }

        public bool GenerateTest(string targetDir, string testId, string recordedRequest, string recordedResponse)
        {
            var className = $"Test{testId}";

            var dump = new StringBuilder();
            using (NewContext)
            {
                Logger.Instance.AddListener(new SignalingLogListener(Category.Debug, message => dump.AppendLine($"// {message.Severity}\t{message.Message}")));

                // parse request
                var serviceCall = RequestReverseEngineering.DetermineServiceCall(recordedRequest, CodeModel, UrlFilter);
                if (serviceCall == null)
                {
                    return false;
                }
                Logger.Instance.Log(Category.Debug, $"[parsed parameters]");
                foreach (var p in serviceCall.Params)
                    Logger.Instance.Log(Category.Debug, $"{p.Key}: {p.Value}");

                // parse response
                var responseInfo = ResponseReverseEngineering.ParseResponse(recordedResponse, serviceCall.Method);

                // generate test file
                using (ExtensionsLoader.GetPlugin().Activate()) // so all the right naming is done (also: default value escaping)
                {
                    var fileContent = File.ReadAllText(templatePathTestFile);
                    fileContent = GetReplacePattern("clientNamespace").Replace(fileContent, CodeModel.Namespace);
                    fileContent = GetReplacePattern("className").Replace(fileContent, className);
                    fileContent = GetReplacePattern("clientConstructorCall").Replace(fileContent, $"new {CodeModel.Name}(credentials)");
                    fileContent = GetReplacePattern("recordedRequest").Replace(fileContent, Utilities.EscapeString(recordedRequest));
                    fileContent = GetReplacePattern("recordedResponse").Replace(fileContent, Utilities.EscapeString(recordedResponse));
                    //fileContent = GetReplacePattern("recordedRequestBody").Replace(fileContent, Utilities.EscapeString(Utilities.GetHttpBody(recordedRequest)));
                    //fileContent = GetReplacePattern("recordedResponseBody").Replace(fileContent, Utilities.EscapeString(responseInfo.Body));


                    // parse body if exists
                    var bodyParamExpression = serviceCall.BodyParamExpression;
                    if (bodyParamExpression != null)
                    {
                        var bodyDeserCode = $"var {bodyParamName} = {bodyParamExpression};";
                        fileContent = GetReplacePattern("bodyParamInit").Replace(fileContent, bodyDeserCode);
                    }

                    // generate C# code for args
                    var sbArgs = new StringBuilder();
                    sbArgs.AppendLine();
                    foreach (var p in serviceCall.AvailableParams)
                        sbArgs.AppendLine($"                        {p.Name}: {GenerateArgumentCode(p, serviceCall.Params[p.SerializedName])},");
                    var args = sbArgs.ToString().TrimEnd().TrimEnd(',');

                    // gen call statement (return thingy will have `Headers`/`Body` properties if `returnType` has those things as non-null)
                    //var returnType = serviceCall.Method.ReturnType;
                    var callStatement = $"var {returnValueName} = await serviceClient.{serviceCall.Method.Group.Value}.{serviceCall.Method.Name}WithHttpMessagesAsync({args});";
                    fileContent = GetReplacePattern("call").Replace(fileContent, callStatement);

                    // response validation
                    fileContent = GetReplacePattern(responseInfo.ExpectException ? "throwIfExpectedFail" : "throwIfExpectedSuccess").Replace(fileContent, "throw;");

                    // dump and finish
                    fileContent = GetReplacePattern("dump").Replace(fileContent, dump.ToString());
                    File.WriteAllText(Path.Combine(targetDir, $"{className}.cs"), fileContent);
                }
            }

            return true;
        }

        public void GenerateTestContext(string targetDir)
        {
            // TestBase.cs
            var fileContent = File.ReadAllText(templatePathTestBaseFile);
            fileContent = GetReplacePattern("clientNamespace").Replace(fileContent, CodeModel.Namespace);
            File.WriteAllText(Path.Combine(targetDir, $"TestBase.cs"), fileContent);
        }

        public void GeneratePorjectContext(string targetDir)
        {
            string fileContent;

            // X.xproj
            fileContent = File.ReadAllText(templatePathProject);
            fileContent = fileContent.Replace("<!--TestClientNamespace-->", Program.TestClientNamespace);
            File.WriteAllText(Path.Combine(targetDir, $"{Program.TestClientNamespace}.xproj"), fileContent);

            // X.sln
            fileContent = File.ReadAllText(templatePathSolution);
            fileContent = fileContent.Replace("<!--TestClientNamespace-->", Program.TestClientNamespace);
            File.WriteAllText(Path.Combine(targetDir, $"{Program.TestClientNamespace}.sln"), fileContent);

            // static project files
            foreach (var staticFile in staticPorjectFiles)
                File.Copy(staticFile, Path.Combine(targetDir, Path.GetFileName(staticFile)), true);
        }
    }
}
