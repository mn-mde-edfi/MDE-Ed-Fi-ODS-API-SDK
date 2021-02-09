# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile.StudentHomelessProgramAssociationsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/sb21_/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletestudentHomelessProgramAssociationById**](StudentHomelessProgramAssociationsApi.md#deletestudenthomelessprogramassociationbyid) | **DELETE** /ed-fi/studentHomelessProgramAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentHomelessProgramAssociations**](StudentHomelessProgramAssociationsApi.md#getstudenthomelessprogramassociations) | **GET** /ed-fi/studentHomelessProgramAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentHomelessProgramAssociationsById**](StudentHomelessProgramAssociationsApi.md#getstudenthomelessprogramassociationsbyid) | **GET** /ed-fi/studentHomelessProgramAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PoststudentHomelessProgramAssociation**](StudentHomelessProgramAssociationsApi.md#poststudenthomelessprogramassociation) | **POST** /ed-fi/studentHomelessProgramAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutstudentHomelessProgramAssociation**](StudentHomelessProgramAssociationsApi.md#putstudenthomelessprogramassociation) | **PUT** /ed-fi/studentHomelessProgramAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudenthomelessprogramassociationbyid"></a>
# **DeletestudentHomelessProgramAssociationById**
> void DeletestudentHomelessProgramAssociationById (string id, string ifMatch = null)

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
    public class DeletestudentHomelessProgramAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentHomelessProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeletestudentHomelessProgramAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentHomelessProgramAssociationsApi.DeletestudentHomelessProgramAssociationById: " + e.Message );
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

 - **Content-Type**: application/vnd.ed-fi.studenthomelessprogramassociation.minnesota-twentyone-twentytwo-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudenthomelessprogramassociations"></a>
# **GetStudentHomelessProgramAssociations**
> List<EdFiStudentHomelessProgramAssociationReadable> GetStudentHomelessProgramAssociations (int? offset = null, int? limit = null, bool? totalCount = null, DateTime? beginDate = null, int? educationOrganizationId = null, int? programEducationOrganizationId = null, string programName = null, string programTypeDescriptor = null, string studentUniqueId = null, string homelessPrimaryNighttimeResidenceDescriptor = null, bool? homelessUnaccompaniedYouth = null)

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
    public class GetStudentHomelessProgramAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentHomelessProgramAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var beginDate = 2013-10-20;  // DateTime? | The month, day, and year on which the Student first received services. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programName = programName_example;  // string | The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. (optional) 
            var programTypeDescriptor = programTypeDescriptor_example;  // string | The type of program. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var homelessPrimaryNighttimeResidenceDescriptor = homelessPrimaryNighttimeResidenceDescriptor_example;  // string | The primary nighttime residence of the student at the time the student is identified as homeless. (optional) 
            var homelessUnaccompaniedYouth = true;  // bool? | A homeless unaccompanied youth is a youth who is not in the physical custody of a parent or guardian and who fits the McKinney-Vento definition of homeless. Students must be both unaccompanied and homeless to be included as an unaccompanied homeless youth. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentHomelessProgramAssociationReadable&gt; result = apiInstance.GetStudentHomelessProgramAssociations(offset, limit, totalCount, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, homelessPrimaryNighttimeResidenceDescriptor, homelessUnaccompaniedYouth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentHomelessProgramAssociationsApi.GetStudentHomelessProgramAssociations: " + e.Message );
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
 **homelessPrimaryNighttimeResidenceDescriptor** | **string**| The primary nighttime residence of the student at the time the student is identified as homeless. | [optional] 
 **homelessUnaccompaniedYouth** | **bool?**| A homeless unaccompanied youth is a youth who is not in the physical custody of a parent or guardian and who fits the McKinney-Vento definition of homeless. Students must be both unaccompanied and homeless to be included as an unaccompanied homeless youth. | [optional] 

### Return type

[**List<EdFiStudentHomelessProgramAssociationReadable>**](EdFiStudentHomelessProgramAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.studenthomelessprogramassociation.minnesota-twentyone-twentytwo-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudenthomelessprogramassociationsbyid"></a>
# **GetStudentHomelessProgramAssociationsById**
> EdFiStudentHomelessProgramAssociationReadable GetStudentHomelessProgramAssociationsById (string id, string ifNoneMatch = null)

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
    public class GetStudentHomelessProgramAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentHomelessProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentHomelessProgramAssociationReadable result = apiInstance.GetStudentHomelessProgramAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentHomelessProgramAssociationsApi.GetStudentHomelessProgramAssociationsById: " + e.Message );
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

[**EdFiStudentHomelessProgramAssociationReadable**](EdFiStudentHomelessProgramAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.studenthomelessprogramassociation.minnesota-twentyone-twentytwo-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudenthomelessprogramassociation"></a>
# **PoststudentHomelessProgramAssociation**
> void PoststudentHomelessProgramAssociation (EdFiStudentHomelessProgramAssociationWritable studentHomelessProgramAssociation)

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
    public class PoststudentHomelessProgramAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentHomelessProgramAssociationsApi();
            var studentHomelessProgramAssociation = new EdFiStudentHomelessProgramAssociationWritable(); // EdFiStudentHomelessProgramAssociationWritable | The JSON representation of the \"studentHomelessProgramAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PoststudentHomelessProgramAssociation(studentHomelessProgramAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentHomelessProgramAssociationsApi.PoststudentHomelessProgramAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentHomelessProgramAssociation** | [**EdFiStudentHomelessProgramAssociationWritable**](EdFiStudentHomelessProgramAssociationWritable.md)| The JSON representation of the \&quot;studentHomelessProgramAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studenthomelessprogramassociation.minnesota-twentyone-twentytwo-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudenthomelessprogramassociation"></a>
# **PutstudentHomelessProgramAssociation**
> void PutstudentHomelessProgramAssociation (string id, EdFiStudentHomelessProgramAssociationWritable studentHomelessProgramAssociation, string ifMatch = null)

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
    public class PutstudentHomelessProgramAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentHomelessProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentHomelessProgramAssociation = new EdFiStudentHomelessProgramAssociationWritable(); // EdFiStudentHomelessProgramAssociationWritable | The JSON representation of the \"studentHomelessProgramAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutstudentHomelessProgramAssociation(id, studentHomelessProgramAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentHomelessProgramAssociationsApi.PutstudentHomelessProgramAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentHomelessProgramAssociation** | [**EdFiStudentHomelessProgramAssociationWritable**](EdFiStudentHomelessProgramAssociationWritable.md)| The JSON representation of the \&quot;studentHomelessProgramAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studenthomelessprogramassociation.minnesota-twentyone-twentytwo-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

