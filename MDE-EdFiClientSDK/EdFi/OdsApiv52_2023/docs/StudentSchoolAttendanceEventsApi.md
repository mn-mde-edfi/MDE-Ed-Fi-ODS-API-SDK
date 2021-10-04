# EdFi.OdsApi.Sdk.Apis.Identity.StudentSchoolAttendanceEventsApi

All URIs are relative to *http://localhost:54746/data/v3/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentSchoolAttendanceEventById**](StudentSchoolAttendanceEventsApi.md#deletestudentschoolattendanceeventbyid) | **DELETE** /ed-fi/studentSchoolAttendanceEvents/{id} | Deletes an existing resource using the resource identifier.
[**DeletesStudentSchoolAttendanceEvents**](StudentSchoolAttendanceEventsApi.md#deletesstudentschoolattendanceevents) | **GET** /ed-fi/studentSchoolAttendanceEvents/deletes | Retrieves deleted resources based on change version.
[**GetStudentSchoolAttendanceEvents**](StudentSchoolAttendanceEventsApi.md#getstudentschoolattendanceevents) | **GET** /ed-fi/studentSchoolAttendanceEvents | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentSchoolAttendanceEventsById**](StudentSchoolAttendanceEventsApi.md#getstudentschoolattendanceeventsbyid) | **GET** /ed-fi/studentSchoolAttendanceEvents/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudentSchoolAttendanceEvent**](StudentSchoolAttendanceEventsApi.md#poststudentschoolattendanceevent) | **POST** /ed-fi/studentSchoolAttendanceEvents | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudentSchoolAttendanceEvent**](StudentSchoolAttendanceEventsApi.md#putstudentschoolattendanceevent) | **PUT** /ed-fi/studentSchoolAttendanceEvents/{id} | Updates a resource based on the resource identifier.


<a name="deletestudentschoolattendanceeventbyid"></a>
# **DeleteStudentSchoolAttendanceEventById**
> void DeleteStudentSchoolAttendanceEventById (string id, string ifMatch = null)

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
    public class DeleteStudentSchoolAttendanceEventByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAttendanceEventsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentSchoolAttendanceEventById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSchoolAttendanceEventsApi.DeleteStudentSchoolAttendanceEventById: " + e.Message );
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

<a name="deletesstudentschoolattendanceevents"></a>
# **DeletesStudentSchoolAttendanceEvents**
> List<DeletedResource> DeletesStudentSchoolAttendanceEvents (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, string snapshotIdentifier = null)

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
    public class DeletesStudentSchoolAttendanceEventsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAttendanceEventsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List&lt;DeletedResource&gt; result = apiInstance.DeletesStudentSchoolAttendanceEvents(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSchoolAttendanceEventsApi.DeletesStudentSchoolAttendanceEvents: " + e.Message );
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

<a name="getstudentschoolattendanceevents"></a>
# **GetStudentSchoolAttendanceEvents**
> List<EdFiStudentSchoolAttendanceEvent> GetStudentSchoolAttendanceEvents (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, bool? totalCount = null, string attendanceEventCategoryDescriptor = null, DateTime? eventDate = null, int? schoolId = null, int? schoolYear = null, string sessionName = null, string studentUniqueId = null, string educationalEnvironmentDescriptor = null, string arrivalTime = null, string attendanceEventReason = null, string departureTime = null, double? eventDuration = null, string id = null, int? schoolAttendanceDuration = null, string snapshotIdentifier = null)

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
    public class GetStudentSchoolAttendanceEventsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAttendanceEventsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var attendanceEventCategoryDescriptor = attendanceEventCategoryDescriptor_example;  // string | A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy. (optional) 
            var eventDate = 2013-10-20;  // DateTime? | Date for this attendance event. (optional) 
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var schoolYear = 56;  // int? | The identifier for the school year. (optional) 
            var sessionName = sessionName_example;  // string | The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var educationalEnvironmentDescriptor = educationalEnvironmentDescriptor_example;  // string | The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section. (optional) 
            var arrivalTime = arrivalTime_example;  // string | The time of day the student arrived for the attendance event in ISO 8601 format. (optional) 
            var attendanceEventReason = attendanceEventReason_example;  // string | The reported reason for a student's absence. (optional) 
            var departureTime = departureTime_example;  // string | The time of day the student departed for the attendance event in ISO 8601 format. (optional) 
            var eventDuration = 1.2;  // double? | The amount of time for the event as recognized by the school: 1 day = 1, 1/2 day = 0.5, 1/3 day = 0.33. (optional) 
            var id = id_example;  // string |  (optional) 
            var schoolAttendanceDuration = 56;  // int? | The duration in minutes of the school attendance event. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentSchoolAttendanceEvent&gt; result = apiInstance.GetStudentSchoolAttendanceEvents(offset, limit, minChangeVersion, maxChangeVersion, totalCount, attendanceEventCategoryDescriptor, eventDate, schoolId, schoolYear, sessionName, studentUniqueId, educationalEnvironmentDescriptor, arrivalTime, attendanceEventReason, departureTime, eventDuration, id, schoolAttendanceDuration, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSchoolAttendanceEventsApi.GetStudentSchoolAttendanceEvents: " + e.Message );
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
 **attendanceEventCategoryDescriptor** | **string**| A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy. | [optional] 
 **eventDate** | **DateTime?**| Date for this attendance event. | [optional] 
 **schoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **schoolYear** | **int?**| The identifier for the school year. | [optional] 
 **sessionName** | **string**| The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **educationalEnvironmentDescriptor** | **string**| The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section. | [optional] 
 **arrivalTime** | **string**| The time of day the student arrived for the attendance event in ISO 8601 format. | [optional] 
 **attendanceEventReason** | **string**| The reported reason for a student&#39;s absence. | [optional] 
 **departureTime** | **string**| The time of day the student departed for the attendance event in ISO 8601 format. | [optional] 
 **eventDuration** | **double?**| The amount of time for the event as recognized by the school: 1 day &#x3D; 1, 1/2 day &#x3D; 0.5, 1/3 day &#x3D; 0.33. | [optional] 
 **id** | **string**|  | [optional] 
 **schoolAttendanceDuration** | **int?**| The duration in minutes of the school attendance event. | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<EdFiStudentSchoolAttendanceEvent>**](EdFiStudentSchoolAttendanceEvent.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentschoolattendanceeventsbyid"></a>
# **GetStudentSchoolAttendanceEventsById**
> EdFiStudentSchoolAttendanceEvent GetStudentSchoolAttendanceEventsById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

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
    public class GetStudentSchoolAttendanceEventsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAttendanceEventsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentSchoolAttendanceEvent result = apiInstance.GetStudentSchoolAttendanceEventsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSchoolAttendanceEventsApi.GetStudentSchoolAttendanceEventsById: " + e.Message );
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

[**EdFiStudentSchoolAttendanceEvent**](EdFiStudentSchoolAttendanceEvent.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentschoolattendanceevent"></a>
# **PostStudentSchoolAttendanceEvent**
> void PostStudentSchoolAttendanceEvent (EdFiStudentSchoolAttendanceEvent studentSchoolAttendanceEvent)

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
    public class PostStudentSchoolAttendanceEventExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAttendanceEventsApi();
            var studentSchoolAttendanceEvent = new EdFiStudentSchoolAttendanceEvent(); // EdFiStudentSchoolAttendanceEvent | The JSON representation of the \"studentSchoolAttendanceEvent\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentSchoolAttendanceEvent(studentSchoolAttendanceEvent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSchoolAttendanceEventsApi.PostStudentSchoolAttendanceEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentSchoolAttendanceEvent** | [**EdFiStudentSchoolAttendanceEvent**](EdFiStudentSchoolAttendanceEvent.md)| The JSON representation of the \&quot;studentSchoolAttendanceEvent\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentschoolattendanceevent"></a>
# **PutStudentSchoolAttendanceEvent**
> void PutStudentSchoolAttendanceEvent (string id, EdFiStudentSchoolAttendanceEvent studentSchoolAttendanceEvent, string ifMatch = null)

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
    public class PutStudentSchoolAttendanceEventExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAttendanceEventsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentSchoolAttendanceEvent = new EdFiStudentSchoolAttendanceEvent(); // EdFiStudentSchoolAttendanceEvent | The JSON representation of the \"studentSchoolAttendanceEvent\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutStudentSchoolAttendanceEvent(id, studentSchoolAttendanceEvent, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSchoolAttendanceEventsApi.PutStudentSchoolAttendanceEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentSchoolAttendanceEvent** | [**EdFiStudentSchoolAttendanceEvent**](EdFiStudentSchoolAttendanceEvent.md)| The JSON representation of the \&quot;studentSchoolAttendanceEvent\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

