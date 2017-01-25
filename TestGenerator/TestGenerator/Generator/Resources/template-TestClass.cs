/*<*/using Microsoft.Rest;/*></rem>*/
/*<*/using System;/*></rem>*/
/*<*/using System.Diagnostics;/*></rem>*/
/*<*/using System.Threading;/*></rem>*/
/*<*/using System.Threading.Tasks;/*></rem>*/
/*<*/using Xunit;/*></rem>*/
/*<*/using Dummy.Tests;/*></rem>*/
/*<*/using Microsoft.Rest.Azure;/*></rem>*/

//<dump disabled/>

public class /*<*/BugDummy/*></className>*/ : TestBase
{
    private static readonly string recordedRequest = /*<*/"recordedRequest"/*></recordedRequest>*/;
    private static readonly string recordedResponse = /*<*/"recordedResponse"/*></recordedResponse>*/;

    public /*<*/BugDummy/*></className>*/() : base(recordedRequest, recordedResponse)
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var credentials = new TokenCredentials("TOKEN", Guid.NewGuid().ToString());
            var serviceClient = /*<*/ (dynamic) null /*></clientConstructorCall>*/;
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(10000).Token;
                //<call/>
                //<assertSuccess/>
                //<validation/>
            }
            catch (CloudException)
            {
                //<assertFail/>

                // TODO: validate e.Body or similar?
            }
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}