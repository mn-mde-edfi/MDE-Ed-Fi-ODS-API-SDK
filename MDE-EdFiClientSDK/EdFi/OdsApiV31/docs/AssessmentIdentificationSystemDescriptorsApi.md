# EdFi.OdsApi.Sdk.Apis.All.AssessmentIdentificationSystemDescriptorsApi

All URIs are relative to *https://localhost:56641/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAssessmentIdentificationSystemDescriptorById**](AssessmentIdentificationSystemDescriptorsApi.md#deleteassessmentidentificationsystemdescriptorbyid) | **DELETE** /ed-fi/assessmentIdentificationSystemDescriptors/{id} | Deletes an existing resource using the resource identifier.
[**GetAssessmentIdentificationSystemDescriptors**](AssessmentIdentificationSystemDescriptorsApi.md#getassessmentidentificationsystemdescriptors) | **GET** /ed-fi/assessmentIdentificationSystemDescriptors | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetAssessmentIdentificationSystemDescriptorsById**](AssessmentIdentificationSystemDescriptorsApi.md#getassessmentidentificationsystemdescriptorsbyid) | **GET** /ed-fi/assessmentIdentificationSystemDescriptors/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostAssessmentIdentificationSystemDescriptor**](AssessmentIdentificationSystemDescriptorsApi.md#postassessmentidentificationsystemdescriptor) | **POST** /ed-fi/assessmentIdentificationSystemDescriptors | Creates or updates resources based on the natural key values of the supplied resource.
[**PutAssessmentIdentificationSystemDescriptor**](AssessmentIdentificationSystemDescriptorsApi.md#putassessmentidentificationsystemdescriptor) | **PUT** /ed-fi/assessmentIdentificationSystemDescriptors/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteassessmentidentificationsystemdescriptorbyid"></a>
# **DeleteAssessmentIdentificationSystemDescriptorById**
> void DeleteAssessmentIdentificationSystemDescriptorById (string id, string ifMatch = null)

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
    public class DeleteAssessmentIdentificationSystemDescriptorByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentIdentificationSystemDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteAssessmentIdentificationSystemDescriptorById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentIdentificationSystemDescriptorsApi.DeleteAssessmentIdentificationSystemDescriptorById: " + e.Message );
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

<a name="getassessmentidentificationsystemdescriptors"></a>
# **GetAssessmentIdentificationSystemDescriptors**
> List<EdFiAssessmentIdentificationSystemDescriptor> GetAssessmentIdentificationSystemDescriptors (int? offset = null, int? limit = null, bool? totalCount = null, int? assessmentIdentificationSystemDescriptorId = null)

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
    public class GetAssessmentIdentificationSystemDescriptorsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentIdentificationSystemDescriptorsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var assessmentIdentificationSystemDescriptorId = 56;  // int? | A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiAssessmentIdentificationSystemDescriptor&gt; result = apiInstance.GetAssessmentIdentificationSystemDescriptors(offset, limit, totalCount, assessmentIdentificationSystemDescriptorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentIdentificationSystemDescriptorsApi.GetAssessmentIdentificationSystemDescriptors: " + e.Message );
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
 **assessmentIdentificationSystemDescriptorId** | **int?**| A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. | [optional] 

### Return type

[**List<EdFiAssessmentIdentificationSystemDescriptor>**](EdFiAssessmentIdentificationSystemDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassessmentidentificationsystemdescriptorsbyid"></a>
# **GetAssessmentIdentificationSystemDescriptorsById**
> EdFiAssessmentIdentificationSystemDescriptor GetAssessmentIdentificationSystemDescriptorsById (string id, string ifNoneMatch = null)

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
    public class GetAssessmentIdentificationSystemDescriptorsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentIdentificationSystemDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiAssessmentIdentificationSystemDescriptor result = apiInstance.GetAssessmentIdentificationSystemDescriptorsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentIdentificationSystemDescriptorsApi.GetAssessmentIdentificationSystemDescriptorsById: " + e.Message );
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

[**EdFiAssessmentIdentificationSystemDescriptor**](EdFiAssessmentIdentificationSystemDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postassessmentidentificationsystemdescriptor"></a>
# **PostAssessmentIdentificationSystemDescriptor**
> void PostAssessmentIdentificationSystemDescriptor (EdFiAssessmentIdentificationSystemDescriptor assessmentIdentificationSystemDescriptor)

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
    public class PostAssessmentIdentificationSystemDescriptorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentIdentificationSystemDescriptorsApi();
            var assessmentIdentificationSystemDescriptor = new EdFiAssessmentIdentificationSystemDescriptor(); // EdFiAssessmentIdentificationSystemDescriptor | The JSON representation of the \"assessmentIdentificationSystemDescriptor\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostAssessmentIdentificationSystemDescriptor(assessmentIdentificationSystemDescriptor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentIdentificationSystemDescriptorsApi.PostAssessmentIdentificationSystemDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assessmentIdentificationSystemDescriptor** | [**EdFiAssessmentIdentificationSystemDescriptor**](EdFiAssessmentIdentificationSystemDescriptor.md)| The JSON representation of the \&quot;assessmentIdentificationSystemDescriptor\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putassessmentidentificationsystemdescriptor"></a>
# **PutAssessmentIdentificationSystemDescriptor**
> void PutAssessmentIdentificationSystemDescriptor (string id, EdFiAssessmentIdentificationSystemDescriptor assessmentIdentificationSystemDescriptor, string ifMatch = null)

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
    public class PutAssessmentIdentificationSystemDescriptorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentIdentificationSystemDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var assessmentIdentificationSystemDescriptor = new EdFiAssessmentIdentificationSystemDescriptor(); // EdFiAssessmentIdentificationSystemDescriptor | The JSON representation of the \"assessmentIdentificationSystemDescriptor\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutAssessmentIdentificationSystemDescriptor(id, assessmentIdentificationSystemDescriptor, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentIdentificationSystemDescriptorsApi.PutAssessmentIdentificationSystemDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **assessmentIdentificationSystemDescriptor** | [**EdFiAssessmentIdentificationSystemDescriptor**](EdFiAssessmentIdentificationSystemDescriptor.md)| The JSON representation of the \&quot;assessmentIdentificationSystemDescriptor\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

