# EdFi.OdsApi.Sdk.Apis.All.StudentGradebookEntriesApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentGradebookEntryById**](StudentGradebookEntriesApi.md#deletestudentgradebookentrybyid) | **DELETE** /ed-fi/studentGradebookEntries/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentGradebookEntries**](StudentGradebookEntriesApi.md#getstudentgradebookentries) | **GET** /ed-fi/studentGradebookEntries | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentGradebookEntriesById**](StudentGradebookEntriesApi.md#getstudentgradebookentriesbyid) | **GET** /ed-fi/studentGradebookEntries/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudentGradebookEntry**](StudentGradebookEntriesApi.md#poststudentgradebookentry) | **POST** /ed-fi/studentGradebookEntries | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudentGradebookEntry**](StudentGradebookEntriesApi.md#putstudentgradebookentry) | **PUT** /ed-fi/studentGradebookEntries/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudentgradebookentrybyid"></a>
# **DeleteStudentGradebookEntryById**
> void DeleteStudentGradebookEntryById (string id, string ifMatch = null)

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
    public class DeleteStudentGradebookEntryByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentGradebookEntriesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentGradebookEntryById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentGradebookEntriesApi.DeleteStudentGradebookEntryById: " + e.Message );
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

<a name="getstudentgradebookentries"></a>
# **GetStudentGradebookEntries**
> List<EdFiStudentGradebookEntry> GetStudentGradebookEntries (int? offset = null, int? limit = null, bool? totalCount = null, DateTime? dateAssigned = null, string gradebookEntryTitle = null, string localCourseCode = null, int? schoolId = null, int? schoolYear = null, string sectionIdentifier = null, string sessionName = null, DateTime? beginDate = null, string studentUniqueId = null, string competencyLevelDescriptor = null, DateTime? dateFulfilled = null, string diagnosticStatement = null, string id = null, string letterGradeEarned = null, double? numericGradeEarned = null)

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
    public class GetStudentGradebookEntriesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentGradebookEntriesApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var dateAssigned = 2013-10-20;  // DateTime? | The date the assignment, homework, or assessment was assigned or executed. (optional) 
            var gradebookEntryTitle = gradebookEntryTitle_example;  // string | The name or title of the activity to be recorded in the GradebookEntry. (optional) 
            var localCourseCode = localCourseCode_example;  // string | The local code assigned by the School that identifies the course offering provided for the instruction of students. (optional) 
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var schoolYear = 56;  // int? | The identifier for the school year. (optional) 
            var sectionIdentifier = sectionIdentifier_example;  // string | The local identifier assigned to a section. (optional) 
            var sessionName = sessionName_example;  // string | The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). (optional) 
            var beginDate = 2013-10-20;  // DateTime? | Month, day, and year of the Student's entry or assignment to the Section. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var competencyLevelDescriptor = competencyLevelDescriptor_example;  // string | The CompetencyLevel assessed for the student for the referenced LearningObjective. (optional) 
            var dateFulfilled = 2013-10-20;  // DateTime? | The date an assignment was turned in or the date of an assessment. (optional) 
            var diagnosticStatement = diagnosticStatement_example;  // string | A statement provided by the teacher that provides information in addition to the grade or assessment score. (optional) 
            var id = id_example;  // string |  (optional) 
            var letterGradeEarned = letterGradeEarned_example;  // string | A final or interim (grading period) indicator of student performance in a class as submitted by the instructor. (optional) 
            var numericGradeEarned = 1.2;  // double? | A final or interim (grading period) indicator of student performance in a class as submitted by the instructor. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentGradebookEntry&gt; result = apiInstance.GetStudentGradebookEntries(offset, limit, totalCount, dateAssigned, gradebookEntryTitle, localCourseCode, schoolId, schoolYear, sectionIdentifier, sessionName, beginDate, studentUniqueId, competencyLevelDescriptor, dateFulfilled, diagnosticStatement, id, letterGradeEarned, numericGradeEarned);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentGradebookEntriesApi.GetStudentGradebookEntries: " + e.Message );
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
 **dateAssigned** | **DateTime?**| The date the assignment, homework, or assessment was assigned or executed. | [optional] 
 **gradebookEntryTitle** | **string**| The name or title of the activity to be recorded in the GradebookEntry. | [optional] 
 **localCourseCode** | **string**| The local code assigned by the School that identifies the course offering provided for the instruction of students. | [optional] 
 **schoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **schoolYear** | **int?**| The identifier for the school year. | [optional] 
 **sectionIdentifier** | **string**| The local identifier assigned to a section. | [optional] 
 **sessionName** | **string**| The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). | [optional] 
 **beginDate** | **DateTime?**| Month, day, and year of the Student&#39;s entry or assignment to the Section. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **competencyLevelDescriptor** | **string**| The CompetencyLevel assessed for the student for the referenced LearningObjective. | [optional] 
 **dateFulfilled** | **DateTime?**| The date an assignment was turned in or the date of an assessment. | [optional] 
 **diagnosticStatement** | **string**| A statement provided by the teacher that provides information in addition to the grade or assessment score. | [optional] 
 **id** | **string**|  | [optional] 
 **letterGradeEarned** | **string**| A final or interim (grading period) indicator of student performance in a class as submitted by the instructor. | [optional] 
 **numericGradeEarned** | **double?**| A final or interim (grading period) indicator of student performance in a class as submitted by the instructor. | [optional] 

### Return type

[**List<EdFiStudentGradebookEntry>**](EdFiStudentGradebookEntry.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentgradebookentriesbyid"></a>
# **GetStudentGradebookEntriesById**
> EdFiStudentGradebookEntry GetStudentGradebookEntriesById (string id, string ifNoneMatch = null)

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
    public class GetStudentGradebookEntriesByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentGradebookEntriesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentGradebookEntry result = apiInstance.GetStudentGradebookEntriesById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentGradebookEntriesApi.GetStudentGradebookEntriesById: " + e.Message );
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

[**EdFiStudentGradebookEntry**](EdFiStudentGradebookEntry.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentgradebookentry"></a>
# **PostStudentGradebookEntry**
> void PostStudentGradebookEntry (EdFiStudentGradebookEntry studentGradebookEntry)

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
    public class PostStudentGradebookEntryExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentGradebookEntriesApi();
            var studentGradebookEntry = new EdFiStudentGradebookEntry(); // EdFiStudentGradebookEntry | The JSON representation of the \"studentGradebookEntry\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentGradebookEntry(studentGradebookEntry);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentGradebookEntriesApi.PostStudentGradebookEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentGradebookEntry** | [**EdFiStudentGradebookEntry**](EdFiStudentGradebookEntry.md)| The JSON representation of the \&quot;studentGradebookEntry\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentgradebookentry"></a>
# **PutStudentGradebookEntry**
> void PutStudentGradebookEntry (string id, EdFiStudentGradebookEntry studentGradebookEntry, string ifMatch = null)

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
    public class PutStudentGradebookEntryExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentGradebookEntriesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentGradebookEntry = new EdFiStudentGradebookEntry(); // EdFiStudentGradebookEntry | The JSON representation of the \"studentGradebookEntry\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStudentGradebookEntry(id, studentGradebookEntry, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentGradebookEntriesApi.PutStudentGradebookEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentGradebookEntry** | [**EdFiStudentGradebookEntry**](EdFiStudentGradebookEntry.md)| The JSON representation of the \&quot;studentGradebookEntry\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

