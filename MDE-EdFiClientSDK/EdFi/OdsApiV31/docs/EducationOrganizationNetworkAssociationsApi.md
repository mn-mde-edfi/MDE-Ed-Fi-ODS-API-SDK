# EdFi.OdsApi.Sdk.Apis.All.EducationOrganizationNetworkAssociationsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteEducationOrganizationNetworkAssociationById**](EducationOrganizationNetworkAssociationsApi.md#deleteeducationorganizationnetworkassociationbyid) | **DELETE** /ed-fi/educationOrganizationNetworkAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetEducationOrganizationNetworkAssociations**](EducationOrganizationNetworkAssociationsApi.md#geteducationorganizationnetworkassociations) | **GET** /ed-fi/educationOrganizationNetworkAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetEducationOrganizationNetworkAssociationsById**](EducationOrganizationNetworkAssociationsApi.md#geteducationorganizationnetworkassociationsbyid) | **GET** /ed-fi/educationOrganizationNetworkAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostEducationOrganizationNetworkAssociation**](EducationOrganizationNetworkAssociationsApi.md#posteducationorganizationnetworkassociation) | **POST** /ed-fi/educationOrganizationNetworkAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutEducationOrganizationNetworkAssociation**](EducationOrganizationNetworkAssociationsApi.md#puteducationorganizationnetworkassociation) | **PUT** /ed-fi/educationOrganizationNetworkAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteeducationorganizationnetworkassociationbyid"></a>
# **DeleteEducationOrganizationNetworkAssociationById**
> void DeleteEducationOrganizationNetworkAssociationById (string id, string ifMatch = null)

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
    public class DeleteEducationOrganizationNetworkAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationOrganizationNetworkAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteEducationOrganizationNetworkAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationOrganizationNetworkAssociationsApi.DeleteEducationOrganizationNetworkAssociationById: " + e.Message );
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

<a name="geteducationorganizationnetworkassociations"></a>
# **GetEducationOrganizationNetworkAssociations**
> List<EdFiEducationOrganizationNetworkAssociation> GetEducationOrganizationNetworkAssociations (int? offset = null, int? limit = null, bool? totalCount = null, int? memberEducationOrganizationId = null, int? educationOrganizationNetworkId = null, DateTime? beginDate = null, DateTime? endDate = null, string id = null)

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
    public class GetEducationOrganizationNetworkAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationOrganizationNetworkAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var memberEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var educationOrganizationNetworkId = 56;  // int? | The identifier assigned to a network of education organizations. (optional) 
            var beginDate = 2013-10-20;  // DateTime? | The date on which the EducationOrganization joined this network. (optional) 
            var endDate = 2013-10-20;  // DateTime? | The date on which the EducationOrganization left this network. (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiEducationOrganizationNetworkAssociation&gt; result = apiInstance.GetEducationOrganizationNetworkAssociations(offset, limit, totalCount, memberEducationOrganizationId, educationOrganizationNetworkId, beginDate, endDate, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationOrganizationNetworkAssociationsApi.GetEducationOrganizationNetworkAssociations: " + e.Message );
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
 **memberEducationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **educationOrganizationNetworkId** | **int?**| The identifier assigned to a network of education organizations. | [optional] 
 **beginDate** | **DateTime?**| The date on which the EducationOrganization joined this network. | [optional] 
 **endDate** | **DateTime?**| The date on which the EducationOrganization left this network. | [optional] 
 **id** | **string**|  | [optional] 

### Return type

[**List<EdFiEducationOrganizationNetworkAssociation>**](EdFiEducationOrganizationNetworkAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteducationorganizationnetworkassociationsbyid"></a>
# **GetEducationOrganizationNetworkAssociationsById**
> EdFiEducationOrganizationNetworkAssociation GetEducationOrganizationNetworkAssociationsById (string id, string ifNoneMatch = null)

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
    public class GetEducationOrganizationNetworkAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationOrganizationNetworkAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiEducationOrganizationNetworkAssociation result = apiInstance.GetEducationOrganizationNetworkAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationOrganizationNetworkAssociationsApi.GetEducationOrganizationNetworkAssociationsById: " + e.Message );
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

[**EdFiEducationOrganizationNetworkAssociation**](EdFiEducationOrganizationNetworkAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posteducationorganizationnetworkassociation"></a>
# **PostEducationOrganizationNetworkAssociation**
> void PostEducationOrganizationNetworkAssociation (EdFiEducationOrganizationNetworkAssociation educationOrganizationNetworkAssociation)

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
    public class PostEducationOrganizationNetworkAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationOrganizationNetworkAssociationsApi();
            var educationOrganizationNetworkAssociation = new EdFiEducationOrganizationNetworkAssociation(); // EdFiEducationOrganizationNetworkAssociation | The JSON representation of the \"educationOrganizationNetworkAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostEducationOrganizationNetworkAssociation(educationOrganizationNetworkAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationOrganizationNetworkAssociationsApi.PostEducationOrganizationNetworkAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **educationOrganizationNetworkAssociation** | [**EdFiEducationOrganizationNetworkAssociation**](EdFiEducationOrganizationNetworkAssociation.md)| The JSON representation of the \&quot;educationOrganizationNetworkAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="puteducationorganizationnetworkassociation"></a>
# **PutEducationOrganizationNetworkAssociation**
> void PutEducationOrganizationNetworkAssociation (string id, EdFiEducationOrganizationNetworkAssociation educationOrganizationNetworkAssociation, string ifMatch = null)

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
    public class PutEducationOrganizationNetworkAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationOrganizationNetworkAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var educationOrganizationNetworkAssociation = new EdFiEducationOrganizationNetworkAssociation(); // EdFiEducationOrganizationNetworkAssociation | The JSON representation of the \"educationOrganizationNetworkAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutEducationOrganizationNetworkAssociation(id, educationOrganizationNetworkAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationOrganizationNetworkAssociationsApi.PutEducationOrganizationNetworkAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **educationOrganizationNetworkAssociation** | [**EdFiEducationOrganizationNetworkAssociation**](EdFiEducationOrganizationNetworkAssociation.md)| The JSON representation of the \&quot;educationOrganizationNetworkAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

