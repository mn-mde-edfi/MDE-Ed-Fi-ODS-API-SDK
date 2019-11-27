# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_SISVendor_Profile.Student21stCenturyLearningCenterGrantProgramAssociationsApi

All URIs are relative to *https://localhost:54746/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Deletestudent21stCenturyLearningCenterGrantProgramAssociationById**](Student21stCenturyLearningCenterGrantProgramAssociationsApi.md#deletestudent21stcenturylearningcentergrantprogramassociationbyid) | **DELETE** /MN/student21stCenturyLearningCenterGrantProgramAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStudent21stCenturyLearningCenterGrantProgramAssociations**](Student21stCenturyLearningCenterGrantProgramAssociationsApi.md#getstudent21stcenturylearningcentergrantprogramassociations) | **GET** /MN/student21stCenturyLearningCenterGrantProgramAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudent21stCenturyLearningCenterGrantProgramAssociationsById**](Student21stCenturyLearningCenterGrantProgramAssociationsApi.md#getstudent21stcenturylearningcentergrantprogramassociationsbyid) | **GET** /MN/student21stCenturyLearningCenterGrantProgramAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**Poststudent21stCenturyLearningCenterGrantProgramAssociation**](Student21stCenturyLearningCenterGrantProgramAssociationsApi.md#poststudent21stcenturylearningcentergrantprogramassociation) | **POST** /MN/student21stCenturyLearningCenterGrantProgramAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**Putstudent21stCenturyLearningCenterGrantProgramAssociation**](Student21stCenturyLearningCenterGrantProgramAssociationsApi.md#putstudent21stcenturylearningcentergrantprogramassociation) | **PUT** /MN/student21stCenturyLearningCenterGrantProgramAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudent21stcenturylearningcentergrantprogramassociationbyid"></a>
# **Deletestudent21stCenturyLearningCenterGrantProgramAssociationById**
> void Deletestudent21stCenturyLearningCenterGrantProgramAssociationById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile;

namespace Example
{
    public class Deletestudent21stCenturyLearningCenterGrantProgramAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Student21stCenturyLearningCenterGrantProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.Deletestudent21stCenturyLearningCenterGrantProgramAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Student21stCenturyLearningCenterGrantProgramAssociationsApi.Deletestudent21stCenturyLearningCenterGrantProgramAssociationById: " + e.Message );
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

 - **Content-Type**: application/vnd.ed-fi.student21stcenturylearningcentergrantprogramassociation.minnesota-sisvendor-profile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudent21stcenturylearningcentergrantprogramassociations"></a>
# **GetStudent21stCenturyLearningCenterGrantProgramAssociations**
> List<MnStudent21stCenturyLearningCenterGrantProgramAssociationReadable> GetStudent21stCenturyLearningCenterGrantProgramAssociations (int? offset = null, int? limit = null, bool? totalCount = null, DateTime? beginDate = null, int? educationOrganizationId = null, int? programEducationOrganizationId = null, string programName = null, string programTypeDescriptor = null, string studentUniqueId = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile;

namespace Example
{
    public class GetStudent21stCenturyLearningCenterGrantProgramAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Student21stCenturyLearningCenterGrantProgramAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var beginDate = 2013-10-20;  // DateTime? | The month, day, and year on which the Student first received services. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programName = programName_example;  // string | The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. (optional) 
            var programTypeDescriptor = programTypeDescriptor_example;  // string | The type of program. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;MnStudent21stCenturyLearningCenterGrantProgramAssociationReadable&gt; result = apiInstance.GetStudent21stCenturyLearningCenterGrantProgramAssociations(offset, limit, totalCount, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Student21stCenturyLearningCenterGrantProgramAssociationsApi.GetStudent21stCenturyLearningCenterGrantProgramAssociations: " + e.Message );
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

### Return type

[**List<MnStudent21stCenturyLearningCenterGrantProgramAssociationReadable>**](MnStudent21stCenturyLearningCenterGrantProgramAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.student21stcenturylearningcentergrantprogramassociation.minnesota-sisvendor-profile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudent21stcenturylearningcentergrantprogramassociationsbyid"></a>
# **GetStudent21stCenturyLearningCenterGrantProgramAssociationsById**
> MnStudent21stCenturyLearningCenterGrantProgramAssociationReadable GetStudent21stCenturyLearningCenterGrantProgramAssociationsById (string id, string ifNoneMatch = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile;

namespace Example
{
    public class GetStudent21stCenturyLearningCenterGrantProgramAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Student21stCenturyLearningCenterGrantProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                MnStudent21stCenturyLearningCenterGrantProgramAssociationReadable result = apiInstance.GetStudent21stCenturyLearningCenterGrantProgramAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Student21stCenturyLearningCenterGrantProgramAssociationsApi.GetStudent21stCenturyLearningCenterGrantProgramAssociationsById: " + e.Message );
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

[**MnStudent21stCenturyLearningCenterGrantProgramAssociationReadable**](MnStudent21stCenturyLearningCenterGrantProgramAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.student21stcenturylearningcentergrantprogramassociation.minnesota-sisvendor-profile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudent21stcenturylearningcentergrantprogramassociation"></a>
# **Poststudent21stCenturyLearningCenterGrantProgramAssociation**
> void Poststudent21stCenturyLearningCenterGrantProgramAssociation (MnStudent21stCenturyLearningCenterGrantProgramAssociationWritable student21stCenturyLearningCenterGrantProgramAssociation)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error (you must use a PUT operation to update a resource by \"id\"). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile;

namespace Example
{
    public class Poststudent21stCenturyLearningCenterGrantProgramAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Student21stCenturyLearningCenterGrantProgramAssociationsApi();
            var student21stCenturyLearningCenterGrantProgramAssociation = new MnStudent21stCenturyLearningCenterGrantProgramAssociationWritable(); // MnStudent21stCenturyLearningCenterGrantProgramAssociationWritable | The JSON representation of the \"student21stCenturyLearningCenterGrantProgramAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.Poststudent21stCenturyLearningCenterGrantProgramAssociation(student21stCenturyLearningCenterGrantProgramAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Student21stCenturyLearningCenterGrantProgramAssociationsApi.Poststudent21stCenturyLearningCenterGrantProgramAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **student21stCenturyLearningCenterGrantProgramAssociation** | [**MnStudent21stCenturyLearningCenterGrantProgramAssociationWritable**](MnStudent21stCenturyLearningCenterGrantProgramAssociationWritable.md)| The JSON representation of the \&quot;student21stCenturyLearningCenterGrantProgramAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.student21stcenturylearningcentergrantprogramassociation.minnesota-sisvendor-profile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudent21stcenturylearningcentergrantprogramassociation"></a>
# **Putstudent21stCenturyLearningCenterGrantProgramAssociation**
> void Putstudent21stCenturyLearningCenterGrantProgramAssociation (string id, MnStudent21stCenturyLearningCenterGrantProgramAssociationWritable student21stCenturyLearningCenterGrantProgramAssociation, string ifMatch = null)

Updates or creates a resource based on the resource identifier.

The PUT operation is used to update or create a resource by identifier. If the resource doesn't exist, the resource will be created using that identifier. Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource \"id\" is provided in the JSON body, it will be ignored as well.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile;

namespace Example
{
    public class Putstudent21stCenturyLearningCenterGrantProgramAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Student21stCenturyLearningCenterGrantProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var student21stCenturyLearningCenterGrantProgramAssociation = new MnStudent21stCenturyLearningCenterGrantProgramAssociationWritable(); // MnStudent21stCenturyLearningCenterGrantProgramAssociationWritable | The JSON representation of the \"student21stCenturyLearningCenterGrantProgramAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.Putstudent21stCenturyLearningCenterGrantProgramAssociation(id, student21stCenturyLearningCenterGrantProgramAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Student21stCenturyLearningCenterGrantProgramAssociationsApi.Putstudent21stCenturyLearningCenterGrantProgramAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **student21stCenturyLearningCenterGrantProgramAssociation** | [**MnStudent21stCenturyLearningCenterGrantProgramAssociationWritable**](MnStudent21stCenturyLearningCenterGrantProgramAssociationWritable.md)| The JSON representation of the \&quot;student21stCenturyLearningCenterGrantProgramAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.student21stcenturylearningcentergrantprogramassociation.minnesota-sisvendor-profile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

