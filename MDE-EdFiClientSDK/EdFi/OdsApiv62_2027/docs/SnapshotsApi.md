# EdFi.OdsApi.Sdk.Apis.ChangeQueries.SnapshotsApi

All URIs are relative to *https://api.education.mn.gov:443/edfiapi/ChangeQueries/v1/2027*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSnapshots**](SnapshotsApi.md#getsnapshots) | **GET** /snapshots | Gets the available static snapshots for enabling client-side processing that is isolated from changing data. |
| [**GetSnapshotsById**](SnapshotsApi.md#getsnapshotsbyid) | **GET** /snapshots/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |

<a name="getsnapshots"></a>
# **GetSnapshots**
> List&lt;ChangeQueriesSnapshot&gt; GetSnapshots (int? offset = null, int? limit = null, bool? totalCount = null)

Gets the available static snapshots for enabling client-side processing that is isolated from changing data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.ChangeQueries;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.ChangeQueries;

namespace Example
{
    public class GetSnapshotsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.education.mn.gov:443/edfiapi/ChangeQueries/v1/2027";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SnapshotsApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)

            try
            {
                // Gets the available static snapshots for enabling client-side processing that is isolated from changing data.
                List<ChangeQueriesSnapshot> result = apiInstance.GetSnapshots(offset, limit, totalCount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SnapshotsApi.GetSnapshots: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSnapshotsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the available static snapshots for enabling client-side processing that is isolated from changing data.
    ApiResponse<List<ChangeQueriesSnapshot>> response = apiInstance.GetSnapshotsWithHttpInfo(offset, limit, totalCount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SnapshotsApi.GetSnapshotsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** | Indicates how many items should be skipped before returning results. | [optional] [default to 0] |
| **limit** | **int?** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **totalCount** | **bool?** | Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false] |

### Return type

[**List&lt;ChangeQueriesSnapshot&gt;**](ChangeQueriesSnapshot.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The resource was successfully retrieved. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsnapshotsbyid"></a>
# **GetSnapshotsById**
> ChangeQueriesSnapshot GetSnapshotsById (string id)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.ChangeQueries;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.ChangeQueries;

namespace Example
{
    public class GetSnapshotsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.education.mn.gov:443/edfiapi/ChangeQueries/v1/2027";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SnapshotsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                ChangeQueriesSnapshot result = apiInstance.GetSnapshotsById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SnapshotsApi.GetSnapshotsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSnapshotsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<ChangeQueriesSnapshot> response = apiInstance.GetSnapshotsByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SnapshotsApi.GetSnapshotsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |

### Return type

[**ChangeQueriesSnapshot**](ChangeQueriesSnapshot.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested resource was successfully retrieved. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **404** | Not Found. The resource could not be found. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

