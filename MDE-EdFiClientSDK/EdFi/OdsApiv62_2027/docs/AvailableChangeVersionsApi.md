# EdFi.OdsApi.Sdk.Apis.ChangeQueries.AvailableChangeVersionsApi

All URIs are relative to *https://api.education.mn.gov:443/edfiapi/ChangeQueries/v1/2027*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAvailableChangeVersions**](AvailableChangeVersionsApi.md#getavailablechangeversions) | **GET** /availableChangeVersions | Gets the change versions for the earliest (oldest) and most recent (newest) changes available. |

<a name="getavailablechangeversions"></a>
# **GetAvailableChangeVersions**
> AvailableChangeVersion GetAvailableChangeVersions ()

Gets the change versions for the earliest (oldest) and most recent (newest) changes available.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.ChangeQueries;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.ChangeQueries;

namespace Example
{
    public class GetAvailableChangeVersionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.education.mn.gov:443/edfiapi/ChangeQueries/v1/2027";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AvailableChangeVersionsApi(config);

            try
            {
                // Gets the change versions for the earliest (oldest) and most recent (newest) changes available.
                AvailableChangeVersion result = apiInstance.GetAvailableChangeVersions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailableChangeVersionsApi.GetAvailableChangeVersions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAvailableChangeVersionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the change versions for the earliest (oldest) and most recent (newest) changes available.
    ApiResponse<AvailableChangeVersion> response = apiInstance.GetAvailableChangeVersionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvailableChangeVersionsApi.GetAvailableChangeVersionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AvailableChangeVersion**](AvailableChangeVersion.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The resource was successfully retrieved. |  -  |
| **401** | Unauthorized.  The request requires authentication.  The OAuth bearer token was either not provided or is invalid.  The operation may succeed once authenication has been successfully completed. |  -  |
| **403** | Forbidden.  The request cannot be completed in the current authorization context.  Contact your administrator if you believe this operation should be allowed. |  -  |
| **410** | Gone.  An attempt to connect to the database for the snapshot specified by the Snapshot-Identifier header was unsuccessful (indicating the snapshot may have been removed). |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

