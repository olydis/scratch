﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Rest.ClientRuntime.RequestPolicy
{
    // The Pipeline interface represents an ordered list of Factory objects and an object implementing the HTTPSender interface.
    // You construct a Pipeline by calling the pipeline.NewPipeline function. To send an HTTP request, call pipeline.NewRequest
    // and then call Pipeline's Do method passing a context, the request, and a method-specific Factory (or nil). Passing a
    // method-specific Factory allows this one call to Do to inject a Policy into the linked-list. The policy is injected where
    // the MethodFactoryMarker (see the pipeline.MethodFactoryMarker function) is in the slice of Factory objects.
    //
    // When Do is called, the Pipeline object asks each Factory object to construct its Policy object and adds each Policy to a linked-list.
    // THen, Do sends the Context and Request through all the Policy objects. The final Policy object sends the request over the network
    // (via the HTTPSender object passed to NewPipeline) and the response is returned backwards through all the Policy objects.
    // Since Pipeline and Factory objects are immutable, you typically create 1 Pipeline object and reuse it to make many HTTP requests.
    public class Pipeline
    {
        private class DefaultHttpClientFactory : IFactory
        {
            private IHttpSender sender;

            public DefaultHttpClientFactory(IHttpSender sender)
            {
                this.sender = sender;
            }

            public DefaultHttpClientFactory(): this(new HttpClientSender()) { }

            private sealed class DefaultHttpClientPolicy : IPolicy
            {
                public PolicyNode Node { get; private set; }
                public IHttpSender Sender { get; private set; }

                public DefaultHttpClientPolicy(PolicyNode node, IHttpSender sender)
                {
                    this.Node = node;
                    this.Sender = new HttpClientSender();
                }

                public async Task<HttpResponseMessage> SendAsync(Context ctx, HttpRequestMessage request)
                {
                    // request.Request = request.WithContext(ctx)

                    return await Sender.SendAsync(request, ctx.CancellationToken);
                }
            }

            public IPolicy Create(PolicyNode node)
                => new DefaultHttpClientPolicy(node, sender);
        }

        public IEnumerable<IFactory> Factories { get; private set; }
        public PipelineOptions Options { get; private set; }

        public Pipeline(IEnumerable<IFactory> factories)
            : this(
                factories,
                new PipelineOptions(
                    new DefaultHttpClientFactory(),
                    new LogOptions((level, message) => {}, LogSeverity.None)
                )
            ) { }

        public Pipeline(IEnumerable<IFactory> factories, HttpClient client)
            : this(
                factories,
                new PipelineOptions(
                    new DefaultHttpClientFactory(new HttpClientSender(client)),
                    new LogOptions((level, message) => {}, LogSeverity.None)
                )
            ) { }

        // NewPipeline creates a new immutable Pipeline object from the slice of Factory objects and the specified HTTPSender.
        // If sender is nil, then a default (zero-value) http.Client is created for this Pipeline object.
        public Pipeline(IEnumerable<IFactory> factories, PipelineOptions options)
        {
            this.Factories = factories;
            this.Options = options;
        }

        // SendAsync is called for each and every HTTP request. It tells each Factory to create its own (mutable) Policy object
        // replacing a MethodFactoryMarker factory (if it exists) with the methodFactory passed in. Then, the Context and Request
        // are sent through the pipeline of Policy objects (which can transform the Request's URL/query parameters/headers) and
        // ultimately sends the transformed HTTP request over the network.
        public Task<HttpResponseMessage> SendAsync(Context ctx, IFactory methodFactory, HttpRequestMessage request)
        {
            // defer request.close()   ... so Dispose request afterwards? not sure that's expected by C# people but maybe required for "determinism" of GC work?
            return NewPolicies(methodFactory).SendAsync(ctx, request);
        }

        private IPolicy NewPolicies(IFactory methodFactory)
        {
            // The last Policy is the one that actually sends the request over the wire and gets the response.
            // It is overridable via the Options' HTTPSender field.
            var node = new PolicyNode(this, null);
            node = new PolicyNode(this, Options.HttpSender.Create(node));

            // Walk over the slice of Factory objects
            int markers = 0;

            foreach (var factory in Factories)
            {
                if (factory is MethodFactoryMarker)
                {
                    markers++;
       
                    if (markers > 1 )
                    {
                        throw new Exception("MethodFactoryMarker can only appear once in the pipeline");
                    }
                    if (methodFactory != null)
                    {
                        // Replace MethodFactoryMarker with passed-in methodFactory
                        node = new PolicyNode(this, methodFactory.Create(node));
                    }
                }
                else
                {
                    // Use the slice's Factory to construct its Policy
                    node = new PolicyNode(this, factory.Create(node));
                }
            }

            // Each Factory has created its Policy
            if (markers == 0 && methodFactory != null)
            {
                throw new Exception("Non-nil methodFactory requires MethodFactoryMarker in the pipeline");
            }
            return node.Next; // Return head of the Policy object linked-list
        }
    }
}
