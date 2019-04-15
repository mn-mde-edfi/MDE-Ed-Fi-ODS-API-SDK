# EdFi.OdsApi.Sdk.Apis.All.AcademicWeeksApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAcademicWeekById**](AcademicWeeksApi.md#deleteacademicweekbyid) | **DELETE** /ed-fi/academicWeeks/{id} | Deletes an existing resource using the resource identifier.
[**GetAcademicWeeks**](AcademicWeeksApi.md#getacademicweeks) | **GET** /ed-fi/academicWeeks | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetAcademicWeeksById**](AcademicWeeksApi.md#getacademicweeksbyid) | **GET** /ed-fi/academicWeeks/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostAcademicWeek**](AcademicWeeksApi.md#postacademicweek) | **POST** /ed-fi/academicWeeks | Creates or updates resources based on the natural key values of the supplied resource.
[**PutAcademicWeek**](AcademicWeeksApi.md#putacademicweek) | **PUT** /ed-fi/academicWeeks/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteacademicweekbyid"></a>
# **DeleteAcademicWeekById**
> void DeleteAcademicWeekById (string id, string ifMatch = null)

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
    public class DeleteAcademicWeekByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AcademicWeeksApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteAcademicWeekById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AcademicWeeksApi.DeleteAcademicWeekById: " + e.Message );
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

<a name="getacademicweeks"></a>
# **GetAcademicWeeks**
> List<EdFiAcademicWeek> GetAcademicWeeks (int? offset = null, int? limit = null, bool? totalCount = null, string weekIdentifier = null, int? schoolId = null, DateTime? beginDate = null, DateTime? endDate = null, string id = null, int? totalInstructionalDays = null)

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
    public class GetAcademicWeeksExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AcademicWeeksApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var weekIdentifier = weekIdentifier_example;  // string | The school label for the week. (optional) 
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var beginDate = 2013-10-20;  // DateTime? | The start date for the academic week. (optional) 
            var endDate = 2013-10-20;  // DateTime? | The end date for the academic week. (optional) 
            var id = id_example;  // string |  (optional) 
            var totalInstructionalDays = 56;  // int? | The total instructional days during the academic week. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiAcademicWeek&gt; result = apiInstance.GetAcademicWeeks(offset, limit, totalCount, weekIdentifier, schoolId, beginDate, endDate, id, totalInstructionalDays);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AcademicWeeksApi.GetAcademicWeeks: " + e.Message );
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
 **weekIdentifier** | **string**| The school label for the week. | [optional] 
 **schoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **beginDate** | **DateTime?**| The start date for the academic week. | [optional] 
 **endDate** | **DateTime?**| The end date for the academic week. | [optional] 
 **id** | **string**|  | [optional] 
 **totalInstructionalDays** | **int?**| The total instructional days during the academic week. | [optional] 

### Return type

[**List<EdFiAcademicWeek>**](EdFiAcademicWeek.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getacademicweeksbyid"></a>
# **GetAcademicWeeksById**
> EdFiAcademicWeek GetAcademicWeeksById (string id, string ifNoneMatch = null)

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
    public class GetAcademicWeeksByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AcademicWeeksApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiAcademicWeek result = apiInstance.GetAcademicWeeksById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AcademicWeeksApi.GetAcademicWeeksById: " + e.Message );
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

[**EdFiAcademicWeek**](EdFiAcademicWeek.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postacademicweek"></a>
# **PostAcademicWeek**
> void PostAcademicWeek (EdFiAcademicWeek academicWeek)

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
    public class PostAcademicWeekExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AcademicWeeksApi();
            var academicWeek = new EdFiAcademicWeek(); // EdFiAcademicWeek | The JSON representation of the \"academicWeek\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostAcademicWeek(academicWeek);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AcademicWeeksApi.PostAcademicWeek: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **academicWeek** | [**EdFiAcademicWeek**](EdFiAcademicWeek.md)| The JSON representation of the \&quot;academicWeek\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putacademicweek"></a>
# **PutAcademicWeek**
> void PutAcademicWeek (string id, EdFiAcademicWeek academicWeek, string ifMatch = null)

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
    public class PutAcademicWeekExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AcademicWeeksApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var academicWeek = new EdFiAcademicWeek(); // EdFiAcademicWeek | The JSON representation of the \"academicWeek\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutAcademicWeek(id, academicWeek, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AcademicWeeksApi.PutAcademicWeek: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **academicWeek** | [**EdFiAcademicWeek**](EdFiAcademicWeek.md)| The JSON representation of the \&quot;academicWeek\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

