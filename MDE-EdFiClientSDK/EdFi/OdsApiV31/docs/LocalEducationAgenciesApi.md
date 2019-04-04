# EdFi.OdsApi.Sdk.Apis.All.LocalEducationAgenciesApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteLocalEducationAgencyById**](LocalEducationAgenciesApi.md#deletelocaleducationagencybyid) | **DELETE** /ed-fi/localEducationAgencies/{id} | Deletes an existing resource using the resource identifier.
[**GetLocalEducationAgencies**](LocalEducationAgenciesApi.md#getlocaleducationagencies) | **GET** /ed-fi/localEducationAgencies | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetLocalEducationAgenciesById**](LocalEducationAgenciesApi.md#getlocaleducationagenciesbyid) | **GET** /ed-fi/localEducationAgencies/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostLocalEducationAgency**](LocalEducationAgenciesApi.md#postlocaleducationagency) | **POST** /ed-fi/localEducationAgencies | Creates or updates resources based on the natural key values of the supplied resource.
[**PutLocalEducationAgency**](LocalEducationAgenciesApi.md#putlocaleducationagency) | **PUT** /ed-fi/localEducationAgencies/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletelocaleducationagencybyid"></a>
# **DeleteLocalEducationAgencyById**
> void DeleteLocalEducationAgencyById (string id, string ifMatch = null)

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
    public class DeleteLocalEducationAgencyByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalEducationAgenciesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteLocalEducationAgencyById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalEducationAgenciesApi.DeleteLocalEducationAgencyById: " + e.Message );
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

<a name="getlocaleducationagencies"></a>
# **GetLocalEducationAgencies**
> List<EdFiLocalEducationAgency> GetLocalEducationAgencies (int? offset = null, int? limit = null, bool? totalCount = null, int? localEducationAgencyId = null, int? educationServiceCenterId = null, int? parentLocalEducationAgencyId = null, int? stateEducationAgencyId = null, string charterStatusDescriptor = null, string localEducationAgencyCategoryDescriptor = null)

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
    public class GetLocalEducationAgenciesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalEducationAgenciesApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var localEducationAgencyId = 56;  // int? | The identifier assigned to a local education agency. (optional) 
            var educationServiceCenterId = 56;  // int? | The identifier assigned to an education service center. (optional) 
            var parentLocalEducationAgencyId = 56;  // int? | The identifier assigned to a local education agency. (optional) 
            var stateEducationAgencyId = 56;  // int? | The identifier assigned to a state education agency. (optional) 
            var charterStatusDescriptor = charterStatusDescriptor_example;  // string | A school or agency providing free public elementary or secondary education to eligible students under a specific charter granted by the state legislature or other appropriate authority and designated by such authority to be a charter school. (optional) 
            var localEducationAgencyCategoryDescriptor = localEducationAgencyCategoryDescriptor_example;  // string | The category of local education agency/district. For example: Independent or Charter. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiLocalEducationAgency&gt; result = apiInstance.GetLocalEducationAgencies(offset, limit, totalCount, localEducationAgencyId, educationServiceCenterId, parentLocalEducationAgencyId, stateEducationAgencyId, charterStatusDescriptor, localEducationAgencyCategoryDescriptor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalEducationAgenciesApi.GetLocalEducationAgencies: " + e.Message );
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
 **localEducationAgencyId** | **int?**| The identifier assigned to a local education agency. | [optional] 
 **educationServiceCenterId** | **int?**| The identifier assigned to an education service center. | [optional] 
 **parentLocalEducationAgencyId** | **int?**| The identifier assigned to a local education agency. | [optional] 
 **stateEducationAgencyId** | **int?**| The identifier assigned to a state education agency. | [optional] 
 **charterStatusDescriptor** | **string**| A school or agency providing free public elementary or secondary education to eligible students under a specific charter granted by the state legislature or other appropriate authority and designated by such authority to be a charter school. | [optional] 
 **localEducationAgencyCategoryDescriptor** | **string**| The category of local education agency/district. For example: Independent or Charter. | [optional] 

### Return type

[**List<EdFiLocalEducationAgency>**](EdFiLocalEducationAgency.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlocaleducationagenciesbyid"></a>
# **GetLocalEducationAgenciesById**
> EdFiLocalEducationAgency GetLocalEducationAgenciesById (string id, string ifNoneMatch = null)

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
    public class GetLocalEducationAgenciesByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalEducationAgenciesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiLocalEducationAgency result = apiInstance.GetLocalEducationAgenciesById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalEducationAgenciesApi.GetLocalEducationAgenciesById: " + e.Message );
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

[**EdFiLocalEducationAgency**](EdFiLocalEducationAgency.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postlocaleducationagency"></a>
# **PostLocalEducationAgency**
> void PostLocalEducationAgency (EdFiLocalEducationAgency localEducationAgency)

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
    public class PostLocalEducationAgencyExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalEducationAgenciesApi();
            var localEducationAgency = new EdFiLocalEducationAgency(); // EdFiLocalEducationAgency | The JSON representation of the \"localEducationAgency\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostLocalEducationAgency(localEducationAgency);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalEducationAgenciesApi.PostLocalEducationAgency: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **localEducationAgency** | [**EdFiLocalEducationAgency**](EdFiLocalEducationAgency.md)| The JSON representation of the \&quot;localEducationAgency\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putlocaleducationagency"></a>
# **PutLocalEducationAgency**
> void PutLocalEducationAgency (string id, EdFiLocalEducationAgency localEducationAgency, string ifMatch = null)

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
    public class PutLocalEducationAgencyExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocalEducationAgenciesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var localEducationAgency = new EdFiLocalEducationAgency(); // EdFiLocalEducationAgency | The JSON representation of the \"localEducationAgency\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutLocalEducationAgency(id, localEducationAgency, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocalEducationAgenciesApi.PutLocalEducationAgency: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **localEducationAgency** | [**EdFiLocalEducationAgency**](EdFiLocalEducationAgency.md)| The JSON representation of the \&quot;localEducationAgency\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

