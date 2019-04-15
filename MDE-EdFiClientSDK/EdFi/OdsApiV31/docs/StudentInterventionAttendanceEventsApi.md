# EdFi.OdsApi.Sdk.Apis.All.StudentInterventionAttendanceEventsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentInterventionAttendanceEventById**](StudentInterventionAttendanceEventsApi.md#deletestudentinterventionattendanceeventbyid) | **DELETE** /ed-fi/studentInterventionAttendanceEvents/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentInterventionAttendanceEvents**](StudentInterventionAttendanceEventsApi.md#getstudentinterventionattendanceevents) | **GET** /ed-fi/studentInterventionAttendanceEvents | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentInterventionAttendanceEventsById**](StudentInterventionAttendanceEventsApi.md#getstudentinterventionattendanceeventsbyid) | **GET** /ed-fi/studentInterventionAttendanceEvents/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudentInterventionAttendanceEvent**](StudentInterventionAttendanceEventsApi.md#poststudentinterventionattendanceevent) | **POST** /ed-fi/studentInterventionAttendanceEvents | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudentInterventionAttendanceEvent**](StudentInterventionAttendanceEventsApi.md#putstudentinterventionattendanceevent) | **PUT** /ed-fi/studentInterventionAttendanceEvents/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudentinterventionattendanceeventbyid"></a>
# **DeleteStudentInterventionAttendanceEventById**
> void DeleteStudentInterventionAttendanceEventById (string id, string ifMatch = null)

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
    public class DeleteStudentInterventionAttendanceEventByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentInterventionAttendanceEventsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentInterventionAttendanceEventById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentInterventionAttendanceEventsApi.DeleteStudentInterventionAttendanceEventById: " + e.Message );
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

<a name="getstudentinterventionattendanceevents"></a>
# **GetStudentInterventionAttendanceEvents**
> List<EdFiStudentInterventionAttendanceEvent> GetStudentInterventionAttendanceEvents (int? offset = null, int? limit = null, bool? totalCount = null, string attendanceEventCategoryDescriptor = null, DateTime? eventDate = null, int? educationOrganizationId = null, string interventionIdentificationCode = null, string studentUniqueId = null, string educationalEnvironmentDescriptor = null, string attendanceEventReason = null, double? eventDuration = null, string id = null, int? interventionDuration = null)

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
    public class GetStudentInterventionAttendanceEventsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentInterventionAttendanceEventsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var attendanceEventCategoryDescriptor = attendanceEventCategoryDescriptor_example;  // string | A code describing the attendance event, for example:          Present          Unexcused absence          Excused absence          Tardy. (optional) 
            var eventDate = 2013-10-20;  // DateTime? | Date for this attendance event. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var interventionIdentificationCode = interventionIdentificationCode_example;  // string | A unique number or alphanumeric code assigned to an intervention. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var educationalEnvironmentDescriptor = educationalEnvironmentDescriptor_example;  // string | The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section. (optional) 
            var attendanceEventReason = attendanceEventReason_example;  // string | The reported reason for a student's absence. (optional) 
            var eventDuration = 1.2;  // double? | The amount of time for the event as recognized by the school: 1 day = 1, 1/2 day = 0.5, 1/3 day = 0.33. (optional) 
            var id = id_example;  // string |  (optional) 
            var interventionDuration = 56;  // int? | The duration in minutes in which the student participated in the intervention during this instance. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentInterventionAttendanceEvent&gt; result = apiInstance.GetStudentInterventionAttendanceEvents(offset, limit, totalCount, attendanceEventCategoryDescriptor, eventDate, educationOrganizationId, interventionIdentificationCode, studentUniqueId, educationalEnvironmentDescriptor, attendanceEventReason, eventDuration, id, interventionDuration);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentInterventionAttendanceEventsApi.GetStudentInterventionAttendanceEvents: " + e.Message );
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
 **attendanceEventCategoryDescriptor** | **string**| A code describing the attendance event, for example:          Present          Unexcused absence          Excused absence          Tardy. | [optional] 
 **eventDate** | **DateTime?**| Date for this attendance event. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **interventionIdentificationCode** | **string**| A unique number or alphanumeric code assigned to an intervention. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **educationalEnvironmentDescriptor** | **string**| The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section. | [optional] 
 **attendanceEventReason** | **string**| The reported reason for a student&#39;s absence. | [optional] 
 **eventDuration** | **double?**| The amount of time for the event as recognized by the school: 1 day &#x3D; 1, 1/2 day &#x3D; 0.5, 1/3 day &#x3D; 0.33. | [optional] 
 **id** | **string**|  | [optional] 
 **interventionDuration** | **int?**| The duration in minutes in which the student participated in the intervention during this instance. | [optional] 

### Return type

[**List<EdFiStudentInterventionAttendanceEvent>**](EdFiStudentInterventionAttendanceEvent.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentinterventionattendanceeventsbyid"></a>
# **GetStudentInterventionAttendanceEventsById**
> EdFiStudentInterventionAttendanceEvent GetStudentInterventionAttendanceEventsById (string id, string ifNoneMatch = null)

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
    public class GetStudentInterventionAttendanceEventsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentInterventionAttendanceEventsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentInterventionAttendanceEvent result = apiInstance.GetStudentInterventionAttendanceEventsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentInterventionAttendanceEventsApi.GetStudentInterventionAttendanceEventsById: " + e.Message );
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

[**EdFiStudentInterventionAttendanceEvent**](EdFiStudentInterventionAttendanceEvent.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentinterventionattendanceevent"></a>
# **PostStudentInterventionAttendanceEvent**
> void PostStudentInterventionAttendanceEvent (EdFiStudentInterventionAttendanceEvent studentInterventionAttendanceEvent)

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
    public class PostStudentInterventionAttendanceEventExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentInterventionAttendanceEventsApi();
            var studentInterventionAttendanceEvent = new EdFiStudentInterventionAttendanceEvent(); // EdFiStudentInterventionAttendanceEvent | The JSON representation of the \"studentInterventionAttendanceEvent\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentInterventionAttendanceEvent(studentInterventionAttendanceEvent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentInterventionAttendanceEventsApi.PostStudentInterventionAttendanceEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentInterventionAttendanceEvent** | [**EdFiStudentInterventionAttendanceEvent**](EdFiStudentInterventionAttendanceEvent.md)| The JSON representation of the \&quot;studentInterventionAttendanceEvent\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentinterventionattendanceevent"></a>
# **PutStudentInterventionAttendanceEvent**
> void PutStudentInterventionAttendanceEvent (string id, EdFiStudentInterventionAttendanceEvent studentInterventionAttendanceEvent, string ifMatch = null)

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
    public class PutStudentInterventionAttendanceEventExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentInterventionAttendanceEventsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentInterventionAttendanceEvent = new EdFiStudentInterventionAttendanceEvent(); // EdFiStudentInterventionAttendanceEvent | The JSON representation of the \"studentInterventionAttendanceEvent\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStudentInterventionAttendanceEvent(id, studentInterventionAttendanceEvent, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentInterventionAttendanceEventsApi.PutStudentInterventionAttendanceEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentInterventionAttendanceEvent** | [**EdFiStudentInterventionAttendanceEvent**](EdFiStudentInterventionAttendanceEvent.md)| The JSON representation of the \&quot;studentInterventionAttendanceEvent\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

