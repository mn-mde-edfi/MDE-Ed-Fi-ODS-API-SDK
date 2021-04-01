# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile.StudentSchoolAssociationsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/sb21_/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletestudentSchoolAssociationById**](StudentSchoolAssociationsApi.md#deletestudentschoolassociationbyid) | **DELETE** /ed-fi/studentSchoolAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentSchoolAssociations**](StudentSchoolAssociationsApi.md#getstudentschoolassociations) | **GET** /ed-fi/studentSchoolAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentSchoolAssociationsById**](StudentSchoolAssociationsApi.md#getstudentschoolassociationsbyid) | **GET** /ed-fi/studentSchoolAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PoststudentSchoolAssociation**](StudentSchoolAssociationsApi.md#poststudentschoolassociation) | **POST** /ed-fi/studentSchoolAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutstudentSchoolAssociation**](StudentSchoolAssociationsApi.md#putstudentschoolassociation) | **PUT** /ed-fi/studentSchoolAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudentschoolassociationbyid"></a>
# **DeletestudentSchoolAssociationById**
> void DeletestudentSchoolAssociationById (string id, string ifMatch = null)

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
    public class DeletestudentSchoolAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeletestudentSchoolAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSchoolAssociationsApi.DeletestudentSchoolAssociationById: " + e.Message );
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

 - **Content-Type**: application/vnd.ed-fi.studentschoolassociation.minnesota-twentyone-twentytwo-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentschoolassociations"></a>
# **GetStudentSchoolAssociations**
> List<EdFiStudentSchoolAssociationReadable> GetStudentSchoolAssociations (int? offset = null, int? limit = null, bool? totalCount = null, DateTime? entryDate = null, int? schoolId = null, string studentUniqueId = null, int? schoolYear = null, string entryTypeDescriptor = null, string exitWithdrawTypeDescriptor = null, string entryGradeLevelDescriptor = null, DateTime? exitWithdrawDate = null, string id = null)

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
    public class GetStudentSchoolAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var entryDate = 2013-10-20;  // DateTime? | The month, day, and year on which an individual enters and begins to receive instructional services in a school. (optional) 
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var schoolYear = 56;  // int? | The school year associated with the student's enrollment. (optional) 
            var entryTypeDescriptor = entryTypeDescriptor_example;  // string | The process by which a student enters a school during a given academic session. (optional) 
            var exitWithdrawTypeDescriptor = exitWithdrawTypeDescriptor_example;  // string | The circumstances under which the student exited from membership in an educational institution. (optional) 
            var entryGradeLevelDescriptor = entryGradeLevelDescriptor_example;  // string | The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session. (optional) 
            var exitWithdrawDate = 2013-10-20;  // DateTime? | The month, day, and year of the first day after the date of an individual's last attendance at a school (if known), the day on which an individual graduated, or the date on which it becomes known officially that an individual left school. (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentSchoolAssociationReadable&gt; result = apiInstance.GetStudentSchoolAssociations(offset, limit, totalCount, entryDate, schoolId, studentUniqueId, schoolYear, entryTypeDescriptor, exitWithdrawTypeDescriptor, entryGradeLevelDescriptor, exitWithdrawDate, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSchoolAssociationsApi.GetStudentSchoolAssociations: " + e.Message );
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
 **entryDate** | **DateTime?**| The month, day, and year on which an individual enters and begins to receive instructional services in a school. | [optional] 
 **schoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **schoolYear** | **int?**| The school year associated with the student&#39;s enrollment. | [optional] 
 **entryTypeDescriptor** | **string**| The process by which a student enters a school during a given academic session. | [optional] 
 **exitWithdrawTypeDescriptor** | **string**| The circumstances under which the student exited from membership in an educational institution. | [optional] 
 **entryGradeLevelDescriptor** | **string**| The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session. | [optional] 
 **exitWithdrawDate** | **DateTime?**| The month, day, and year of the first day after the date of an individual&#39;s last attendance at a school (if known), the day on which an individual graduated, or the date on which it becomes known officially that an individual left school. | [optional] 
 **id** | **string**|  | [optional] 

### Return type

[**List<EdFiStudentSchoolAssociationReadable>**](EdFiStudentSchoolAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.studentschoolassociation.minnesota-twentyone-twentytwo-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentschoolassociationsbyid"></a>
# **GetStudentSchoolAssociationsById**
> EdFiStudentSchoolAssociationReadable GetStudentSchoolAssociationsById (string id, string ifNoneMatch = null)

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
    public class GetStudentSchoolAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentSchoolAssociationReadable result = apiInstance.GetStudentSchoolAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSchoolAssociationsApi.GetStudentSchoolAssociationsById: " + e.Message );
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

[**EdFiStudentSchoolAssociationReadable**](EdFiStudentSchoolAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.studentschoolassociation.minnesota-twentyone-twentytwo-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentschoolassociation"></a>
# **PoststudentSchoolAssociation**
> void PoststudentSchoolAssociation (EdFiStudentSchoolAssociationWritable studentSchoolAssociation)

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
    public class PoststudentSchoolAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAssociationsApi();
            var studentSchoolAssociation = new EdFiStudentSchoolAssociationWritable(); // EdFiStudentSchoolAssociationWritable | The JSON representation of the \"studentSchoolAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PoststudentSchoolAssociation(studentSchoolAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSchoolAssociationsApi.PoststudentSchoolAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentSchoolAssociation** | [**EdFiStudentSchoolAssociationWritable**](EdFiStudentSchoolAssociationWritable.md)| The JSON representation of the \&quot;studentSchoolAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studentschoolassociation.minnesota-twentyone-twentytwo-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentschoolassociation"></a>
# **PutstudentSchoolAssociation**
> void PutstudentSchoolAssociation (string id, EdFiStudentSchoolAssociationWritable studentSchoolAssociation, string ifMatch = null)

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
    public class PutstudentSchoolAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSchoolAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentSchoolAssociation = new EdFiStudentSchoolAssociationWritable(); // EdFiStudentSchoolAssociationWritable | The JSON representation of the \"studentSchoolAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutstudentSchoolAssociation(id, studentSchoolAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSchoolAssociationsApi.PutstudentSchoolAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentSchoolAssociation** | [**EdFiStudentSchoolAssociationWritable**](EdFiStudentSchoolAssociationWritable.md)| The JSON representation of the \&quot;studentSchoolAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studentschoolassociation.minnesota-twentyone-twentytwo-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

