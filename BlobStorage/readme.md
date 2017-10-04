# Blob Storage
    
> see https://aka.ms/autorest


## Configuration

``` yaml
openapi-type: data-plane
input-file:
- blob-storage-out.yaml
csharp:
  override-client-name: AzureBlobStorageClient
  license-header: MICROSOFT_MIT_NO_VERSION
  namespace: BlobStorageTest.Client
  output-folder: ./BlobStorageTest/Client
  clear-output-folder: true
  enable-xml: true
  sync-methods: none
```

``` yaml
use: C:\work\oneautorest\autorest.csharp\

directive:
  - from: source-file-csharp
    where: $
    transform: >-
        $ = $
            .replace(", IAzureClient", "")
            // normalize SendAsync call (stream version specifies additional param)
            .replace(/System\.Net\.Http\.HttpCompletionOption\.ResponseHeadersRead, /g, "")
            // remove tracing
            .replace(/if *\(_shouldTrace\)\s*.*\{(\s*.*)*?\s*\}/g, "")
            .replace(/bool _shouldTrace = ServiceClientTracing\.IsEnabled;/g, "")
            .replace(/string _invocationId = null;/g, "")
            // deserialization as continuation
            .replace(/((public|internal) async Task<(.*?)> .*(\s.*?)*?)_httpResponse = await Client\.HttpClient\.SendAsync\(_httpRequest, cancellationToken\)\.ConfigureAwait\(false\);((\s.*)*?\s*return _result;)/g, (_, prefix, __, resultType, ___, suffix) => `${prefix.replace("HttpResponseMessage _httpResponse = null;", "")}var result = await Client.SendAsync<${resultType}>(_httpRequest, async _httpResponse => {${suffix.replace(/\n/g, "\n    ")}\n            }, cancellationToken).ConfigureAwait(false);\n            return (result.Content as ParsedHttpContent<${resultType}>).ParsedObject;`)
        if ($.includes(" : ServiceClient<"))
          $ = $
            // simplify ctor 1
            .replace("(params DelegatingHandler[] handlers) : base(handlers)", "() : base()")
            // ...also remove its params docs
            .replace(/\/\/\/ <param name='handlers'>\s*\/\/\/.*\s*\/\/\/ <\/param>\s*/, "")
            // remove ctor 2
            .replace(/(\s*\/\/\/.*)+\s*public .*params.*\s*.*\s*.*\s*\}/g, "")
```