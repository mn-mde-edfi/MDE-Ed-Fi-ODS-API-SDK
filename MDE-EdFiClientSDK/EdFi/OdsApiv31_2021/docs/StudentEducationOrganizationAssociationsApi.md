# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile.StudentEducationOrganizationAssociationsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/sb20_/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletestudentEducationOrganizationAssociationById**](StudentEducationOrganizationAssociationsApi.md#deletestudenteducationorganizationassociationbyid) | **DELETE** /ed-fi/studentEducationOrganizationAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentEducationOrganizationAssociations**](StudentEducationOrganizationAssociationsApi.md#getstudenteducationorganizationassociations) | **GET** /ed-fi/studentEducationOrganizationAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentEducationOrganizationAssociationsById**](StudentEducationOrganizationAssociationsApi.md#getstudenteducationorganizationassociationsbyid) | **GET** /ed-fi/studentEducationOrganizationAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PoststudentEducationOrganizationAssociation**](StudentEducationOrganizationAssociationsApi.md#poststudenteducationorganizationassociation) | **POST** /ed-fi/studentEducationOrganizationAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutstudentEducationOrganizationAssociation**](StudentEducationOrganizationAssociationsApi.md#putstudenteducationorganizationassociation) | **PUT** /ed-fi/studentEducationOrganizationAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudenteducationorganizationassociationbyid"></a>
# **DeletestudentEducationOrganizationAssociationById**
> void DeletestudentEducationOrganizationAssociationById (string id, string ifMatch = null)

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
    public class DeletestudentEducationOrganizationAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeletestudentEducationOrganizationAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.DeletestudentEducationOrganizationAssociationById: " + e.Message );
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

 - **Content-Type**: application/vnd.ed-fi.studenteducationorganizationassociation.minnesota-twentytwentytwopreview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudenteducationorganizationassociations"></a>
# **GetStudentEducationOrganizationAssociations**
> List<EdFiStudentEducationOrganizationAssociationReadable> GetStudentEducationOrganizationAssociations (int? offset = null, int? limit = null, bool? totalCount = null, int? educationOrganizationId = null, string studentUniqueId = null, string sexDescriptor = null, bool? hispanicLatinoEthnicity = null, string id = null)

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
    public class GetStudentEducationOrganizationAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var sexDescriptor = sexDescriptor_example;  // string | A person's gender. (optional) 
            var hispanicLatinoEthnicity = true;  // bool? | An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race. The term, \"Spanish origin,\" can be used in addition to \"Hispanic or Latino.\" (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentEducationOrganizationAssociationReadable&gt; result = apiInstance.GetStudentEducationOrganizationAssociations(offset, limit, totalCount, educationOrganizationId, studentUniqueId, sexDescriptor, hispanicLatinoEthnicity, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.GetStudentEducationOrganizationAssociations: " + e.Message );
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
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **sexDescriptor** | **string**| A person&#39;s gender. | [optional] 
 **hispanicLatinoEthnicity** | **bool?**| An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race. The term, \&quot;Spanish origin,\&quot; can be used in addition to \&quot;Hispanic or Latino.\&quot; | [optional] 
 **id** | **string**|  | [optional] 

### Return type

[**List<EdFiStudentEducationOrganizationAssociationReadable>**](EdFiStudentEducationOrganizationAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.studenteducationorganizationassociation.minnesota-twentytwentytwopreview-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudenteducationorganizationassociationsbyid"></a>
# **GetStudentEducationOrganizationAssociationsById**
> EdFiStudentEducationOrganizationAssociationReadable GetStudentEducationOrganizationAssociationsById (string id, string ifNoneMatch = null)

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
    public class GetStudentEducationOrganizationAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentEducationOrganizationAssociationReadable result = apiInstance.GetStudentEducationOrganizationAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.GetStudentEducationOrganizationAssociationsById: " + e.Message );
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

[**EdFiStudentEducationOrganizationAssociationReadable**](EdFiStudentEducationOrganizationAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.studenteducationorganizationassociation.minnesota-twentytwentytwopreview-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudenteducationorganizationassociation"></a>
# **PoststudentEducationOrganizationAssociation**
> void PoststudentEducationOrganizationAssociation (EdFiStudentEducationOrganizationAssociationWritable studentEducationOrganizationAssociation)

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
    public class PoststudentEducationOrganizationAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationAssociationsApi();
            var studentEducationOrganizationAssociation = new EdFiStudentEducationOrganizationAssociationWritable(); // EdFiStudentEducationOrganizationAssociationWritable | The JSON representation of the \"studentEducationOrganizationAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PoststudentEducationOrganizationAssociation(studentEducationOrganizationAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.PoststudentEducationOrganizationAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentEducationOrganizationAssociation** | [**EdFiStudentEducationOrganizationAssociationWritable**](EdFiStudentEducationOrganizationAssociationWritable.md)| The JSON representation of the \&quot;studentEducationOrganizationAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studenteducationorganizationassociation.minnesota-twentytwentytwopreview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudenteducationorganizationassociation"></a>
# **PutstudentEducationOrganizationAssociation**
> void PutstudentEducationOrganizationAssociation (string id, EdFiStudentEducationOrganizationAssociationWritable studentEducationOrganizationAssociation, string ifMatch = null)

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
    public class PutstudentEducationOrganizationAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentEducationOrganizationAssociation = new EdFiStudentEducationOrganizationAssociationWritable(); // EdFiStudentEducationOrganizationAssociationWritable | The JSON representation of the \"studentEducationOrganizationAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutstudentEducationOrganizationAssociation(id, studentEducationOrganizationAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.PutstudentEducationOrganizationAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentEducationOrganizationAssociation** | [**EdFiStudentEducationOrganizationAssociationWritable**](EdFiStudentEducationOrganizationAssociationWritable.md)| The JSON representation of the \&quot;studentEducationOrganizationAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studenteducationorganizationassociation.minnesota-twentytwentytwopreview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

