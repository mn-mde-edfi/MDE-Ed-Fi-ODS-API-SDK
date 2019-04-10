# EdFi.OdsApi.Sdk.Apis.All.CourseLevelCharacteristicDescriptorsApi

All URIs are relative to *https://localhost:56641/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCourseLevelCharacteristicDescriptorById**](CourseLevelCharacteristicDescriptorsApi.md#deletecourselevelcharacteristicdescriptorbyid) | **DELETE** /ed-fi/courseLevelCharacteristicDescriptors/{id} | Deletes an existing resource using the resource identifier.
[**GetCourseLevelCharacteristicDescriptors**](CourseLevelCharacteristicDescriptorsApi.md#getcourselevelcharacteristicdescriptors) | **GET** /ed-fi/courseLevelCharacteristicDescriptors | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetCourseLevelCharacteristicDescriptorsById**](CourseLevelCharacteristicDescriptorsApi.md#getcourselevelcharacteristicdescriptorsbyid) | **GET** /ed-fi/courseLevelCharacteristicDescriptors/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostCourseLevelCharacteristicDescriptor**](CourseLevelCharacteristicDescriptorsApi.md#postcourselevelcharacteristicdescriptor) | **POST** /ed-fi/courseLevelCharacteristicDescriptors | Creates or updates resources based on the natural key values of the supplied resource.
[**PutCourseLevelCharacteristicDescriptor**](CourseLevelCharacteristicDescriptorsApi.md#putcourselevelcharacteristicdescriptor) | **PUT** /ed-fi/courseLevelCharacteristicDescriptors/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletecourselevelcharacteristicdescriptorbyid"></a>
# **DeleteCourseLevelCharacteristicDescriptorById**
> void DeleteCourseLevelCharacteristicDescriptorById (string id, string ifMatch = null)

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
    public class DeleteCourseLevelCharacteristicDescriptorByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseLevelCharacteristicDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteCourseLevelCharacteristicDescriptorById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseLevelCharacteristicDescriptorsApi.DeleteCourseLevelCharacteristicDescriptorById: " + e.Message );
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

<a name="getcourselevelcharacteristicdescriptors"></a>
# **GetCourseLevelCharacteristicDescriptors**
> List<EdFiCourseLevelCharacteristicDescriptor> GetCourseLevelCharacteristicDescriptors (int? offset = null, int? limit = null, bool? totalCount = null, int? courseLevelCharacteristicDescriptorId = null)

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
    public class GetCourseLevelCharacteristicDescriptorsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseLevelCharacteristicDescriptorsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var courseLevelCharacteristicDescriptorId = 56;  // int? | A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiCourseLevelCharacteristicDescriptor&gt; result = apiInstance.GetCourseLevelCharacteristicDescriptors(offset, limit, totalCount, courseLevelCharacteristicDescriptorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseLevelCharacteristicDescriptorsApi.GetCourseLevelCharacteristicDescriptors: " + e.Message );
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
 **courseLevelCharacteristicDescriptorId** | **int?**| A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. | [optional] 

### Return type

[**List<EdFiCourseLevelCharacteristicDescriptor>**](EdFiCourseLevelCharacteristicDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcourselevelcharacteristicdescriptorsbyid"></a>
# **GetCourseLevelCharacteristicDescriptorsById**
> EdFiCourseLevelCharacteristicDescriptor GetCourseLevelCharacteristicDescriptorsById (string id, string ifNoneMatch = null)

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
    public class GetCourseLevelCharacteristicDescriptorsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseLevelCharacteristicDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiCourseLevelCharacteristicDescriptor result = apiInstance.GetCourseLevelCharacteristicDescriptorsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseLevelCharacteristicDescriptorsApi.GetCourseLevelCharacteristicDescriptorsById: " + e.Message );
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

[**EdFiCourseLevelCharacteristicDescriptor**](EdFiCourseLevelCharacteristicDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcourselevelcharacteristicdescriptor"></a>
# **PostCourseLevelCharacteristicDescriptor**
> void PostCourseLevelCharacteristicDescriptor (EdFiCourseLevelCharacteristicDescriptor courseLevelCharacteristicDescriptor)

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
    public class PostCourseLevelCharacteristicDescriptorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseLevelCharacteristicDescriptorsApi();
            var courseLevelCharacteristicDescriptor = new EdFiCourseLevelCharacteristicDescriptor(); // EdFiCourseLevelCharacteristicDescriptor | The JSON representation of the \"courseLevelCharacteristicDescriptor\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostCourseLevelCharacteristicDescriptor(courseLevelCharacteristicDescriptor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseLevelCharacteristicDescriptorsApi.PostCourseLevelCharacteristicDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseLevelCharacteristicDescriptor** | [**EdFiCourseLevelCharacteristicDescriptor**](EdFiCourseLevelCharacteristicDescriptor.md)| The JSON representation of the \&quot;courseLevelCharacteristicDescriptor\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcourselevelcharacteristicdescriptor"></a>
# **PutCourseLevelCharacteristicDescriptor**
> void PutCourseLevelCharacteristicDescriptor (string id, EdFiCourseLevelCharacteristicDescriptor courseLevelCharacteristicDescriptor, string ifMatch = null)

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
    public class PutCourseLevelCharacteristicDescriptorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseLevelCharacteristicDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var courseLevelCharacteristicDescriptor = new EdFiCourseLevelCharacteristicDescriptor(); // EdFiCourseLevelCharacteristicDescriptor | The JSON representation of the \"courseLevelCharacteristicDescriptor\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutCourseLevelCharacteristicDescriptor(id, courseLevelCharacteristicDescriptor, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseLevelCharacteristicDescriptorsApi.PutCourseLevelCharacteristicDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **courseLevelCharacteristicDescriptor** | [**EdFiCourseLevelCharacteristicDescriptor**](EdFiCourseLevelCharacteristicDescriptor.md)| The JSON representation of the \&quot;courseLevelCharacteristicDescriptor\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

