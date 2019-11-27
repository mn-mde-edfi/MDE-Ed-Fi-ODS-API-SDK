# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_SISVendor_Profile.PostSecondaryInstitutionsApi

All URIs are relative to *https://localhost:54746/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletepostSecondaryInstitutionById**](PostSecondaryInstitutionsApi.md#deletepostsecondaryinstitutionbyid) | **DELETE** /ed-fi/postSecondaryInstitutions/{id} | Deletes an existing resource using the resource identifier.
[**GetPostSecondaryInstitutions**](PostSecondaryInstitutionsApi.md#getpostsecondaryinstitutions) | **GET** /ed-fi/postSecondaryInstitutions | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetPostSecondaryInstitutionsById**](PostSecondaryInstitutionsApi.md#getpostsecondaryinstitutionsbyid) | **GET** /ed-fi/postSecondaryInstitutions/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostpostSecondaryInstitution**](PostSecondaryInstitutionsApi.md#postpostsecondaryinstitution) | **POST** /ed-fi/postSecondaryInstitutions | Creates or updates resources based on the natural key values of the supplied resource.
[**PutpostSecondaryInstitution**](PostSecondaryInstitutionsApi.md#putpostsecondaryinstitution) | **PUT** /ed-fi/postSecondaryInstitutions/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletepostsecondaryinstitutionbyid"></a>
# **DeletepostSecondaryInstitutionById**
> void DeletepostSecondaryInstitutionById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile;

namespace Example
{
    public class DeletepostSecondaryInstitutionByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostSecondaryInstitutionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeletepostSecondaryInstitutionById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PostSecondaryInstitutionsApi.DeletepostSecondaryInstitutionById: " + e.Message );
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

 - **Content-Type**: application/vnd.ed-fi.postsecondaryinstitution.minnesota-sisvendor-profile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpostsecondaryinstitutions"></a>
# **GetPostSecondaryInstitutions**
> List<EdFiPostSecondaryInstitutionReadable> GetPostSecondaryInstitutions (int? offset = null, int? limit = null, bool? totalCount = null, int? postSecondaryInstitutionId = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile;

namespace Example
{
    public class GetPostSecondaryInstitutionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostSecondaryInstitutionsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var postSecondaryInstitutionId = 56;  // int? | The ID of the post secondary institution. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiPostSecondaryInstitutionReadable&gt; result = apiInstance.GetPostSecondaryInstitutions(offset, limit, totalCount, postSecondaryInstitutionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PostSecondaryInstitutionsApi.GetPostSecondaryInstitutions: " + e.Message );
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
 **postSecondaryInstitutionId** | **int?**| The ID of the post secondary institution. | [optional] 

### Return type

[**List<EdFiPostSecondaryInstitutionReadable>**](EdFiPostSecondaryInstitutionReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.postsecondaryinstitution.minnesota-sisvendor-profile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpostsecondaryinstitutionsbyid"></a>
# **GetPostSecondaryInstitutionsById**
> EdFiPostSecondaryInstitutionReadable GetPostSecondaryInstitutionsById (string id, string ifNoneMatch = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile;

namespace Example
{
    public class GetPostSecondaryInstitutionsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostSecondaryInstitutionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiPostSecondaryInstitutionReadable result = apiInstance.GetPostSecondaryInstitutionsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PostSecondaryInstitutionsApi.GetPostSecondaryInstitutionsById: " + e.Message );
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

[**EdFiPostSecondaryInstitutionReadable**](EdFiPostSecondaryInstitutionReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.postsecondaryinstitution.minnesota-sisvendor-profile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpostsecondaryinstitution"></a>
# **PostpostSecondaryInstitution**
> void PostpostSecondaryInstitution (EdFiPostSecondaryInstitutionWritable postSecondaryInstitution)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error (you must use a PUT operation to update a resource by \"id\"). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile;

namespace Example
{
    public class PostpostSecondaryInstitutionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostSecondaryInstitutionsApi();
            var postSecondaryInstitution = new EdFiPostSecondaryInstitutionWritable(); // EdFiPostSecondaryInstitutionWritable | The JSON representation of the \"postSecondaryInstitution\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostpostSecondaryInstitution(postSecondaryInstitution);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PostSecondaryInstitutionsApi.PostpostSecondaryInstitution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postSecondaryInstitution** | [**EdFiPostSecondaryInstitutionWritable**](EdFiPostSecondaryInstitutionWritable.md)| The JSON representation of the \&quot;postSecondaryInstitution\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.postsecondaryinstitution.minnesota-sisvendor-profile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putpostsecondaryinstitution"></a>
# **PutpostSecondaryInstitution**
> void PutpostSecondaryInstitution (string id, EdFiPostSecondaryInstitutionWritable postSecondaryInstitution, string ifMatch = null)

Updates or creates a resource based on the resource identifier.

The PUT operation is used to update or create a resource by identifier. If the resource doesn't exist, the resource will be created using that identifier. Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource \"id\" is provided in the JSON body, it will be ignored as well.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile;

namespace Example
{
    public class PutpostSecondaryInstitutionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostSecondaryInstitutionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var postSecondaryInstitution = new EdFiPostSecondaryInstitutionWritable(); // EdFiPostSecondaryInstitutionWritable | The JSON representation of the \"postSecondaryInstitution\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutpostSecondaryInstitution(id, postSecondaryInstitution, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PostSecondaryInstitutionsApi.PutpostSecondaryInstitution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **postSecondaryInstitution** | [**EdFiPostSecondaryInstitutionWritable**](EdFiPostSecondaryInstitutionWritable.md)| The JSON representation of the \&quot;postSecondaryInstitution\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.postsecondaryinstitution.minnesota-sisvendor-profile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

