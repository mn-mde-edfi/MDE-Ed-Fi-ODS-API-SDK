# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile.CalendarDatesApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/sb21_/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletecalendarDateById**](CalendarDatesApi.md#deletecalendardatebyid) | **DELETE** /ed-fi/calendarDates/{id} | Deletes an existing resource using the resource identifier.
[**GetCalendarDates**](CalendarDatesApi.md#getcalendardates) | **GET** /ed-fi/calendarDates | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetCalendarDatesById**](CalendarDatesApi.md#getcalendardatesbyid) | **GET** /ed-fi/calendarDates/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostcalendarDate**](CalendarDatesApi.md#postcalendardate) | **POST** /ed-fi/calendarDates | Creates or updates resources based on the natural key values of the supplied resource.
[**PutcalendarDate**](CalendarDatesApi.md#putcalendardate) | **PUT** /ed-fi/calendarDates/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletecalendardatebyid"></a>
# **DeletecalendarDateById**
> void DeletecalendarDateById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;

namespace Example
{
    public class DeletecalendarDateByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarDatesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeletecalendarDateById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarDatesApi.DeletecalendarDateById: " + e.Message );
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

 - **Content-Type**: application/vnd.ed-fi.calendardate.minnesota-twentyone-twentytwo-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcalendardates"></a>
# **GetCalendarDates**
> List<EdFiCalendarDateReadable> GetCalendarDates (int? offset = null, int? limit = null, bool? totalCount = null, DateTime? date = null, string calendarCode = null, int? schoolId = null, int? schoolYear = null, string id = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;

namespace Example
{
    public class GetCalendarDatesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarDatesApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var date = 2013-10-20;  // DateTime? | The month, day, and year of the CalendarEvent. (optional) 
            var calendarCode = calendarCode_example;  // string | The identifier for the Calendar. (optional) 
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var schoolYear = 56;  // int? | The identifier for the school year associated with the Calendar. (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiCalendarDateReadable&gt; result = apiInstance.GetCalendarDates(offset, limit, totalCount, date, calendarCode, schoolId, schoolYear, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarDatesApi.GetCalendarDates: " + e.Message );
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
 **date** | **DateTime?**| The month, day, and year of the CalendarEvent. | [optional] 
 **calendarCode** | **string**| The identifier for the Calendar. | [optional] 
 **schoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **schoolYear** | **int?**| The identifier for the school year associated with the Calendar. | [optional] 
 **id** | **string**|  | [optional] 

### Return type

[**List<EdFiCalendarDateReadable>**](EdFiCalendarDateReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.calendardate.minnesota-twentyone-twentytwo-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcalendardatesbyid"></a>
# **GetCalendarDatesById**
> EdFiCalendarDateReadable GetCalendarDatesById (string id, string ifNoneMatch = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;

namespace Example
{
    public class GetCalendarDatesByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarDatesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiCalendarDateReadable result = apiInstance.GetCalendarDatesById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarDatesApi.GetCalendarDatesById: " + e.Message );
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

[**EdFiCalendarDateReadable**](EdFiCalendarDateReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.calendardate.minnesota-twentyone-twentytwo-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcalendardate"></a>
# **PostcalendarDate**
> void PostcalendarDate (EdFiCalendarDateWritable calendarDate)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error (you must use a PUT operation to update a resource by \"id\"). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;

namespace Example
{
    public class PostcalendarDateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarDatesApi();
            var calendarDate = new EdFiCalendarDateWritable(); // EdFiCalendarDateWritable | The JSON representation of the \"calendarDate\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostcalendarDate(calendarDate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarDatesApi.PostcalendarDate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **calendarDate** | [**EdFiCalendarDateWritable**](EdFiCalendarDateWritable.md)| The JSON representation of the \&quot;calendarDate\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.calendardate.minnesota-twentyone-twentytwo-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcalendardate"></a>
# **PutcalendarDate**
> void PutcalendarDate (string id, EdFiCalendarDateWritable calendarDate, string ifMatch = null)

Updates or creates a resource based on the resource identifier.

The PUT operation is used to update or create a resource by identifier. If the resource doesn't exist, the resource will be created using that identifier. Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource \"id\" is provided in the JSON body, it will be ignored as well.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;

namespace Example
{
    public class PutcalendarDateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CalendarDatesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var calendarDate = new EdFiCalendarDateWritable(); // EdFiCalendarDateWritable | The JSON representation of the \"calendarDate\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutcalendarDate(id, calendarDate, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CalendarDatesApi.PutcalendarDate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **calendarDate** | [**EdFiCalendarDateWritable**](EdFiCalendarDateWritable.md)| The JSON representation of the \&quot;calendarDate\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.calendardate.minnesota-twentyone-twentytwo-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

