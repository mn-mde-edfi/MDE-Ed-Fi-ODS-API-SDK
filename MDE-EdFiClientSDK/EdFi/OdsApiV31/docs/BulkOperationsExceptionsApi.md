# EdFi.OdsApi.Sdk.Apis.Bulk.BulkOperationsExceptionsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/Bulk/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](BulkOperationsExceptionsApi.md#get) | **GET** /bulkoperations/{id}/exceptions/{uploadid} | Retrieves collection of exceptions from a bulk operation.


<a name="get"></a>
# **Get**
> List<BulkOperationException> Get (string id, string uploadid, int? offset = null, int? limit = null)

Retrieves collection of exceptions from a bulk operation.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Bulk;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Bulk;

namespace Example
{
    public class GetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BulkOperationsExceptionsApi();
            var id = id_example;  // string | id (string): required The unique ID of the operation. This value should be obtained from the operation created via the bulk operations API
            var uploadid = uploadid_example;  // string | uploadId (string): required The unique ID of the in-progress upload on the server. This value should be obtained from the operation created via the bulk operations API
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional) 
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results (defaults to 25). (optional) 

            try
            {
                // Retrieves collection of exceptions from a bulk operation.
                List&lt;BulkOperationException&gt; result = apiInstance.Get(id, uploadid, offset, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkOperationsExceptionsApi.Get: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id (string): required The unique ID of the operation. This value should be obtained from the operation created via the bulk operations API | 
 **uploadid** | **string**| uploadId (string): required The unique ID of the in-progress upload on the server. This value should be obtained from the operation created via the bulk operations API | 
 **offset** | **int?**| Indicates how many items should be skipped before returning results. | [optional] 
 **limit** | **int?**| Indicates the maximum number of items that should be returned in the results (defaults to 25). | [optional] 

### Return type

[**List<BulkOperationException>**](BulkOperationException.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

