using System;
using System.Threading;

namespace Microsoft.Rest.RequestPolicy
{
    public class Context
    {
        public CancellationToken CancellationToken { get; private set; }

        public Context() : this(CancellationToken.None) { }

        public Context(CancellationToken cancellationToken) => CancellationToken = cancellationToken;

        public Context WithCancellationToken(CancellationToken token)
            => new Context(CancellationTokenSource.CreateLinkedTokenSource(CancellationToken, token).Token);

        public Context WithTimeout(TimeSpan timeout, out Func<bool> isTimeout)
        {
            var tokenSource = new CancellationTokenSource();
            tokenSource.CancelAfter(timeout);
            isTimeout = () => tokenSource.IsCancellationRequested;
            return WithCancellationToken(tokenSource.Token);
        }

        public Context WithCancel(out Action cancel)
        {
            var tokenSource = new CancellationTokenSource();
            cancel = () => tokenSource.Cancel();
            return WithCancellationToken(tokenSource.Token);
        }
    }
}
