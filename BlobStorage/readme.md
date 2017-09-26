# Blob Storage
    
> see https://aka.ms/autorest


## Configuration

``` yaml
openapi-type: data-plane
input-file:
- blob-storage-out.yaml
csharp:
  azure-arm: true
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
            .replace(" : ServiceClient", " : ServiceClientX")
            .replace(" : IServiceOperations", " : IServiceOperationsX")
            .replace(/Credentials\.InitializeServiceClient\(this\);/g, "// Credentials.InitializeServiceClient(this);")
            .replace(/System\.Net\.Http\.HttpCompletionOption\.ResponseHeadersRead, /g, "")
```