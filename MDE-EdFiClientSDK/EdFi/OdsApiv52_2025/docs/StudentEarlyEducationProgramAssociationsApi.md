# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile.StudentEarlyEducationProgramAssociationsApi

All URIs are relative to *https://test.edfi5.education.mn.gov:443/sb24/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeletesStudentEarlyEducationProgramAssociations**](StudentEarlyEducationProgramAssociationsApi.md#deletesstudentearlyeducationprogramassociations) | **GET** /MN/studentEarlyEducationProgramAssociations/deletes | Retrieves deleted resources based on change version. |
| [**DeletestudentEarlyEducationProgramAssociationById**](StudentEarlyEducationProgramAssociationsApi.md#deletestudentearlyeducationprogramassociationbyid) | **DELETE** /MN/studentEarlyEducationProgramAssociations/{id} | Deletes an existing resource using the resource identifier. |
| [**GetStudentEarlyEducationProgramAssociations**](StudentEarlyEducationProgramAssociationsApi.md#getstudentearlyeducationprogramassociations) | **GET** /MN/studentEarlyEducationProgramAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetStudentEarlyEducationProgramAssociationsById**](StudentEarlyEducationProgramAssociationsApi.md#getstudentearlyeducationprogramassociationsbyid) | **GET** /MN/studentEarlyEducationProgramAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**PoststudentEarlyEducationProgramAssociation**](StudentEarlyEducationProgramAssociationsApi.md#poststudentearlyeducationprogramassociation) | **POST** /MN/studentEarlyEducationProgramAssociations | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutstudentEarlyEducationProgramAssociation**](StudentEarlyEducationProgramAssociationsApi.md#putstudentearlyeducationprogramassociation) | **PUT** /MN/studentEarlyEducationProgramAssociations/{id} | Updates a resource based on the resource identifier. |

<a name="deletesstudentearlyeducationprogramassociations"></a>
# **DeletesStudentEarlyEducationProgramAssociations**
> List&lt;DeletedResource&gt; DeletesStudentEarlyEducationProgramAssociations (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, string? snapshotIdentifier = null)

Retrieves deleted resources based on change version.

The DELETES operation is used to retrieve deleted resources.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile;

namespace Example
{
    public class DeletesStudentEarlyEducationProgramAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.edfi5.education.mn.gov:443/sb24/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEarlyEducationProgramAssociationsApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List<DeletedResource> result = apiInstance.DeletesStudentEarlyEducationProgramAssociations(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEarlyEducationProgramAssociationsApi.DeletesStudentEarlyEducationProgramAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesStudentEarlyEducationProgramAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<DeletedResource>> response = apiInstance.DeletesStudentEarlyEducationProgramAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEarlyEducationProgramAssociationsApi.DeletesStudentEarlyEducationProgramAssociationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** | Indicates how many items should be skipped before returning results. | [optional] [default to 0] |
| **limit** | **int?** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **minChangeVersion** | **int?** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **int?** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **snapshotIdentifier** | **string?** | Indicates the Snapshot-Identifier that should be used. | [optional]  |

### Return type

[**List&lt;DeletedResource&gt;**](DeletedResource.md)

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

<a name="deletestudentearlyeducationprogramassociationbyid"></a>
# **DeletestudentEarlyEducationProgramAssociationById**
> void DeletestudentEarlyEducationProgramAssociationById (string id, string? ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile;

namespace Example
{
    public class DeletestudentEarlyEducationProgramAssociationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.edfi5.education.mn.gov:443/sb24/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEarlyEducationProgramAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string? | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeletestudentEarlyEducationProgramAssociationById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEarlyEducationProgramAssociationsApi.DeletestudentEarlyEducationProgramAssociationById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletestudentEarlyEducationProgramAssociationByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeletestudentEarlyEducationProgramAssociationByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEarlyEducationProgramAssociationsApi.DeletestudentEarlyEducationProgramAssociationByIdWithHttpInfo: " + e.Message);
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

<a name="getstudentearlyeducationprogramassociations"></a>
# **GetStudentEarlyEducationProgramAssociations**
> List&lt;MnStudentEarlyEducationProgramAssociationReadable&gt; GetStudentEarlyEducationProgramAssociations (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, bool? totalCount = null, DateTime? beginDate = null, int? educationOrganizationId = null, int? programEducationOrganizationId = null, string? programName = null, string? programTypeDescriptor = null, string? studentUniqueId = null, string? calendarCode = null, int? schoolId = null, int? schoolYear = null, string? programSectionDescriptor = null, string? snapshotIdentifier = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile;

namespace Example
{
    public class GetStudentEarlyEducationProgramAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.edfi5.education.mn.gov:443/sb24/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEarlyEducationProgramAssociationsApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var beginDate = DateTime.Parse("2013-10-20");  // DateTime? | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programName = "programName_example";  // string? | The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. (optional) 
            var programTypeDescriptor = "programTypeDescriptor_example";  // string? | The type of program. (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string? | A unique alphanumeric code assigned to a student. (optional) 
            var calendarCode = "calendarCode_example";  // string? | The identifier for the Calendar. (optional) 
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var schoolYear = 56;  // int? | The identifier for the school year associated with the Calendar. (optional) 
            var programSectionDescriptor = "programSectionDescriptor_example";  // string? | Descriptor of the program section. (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<MnStudentEarlyEducationProgramAssociationReadable> result = apiInstance.GetStudentEarlyEducationProgramAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, calendarCode, schoolId, schoolYear, programSectionDescriptor, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEarlyEducationProgramAssociationsApi.GetStudentEarlyEducationProgramAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentEarlyEducationProgramAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<MnStudentEarlyEducationProgramAssociationReadable>> response = apiInstance.GetStudentEarlyEducationProgramAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, calendarCode, schoolId, schoolYear, programSectionDescriptor, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEarlyEducationProgramAssociationsApi.GetStudentEarlyEducationProgramAssociationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** | Indicates how many items should be skipped before returning results. | [optional] [default to 0] |
| **limit** | **int?** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **minChangeVersion** | **int?** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **int?** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **totalCount** | **bool?** | Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false] |
| **beginDate** | **DateTime?** | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. | [optional]  |
| **educationOrganizationId** | **int?** | The identifier assigned to an education organization. | [optional]  |
| **programEducationOrganizationId** | **int?** | The identifier assigned to an education organization. | [optional]  |
| **programName** | **string?** | The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. | [optional]  |
| **programTypeDescriptor** | **string?** | The type of program. | [optional]  |
| **studentUniqueId** | **string?** | A unique alphanumeric code assigned to a student. | [optional]  |
| **calendarCode** | **string?** | The identifier for the Calendar. | [optional]  |
| **schoolId** | **int?** | The identifier assigned to a school. | [optional]  |
| **schoolYear** | **int?** | The identifier for the school year associated with the Calendar. | [optional]  |
| **programSectionDescriptor** | **string?** | Descriptor of the program section. | [optional]  |
| **snapshotIdentifier** | **string?** | Indicates the Snapshot-Identifier that should be used. | [optional]  |

### Return type

[**List&lt;MnStudentEarlyEducationProgramAssociationReadable&gt;**](MnStudentEarlyEducationProgramAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.ed-fi.studentearlyeducationprogramassociation.minnesota-twenty-four-twenty-five-sis-vendor-profile.readable+json


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

<a name="getstudentearlyeducationprogramassociationsbyid"></a>
# **GetStudentEarlyEducationProgramAssociationsById**
> MnStudentEarlyEducationProgramAssociationReadable GetStudentEarlyEducationProgramAssociationsById (string id, string? ifNoneMatch = null, string? snapshotIdentifier = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile;

namespace Example
{
    public class GetStudentEarlyEducationProgramAssociationsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.edfi5.education.mn.gov:443/sb24/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEarlyEducationProgramAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string? | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                MnStudentEarlyEducationProgramAssociationReadable result = apiInstance.GetStudentEarlyEducationProgramAssociationsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEarlyEducationProgramAssociationsApi.GetStudentEarlyEducationProgramAssociationsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentEarlyEducationProgramAssociationsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<MnStudentEarlyEducationProgramAssociationReadable> response = apiInstance.GetStudentEarlyEducationProgramAssociationsByIdWithHttpInfo(id, ifNoneMatch, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEarlyEducationProgramAssociationsApi.GetStudentEarlyEducationProgramAssociationsByIdWithHttpInfo: " + e.Message);
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

[**MnStudentEarlyEducationProgramAssociationReadable**](MnStudentEarlyEducationProgramAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.ed-fi.studentearlyeducationprogramassociation.minnesota-twenty-four-twenty-five-sis-vendor-profile.readable+json


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

<a name="poststudentearlyeducationprogramassociation"></a>
# **PoststudentEarlyEducationProgramAssociation**
> void PoststudentEarlyEducationProgramAssociation (MnStudentEarlyEducationProgramAssociationWritable studentEarlyEducationProgramAssociation)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error. The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately. It is recommended to use POST for both create and update except while updating natural key of a resource in which case PUT operation must be used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile;

namespace Example
{
    public class PoststudentEarlyEducationProgramAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.edfi5.education.mn.gov:443/sb24/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEarlyEducationProgramAssociationsApi(config);
            var studentEarlyEducationProgramAssociation = new MnStudentEarlyEducationProgramAssociationWritable(); // MnStudentEarlyEducationProgramAssociationWritable | The JSON representation of the \"studentEarlyEducationProgramAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PoststudentEarlyEducationProgramAssociation(studentEarlyEducationProgramAssociation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEarlyEducationProgramAssociationsApi.PoststudentEarlyEducationProgramAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PoststudentEarlyEducationProgramAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PoststudentEarlyEducationProgramAssociationWithHttpInfo(studentEarlyEducationProgramAssociation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEarlyEducationProgramAssociationsApi.PoststudentEarlyEducationProgramAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **studentEarlyEducationProgramAssociation** | [**MnStudentEarlyEducationProgramAssociationWritable**](MnStudentEarlyEducationProgramAssociationWritable.md) | The JSON representation of the \&quot;studentEarlyEducationProgramAssociation\&quot; resource to be created or updated. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studentearlyeducationprogramassociation.minnesota-twenty-four-twenty-five-sis-vendor-profile.writable+json
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

<a name="putstudentearlyeducationprogramassociation"></a>
# **PutstudentEarlyEducationProgramAssociation**
> void PutstudentEarlyEducationProgramAssociation (string id, MnStudentEarlyEducationProgramAssociationWritable studentEarlyEducationProgramAssociation, string? ifMatch = null)

Updates a resource based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, this API resource is not configured for cascading natural key updates. Natural key values for this resource cannot be changed using PUT operation and will not be modified in the database, and so recommendation is to use POST as that supports upsert behavior.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile;

namespace Example
{
    public class PutstudentEarlyEducationProgramAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://test.edfi5.education.mn.gov:443/sb24/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEarlyEducationProgramAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var studentEarlyEducationProgramAssociation = new MnStudentEarlyEducationProgramAssociationWritable(); // MnStudentEarlyEducationProgramAssociationWritable | The JSON representation of the \"studentEarlyEducationProgramAssociation\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string? | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutstudentEarlyEducationProgramAssociation(id, studentEarlyEducationProgramAssociation, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentEarlyEducationProgramAssociationsApi.PutstudentEarlyEducationProgramAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutstudentEarlyEducationProgramAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutstudentEarlyEducationProgramAssociationWithHttpInfo(id, studentEarlyEducationProgramAssociation, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentEarlyEducationProgramAssociationsApi.PutstudentEarlyEducationProgramAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **studentEarlyEducationProgramAssociation** | [**MnStudentEarlyEducationProgramAssociationWritable**](MnStudentEarlyEducationProgramAssociationWritable.md) | The JSON representation of the \&quot;studentEarlyEducationProgramAssociation\&quot; resource to be created or updated. |  |
| **ifMatch** | **string?** | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studentearlyeducationprogramassociation.minnesota-twenty-four-twenty-five-sis-vendor-profile.writable+json
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

