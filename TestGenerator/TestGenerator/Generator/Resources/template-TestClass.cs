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

    public /*<*/BugDummy/*></className>*/() : base(recordedRequest, recordedResponse, /*<*/null/*></accountName>*/)
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = /*<*/ (dynamic) null /*></clientConstructorCall>*/;
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                //<call/>
                //<assertSuccess/>
                //<validation/>
            }
            catch (CloudException)
            {
                //<assertFail/>

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                //<assertFail/>
            }
            catch (ArgumentException)
            {
                //<assertFail/>
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}