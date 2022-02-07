# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile.StudentAssessmentPrecodesApi

All URIs are relative to *https://test.edfi5.education.mn.gov:443/api/data/v3/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletesStudentAssessmentPrecodes**](StudentAssessmentPrecodesApi.md#deletesstudentassessmentprecodes) | **GET** /MN/studentAssessmentPrecodes/deletes | Retrieves deleted resources based on change version.
[**DeletestudentAssessmentPrecodeById**](StudentAssessmentPrecodesApi.md#deletestudentassessmentprecodebyid) | **DELETE** /MN/studentAssessmentPrecodes/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentAssessmentPrecodes**](StudentAssessmentPrecodesApi.md#getstudentassessmentprecodes) | **GET** /MN/studentAssessmentPrecodes | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentAssessmentPrecodesById**](StudentAssessmentPrecodesApi.md#getstudentassessmentprecodesbyid) | **GET** /MN/studentAssessmentPrecodes/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PoststudentAssessmentPrecode**](StudentAssessmentPrecodesApi.md#poststudentassessmentprecode) | **POST** /MN/studentAssessmentPrecodes | Creates or updates resources based on the natural key values of the supplied resource.
[**PutstudentAssessmentPrecode**](StudentAssessmentPrecodesApi.md#putstudentassessmentprecode) | **PUT** /MN/studentAssessmentPrecodes/{id} | Updates a resource based on the resource identifier.


<a name="deletesstudentassessmentprecodes"></a>
# **DeletesStudentAssessmentPrecodes**
> List<DeletedResource> DeletesStudentAssessmentPrecodes (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, string snapshotIdentifier = null)

Retrieves deleted resources based on change version.

The DELETES operation is used to retrieve deleted resources.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class DeletesStudentAssessmentPrecodesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentPrecodesApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List&lt;DeletedResource&gt; result = apiInstance.DeletesStudentAssessmentPrecodes(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAssessmentPrecodesApi.DeletesStudentAssessmentPrecodes: " + e.Message );
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
 **minChangeVersion** | **int?**| Used in synchronization to set sequence minimum ChangeVersion | [optional] 
 **maxChangeVersion** | **int?**| Used in synchronization to set sequence maximum ChangeVersion | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<DeletedResource>**](DeletedResource.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studentassessmentprecode.minnesota-preview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletestudentassessmentprecodebyid"></a>
# **DeletestudentAssessmentPrecodeById**
> void DeletestudentAssessmentPrecodeById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class DeletestudentAssessmentPrecodeByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentPrecodesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeletestudentAssessmentPrecodeById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAssessmentPrecodesApi.DeletestudentAssessmentPrecodeById: " + e.Message );
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

 - **Content-Type**: application/vnd.ed-fi.studentassessmentprecode.minnesota-preview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentassessmentprecodes"></a>
# **GetStudentAssessmentPrecodes**
> List<MnStudentAssessmentPrecodeReadable> GetStudentAssessmentPrecodes (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, bool? totalCount = null, string precodeTypeDescriptor = null, int? educationOrganizationId = null, string studentUniqueId = null, int? siteEducationOrganizationId = null, string sitePrecodeTypeDescriptor = null, string generalEnrollmentDescriptor = null, string assessedGradeLevelDescriptor = null, string enrolledGradeLevelDescriptor = null, string assessmentTitle = null, string customGroup = null, string id = null, string snapshotIdentifier = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class GetStudentAssessmentPrecodesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentPrecodesApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var precodeTypeDescriptor = precodeTypeDescriptor_example;  // string | Type of pre-code record. For example, MCA/MTAS, ACCESS/ALT-ACCESS (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var siteEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var sitePrecodeTypeDescriptor = sitePrecodeTypeDescriptor_example;  // string | Type of pre-code site record. For example, MCA/MTAS, ACCESS/ALT-ACCESS (optional) 
            var generalEnrollmentDescriptor = generalEnrollmentDescriptor_example;  // string | Student enrollment at the time of assessment pre-coding. For example H-Homeschool, N-Nonpublic, R-Regular (optional) 
            var assessedGradeLevelDescriptor = assessedGradeLevelDescriptor_example;  // string | The grade level tested for student when assessed. (optional) 
            var enrolledGradeLevelDescriptor = enrolledGradeLevelDescriptor_example;  // string | The grade level for which student is enrolled. (optional) 
            var assessmentTitle = assessmentTitle_example;  // string | Refers to the test name of the assessment taken by the student. (optional) 
            var customGroup = customGroup_example;  // string | District use special sort order (optional) 
            var id = id_example;  // string |  (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;MnStudentAssessmentPrecodeReadable&gt; result = apiInstance.GetStudentAssessmentPrecodes(offset, limit, minChangeVersion, maxChangeVersion, totalCount, precodeTypeDescriptor, educationOrganizationId, studentUniqueId, siteEducationOrganizationId, sitePrecodeTypeDescriptor, generalEnrollmentDescriptor, assessedGradeLevelDescriptor, enrolledGradeLevelDescriptor, assessmentTitle, customGroup, id, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAssessmentPrecodesApi.GetStudentAssessmentPrecodes: " + e.Message );
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
 **minChangeVersion** | **int?**| Used in synchronization to set sequence minimum ChangeVersion | [optional] 
 **maxChangeVersion** | **int?**| Used in synchronization to set sequence maximum ChangeVersion | [optional] 
 **totalCount** | **bool?**| Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false]
 **precodeTypeDescriptor** | **string**| Type of pre-code record. For example, MCA/MTAS, ACCESS/ALT-ACCESS | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **siteEducationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **sitePrecodeTypeDescriptor** | **string**| Type of pre-code site record. For example, MCA/MTAS, ACCESS/ALT-ACCESS | [optional] 
 **generalEnrollmentDescriptor** | **string**| Student enrollment at the time of assessment pre-coding. For example H-Homeschool, N-Nonpublic, R-Regular | [optional] 
 **assessedGradeLevelDescriptor** | **string**| The grade level tested for student when assessed. | [optional] 
 **enrolledGradeLevelDescriptor** | **string**| The grade level for which student is enrolled. | [optional] 
 **assessmentTitle** | **string**| Refers to the test name of the assessment taken by the student. | [optional] 
 **customGroup** | **string**| District use special sort order | [optional] 
 **id** | **string**|  | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<MnStudentAssessmentPrecodeReadable>**](MnStudentAssessmentPrecodeReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.studentassessmentprecode.minnesota-preview-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentassessmentprecodesbyid"></a>
# **GetStudentAssessmentPrecodesById**
> MnStudentAssessmentPrecodeReadable GetStudentAssessmentPrecodesById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class GetStudentAssessmentPrecodesByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentPrecodesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                MnStudentAssessmentPrecodeReadable result = apiInstance.GetStudentAssessmentPrecodesById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAssessmentPrecodesApi.GetStudentAssessmentPrecodesById: " + e.Message );
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
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**MnStudentAssessmentPrecodeReadable**](MnStudentAssessmentPrecodeReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.studentassessmentprecode.minnesota-preview-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentassessmentprecode"></a>
# **PoststudentAssessmentPrecode**
> void PoststudentAssessmentPrecode (MnStudentAssessmentPrecodeWritable studentAssessmentPrecode)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error. The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately. It is recommended to use POST for both create and update except while updating natural key of a resource in which case PUT operation must be used.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class PoststudentAssessmentPrecodeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentPrecodesApi();
            var studentAssessmentPrecode = new MnStudentAssessmentPrecodeWritable(); // MnStudentAssessmentPrecodeWritable | The JSON representation of the \"studentAssessmentPrecode\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PoststudentAssessmentPrecode(studentAssessmentPrecode);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAssessmentPrecodesApi.PoststudentAssessmentPrecode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentAssessmentPrecode** | [**MnStudentAssessmentPrecodeWritable**](MnStudentAssessmentPrecodeWritable.md)| The JSON representation of the \&quot;studentAssessmentPrecode\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studentassessmentprecode.minnesota-preview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentassessmentprecode"></a>
# **PutstudentAssessmentPrecode**
> void PutstudentAssessmentPrecode (string id, MnStudentAssessmentPrecodeWritable studentAssessmentPrecode, string ifMatch = null)

Updates a resource based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, this API resource is not configured for cascading natural key updates. Natural key values for this resource cannot be changed using PUT operation and will not be modified in the database, and so recommendation is to use POST as that supports upsert behavior.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class PutstudentAssessmentPrecodeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentPrecodesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentAssessmentPrecode = new MnStudentAssessmentPrecodeWritable(); // MnStudentAssessmentPrecodeWritable | The JSON representation of the \"studentAssessmentPrecode\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutstudentAssessmentPrecode(id, studentAssessmentPrecode, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAssessmentPrecodesApi.PutstudentAssessmentPrecode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentAssessmentPrecode** | [**MnStudentAssessmentPrecodeWritable**](MnStudentAssessmentPrecodeWritable.md)| The JSON representation of the \&quot;studentAssessmentPrecode\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studentassessmentprecode.minnesota-preview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

