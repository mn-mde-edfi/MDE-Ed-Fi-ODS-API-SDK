# EdFi.OdsApi.Sdk.Apis.Identity.IdentitiesApi

All URIs are relative to *https://test.edfi5.education.mn.gov:443/api/identity/v2/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IdentitiesCreate**](IdentitiesApi.md#identitiescreate) | **POST** /identities | Creates a new Unique Id for the given Identity information.
[**IdentitiesFind**](IdentitiesApi.md#identitiesfind) | **POST** /identities/find | Retrieve a multiple person records from their Unique Ids.
[**IdentitiesGetById**](IdentitiesApi.md#identitiesgetbyid) | **GET** /identities/{id} | Retrieve a single person record from their Unique Id.
[**IdentitiesResult**](IdentitiesApi.md#identitiesresult) | **GET** /identities/results/{id} | Retrieve asynchronous search results from a previously created request.
[**IdentitiesSearch**](IdentitiesApi.md#identitiessearch) | **POST** /identities/search | Lookup existing Unique Ids for a persons, or suggest possible matches.


<a name="identitiescreate"></a>
# **IdentitiesCreate**
> string IdentitiesCreate (IdentityCreateRequest request)

Creates a new Unique Id for the given Identity information.

Assumption here is that the user has verified that possible matches are not correct matches. Returns the created identity information along with the assigned Unique Id.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class IdentitiesCreateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentitiesApi();
            var request = new IdentityCreateRequest(); // IdentityCreateRequest | Identity object to be created.

            try
            {
                // Creates a new Unique Id for the given Identity information.
                string result = apiInstance.IdentitiesCreate(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentitiesApi.IdentitiesCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**IdentityCreateRequest**](IdentityCreateRequest.md)| Identity object to be created. | 

### Return type

**string**

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="identitiesfind"></a>
# **IdentitiesFind**
> IdentitySearchResponse IdentitiesFind (List<string> uniqueIds)

Retrieve a multiple person records from their Unique Ids.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class IdentitiesFindExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentitiesApi();
            var uniqueIds = ;  // List<string> | Unique Ids of the persons to be retrieved.

            try
            {
                // Retrieve a multiple person records from their Unique Ids.
                IdentitySearchResponse result = apiInstance.IdentitiesFind(uniqueIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentitiesApi.IdentitiesFind: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueIds** | **List&lt;string&gt;**| Unique Ids of the persons to be retrieved. | 

### Return type

[**IdentitySearchResponse**](IdentitySearchResponse.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="identitiesgetbyid"></a>
# **IdentitiesGetById**
> IdentityResponse IdentitiesGetById (string id)

Retrieve a single person record from their Unique Id.

Returns either a single identity or 404 and no data

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class IdentitiesGetByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentitiesApi();
            var id = id_example;  // string | Unique Id of the identity to be retrieved

            try
            {
                // Retrieve a single person record from their Unique Id.
                IdentityResponse result = apiInstance.IdentitiesGetById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentitiesApi.IdentitiesGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Unique Id of the identity to be retrieved | 

### Return type

[**IdentityResponse**](IdentityResponse.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="identitiesresult"></a>
# **IdentitiesResult**
> IdentitySearchResponse IdentitiesResult (string id)

Retrieve asynchronous search results from a previously created request.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class IdentitiesResultExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentitiesApi();
            var id = id_example;  // string | The search token provided by a Find or Search request.

            try
            {
                // Retrieve asynchronous search results from a previously created request.
                IdentitySearchResponse result = apiInstance.IdentitiesResult(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentitiesApi.IdentitiesResult: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The search token provided by a Find or Search request. | 

### Return type

[**IdentitySearchResponse**](IdentitySearchResponse.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="identitiessearch"></a>
# **IdentitiesSearch**
> IdentitySearchResponse IdentitiesSearch (List<IdentitySearchRequest> criteria)

Lookup existing Unique Ids for a persons, or suggest possible matches.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class IdentitiesSearchExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentitiesApi();
            var criteria = new List<IdentitySearchRequest>(); // List<IdentitySearchRequest> | One or more identity search request objects.

            try
            {
                // Lookup existing Unique Ids for a persons, or suggest possible matches.
                IdentitySearchResponse result = apiInstance.IdentitiesSearch(criteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentitiesApi.IdentitiesSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | [**List&lt;IdentitySearchRequest&gt;**](IdentitySearchRequest.md)| One or more identity search request objects. | 

### Return type

[**IdentitySearchResponse**](IdentitySearchResponse.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

