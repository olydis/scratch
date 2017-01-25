using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestGenerator.Generator
{
    static class Utilities
    {
        public static void ParseRawHttpMessage(string message, out string intro, out Dictionary<string, string> headers, out string body)
        {
            var httpNewLine = "\r\n";
            var divideIndex = new string(message.Select(c => (char)(c % 256)).ToArray()).IndexOf(httpNewLine + httpNewLine);
            body = message.Substring(divideIndex + 4);
            var lines = message.Substring(0, divideIndex).Split(new[] { httpNewLine }, StringSplitOptions.RemoveEmptyEntries);
            intro = lines[0];
            headers = lines.Skip(1).TakeWhile(line => line != "")
                .Select(line => Regex.Match(line, @"^(?<key>.*?)\: (?<value>.*?)$"))
                .Distinct(new AutoRest.Core.Utilities.EqualityComparer<Match>((a, b) => a.Groups["key"].Value == b.Groups["key"].Value, x => x.Groups["key"].Value.GetHashCode()))
                .ToDictionary(x => x.Groups["key"].Value, x => x.Groups["value"].Value);
        }

        public static string GetHttpBody(string message)
        {
            string intro;
            Dictionary<string, string> headers;
            string body;
            ParseRawHttpMessage(message, out intro, out headers, out body);
            return body;
        }

        public static string EscapeString(string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            if (bytes.Any(b => b > 127))
                return $@"Encoding.UTF8.GetString(new byte[]{{{string.Join(",", bytes)}}})";

            using (var writer = new StringWriter())
            {
                using (var provider = CodeDomProvider.CreateProvider("CSharp"))
                {
                    provider.GenerateCodeFromExpression(new CodePrimitiveExpression(input), writer, null);
                    return writer.ToString();
                }
            }
        }
    }
}
