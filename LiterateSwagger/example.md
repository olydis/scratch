# Search Management Client
* [General](#general)
* [Security](#security)
* [Operations on Query Keys](#operations-on-query-keys)
   * [List](#list)
      * [Description](#description)
   * [Model Definition: ListQueryKeysResult](#model-definition-listquerykeysresult)
      * [Description](#description-1)
      * [Property: value](#property-value)
   * [Model Definition: QueryKey](#model-definition-querykey)
      * [Description](#description-2)
      * [Property: name](#property-name)
      * [Property: key](#property-key)
* [Operations on Services](#operations-on-services)
   * [CreateOrUpdate](#createorupdate)
      * [Description](#description-3)
      * [Parameter: parameters](#parameter-parameters)
   * [Delete](#delete)
      * [Description](#description-4)
   * [List](#list-1)
      * [Description](#description-5)
   * [Model Definition: SearchServiceProperties](#model-definition-searchserviceproperties)
      * [Description](#description-6)
      * [Property: replicaCount](#property-replicacount)
      * [Property: partitionCount](#property-partitioncount)
   * [Model Definition: SearchServiceCreateOrUpdateParameters](#model-definition-searchservicecreateorupdateparameters)
      * [Description](#description-7)
      * [Property: location](#property-location)
      * [Property: tags](#property-tags)
      * [Property: properties](#property-properties)
   * [Model Definition: SearchServiceResource](#model-definition-searchserviceresource)
      * [Description](#description-8)
      * [Property: id](#property-id)
      * [Property: name](#property-name-1)
      * [Property: location](#property-location-1)
      * [Property: tags](#property-tags-1)
   * [Model Definition: SearchServiceListResult](#model-definition-searchservicelistresult)
      * [Description](#description-9)
      * [Property: value](#property-value-1)
* [Common Definitions](#common-definitions)
   * [Client Parameter: SubscriptionId](#client-parameter-subscriptionid)
   * [Client Parameter: ApiVersion](#client-parameter-apiversion)
   * [Method Parameter: ResourceGroupName](#method-parameter-resourcegroupname)
   * [Method Parameter: SearchServiceName](#method-parameter-searchservicename)
   * [Error Response](#error-response)

## General
This client that can be used to manage Azure Search services and API keys.

```yaml
swagger: '2.0'
info:
  title: SearchManagementClient
  description: '#/descriptions/???'
  version: '2015-02-28'
host: management.azure.com
schemes:
- https
consumes:
- application/json
produces:
- application/json
```

## Security
Makes the service usable in SwaggerUI.

```yaml
security:
- azure_auth:
  - user_impersonation
securityDefinitions:
  azure_auth:
    type: oauth2
    authorizationUrl: https://login.microsoftonline.com/common/oauth2/authorize
    flow: implicit
    description: Azure Active Directory OAuth2 Flow
    scopes:
      user_impersonation: impersonate your user account
```

## Operations on Query Keys

### List

#### Description
Returns the list of query API keys for the given Azure Search service.

```yaml
paths:
  '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{serviceName}/listQueryKeys':
    get:
      tags:
      - QueryKeys
      operationId: QueryKeys_List
      description: '#/descriptions/???'
      externalDocs:
        url: https://msdn.microsoft.com/library/azure/dn832701.aspx
      parameters:
      - '$ref': '#/parameters/ResourceGroupName'
      - '$ref': '#/parameters/SearchServiceName'
      - '$ref': '#/parameters/ApiVersion'
      - '$ref': '#/parameters/SubscriptionId'
      responses:
        '200':
          description: OK
          schema:
            '$ref': '#/definitions/ListQueryKeysResult'
        default:
          '$ref': '#/responses/error'
```

### Model Definition: ListQueryKeysResult

#### Description
Response containing the query API keys for a given Azure Search service.

#### Property: value
The query keys for the Azure Search service.

```yaml
definitions:
  ListQueryKeysResult:
    properties:
      value:
        readOnly: true
        type: array
        items:
          '$ref': '#/definitions/QueryKey'
        description: '#/descriptions/???'
    description: '#/descriptions/???'
```

### Model Definition: QueryKey

#### Description
Describes an API key for a given Azure Search service that has permissions for query operations only.

#### Property: name
The name of the query API key; may be empty.

#### Property: key
The value of the query API key.

```yaml
definitions:
  QueryKey:
    properties:
      name:
        readOnly: true
        type: string
        description: '#/descriptions/???'
      key:
        readOnly: true
        type: string
        description: '#/descriptions/???'
    description: '#/descriptions/???'
```

## Operations on Services

### CreateOrUpdate

#### Description
Creates or updates a Search service in the given resource group.
If the Search service already exists, all properties will be updated with the given values.

#### Parameter: parameters
The properties to set or update on the Search service.

```yaml
paths:
  '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{serviceName}':
    put:
      tags:
      - Services
      operationId: Services_CreateOrUpdate
      description: '#/descriptions/???'
      externalDocs:
        url: https://msdn.microsoft.com/library/azure/dn832687.aspx
      parameters:
      - '$ref': '#/parameters/ResourceGroupName'
      - '$ref': '#/parameters/SearchServiceName'
      - name: parameters
        in: body
        required: true
        schema:
          '$ref': '#/definitions/SearchServiceCreateOrUpdateParameters'
        description: '#/descriptions/???'
      - '$ref': '#/parameters/ApiVersion'
      - '$ref': '#/parameters/SubscriptionId'
      responses:
        '200':
          description: OK
          schema:
            '$ref': '#/definitions/SearchServiceResource'
        '201':
          description: Created
          schema:
            '$ref': '#/definitions/SearchServiceResource'
        default:
          '$ref': '#/responses/error'
```

### Delete

#### Description
Deletes a Search service in the given resource group, along with its associated resources.

```yaml
paths:
  '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices/{serviceName}':
    delete:
      tags:
      - Services
      operationId: Services_Delete
      description: '#/descriptions/???'
      externalDocs:
        url: https://msdn.microsoft.com/library/azure/dn832692.aspx
      parameters:
      - '$ref': '#/parameters/ResourceGroupName'
      - '$ref': '#/parameters/SearchServiceName'
      - '$ref': '#/parameters/ApiVersion'
      - '$ref': '#/parameters/SubscriptionId'
      responses:
        '200':
          description: OK
        '204':
          description: No Content
        '404':
          description: Not Found
        default:
          '$ref': '#/responses/error'
```

### List

#### Description
Returns a list of all Search services in the given resource group.

```yaml
paths:
  '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Search/searchServices':
    get:
      tags:
      - Services
      operationId: Services_List
      description: '#/descriptions/???'
      externalDocs:
        url: https://msdn.microsoft.com/library/azure/dn832688.aspx
      parameters:
      - '$ref': '#/parameters/ResourceGroupName'
      - '$ref': '#/parameters/ApiVersion'
      - '$ref': '#/parameters/SubscriptionId'
      responses:
        '200':
          description: OK
          schema:
            '$ref': '#/definitions/SearchServiceListResult'
        default:
          '$ref': '#/responses/error'
```

### Model Definition: SearchServiceProperties

#### Description
Defines properties of an Azure Search service that can be modified.

#### Property: replicaCount
The number of replicas in the Search service.

#### Property: partitionCount
The number of partitions in the Search service; if specified, it can be 1, 2, 3, 4, 6, or 12.

```yaml
definitions:
  SearchServiceProperties:
    properties:
      replicaCount:
        type: integer
        format: int32
        minimum: 1
        maximum: 6
        description: '#/descriptions/???'
      partitionCount:
        type: integer
        format: int32
        description: '#/descriptions/???'
    description: '#/descriptions/???'
```

### Model Definition: SearchServiceCreateOrUpdateParameters

#### Description
Properties that describe an Azure Search service.

#### Property: location
The geographic location of the Search service.

#### Property: tags
Tags to help categorize the Search service in the Azure Portal.

#### Property: properties
Properties of the Search service.

```yaml
definitions:
  SearchServiceCreateOrUpdateParameters:
    properties:
      location:
        type: string
        description: '#/descriptions/???'
      tags:
        type: object
        additionalProperties:
          type: string
        description: '#/descriptions/???'
      properties:
        '$ref': '#/definitions/SearchServiceProperties'
        description: '#/descriptions/???'
    description: '#/descriptions/???'
```

### Model Definition: SearchServiceResource

#### Description
Describes an Azure Search service and its current state.

#### Property: id
The resource Id of the Azure Search service.

#### Property: name
The name of the Search service.

#### Property: location
The geographic location of the Search service.

#### Property: tags
Tags to help categorize the Search service in the Azure Portal.

```yaml
definitions:
  SearchServiceResource:
    properties:
      id:
        readOnly: true
        type: string
        description: '#/descriptions/???'
      name:
        externalDocs:
          url: https://msdn.microsoft.com/library/azure/dn857353.aspx
        type: string
        description: '#/descriptions/???'
      location:
        type: string
        description: '#/descriptions/???'
      tags:
        type: object
        additionalProperties:
          type: string
        description: '#/descriptions/???'
    description: '#/descriptions/???'
```

### Model Definition: SearchServiceListResult

#### Description
Response containing a list of Azure Search services for a given resource group.

#### Property: value
The Search services in the resource group.

```yaml
definitions:
  SearchServiceListResult:
    properties:
      value:
        readOnly: true
        type: array
        items:
          '$ref': '#/definitions/SearchServiceResource'
        description: '#/descriptions/???'
    description: '#/descriptions/???'
```

## Common Definitions

### Client Parameter: SubscriptionId
Gets subscription credentials which uniquely identify Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
parameters:
  SubscriptionId:
    name: subscriptionId
    in: path
    required: true
    type: string
    description: '#/descriptions/???'
```

### Client Parameter: ApiVersion
The client API version.

```yaml
parameters:
  ApiVersion:
    name: api-version
    in: query
    required: true
    type: string
    description: '#/descriptions/???'
```

### Method Parameter: ResourceGroupName
The name of the resource group within the current subscription.

```yaml
parameters:
  ResourceGroupName:
    name: resourceGroupName
    in: path
    required: true
    type: string
    x-ms-parameter-location: method
    description: '#/descriptions/???'
```

### Method Parameter: SearchServiceName
The name of the Search service to operate on.

```yaml
parameters:
  SearchServiceName:
    name: serviceName
    in: path
    required: true
    type: string
    x-ms-parameter-location: method
    description: '#/descriptions/???'
```

### Error Response

The default response will be deserialized as per the Error defintion and will be part of the exception.

```yaml
definitions:
  Error:
    type: object
    properties:
      code:
        type: integer
      message:
        type: string
responses:
  error:
    description: OK
    schema:
      '$ref': '#/definitions/Error'
```