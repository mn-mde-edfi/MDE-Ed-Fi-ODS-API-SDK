# EdFi.OdsApi.Sdk.Apis.All.StudentAssessmentsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentAssessmentById**](StudentAssessmentsApi.md#deletestudentassessmentbyid) | **DELETE** /ed-fi/studentAssessments/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentAssessments**](StudentAssessmentsApi.md#getstudentassessments) | **GET** /ed-fi/studentAssessments | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentAssessmentsById**](StudentAssessmentsApi.md#getstudentassessmentsbyid) | **GET** /ed-fi/studentAssessments/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudentAssessment**](StudentAssessmentsApi.md#poststudentassessment) | **POST** /ed-fi/studentAssessments | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudentAssessment**](StudentAssessmentsApi.md#putstudentassessment) | **PUT** /ed-fi/studentAssessments/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudentassessmentbyid"></a>
# **DeleteStudentAssessmentById**
> void DeleteStudentAssessmentById (string id, string ifMatch = null)

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
    public class DeleteStudentAssessmentByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentAssessmentById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAssessmentsApi.DeleteStudentAssessmentById: " + e.Message );
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

<a name="getstudentassessments"></a>
# **GetStudentAssessments**
> List<EdFiStudentAssessment> GetStudentAssessments (int? offset = null, int? limit = null, bool? totalCount = null, string studentAssessmentIdentifier = null, string assessmentIdentifier = null, string _namespace = null, string studentUniqueId = null, int? schoolYear = null, string administrationEnvironmentDescriptor = null, string eventCircumstanceDescriptor = null, string whenAssessedGradeLevelDescriptor = null, string administrationLanguageDescriptor = null, string reasonNotTestedDescriptor = null, string retestIndicatorDescriptor = null, DateTime? administrationDate = null, DateTime? administrationEndDate = null, string eventDescription = null, string id = null, string serialNumber = null)

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
    public class GetStudentAssessmentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var studentAssessmentIdentifier = studentAssessmentIdentifier_example;  // string | A unique number or alphanumeric code assigned to an assessment administered to a student. (optional) 
            var assessmentIdentifier = assessmentIdentifier_example;  // string | A unique number or alphanumeric code assigned to an assessment. (optional) 
            var _namespace = _namespace_example;  // string | Namespace for the Assessment. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var schoolYear = 56;  // int? | The school year for which the assessment was administered to a student. Among other uses, handles cases in which a student takes a prior-year exam in a subsequent school year during an exam re-test. (optional) 
            var administrationEnvironmentDescriptor = administrationEnvironmentDescriptor_example;  // string | The environment in which the test was administered. For example:          Electronic          Classroom          Testing Center          ... (optional) 
            var eventCircumstanceDescriptor = eventCircumstanceDescriptor_example;  // string | An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc. (optional) 
            var whenAssessedGradeLevelDescriptor = whenAssessedGradeLevelDescriptor_example;  // string | The grade level of a student when assessed. (optional) 
            var administrationLanguageDescriptor = administrationLanguageDescriptor_example;  // string | The language in which an assessment is written and/or administered. (optional) 
            var reasonNotTestedDescriptor = reasonNotTestedDescriptor_example;  // string | The primary reason student is not tested. For example:          Absent          Refusal by parent          Refusal by student          Medical waiver          Illness          Disruptive behavior          LEP Exempt          ... (optional) 
            var retestIndicatorDescriptor = retestIndicatorDescriptor_example;  // string | Indicator if the test was retaken. For example:          Primary administration          First retest          Second retest          ... (optional) 
            var administrationDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time an assessment was completed by the student. The use of ISO-8601 formats with a timezone designator (UTC or time offset) is recommended in order to prevent ambiguity due to time zones. (optional) 
            var administrationEndDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time an assessment administration ended. (optional) 
            var eventDescription = eventDescription_example;  // string | Describes special events that occur before during or after the assessment session that may impact use of results. (optional) 
            var id = id_example;  // string |  (optional) 
            var serialNumber = serialNumber_example;  // string | The unique number for the assessment form or answer document. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentAssessment&gt; result = apiInstance.GetStudentAssessments(offset, limit, totalCount, studentAssessmentIdentifier, assessmentIdentifier, _namespace, studentUniqueId, schoolYear, administrationEnvironmentDescriptor, eventCircumstanceDescriptor, whenAssessedGradeLevelDescriptor, administrationLanguageDescriptor, reasonNotTestedDescriptor, retestIndicatorDescriptor, administrationDate, administrationEndDate, eventDescription, id, serialNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAssessmentsApi.GetStudentAssessments: " + e.Message );
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
 **studentAssessmentIdentifier** | **string**| A unique number or alphanumeric code assigned to an assessment administered to a student. | [optional] 
 **assessmentIdentifier** | **string**| A unique number or alphanumeric code assigned to an assessment. | [optional] 
 **_namespace** | **string**| Namespace for the Assessment. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **schoolYear** | **int?**| The school year for which the assessment was administered to a student. Among other uses, handles cases in which a student takes a prior-year exam in a subsequent school year during an exam re-test. | [optional] 
 **administrationEnvironmentDescriptor** | **string**| The environment in which the test was administered. For example:          Electronic          Classroom          Testing Center          ... | [optional] 
 **eventCircumstanceDescriptor** | **string**| An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc. | [optional] 
 **whenAssessedGradeLevelDescriptor** | **string**| The grade level of a student when assessed. | [optional] 
 **administrationLanguageDescriptor** | **string**| The language in which an assessment is written and/or administered. | [optional] 
 **reasonNotTestedDescriptor** | **string**| The primary reason student is not tested. For example:          Absent          Refusal by parent          Refusal by student          Medical waiver          Illness          Disruptive behavior          LEP Exempt          ... | [optional] 
 **retestIndicatorDescriptor** | **string**| Indicator if the test was retaken. For example:          Primary administration          First retest          Second retest          ... | [optional] 
 **administrationDate** | **DateTime?**| The date and time an assessment was completed by the student. The use of ISO-8601 formats with a timezone designator (UTC or time offset) is recommended in order to prevent ambiguity due to time zones. | [optional] 
 **administrationEndDate** | **DateTime?**| The date and time an assessment administration ended. | [optional] 
 **eventDescription** | **string**| Describes special events that occur before during or after the assessment session that may impact use of results. | [optional] 
 **id** | **string**|  | [optional] 
 **serialNumber** | **string**| The unique number for the assessment form or answer document. | [optional] 

### Return type

[**List<EdFiStudentAssessment>**](EdFiStudentAssessment.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentassessmentsbyid"></a>
# **GetStudentAssessmentsById**
> EdFiStudentAssessment GetStudentAssessmentsById (string id, string ifNoneMatch = null)

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
    public class GetStudentAssessmentsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentAssessment result = apiInstance.GetStudentAssessmentsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAssessmentsApi.GetStudentAssessmentsById: " + e.Message );
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

[**EdFiStudentAssessment**](EdFiStudentAssessment.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentassessment"></a>
# **PostStudentAssessment**
> void PostStudentAssessment (EdFiStudentAssessment studentAssessment)

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
    public class PostStudentAssessmentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentsApi();
            var studentAssessment = new EdFiStudentAssessment(); // EdFiStudentAssessment | The JSON representation of the \"studentAssessment\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentAssessment(studentAssessment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAssessmentsApi.PostStudentAssessment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentAssessment** | [**EdFiStudentAssessment**](EdFiStudentAssessment.md)| The JSON representation of the \&quot;studentAssessment\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentassessment"></a>
# **PutStudentAssessment**
> void PutStudentAssessment (string id, EdFiStudentAssessment studentAssessment, string ifMatch = null)

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
    public class PutStudentAssessmentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentAssessment = new EdFiStudentAssessment(); // EdFiStudentAssessment | The JSON representation of the \"studentAssessment\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStudentAssessment(id, studentAssessment, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAssessmentsApi.PutStudentAssessment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentAssessment** | [**EdFiStudentAssessment**](EdFiStudentAssessment.md)| The JSON representation of the \&quot;studentAssessment\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

