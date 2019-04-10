# EdFi.OdsApi.Sdk.Apis.All.StudentEducationOrganizationAssociationsApi

All URIs are relative to *https://localhost:56641/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentEducationOrganizationAssociationById**](StudentEducationOrganizationAssociationsApi.md#deletestudenteducationorganizationassociationbyid) | **DELETE** /ed-fi/studentEducationOrganizationAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentEducationOrganizationAssociations**](StudentEducationOrganizationAssociationsApi.md#getstudenteducationorganizationassociations) | **GET** /ed-fi/studentEducationOrganizationAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentEducationOrganizationAssociationsById**](StudentEducationOrganizationAssociationsApi.md#getstudenteducationorganizationassociationsbyid) | **GET** /ed-fi/studentEducationOrganizationAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudentEducationOrganizationAssociation**](StudentEducationOrganizationAssociationsApi.md#poststudenteducationorganizationassociation) | **POST** /ed-fi/studentEducationOrganizationAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudentEducationOrganizationAssociation**](StudentEducationOrganizationAssociationsApi.md#putstudenteducationorganizationassociation) | **PUT** /ed-fi/studentEducationOrganizationAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudenteducationorganizationassociationbyid"></a>
# **DeleteStudentEducationOrganizationAssociationById**
> void DeleteStudentEducationOrganizationAssociationById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.All;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.All;

namespace Example
{
    public class DeleteStudentEducationOrganizationAssociationByIdExample
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
                apiInstance.DeleteStudentEducationOrganizationAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.DeleteStudentEducationOrganizationAssociationById: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudenteducationorganizationassociations"></a>
# **GetStudentEducationOrganizationAssociations**
> List<EdFiStudentEducationOrganizationAssociation> GetStudentEducationOrganizationAssociations (int? offset = null, int? limit = null, bool? totalCount = null, int? educationOrganizationId = null, string studentUniqueId = null, string limitedEnglishProficiencyDescriptor = null, string oldEthnicityDescriptor = null, string sexDescriptor = null, bool? hispanicLatinoEthnicity = null, string id = null, string loginId = null, string profileThumbnail = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.All;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.All;

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
            var limitedEnglishProficiencyDescriptor = limitedEnglishProficiencyDescriptor_example;  // string | An indication that the student has been identified as limited English proficient by the Language Proficiency Assessment Committee (LPAC), or English proficient. (optional) 
            var oldEthnicityDescriptor = oldEthnicityDescriptor_example;  // string | Previous definition of Ethnicity combining Hispanic/Latino and race:          1 - American Indian or Alaskan Native          2 - Asian or Pacific Islander          3 - Black, not of Hispanic origin          4 - Hispanic          5 - White, not of Hispanic origin. (optional) 
            var sexDescriptor = sexDescriptor_example;  // string | A person's gender. (optional) 
            var hispanicLatinoEthnicity = true;  // bool? | An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race. The term, \"Spanish origin,\" can be used in addition to \"Hispanic or Latino.\" (optional) 
            var id = id_example;  // string |  (optional) 
            var loginId = loginId_example;  // string | The login ID for the user; used for security access control interface. (optional) 
            var profileThumbnail = profileThumbnail_example;  // string | Locator reference for the student photo. The specification for that reference is left to local definition. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentEducationOrganizationAssociation&gt; result = apiInstance.GetStudentEducationOrganizationAssociations(offset, limit, totalCount, educationOrganizationId, studentUniqueId, limitedEnglishProficiencyDescriptor, oldEthnicityDescriptor, sexDescriptor, hispanicLatinoEthnicity, id, loginId, profileThumbnail);
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
 **limitedEnglishProficiencyDescriptor** | **string**| An indication that the student has been identified as limited English proficient by the Language Proficiency Assessment Committee (LPAC), or English proficient. | [optional] 
 **oldEthnicityDescriptor** | **string**| Previous definition of Ethnicity combining Hispanic/Latino and race:          1 - American Indian or Alaskan Native          2 - Asian or Pacific Islander          3 - Black, not of Hispanic origin          4 - Hispanic          5 - White, not of Hispanic origin. | [optional] 
 **sexDescriptor** | **string**| A person&#39;s gender. | [optional] 
 **hispanicLatinoEthnicity** | **bool?**| An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race. The term, \&quot;Spanish origin,\&quot; can be used in addition to \&quot;Hispanic or Latino.\&quot; | [optional] 
 **id** | **string**|  | [optional] 
 **loginId** | **string**| The login ID for the user; used for security access control interface. | [optional] 
 **profileThumbnail** | **string**| Locator reference for the student photo. The specification for that reference is left to local definition. | [optional] 

### Return type

[**List<EdFiStudentEducationOrganizationAssociation>**](EdFiStudentEducationOrganizationAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudenteducationorganizationassociationsbyid"></a>
# **GetStudentEducationOrganizationAssociationsById**
> EdFiStudentEducationOrganizationAssociation GetStudentEducationOrganizationAssociationsById (string id, string ifNoneMatch = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.All;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.All;

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
                EdFiStudentEducationOrganizationAssociation result = apiInstance.GetStudentEducationOrganizationAssociationsById(id, ifNoneMatch);
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

[**EdFiStudentEducationOrganizationAssociation**](EdFiStudentEducationOrganizationAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudenteducationorganizationassociation"></a>
# **PostStudentEducationOrganizationAssociation**
> void PostStudentEducationOrganizationAssociation (EdFiStudentEducationOrganizationAssociation studentEducationOrganizationAssociation)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error (you must use a PUT operation to update a resource by \"id\"). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.All;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.All;

namespace Example
{
    public class PostStudentEducationOrganizationAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationAssociationsApi();
            var studentEducationOrganizationAssociation = new EdFiStudentEducationOrganizationAssociation(); // EdFiStudentEducationOrganizationAssociation | The JSON representation of the \"studentEducationOrganizationAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentEducationOrganizationAssociation(studentEducationOrganizationAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.PostStudentEducationOrganizationAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentEducationOrganizationAssociation** | [**EdFiStudentEducationOrganizationAssociation**](EdFiStudentEducationOrganizationAssociation.md)| The JSON representation of the \&quot;studentEducationOrganizationAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudenteducationorganizationassociation"></a>
# **PutStudentEducationOrganizationAssociation**
> void PutStudentEducationOrganizationAssociation (string id, EdFiStudentEducationOrganizationAssociation studentEducationOrganizationAssociation, string ifMatch = null)

Updates or creates a resource based on the resource identifier.

The PUT operation is used to update or create a resource by identifier. If the resource doesn't exist, the resource will be created using that identifier. Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource \"id\" is provided in the JSON body, it will be ignored as well.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.All;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.All;

namespace Example
{
    public class PutStudentEducationOrganizationAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEducationOrganizationAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentEducationOrganizationAssociation = new EdFiStudentEducationOrganizationAssociation(); // EdFiStudentEducationOrganizationAssociation | The JSON representation of the \"studentEducationOrganizationAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStudentEducationOrganizationAssociation(id, studentEducationOrganizationAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentEducationOrganizationAssociationsApi.PutStudentEducationOrganizationAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentEducationOrganizationAssociation** | [**EdFiStudentEducationOrganizationAssociation**](EdFiStudentEducationOrganizationAssociation.md)| The JSON representation of the \&quot;studentEducationOrganizationAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

