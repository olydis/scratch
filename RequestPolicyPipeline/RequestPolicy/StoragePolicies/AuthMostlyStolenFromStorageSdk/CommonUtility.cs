//-----------------------------------------------------------------------
// <copyright file="CommonUtility.cs" company="Microsoft">
//    Copyright 2013 Microsoft Corporation
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//      http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>
//-----------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Storage.Core.Util
{
    using Microsoft.WindowsAzure.Storage.Auth;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;
    using System.Xml;

#if WINDOWS_DESKTOP 
    using System.Net;
    using Microsoft.WindowsAzure.Storage.Shared.Protocol;
#endif

    internal static class CommonUtility
    {
        /// <summary>
        /// Gets the first header value or <c>null</c> if no header values exist.
        /// </summary>
        /// <typeparam name="T">The type of header objects contained in the enumerable.</typeparam>
        /// <param name="headerValues">An enumerable that contains header values.</param>
        /// <returns>The first header value or <c>null</c> if no header values exist.</returns>
        public static string GetFirstHeaderValue<T>(IEnumerable<T> headerValues) where T : class
        {
            if (headerValues != null)
            {
                T result = headerValues.FirstOrDefault();
                if (result != null)
                {
                    return result.ToString().TrimStart();
                }
            }

            return null;
        }
    }
}