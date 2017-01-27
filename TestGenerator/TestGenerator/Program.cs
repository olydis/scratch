using AutoRest.Core;
using AutoRest.Core.Extensibility;
using AutoRest.Core.Logging;
using AutoRest.CSharp.Model;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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
            //var testFolder = @"E:\BlobStorageTests\ALL";
            var testFolder = @"E:\BlobStorageTests\rawErr";
            //var testFolder = @"E:\BlobStorageTests\Recordings1\rawPayloads";
            // var testFolder = @"E:\BlobStorageTests\Recordings2\tmp";
            var targetFolder = @"E:\BlobStorageTests\TestsErr";
            var autoRestExe = @"C:\work\autorest\src\core\AutoRest\bin\Debug\net451\win7-x64\AutoRest.exe";
            var urlFilter = new Regex(@"(http://localhost:1000./.*)|(http://.*\.blob\.core\.windows\.net/.*)");

            // create folders
            var targetFolderClient = Path.Combine(targetFolder, "client");
            var targetFolderTests = Path.Combine(targetFolder, "tests");
            Directory.CreateDirectory(targetFolderClient);
            Directory.CreateDirectory(targetFolderTests);

            using (NewContext)
            {
                // get code model
                CodeModelCs codeModel;
                Logger.Instance.AddListener(new ConsoleLogListener(Category.Warning));
                var settings = new Settings {CodeGenerator = codeGen};
                codeModel = AutoRestPipeline.GenerateCodeModel(File.ReadAllText(swaggerPath), codeGen);

                // init test generator
                var testGenerator = new TestCaseGenerator(codeModel, urlFilter);

                // generate
                //GenerateProject(targetFolder, testGenerator);
                GenerateClient(targetFolderClient, swaggerPath, codeGen, autoRestExe);
                GenerateTests(targetFolderTests, testGenerator, testFolder);

                // coverage
                Console.WriteLine(testGenerator.CoverageReport);
            }
        }

        static void GenerateClient(string targetFolder, string swaggerPath, string codeGen, string autoRestExe)
        {
            var proc = Process.Start(autoRestExe,
                $"-Input \"{swaggerPath}\" -CodeGenerator {codeGen} -OutputDirectory \"{targetFolder}\" -Namespace {TestClientNamespace}");
            proc.WaitForExit();
            if (proc.ExitCode != 0)
                throw new Exception("AutoRest failed!");
        }

        static void GenerateTests(string targetFolder, TestCaseGenerator generator, string testFolder)
        {
            var testFolderDi = new DirectoryInfo(testFolder);

            var testIds =
                testFolderDi.GetFiles("*.xml")
                    .Select(x => x.Name.Substring(0, x.Name.LastIndexOf("_", StringComparison.Ordinal)))
                    .ToArray();
            int progress = 0;
            int progressMax = testIds.Count();

            int nThreads = 128;

            Parallel.ForEach(
                Partitioner.Create(testIds, EnumerablePartitionerOptions.NoBuffering).AsParallel(),
                new ParallelOptions {MaxDegreeOfParallelism = nThreads},
                testId =>
                {
                    ThreadPool.SetMinThreads(nThreads, nThreads);
                    Logger.Instance.Log(Category.Info,
                        $"@{Thread.CurrentThread.ManagedThreadId}: Generating test {testId}");
                    var recordingFilePathRequest = testFolderDi.GetFiles($"{testId}_c.txt")[0].FullName;
                    var recordingFilePathResponse = testFolderDi.GetFiles($"{testId}_s.txt")[0].FullName;
                    var recordingFileRequest = File.ReadAllText(recordingFilePathRequest, Encoding.UTF8);
                    var recordingFileResponse = File.ReadAllText(recordingFilePathResponse, Encoding.UTF8);

                    if (recordingFileRequest.Length > (1 << 16))
                    {
                        Logger.Instance.Log(Category.Warning,
                            $"Request body too large ({recordingFileRequest.Length} bytes)");
                        return;
                    }
                    if (recordingFileResponse.Length > (1 << 16))
                    {
                        Logger.Instance.Log(Category.Warning,
                            $"Response body too large ({recordingFileResponse.Length} bytes)");
                        return;
                    }

                    // data fixups

                    // 1) `Transfer-Encoding: chunked` sometimes comes with empty body instead of `0\r\n\r\n` termination!
                    if (recordingFileResponse.Contains("Transfer-Encoding: chunked") &&
                        !recordingFileResponse.EndsWith("0\r\n\r\n"))
                    {
                        recordingFileResponse += "0\r\n\r\n";
                        recordingFilePathResponse = null;
                    }

                    try
                    {
                        // generate!
                        generator.GenerateTest(
                            targetFolder,
                            testId,
                            recordingFileRequest,
                            recordingFileResponse,
                            recordingFilePathRequest,
                            recordingFilePathResponse);
                    }
                    catch (InvalidDataException e)
                    {
                        Logger.Instance.Log(Category.Warning, e.Message);
                    }

                    Interlocked.Increment(ref progress);
                    Console.Title = $"{progress} / {progressMax}";
                });
            
            generator.GenerateTestContext(targetFolder);
        }

        static void GenerateProject(string targetFolder, TestCaseGenerator generator)
        {
            Logger.Instance.Log(Category.Info, $"Generating project file");
            generator.GenerateProjectContext(targetFolder);
        }
    }
}
