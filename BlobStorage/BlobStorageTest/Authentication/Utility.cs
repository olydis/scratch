using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using Microsoft.WindowsAzure.Storage.Core;
using Microsoft.WindowsAzure.Storage.Core.Util;

namespace BlobStorageTest.Authentication
{
    public static class Utility
    {
        public static string GetValue(this HttpHeaders headers, string name)
        {
            IEnumerable<string> result = new List<string>();
            return headers?.TryGetValues(name, out result) == true
                ? result.FirstOrDefault()
                : null;
        }

        internal static string CanonicalizeHttpRequest(HttpRequestMessage request, string accountName)
        {
            // Add the method (GET, POST, PUT, or HEAD).
            CanonicalizedString canonicalizedString = new CanonicalizedString(request.Method.ToString().ToUpperInvariant());

            // Add the Content-* HTTP headers. Empty values are allowed.
            canonicalizedString.AppendCanonicalizedElement(request.Content?.Headers.GetValue("Content-Encoding"));
            canonicalizedString.AppendCanonicalizedElement(request.Content?.Headers.GetValue("Content-Language"));
            AuthenticationUtility.AppendCanonicalizedContentLengthHeader(canonicalizedString, request);
            canonicalizedString.AppendCanonicalizedElement(request.Content?.Headers.GetValue("Content-MD5"));
            canonicalizedString.AppendCanonicalizedElement(request.Content?.Headers.GetValue("Content-Type"));

            // Add the Date HTTP header (only if the x-ms-date header is not being used)
            AuthenticationUtility.AppendCanonicalizedDateHeader(canonicalizedString, request);

            // Add If-* headers and Range header
            canonicalizedString.AppendCanonicalizedElement(request.Headers.GetValue("If-Modified-Since"));
            canonicalizedString.AppendCanonicalizedElement(request.Headers.GetValue("If-Match"));
            canonicalizedString.AppendCanonicalizedElement(request.Headers.GetValue("If-None-Match"));
            canonicalizedString.AppendCanonicalizedElement(request.Headers.GetValue("If-Unmodified-Since"));
            canonicalizedString.AppendCanonicalizedElement(request.Headers.GetValue("Range"));

            // Add any custom headers
            AuthenticationUtility.AppendCanonicalizedCustomHeaders(canonicalizedString, request);

            // Add the canonicalized URI element
            string resourceString = AuthenticationUtility.GetCanonicalizedResourceString(request.RequestUri, accountName);
            canonicalizedString.AppendCanonicalizedElement(resourceString);

            return canonicalizedString.ToString();
        }

        internal static string ComputeHmac256(byte[] key, string message)
        {
            using (HashAlgorithm hashAlgorithm = new HMACSHA256(key))
            {
                byte[] messageBuffer = Encoding.UTF8.GetBytes(message);
                return Convert.ToBase64String(hashAlgorithm.ComputeHash(messageBuffer));
            }
        }

        internal static IDictionary<string, string> ParseQueryString(string query)
        {
            var retVal = new Dictionary<string, string>();
            if (string.IsNullOrEmpty(query))
            {
                return retVal;
            }

            if (query.StartsWith("?", StringComparison.Ordinal))
            {
                if (query.Length == 1)
                {
                    return retVal;
                }

                query = query.Substring(1);
            }

            string[] valuePairs = query.Split('&');
            foreach (string pair in valuePairs)
            {
                string key;
                string value;

                int equalDex = pair.IndexOf("=", StringComparison.Ordinal);
                if (equalDex < 0)
                {
                    key = string.Empty;
                    value = Uri.UnescapeDataString(pair);
                }
                else
                {
                    key = Uri.UnescapeDataString(pair.Substring(0, equalDex));
                    value = Uri.UnescapeDataString(pair.Substring(equalDex + 1));
                }

                string existingValue;
                retVal[key] = retVal.TryGetValue(key, out existingValue)
                    ? string.Concat(existingValue, ",", value)
                    : value;
            }

            return retVal;
        }
    }
}
