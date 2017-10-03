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
```

``` yaml
use: C:\work\oneautorest\autorest.csharp\

directive:
  - from: source-file-csharp
    where: $
    transform: >-
        $ = $
            .replace(", IAzureClient", "")
            .replace(/Credentials\.InitializeServiceClient\(this\);/g, "// Credentials.InitializeServiceClient(this);")
            .replace(/throw new System.ArgumentNullException\("credentials"\);/g, `// throw new System.ArgumentNullException("credentials");`)
            .replace(/System\.Net\.Http\.HttpCompletionOption\.ResponseHeadersRead, /g, "")
        if ($.includes(" : ServiceClient<"))
          $ = $
            .replace("(params DelegatingHandler[] handlers) : base(handlers)", "() : base()")
            .replace(/\/\/\/ <param name='handlers'>\s*\/\/\/.*\s*\/\/\/ <\/param>\s*/, "")
            .replace(/(\s*\/\/\/.*)+\s*public .*params.*\s*.*\s*.*\s*\}/g, "")
```