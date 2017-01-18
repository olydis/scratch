using AutoRest.Core;
using AutoRest.Core.Extensibility;
using AutoRest.Core.Logging;
using AutoRest.CSharp.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TestGenerator.Generator;
using static AutoRest.Core.Utilities.DependencyInjection;

namespace TestGenerator
{
    class Program
    {
        internal static readonly string TestClientNamespace = "TestedClient";

        static void Main(string[] args)
        {
            var swaggerPath = @"C:\Users\jobader\Documents\GitHub\scratch\blob-storage-out.yaml";
            var codeGen = "Azure.CSharp";
            var testFolder = @"E:\Managed.Blob.VersionedTests\rawA";
            var targetFolder = @"E:\Managed.Blob.VersionedTests\gen";
            var autoRestExe = @"C:\work\autorest\src\core\AutoRest\bin\Debug\net451\win7-x64\AutoRest.exe";
            var urlFilter = new Regex(@"http://localhost:1000./.*");

            // create folders
            var targetFolderClient = Path.Combine(targetFolder, "client");
            var targetFolderTests = Path.Combine(targetFolder, "tests");
            Directory.CreateDirectory(targetFolderClient);
            Directory.CreateDirectory(targetFolderTests);

            using (NewContext)
            {
                // get code model
                CodeModelCs codeModel;
                Logger.Instance.AddListener(new ConsoleLogListener());
                var settings = new Settings { CodeGenerator = codeGen };
                codeModel = AutoRestPipeline.GenerateCodeModel(File.ReadAllText(swaggerPath), codeGen);

                // init test generator
                var testGenerator = new TestCaseGenerator(codeModel, urlFilter);

                // generate
                //GenerateClient(targetFolderClient, swaggerPath, codeGen, autoRestExe);
                GenerateTests(targetFolderTests, testGenerator, testFolder);
                //GenerateProject(targetFolder, testGenerator);
            }
        }

        static void GenerateClient(string targetFolder, string swaggerPath, string codeGen, string autoRestExe)
        {
            var proc = Process.Start(autoRestExe, $"-Input \"{swaggerPath}\" -CodeGenerator {codeGen} -OutputDirectory \"{targetFolder}\" -Namespace {TestClientNamespace}");
            proc.WaitForExit();
        }

        static void GenerateTests(string targetFolder, TestCaseGenerator generator, string testFolder)
        {
            var testFolderDi = new DirectoryInfo(testFolder);

            foreach (var testId in testFolderDi.GetFiles("*.xml").Select(x => x.Name.Split('_')[0]))
            {
                Logger.Instance.Log(Category.Info, $"Generating test {testId}");
                var recordingFileRequest = File.ReadAllText(testFolderDi.GetFiles($"{testId}_c.txt")[0].FullName);
                var recordingFileResponse = File.ReadAllText(testFolderDi.GetFiles($"{testId}_s.txt")[0].FullName);

                if (recordingFileRequest.Length > (1 << 16))
                {
                    Logger.Instance.Log(Category.Warning, $"Request body too large ({recordingFileRequest.Length} bytes)");
                    continue;
                }
                if (recordingFileResponse.Length > (1 << 16))
                {
                    Logger.Instance.Log(Category.Warning, $"Response body too large ({recordingFileResponse.Length} bytes)");
                    continue;
                }

                // data fixups

                // 1) `Transfer-Encoding: chunked` sometimes comes with empty body instead of `0\r\n\r\n` termination!
                if (recordingFileResponse.Contains("Transfer-Encoding: chunked") && !recordingFileResponse.EndsWith("0\r\n\r\n"))
                    recordingFileResponse += "0\r\n\r\n";

                generator.GenerateTest(
                    targetFolder,
                    testId,
                    recordingFileRequest,
                    recordingFileResponse);
            }
            
            generator.GenerateTestContext(targetFolder);
        }

        static void GenerateProject(string targetFolder, TestCaseGenerator generator)
        {
            Logger.Instance.Log(Category.Info, $"Generating project file");
            generator.GeneratePorjectContext(targetFolder);
        }
    }
}
