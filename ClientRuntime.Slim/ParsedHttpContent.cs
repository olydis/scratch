// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Rest.ClientRuntime.Slim
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class ParsedHttpContent<T> : HttpContent
    {
        public T ParsedObject { get; private set; }

        public ParsedHttpContent(T parsedObject)
        {
            this.ParsedObject = parsedObject;
        }

        protected override bool TryComputeLength(out long length) => throw new InvalidOperationException("Cannot compute length of parsed content.");
        protected override Task SerializeToStreamAsync(Stream s, TransportContext tc) => throw new InvalidOperationException("Cannot serialize parsed content back to stream.");
    }
}
