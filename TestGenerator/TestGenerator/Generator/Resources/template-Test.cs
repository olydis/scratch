// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 

using Microsoft.Rest;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;
using /*<*/Dummy/*></clientNamespace>*/;
using /*<*/Dummy/*></clientNamespaceModels>*/;
using Microsoft.Rest.Azure;

//<dump disabled/>

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
                //<assertSuccess/>
//<validation/>
            }
            catch (CloudException e)
            {
                //<assertFail/>

                // TODO: validate e.Body or similar?
            }

            // stop server
            StopServer();
        }
    }
}