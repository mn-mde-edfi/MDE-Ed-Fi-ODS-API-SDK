# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile.StudentLanguageInstructionProgramAssociationsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/sb21_/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletestudentLanguageInstructionProgramAssociationById**](StudentLanguageInstructionProgramAssociationsApi.md#deletestudentlanguageinstructionprogramassociationbyid) | **DELETE** /ed-fi/studentLanguageInstructionProgramAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentLanguageInstructionProgramAssociations**](StudentLanguageInstructionProgramAssociationsApi.md#getstudentlanguageinstructionprogramassociations) | **GET** /ed-fi/studentLanguageInstructionProgramAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentLanguageInstructionProgramAssociationsById**](StudentLanguageInstructionProgramAssociationsApi.md#getstudentlanguageinstructionprogramassociationsbyid) | **GET** /ed-fi/studentLanguageInstructionProgramAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PoststudentLanguageInstructionProgramAssociation**](StudentLanguageInstructionProgramAssociationsApi.md#poststudentlanguageinstructionprogramassociation) | **POST** /ed-fi/studentLanguageInstructionProgramAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutstudentLanguageInstructionProgramAssociation**](StudentLanguageInstructionProgramAssociationsApi.md#putstudentlanguageinstructionprogramassociation) | **PUT** /ed-fi/studentLanguageInstructionProgramAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudentlanguageinstructionprogramassociationbyid"></a>
# **DeletestudentLanguageInstructionProgramAssociationById**
> void DeletestudentLanguageInstructionProgramAssociationById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;

namespace Example
{
    public class DeletestudentLanguageInstructionProgramAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentLanguageInstructionProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeletestudentLanguageInstructionProgramAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentLanguageInstructionProgramAssociationsApi.DeletestudentLanguageInstructionProgramAssociationById: " + e.Message );
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

 - **Content-Type**: application/vnd.ed-fi.studentlanguageinstructionprogramassociation.minnesota-twentyone-twentytwo-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentlanguageinstructionprogramassociations"></a>
# **GetStudentLanguageInstructionProgramAssociations**
> List<EdFiStudentLanguageInstructionProgramAssociationReadable> GetStudentLanguageInstructionProgramAssociations (int? offset = null, int? limit = null, bool? totalCount = null, DateTime? beginDate = null, int? educationOrganizationId = null, int? programEducationOrganizationId = null, string programName = null, string programTypeDescriptor = null, string studentUniqueId = null, bool? englishLearnerParticipation = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;

namespace Example
{
    public class GetStudentLanguageInstructionProgramAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentLanguageInstructionProgramAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var beginDate = 2013-10-20;  // DateTime? | The month, day, and year on which the Student first received services. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programName = programName_example;  // string | The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. (optional) 
            var programTypeDescriptor = programTypeDescriptor_example;  // string | The type of program. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var englishLearnerParticipation = true;  // bool? | An indication that an English Learner student is served by an English language instruction educational program supported with Title III of ESEA funds. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentLanguageInstructionProgramAssociationReadable&gt; result = apiInstance.GetStudentLanguageInstructionProgramAssociations(offset, limit, totalCount, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, englishLearnerParticipation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentLanguageInstructionProgramAssociationsApi.GetStudentLanguageInstructionProgramAssociations: " + e.Message );
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
 **englishLearnerParticipation** | **bool?**| An indication that an English Learner student is served by an English language instruction educational program supported with Title III of ESEA funds. | [optional] 

### Return type

[**List<EdFiStudentLanguageInstructionProgramAssociationReadable>**](EdFiStudentLanguageInstructionProgramAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.studentlanguageinstructionprogramassociation.minnesota-twentyone-twentytwo-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentlanguageinstructionprogramassociationsbyid"></a>
# **GetStudentLanguageInstructionProgramAssociationsById**
> EdFiStudentLanguageInstructionProgramAssociationReadable GetStudentLanguageInstructionProgramAssociationsById (string id, string ifNoneMatch = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;

namespace Example
{
    public class GetStudentLanguageInstructionProgramAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentLanguageInstructionProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentLanguageInstructionProgramAssociationReadable result = apiInstance.GetStudentLanguageInstructionProgramAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentLanguageInstructionProgramAssociationsApi.GetStudentLanguageInstructionProgramAssociationsById: " + e.Message );
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

[**EdFiStudentLanguageInstructionProgramAssociationReadable**](EdFiStudentLanguageInstructionProgramAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.studentlanguageinstructionprogramassociation.minnesota-twentyone-twentytwo-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentlanguageinstructionprogramassociation"></a>
# **PoststudentLanguageInstructionProgramAssociation**
> void PoststudentLanguageInstructionProgramAssociation (EdFiStudentLanguageInstructionProgramAssociationWritable studentLanguageInstructionProgramAssociation)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error (you must use a PUT operation to update a resource by \"id\"). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;

namespace Example
{
    public class PoststudentLanguageInstructionProgramAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentLanguageInstructionProgramAssociationsApi();
            var studentLanguageInstructionProgramAssociation = new EdFiStudentLanguageInstructionProgramAssociationWritable(); // EdFiStudentLanguageInstructionProgramAssociationWritable | The JSON representation of the \"studentLanguageInstructionProgramAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PoststudentLanguageInstructionProgramAssociation(studentLanguageInstructionProgramAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentLanguageInstructionProgramAssociationsApi.PoststudentLanguageInstructionProgramAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentLanguageInstructionProgramAssociation** | [**EdFiStudentLanguageInstructionProgramAssociationWritable**](EdFiStudentLanguageInstructionProgramAssociationWritable.md)| The JSON representation of the \&quot;studentLanguageInstructionProgramAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studentlanguageinstructionprogramassociation.minnesota-twentyone-twentytwo-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentlanguageinstructionprogramassociation"></a>
# **PutstudentLanguageInstructionProgramAssociation**
> void PutstudentLanguageInstructionProgramAssociation (string id, EdFiStudentLanguageInstructionProgramAssociationWritable studentLanguageInstructionProgramAssociation, string ifMatch = null)

Updates or creates a resource based on the resource identifier.

The PUT operation is used to update or create a resource by identifier. If the resource doesn't exist, the resource will be created using that identifier. Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource \"id\" is provided in the JSON body, it will be ignored as well.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile;

namespace Example
{
    public class PutstudentLanguageInstructionProgramAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentLanguageInstructionProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentLanguageInstructionProgramAssociation = new EdFiStudentLanguageInstructionProgramAssociationWritable(); // EdFiStudentLanguageInstructionProgramAssociationWritable | The JSON representation of the \"studentLanguageInstructionProgramAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutstudentLanguageInstructionProgramAssociation(id, studentLanguageInstructionProgramAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentLanguageInstructionProgramAssociationsApi.PutstudentLanguageInstructionProgramAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentLanguageInstructionProgramAssociation** | [**EdFiStudentLanguageInstructionProgramAssociationWritable**](EdFiStudentLanguageInstructionProgramAssociationWritable.md)| The JSON representation of the \&quot;studentLanguageInstructionProgramAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studentlanguageinstructionprogramassociation.minnesota-twentyone-twentytwo-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

