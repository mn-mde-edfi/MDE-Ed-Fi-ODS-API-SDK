# EdFi.OdsApi.Sdk.Apis.Descriptors.SchoolChoiceImplementStatusDescriptorsApi

All URIs are relative to *https://localhost:54746/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSchoolChoiceImplementStatusDescriptorById**](SchoolChoiceImplementStatusDescriptorsApi.md#deleteschoolchoiceimplementstatusdescriptorbyid) | **DELETE** /ed-fi/schoolChoiceImplementStatusDescriptors/{id} | Deletes an existing resource using the resource identifier.
[**GetSchoolChoiceImplementStatusDescriptors**](SchoolChoiceImplementStatusDescriptorsApi.md#getschoolchoiceimplementstatusdescriptors) | **GET** /ed-fi/schoolChoiceImplementStatusDescriptors | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetSchoolChoiceImplementStatusDescriptorsById**](SchoolChoiceImplementStatusDescriptorsApi.md#getschoolchoiceimplementstatusdescriptorsbyid) | **GET** /ed-fi/schoolChoiceImplementStatusDescriptors/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostSchoolChoiceImplementStatusDescriptor**](SchoolChoiceImplementStatusDescriptorsApi.md#postschoolchoiceimplementstatusdescriptor) | **POST** /ed-fi/schoolChoiceImplementStatusDescriptors | Creates or updates resources based on the natural key values of the supplied resource.
[**PutSchoolChoiceImplementStatusDescriptor**](SchoolChoiceImplementStatusDescriptorsApi.md#putschoolchoiceimplementstatusdescriptor) | **PUT** /ed-fi/schoolChoiceImplementStatusDescriptors/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteschoolchoiceimplementstatusdescriptorbyid"></a>
# **DeleteSchoolChoiceImplementStatusDescriptorById**
> void DeleteSchoolChoiceImplementStatusDescriptorById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Descriptors;

namespace Example
{
    public class DeleteSchoolChoiceImplementStatusDescriptorByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolChoiceImplementStatusDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteSchoolChoiceImplementStatusDescriptorById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchoolChoiceImplementStatusDescriptorsApi.DeleteSchoolChoiceImplementStatusDescriptorById: " + e.Message );
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

<a name="getschoolchoiceimplementstatusdescriptors"></a>
# **GetSchoolChoiceImplementStatusDescriptors**
> List<EdFiSchoolChoiceImplementStatusDescriptor> GetSchoolChoiceImplementStatusDescriptors (int? offset = null, int? limit = null, bool? totalCount = null, int? schoolChoiceImplementStatusDescriptorId = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Descriptors;

namespace Example
{
    public class GetSchoolChoiceImplementStatusDescriptorsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolChoiceImplementStatusDescriptorsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var schoolChoiceImplementStatusDescriptorId = 56;  // int? | A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiSchoolChoiceImplementStatusDescriptor&gt; result = apiInstance.GetSchoolChoiceImplementStatusDescriptors(offset, limit, totalCount, schoolChoiceImplementStatusDescriptorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchoolChoiceImplementStatusDescriptorsApi.GetSchoolChoiceImplementStatusDescriptors: " + e.Message );
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
 **schoolChoiceImplementStatusDescriptorId** | **int?**| A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. | [optional] 

### Return type

[**List<EdFiSchoolChoiceImplementStatusDescriptor>**](EdFiSchoolChoiceImplementStatusDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschoolchoiceimplementstatusdescriptorsbyid"></a>
# **GetSchoolChoiceImplementStatusDescriptorsById**
> EdFiSchoolChoiceImplementStatusDescriptor GetSchoolChoiceImplementStatusDescriptorsById (string id, string ifNoneMatch = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Descriptors;

namespace Example
{
    public class GetSchoolChoiceImplementStatusDescriptorsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolChoiceImplementStatusDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiSchoolChoiceImplementStatusDescriptor result = apiInstance.GetSchoolChoiceImplementStatusDescriptorsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchoolChoiceImplementStatusDescriptorsApi.GetSchoolChoiceImplementStatusDescriptorsById: " + e.Message );
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

[**EdFiSchoolChoiceImplementStatusDescriptor**](EdFiSchoolChoiceImplementStatusDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postschoolchoiceimplementstatusdescriptor"></a>
# **PostSchoolChoiceImplementStatusDescriptor**
> void PostSchoolChoiceImplementStatusDescriptor (EdFiSchoolChoiceImplementStatusDescriptor schoolChoiceImplementStatusDescriptor)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error (you must use a PUT operation to update a resource by \"id\"). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Descriptors;

namespace Example
{
    public class PostSchoolChoiceImplementStatusDescriptorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolChoiceImplementStatusDescriptorsApi();
            var schoolChoiceImplementStatusDescriptor = new EdFiSchoolChoiceImplementStatusDescriptor(); // EdFiSchoolChoiceImplementStatusDescriptor | The JSON representation of the \"schoolChoiceImplementStatusDescriptor\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostSchoolChoiceImplementStatusDescriptor(schoolChoiceImplementStatusDescriptor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchoolChoiceImplementStatusDescriptorsApi.PostSchoolChoiceImplementStatusDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **schoolChoiceImplementStatusDescriptor** | [**EdFiSchoolChoiceImplementStatusDescriptor**](EdFiSchoolChoiceImplementStatusDescriptor.md)| The JSON representation of the \&quot;schoolChoiceImplementStatusDescriptor\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putschoolchoiceimplementstatusdescriptor"></a>
# **PutSchoolChoiceImplementStatusDescriptor**
> void PutSchoolChoiceImplementStatusDescriptor (string id, EdFiSchoolChoiceImplementStatusDescriptor schoolChoiceImplementStatusDescriptor, string ifMatch = null)

Updates or creates a resource based on the resource identifier.

The PUT operation is used to update or create a resource by identifier. If the resource doesn't exist, the resource will be created using that identifier. Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource \"id\" is provided in the JSON body, it will be ignored as well.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Descriptors;

namespace Example
{
    public class PutSchoolChoiceImplementStatusDescriptorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolChoiceImplementStatusDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var schoolChoiceImplementStatusDescriptor = new EdFiSchoolChoiceImplementStatusDescriptor(); // EdFiSchoolChoiceImplementStatusDescriptor | The JSON representation of the \"schoolChoiceImplementStatusDescriptor\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutSchoolChoiceImplementStatusDescriptor(id, schoolChoiceImplementStatusDescriptor, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchoolChoiceImplementStatusDescriptorsApi.PutSchoolChoiceImplementStatusDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **schoolChoiceImplementStatusDescriptor** | [**EdFiSchoolChoiceImplementStatusDescriptor**](EdFiSchoolChoiceImplementStatusDescriptor.md)| The JSON representation of the \&quot;schoolChoiceImplementStatusDescriptor\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

