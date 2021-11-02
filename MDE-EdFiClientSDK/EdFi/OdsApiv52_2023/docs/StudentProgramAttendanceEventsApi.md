# EdFi.OdsApi.Sdk.Apis.Identity.StudentProgramAttendanceEventsApi

All URIs are relative to *http://localhost:54746/data/v3/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentProgramAttendanceEventById**](StudentProgramAttendanceEventsApi.md#deletestudentprogramattendanceeventbyid) | **DELETE** /ed-fi/studentProgramAttendanceEvents/{id} | Deletes an existing resource using the resource identifier.
[**DeletesStudentProgramAttendanceEvents**](StudentProgramAttendanceEventsApi.md#deletesstudentprogramattendanceevents) | **GET** /ed-fi/studentProgramAttendanceEvents/deletes | Retrieves deleted resources based on change version.
[**GetStudentProgramAttendanceEvents**](StudentProgramAttendanceEventsApi.md#getstudentprogramattendanceevents) | **GET** /ed-fi/studentProgramAttendanceEvents | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentProgramAttendanceEventsById**](StudentProgramAttendanceEventsApi.md#getstudentprogramattendanceeventsbyid) | **GET** /ed-fi/studentProgramAttendanceEvents/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudentProgramAttendanceEvent**](StudentProgramAttendanceEventsApi.md#poststudentprogramattendanceevent) | **POST** /ed-fi/studentProgramAttendanceEvents | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudentProgramAttendanceEvent**](StudentProgramAttendanceEventsApi.md#putstudentprogramattendanceevent) | **PUT** /ed-fi/studentProgramAttendanceEvents/{id} | Updates a resource based on the resource identifier.


<a name="deletestudentprogramattendanceeventbyid"></a>
# **DeleteStudentProgramAttendanceEventById**
> void DeleteStudentProgramAttendanceEventById (string id, string ifMatch = null)

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
    public class DeleteStudentProgramAttendanceEventByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentProgramAttendanceEventsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentProgramAttendanceEventById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentProgramAttendanceEventsApi.DeleteStudentProgramAttendanceEventById: " + e.Message );
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

<a name="deletesstudentprogramattendanceevents"></a>
# **DeletesStudentProgramAttendanceEvents**
> List<DeletedResource> DeletesStudentProgramAttendanceEvents (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, string snapshotIdentifier = null)

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
    public class DeletesStudentProgramAttendanceEventsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentProgramAttendanceEventsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List&lt;DeletedResource&gt; result = apiInstance.DeletesStudentProgramAttendanceEvents(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentProgramAttendanceEventsApi.DeletesStudentProgramAttendanceEvents: " + e.Message );
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

<a name="getstudentprogramattendanceevents"></a>
# **GetStudentProgramAttendanceEvents**
> List<EdFiStudentProgramAttendanceEvent> GetStudentProgramAttendanceEvents (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, bool? totalCount = null, string attendanceEventCategoryDescriptor = null, DateTime? eventDate = null, int? educationOrganizationId = null, int? programEducationOrganizationId = null, string programName = null, string programTypeDescriptor = null, string studentUniqueId = null, string educationalEnvironmentDescriptor = null, string attendanceEventReason = null, double? eventDuration = null, string id = null, int? programAttendanceDuration = null, string snapshotIdentifier = null)

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
    public class GetStudentProgramAttendanceEventsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentProgramAttendanceEventsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var attendanceEventCategoryDescriptor = attendanceEventCategoryDescriptor_example;  // string | A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy. (optional) 
            var eventDate = 2013-10-20;  // DateTime? | Date for this attendance event. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programName = programName_example;  // string | The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. (optional) 
            var programTypeDescriptor = programTypeDescriptor_example;  // string | The type of program. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var educationalEnvironmentDescriptor = educationalEnvironmentDescriptor_example;  // string | The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section. (optional) 
            var attendanceEventReason = attendanceEventReason_example;  // string | The reported reason for a student's absence. (optional) 
            var eventDuration = 1.2;  // double? | The amount of time for the event as recognized by the school: 1 day = 1, 1/2 day = 0.5, 1/3 day = 0.33. (optional) 
            var id = id_example;  // string |  (optional) 
            var programAttendanceDuration = 56;  // int? | The duration in minutes of the program attendance event. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentProgramAttendanceEvent&gt; result = apiInstance.GetStudentProgramAttendanceEvents(offset, limit, minChangeVersion, maxChangeVersion, totalCount, attendanceEventCategoryDescriptor, eventDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, educationalEnvironmentDescriptor, attendanceEventReason, eventDuration, id, programAttendanceDuration, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentProgramAttendanceEventsApi.GetStudentProgramAttendanceEvents: " + e.Message );
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
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **programEducationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **programName** | **string**| The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. | [optional] 
 **programTypeDescriptor** | **string**| The type of program. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **educationalEnvironmentDescriptor** | **string**| The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section. | [optional] 
 **attendanceEventReason** | **string**| The reported reason for a student&#39;s absence. | [optional] 
 **eventDuration** | **double?**| The amount of time for the event as recognized by the school: 1 day &#x3D; 1, 1/2 day &#x3D; 0.5, 1/3 day &#x3D; 0.33. | [optional] 
 **id** | **string**|  | [optional] 
 **programAttendanceDuration** | **int?**| The duration in minutes of the program attendance event. | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<EdFiStudentProgramAttendanceEvent>**](EdFiStudentProgramAttendanceEvent.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentprogramattendanceeventsbyid"></a>
# **GetStudentProgramAttendanceEventsById**
> EdFiStudentProgramAttendanceEvent GetStudentProgramAttendanceEventsById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

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
    public class GetStudentProgramAttendanceEventsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentProgramAttendanceEventsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentProgramAttendanceEvent result = apiInstance.GetStudentProgramAttendanceEventsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentProgramAttendanceEventsApi.GetStudentProgramAttendanceEventsById: " + e.Message );
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

[**EdFiStudentProgramAttendanceEvent**](EdFiStudentProgramAttendanceEvent.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentprogramattendanceevent"></a>
# **PostStudentProgramAttendanceEvent**
> void PostStudentProgramAttendanceEvent (EdFiStudentProgramAttendanceEvent studentProgramAttendanceEvent)

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
    public class PostStudentProgramAttendanceEventExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentProgramAttendanceEventsApi();
            var studentProgramAttendanceEvent = new EdFiStudentProgramAttendanceEvent(); // EdFiStudentProgramAttendanceEvent | The JSON representation of the \"studentProgramAttendanceEvent\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentProgramAttendanceEvent(studentProgramAttendanceEvent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentProgramAttendanceEventsApi.PostStudentProgramAttendanceEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentProgramAttendanceEvent** | [**EdFiStudentProgramAttendanceEvent**](EdFiStudentProgramAttendanceEvent.md)| The JSON representation of the \&quot;studentProgramAttendanceEvent\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentprogramattendanceevent"></a>
# **PutStudentProgramAttendanceEvent**
> void PutStudentProgramAttendanceEvent (string id, EdFiStudentProgramAttendanceEvent studentProgramAttendanceEvent, string ifMatch = null)

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
    public class PutStudentProgramAttendanceEventExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentProgramAttendanceEventsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentProgramAttendanceEvent = new EdFiStudentProgramAttendanceEvent(); // EdFiStudentProgramAttendanceEvent | The JSON representation of the \"studentProgramAttendanceEvent\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutStudentProgramAttendanceEvent(id, studentProgramAttendanceEvent, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentProgramAttendanceEventsApi.PutStudentProgramAttendanceEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentProgramAttendanceEvent** | [**EdFiStudentProgramAttendanceEvent**](EdFiStudentProgramAttendanceEvent.md)| The JSON representation of the \&quot;studentProgramAttendanceEvent\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

