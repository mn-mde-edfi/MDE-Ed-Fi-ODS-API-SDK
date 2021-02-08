# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile.StudentAssessmentPrecodeSitesApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/sb21_/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletestudentAssessmentPrecodeSiteById**](StudentAssessmentPrecodeSitesApi.md#deletestudentassessmentprecodesitebyid) | **DELETE** /MN/studentAssessmentPrecodeSites/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentAssessmentPrecodeSites**](StudentAssessmentPrecodeSitesApi.md#getstudentassessmentprecodesites) | **GET** /MN/studentAssessmentPrecodeSites | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentAssessmentPrecodeSitesById**](StudentAssessmentPrecodeSitesApi.md#getstudentassessmentprecodesitesbyid) | **GET** /MN/studentAssessmentPrecodeSites/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PoststudentAssessmentPrecodeSite**](StudentAssessmentPrecodeSitesApi.md#poststudentassessmentprecodesite) | **POST** /MN/studentAssessmentPrecodeSites | Creates or updates resources based on the natural key values of the supplied resource.
[**PutstudentAssessmentPrecodeSite**](StudentAssessmentPrecodeSitesApi.md#putstudentassessmentprecodesite) | **PUT** /MN/studentAssessmentPrecodeSites/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudentassessmentprecodesitebyid"></a>
# **DeletestudentAssessmentPrecodeSiteById**
> void DeletestudentAssessmentPrecodeSiteById (string id, string ifMatch = null)

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
    public class DeletestudentAssessmentPrecodeSiteByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentPrecodeSitesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeletestudentAssessmentPrecodeSiteById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAssessmentPrecodeSitesApi.DeletestudentAssessmentPrecodeSiteById: " + e.Message );
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

 - **Content-Type**: application/vnd.ed-fi.studentassessmentprecodesite.minnesota-preview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentassessmentprecodesites"></a>
# **GetStudentAssessmentPrecodeSites**
> List<MnStudentAssessmentPrecodeSiteReadable> GetStudentAssessmentPrecodeSites (int? offset = null, int? limit = null, bool? totalCount = null, string precodeTypeDescriptor = null, int? educationOrganizationId = null, string contactElectronicMailAddress = null, string contactFirstName = null, string contactLastSurname = null, string contactTitle = null, string id = null)

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
    public class GetStudentAssessmentPrecodeSitesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentPrecodeSitesApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var precodeTypeDescriptor = precodeTypeDescriptor_example;  // string | Type of pre-code site record. For example, MCA/MTAS, ACCESS/ALT-ACCESS (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var contactElectronicMailAddress = contactElectronicMailAddress_example;  // string | Email address or login of administrative contact (optional) 
            var contactFirstName = contactFirstName_example;  // string | First name of administrative contact (optional) 
            var contactLastSurname = contactLastSurname_example;  // string | Last name of administrative contact (optional) 
            var contactTitle = contactTitle_example;  // string | Title of administrative contact (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;MnStudentAssessmentPrecodeSiteReadable&gt; result = apiInstance.GetStudentAssessmentPrecodeSites(offset, limit, totalCount, precodeTypeDescriptor, educationOrganizationId, contactElectronicMailAddress, contactFirstName, contactLastSurname, contactTitle, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAssessmentPrecodeSitesApi.GetStudentAssessmentPrecodeSites: " + e.Message );
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
 **totalCount** | **bool?**| Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false]
 **precodeTypeDescriptor** | **string**| Type of pre-code site record. For example, MCA/MTAS, ACCESS/ALT-ACCESS | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **contactElectronicMailAddress** | **string**| Email address or login of administrative contact | [optional] 
 **contactFirstName** | **string**| First name of administrative contact | [optional] 
 **contactLastSurname** | **string**| Last name of administrative contact | [optional] 
 **contactTitle** | **string**| Title of administrative contact | [optional] 
 **id** | **string**|  | [optional] 

### Return type

[**List<MnStudentAssessmentPrecodeSiteReadable>**](MnStudentAssessmentPrecodeSiteReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.studentassessmentprecodesite.minnesota-preview-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentassessmentprecodesitesbyid"></a>
# **GetStudentAssessmentPrecodeSitesById**
> MnStudentAssessmentPrecodeSiteReadable GetStudentAssessmentPrecodeSitesById (string id, string ifNoneMatch = null)

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
    public class GetStudentAssessmentPrecodeSitesByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentPrecodeSitesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                MnStudentAssessmentPrecodeSiteReadable result = apiInstance.GetStudentAssessmentPrecodeSitesById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAssessmentPrecodeSitesApi.GetStudentAssessmentPrecodeSitesById: " + e.Message );
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

### Return type

[**MnStudentAssessmentPrecodeSiteReadable**](MnStudentAssessmentPrecodeSiteReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.studentassessmentprecodesite.minnesota-preview-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentassessmentprecodesite"></a>
# **PoststudentAssessmentPrecodeSite**
> void PoststudentAssessmentPrecodeSite (MnStudentAssessmentPrecodeSiteWritable studentAssessmentPrecodeSite)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error (you must use a PUT operation to update a resource by \"id\"). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class PoststudentAssessmentPrecodeSiteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentPrecodeSitesApi();
            var studentAssessmentPrecodeSite = new MnStudentAssessmentPrecodeSiteWritable(); // MnStudentAssessmentPrecodeSiteWritable | The JSON representation of the \"studentAssessmentPrecodeSite\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PoststudentAssessmentPrecodeSite(studentAssessmentPrecodeSite);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAssessmentPrecodeSitesApi.PoststudentAssessmentPrecodeSite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentAssessmentPrecodeSite** | [**MnStudentAssessmentPrecodeSiteWritable**](MnStudentAssessmentPrecodeSiteWritable.md)| The JSON representation of the \&quot;studentAssessmentPrecodeSite\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studentassessmentprecodesite.minnesota-preview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentassessmentprecodesite"></a>
# **PutstudentAssessmentPrecodeSite**
> void PutstudentAssessmentPrecodeSite (string id, MnStudentAssessmentPrecodeSiteWritable studentAssessmentPrecodeSite, string ifMatch = null)

Updates or creates a resource based on the resource identifier.

The PUT operation is used to update or create a resource by identifier. If the resource doesn't exist, the resource will be created using that identifier. Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource \"id\" is provided in the JSON body, it will be ignored as well.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class PutstudentAssessmentPrecodeSiteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAssessmentPrecodeSitesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentAssessmentPrecodeSite = new MnStudentAssessmentPrecodeSiteWritable(); // MnStudentAssessmentPrecodeSiteWritable | The JSON representation of the \"studentAssessmentPrecodeSite\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutstudentAssessmentPrecodeSite(id, studentAssessmentPrecodeSite, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAssessmentPrecodeSitesApi.PutstudentAssessmentPrecodeSite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentAssessmentPrecodeSite** | [**MnStudentAssessmentPrecodeSiteWritable**](MnStudentAssessmentPrecodeSiteWritable.md)| The JSON representation of the \&quot;studentAssessmentPrecodeSite\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studentassessmentprecodesite.minnesota-preview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

