# EdFi.OdsApi.Sdk.Apis.All.GradebookEntriesApi

All URIs are relative to *https://localhost:56641/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteGradebookEntryById**](GradebookEntriesApi.md#deletegradebookentrybyid) | **DELETE** /ed-fi/gradebookEntries/{id} | Deletes an existing resource using the resource identifier.
[**GetGradebookEntries**](GradebookEntriesApi.md#getgradebookentries) | **GET** /ed-fi/gradebookEntries | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetGradebookEntriesById**](GradebookEntriesApi.md#getgradebookentriesbyid) | **GET** /ed-fi/gradebookEntries/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostGradebookEntry**](GradebookEntriesApi.md#postgradebookentry) | **POST** /ed-fi/gradebookEntries | Creates or updates resources based on the natural key values of the supplied resource.
[**PutGradebookEntry**](GradebookEntriesApi.md#putgradebookentry) | **PUT** /ed-fi/gradebookEntries/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletegradebookentrybyid"></a>
# **DeleteGradebookEntryById**
> void DeleteGradebookEntryById (string id, string ifMatch = null)

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
    public class DeleteGradebookEntryByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GradebookEntriesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteGradebookEntryById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GradebookEntriesApi.DeleteGradebookEntryById: " + e.Message );
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

<a name="getgradebookentries"></a>
# **GetGradebookEntries**
> List<EdFiGradebookEntry> GetGradebookEntries (int? offset = null, int? limit = null, bool? totalCount = null, DateTime? dateAssigned = null, string gradebookEntryTitle = null, string localCourseCode = null, int? schoolId = null, int? schoolYear = null, string sectionIdentifier = null, string sessionName = null, string gradingPeriodDescriptor = null, int? periodSequence = null, string gradebookEntryTypeDescriptor = null, string description = null, string id = null)

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
    public class GetGradebookEntriesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GradebookEntriesApi();
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
            var gradingPeriodDescriptor = gradingPeriodDescriptor_example;  // string | The name of the period for which grades are reported. (optional) 
            var periodSequence = 56;  // int? | The sequential order of this period relative to other periods. (optional) 
            var gradebookEntryTypeDescriptor = gradebookEntryTypeDescriptor_example;  // string | The type of the GradebookEntry; for example, homework, assignment, quiz, unit test, oral presentation, etc. (optional) 
            var description = description_example;  // string | A description of the assignment, homework, or classroom assessment. (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiGradebookEntry&gt; result = apiInstance.GetGradebookEntries(offset, limit, totalCount, dateAssigned, gradebookEntryTitle, localCourseCode, schoolId, schoolYear, sectionIdentifier, sessionName, gradingPeriodDescriptor, periodSequence, gradebookEntryTypeDescriptor, description, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GradebookEntriesApi.GetGradebookEntries: " + e.Message );
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
 **gradingPeriodDescriptor** | **string**| The name of the period for which grades are reported. | [optional] 
 **periodSequence** | **int?**| The sequential order of this period relative to other periods. | [optional] 
 **gradebookEntryTypeDescriptor** | **string**| The type of the GradebookEntry; for example, homework, assignment, quiz, unit test, oral presentation, etc. | [optional] 
 **description** | **string**| A description of the assignment, homework, or classroom assessment. | [optional] 
 **id** | **string**|  | [optional] 

### Return type

[**List<EdFiGradebookEntry>**](EdFiGradebookEntry.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgradebookentriesbyid"></a>
# **GetGradebookEntriesById**
> EdFiGradebookEntry GetGradebookEntriesById (string id, string ifNoneMatch = null)

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
    public class GetGradebookEntriesByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GradebookEntriesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiGradebookEntry result = apiInstance.GetGradebookEntriesById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GradebookEntriesApi.GetGradebookEntriesById: " + e.Message );
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

[**EdFiGradebookEntry**](EdFiGradebookEntry.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgradebookentry"></a>
# **PostGradebookEntry**
> void PostGradebookEntry (EdFiGradebookEntry gradebookEntry)

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
    public class PostGradebookEntryExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GradebookEntriesApi();
            var gradebookEntry = new EdFiGradebookEntry(); // EdFiGradebookEntry | The JSON representation of the \"gradebookEntry\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostGradebookEntry(gradebookEntry);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GradebookEntriesApi.PostGradebookEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gradebookEntry** | [**EdFiGradebookEntry**](EdFiGradebookEntry.md)| The JSON representation of the \&quot;gradebookEntry\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putgradebookentry"></a>
# **PutGradebookEntry**
> void PutGradebookEntry (string id, EdFiGradebookEntry gradebookEntry, string ifMatch = null)

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
    public class PutGradebookEntryExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GradebookEntriesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var gradebookEntry = new EdFiGradebookEntry(); // EdFiGradebookEntry | The JSON representation of the \"gradebookEntry\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutGradebookEntry(id, gradebookEntry, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GradebookEntriesApi.PutGradebookEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **gradebookEntry** | [**EdFiGradebookEntry**](EdFiGradebookEntry.md)| The JSON representation of the \&quot;gradebookEntry\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

