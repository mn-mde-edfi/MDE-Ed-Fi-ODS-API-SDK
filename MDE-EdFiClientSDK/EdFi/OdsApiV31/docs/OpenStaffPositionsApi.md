# EdFi.OdsApi.Sdk.Apis.All.OpenStaffPositionsApi

All URIs are relative to *https://localhost:56641/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteOpenStaffPositionById**](OpenStaffPositionsApi.md#deleteopenstaffpositionbyid) | **DELETE** /ed-fi/openStaffPositions/{id} | Deletes an existing resource using the resource identifier.
[**GetOpenStaffPositions**](OpenStaffPositionsApi.md#getopenstaffpositions) | **GET** /ed-fi/openStaffPositions | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetOpenStaffPositionsById**](OpenStaffPositionsApi.md#getopenstaffpositionsbyid) | **GET** /ed-fi/openStaffPositions/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostOpenStaffPosition**](OpenStaffPositionsApi.md#postopenstaffposition) | **POST** /ed-fi/openStaffPositions | Creates or updates resources based on the natural key values of the supplied resource.
[**PutOpenStaffPosition**](OpenStaffPositionsApi.md#putopenstaffposition) | **PUT** /ed-fi/openStaffPositions/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteopenstaffpositionbyid"></a>
# **DeleteOpenStaffPositionById**
> void DeleteOpenStaffPositionById (string id, string ifMatch = null)

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
    public class DeleteOpenStaffPositionByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OpenStaffPositionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteOpenStaffPositionById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpenStaffPositionsApi.DeleteOpenStaffPositionById: " + e.Message );
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

<a name="getopenstaffpositions"></a>
# **GetOpenStaffPositions**
> List<EdFiOpenStaffPosition> GetOpenStaffPositions (int? offset = null, int? limit = null, bool? totalCount = null, string requisitionNumber = null, int? educationOrganizationId = null, string employmentStatusDescriptor = null, string postingResultDescriptor = null, string programAssignmentDescriptor = null, string staffClassificationDescriptor = null, DateTime? datePosted = null, DateTime? datePostingRemoved = null, string id = null, string positionTitle = null)

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
    public class GetOpenStaffPositionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OpenStaffPositionsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var requisitionNumber = requisitionNumber_example;  // string | The number or identifier assigned to an open staff position, typically a requisition number assigned by Human Resources. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var employmentStatusDescriptor = employmentStatusDescriptor_example;  // string | Reflects the type of employment or contract desired for the position; for example:          Probationary          Contractual          Substitute/temporary          Tenured or permanent          Volunteer/no contract          ... (optional) 
            var postingResultDescriptor = postingResultDescriptor_example;  // string | Indication of whether the OpenStaffPosition was filled or retired without filling. (optional) 
            var programAssignmentDescriptor = programAssignmentDescriptor_example;  // string | The name of the program for which the OpenStaffPosition will be assigned; for example:          Regular education          Title I-Academic          Title I-Non-Academic          Special Education'          Bilingual/English as a Second Language. (optional) 
            var staffClassificationDescriptor = staffClassificationDescriptor_example;  // string | The titles of employment, official status, or rank of education staff. (optional) 
            var datePosted = 2013-10-20;  // DateTime? | Date the OpenStaffPosition was posted. (optional) 
            var datePostingRemoved = 2013-10-20;  // DateTime? | The date the posting was removed or filled. (optional) 
            var id = id_example;  // string |  (optional) 
            var positionTitle = positionTitle_example;  // string | The descriptive name of an individual's position. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiOpenStaffPosition&gt; result = apiInstance.GetOpenStaffPositions(offset, limit, totalCount, requisitionNumber, educationOrganizationId, employmentStatusDescriptor, postingResultDescriptor, programAssignmentDescriptor, staffClassificationDescriptor, datePosted, datePostingRemoved, id, positionTitle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpenStaffPositionsApi.GetOpenStaffPositions: " + e.Message );
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
 **requisitionNumber** | **string**| The number or identifier assigned to an open staff position, typically a requisition number assigned by Human Resources. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **employmentStatusDescriptor** | **string**| Reflects the type of employment or contract desired for the position; for example:          Probationary          Contractual          Substitute/temporary          Tenured or permanent          Volunteer/no contract          ... | [optional] 
 **postingResultDescriptor** | **string**| Indication of whether the OpenStaffPosition was filled or retired without filling. | [optional] 
 **programAssignmentDescriptor** | **string**| The name of the program for which the OpenStaffPosition will be assigned; for example:          Regular education          Title I-Academic          Title I-Non-Academic          Special Education&#39;          Bilingual/English as a Second Language. | [optional] 
 **staffClassificationDescriptor** | **string**| The titles of employment, official status, or rank of education staff. | [optional] 
 **datePosted** | **DateTime?**| Date the OpenStaffPosition was posted. | [optional] 
 **datePostingRemoved** | **DateTime?**| The date the posting was removed or filled. | [optional] 
 **id** | **string**|  | [optional] 
 **positionTitle** | **string**| The descriptive name of an individual&#39;s position. | [optional] 

### Return type

[**List<EdFiOpenStaffPosition>**](EdFiOpenStaffPosition.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getopenstaffpositionsbyid"></a>
# **GetOpenStaffPositionsById**
> EdFiOpenStaffPosition GetOpenStaffPositionsById (string id, string ifNoneMatch = null)

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
    public class GetOpenStaffPositionsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OpenStaffPositionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiOpenStaffPosition result = apiInstance.GetOpenStaffPositionsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpenStaffPositionsApi.GetOpenStaffPositionsById: " + e.Message );
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

[**EdFiOpenStaffPosition**](EdFiOpenStaffPosition.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postopenstaffposition"></a>
# **PostOpenStaffPosition**
> void PostOpenStaffPosition (EdFiOpenStaffPosition openStaffPosition)

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
    public class PostOpenStaffPositionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OpenStaffPositionsApi();
            var openStaffPosition = new EdFiOpenStaffPosition(); // EdFiOpenStaffPosition | The JSON representation of the \"openStaffPosition\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostOpenStaffPosition(openStaffPosition);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpenStaffPositionsApi.PostOpenStaffPosition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **openStaffPosition** | [**EdFiOpenStaffPosition**](EdFiOpenStaffPosition.md)| The JSON representation of the \&quot;openStaffPosition\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putopenstaffposition"></a>
# **PutOpenStaffPosition**
> void PutOpenStaffPosition (string id, EdFiOpenStaffPosition openStaffPosition, string ifMatch = null)

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
    public class PutOpenStaffPositionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OpenStaffPositionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var openStaffPosition = new EdFiOpenStaffPosition(); // EdFiOpenStaffPosition | The JSON representation of the \"openStaffPosition\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutOpenStaffPosition(id, openStaffPosition, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpenStaffPositionsApi.PutOpenStaffPosition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **openStaffPosition** | [**EdFiOpenStaffPosition**](EdFiOpenStaffPosition.md)| The JSON representation of the \&quot;openStaffPosition\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

