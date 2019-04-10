# EdFi.OdsApi.Sdk.Apis.All.StudentLearningObjectivesApi

All URIs are relative to *https://localhost:56641/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentLearningObjectiveById**](StudentLearningObjectivesApi.md#deletestudentlearningobjectivebyid) | **DELETE** /ed-fi/studentLearningObjectives/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentLearningObjectives**](StudentLearningObjectivesApi.md#getstudentlearningobjectives) | **GET** /ed-fi/studentLearningObjectives | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentLearningObjectivesById**](StudentLearningObjectivesApi.md#getstudentlearningobjectivesbyid) | **GET** /ed-fi/studentLearningObjectives/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudentLearningObjective**](StudentLearningObjectivesApi.md#poststudentlearningobjective) | **POST** /ed-fi/studentLearningObjectives | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudentLearningObjective**](StudentLearningObjectivesApi.md#putstudentlearningobjective) | **PUT** /ed-fi/studentLearningObjectives/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudentlearningobjectivebyid"></a>
# **DeleteStudentLearningObjectiveById**
> void DeleteStudentLearningObjectiveById (string id, string ifMatch = null)

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
    public class DeleteStudentLearningObjectiveByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentLearningObjectivesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentLearningObjectiveById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentLearningObjectivesApi.DeleteStudentLearningObjectiveById: " + e.Message );
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

<a name="getstudentlearningobjectives"></a>
# **GetStudentLearningObjectives**
> List<EdFiStudentLearningObjective> GetStudentLearningObjectives (int? offset = null, int? limit = null, bool? totalCount = null, string gradingPeriodDescriptor = null, int? gradingPeriodSequence = null, int? gradingPeriodSchoolId = null, int? gradingPeriodSchoolYear = null, string learningObjectiveId = null, string _namespace = null, string studentUniqueId = null, string competencyLevelDescriptor = null, string diagnosticStatement = null, string id = null)

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
    public class GetStudentLearningObjectivesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentLearningObjectivesApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var gradingPeriodDescriptor = gradingPeriodDescriptor_example;  // string | The name of the period for which grades are reported. (optional) 
            var gradingPeriodSequence = 56;  // int? | The sequential order of this period relative to other periods. (optional) 
            var gradingPeriodSchoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var gradingPeriodSchoolYear = 56;  // int? | The identifier for the grading period school year. (optional) 
            var learningObjectiveId = learningObjectiveId_example;  // string | The identifier for the specific learning objective in the context of a standard (e.g., 111.15.3.1.A). (optional) 
            var _namespace = _namespace_example;  // string | Namespace for the LearningObjective. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var competencyLevelDescriptor = competencyLevelDescriptor_example;  // string | The CompetencyLevel assessed for the student for the referenced LearningObjective. (optional) 
            var diagnosticStatement = diagnosticStatement_example;  // string | A statement provided by the teacher that provides information in addition to the grade or assessment score. (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentLearningObjective&gt; result = apiInstance.GetStudentLearningObjectives(offset, limit, totalCount, gradingPeriodDescriptor, gradingPeriodSequence, gradingPeriodSchoolId, gradingPeriodSchoolYear, learningObjectiveId, _namespace, studentUniqueId, competencyLevelDescriptor, diagnosticStatement, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentLearningObjectivesApi.GetStudentLearningObjectives: " + e.Message );
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
 **gradingPeriodDescriptor** | **string**| The name of the period for which grades are reported. | [optional] 
 **gradingPeriodSequence** | **int?**| The sequential order of this period relative to other periods. | [optional] 
 **gradingPeriodSchoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **gradingPeriodSchoolYear** | **int?**| The identifier for the grading period school year. | [optional] 
 **learningObjectiveId** | **string**| The identifier for the specific learning objective in the context of a standard (e.g., 111.15.3.1.A). | [optional] 
 **_namespace** | **string**| Namespace for the LearningObjective. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **competencyLevelDescriptor** | **string**| The CompetencyLevel assessed for the student for the referenced LearningObjective. | [optional] 
 **diagnosticStatement** | **string**| A statement provided by the teacher that provides information in addition to the grade or assessment score. | [optional] 
 **id** | **string**|  | [optional] 

### Return type

[**List<EdFiStudentLearningObjective>**](EdFiStudentLearningObjective.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentlearningobjectivesbyid"></a>
# **GetStudentLearningObjectivesById**
> EdFiStudentLearningObjective GetStudentLearningObjectivesById (string id, string ifNoneMatch = null)

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
    public class GetStudentLearningObjectivesByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentLearningObjectivesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentLearningObjective result = apiInstance.GetStudentLearningObjectivesById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentLearningObjectivesApi.GetStudentLearningObjectivesById: " + e.Message );
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

[**EdFiStudentLearningObjective**](EdFiStudentLearningObjective.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentlearningobjective"></a>
# **PostStudentLearningObjective**
> void PostStudentLearningObjective (EdFiStudentLearningObjective studentLearningObjective)

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
    public class PostStudentLearningObjectiveExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentLearningObjectivesApi();
            var studentLearningObjective = new EdFiStudentLearningObjective(); // EdFiStudentLearningObjective | The JSON representation of the \"studentLearningObjective\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentLearningObjective(studentLearningObjective);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentLearningObjectivesApi.PostStudentLearningObjective: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentLearningObjective** | [**EdFiStudentLearningObjective**](EdFiStudentLearningObjective.md)| The JSON representation of the \&quot;studentLearningObjective\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentlearningobjective"></a>
# **PutStudentLearningObjective**
> void PutStudentLearningObjective (string id, EdFiStudentLearningObjective studentLearningObjective, string ifMatch = null)

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
    public class PutStudentLearningObjectiveExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentLearningObjectivesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentLearningObjective = new EdFiStudentLearningObjective(); // EdFiStudentLearningObjective | The JSON representation of the \"studentLearningObjective\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStudentLearningObjective(id, studentLearningObjective, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentLearningObjectivesApi.PutStudentLearningObjective: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentLearningObjective** | [**EdFiStudentLearningObjective**](EdFiStudentLearningObjective.md)| The JSON representation of the \&quot;studentLearningObjective\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

