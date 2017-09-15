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