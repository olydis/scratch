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
            if ((param.ModelType as EnumType)?.ModelAsString == false)
                return $"{param.ModelTypeName}.{CodeNamer.Instance.EscapeDefaultValue(value, param.ModelType)}";
            return CodeNamer.Instance.EscapeDefaultValue(value, param.ModelType)
                .Replace(", this.Client.SerializationSettings", "");
        }

        public bool GenerateTest(string targetDir, string testId, string recordedRequest, string recordedResponse)
        {
            var className = $"Test{testId}";

            var dump = new StringBuilder();
            using (NewContext)
            {
                Logger.Instance.AddListener(new SignalingLogListener(Category.Debug, message => dump.AppendLine($"// {message.Severity}\t{message.Message.Replace("\r", @"\r").Replace("\n", @"\n")}")));

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
                    fileContent = GetReplacePattern("clientNamespaceModels").Replace(fileContent, $"{CodeModel.Namespace}.Models");
                    fileContent = GetReplacePattern("className").Replace(fileContent, className);
                    fileContent = GetReplacePattern("clientConstructorCall").Replace(fileContent, $"new {CodeModel.Name}(credentials)");
                    fileContent = GetReplacePattern("recordedRequest").Replace(fileContent, Utilities.EscapeString(recordedRequest));
                    fileContent = GetReplacePattern("recordedResponse").Replace(fileContent, Utilities.EscapeString(recordedResponse));
                    //fileContent = GetReplacePattern("recordedRequestBody").Replace(fileContent, Utilities.EscapeString(Utilities.GetHttpBody(recordedRequest)));
                    //fileContent = GetReplacePattern("recordedResponseBody").Replace(fileContent, Utilities.EscapeString(responseInfo.Body));


                    // parse body if exists
                    if (serviceCall.BodyParam != null)
                    {
                        var bodyDeserCode = $"{serviceCall.BodyParamType} {bodyParamName}; {serviceCall.BodyInitStatement(bodyParamName)}; Assert.NotNull({bodyParamName});";
                        fileContent = GetReplacePattern("bodyParamInit").Replace(fileContent, bodyDeserCode);
                    }

                    // generate C# code for args
                    var sbArgs = new StringBuilder();
                    sbArgs.AppendLine();
                    foreach (var p in serviceCall.AvailableParams)
                        sbArgs.AppendLine($"                        {p.Name}: {GenerateArgumentCode(p, serviceCall.Params[p.SerializedName])},");
                    sbArgs.Append($"                        cancellationToken: new CancellationTokenSource(3000).Token");
                    var args = sbArgs.ToString();

                    // gen call statement (return thingy will have `Headers`/`Body` properties if `returnType` has those things as non-null)
                    //var returnType = serviceCall.Method.ReturnType;
                    var callStatement = $"var {returnValueName} = await serviceClient.{serviceCall.Method.Group.Value}.{serviceCall.Method.Name}WithHttpMessagesAsync({args});";
                    fileContent = GetReplacePattern("call").Replace(fileContent, callStatement);

                    // response validation
                    if (responseInfo.ExpectException)
                    {
                        fileContent = GetReplacePattern("assertFail").Replace(fileContent, "");
                        fileContent = GetReplacePattern("assertSuccess").Replace(fileContent, "Assert.True(false); // expected exception");

                        fileContent = GetReplacePattern("validation").Replace(fileContent, "");
                    }
                    else
                    {
                        fileContent = GetReplacePattern("assertFail").Replace(fileContent, "throw; // expected success");
                        fileContent = GetReplacePattern("assertSuccess").Replace(fileContent, "");

                        var sb = new StringBuilder();
                        string indent = "                ";
                        var response = responseInfo.ExpectedReponse;
                        if (response.Body != null)
                        {
                            sb.AppendLine(indent + "// body validation");
                            if (response.Body.Name == "System.IO.Stream")
                            {
                                sb.AppendLine(indent + $"byte[] dataBodyExpected = Encoding.UTF8.GetBytes({Utilities.EscapeString(responseInfo.Body)});");
                                sb.AppendLine(indent + "byte[] dataBodyActual;");
                                sb.AppendLine(indent + "using (var ms = new MemoryStream()) { result.Body.CopyTo(ms); dataBodyActual = ms.ToArray(); }");
                                sb.AppendLine(indent + "Assert.Equal(dataBodyExpected.Length, dataBodyActual.Length);");
                                sb.AppendLine(indent + "for (int i = 0; i < dataBodyExpected.Length; ++i) Assert.Equal(dataBodyExpected[i], dataBodyActual[i]);");
                            }
                            else if (response.Body.Name == "string")
                            {
                                sb.AppendLine(indent + $"var strBodyExpected = {Utilities.EscapeString(responseInfo.Body)};");
                                sb.AppendLine(indent + "var strBodyActual = result.Body;");
                                sb.AppendLine(indent + "Assert.Equal(strBodyExpected, strBodyActual);");
                            }
                            else
                            {
                                sb.AppendLine(indent + $"var xmlBodyExpected = XElement.Parse({Utilities.EscapeString(responseInfo.Body)});");
                                sb.AppendLine(indent + "var xmlBodyActual = new XElement(xmlBodyExpected.Name);");
                                sb.AppendLine(indent + "result.Body.XmlSerialize(xmlBodyActual);");
                                sb.AppendLine(indent + "// Assert.Equal(xmlBodyExpected, xmlBodyActual);");
                            }
                        }
                        //if (response.Headers != null)
                        //{
                        //    sb.AppendLine(indent + "// header validation");
                        //    sb.AppendLine(indent + "var headers = result.Headers;");
                        //    foreach (var expectedHeader in responseInfo.ExpectedTypedHeaderFields)
                        //        sb.AppendLine(indent + $"Assert.Equal({CodeNamer.Instance.EscapeDefaultValue(expectedHeader.Value, expectedHeader.Key.ModelType)}, headers.{expectedHeader.Key.Name});");
                        //}
                        fileContent = GetReplacePattern("validation").Replace(fileContent, sb.ToString());
                    }

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
