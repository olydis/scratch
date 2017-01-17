// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 

using Microsoft.Rest;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using /*<*/Dummy/*></clientNamespace>*/;
using Microsoft.Rest.Azure;

//<dump/>

namespace /*<*/Dummy/*></clientNamespace>*/.Tests
{
    public class /*<*/BugDummy/*></className>*/ : TestBase
    {
        private static readonly string recordedRequest = /*<*/"recordedRequest"/*></recordedRequest>*/;
        private static readonly string recordedResponse = /*<*/"recordedResponse"/*></recordedResponse>*/;

        public /*<*/BugDummy/*></className>*/() : base(recordedRequest, recordedResponse)
        { }

        [Fact]
        public async Task Execute()
        {
            // start server
            StartServer();

            // create and use client
            var credentials = new TokenCredentials("TOKEN", Guid.NewGuid().ToString());
            var serviceClient = /*<*/(dynamic)null/*></clientConstructorCall>*/;
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                //<call/>
                //<throwIfExpectedSuccess/>
            }
            catch (CloudException e)
            {
                //<throwIfExpectedFail/>
            }

            // stop server
            StopServer();
        }
    }
}