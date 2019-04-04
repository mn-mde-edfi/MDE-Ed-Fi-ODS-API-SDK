# EdFi.OdsApi.Sdk.Apis.All.LearningStandardsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteLearningStandardById**](LearningStandardsApi.md#deletelearningstandardbyid) | **DELETE** /ed-fi/learningStandards/{id} | Deletes an existing resource using the resource identifier.
[**GetLearningStandards**](LearningStandardsApi.md#getlearningstandards) | **GET** /ed-fi/learningStandards | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetLearningStandardsById**](LearningStandardsApi.md#getlearningstandardsbyid) | **GET** /ed-fi/learningStandards/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostLearningStandard**](LearningStandardsApi.md#postlearningstandard) | **POST** /ed-fi/learningStandards | Creates or updates resources based on the natural key values of the supplied resource.
[**PutLearningStandard**](LearningStandardsApi.md#putlearningstandard) | **PUT** /ed-fi/learningStandards/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletelearningstandardbyid"></a>
# **DeleteLearningStandardById**
> void DeleteLearningStandardById (string id, string ifMatch = null)

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
    public class DeleteLearningStandardByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteLearningStandardById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningStandardsApi.DeleteLearningStandardById: " + e.Message );
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

<a name="getlearningstandards"></a>
# **GetLearningStandards**
> List<EdFiLearningStandard> GetLearningStandards (int? offset = null, int? limit = null, bool? totalCount = null, string learningStandardId = null, string parentLearningStandardId = null, string learningStandardCategoryDescriptor = null, string courseTitle = null, string description = null, string id = null, string learningStandardItemCode = null, string _namespace = null, string successCriteria = null, string uri = null)

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
    public class GetLearningStandardsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var learningStandardId = learningStandardId_example;  // string | The identifier for the specific learning standard (e.g., 111.15.3.1.A). (optional) 
            var parentLearningStandardId = parentLearningStandardId_example;  // string | The identifier for the specific learning standard (e.g., 111.15.3.1.A). (optional) 
            var learningStandardCategoryDescriptor = learningStandardCategoryDescriptor_example;  // string | An additional classification of the type of a specific learning standard. (optional) 
            var courseTitle = courseTitle_example;  // string | The official Course Title with which this learning standard is associated. (optional) 
            var description = description_example;  // string | The text of the statement. The textual content that either describes a specific competency such as \"Apply the Pythagorean Theorem to determine unknown side lengths in right triangles in real-world and mathematical problems in two and three dimensions.\" or describes a less granular group of competencies within the taxonomy of the standards document, e.g. \"Understand and apply the Pythagorean Theorem,\" or \"Geometry\". (optional) 
            var id = id_example;  // string |  (optional) 
            var learningStandardItemCode = learningStandardItemCode_example;  // string | A code designated by the promulgating body to identify the statement, e.g. 1.N.3 (usually not globally unique). (optional) 
            var _namespace = _namespace_example;  // string | Namespace for the LearningStandard. (optional) 
            var successCriteria = successCriteria_example;  // string | One or more statements that describes the criteria used by teachers and students to check for attainment of a learning standard. This criteria gives clear indications as to the degree to which learning is moving through the Zone or Proximal Development toward independent achievement of the LearningStandard. (optional) 
            var uri = uri_example;  // string | An unambiguous reference to the statement using a network-resolvable URI. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiLearningStandard&gt; result = apiInstance.GetLearningStandards(offset, limit, totalCount, learningStandardId, parentLearningStandardId, learningStandardCategoryDescriptor, courseTitle, description, id, learningStandardItemCode, _namespace, successCriteria, uri);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningStandardsApi.GetLearningStandards: " + e.Message );
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
 **learningStandardId** | **string**| The identifier for the specific learning standard (e.g., 111.15.3.1.A). | [optional] 
 **parentLearningStandardId** | **string**| The identifier for the specific learning standard (e.g., 111.15.3.1.A). | [optional] 
 **learningStandardCategoryDescriptor** | **string**| An additional classification of the type of a specific learning standard. | [optional] 
 **courseTitle** | **string**| The official Course Title with which this learning standard is associated. | [optional] 
 **description** | **string**| The text of the statement. The textual content that either describes a specific competency such as \&quot;Apply the Pythagorean Theorem to determine unknown side lengths in right triangles in real-world and mathematical problems in two and three dimensions.\&quot; or describes a less granular group of competencies within the taxonomy of the standards document, e.g. \&quot;Understand and apply the Pythagorean Theorem,\&quot; or \&quot;Geometry\&quot;. | [optional] 
 **id** | **string**|  | [optional] 
 **learningStandardItemCode** | **string**| A code designated by the promulgating body to identify the statement, e.g. 1.N.3 (usually not globally unique). | [optional] 
 **_namespace** | **string**| Namespace for the LearningStandard. | [optional] 
 **successCriteria** | **string**| One or more statements that describes the criteria used by teachers and students to check for attainment of a learning standard. This criteria gives clear indications as to the degree to which learning is moving through the Zone or Proximal Development toward independent achievement of the LearningStandard. | [optional] 
 **uri** | **string**| An unambiguous reference to the statement using a network-resolvable URI. | [optional] 

### Return type

[**List<EdFiLearningStandard>**](EdFiLearningStandard.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlearningstandardsbyid"></a>
# **GetLearningStandardsById**
> EdFiLearningStandard GetLearningStandardsById (string id, string ifNoneMatch = null)

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
    public class GetLearningStandardsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiLearningStandard result = apiInstance.GetLearningStandardsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningStandardsApi.GetLearningStandardsById: " + e.Message );
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

[**EdFiLearningStandard**](EdFiLearningStandard.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postlearningstandard"></a>
# **PostLearningStandard**
> void PostLearningStandard (EdFiLearningStandard learningStandard)

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
    public class PostLearningStandardExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardsApi();
            var learningStandard = new EdFiLearningStandard(); // EdFiLearningStandard | The JSON representation of the \"learningStandard\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostLearningStandard(learningStandard);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningStandardsApi.PostLearningStandard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **learningStandard** | [**EdFiLearningStandard**](EdFiLearningStandard.md)| The JSON representation of the \&quot;learningStandard\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putlearningstandard"></a>
# **PutLearningStandard**
> void PutLearningStandard (string id, EdFiLearningStandard learningStandard, string ifMatch = null)

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
    public class PutLearningStandardExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var learningStandard = new EdFiLearningStandard(); // EdFiLearningStandard | The JSON representation of the \"learningStandard\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutLearningStandard(id, learningStandard, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningStandardsApi.PutLearningStandard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **learningStandard** | [**EdFiLearningStandard**](EdFiLearningStandard.md)| The JSON representation of the \&quot;learningStandard\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

