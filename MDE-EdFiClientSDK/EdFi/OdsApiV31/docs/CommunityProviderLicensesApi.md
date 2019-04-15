# EdFi.OdsApi.Sdk.Apis.All.CommunityProviderLicensesApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCommunityProviderLicenseById**](CommunityProviderLicensesApi.md#deletecommunityproviderlicensebyid) | **DELETE** /ed-fi/communityProviderLicenses/{id} | Deletes an existing resource using the resource identifier.
[**GetCommunityProviderLicenses**](CommunityProviderLicensesApi.md#getcommunityproviderlicenses) | **GET** /ed-fi/communityProviderLicenses | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetCommunityProviderLicensesById**](CommunityProviderLicensesApi.md#getcommunityproviderlicensesbyid) | **GET** /ed-fi/communityProviderLicenses/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostCommunityProviderLicense**](CommunityProviderLicensesApi.md#postcommunityproviderlicense) | **POST** /ed-fi/communityProviderLicenses | Creates or updates resources based on the natural key values of the supplied resource.
[**PutCommunityProviderLicense**](CommunityProviderLicensesApi.md#putcommunityproviderlicense) | **PUT** /ed-fi/communityProviderLicenses/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletecommunityproviderlicensebyid"></a>
# **DeleteCommunityProviderLicenseById**
> void DeleteCommunityProviderLicenseById (string id, string ifMatch = null)

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
    public class DeleteCommunityProviderLicenseByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommunityProviderLicensesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteCommunityProviderLicenseById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityProviderLicensesApi.DeleteCommunityProviderLicenseById: " + e.Message );
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

<a name="getcommunityproviderlicenses"></a>
# **GetCommunityProviderLicenses**
> List<EdFiCommunityProviderLicense> GetCommunityProviderLicenses (int? offset = null, int? limit = null, bool? totalCount = null, string licenseIdentifier = null, string licensingOrganization = null, int? communityProviderId = null, string licenseStatusDescriptor = null, string licenseTypeDescriptor = null, int? authorizedFacilityCapacity = null, string id = null, DateTime? licenseEffectiveDate = null, DateTime? licenseExpirationDate = null, DateTime? licenseIssueDate = null, int? oldestAgeAuthorizedToServe = null, int? youngestAgeAuthorizedToServe = null)

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
    public class GetCommunityProviderLicensesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommunityProviderLicensesApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var licenseIdentifier = licenseIdentifier_example;  // string | The unique identifier issued by the licensing organization. (optional) 
            var licensingOrganization = licensingOrganization_example;  // string | The organization issuing the license. (optional) 
            var communityProviderId = 56;  // int? | The identifier assigned to a CommunityProvider. (optional) 
            var licenseStatusDescriptor = licenseStatusDescriptor_example;  // string | An indication of the status of the license. (optional) 
            var licenseTypeDescriptor = licenseTypeDescriptor_example;  // string | An indication of the category of the license. (optional) 
            var authorizedFacilityCapacity = 56;  // int? | The maximum number that can be contained or accommodated which a provider is authorized or licensed to serve. (optional) 
            var id = id_example;  // string |  (optional) 
            var licenseEffectiveDate = 2013-10-20;  // DateTime? | The month, day, and year on which a license is active or becomes effective. (optional) 
            var licenseExpirationDate = 2013-10-20;  // DateTime? | The month, day, and year on which a license will expire. (optional) 
            var licenseIssueDate = 2013-10-20;  // DateTime? | The month, day, and year on which an active license was issued. (optional) 
            var oldestAgeAuthorizedToServe = 56;  // int? | The oldest age of children a provider is authorized or licensed to serve. (optional) 
            var youngestAgeAuthorizedToServe = 56;  // int? | The youngest age of children a provider is authorized or licensed to serve. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiCommunityProviderLicense&gt; result = apiInstance.GetCommunityProviderLicenses(offset, limit, totalCount, licenseIdentifier, licensingOrganization, communityProviderId, licenseStatusDescriptor, licenseTypeDescriptor, authorizedFacilityCapacity, id, licenseEffectiveDate, licenseExpirationDate, licenseIssueDate, oldestAgeAuthorizedToServe, youngestAgeAuthorizedToServe);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityProviderLicensesApi.GetCommunityProviderLicenses: " + e.Message );
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
 **licenseIdentifier** | **string**| The unique identifier issued by the licensing organization. | [optional] 
 **licensingOrganization** | **string**| The organization issuing the license. | [optional] 
 **communityProviderId** | **int?**| The identifier assigned to a CommunityProvider. | [optional] 
 **licenseStatusDescriptor** | **string**| An indication of the status of the license. | [optional] 
 **licenseTypeDescriptor** | **string**| An indication of the category of the license. | [optional] 
 **authorizedFacilityCapacity** | **int?**| The maximum number that can be contained or accommodated which a provider is authorized or licensed to serve. | [optional] 
 **id** | **string**|  | [optional] 
 **licenseEffectiveDate** | **DateTime?**| The month, day, and year on which a license is active or becomes effective. | [optional] 
 **licenseExpirationDate** | **DateTime?**| The month, day, and year on which a license will expire. | [optional] 
 **licenseIssueDate** | **DateTime?**| The month, day, and year on which an active license was issued. | [optional] 
 **oldestAgeAuthorizedToServe** | **int?**| The oldest age of children a provider is authorized or licensed to serve. | [optional] 
 **youngestAgeAuthorizedToServe** | **int?**| The youngest age of children a provider is authorized or licensed to serve. | [optional] 

### Return type

[**List<EdFiCommunityProviderLicense>**](EdFiCommunityProviderLicense.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcommunityproviderlicensesbyid"></a>
# **GetCommunityProviderLicensesById**
> EdFiCommunityProviderLicense GetCommunityProviderLicensesById (string id, string ifNoneMatch = null)

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
    public class GetCommunityProviderLicensesByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommunityProviderLicensesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiCommunityProviderLicense result = apiInstance.GetCommunityProviderLicensesById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityProviderLicensesApi.GetCommunityProviderLicensesById: " + e.Message );
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

[**EdFiCommunityProviderLicense**](EdFiCommunityProviderLicense.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcommunityproviderlicense"></a>
# **PostCommunityProviderLicense**
> void PostCommunityProviderLicense (EdFiCommunityProviderLicense communityProviderLicense)

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
    public class PostCommunityProviderLicenseExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommunityProviderLicensesApi();
            var communityProviderLicense = new EdFiCommunityProviderLicense(); // EdFiCommunityProviderLicense | The JSON representation of the \"communityProviderLicense\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostCommunityProviderLicense(communityProviderLicense);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityProviderLicensesApi.PostCommunityProviderLicense: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **communityProviderLicense** | [**EdFiCommunityProviderLicense**](EdFiCommunityProviderLicense.md)| The JSON representation of the \&quot;communityProviderLicense\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcommunityproviderlicense"></a>
# **PutCommunityProviderLicense**
> void PutCommunityProviderLicense (string id, EdFiCommunityProviderLicense communityProviderLicense, string ifMatch = null)

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
    public class PutCommunityProviderLicenseExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommunityProviderLicensesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var communityProviderLicense = new EdFiCommunityProviderLicense(); // EdFiCommunityProviderLicense | The JSON representation of the \"communityProviderLicense\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutCommunityProviderLicense(id, communityProviderLicense, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityProviderLicensesApi.PutCommunityProviderLicense: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **communityProviderLicense** | [**EdFiCommunityProviderLicense**](EdFiCommunityProviderLicense.md)| The JSON representation of the \&quot;communityProviderLicense\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

