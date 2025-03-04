# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile.SectionsApi

All URIs are relative to *https://test.api.education.mn.gov:443/edfiapi/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeletesSections**](SectionsApi.md#deletessections) | **GET** /ed-fi/sections/deletes | Retrieves deleted resources based on change version. |
| [**DeletesectionById**](SectionsApi.md#deletesectionbyid) | **DELETE** /ed-fi/sections/{id} | Deletes an existing resource using the resource identifier. |
| [**GetSections**](SectionsApi.md#getsections) | **GET** /ed-fi/sections | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetSectionsById**](SectionsApi.md#getsectionsbyid) | **GET** /ed-fi/sections/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**KeyChangesSections**](SectionsApi.md#keychangessections) | **GET** /ed-fi/sections/keyChanges | Retrieves resources key changes based on change version. |
| [**Postsection**](SectionsApi.md#postsection) | **POST** /ed-fi/sections | Creates or updates resources based on the natural key values of the supplied resource. |
| [**Putsection**](SectionsApi.md#putsection) | **PUT** /ed-fi/sections/{id} | Updates a resource based on the resource identifier. |

<a name="deletessections"></a>
# **DeletesSections**
> List&lt;TrackedChangesEdFiSectionReadableDelete&gt; DeletesSections (int? offset = null, int? limit = null, long? minChangeVersion = null, long? maxChangeVersion = null, bool? totalCount = null, string? snapshotIdentifier = null)

Retrieves deleted resources based on change version.

This operation is used to retrieve identifying information about resources that have been deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile;

namespace Example
{
    public class DeletesSectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SectionsApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiSectionReadableDelete> result = apiInstance.DeletesSections(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SectionsApi.DeletesSections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesSectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiSectionReadableDelete>> response = apiInstance.DeletesSectionsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SectionsApi.DeletesSectionsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiSectionReadableDelete&gt;**](TrackedChangesEdFiSectionReadableDelete.md)

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

<a name="deletesectionbyid"></a>
# **DeletesectionById**
> void DeletesectionById (string id, string? ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile;

namespace Example
{
    public class DeletesectionByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SectionsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string? | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeletesectionById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SectionsApi.DeletesectionById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesectionByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeletesectionByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SectionsApi.DeletesectionByIdWithHttpInfo: " + e.Message);
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

<a name="getsections"></a>
# **GetSections**
> List&lt;EdFiSectionReadable&gt; GetSections (int? offset = null, int? limit = null, long? minChangeVersion = null, long? maxChangeVersion = null, bool? totalCount = null, string? sectionIdentifier = null, string? localCourseCode = null, int? schoolId = null, int? schoolYear = null, string? sessionName = null, string? instructionLanguageDescriptor = null, string? mediumOfInstructionDescriptor = null, string? id = null, int? sequenceOfCourse = null, string? snapshotIdentifier = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile;

namespace Example
{
    public class GetSectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SectionsApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var sectionIdentifier = "sectionIdentifier_example";  // string? | The local identifier assigned to a section. (optional) 
            var localCourseCode = "localCourseCode_example";  // string? | The local code assigned by the School that identifies the course offering provided for the instruction of students. (optional) 
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var schoolYear = 56;  // int? | The identifier for the school year. (optional) 
            var sessionName = "sessionName_example";  // string? | The identifier for the calendar for the academic session. (optional) 
            var instructionLanguageDescriptor = "instructionLanguageDescriptor_example";  // string? | The primary language of instruction. If omitted, English is assumed. (optional) 
            var mediumOfInstructionDescriptor = "mediumOfInstructionDescriptor_example";  // string? | The media through which teachers provide instruction to students and students and teachers communicate about instructional matters. (optional) 
            var id = "id_example";  // string? |  (optional) 
            var sequenceOfCourse = 56;  // int? | When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1. (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiSectionReadable> result = apiInstance.GetSections(offset, limit, minChangeVersion, maxChangeVersion, totalCount, sectionIdentifier, localCourseCode, schoolId, schoolYear, sessionName, instructionLanguageDescriptor, mediumOfInstructionDescriptor, id, sequenceOfCourse, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SectionsApi.GetSections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiSectionReadable>> response = apiInstance.GetSectionsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, sectionIdentifier, localCourseCode, schoolId, schoolYear, sessionName, instructionLanguageDescriptor, mediumOfInstructionDescriptor, id, sequenceOfCourse, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SectionsApi.GetSectionsWithHttpInfo: " + e.Message);
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
| **sectionIdentifier** | **string?** | The local identifier assigned to a section. | [optional]  |
| **localCourseCode** | **string?** | The local code assigned by the School that identifies the course offering provided for the instruction of students. | [optional]  |
| **schoolId** | **int?** | The identifier assigned to a school. | [optional]  |
| **schoolYear** | **int?** | The identifier for the school year. | [optional]  |
| **sessionName** | **string?** | The identifier for the calendar for the academic session. | [optional]  |
| **instructionLanguageDescriptor** | **string?** | The primary language of instruction. If omitted, English is assumed. | [optional]  |
| **mediumOfInstructionDescriptor** | **string?** | The media through which teachers provide instruction to students and students and teachers communicate about instructional matters. | [optional]  |
| **id** | **string?** |  | [optional]  |
| **sequenceOfCourse** | **int?** | When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1. | [optional]  |
| **snapshotIdentifier** | **string?** | Indicates the Snapshot-Identifier that should be used. | [optional]  |

### Return type

[**List&lt;EdFiSectionReadable&gt;**](EdFiSectionReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.ed-fi.section.minnesota-twenty-five-twenty-six-sis-vendor-profile.readable+json


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

<a name="getsectionsbyid"></a>
# **GetSectionsById**
> EdFiSectionReadable GetSectionsById (string id, string? ifNoneMatch = null, string? snapshotIdentifier = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile;

namespace Example
{
    public class GetSectionsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SectionsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string? | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiSectionReadable result = apiInstance.GetSectionsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SectionsApi.GetSectionsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSectionsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiSectionReadable> response = apiInstance.GetSectionsByIdWithHttpInfo(id, ifNoneMatch, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SectionsApi.GetSectionsByIdWithHttpInfo: " + e.Message);
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

[**EdFiSectionReadable**](EdFiSectionReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.ed-fi.section.minnesota-twenty-five-twenty-six-sis-vendor-profile.readable+json


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

<a name="keychangessections"></a>
# **KeyChangesSections**
> List&lt;TrackedChangesEdFiSectionReadableKeyChange&gt; KeyChangesSections (int? offset = null, int? limit = null, long? minChangeVersion = null, long? maxChangeVersion = null, bool? totalCount = null, string? snapshotIdentifier = null)

Retrieves resources key changes based on change version.

This operation is used to retrieve identifying information about resources whose key values have been changed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile;

namespace Example
{
    public class KeyChangesSectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SectionsApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiSectionReadableKeyChange> result = apiInstance.KeyChangesSections(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SectionsApi.KeyChangesSections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesSectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiSectionReadableKeyChange>> response = apiInstance.KeyChangesSectionsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SectionsApi.KeyChangesSectionsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiSectionReadableKeyChange&gt;**](TrackedChangesEdFiSectionReadableKeyChange.md)

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

<a name="postsection"></a>
# **Postsection**
> void Postsection (EdFiSectionWritable section)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error. The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately. It is recommended to use POST for both create and update except while updating natural key of a resource in which case PUT operation must be used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile;

namespace Example
{
    public class PostsectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SectionsApi(config);
            var section = new EdFiSectionWritable(); // EdFiSectionWritable | The JSON representation of the \"section\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.Postsection(section);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SectionsApi.Postsection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostsectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostsectionWithHttpInfo(section);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SectionsApi.PostsectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **section** | [**EdFiSectionWritable**](EdFiSectionWritable.md) | The JSON representation of the \&quot;section\&quot; resource to be created or updated. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.section.minnesota-twenty-five-twenty-six-sis-vendor-profile.writable+json
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

<a name="putsection"></a>
# **Putsection**
> void Putsection (string id, EdFiSectionWritable section, string? ifMatch = null)

Updates a resource based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, if natural key values are being updated by the JSON body, those changes will be applied to the resource and will also cascade through to dependent resources.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile;

namespace Example
{
    public class PutsectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SectionsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var section = new EdFiSectionWritable(); // EdFiSectionWritable | The JSON representation of the \"section\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string? | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.Putsection(id, section, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SectionsApi.Putsection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutsectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutsectionWithHttpInfo(id, section, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SectionsApi.PutsectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **section** | [**EdFiSectionWritable**](EdFiSectionWritable.md) | The JSON representation of the \&quot;section\&quot; resource to be created or updated. |  |
| **ifMatch** | **string?** | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.section.minnesota-twenty-five-twenty-six-sis-vendor-profile.writable+json
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

