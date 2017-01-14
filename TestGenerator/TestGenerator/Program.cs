using AutoRest.Core;
using AutoRest.Core.Extensibility;
using AutoRest.Core.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
            var testFolder = @"E:\Managed.Blob.VersionedTests\raw2";
            var targetFolder = @"E:\Managed.Blob.VersionedTests\gen";
            var urlFilter = new Regex(@"http://localhost:10000/.*");

            using (NewContext)
            {
                Logger.Instance.AddListener(new ConsoleLogListener());
                var settings = new Settings { CodeGenerator = codeGen };
                GenerateTests(swaggerPath, codeGen, testFolder, targetFolder, urlFilter);
            }
        }

        static void GenerateTests(string swaggerPath, string codeGen, string testFolder, string targetFolder, Regex urlFilter)
        {
            var testFolderDi = new DirectoryInfo(testFolder);
            var codeModel = AutoRestPipeline.GenerateCodeModel(File.ReadAllText(swaggerPath), codeGen);
            var testGenerator = new Generator.TestGenerator(new DirectoryInfo(targetFolder), codeModel, urlFilter);
            
            foreach (var testId in testFolderDi.GetFiles("*.xml").Select(x => x.Name.Split('_')[0]))
            {
                Logger.Instance.Log(Category.Info, $"Generating test {testId}");
                var recordingFileRequest = testFolderDi.GetFiles($"{testId}_c.txt")[0];
                var recordingFileResponse = testFolderDi.GetFiles($"{testId}_s.txt")[0];
                testGenerator.GenerateTest(
                    testId,
                    File.ReadAllText(recordingFileRequest.FullName), 
                    File.ReadAllText(recordingFileResponse.FullName));
            }

            Logger.Instance.Log(Category.Info, $"Generating project file");
            testGenerator.GenerateProjectFile();
        }
    }
}
