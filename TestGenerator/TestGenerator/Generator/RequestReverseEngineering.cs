﻿using AutoRest.Core.Logging;
using AutoRest.Core.Model;
using AutoRest.CSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace TestGenerator.Generator
{
    static class RequestReverseEngineering
    {
        private static bool TryAddParameterValue(string name, string value, ParameterLocation location, Method method, Dictionary<string, string> args)
        {
            // param exists? and matches value in case it is a constant?
            var param = method.Parameters.FirstOrDefault(p => p.Location == location && p.SerializedName == name);
            if (param == null || (param.IsConstant && param.DefaultValue != value))
            {
                return false;
            }

            args[name] = value;
            return true;
        }

        private static Dictionary<string, string> MatchMethodAgainstRequest(Method method, string httpMethod, Uri url, Dictionary<string, string> headers)
        {
            // check HTTP method
            if (method.HttpMethod.ToString().ToLowerInvariant() != httpMethod.ToLowerInvariant())
            {
                return null;
            }

            var args = new Dictionary<string, string>();
            
            // EXTRACT ACCOUNT NAME
            string pathPrefixRegex = "";
            var accountNameUrl = Regex.Match(url.Host, @"(?<accountName>[^/]*)\.blob\.core\.windows\.net");
            if (accountNameUrl.Success) // get accountname differently if 
            {
                TryAddParameterValue("accountName", HttpUtility.UrlDecode(accountNameUrl.Groups["accountName"].Value), ParameterLocation.Path, method, args);
            }
            else
            {
                pathPrefixRegex = @"\/(?<accountName>[^/]*)";
            }

            // match local path
            var pathPattern = Regex.Replace(method.Url.Value.TrimEnd('/'), @"\{(?<key>[^}]*)\}", "(?<${key}>[^/]+)");
            var pathRegex = new Regex($"^{pathPrefixRegex}{pathPattern}$");
            var pathMatch = pathRegex.Match(url.LocalPath.TrimEnd('/'));
            if (!pathMatch.Success)
            {
                return null;
            }

            // extract path params
            var pathParams = pathRegex.GetGroupNames().Where(paramName => !Regex.Match(paramName, @"^\d+$").Success);
            foreach (var paramName in pathParams)
                if (!TryAddParameterValue(paramName, HttpUtility.UrlDecode(pathMatch.Groups[paramName].Value), ParameterLocation.Path, method, args))
                    return null;
            // required path params missing?
            if (method.Parameters.Any(p => p.Location == ParameterLocation.Path && p.IsRequired && !args.ContainsKey(p.SerializedName)))
                return null;

            // extract query params
            var queryParams = Regex.Matches(url.Query, @"[?&](?<key>[^=]*)=(?<value>[^&#]*)").OfType<Match>();
            foreach (var queryParam in queryParams)
                TryAddParameterValue(queryParam.Groups["key"].Value, HttpUtility.UrlDecode(queryParam.Groups["value"].Value), ParameterLocation.Query, method, args);
            // required query params missing?
            if (method.Parameters.Any(p => p.Location == ParameterLocation.Query && p.IsRequired && !args.ContainsKey(p.SerializedName)))
                return null;

            // extract header params
            foreach (var headerParam in headers)
                TryAddParameterValue(headerParam.Key, headerParam.Value, ParameterLocation.Header, method, args);
            // required header params missing?
            if (method.Parameters.Any(p => p.Location == ParameterLocation.Header && p.IsRequired && !args.ContainsKey(p.SerializedName)))
                return null;

            return args;
        }

        public static ServiceCallInfo DetermineServiceCall(string testId, string recordedRequest, CodeModel serviceModel, Regex urlFilter)
        {
            // parse
            string intro;
            Dictionary<string, string> headers;
            string body;
            Utilities.ParseRawHttpMessage(recordedRequest, out intro, out headers, out body);

            var introParts = intro.Split();
            var method = introParts[0].ToLowerInvariant();
            var url = new Uri(introParts[1]);
            if (!urlFilter.Match(url.OriginalString).Success)
            {
                Logger.Instance.Log(Category.Info, $"{testId}: Dropping `{url}` (did not match filter)");
                return null;
            }

            // match
            var candids = serviceModel.Methods
                .OfType<MethodCs>()
                .SelectMany(m => method == "get" || method == "head"
                    ? new[]
                    {   // SPECIAL DOOHICKEY for Blob Storage: HEAD/GET both allowed on some operations
                        new ServiceCallInfo { Method = m, Params = MatchMethodAgainstRequest(m, "get", url, headers) },
                        new ServiceCallInfo { Method = m, Params = MatchMethodAgainstRequest(m, "head", url, headers) }
                    }
                    : new[]
                    {
                        new ServiceCallInfo { Method = m, Params = MatchMethodAgainstRequest(m, method, url, headers) }
                    })
                .Where(x => x.Params != null)
                .ToList();

            // select candidate service call
            if (candids.Count == 0)
            {
                Logger.Instance.Log(Category.Error, $"{testId}: Could not determine method for `{method} {url}`");
                return null;
            }
            if (candids.Count > 1)
            {
                candids = candids.OrderByDescending(x => x.Method.Parameters.Count(p => p.Location == ParameterLocation.Query && p.IsRequired)).ToList();
                Logger.Instance.Log(Category.Warning, $"{testId}: Found multiple candidates, will choose first (most required query params): `{string.Join(", ", candids.Select(x => x.Method.Group + "_" + x.Method.Name))}`");
            }
            var serviceCall = candids.First();

            // populate body param
            var bodyParam = serviceCall.Method.Parameters.FirstOrDefault(p => p.Location == ParameterLocation.Body);
            if (bodyParam != null)
            {
                serviceCall.Params[bodyParam.SerializedName] = body.TrimStart();
            }
            else if (body.Length > 0)
            {
                Logger.Instance.Log(Category.Warning, $"{testId}: Found non-empty body but selected a service call without a body parameter.");
            }
            
            return serviceCall;
        }
    }
}
