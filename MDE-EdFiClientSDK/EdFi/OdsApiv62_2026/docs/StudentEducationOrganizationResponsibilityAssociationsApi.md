# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile.StudentEducationOrganizationResponsibilityAssociationsApi

All URIs are relative to *https://test.api.education.mn.gov:443/edfiapi/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeletesStudentEducationOrganizationResponsibilityAssociations**](StudentEducationOrganizationResponsibilityAssociationsApi.md#deletesstudenteducationorganizationresponsibilityassociations) | **GET** /ed-fi/studentEducationOrganizationResponsibilityAssociations/deletes | Retrieves deleted resources based on change version. |
| [**DeletestudentEducationOrganizationResponsibilityAssociationById**](StudentEducationOrganizationResponsibilityAssociationsApi.md#deletestudenteducationorganizationresponsibilityassociationbyid) | **DELETE** /ed-fi/studentEducationOrganizationResponsibilityAssociations/{id} | Deletes an existing resource using the resource identifier. |
| [**GetStudentEducationOrganizationResponsibilityAssociations**](StudentEducationOrganizationResponsibilityAssociationsApi.md#getstudenteducationorganizationresponsibilityassociations) | **GET** /ed-fi/studentEducationOrganizationResponsibilityAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetStudentEducationOrganizationResponsibilityAssociationsById**](StudentEducationOrganizationResponsibilityAssociationsApi.md#getstudenteducationorganizationresponsibilityassociationsbyid) | **GET** /ed-fi/studentEducationOrganizationResponsibilityAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**KeyChangesStudentEducationOrganizationResponsibilityAssociations**](StudentEducationOrganizationResponsibilityAssociationsApi.md#keychangesstudenteducationorganizationresponsibilityassociations) | **GET** /ed-fi/studentEducationOrganizationResponsibilityAssociations/keyChanges | Retrieves resources key changes based on change version. |
| [**PoststudentEducationOrganizationResponsibilityAssociation**](StudentEducationOrganizationResponsibilityAssociationsApi.md#poststudenteducationorganizationresponsibilityassociation) | **POST** /ed-fi/studentEducationOrganizationResponsibilityAssociations | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutstudentEducationOrganizationResponsibilityAssociation**](StudentEducationOrganizationResponsibilityAssociationsApi.md#putstudenteducationorganizationresponsibilityassociation) | **PUT** /ed-fi/studentEducationOrganizationResponsibilityAssociations/{id} | Updates a resource based on the resource identifier. |

<a name="deletesstudenteducationorganizationresponsibilityassociations"></a>
# **DeletesStudentEducationOrganizationResponsibilityAssociations**
> List&lt;TrackedChangesEdFiStudentEducationOrganizationResponsibilityAssociationReadableDelete&gt; DeletesStudentEducationOrganizationResponsibilityAssociations (int? offset = null, int? limit = null, long? minChangeVersion = null, long? maxChangeVersion = null, bool? totalCount = null, string? snapshotIdentifier = null)

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
    public class DeletesStudentEducationOrganizationResponsibilityAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationResponsibilityAssociationsApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiStudentEducationOrganizationResponsibilityAssociationReadableDelete> result = apiInstance.DeletesStudentEducationOrganizationResponsibilityAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationResponsibilityAssociationsApi.DeletesStudentEducationOrganizationResponsibilityAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesStudentEducationOrganizationResponsibilityAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiStudentEducationOrganizationResponsibilityAssociationReadableDelete>> response = apiInstance.DeletesStudentEducationOrganizationResponsibilityAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEducationOrganizationResponsibilityAssociationsApi.DeletesStudentEducationOrganizationResponsibilityAssociationsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStudentEducationOrganizationResponsibilityAssociationReadableDelete&gt;**](TrackedChangesEdFiStudentEducationOrganizationResponsibilityAssociationReadableDelete.md)

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

<a name="deletestudenteducationorganizationresponsibilityassociationbyid"></a>
# **DeletestudentEducationOrganizationResponsibilityAssociationById**
> void DeletestudentEducationOrganizationResponsibilityAssociationById (string id, string? ifMatch = null)

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
    public class DeletestudentEducationOrganizationResponsibilityAssociationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationResponsibilityAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string? | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeletestudentEducationOrganizationResponsibilityAssociationById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationResponsibilityAssociationsApi.DeletestudentEducationOrganizationResponsibilityAssociationById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletestudentEducationOrganizationResponsibilityAssociationByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeletestudentEducationOrganizationResponsibilityAssociationByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEducationOrganizationResponsibilityAssociationsApi.DeletestudentEducationOrganizationResponsibilityAssociationByIdWithHttpInfo: " + e.Message);
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

<a name="getstudenteducationorganizationresponsibilityassociations"></a>
# **GetStudentEducationOrganizationResponsibilityAssociations**
> List&lt;EdFiStudentEducationOrganizationResponsibilityAssociationReadable&gt; GetStudentEducationOrganizationResponsibilityAssociations (int? offset = null, int? limit = null, long? minChangeVersion = null, long? maxChangeVersion = null, bool? totalCount = null, string? responsibilityDescriptor = null, DateTime? beginDate = null, int? educationOrganizationId = null, string? studentUniqueId = null, DateTime? endDate = null, string? id = null, string? snapshotIdentifier = null)

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
    public class GetStudentEducationOrganizationResponsibilityAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationResponsibilityAssociationsApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var responsibilityDescriptor = "responsibilityDescriptor_example";  // string? | Indications of an education organization's responsibility for a student, such as accountability, attendance, funding, etc. (optional) 
            var beginDate = DateTime.Parse("2013-10-20");  // DateTime? | Month, day, and year of the start date of an education organization's responsibility for a student. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string? | A unique alphanumeric code assigned to a student. (optional) 
            var endDate = DateTime.Parse("2013-10-20");  // DateTime? | Month, day, and year of the end date of an education organization's responsibility for a student. (optional) 
            var id = "id_example";  // string? |  (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiStudentEducationOrganizationResponsibilityAssociationReadable> result = apiInstance.GetStudentEducationOrganizationResponsibilityAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, responsibilityDescriptor, beginDate, educationOrganizationId, studentUniqueId, endDate, id, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationResponsibilityAssociationsApi.GetStudentEducationOrganizationResponsibilityAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentEducationOrganizationResponsibilityAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiStudentEducationOrganizationResponsibilityAssociationReadable>> response = apiInstance.GetStudentEducationOrganizationResponsibilityAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, responsibilityDescriptor, beginDate, educationOrganizationId, studentUniqueId, endDate, id, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEducationOrganizationResponsibilityAssociationsApi.GetStudentEducationOrganizationResponsibilityAssociationsWithHttpInfo: " + e.Message);
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
| **responsibilityDescriptor** | **string?** | Indications of an education organization&#39;s responsibility for a student, such as accountability, attendance, funding, etc. | [optional]  |
| **beginDate** | **DateTime?** | Month, day, and year of the start date of an education organization&#39;s responsibility for a student. | [optional]  |
| **educationOrganizationId** | **int?** | The identifier assigned to an education organization. | [optional]  |
| **studentUniqueId** | **string?** | A unique alphanumeric code assigned to a student. | [optional]  |
| **endDate** | **DateTime?** | Month, day, and year of the end date of an education organization&#39;s responsibility for a student. | [optional]  |
| **id** | **string?** |  | [optional]  |
| **snapshotIdentifier** | **string?** | Indicates the Snapshot-Identifier that should be used. | [optional]  |

### Return type

[**List&lt;EdFiStudentEducationOrganizationResponsibilityAssociationReadable&gt;**](EdFiStudentEducationOrganizationResponsibilityAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.ed-fi.studenteducationorganizationresponsibilityassociation.minnesota-twenty-five-twenty-six-sis-vendor-profile.readable+json


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

<a name="getstudenteducationorganizationresponsibilityassociationsbyid"></a>
# **GetStudentEducationOrganizationResponsibilityAssociationsById**
> EdFiStudentEducationOrganizationResponsibilityAssociationReadable GetStudentEducationOrganizationResponsibilityAssociationsById (string id, string? ifNoneMatch = null, string? snapshotIdentifier = null)

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
    public class GetStudentEducationOrganizationResponsibilityAssociationsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationResponsibilityAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string? | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentEducationOrganizationResponsibilityAssociationReadable result = apiInstance.GetStudentEducationOrganizationResponsibilityAssociationsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationResponsibilityAssociationsApi.GetStudentEducationOrganizationResponsibilityAssociationsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentEducationOrganizationResponsibilityAssociationsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiStudentEducationOrganizationResponsibilityAssociationReadable> response = apiInstance.GetStudentEducationOrganizationResponsibilityAssociationsByIdWithHttpInfo(id, ifNoneMatch, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEducationOrganizationResponsibilityAssociationsApi.GetStudentEducationOrganizationResponsibilityAssociationsByIdWithHttpInfo: " + e.Message);
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

[**EdFiStudentEducationOrganizationResponsibilityAssociationReadable**](EdFiStudentEducationOrganizationResponsibilityAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.ed-fi.studenteducationorganizationresponsibilityassociation.minnesota-twenty-five-twenty-six-sis-vendor-profile.readable+json


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

<a name="keychangesstudenteducationorganizationresponsibilityassociations"></a>
# **KeyChangesStudentEducationOrganizationResponsibilityAssociations**
> List&lt;TrackedChangesEdFiStudentEducationOrganizationResponsibilityAssociationReadableKeyChange&gt; KeyChangesStudentEducationOrganizationResponsibilityAssociations (int? offset = null, int? limit = null, long? minChangeVersion = null, long? maxChangeVersion = null, bool? totalCount = null, string? snapshotIdentifier = null)

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
    public class KeyChangesStudentEducationOrganizationResponsibilityAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationResponsibilityAssociationsApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiStudentEducationOrganizationResponsibilityAssociationReadableKeyChange> result = apiInstance.KeyChangesStudentEducationOrganizationResponsibilityAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationResponsibilityAssociationsApi.KeyChangesStudentEducationOrganizationResponsibilityAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesStudentEducationOrganizationResponsibilityAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiStudentEducationOrganizationResponsibilityAssociationReadableKeyChange>> response = apiInstance.KeyChangesStudentEducationOrganizationResponsibilityAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEducationOrganizationResponsibilityAssociationsApi.KeyChangesStudentEducationOrganizationResponsibilityAssociationsWithHttpInfo: " + e.Message);
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

[**List&lt;TrackedChangesEdFiStudentEducationOrganizationResponsibilityAssociationReadableKeyChange&gt;**](TrackedChangesEdFiStudentEducationOrganizationResponsibilityAssociationReadableKeyChange.md)

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

<a name="poststudenteducationorganizationresponsibilityassociation"></a>
# **PoststudentEducationOrganizationResponsibilityAssociation**
> void PoststudentEducationOrganizationResponsibilityAssociation (EdFiStudentEducationOrganizationResponsibilityAssociationWritable studentEducationOrganizationResponsibilityAssociation)

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
    public class PoststudentEducationOrganizationResponsibilityAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationResponsibilityAssociationsApi(config);
            var studentEducationOrganizationResponsibilityAssociation = new EdFiStudentEducationOrganizationResponsibilityAssociationWritable(); // EdFiStudentEducationOrganizationResponsibilityAssociationWritable | The JSON representation of the \"studentEducationOrganizationResponsibilityAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PoststudentEducationOrganizationResponsibilityAssociation(studentEducationOrganizationResponsibilityAssociation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationResponsibilityAssociationsApi.PoststudentEducationOrganizationResponsibilityAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PoststudentEducationOrganizationResponsibilityAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PoststudentEducationOrganizationResponsibilityAssociationWithHttpInfo(studentEducationOrganizationResponsibilityAssociation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEducationOrganizationResponsibilityAssociationsApi.PoststudentEducationOrganizationResponsibilityAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **studentEducationOrganizationResponsibilityAssociation** | [**EdFiStudentEducationOrganizationResponsibilityAssociationWritable**](EdFiStudentEducationOrganizationResponsibilityAssociationWritable.md) | The JSON representation of the \&quot;studentEducationOrganizationResponsibilityAssociation\&quot; resource to be created or updated. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studenteducationorganizationresponsibilityassociation.minnesota-twenty-five-twenty-six-sis-vendor-profile.writable+json
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

<a name="putstudenteducationorganizationresponsibilityassociation"></a>
# **PutstudentEducationOrganizationResponsibilityAssociation**
> void PutstudentEducationOrganizationResponsibilityAssociation (string id, EdFiStudentEducationOrganizationResponsibilityAssociationWritable studentEducationOrganizationResponsibilityAssociation, string? ifMatch = null)

Updates a resource based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, this API resource is not configured for cascading natural key updates. Natural key values for this resource cannot be changed using PUT operation and will not be modified in the database, and so recommendation is to use POST as that supports upsert behavior.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile;

namespace Example
{
    public class PutstudentEducationOrganizationResponsibilityAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.api.education.mn.gov:443/edfiapi/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationResponsibilityAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var studentEducationOrganizationResponsibilityAssociation = new EdFiStudentEducationOrganizationResponsibilityAssociationWritable(); // EdFiStudentEducationOrganizationResponsibilityAssociationWritable | The JSON representation of the \"studentEducationOrganizationResponsibilityAssociation\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string? | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutstudentEducationOrganizationResponsibilityAssociation(id, studentEducationOrganizationResponsibilityAssociation, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationResponsibilityAssociationsApi.PutstudentEducationOrganizationResponsibilityAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutstudentEducationOrganizationResponsibilityAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutstudentEducationOrganizationResponsibilityAssociationWithHttpInfo(id, studentEducationOrganizationResponsibilityAssociation, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEducationOrganizationResponsibilityAssociationsApi.PutstudentEducationOrganizationResponsibilityAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **studentEducationOrganizationResponsibilityAssociation** | [**EdFiStudentEducationOrganizationResponsibilityAssociationWritable**](EdFiStudentEducationOrganizationResponsibilityAssociationWritable.md) | The JSON representation of the \&quot;studentEducationOrganizationResponsibilityAssociation\&quot; resource to be created or updated. |  |
| **ifMatch** | **string?** | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studenteducationorganizationresponsibilityassociation.minnesota-twenty-five-twenty-six-sis-vendor-profile.writable+json
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

