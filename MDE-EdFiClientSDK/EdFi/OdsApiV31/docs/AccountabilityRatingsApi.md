# EdFi.OdsApi.Sdk.Apis.All.AccountabilityRatingsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAccountabilityRatingById**](AccountabilityRatingsApi.md#deleteaccountabilityratingbyid) | **DELETE** /ed-fi/accountabilityRatings/{id} | Deletes an existing resource using the resource identifier.
[**GetAccountabilityRatings**](AccountabilityRatingsApi.md#getaccountabilityratings) | **GET** /ed-fi/accountabilityRatings | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetAccountabilityRatingsById**](AccountabilityRatingsApi.md#getaccountabilityratingsbyid) | **GET** /ed-fi/accountabilityRatings/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostAccountabilityRating**](AccountabilityRatingsApi.md#postaccountabilityrating) | **POST** /ed-fi/accountabilityRatings | Creates or updates resources based on the natural key values of the supplied resource.
[**PutAccountabilityRating**](AccountabilityRatingsApi.md#putaccountabilityrating) | **PUT** /ed-fi/accountabilityRatings/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteaccountabilityratingbyid"></a>
# **DeleteAccountabilityRatingById**
> void DeleteAccountabilityRatingById (string id, string ifMatch = null)

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
    public class DeleteAccountabilityRatingByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountabilityRatingsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteAccountabilityRatingById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountabilityRatingsApi.DeleteAccountabilityRatingById: " + e.Message );
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

<a name="getaccountabilityratings"></a>
# **GetAccountabilityRatings**
> List<EdFiAccountabilityRating> GetAccountabilityRatings (int? offset = null, int? limit = null, bool? totalCount = null, string ratingTitle = null, int? educationOrganizationId = null, int? schoolYear = null, string id = null, string rating = null, DateTime? ratingDate = null, string ratingOrganization = null, string ratingProgram = null)

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
    public class GetAccountabilityRatingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountabilityRatingsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var ratingTitle = ratingTitle_example;  // string | The title of the rating (e.g., School Rating, Safety Score). (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var schoolYear = 56;  // int? | The school year for which the AccountabilityRating is assessed. (optional) 
            var id = id_example;  // string |  (optional) 
            var rating = rating_example;  // string | An accountability rating level, designation, or assessment. (optional) 
            var ratingDate = 2013-10-20;  // DateTime? | The date the rating was awarded. (optional) 
            var ratingOrganization = ratingOrganization_example;  // string | The organization that assessed the rating. (optional) 
            var ratingProgram = ratingProgram_example;  // string | The program associated with the AccountabilityRating (e.g., NCLB, AEIS). (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiAccountabilityRating&gt; result = apiInstance.GetAccountabilityRatings(offset, limit, totalCount, ratingTitle, educationOrganizationId, schoolYear, id, rating, ratingDate, ratingOrganization, ratingProgram);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountabilityRatingsApi.GetAccountabilityRatings: " + e.Message );
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
 **ratingTitle** | **string**| The title of the rating (e.g., School Rating, Safety Score). | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **schoolYear** | **int?**| The school year for which the AccountabilityRating is assessed. | [optional] 
 **id** | **string**|  | [optional] 
 **rating** | **string**| An accountability rating level, designation, or assessment. | [optional] 
 **ratingDate** | **DateTime?**| The date the rating was awarded. | [optional] 
 **ratingOrganization** | **string**| The organization that assessed the rating. | [optional] 
 **ratingProgram** | **string**| The program associated with the AccountabilityRating (e.g., NCLB, AEIS). | [optional] 

### Return type

[**List<EdFiAccountabilityRating>**](EdFiAccountabilityRating.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountabilityratingsbyid"></a>
# **GetAccountabilityRatingsById**
> EdFiAccountabilityRating GetAccountabilityRatingsById (string id, string ifNoneMatch = null)

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
    public class GetAccountabilityRatingsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountabilityRatingsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiAccountabilityRating result = apiInstance.GetAccountabilityRatingsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountabilityRatingsApi.GetAccountabilityRatingsById: " + e.Message );
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

[**EdFiAccountabilityRating**](EdFiAccountabilityRating.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postaccountabilityrating"></a>
# **PostAccountabilityRating**
> void PostAccountabilityRating (EdFiAccountabilityRating accountabilityRating)

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
    public class PostAccountabilityRatingExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountabilityRatingsApi();
            var accountabilityRating = new EdFiAccountabilityRating(); // EdFiAccountabilityRating | The JSON representation of the \"accountabilityRating\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostAccountabilityRating(accountabilityRating);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountabilityRatingsApi.PostAccountabilityRating: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountabilityRating** | [**EdFiAccountabilityRating**](EdFiAccountabilityRating.md)| The JSON representation of the \&quot;accountabilityRating\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putaccountabilityrating"></a>
# **PutAccountabilityRating**
> void PutAccountabilityRating (string id, EdFiAccountabilityRating accountabilityRating, string ifMatch = null)

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
    public class PutAccountabilityRatingExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountabilityRatingsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var accountabilityRating = new EdFiAccountabilityRating(); // EdFiAccountabilityRating | The JSON representation of the \"accountabilityRating\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutAccountabilityRating(id, accountabilityRating, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountabilityRatingsApi.PutAccountabilityRating: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **accountabilityRating** | [**EdFiAccountabilityRating**](EdFiAccountabilityRating.md)| The JSON representation of the \&quot;accountabilityRating\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

