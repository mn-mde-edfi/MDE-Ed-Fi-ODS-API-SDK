# EdFi.OdsApi.Sdk.Apis.Identity.IdentitiesApi

All URIs are relative to *https://localhost:54746/Identity/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IdentitiesCreate**](IdentitiesApi.md#identitiescreate) | **POST** /2019/identities | Creates a new Unique Id for the given Identity information.


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

