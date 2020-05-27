# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile.StudentTitleIPartAProgramAssociationsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/sb20_/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletestudentTitleIPartAProgramAssociationById**](StudentTitleIPartAProgramAssociationsApi.md#deletestudenttitleipartaprogramassociationbyid) | **DELETE** /ed-fi/studentTitleIPartAProgramAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentTitleIPartAProgramAssociations**](StudentTitleIPartAProgramAssociationsApi.md#getstudenttitleipartaprogramassociations) | **GET** /ed-fi/studentTitleIPartAProgramAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentTitleIPartAProgramAssociationsById**](StudentTitleIPartAProgramAssociationsApi.md#getstudenttitleipartaprogramassociationsbyid) | **GET** /ed-fi/studentTitleIPartAProgramAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PoststudentTitleIPartAProgramAssociation**](StudentTitleIPartAProgramAssociationsApi.md#poststudenttitleipartaprogramassociation) | **POST** /ed-fi/studentTitleIPartAProgramAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutstudentTitleIPartAProgramAssociation**](StudentTitleIPartAProgramAssociationsApi.md#putstudenttitleipartaprogramassociation) | **PUT** /ed-fi/studentTitleIPartAProgramAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudenttitleipartaprogramassociationbyid"></a>
# **DeletestudentTitleIPartAProgramAssociationById**
> void DeletestudentTitleIPartAProgramAssociationById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;

namespace Example
{
    public class DeletestudentTitleIPartAProgramAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentTitleIPartAProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeletestudentTitleIPartAProgramAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentTitleIPartAProgramAssociationsApi.DeletestudentTitleIPartAProgramAssociationById: " + e.Message );
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

 - **Content-Type**: application/vnd.ed-fi.studenttitleipartaprogramassociation.minnesota-twentytwentytwopreview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudenttitleipartaprogramassociations"></a>
# **GetStudentTitleIPartAProgramAssociations**
> List<EdFiStudentTitleIPartAProgramAssociationReadable> GetStudentTitleIPartAProgramAssociations (int? offset = null, int? limit = null, bool? totalCount = null, DateTime? beginDate = null, int? educationOrganizationId = null, int? programEducationOrganizationId = null, string programName = null, string programTypeDescriptor = null, string studentUniqueId = null, string titleIPartAParticipantDescriptor = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;

namespace Example
{
    public class GetStudentTitleIPartAProgramAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentTitleIPartAProgramAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var beginDate = 2013-10-20;  // DateTime? | The month, day, and year on which the Student first received services. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programName = programName_example;  // string | The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. (optional) 
            var programTypeDescriptor = programTypeDescriptor_example;  // string | The type of program. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var titleIPartAParticipantDescriptor = titleIPartAParticipantDescriptor_example;  // string | An indication of the type of Title I program, if any, in which the student is participating and by which the student is served:          Public Targeted Assistance Program          Public Schoolwide Program          Private School Students Participating          Local Neglected Program. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentTitleIPartAProgramAssociationReadable&gt; result = apiInstance.GetStudentTitleIPartAProgramAssociations(offset, limit, totalCount, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, titleIPartAParticipantDescriptor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentTitleIPartAProgramAssociationsApi.GetStudentTitleIPartAProgramAssociations: " + e.Message );
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
 **beginDate** | **DateTime?**| The month, day, and year on which the Student first received services. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **programEducationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **programName** | **string**| The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. | [optional] 
 **programTypeDescriptor** | **string**| The type of program. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **titleIPartAParticipantDescriptor** | **string**| An indication of the type of Title I program, if any, in which the student is participating and by which the student is served:          Public Targeted Assistance Program          Public Schoolwide Program          Private School Students Participating          Local Neglected Program. | [optional] 

### Return type

[**List<EdFiStudentTitleIPartAProgramAssociationReadable>**](EdFiStudentTitleIPartAProgramAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.studenttitleipartaprogramassociation.minnesota-twentytwentytwopreview-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudenttitleipartaprogramassociationsbyid"></a>
# **GetStudentTitleIPartAProgramAssociationsById**
> EdFiStudentTitleIPartAProgramAssociationReadable GetStudentTitleIPartAProgramAssociationsById (string id, string ifNoneMatch = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;

namespace Example
{
    public class GetStudentTitleIPartAProgramAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentTitleIPartAProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentTitleIPartAProgramAssociationReadable result = apiInstance.GetStudentTitleIPartAProgramAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentTitleIPartAProgramAssociationsApi.GetStudentTitleIPartAProgramAssociationsById: " + e.Message );
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

[**EdFiStudentTitleIPartAProgramAssociationReadable**](EdFiStudentTitleIPartAProgramAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.studenttitleipartaprogramassociation.minnesota-twentytwentytwopreview-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudenttitleipartaprogramassociation"></a>
# **PoststudentTitleIPartAProgramAssociation**
> void PoststudentTitleIPartAProgramAssociation (EdFiStudentTitleIPartAProgramAssociationWritable studentTitleIPartAProgramAssociation)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error (you must use a PUT operation to update a resource by \"id\"). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;

namespace Example
{
    public class PoststudentTitleIPartAProgramAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentTitleIPartAProgramAssociationsApi();
            var studentTitleIPartAProgramAssociation = new EdFiStudentTitleIPartAProgramAssociationWritable(); // EdFiStudentTitleIPartAProgramAssociationWritable | The JSON representation of the \"studentTitleIPartAProgramAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PoststudentTitleIPartAProgramAssociation(studentTitleIPartAProgramAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentTitleIPartAProgramAssociationsApi.PoststudentTitleIPartAProgramAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentTitleIPartAProgramAssociation** | [**EdFiStudentTitleIPartAProgramAssociationWritable**](EdFiStudentTitleIPartAProgramAssociationWritable.md)| The JSON representation of the \&quot;studentTitleIPartAProgramAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studenttitleipartaprogramassociation.minnesota-twentytwentytwopreview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudenttitleipartaprogramassociation"></a>
# **PutstudentTitleIPartAProgramAssociation**
> void PutstudentTitleIPartAProgramAssociation (string id, EdFiStudentTitleIPartAProgramAssociationWritable studentTitleIPartAProgramAssociation, string ifMatch = null)

Updates or creates a resource based on the resource identifier.

The PUT operation is used to update or create a resource by identifier. If the resource doesn't exist, the resource will be created using that identifier. Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource \"id\" is provided in the JSON body, it will be ignored as well.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;

namespace Example
{
    public class PutstudentTitleIPartAProgramAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentTitleIPartAProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentTitleIPartAProgramAssociation = new EdFiStudentTitleIPartAProgramAssociationWritable(); // EdFiStudentTitleIPartAProgramAssociationWritable | The JSON representation of the \"studentTitleIPartAProgramAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutstudentTitleIPartAProgramAssociation(id, studentTitleIPartAProgramAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentTitleIPartAProgramAssociationsApi.PutstudentTitleIPartAProgramAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentTitleIPartAProgramAssociation** | [**EdFiStudentTitleIPartAProgramAssociationWritable**](EdFiStudentTitleIPartAProgramAssociationWritable.md)| The JSON representation of the \&quot;studentTitleIPartAProgramAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studenttitleipartaprogramassociation.minnesota-twentytwentytwopreview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

