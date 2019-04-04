# EdFi.OdsApi.Sdk.Apis.Bulk.BulkOperationsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/Bulk/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBulkOperation**](BulkOperationsApi.md#getbulkoperation) | **GET** /bulkOperations/{id} | Get a bulk operation resource that matches the operation identifier
[**PostBulkOperations**](BulkOperationsApi.md#postbulkoperations) | **POST** /bulkOperations | Create a bulk operation session and retrieve an operation identifier


<a name="getbulkoperation"></a>
# **GetBulkOperation**
> BulkOperationResource GetBulkOperation (string id)

Get a bulk operation resource that matches the operation identifier

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Bulk;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Bulk;

namespace Example
{
    public class GetBulkOperationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BulkOperationsApi();
            var id = id_example;  // string | The operation identifier

            try
            {
                // Get a bulk operation resource that matches the operation identifier
                BulkOperationResource result = apiInstance.GetBulkOperation(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkOperationsApi.GetBulkOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The operation identifier | 

### Return type

[**BulkOperationResource**](BulkOperationResource.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postbulkoperations"></a>
# **PostBulkOperations**
> void PostBulkOperations (BulkOperationCreateRequest body)

Create a bulk operation session and retrieve an operation identifier

This creates a session, during which XML interchange files are uploaded, committed, and processed. An Operation Identifier is returned that will be used for future calls.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Bulk;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Bulk;

namespace Example
{
    public class PostBulkOperationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BulkOperationsApi();
            var body = new BulkOperationCreateRequest(); // BulkOperationCreateRequest | 

            try
            {
                // Create a bulk operation session and retrieve an operation identifier
                apiInstance.PostBulkOperations(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkOperationsApi.PostBulkOperations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BulkOperationCreateRequest**](BulkOperationCreateRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

