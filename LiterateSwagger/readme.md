
# My API 

## Getting Started 
To build the SDKs for My API, simply [Install AutoRest](#Installing-AutoRest) and run:

> `Autorest.exe readme.md`

To see additional help and options, run:

> `Autorest.exe help readme.md`

### Installing AutoRest
AutoRest is most easily installed via the Node JS package `autorest`:

> npm install -g autorest 

For other options on installation see [Installing AutoRest](https://aka.ms/installing-autorest.md) on the AutoRest github page.

## Configuration for My API

``` yaml
version: 1.0.0-Nightly20170412  # miniumum version (inclusive)
input-file: 
  - example.md
  - exampleInline.md 

output-folder: $(base-folder)/generated
  
namespace: Microsoft.Azure.Example

csharp:
  output-folder: $(output-folder)/csharp

```

### Ruby generation is still experimental. Off by default.

use `-enable-ruby` on the cmdline. 


``` yaml enabled=$(enable-ruby) 
# enabled=$(enable-ruby) 
ruby:
  output-folder: $(output-folder)/ruby
  namespace: Azure::Example
``` 

## Directives 

We want to override the name of the `method-group` to just `Keys`

``` yaml
directive:
  - from: SearchManagement  # aka the example.md file
    where: $..paths[@..operationId="QueryKeys_*"]
    set:
      method-group: Keys
      
  - from: SearchManagementOther
    suppress-validations: 
      - TOO_MANY_PARAMETERS # I like parameters
```

### Special directives for debugging...

Only do this when `-debug` is specified in the cmdline.

``` yaml
# enabled=$(debug)
directive:
  - generate-trace-information: true

```

