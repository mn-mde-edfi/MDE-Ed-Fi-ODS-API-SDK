# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile.SchoolAttributesApi

All URIs are relative to *https://test.api.education.mn.gov:443/edfiapi/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeletesSchoolAttributes**](SchoolAttributesApi.md#deletesschoolattributes) | **GET** /MN/schoolAttributes/deletes | Retrieves deleted resources based on change version. |
| [**DeleteschoolAttributeById**](SchoolAttributesApi.md#deleteschoolattributebyid) | **DELETE** /MN/schoolAttributes/{id} | Deletes an existing resource using the resource identifier. |
| [**GetSchoolAttributes**](SchoolAttributesApi.md#getschoolattributes) | **GET** /MN/schoolAttributes | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetSchoolAttributesById**](SchoolAttributesApi.md#getschoolattributesbyid) | **GET** /MN/schoolAttributes/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**KeyChangesSchoolAttributes**](SchoolAttributesApi.md#keychangesschoolattributes) | **GET** /MN/schoolAttributes/keyChanges | Retrieves resources key changes based on change version. |
| [**PostschoolAttribute**](SchoolAttributesApi.md#postschoolattribute) | **POST** /MN/schoolAttributes | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutschoolAttribute**](SchoolAttributesApi.md#putschoolattribute) | **PUT** /MN/schoolAttributes/{id} | Updates a resource based on the resource identifier. |

<a name="deletesschoolattributes"></a>
# **DeletesSchoolAttributes**
> List&lt;TrackedChangesMnSchoolAttributeReadableDelete&gt; DeletesSchoolAttributes (int? offset = null, int? limit = null, long? minChangeVersion = null, long? maxChangeVersion = null, bool? totalCount = null, string? snapshotIdentifier = null)

Retrieves deleted resources based on change version.

This operation is used to retrieve identifying information about resources that have been deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class DeletesSchoolAttributesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolAttributesApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesMnSchoolAttributeReadableDelete> result = apiInstance.DeletesSchoolAttributes(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolAttributesApi.DeletesSchoolAttributes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesSchoolAttributesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesMnSchoolAttributeReadableDelete>> response = apiInstance.DeletesSchoolAttributesWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchoolAttributesApi.DeletesSchoolAttributesWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesMnSchoolAttributeReadableDelete&gt;**](TrackedChangesMnSchoolAttributeReadableDelete.md)

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

<a name="deleteschoolattributebyid"></a>
# **DeleteschoolAttributeById**
> void DeleteschoolAttributeById (string id, string? ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class DeleteschoolAttributeByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolAttributesApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string? | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteschoolAttributeById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolAttributesApi.DeleteschoolAttributeById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteschoolAttributeByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeleteschoolAttributeByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchoolAttributesApi.DeleteschoolAttributeByIdWithHttpInfo: " + e.Message);
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

<a name="getschoolattributes"></a>
# **GetSchoolAttributes**
> List&lt;MnSchoolAttributeReadable&gt; GetSchoolAttributes (int? offset = null, int? limit = null, long? minChangeVersion = null, long? maxChangeVersion = null, bool? totalCount = null, int? schoolId = null, string? titleIPartASchoolDesignationDescriptor = null, bool? hasAntiBullyingPolicy = null, bool? hasAntiViolencePolicy = null, bool? hasCrisisPlan = null, bool? hasDrugEducation = null, bool? hasSafetyPlan = null, bool? hasZeroTolerancePolicy = null, string? id = null, int? numberOfHabitualTruants = null, string? safetySpecialistEmail = null, string? snapshotIdentifier = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class GetSchoolAttributesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolAttributesApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var titleIPartASchoolDesignationDescriptor = "titleIPartASchoolDesignationDescriptor_example";  // string? | Denotes the Title I Part A designation for the school. (optional) 
            var hasAntiBullyingPolicy = true;  // bool? | Indicator that the school enforces an anti-bullying policy. (optional) 
            var hasAntiViolencePolicy = true;  // bool? | Indicator that the school enforces an anti-violence policy. (optional) 
            var hasCrisisPlan = true;  // bool? | Indicator that the school has a crisis plan in place. (optional) 
            var hasDrugEducation = true;  // bool? | Indicator that the school has a drug education program in place. (optional) 
            var hasSafetyPlan = true;  // bool? | Indicator that the school has a safety plan in place. (optional) 
            var hasZeroTolerancePolicy = true;  // bool? | Indicator that the school enforces a zero tolerance policy. (optional) 
            var id = "id_example";  // string? |  (optional) 
            var numberOfHabitualTruants = 56;  // int? | The number of students in the school who are habitual truants. (optional) 
            var safetySpecialistEmail = "safetySpecialistEmail_example";  // string? | The email address of the school safety specialist at the school. (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<MnSchoolAttributeReadable> result = apiInstance.GetSchoolAttributes(offset, limit, minChangeVersion, maxChangeVersion, totalCount, schoolId, titleIPartASchoolDesignationDescriptor, hasAntiBullyingPolicy, hasAntiViolencePolicy, hasCrisisPlan, hasDrugEducation, hasSafetyPlan, hasZeroTolerancePolicy, id, numberOfHabitualTruants, safetySpecialistEmail, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolAttributesApi.GetSchoolAttributes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSchoolAttributesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<MnSchoolAttributeReadable>> response = apiInstance.GetSchoolAttributesWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, schoolId, titleIPartASchoolDesignationDescriptor, hasAntiBullyingPolicy, hasAntiViolencePolicy, hasCrisisPlan, hasDrugEducation, hasSafetyPlan, hasZeroTolerancePolicy, id, numberOfHabitualTruants, safetySpecialistEmail, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchoolAttributesApi.GetSchoolAttributesWithHttpInfo: " + e.Message);
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
| **schoolId** | **int?** | The identifier assigned to a school. | [optional]  |
| **titleIPartASchoolDesignationDescriptor** | **string?** | Denotes the Title I Part A designation for the school. | [optional]  |
| **hasAntiBullyingPolicy** | **bool?** | Indicator that the school enforces an anti-bullying policy. | [optional]  |
| **hasAntiViolencePolicy** | **bool?** | Indicator that the school enforces an anti-violence policy. | [optional]  |
| **hasCrisisPlan** | **bool?** | Indicator that the school has a crisis plan in place. | [optional]  |
| **hasDrugEducation** | **bool?** | Indicator that the school has a drug education program in place. | [optional]  |
| **hasSafetyPlan** | **bool?** | Indicator that the school has a safety plan in place. | [optional]  |
| **hasZeroTolerancePolicy** | **bool?** | Indicator that the school enforces a zero tolerance policy. | [optional]  |
| **id** | **string?** |  | [optional]  |
| **numberOfHabitualTruants** | **int?** | The number of students in the school who are habitual truants. | [optional]  |
| **safetySpecialistEmail** | **string?** | The email address of the school safety specialist at the school. | [optional]  |
| **snapshotIdentifier** | **string?** | Indicates the Snapshot-Identifier that should be used. | [optional]  |

### Return type

[**List&lt;MnSchoolAttributeReadable&gt;**](MnSchoolAttributeReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.ed-fi.schoolattribute.minnesota-preview-sisvendorprofile.readable+json


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

<a name="getschoolattributesbyid"></a>
# **GetSchoolAttributesById**
> MnSchoolAttributeReadable GetSchoolAttributesById (string id, string? ifNoneMatch = null, string? snapshotIdentifier = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class GetSchoolAttributesByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolAttributesApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string? | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                MnSchoolAttributeReadable result = apiInstance.GetSchoolAttributesById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolAttributesApi.GetSchoolAttributesById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSchoolAttributesByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<MnSchoolAttributeReadable> response = apiInstance.GetSchoolAttributesByIdWithHttpInfo(id, ifNoneMatch, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchoolAttributesApi.GetSchoolAttributesByIdWithHttpInfo: " + e.Message);
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

[**MnSchoolAttributeReadable**](MnSchoolAttributeReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.ed-fi.schoolattribute.minnesota-preview-sisvendorprofile.readable+json


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

<a name="keychangesschoolattributes"></a>
# **KeyChangesSchoolAttributes**
> List&lt;TrackedChangesMnSchoolAttributeReadableKeyChange&gt; KeyChangesSchoolAttributes (int? offset = null, int? limit = null, long? minChangeVersion = null, long? maxChangeVersion = null, bool? totalCount = null, string? snapshotIdentifier = null)

Retrieves resources key changes based on change version.

This operation is used to retrieve identifying information about resources whose key values have been changed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class KeyChangesSchoolAttributesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolAttributesApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesMnSchoolAttributeReadableKeyChange> result = apiInstance.KeyChangesSchoolAttributes(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolAttributesApi.KeyChangesSchoolAttributes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesSchoolAttributesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesMnSchoolAttributeReadableKeyChange>> response = apiInstance.KeyChangesSchoolAttributesWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchoolAttributesApi.KeyChangesSchoolAttributesWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesMnSchoolAttributeReadableKeyChange&gt;**](TrackedChangesMnSchoolAttributeReadableKeyChange.md)

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

<a name="postschoolattribute"></a>
# **PostschoolAttribute**
> void PostschoolAttribute (MnSchoolAttributeWritable schoolAttribute)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error. The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately. It is recommended to use POST for both create and update except while updating natural key of a resource in which case PUT operation must be used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class PostschoolAttributeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolAttributesApi(config);
            var schoolAttribute = new MnSchoolAttributeWritable(); // MnSchoolAttributeWritable | The JSON representation of the \"schoolAttribute\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostschoolAttribute(schoolAttribute);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolAttributesApi.PostschoolAttribute: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostschoolAttributeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostschoolAttributeWithHttpInfo(schoolAttribute);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchoolAttributesApi.PostschoolAttributeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **schoolAttribute** | [**MnSchoolAttributeWritable**](MnSchoolAttributeWritable.md) | The JSON representation of the \&quot;schoolAttribute\&quot; resource to be created or updated. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.schoolattribute.minnesota-preview-sisvendorprofile.writable+json
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

<a name="putschoolattribute"></a>
# **PutschoolAttribute**
> void PutschoolAttribute (string id, MnSchoolAttributeWritable schoolAttribute, string? ifMatch = null)

Updates a resource based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, this API resource is not configured for cascading natural key updates. Natural key values for this resource cannot be changed using PUT operation and will not be modified in the database, and so recommendation is to use POST as that supports upsert behavior.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class PutschoolAttributeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolAttributesApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var schoolAttribute = new MnSchoolAttributeWritable(); // MnSchoolAttributeWritable | The JSON representation of the \"schoolAttribute\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string? | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutschoolAttribute(id, schoolAttribute, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolAttributesApi.PutschoolAttribute: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutschoolAttributeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutschoolAttributeWithHttpInfo(id, schoolAttribute, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchoolAttributesApi.PutschoolAttributeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **schoolAttribute** | [**MnSchoolAttributeWritable**](MnSchoolAttributeWritable.md) | The JSON representation of the \&quot;schoolAttribute\&quot; resource to be created or updated. |  |
| **ifMatch** | **string?** | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.schoolattribute.minnesota-preview-sisvendorprofile.writable+json
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

