# EdFi.OdsApi.Sdk.Apis.All.ContractedStaffsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteContractedStaffById**](ContractedStaffsApi.md#deletecontractedstaffbyid) | **DELETE** /ed-fi/contractedStaffs/{id} | Deletes an existing resource using the resource identifier.
[**GetContractedStaffs**](ContractedStaffsApi.md#getcontractedstaffs) | **GET** /ed-fi/contractedStaffs | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetContractedStaffsById**](ContractedStaffsApi.md#getcontractedstaffsbyid) | **GET** /ed-fi/contractedStaffs/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostContractedStaff**](ContractedStaffsApi.md#postcontractedstaff) | **POST** /ed-fi/contractedStaffs | Creates or updates resources based on the natural key values of the supplied resource.
[**PutContractedStaff**](ContractedStaffsApi.md#putcontractedstaff) | **PUT** /ed-fi/contractedStaffs/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletecontractedstaffbyid"></a>
# **DeleteContractedStaffById**
> void DeleteContractedStaffById (string id, string ifMatch = null)

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
    public class DeleteContractedStaffByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractedStaffsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteContractedStaffById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractedStaffsApi.DeleteContractedStaffById: " + e.Message );
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

<a name="getcontractedstaffs"></a>
# **GetContractedStaffs**
> List<EdFiContractedStaff> GetContractedStaffs (int? offset = null, int? limit = null, bool? totalCount = null, DateTime? asOfDate = null, string accountIdentifier = null, int? educationOrganizationId = null, int? fiscalYear = null, string staffUniqueId = null, double? amountToDate = null, string id = null)

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
    public class GetContractedStaffsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractedStaffsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var asOfDate = 2013-10-20;  // DateTime? | The date of the reported contracted staff element. (optional) 
            var accountIdentifier = accountIdentifier_example;  // string | The alphanumeric string that identifies the account. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var fiscalYear = 56;  // int? | The financial accounting year. (optional) 
            var staffUniqueId = staffUniqueId_example;  // string | A unique alphanumeric code assigned to a staff. (optional) 
            var amountToDate = 1.2;  // double? | Current balance (amount paid to contractor) for account for the fiscal year. (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiContractedStaff&gt; result = apiInstance.GetContractedStaffs(offset, limit, totalCount, asOfDate, accountIdentifier, educationOrganizationId, fiscalYear, staffUniqueId, amountToDate, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractedStaffsApi.GetContractedStaffs: " + e.Message );
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
 **asOfDate** | **DateTime?**| The date of the reported contracted staff element. | [optional] 
 **accountIdentifier** | **string**| The alphanumeric string that identifies the account. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **fiscalYear** | **int?**| The financial accounting year. | [optional] 
 **staffUniqueId** | **string**| A unique alphanumeric code assigned to a staff. | [optional] 
 **amountToDate** | **double?**| Current balance (amount paid to contractor) for account for the fiscal year. | [optional] 
 **id** | **string**|  | [optional] 

### Return type

[**List<EdFiContractedStaff>**](EdFiContractedStaff.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontractedstaffsbyid"></a>
# **GetContractedStaffsById**
> EdFiContractedStaff GetContractedStaffsById (string id, string ifNoneMatch = null)

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
    public class GetContractedStaffsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractedStaffsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiContractedStaff result = apiInstance.GetContractedStaffsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractedStaffsApi.GetContractedStaffsById: " + e.Message );
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

[**EdFiContractedStaff**](EdFiContractedStaff.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcontractedstaff"></a>
# **PostContractedStaff**
> void PostContractedStaff (EdFiContractedStaff contractedStaff)

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
    public class PostContractedStaffExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractedStaffsApi();
            var contractedStaff = new EdFiContractedStaff(); // EdFiContractedStaff | The JSON representation of the \"contractedStaff\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostContractedStaff(contractedStaff);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractedStaffsApi.PostContractedStaff: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractedStaff** | [**EdFiContractedStaff**](EdFiContractedStaff.md)| The JSON representation of the \&quot;contractedStaff\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcontractedstaff"></a>
# **PutContractedStaff**
> void PutContractedStaff (string id, EdFiContractedStaff contractedStaff, string ifMatch = null)

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
    public class PutContractedStaffExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContractedStaffsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var contractedStaff = new EdFiContractedStaff(); // EdFiContractedStaff | The JSON representation of the \"contractedStaff\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutContractedStaff(id, contractedStaff, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractedStaffsApi.PutContractedStaff: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **contractedStaff** | [**EdFiContractedStaff**](EdFiContractedStaff.md)| The JSON representation of the \&quot;contractedStaff\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

