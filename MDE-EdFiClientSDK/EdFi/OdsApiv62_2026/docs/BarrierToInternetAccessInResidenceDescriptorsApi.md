# EdFi.OdsApi.Sdk.Apis.Descriptors.BarrierToInternetAccessInResidenceDescriptorsApi

All URIs are relative to *https://stage.api.education.mn.gov:443/edfiapi/data/v3/2026*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteBarrierToInternetAccessInResidenceDescriptorById**](BarrierToInternetAccessInResidenceDescriptorsApi.md#deletebarriertointernetaccessinresidencedescriptorbyid) | **DELETE** /ed-fi/barrierToInternetAccessInResidenceDescriptors/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesBarrierToInternetAccessInResidenceDescriptors**](BarrierToInternetAccessInResidenceDescriptorsApi.md#deletesbarriertointernetaccessinresidencedescriptors) | **GET** /ed-fi/barrierToInternetAccessInResidenceDescriptors/deletes | Retrieves deleted resources based on change version. |
| [**GetBarrierToInternetAccessInResidenceDescriptors**](BarrierToInternetAccessInResidenceDescriptorsApi.md#getbarriertointernetaccessinresidencedescriptors) | **GET** /ed-fi/barrierToInternetAccessInResidenceDescriptors | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetBarrierToInternetAccessInResidenceDescriptorsById**](BarrierToInternetAccessInResidenceDescriptorsApi.md#getbarriertointernetaccessinresidencedescriptorsbyid) | **GET** /ed-fi/barrierToInternetAccessInResidenceDescriptors/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**KeyChangesBarrierToInternetAccessInResidenceDescriptors**](BarrierToInternetAccessInResidenceDescriptorsApi.md#keychangesbarriertointernetaccessinresidencedescriptors) | **GET** /ed-fi/barrierToInternetAccessInResidenceDescriptors/keyChanges | Retrieves resources key changes based on change version. |
| [**PostBarrierToInternetAccessInResidenceDescriptor**](BarrierToInternetAccessInResidenceDescriptorsApi.md#postbarriertointernetaccessinresidencedescriptor) | **POST** /ed-fi/barrierToInternetAccessInResidenceDescriptors | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutBarrierToInternetAccessInResidenceDescriptor**](BarrierToInternetAccessInResidenceDescriptorsApi.md#putbarriertointernetaccessinresidencedescriptor) | **PUT** /ed-fi/barrierToInternetAccessInResidenceDescriptors/{id} | Updates a resource based on the resource identifier. |

<a name="deletebarriertointernetaccessinresidencedescriptorbyid"></a>
# **DeleteBarrierToInternetAccessInResidenceDescriptorById**
> void DeleteBarrierToInternetAccessInResidenceDescriptorById (string id, string? ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Descriptors;

namespace Example
{
    public class DeleteBarrierToInternetAccessInResidenceDescriptorByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://stage.api.education.mn.gov:443/edfiapi/data/v3/2026";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BarrierToInternetAccessInResidenceDescriptorsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string? | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteBarrierToInternetAccessInResidenceDescriptorById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BarrierToInternetAccessInResidenceDescriptorsApi.DeleteBarrierToInternetAccessInResidenceDescriptorById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteBarrierToInternetAccessInResidenceDescriptorByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeleteBarrierToInternetAccessInResidenceDescriptorByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BarrierToInternetAccessInResidenceDescriptorsApi.DeleteBarrierToInternetAccessInResidenceDescriptorByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **ifMatch** | **string?** | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The resource was successfully deleted. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **405** | Method Is Not Allowed. When the Snapshot-Identifier header is present the method is not allowed. |  -  |
| **409** | Conflict.  The request cannot be completed because it would result in an invalid state.  See the response body for details. |  -  |
| **412** | The resource&#39;s current server-side ETag value does not match the supplied If-Match header value in the request. This indicates the resource has been modified by another consumer. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesbarriertointernetaccessinresidencedescriptors"></a>
# **DeletesBarrierToInternetAccessInResidenceDescriptors**
> List&lt;TrackedChangesEdFiBarrierToInternetAccessInResidenceDescriptorDelete&gt; DeletesBarrierToInternetAccessInResidenceDescriptors (int? offset = null, int? limit = null, long? minChangeVersion = null, long? maxChangeVersion = null, bool? totalCount = null, string? snapshotIdentifier = null)

Retrieves deleted resources based on change version.

This operation is used to retrieve identifying information about resources that have been deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Descriptors;

namespace Example
{
    public class DeletesBarrierToInternetAccessInResidenceDescriptorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://stage.api.education.mn.gov:443/edfiapi/data/v3/2026";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BarrierToInternetAccessInResidenceDescriptorsApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiBarrierToInternetAccessInResidenceDescriptorDelete> result = apiInstance.DeletesBarrierToInternetAccessInResidenceDescriptors(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BarrierToInternetAccessInResidenceDescriptorsApi.DeletesBarrierToInternetAccessInResidenceDescriptors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesBarrierToInternetAccessInResidenceDescriptorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiBarrierToInternetAccessInResidenceDescriptorDelete>> response = apiInstance.DeletesBarrierToInternetAccessInResidenceDescriptorsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BarrierToInternetAccessInResidenceDescriptorsApi.DeletesBarrierToInternetAccessInResidenceDescriptorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** | Indicates how many items should be skipped before returning results. | [optional] [default to 0] |
| **limit** | **int?** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **minChangeVersion** | **long?** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **long?** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **totalCount** | **bool?** | Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false] |
| **snapshotIdentifier** | **string?** | Indicates the Snapshot-Identifier that should be used. | [optional]  |

### Return type

[**List&lt;TrackedChangesEdFiBarrierToInternetAccessInResidenceDescriptorDelete&gt;**](TrackedChangesEdFiBarrierToInternetAccessInResidenceDescriptorDelete.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested resource was successfully retrieved. |  -  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |
| **410** | Gone. An attempt to connect to the database for the snapshot specified by the Snapshot-Identifier header was unsuccessful (indicating the snapshot may have been removed). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbarriertointernetaccessinresidencedescriptors"></a>
# **GetBarrierToInternetAccessInResidenceDescriptors**
> List&lt;EdFiBarrierToInternetAccessInResidenceDescriptor&gt; GetBarrierToInternetAccessInResidenceDescriptors (int? offset = null, int? limit = null, long? minChangeVersion = null, long? maxChangeVersion = null, bool? totalCount = null, int? barrierToInternetAccessInResidenceDescriptorId = null, string? snapshotIdentifier = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Descriptors;

namespace Example
{
    public class GetBarrierToInternetAccessInResidenceDescriptorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://stage.api.education.mn.gov:443/edfiapi/data/v3/2026";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BarrierToInternetAccessInResidenceDescriptorsApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var barrierToInternetAccessInResidenceDescriptorId = 56;  // int? | A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiBarrierToInternetAccessInResidenceDescriptor> result = apiInstance.GetBarrierToInternetAccessInResidenceDescriptors(offset, limit, minChangeVersion, maxChangeVersion, totalCount, barrierToInternetAccessInResidenceDescriptorId, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BarrierToInternetAccessInResidenceDescriptorsApi.GetBarrierToInternetAccessInResidenceDescriptors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBarrierToInternetAccessInResidenceDescriptorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiBarrierToInternetAccessInResidenceDescriptor>> response = apiInstance.GetBarrierToInternetAccessInResidenceDescriptorsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, barrierToInternetAccessInResidenceDescriptorId, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BarrierToInternetAccessInResidenceDescriptorsApi.GetBarrierToInternetAccessInResidenceDescriptorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** | Indicates how many items should be skipped before returning results. | [optional] [default to 0] |
| **limit** | **int?** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **minChangeVersion** | **long?** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **long?** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **totalCount** | **bool?** | Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false] |
| **barrierToInternetAccessInResidenceDescriptorId** | **int?** | A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. | [optional]  |
| **snapshotIdentifier** | **string?** | Indicates the Snapshot-Identifier that should be used. | [optional]  |

### Return type

[**List&lt;EdFiBarrierToInternetAccessInResidenceDescriptor&gt;**](EdFiBarrierToInternetAccessInResidenceDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested resource was successfully retrieved. |  -  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |
| **410** | Gone. An attempt to connect to the database for the snapshot specified by the Snapshot-Identifier header was unsuccessful (indicating the snapshot may have been removed). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbarriertointernetaccessinresidencedescriptorsbyid"></a>
# **GetBarrierToInternetAccessInResidenceDescriptorsById**
> EdFiBarrierToInternetAccessInResidenceDescriptor GetBarrierToInternetAccessInResidenceDescriptorsById (string id, string? ifNoneMatch = null, string? snapshotIdentifier = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Descriptors;

namespace Example
{
    public class GetBarrierToInternetAccessInResidenceDescriptorsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://stage.api.education.mn.gov:443/edfiapi/data/v3/2026";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BarrierToInternetAccessInResidenceDescriptorsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string? | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiBarrierToInternetAccessInResidenceDescriptor result = apiInstance.GetBarrierToInternetAccessInResidenceDescriptorsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BarrierToInternetAccessInResidenceDescriptorsApi.GetBarrierToInternetAccessInResidenceDescriptorsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBarrierToInternetAccessInResidenceDescriptorsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiBarrierToInternetAccessInResidenceDescriptor> response = apiInstance.GetBarrierToInternetAccessInResidenceDescriptorsByIdWithHttpInfo(id, ifNoneMatch, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BarrierToInternetAccessInResidenceDescriptorsApi.GetBarrierToInternetAccessInResidenceDescriptorsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **ifNoneMatch** | **string?** | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. | [optional]  |
| **snapshotIdentifier** | **string?** | Indicates the Snapshot-Identifier that should be used. | [optional]  |

### Return type

[**EdFiBarrierToInternetAccessInResidenceDescriptor**](EdFiBarrierToInternetAccessInResidenceDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested resource was successfully retrieved. |  -  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |
| **410** | Gone. An attempt to connect to the database for the snapshot specified by the Snapshot-Identifier header was unsuccessful (indicating the snapshot may have been removed). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keychangesbarriertointernetaccessinresidencedescriptors"></a>
# **KeyChangesBarrierToInternetAccessInResidenceDescriptors**
> List&lt;TrackedChangesEdFiBarrierToInternetAccessInResidenceDescriptorKeyChange&gt; KeyChangesBarrierToInternetAccessInResidenceDescriptors (int? offset = null, int? limit = null, long? minChangeVersion = null, long? maxChangeVersion = null, bool? totalCount = null, string? snapshotIdentifier = null)

Retrieves resources key changes based on change version.

This operation is used to retrieve identifying information about resources whose key values have been changed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Descriptors;

namespace Example
{
    public class KeyChangesBarrierToInternetAccessInResidenceDescriptorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://stage.api.education.mn.gov:443/edfiapi/data/v3/2026";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BarrierToInternetAccessInResidenceDescriptorsApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiBarrierToInternetAccessInResidenceDescriptorKeyChange> result = apiInstance.KeyChangesBarrierToInternetAccessInResidenceDescriptors(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BarrierToInternetAccessInResidenceDescriptorsApi.KeyChangesBarrierToInternetAccessInResidenceDescriptors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesBarrierToInternetAccessInResidenceDescriptorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiBarrierToInternetAccessInResidenceDescriptorKeyChange>> response = apiInstance.KeyChangesBarrierToInternetAccessInResidenceDescriptorsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BarrierToInternetAccessInResidenceDescriptorsApi.KeyChangesBarrierToInternetAccessInResidenceDescriptorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** | Indicates how many items should be skipped before returning results. | [optional] [default to 0] |
| **limit** | **int?** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **minChangeVersion** | **long?** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **long?** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **totalCount** | **bool?** | Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false] |
| **snapshotIdentifier** | **string?** | Indicates the Snapshot-Identifier that should be used. | [optional]  |

### Return type

[**List&lt;TrackedChangesEdFiBarrierToInternetAccessInResidenceDescriptorKeyChange&gt;**](TrackedChangesEdFiBarrierToInternetAccessInResidenceDescriptorKeyChange.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested resource was successfully retrieved. |  -  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |
| **410** | Gone. An attempt to connect to the database for the snapshot specified by the Snapshot-Identifier header was unsuccessful (indicating the snapshot may have been removed). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postbarriertointernetaccessinresidencedescriptor"></a>
# **PostBarrierToInternetAccessInResidenceDescriptor**
> void PostBarrierToInternetAccessInResidenceDescriptor (EdFiBarrierToInternetAccessInResidenceDescriptor barrierToInternetAccessInResidenceDescriptor)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error. The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately. It is recommended to use POST for both create and update except while updating natural key of a resource in which case PUT operation must be used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Descriptors;

namespace Example
{
    public class PostBarrierToInternetAccessInResidenceDescriptorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://stage.api.education.mn.gov:443/edfiapi/data/v3/2026";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BarrierToInternetAccessInResidenceDescriptorsApi(config);
            var barrierToInternetAccessInResidenceDescriptor = new EdFiBarrierToInternetAccessInResidenceDescriptor(); // EdFiBarrierToInternetAccessInResidenceDescriptor | The JSON representation of the \"barrierToInternetAccessInResidenceDescriptor\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostBarrierToInternetAccessInResidenceDescriptor(barrierToInternetAccessInResidenceDescriptor);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BarrierToInternetAccessInResidenceDescriptorsApi.PostBarrierToInternetAccessInResidenceDescriptor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostBarrierToInternetAccessInResidenceDescriptorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostBarrierToInternetAccessInResidenceDescriptorWithHttpInfo(barrierToInternetAccessInResidenceDescriptor);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BarrierToInternetAccessInResidenceDescriptorsApi.PostBarrierToInternetAccessInResidenceDescriptorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **barrierToInternetAccessInResidenceDescriptor** | [**EdFiBarrierToInternetAccessInResidenceDescriptor**](EdFiBarrierToInternetAccessInResidenceDescriptor.md) | The JSON representation of the \&quot;barrierToInternetAccessInResidenceDescriptor\&quot; resource to be created or updated. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The resource was updated.  An updated ETag value is available in the ETag header of the response. |  -  |
| **201** | The resource was created.  An ETag value is available in the ETag header, and the location of the resource is available in the Location header of the response. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **405** | Method Is Not Allowed. When the Snapshot-Identifier header is present the method is not allowed. |  -  |
| **409** | Conflict.  The request cannot be completed because it would result in an invalid state.  See the response body for details. |  -  |
| **412** | The resource&#39;s current server-side ETag value does not match the supplied If-Match header value in the request. This indicates the resource has been modified by another consumer. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbarriertointernetaccessinresidencedescriptor"></a>
# **PutBarrierToInternetAccessInResidenceDescriptor**
> void PutBarrierToInternetAccessInResidenceDescriptor (string id, EdFiBarrierToInternetAccessInResidenceDescriptor barrierToInternetAccessInResidenceDescriptor, string? ifMatch = null)

Updates a resource based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, this API resource is not configured for cascading natural key updates. Natural key values for this resource cannot be changed using PUT operation and will not be modified in the database, and so recommendation is to use POST as that supports upsert behavior.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Descriptors;

namespace Example
{
    public class PutBarrierToInternetAccessInResidenceDescriptorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://stage.api.education.mn.gov:443/edfiapi/data/v3/2026";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BarrierToInternetAccessInResidenceDescriptorsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var barrierToInternetAccessInResidenceDescriptor = new EdFiBarrierToInternetAccessInResidenceDescriptor(); // EdFiBarrierToInternetAccessInResidenceDescriptor | The JSON representation of the \"barrierToInternetAccessInResidenceDescriptor\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string? | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutBarrierToInternetAccessInResidenceDescriptor(id, barrierToInternetAccessInResidenceDescriptor, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BarrierToInternetAccessInResidenceDescriptorsApi.PutBarrierToInternetAccessInResidenceDescriptor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutBarrierToInternetAccessInResidenceDescriptorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutBarrierToInternetAccessInResidenceDescriptorWithHttpInfo(id, barrierToInternetAccessInResidenceDescriptor, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BarrierToInternetAccessInResidenceDescriptorsApi.PutBarrierToInternetAccessInResidenceDescriptorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **barrierToInternetAccessInResidenceDescriptor** | [**EdFiBarrierToInternetAccessInResidenceDescriptor**](EdFiBarrierToInternetAccessInResidenceDescriptor.md) | The JSON representation of the \&quot;barrierToInternetAccessInResidenceDescriptor\&quot; resource to be created or updated. |  |
| **ifMatch** | **string?** | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The resource was updated.  An updated ETag value is available in the ETag header of the response. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **405** | Method Is Not Allowed. When the Snapshot-Identifier header is present the method is not allowed. |  -  |
| **409** | Conflict.  The request cannot be completed because it would result in an invalid state.  See the response body for details. |  -  |
| **412** | The resource&#39;s current server-side ETag value does not match the supplied If-Match header value in the request. This indicates the resource has been modified by another consumer. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

