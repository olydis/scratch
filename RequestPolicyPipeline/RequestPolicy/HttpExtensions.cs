using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;

namespace Microsoft.Rest.RequestPolicy
{
    public static class HttpExtensions
    {
        public static string Format(this HttpRequestMessage request)
            => $"=====> REQUEST: {request.Method} {request.RequestUri}\n{request.Headers.Format()}";
        public static string Format(this HttpResponseMessage response)
            => /* TODO response.Format() +*/ $"=====> RESPONSE: Status={response.StatusCode}\n{response.Headers.Format()}";

        public static string Format(this HttpHeaders headers)
            => !headers.Any()
            ? "   (no headers)\n"
            : string.Concat(headers.OrderBy(h => h.Key).Select(h => $"   {h.Key}: {string.Join(", ", h.Value)}\n"));
    }
}
