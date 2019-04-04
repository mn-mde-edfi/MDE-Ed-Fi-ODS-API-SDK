# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_SISVendor_Profile.EducationOrganizationsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteeducationOrganizationById**](EducationOrganizationsApi.md#deleteeducationorganizationbyid) | **DELETE** /ed-fi/educationOrganizations/{id} | Deletes an existing resource using the resource identifier.
[**GetEducationOrganizations**](EducationOrganizationsApi.md#geteducationorganizations) | **GET** /ed-fi/educationOrganizations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetEducationOrganizationsById**](EducationOrganizationsApi.md#geteducationorganizationsbyid) | **GET** /ed-fi/educationOrganizations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PosteducationOrganization**](EducationOrganizationsApi.md#posteducationorganization) | **POST** /ed-fi/educationOrganizations | Creates or updates resources based on the natural key values of the supplied resource.
[**PuteducationOrganization**](EducationOrganizationsApi.md#puteducationorganization) | **PUT** /ed-fi/educationOrganizations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteeducationorganizationbyid"></a>
# **DeleteeducationOrganizationById**
> void DeleteeducationOrganizationById (string id, string ifMatch = null)

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
    public class DeleteeducationOrganizationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationOrganizationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteeducationOrganizationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationOrganizationsApi.DeleteeducationOrganizationById: " + e.Message );
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

 - **Content-Type**: application/vnd.ed-fi.educationorganization.minnesota-sisvendor-profile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteducationorganizations"></a>
# **GetEducationOrganizations**
> List<EdFiEducationOrganizationReadable> GetEducationOrganizations (int? offset = null, int? limit = null, bool? totalCount = null, int? educationOrganizationId = null, string id = null, string nameOfInstitution = null)

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
    public class GetEducationOrganizationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationOrganizationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var id = id_example;  // string |  (optional) 
            var nameOfInstitution = nameOfInstitution_example;  // string | The full, legally accepted name of the institution. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiEducationOrganizationReadable&gt; result = apiInstance.GetEducationOrganizations(offset, limit, totalCount, educationOrganizationId, id, nameOfInstitution);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationOrganizationsApi.GetEducationOrganizations: " + e.Message );
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
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **id** | **string**|  | [optional] 
 **nameOfInstitution** | **string**| The full, legally accepted name of the institution. | [optional] 

### Return type

[**List<EdFiEducationOrganizationReadable>**](EdFiEducationOrganizationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.educationorganization.minnesota-sisvendor-profile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteducationorganizationsbyid"></a>
# **GetEducationOrganizationsById**
> EdFiEducationOrganizationReadable GetEducationOrganizationsById (string id, string ifNoneMatch = null)

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
    public class GetEducationOrganizationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationOrganizationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiEducationOrganizationReadable result = apiInstance.GetEducationOrganizationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationOrganizationsApi.GetEducationOrganizationsById: " + e.Message );
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

[**EdFiEducationOrganizationReadable**](EdFiEducationOrganizationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.educationorganization.minnesota-sisvendor-profile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posteducationorganization"></a>
# **PosteducationOrganization**
> void PosteducationOrganization (EdFiEducationOrganizationWritable educationOrganization)

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
    public class PosteducationOrganizationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationOrganizationsApi();
            var educationOrganization = new EdFiEducationOrganizationWritable(); // EdFiEducationOrganizationWritable | The JSON representation of the \"educationOrganization\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PosteducationOrganization(educationOrganization);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationOrganizationsApi.PosteducationOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **educationOrganization** | [**EdFiEducationOrganizationWritable**](EdFiEducationOrganizationWritable.md)| The JSON representation of the \&quot;educationOrganization\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.educationorganization.minnesota-sisvendor-profile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="puteducationorganization"></a>
# **PuteducationOrganization**
> void PuteducationOrganization (string id, EdFiEducationOrganizationWritable educationOrganization, string ifMatch = null)

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
    public class PuteducationOrganizationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationOrganizationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var educationOrganization = new EdFiEducationOrganizationWritable(); // EdFiEducationOrganizationWritable | The JSON representation of the \"educationOrganization\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PuteducationOrganization(id, educationOrganization, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationOrganizationsApi.PuteducationOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **educationOrganization** | [**EdFiEducationOrganizationWritable**](EdFiEducationOrganizationWritable.md)| The JSON representation of the \&quot;educationOrganization\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.educationorganization.minnesota-sisvendor-profile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

