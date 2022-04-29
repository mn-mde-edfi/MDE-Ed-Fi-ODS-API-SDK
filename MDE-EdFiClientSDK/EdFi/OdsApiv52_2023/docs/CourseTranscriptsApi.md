# EdFi.OdsApi.Sdk.Apis.Identity.CourseTranscriptsApi

All URIs are relative to *https://test.edfi5.education.mn.gov:443/api/data/v3/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCourseTranscriptById**](CourseTranscriptsApi.md#deletecoursetranscriptbyid) | **DELETE** /ed-fi/courseTranscripts/{id} | Deletes an existing resource using the resource identifier.
[**DeletesCourseTranscripts**](CourseTranscriptsApi.md#deletescoursetranscripts) | **GET** /ed-fi/courseTranscripts/deletes | Retrieves deleted resources based on change version.
[**GetCourseTranscripts**](CourseTranscriptsApi.md#getcoursetranscripts) | **GET** /ed-fi/courseTranscripts | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetCourseTranscriptsById**](CourseTranscriptsApi.md#getcoursetranscriptsbyid) | **GET** /ed-fi/courseTranscripts/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostCourseTranscript**](CourseTranscriptsApi.md#postcoursetranscript) | **POST** /ed-fi/courseTranscripts | Creates or updates resources based on the natural key values of the supplied resource.
[**PutCourseTranscript**](CourseTranscriptsApi.md#putcoursetranscript) | **PUT** /ed-fi/courseTranscripts/{id} | Updates a resource based on the resource identifier.


<a name="deletecoursetranscriptbyid"></a>
# **DeleteCourseTranscriptById**
> void DeleteCourseTranscriptById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class DeleteCourseTranscriptByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseTranscriptsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteCourseTranscriptById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseTranscriptsApi.DeleteCourseTranscriptById: " + e.Message );
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

<a name="deletescoursetranscripts"></a>
# **DeletesCourseTranscripts**
> List<DeletedResource> DeletesCourseTranscripts (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, string snapshotIdentifier = null)

Retrieves deleted resources based on change version.

The DELETES operation is used to retrieve deleted resources.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class DeletesCourseTranscriptsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseTranscriptsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List&lt;DeletedResource&gt; result = apiInstance.DeletesCourseTranscripts(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseTranscriptsApi.DeletesCourseTranscripts: " + e.Message );
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
 **minChangeVersion** | **int?**| Used in synchronization to set sequence minimum ChangeVersion | [optional] 
 **maxChangeVersion** | **int?**| Used in synchronization to set sequence maximum ChangeVersion | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<DeletedResource>**](DeletedResource.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcoursetranscripts"></a>
# **GetCourseTranscripts**
> List<EdFiCourseTranscript> GetCourseTranscripts (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, bool? totalCount = null, string courseAttemptResultDescriptor = null, string courseCode = null, int? courseEducationOrganizationId = null, int? educationOrganizationId = null, int? schoolYear = null, string studentUniqueId = null, string termDescriptor = null, int? externalEducationOrganizationId = null, string courseRepeatCodeDescriptor = null, string attemptedCreditTypeDescriptor = null, string earnedCreditTypeDescriptor = null, string whenTakenGradeLevelDescriptor = null, string methodCreditEarnedDescriptor = null, string alternativeCourseCode = null, string alternativeCourseTitle = null, string assigningOrganizationIdentificationCode = null, double? attemptedCreditConversion = null, double? attemptedCredits = null, string courseCatalogURL = null, string courseTitle = null, double? earnedCreditConversion = null, double? earnedCredits = null, string finalLetterGradeEarned = null, double? finalNumericGradeEarned = null, string id = null, string snapshotIdentifier = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class GetCourseTranscriptsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseTranscriptsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var courseAttemptResultDescriptor = courseAttemptResultDescriptor_example;  // string | The result from the student's attempt to take the course, for example:         Pass         Fail         Incomplete         Withdrawn. (optional) 
            var courseCode = courseCode_example;  // string | A unique alphanumeric code assigned to a course. (optional) 
            var courseEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var schoolYear = 56;  // int? | The identifier for the school year. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var termDescriptor = termDescriptor_example;  // string | The term for the session during the school year. (optional) 
            var externalEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var courseRepeatCodeDescriptor = courseRepeatCodeDescriptor_example;  // string | Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student's academic grade average. (optional) 
            var attemptedCreditTypeDescriptor = attemptedCreditTypeDescriptor_example;  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var earnedCreditTypeDescriptor = earnedCreditTypeDescriptor_example;  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var whenTakenGradeLevelDescriptor = whenTakenGradeLevelDescriptor_example;  // string | Student's grade level at time of course. (optional) 
            var methodCreditEarnedDescriptor = methodCreditEarnedDescriptor_example;  // string | The method the credits were earned (e.g., Classroom, Examination, Transfer). (optional) 
            var alternativeCourseCode = alternativeCourseCode_example;  // string | The local code assigned by the school that identifies the course offering, the code from an external educational organization, or other alternate course code. (optional) 
            var alternativeCourseTitle = alternativeCourseTitle_example;  // string | The descriptive name given to a course of study offered in the school, if different from the CourseTitle. (optional) 
            var assigningOrganizationIdentificationCode = assigningOrganizationIdentificationCode_example;  // string | The organization code or name assigning the course identification code. (optional) 
            var attemptedCreditConversion = 1.2;  // double? | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var attemptedCredits = 1.2;  // double? | The value of credits or units of value awarded for the completion of a course. (optional) 
            var courseCatalogURL = courseCatalogURL_example;  // string | The URL for the course catalog that defines the course identification code. (optional) 
            var courseTitle = courseTitle_example;  // string | The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, language arts). (optional) 
            var earnedCreditConversion = 1.2;  // double? | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var earnedCredits = 1.2;  // double? | The value of credits or units of value awarded for the completion of a course. (optional) 
            var finalLetterGradeEarned = finalLetterGradeEarned_example;  // string | The final indicator of student performance in a class as submitted by the instructor. (optional) 
            var finalNumericGradeEarned = 1.2;  // double? | The final indicator of student performance in a class as submitted by the instructor. (optional) 
            var id = id_example;  // string |  (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiCourseTranscript&gt; result = apiInstance.GetCourseTranscripts(offset, limit, minChangeVersion, maxChangeVersion, totalCount, courseAttemptResultDescriptor, courseCode, courseEducationOrganizationId, educationOrganizationId, schoolYear, studentUniqueId, termDescriptor, externalEducationOrganizationId, courseRepeatCodeDescriptor, attemptedCreditTypeDescriptor, earnedCreditTypeDescriptor, whenTakenGradeLevelDescriptor, methodCreditEarnedDescriptor, alternativeCourseCode, alternativeCourseTitle, assigningOrganizationIdentificationCode, attemptedCreditConversion, attemptedCredits, courseCatalogURL, courseTitle, earnedCreditConversion, earnedCredits, finalLetterGradeEarned, finalNumericGradeEarned, id, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseTranscriptsApi.GetCourseTranscripts: " + e.Message );
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
 **minChangeVersion** | **int?**| Used in synchronization to set sequence minimum ChangeVersion | [optional] 
 **maxChangeVersion** | **int?**| Used in synchronization to set sequence maximum ChangeVersion | [optional] 
 **totalCount** | **bool?**| Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false]
 **courseAttemptResultDescriptor** | **string**| The result from the student&#39;s attempt to take the course, for example:         Pass         Fail         Incomplete         Withdrawn. | [optional] 
 **courseCode** | **string**| A unique alphanumeric code assigned to a course. | [optional] 
 **courseEducationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **schoolYear** | **int?**| The identifier for the school year. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **termDescriptor** | **string**| The term for the session during the school year. | [optional] 
 **externalEducationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **courseRepeatCodeDescriptor** | **string**| Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student&#39;s academic grade average. | [optional] 
 **attemptedCreditTypeDescriptor** | **string**| The type of credits or units of value awarded for the completion of a course. | [optional] 
 **earnedCreditTypeDescriptor** | **string**| The type of credits or units of value awarded for the completion of a course. | [optional] 
 **whenTakenGradeLevelDescriptor** | **string**| Student&#39;s grade level at time of course. | [optional] 
 **methodCreditEarnedDescriptor** | **string**| The method the credits were earned (e.g., Classroom, Examination, Transfer). | [optional] 
 **alternativeCourseCode** | **string**| The local code assigned by the school that identifies the course offering, the code from an external educational organization, or other alternate course code. | [optional] 
 **alternativeCourseTitle** | **string**| The descriptive name given to a course of study offered in the school, if different from the CourseTitle. | [optional] 
 **assigningOrganizationIdentificationCode** | **string**| The organization code or name assigning the course identification code. | [optional] 
 **attemptedCreditConversion** | **double?**| Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
 **attemptedCredits** | **double?**| The value of credits or units of value awarded for the completion of a course. | [optional] 
 **courseCatalogURL** | **string**| The URL for the course catalog that defines the course identification code. | [optional] 
 **courseTitle** | **string**| The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, language arts). | [optional] 
 **earnedCreditConversion** | **double?**| Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
 **earnedCredits** | **double?**| The value of credits or units of value awarded for the completion of a course. | [optional] 
 **finalLetterGradeEarned** | **string**| The final indicator of student performance in a class as submitted by the instructor. | [optional] 
 **finalNumericGradeEarned** | **double?**| The final indicator of student performance in a class as submitted by the instructor. | [optional] 
 **id** | **string**|  | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<EdFiCourseTranscript>**](EdFiCourseTranscript.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcoursetranscriptsbyid"></a>
# **GetCourseTranscriptsById**
> EdFiCourseTranscript GetCourseTranscriptsById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class GetCourseTranscriptsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseTranscriptsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiCourseTranscript result = apiInstance.GetCourseTranscriptsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseTranscriptsApi.GetCourseTranscriptsById: " + e.Message );
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
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**EdFiCourseTranscript**](EdFiCourseTranscript.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcoursetranscript"></a>
# **PostCourseTranscript**
> void PostCourseTranscript (EdFiCourseTranscript courseTranscript)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error. The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately. It is recommended to use POST for both create and update except while updating natural key of a resource in which case PUT operation must be used.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class PostCourseTranscriptExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseTranscriptsApi();
            var courseTranscript = new EdFiCourseTranscript(); // EdFiCourseTranscript | The JSON representation of the \"courseTranscript\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostCourseTranscript(courseTranscript);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseTranscriptsApi.PostCourseTranscript: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **courseTranscript** | [**EdFiCourseTranscript**](EdFiCourseTranscript.md)| The JSON representation of the \&quot;courseTranscript\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcoursetranscript"></a>
# **PutCourseTranscript**
> void PutCourseTranscript (string id, EdFiCourseTranscript courseTranscript, string ifMatch = null)

Updates a resource based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, this API resource is not configured for cascading natural key updates. Natural key values for this resource cannot be changed using PUT operation and will not be modified in the database, and so recommendation is to use POST as that supports upsert behavior.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class PutCourseTranscriptExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CourseTranscriptsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var courseTranscript = new EdFiCourseTranscript(); // EdFiCourseTranscript | The JSON representation of the \"courseTranscript\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutCourseTranscript(id, courseTranscript, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CourseTranscriptsApi.PutCourseTranscript: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **courseTranscript** | [**EdFiCourseTranscript**](EdFiCourseTranscript.md)| The JSON representation of the \&quot;courseTranscript\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

