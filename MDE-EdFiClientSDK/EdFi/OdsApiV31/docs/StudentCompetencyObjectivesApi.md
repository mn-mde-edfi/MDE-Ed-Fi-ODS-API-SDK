# EdFi.OdsApi.Sdk.Apis.All.StudentCompetencyObjectivesApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentCompetencyObjectiveById**](StudentCompetencyObjectivesApi.md#deletestudentcompetencyobjectivebyid) | **DELETE** /ed-fi/studentCompetencyObjectives/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentCompetencyObjectives**](StudentCompetencyObjectivesApi.md#getstudentcompetencyobjectives) | **GET** /ed-fi/studentCompetencyObjectives | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentCompetencyObjectivesById**](StudentCompetencyObjectivesApi.md#getstudentcompetencyobjectivesbyid) | **GET** /ed-fi/studentCompetencyObjectives/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudentCompetencyObjective**](StudentCompetencyObjectivesApi.md#poststudentcompetencyobjective) | **POST** /ed-fi/studentCompetencyObjectives | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudentCompetencyObjective**](StudentCompetencyObjectivesApi.md#putstudentcompetencyobjective) | **PUT** /ed-fi/studentCompetencyObjectives/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudentcompetencyobjectivebyid"></a>
# **DeleteStudentCompetencyObjectiveById**
> void DeleteStudentCompetencyObjectiveById (string id, string ifMatch = null)

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
    public class DeleteStudentCompetencyObjectiveByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentCompetencyObjectivesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentCompetencyObjectiveById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentCompetencyObjectivesApi.DeleteStudentCompetencyObjectiveById: " + e.Message );
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

<a name="getstudentcompetencyobjectives"></a>
# **GetStudentCompetencyObjectives**
> List<EdFiStudentCompetencyObjective> GetStudentCompetencyObjectives (int? offset = null, int? limit = null, bool? totalCount = null, int? objectiveEducationOrganizationId = null, string objective = null, string objectiveGradeLevelDescriptor = null, string gradingPeriodDescriptor = null, int? gradingPeriodSequence = null, int? gradingPeriodSchoolId = null, int? gradingPeriodSchoolYear = null, string studentUniqueId = null, string competencyLevelDescriptor = null, string diagnosticStatement = null, string id = null)

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
    public class GetStudentCompetencyObjectivesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentCompetencyObjectivesApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var objectiveEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var objective = objective_example;  // string | The designated title of the CompetencyObjective. (optional) 
            var objectiveGradeLevelDescriptor = objectiveGradeLevelDescriptor_example;  // string | The grade level for which the CompetencyObjective is targeted. (optional) 
            var gradingPeriodDescriptor = gradingPeriodDescriptor_example;  // string | The name of the period for which grades are reported. (optional) 
            var gradingPeriodSequence = 56;  // int? | The sequential order of this period relative to other periods. (optional) 
            var gradingPeriodSchoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var gradingPeriodSchoolYear = 56;  // int? | The identifier for the grading period school year. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var competencyLevelDescriptor = competencyLevelDescriptor_example;  // string | The CompetencyLevel assessed for the student for the referenced LearningObjective. (optional) 
            var diagnosticStatement = diagnosticStatement_example;  // string | A statement provided by the teacher that provides information in addition to the grade or assessment score. (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentCompetencyObjective&gt; result = apiInstance.GetStudentCompetencyObjectives(offset, limit, totalCount, objectiveEducationOrganizationId, objective, objectiveGradeLevelDescriptor, gradingPeriodDescriptor, gradingPeriodSequence, gradingPeriodSchoolId, gradingPeriodSchoolYear, studentUniqueId, competencyLevelDescriptor, diagnosticStatement, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentCompetencyObjectivesApi.GetStudentCompetencyObjectives: " + e.Message );
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
 **objectiveEducationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **objective** | **string**| The designated title of the CompetencyObjective. | [optional] 
 **objectiveGradeLevelDescriptor** | **string**| The grade level for which the CompetencyObjective is targeted. | [optional] 
 **gradingPeriodDescriptor** | **string**| The name of the period for which grades are reported. | [optional] 
 **gradingPeriodSequence** | **int?**| The sequential order of this period relative to other periods. | [optional] 
 **gradingPeriodSchoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **gradingPeriodSchoolYear** | **int?**| The identifier for the grading period school year. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **competencyLevelDescriptor** | **string**| The CompetencyLevel assessed for the student for the referenced LearningObjective. | [optional] 
 **diagnosticStatement** | **string**| A statement provided by the teacher that provides information in addition to the grade or assessment score. | [optional] 
 **id** | **string**|  | [optional] 

### Return type

[**List<EdFiStudentCompetencyObjective>**](EdFiStudentCompetencyObjective.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentcompetencyobjectivesbyid"></a>
# **GetStudentCompetencyObjectivesById**
> EdFiStudentCompetencyObjective GetStudentCompetencyObjectivesById (string id, string ifNoneMatch = null)

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
    public class GetStudentCompetencyObjectivesByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentCompetencyObjectivesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentCompetencyObjective result = apiInstance.GetStudentCompetencyObjectivesById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentCompetencyObjectivesApi.GetStudentCompetencyObjectivesById: " + e.Message );
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

[**EdFiStudentCompetencyObjective**](EdFiStudentCompetencyObjective.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentcompetencyobjective"></a>
# **PostStudentCompetencyObjective**
> void PostStudentCompetencyObjective (EdFiStudentCompetencyObjective studentCompetencyObjective)

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
    public class PostStudentCompetencyObjectiveExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentCompetencyObjectivesApi();
            var studentCompetencyObjective = new EdFiStudentCompetencyObjective(); // EdFiStudentCompetencyObjective | The JSON representation of the \"studentCompetencyObjective\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentCompetencyObjective(studentCompetencyObjective);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentCompetencyObjectivesApi.PostStudentCompetencyObjective: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentCompetencyObjective** | [**EdFiStudentCompetencyObjective**](EdFiStudentCompetencyObjective.md)| The JSON representation of the \&quot;studentCompetencyObjective\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentcompetencyobjective"></a>
# **PutStudentCompetencyObjective**
> void PutStudentCompetencyObjective (string id, EdFiStudentCompetencyObjective studentCompetencyObjective, string ifMatch = null)

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
    public class PutStudentCompetencyObjectiveExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentCompetencyObjectivesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentCompetencyObjective = new EdFiStudentCompetencyObjective(); // EdFiStudentCompetencyObjective | The JSON representation of the \"studentCompetencyObjective\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStudentCompetencyObjective(id, studentCompetencyObjective, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentCompetencyObjectivesApi.PutStudentCompetencyObjective: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentCompetencyObjective** | [**EdFiStudentCompetencyObjective**](EdFiStudentCompetencyObjective.md)| The JSON representation of the \&quot;studentCompetencyObjective\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

