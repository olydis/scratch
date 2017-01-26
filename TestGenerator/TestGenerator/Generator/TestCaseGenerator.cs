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
using System.Threading;
using Microsoft.Rest.Serialization;
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
        private static readonly string templatePathTestClass = @"Generator\Resources\template-TestClass.cs";
        private static readonly string templatePathTestBaseFile = @"Generator\Resources\template-TestBase.cs";
        private static readonly string bodyParamName = "body";
        private static readonly string returnValueName = "result";
        
        public CodeModelCs CodeModel { get; }
        public Regex UrlFilter { get; }

        // indicates whether given method was tested with a
        // - successful response
        // - failing response
        private Dictionary<Method, Tuple<int, int>> coverage;
        
        private Dictionary<string, StreamWriter> touched;

        public TestCaseGenerator(CodeModelCs codeModel, Regex urlFilter)
        {
            this.CodeModel = codeModel;
            this.UrlFilter = urlFilter;

            this.coverage = codeModel.Methods.ToDictionary(m => m, m => new Tuple<int, int>(0, 0));
            this.touched = new Dictionary<string, StreamWriter>();
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
            // EARLY BLOW UP (we *can't* generate service calls with arguments that don't type...)
            if ((param.ModelType as PrimaryType)?.KnownPrimaryType == KnownPrimaryType.Int)
                try { int.Parse(value); }
                catch { throw new InvalidDataException($"integer arg had non-integer value ({value} : {param.ModelType.Name})"); }
            if ((param.ModelType as PrimaryType)?.KnownPrimaryType == KnownPrimaryType.DateTime ||
                (param.ModelType as PrimaryType)?.KnownPrimaryType == KnownPrimaryType.DateTimeRfc1123)
                try { SafeJsonConvert.DeserializeObject<DateTime>(value); }
                catch { throw new InvalidDataException($"datetime arg had non-datetime value ({value} : {param.ModelType.Name})"); }

            if (param.Location == ParameterLocation.Body)
                return bodyParamName;
            if ((param.ModelType as EnumType)?.ModelAsString == false)
                return $"{Utilities.EscapeString(value)}.Parse{param.ModelType.Name}() ?? ({param.ModelType.Name})Enum.Parse(typeof({param.ModelType.Name}), {Utilities.EscapeString(value)})";
            if ((param.ModelType as PrimaryType)?.KnownPrimaryType == KnownPrimaryType.String)
                return Utilities.EscapeString(value);
            return CodeNamer.Instance.EscapeDefaultValue(value, param.ModelType)
                .Replace(", this.Client.SerializationSettings", "");
        }


        public bool GenerateTest(string targetDir, string testId, 
            string recordedRequest, string recordedResponse,
            string recordingFilePathRequest, string recordingFilePathResponse)
        {
            var className = $"Test{testId}";

            using (NewContext)
            {
                var dump = new StringBuilder();
                Logger.Instance.AddListener(new SignalingLogListener(Category.Debug, message => dump.AppendLine($"// {message.Severity}\t{message.Message.Replace("\r", @"\r").Replace("\n", @"\n")}")));
                
                // parse request
                var serviceCall = RequestReverseEngineering.DetermineServiceCall(testId, recordedRequest, CodeModel, UrlFilter);
                if (serviceCall == null)
                {
                    return false;
                }
                Logger.Instance.Log(Category.Debug, $"[parsed parameters]");
                foreach (var p in serviceCall.Params)
                    Logger.Instance.Log(Category.Debug, $"{p.Key}: {p.Value}");

                // parse response
                var responseInfo = ResponseReverseEngineering.ParseResponse(recordedResponse, serviceCall.Method);

                // file info
                var fileName = Path.Combine(targetDir, $"{serviceCall.Method.Group}_{serviceCall.Method.Name}_{(responseInfo.ExpectException ? "fail" : "succ")}.cs");
                StreamWriter fileWriter;

                lock (this)
                {
                    // update coverage data
                    var mcoverage = this.coverage[serviceCall.Method];
                    this.coverage[serviceCall.Method] = !responseInfo.ExpectException
                        ? new Tuple<int, int>(mcoverage.Item1 + 1, mcoverage.Item2)
                        : new Tuple<int, int>(mcoverage.Item1, mcoverage.Item2 + 1);

                    // (re)used test file:
                    if (!touched.ContainsKey(fileName))
                    {
                        fileWriter = new StreamWriter(File.Create(fileName), Encoding.UTF8);
                        touched.Add(fileName, fileWriter);
                        // generate stub
                        var fileContent = File.ReadAllText(templatePathTestFile);
                        fileContent = GetReplacePattern("clientNamespace").Replace(fileContent, CodeModel.Namespace);
                        fileContent = GetReplacePattern("clientNamespaceModels").Replace(fileContent, $"{CodeModel.Namespace}.Models");
                        fileContent = GetReplacePattern("clientNamespaceTests").Replace(fileContent, $"{CodeModel.Namespace}.Tests");
                        fileWriter.Write(fileContent);
                    }
                    fileWriter = touched[fileName];
                }

                // generate test class
                GenerateTestClass(className, 
                        recordedRequest, recordedResponse, 
                        recordingFilePathRequest, recordingFilePathResponse, 
                        serviceCall, responseInfo, fileWriter, dump);
            }

            return true;
        }

        private void GenerateTestClass(
            string className,
            string recordedRequest,
            string recordedResponse,
            string recordingFilePathRequest,
            string recordingFilePathResponse,
            ServiceCallInfo serviceCall,
            ResponseInfo responseInfo,
            StreamWriter fileWriter, // when writing out
            StringBuilder dump)
        {
            using (ExtensionsLoader.GetPlugin().Activate()) // so all the right naming is done (also: default value escaping)
            {
                var fileContent = File.ReadAllText(templatePathTestClass);
                fileContent = GetReplacePattern("rem").Replace(fileContent, "");
                fileContent = GetReplacePattern("className").Replace(fileContent, className);
                fileContent = GetReplacePattern("clientConstructorCall").Replace(fileContent, $"new {CodeModel.Name}(this.Credentials)");
                fileContent = GetReplacePattern("recordedRequest").Replace(fileContent, $"File.ReadAllText({Utilities.EscapeString(recordingFilePathRequest)}, Encoding.UTF8)");
                if (recordingFilePathResponse != null)
                    fileContent = GetReplacePattern("recordedResponse").Replace(fileContent, $"File.ReadAllText({Utilities.EscapeString(recordingFilePathResponse)}, Encoding.UTF8)");
                else
                    fileContent = GetReplacePattern("recordedResponse").Replace(fileContent, Utilities.EscapeString(recordedResponse));
                //fileContent = GetReplacePattern("recordedRequestBody").Replace(fileContent, Utilities.EscapeString(Utilities.GetHttpBody(recordedRequest)));
                //fileContent = GetReplacePattern("recordedResponseBody").Replace(fileContent, Utilities.EscapeString(responseInfo.Body));

                // parse body if exists
                if (serviceCall.BodyParam != null)
                {
                    var bodyDeserCode = $"{serviceCall.BodyParamType} {bodyParamName}; {serviceCall.BodyInitStatement(bodyParamName)};";
                    fileContent = GetReplacePattern("bodyParamInit").Replace(fileContent, bodyDeserCode);
                }

                // generate C# code for args
                var sbArgs = new StringBuilder();
                sbArgs.AppendLine();
                foreach (var p in serviceCall.AvailableParams)
                    sbArgs.AppendLine($"                        {p.Name}: {GenerateArgumentCode(p, serviceCall.Params[p.SerializedName])},");
                sbArgs.Append("                        cancellationToken: cancellationToken");
                var args = sbArgs.ToString();

                // gen call statement (return thingy will have `Headers`/`Body` properties if `returnType` has those things as non-null)
                //var returnType = serviceCall.Method.ReturnType;
                var callStatement = $"var {returnValueName} = serviceClient.{serviceCall.Method.Group.Value}.{serviceCall.Method.Name}WithHttpMessagesAsync({args}).GetAwaiter().GetResult();";
                fileContent = GetReplacePattern("call").Replace(fileContent, callStatement);

                // response validation
                if (responseInfo.ExpectException)
                {
                    fileContent = GetReplacePattern("assertFail").Replace(fileContent, "");
                    fileContent = GetReplacePattern("assertServerFail").Replace(fileContent, "/*expecting failure*/");
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
                            sb.AppendLine(indent + $"byte[] dataBodyExpected = Encoding.UTF8.GetBytes(RawResponseBody);");
                            sb.AppendLine(indent + "byte[] dataBodyActual;");
                            sb.AppendLine(indent + "using (var ms = new MemoryStream()) { result.Body.CopyTo(ms); dataBodyActual = ms.ToArray(); }");
                            sb.AppendLine(indent + "Assert.Equal(dataBodyExpected.Length, dataBodyActual.Length);");
                            sb.AppendLine(indent + "for (int i = 0; i < dataBodyExpected.Length; ++i) Assert.Equal(dataBodyExpected[i], dataBodyActual[i]);");
                        }
                        else if (response.Body.Name == "string")
                        {
                            sb.AppendLine(indent + $"var strBodyExpected = RawResponseBody;");
                            sb.AppendLine(indent + "var strBodyActual = result.Body;");
                            sb.AppendLine(indent + "Assert.Equal(strBodyExpected, strBodyActual);");
                        }
                        else if (response.Body.Name == "object")
                        {
                            sb.AppendLine(indent + $"var strBodyExpected = XElement.Parse(RawResponseBody).ToString();");
                            sb.AppendLine(indent + "var strBodyActual = result.Body.ToString();");
                            sb.AppendLine(indent + "Assert.Equal(strBodyExpected, strBodyActual);");
                        }
                        else
                        {
                            sb.AppendLine(indent + $"var xmlBodyExpected = XElement.Parse(RawResponseBody);");
                            if (response.Body is SequenceType && (response.Body as SequenceType).ElementType is CompositeType)
                            {
                                sb.AppendLine(indent + $"var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement(\"{(response.Body as SequenceType).ElementXmlName}\"))));");
                            }
                            else if (response.Body is SequenceType)
                            {
                                sb.AppendLine(indent + $"var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => new XElement(\"{(response.Body as SequenceType).ElementXmlName}\", x)));");
                            }
                            else
                            {
                                sb.AppendLine(indent + "var xmlBodyActual = new XElement(xmlBodyExpected.Name);");
                                sb.AppendLine(indent + "result.Body.XmlSerialize(xmlBodyActual);");
                            }
                            sb.AppendLine(indent + "// Assert.Equal(xmlBodyExpected, xmlBodyActual);");

                            // VS code diff
                            sb.AppendLine();
                            sb.AppendLine(indent + "if (Debugger.IsAttached)");
                            sb.AppendLine(indent + "{");
                            sb.AppendLine(indent + "    var fileA = Path.GetTempFileName();");
                            sb.AppendLine(indent + "    var fileB = Path.GetTempFileName();");
                            sb.AppendLine(indent + "    File.WriteAllText(fileA, xmlBodyExpected.ToString());");
                            sb.AppendLine(indent + "    File.WriteAllText(fileB, xmlBodyActual.ToString());");
                            sb.AppendLine(indent + "    var p = Process.Start(\"code\", $\"-w -d \\\"{fileA}\\\" \\\"{fileB}\\\"\");");
                            sb.AppendLine(indent + "    p.WaitForExit();");
                            sb.AppendLine(indent + "    try");
                            sb.AppendLine(indent + "    {");
                            sb.AppendLine(indent + "        File.Delete(fileA);");
                            sb.AppendLine(indent + "        File.Delete(fileB);");
                            sb.AppendLine(indent + "    }");
                            sb.AppendLine(indent + "    catch { }");
                            sb.AppendLine(indent + "}");
                            sb.AppendLine();
                            sb.AppendLine(indent + "FuzzyMatch(xmlBodyExpected, xmlBodyActual);");
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
                fileContent = GetReplacePattern("dump").Replace(fileContent.Trim(), dump.ToString());

                // chain test
                lock (fileWriter)
                {
                    fileWriter.WriteLine();
                    fileWriter.WriteLine(fileContent.Trim());
                }
            }
        }

        public void GenerateTestContext(string targetDir)
        {
            // flush tests
            foreach (var fileWriter in touched.Values)
                fileWriter.Close();

            // TestBase.cs
            var fileContent = File.ReadAllText(templatePathTestBaseFile);
            fileContent = GetReplacePattern("clientNamespace").Replace(fileContent, CodeModel.Namespace);
            File.WriteAllText(Path.Combine(targetDir, $"TestBase.cs"), fileContent);
        }

        public void GenerateProjectContext(string targetDir)
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

        public string CoverageReport
        {
            get
            {
                var sb = new StringBuilder();
                sb.AppendLine("Covered:");
                foreach (var methodCoverage in coverage)
                    sb.AppendLine("- " +
                                  $"{methodCoverage.Value.Item1:D5} " +
                                  $"{methodCoverage.Value.Item2:D5} " +
                                  $"{methodCoverage.Key.Group}_{methodCoverage.Key.Name}");
                var coverageRatio = coverage.Sum(c => (c.Value.Item1 > 0 ? 0.5 : 0) + (c.Value.Item2 > 0 ? 0.5 : 0)) / coverage.Count;
                sb.AppendLine($"Total coverage: {coverageRatio:F2}");
                return sb.ToString();
            }
        }
    }
}
