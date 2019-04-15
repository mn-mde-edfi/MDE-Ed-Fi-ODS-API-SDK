# EdFi.OdsApi.Sdk.Apis.MN.AncestryEthnicOriginDescriptorsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAncestryEthnicOriginDescriptorById**](AncestryEthnicOriginDescriptorsApi.md#deleteancestryethnicorigindescriptorbyid) | **DELETE** /MN/ancestryEthnicOriginDescriptors/{id} | Deletes an existing resource using the resource identifier.
[**GetAncestryEthnicOriginDescriptors**](AncestryEthnicOriginDescriptorsApi.md#getancestryethnicorigindescriptors) | **GET** /MN/ancestryEthnicOriginDescriptors | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetAncestryEthnicOriginDescriptorsById**](AncestryEthnicOriginDescriptorsApi.md#getancestryethnicorigindescriptorsbyid) | **GET** /MN/ancestryEthnicOriginDescriptors/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostAncestryEthnicOriginDescriptor**](AncestryEthnicOriginDescriptorsApi.md#postancestryethnicorigindescriptor) | **POST** /MN/ancestryEthnicOriginDescriptors | Creates or updates resources based on the natural key values of the supplied resource.
[**PutAncestryEthnicOriginDescriptor**](AncestryEthnicOriginDescriptorsApi.md#putancestryethnicorigindescriptor) | **PUT** /MN/ancestryEthnicOriginDescriptors/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteancestryethnicorigindescriptorbyid"></a>
# **DeleteAncestryEthnicOriginDescriptorById**
> void DeleteAncestryEthnicOriginDescriptorById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.MN;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.MN;

namespace Example
{
    public class DeleteAncestryEthnicOriginDescriptorByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AncestryEthnicOriginDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteAncestryEthnicOriginDescriptorById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AncestryEthnicOriginDescriptorsApi.DeleteAncestryEthnicOriginDescriptorById: " + e.Message );
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

<a name="getancestryethnicorigindescriptors"></a>
# **GetAncestryEthnicOriginDescriptors**
> List<MnAncestryEthnicOriginDescriptor> GetAncestryEthnicOriginDescriptors (int? offset = null, int? limit = null, bool? totalCount = null, int? ancestryEthnicOriginDescriptorId = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.MN;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.MN;

namespace Example
{
    public class GetAncestryEthnicOriginDescriptorsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AncestryEthnicOriginDescriptorsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var ancestryEthnicOriginDescriptorId = 56;  // int? | A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;MnAncestryEthnicOriginDescriptor&gt; result = apiInstance.GetAncestryEthnicOriginDescriptors(offset, limit, totalCount, ancestryEthnicOriginDescriptorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AncestryEthnicOriginDescriptorsApi.GetAncestryEthnicOriginDescriptors: " + e.Message );
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
 **ancestryEthnicOriginDescriptorId** | **int?**| A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. | [optional] 

### Return type

[**List<MnAncestryEthnicOriginDescriptor>**](MnAncestryEthnicOriginDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getancestryethnicorigindescriptorsbyid"></a>
# **GetAncestryEthnicOriginDescriptorsById**
> MnAncestryEthnicOriginDescriptor GetAncestryEthnicOriginDescriptorsById (string id, string ifNoneMatch = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.MN;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.MN;

namespace Example
{
    public class GetAncestryEthnicOriginDescriptorsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AncestryEthnicOriginDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                MnAncestryEthnicOriginDescriptor result = apiInstance.GetAncestryEthnicOriginDescriptorsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AncestryEthnicOriginDescriptorsApi.GetAncestryEthnicOriginDescriptorsById: " + e.Message );
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

[**MnAncestryEthnicOriginDescriptor**](MnAncestryEthnicOriginDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postancestryethnicorigindescriptor"></a>
# **PostAncestryEthnicOriginDescriptor**
> void PostAncestryEthnicOriginDescriptor (MnAncestryEthnicOriginDescriptor ancestryEthnicOriginDescriptor)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error (you must use a PUT operation to update a resource by \"id\"). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.MN;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.MN;

namespace Example
{
    public class PostAncestryEthnicOriginDescriptorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AncestryEthnicOriginDescriptorsApi();
            var ancestryEthnicOriginDescriptor = new MnAncestryEthnicOriginDescriptor(); // MnAncestryEthnicOriginDescriptor | The JSON representation of the \"ancestryEthnicOriginDescriptor\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostAncestryEthnicOriginDescriptor(ancestryEthnicOriginDescriptor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AncestryEthnicOriginDescriptorsApi.PostAncestryEthnicOriginDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ancestryEthnicOriginDescriptor** | [**MnAncestryEthnicOriginDescriptor**](MnAncestryEthnicOriginDescriptor.md)| The JSON representation of the \&quot;ancestryEthnicOriginDescriptor\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putancestryethnicorigindescriptor"></a>
# **PutAncestryEthnicOriginDescriptor**
> void PutAncestryEthnicOriginDescriptor (string id, MnAncestryEthnicOriginDescriptor ancestryEthnicOriginDescriptor, string ifMatch = null)

Updates or creates a resource based on the resource identifier.

The PUT operation is used to update or create a resource by identifier. If the resource doesn't exist, the resource will be created using that identifier. Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource \"id\" is provided in the JSON body, it will be ignored as well.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.MN;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.MN;

namespace Example
{
    public class PutAncestryEthnicOriginDescriptorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AncestryEthnicOriginDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ancestryEthnicOriginDescriptor = new MnAncestryEthnicOriginDescriptor(); // MnAncestryEthnicOriginDescriptor | The JSON representation of the \"ancestryEthnicOriginDescriptor\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutAncestryEthnicOriginDescriptor(id, ancestryEthnicOriginDescriptor, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AncestryEthnicOriginDescriptorsApi.PutAncestryEthnicOriginDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **ancestryEthnicOriginDescriptor** | [**MnAncestryEthnicOriginDescriptor**](MnAncestryEthnicOriginDescriptor.md)| The JSON representation of the \&quot;ancestryEthnicOriginDescriptor\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

