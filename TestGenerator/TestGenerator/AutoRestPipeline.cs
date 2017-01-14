using AutoRest.Core;
using AutoRest.Core.Extensibility;
using AutoRest.Core.Model;
using AutoRest.Core.Utilities;
using AutoRest.CSharp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutoRest.Core.Utilities.DependencyInjection;

namespace TestGenerator
{
    static class AutoRestPipeline
    {
        public static CodeModelCs GenerateCodeModel(string swagger, string codeGen)
        {
            using (NewContext)
            {
                var fs = new MemoryFileSystem();
                var settings = new Settings
                {
                    Modeler = "Swagger",
                    CodeGenerator = codeGen,
                    FileSystem = fs,
                    Namespace = Program.TestClientNamespace,
                    Input = "input.json"
                };

                fs.WriteFile(settings.Input, swagger);
                fs.WriteFile("AutoRest.json", File.ReadAllText("AutoRest.json"));

                return GenerateCodeModel();
            }
        }

        private static CodeModelCs GenerateCodeModel()
        {
            using (NewContext)
            {
                var plugin = ExtensionsLoader.GetPlugin();
                var modeler = ExtensionsLoader.GetModeler();
                var codeModel = modeler.Build();

                using (plugin.Activate())
                {
                    codeModel = plugin.Serializer.Load(codeModel);
                    codeModel = plugin.Transformer.TransformCodeModel(codeModel);
                    return codeModel as CodeModelCs;
                }
            }
        }
    }
}
