# EdFi.OdsApi.Sdk.Apis.All.ObjectiveAssessmentsApi

All URIs are relative to *https://localhost:56641/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteObjectiveAssessmentById**](ObjectiveAssessmentsApi.md#deleteobjectiveassessmentbyid) | **DELETE** /ed-fi/objectiveAssessments/{id} | Deletes an existing resource using the resource identifier.
[**GetObjectiveAssessments**](ObjectiveAssessmentsApi.md#getobjectiveassessments) | **GET** /ed-fi/objectiveAssessments | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetObjectiveAssessmentsById**](ObjectiveAssessmentsApi.md#getobjectiveassessmentsbyid) | **GET** /ed-fi/objectiveAssessments/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostObjectiveAssessment**](ObjectiveAssessmentsApi.md#postobjectiveassessment) | **POST** /ed-fi/objectiveAssessments | Creates or updates resources based on the natural key values of the supplied resource.
[**PutObjectiveAssessment**](ObjectiveAssessmentsApi.md#putobjectiveassessment) | **PUT** /ed-fi/objectiveAssessments/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteobjectiveassessmentbyid"></a>
# **DeleteObjectiveAssessmentById**
> void DeleteObjectiveAssessmentById (string id, string ifMatch = null)

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
    public class DeleteObjectiveAssessmentByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ObjectiveAssessmentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteObjectiveAssessmentById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectiveAssessmentsApi.DeleteObjectiveAssessmentById: " + e.Message );
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

<a name="getobjectiveassessments"></a>
# **GetObjectiveAssessments**
> List<EdFiObjectiveAssessment> GetObjectiveAssessments (int? offset = null, int? limit = null, bool? totalCount = null, string identificationCode = null, string assessmentIdentifier = null, string _namespace = null, string parentIdentificationCode = null, string description = null, string id = null, int? maxRawScore = null, string nomenclature = null, double? percentOfAssessment = null)

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
    public class GetObjectiveAssessmentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ObjectiveAssessmentsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var identificationCode = identificationCode_example;  // string | A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, a state, or other agency or entity. (optional) 
            var assessmentIdentifier = assessmentIdentifier_example;  // string | A unique number or alphanumeric code assigned to an assessment. (optional) 
            var _namespace = _namespace_example;  // string | Namespace for the Assessment. (optional) 
            var parentIdentificationCode = parentIdentificationCode_example;  // string | A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, a state, or other agency or entity. (optional) 
            var description = description_example;  // string | The description of the ObjectiveAssessment (e.g., vocabulary, measurement, or geometry). (optional) 
            var id = id_example;  // string |  (optional) 
            var maxRawScore = 56;  // int? | The maximum raw score achievable across all assessment items that are correct and scored at the maximum. (optional) 
            var nomenclature = nomenclature_example;  // string | Reflects the specific nomenclature used for this level of ObjectiveAssessment. (optional) 
            var percentOfAssessment = 1.2;  // double? | The percentage of the Assessment that tests this objective. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiObjectiveAssessment&gt; result = apiInstance.GetObjectiveAssessments(offset, limit, totalCount, identificationCode, assessmentIdentifier, _namespace, parentIdentificationCode, description, id, maxRawScore, nomenclature, percentOfAssessment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectiveAssessmentsApi.GetObjectiveAssessments: " + e.Message );
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
 **identificationCode** | **string**| A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, a state, or other agency or entity. | [optional] 
 **assessmentIdentifier** | **string**| A unique number or alphanumeric code assigned to an assessment. | [optional] 
 **_namespace** | **string**| Namespace for the Assessment. | [optional] 
 **parentIdentificationCode** | **string**| A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, a state, or other agency or entity. | [optional] 
 **description** | **string**| The description of the ObjectiveAssessment (e.g., vocabulary, measurement, or geometry). | [optional] 
 **id** | **string**|  | [optional] 
 **maxRawScore** | **int?**| The maximum raw score achievable across all assessment items that are correct and scored at the maximum. | [optional] 
 **nomenclature** | **string**| Reflects the specific nomenclature used for this level of ObjectiveAssessment. | [optional] 
 **percentOfAssessment** | **double?**| The percentage of the Assessment that tests this objective. | [optional] 

### Return type

[**List<EdFiObjectiveAssessment>**](EdFiObjectiveAssessment.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getobjectiveassessmentsbyid"></a>
# **GetObjectiveAssessmentsById**
> EdFiObjectiveAssessment GetObjectiveAssessmentsById (string id, string ifNoneMatch = null)

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
    public class GetObjectiveAssessmentsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ObjectiveAssessmentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiObjectiveAssessment result = apiInstance.GetObjectiveAssessmentsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectiveAssessmentsApi.GetObjectiveAssessmentsById: " + e.Message );
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

[**EdFiObjectiveAssessment**](EdFiObjectiveAssessment.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postobjectiveassessment"></a>
# **PostObjectiveAssessment**
> void PostObjectiveAssessment (EdFiObjectiveAssessment objectiveAssessment)

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
    public class PostObjectiveAssessmentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ObjectiveAssessmentsApi();
            var objectiveAssessment = new EdFiObjectiveAssessment(); // EdFiObjectiveAssessment | The JSON representation of the \"objectiveAssessment\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostObjectiveAssessment(objectiveAssessment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectiveAssessmentsApi.PostObjectiveAssessment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **objectiveAssessment** | [**EdFiObjectiveAssessment**](EdFiObjectiveAssessment.md)| The JSON representation of the \&quot;objectiveAssessment\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putobjectiveassessment"></a>
# **PutObjectiveAssessment**
> void PutObjectiveAssessment (string id, EdFiObjectiveAssessment objectiveAssessment, string ifMatch = null)

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
    public class PutObjectiveAssessmentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ObjectiveAssessmentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var objectiveAssessment = new EdFiObjectiveAssessment(); // EdFiObjectiveAssessment | The JSON representation of the \"objectiveAssessment\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutObjectiveAssessment(id, objectiveAssessment, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObjectiveAssessmentsApi.PutObjectiveAssessment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **objectiveAssessment** | [**EdFiObjectiveAssessment**](EdFiObjectiveAssessment.md)| The JSON representation of the \&quot;objectiveAssessment\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

