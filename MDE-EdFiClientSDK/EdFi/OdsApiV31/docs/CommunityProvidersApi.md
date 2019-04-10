# EdFi.OdsApi.Sdk.Apis.All.CommunityProvidersApi

All URIs are relative to *https://localhost:56641/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCommunityProviderById**](CommunityProvidersApi.md#deletecommunityproviderbyid) | **DELETE** /ed-fi/communityProviders/{id} | Deletes an existing resource using the resource identifier.
[**GetCommunityProviders**](CommunityProvidersApi.md#getcommunityproviders) | **GET** /ed-fi/communityProviders | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetCommunityProvidersById**](CommunityProvidersApi.md#getcommunityprovidersbyid) | **GET** /ed-fi/communityProviders/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostCommunityProvider**](CommunityProvidersApi.md#postcommunityprovider) | **POST** /ed-fi/communityProviders | Creates or updates resources based on the natural key values of the supplied resource.
[**PutCommunityProvider**](CommunityProvidersApi.md#putcommunityprovider) | **PUT** /ed-fi/communityProviders/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletecommunityproviderbyid"></a>
# **DeleteCommunityProviderById**
> void DeleteCommunityProviderById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.All;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.All;

namespace Example
{
    public class DeleteCommunityProviderByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommunityProvidersApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteCommunityProviderById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityProvidersApi.DeleteCommunityProviderById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **ifMatch** | **string**| The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcommunityproviders"></a>
# **GetCommunityProviders**
> List<EdFiCommunityProvider> GetCommunityProviders (int? offset = null, int? limit = null, bool? totalCount = null, int? communityProviderId = null, int? communityOrganizationId = null, string providerCategoryDescriptor = null, string providerProfitabilityDescriptor = null, string providerStatusDescriptor = null, bool? licenseExemptIndicator = null, bool? schoolIndicator = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.All;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.All;

namespace Example
{
    public class GetCommunityProvidersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommunityProvidersApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var communityProviderId = 56;  // int? | The identifier assigned to a CommunityProvider. (optional) 
            var communityOrganizationId = 56;  // int? | The identifier assigned to a CommunityOrganization. (optional) 
            var providerCategoryDescriptor = providerCategoryDescriptor_example;  // string | Indicates the category of the provider. (optional) 
            var providerProfitabilityDescriptor = providerProfitabilityDescriptor_example;  // string | Indicates the profitability status of the provider. (optional) 
            var providerStatusDescriptor = providerStatusDescriptor_example;  // string | Indicates the status of the provider. (optional) 
            var licenseExemptIndicator = true;  // bool? | An indication of whether the provider is exempt from having a license. (optional) 
            var schoolIndicator = true;  // bool? | An indication of whether the community provider is a school. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiCommunityProvider&gt; result = apiInstance.GetCommunityProviders(offset, limit, totalCount, communityProviderId, communityOrganizationId, providerCategoryDescriptor, providerProfitabilityDescriptor, providerStatusDescriptor, licenseExemptIndicator, schoolIndicator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityProvidersApi.GetCommunityProviders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **int?**| Indicates how many items should be skipped before returning results. | [optional] [default to 0]
 **limit** | **int?**| Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25]
 **totalCount** | **bool?**| Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false]
 **communityProviderId** | **int?**| The identifier assigned to a CommunityProvider. | [optional] 
 **communityOrganizationId** | **int?**| The identifier assigned to a CommunityOrganization. | [optional] 
 **providerCategoryDescriptor** | **string**| Indicates the category of the provider. | [optional] 
 **providerProfitabilityDescriptor** | **string**| Indicates the profitability status of the provider. | [optional] 
 **providerStatusDescriptor** | **string**| Indicates the status of the provider. | [optional] 
 **licenseExemptIndicator** | **bool?**| An indication of whether the provider is exempt from having a license. | [optional] 
 **schoolIndicator** | **bool?**| An indication of whether the community provider is a school. | [optional] 

### Return type

[**List<EdFiCommunityProvider>**](EdFiCommunityProvider.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcommunityprovidersbyid"></a>
# **GetCommunityProvidersById**
> EdFiCommunityProvider GetCommunityProvidersById (string id, string ifNoneMatch = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.All;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.All;

namespace Example
{
    public class GetCommunityProvidersByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommunityProvidersApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiCommunityProvider result = apiInstance.GetCommunityProvidersById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityProvidersApi.GetCommunityProvidersById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **ifNoneMatch** | **string**| The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. | [optional] 

### Return type

[**EdFiCommunityProvider**](EdFiCommunityProvider.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcommunityprovider"></a>
# **PostCommunityProvider**
> void PostCommunityProvider (EdFiCommunityProvider communityProvider)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error (you must use a PUT operation to update a resource by \"id\"). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.All;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.All;

namespace Example
{
    public class PostCommunityProviderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommunityProvidersApi();
            var communityProvider = new EdFiCommunityProvider(); // EdFiCommunityProvider | The JSON representation of the \"communityProvider\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostCommunityProvider(communityProvider);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityProvidersApi.PostCommunityProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **communityProvider** | [**EdFiCommunityProvider**](EdFiCommunityProvider.md)| The JSON representation of the \&quot;communityProvider\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcommunityprovider"></a>
# **PutCommunityProvider**
> void PutCommunityProvider (string id, EdFiCommunityProvider communityProvider, string ifMatch = null)

Updates or creates a resource based on the resource identifier.

The PUT operation is used to update or create a resource by identifier. If the resource doesn't exist, the resource will be created using that identifier. Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource \"id\" is provided in the JSON body, it will be ignored as well.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.All;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.All;

namespace Example
{
    public class PutCommunityProviderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommunityProvidersApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var communityProvider = new EdFiCommunityProvider(); // EdFiCommunityProvider | The JSON representation of the \"communityProvider\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutCommunityProvider(id, communityProvider, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityProvidersApi.PutCommunityProvider: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **communityProvider** | [**EdFiCommunityProvider**](EdFiCommunityProvider.md)| The JSON representation of the \&quot;communityProvider\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

