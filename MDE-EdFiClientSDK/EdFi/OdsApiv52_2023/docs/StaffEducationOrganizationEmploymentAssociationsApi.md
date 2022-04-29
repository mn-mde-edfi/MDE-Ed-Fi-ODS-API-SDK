# EdFi.OdsApi.Sdk.Apis.Identity.StaffEducationOrganizationEmploymentAssociationsApi

All URIs are relative to *https://test.edfi5.education.mn.gov:443/api/data/v3/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStaffEducationOrganizationEmploymentAssociationById**](StaffEducationOrganizationEmploymentAssociationsApi.md#deletestaffeducationorganizationemploymentassociationbyid) | **DELETE** /ed-fi/staffEducationOrganizationEmploymentAssociations/{id} | Deletes an existing resource using the resource identifier.
[**DeletesStaffEducationOrganizationEmploymentAssociations**](StaffEducationOrganizationEmploymentAssociationsApi.md#deletesstaffeducationorganizationemploymentassociations) | **GET** /ed-fi/staffEducationOrganizationEmploymentAssociations/deletes | Retrieves deleted resources based on change version.
[**GetStaffEducationOrganizationEmploymentAssociations**](StaffEducationOrganizationEmploymentAssociationsApi.md#getstaffeducationorganizationemploymentassociations) | **GET** /ed-fi/staffEducationOrganizationEmploymentAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStaffEducationOrganizationEmploymentAssociationsById**](StaffEducationOrganizationEmploymentAssociationsApi.md#getstaffeducationorganizationemploymentassociationsbyid) | **GET** /ed-fi/staffEducationOrganizationEmploymentAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStaffEducationOrganizationEmploymentAssociation**](StaffEducationOrganizationEmploymentAssociationsApi.md#poststaffeducationorganizationemploymentassociation) | **POST** /ed-fi/staffEducationOrganizationEmploymentAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStaffEducationOrganizationEmploymentAssociation**](StaffEducationOrganizationEmploymentAssociationsApi.md#putstaffeducationorganizationemploymentassociation) | **PUT** /ed-fi/staffEducationOrganizationEmploymentAssociations/{id} | Updates a resource based on the resource identifier.


<a name="deletestaffeducationorganizationemploymentassociationbyid"></a>
# **DeleteStaffEducationOrganizationEmploymentAssociationById**
> void DeleteStaffEducationOrganizationEmploymentAssociationById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class DeleteStaffEducationOrganizationEmploymentAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationEmploymentAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStaffEducationOrganizationEmploymentAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationEmploymentAssociationsApi.DeleteStaffEducationOrganizationEmploymentAssociationById: " + e.Message );
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

<a name="deletesstaffeducationorganizationemploymentassociations"></a>
# **DeletesStaffEducationOrganizationEmploymentAssociations**
> List<DeletedResource> DeletesStaffEducationOrganizationEmploymentAssociations (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, string snapshotIdentifier = null)

Retrieves deleted resources based on change version.

The DELETES operation is used to retrieve deleted resources.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class DeletesStaffEducationOrganizationEmploymentAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationEmploymentAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List&lt;DeletedResource&gt; result = apiInstance.DeletesStaffEducationOrganizationEmploymentAssociations(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationEmploymentAssociationsApi.DeletesStaffEducationOrganizationEmploymentAssociations: " + e.Message );
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

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstaffeducationorganizationemploymentassociations"></a>
# **GetStaffEducationOrganizationEmploymentAssociations**
> List<EdFiStaffEducationOrganizationEmploymentAssociation> GetStaffEducationOrganizationEmploymentAssociations (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, bool? totalCount = null, string employmentStatusDescriptor = null, DateTime? hireDate = null, int? educationOrganizationId = null, string staffUniqueId = null, string credentialIdentifier = null, string stateOfIssueStateAbbreviationDescriptor = null, string separationDescriptor = null, string separationReasonDescriptor = null, string department = null, DateTime? endDate = null, double? fullTimeEquivalency = null, double? hourlyWage = null, string id = null, DateTime? offerDate = null, string snapshotIdentifier = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class GetStaffEducationOrganizationEmploymentAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationEmploymentAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var employmentStatusDescriptor = employmentStatusDescriptor_example;  // string | Reflects the type of employment or contract; for example:         Probationary         Contractual         Substitute/temporary         Tenured or permanent         Volunteer/no contract         ... (optional) 
            var hireDate = 2013-10-20;  // DateTime? | The month, day, and year on which an individual was hired for a position. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var staffUniqueId = staffUniqueId_example;  // string | A unique alphanumeric code assigned to a staff. (optional) 
            var credentialIdentifier = credentialIdentifier_example;  // string | Identifier or serial number assigned to the credential. (optional) 
            var stateOfIssueStateAbbreviationDescriptor = stateOfIssueStateAbbreviationDescriptor_example;  // string | The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a license/credential was issued. (optional) 
            var separationDescriptor = separationDescriptor_example;  // string | Type of employment separation; for example: Voluntary separation, Involuntary separation,         Mutual agreement         Other, etc. (optional) 
            var separationReasonDescriptor = separationReasonDescriptor_example;  // string | Reason for terminating the employment; for example:         Employment in education         Employment outside of education         Retirement         Family/personal relocation         Change of assignment. (optional) 
            var department = department_example;  // string | The department or suborganization the employee/contractor is associated with in the EducationOrganization. (optional) 
            var endDate = 2013-10-20;  // DateTime? | The month, day, and year on which a contract between an individual and a governing authority ends or is terminated under the provisions of the contract (or the date on which the agreement is made invalid). (optional) 
            var fullTimeEquivalency = 1.2;  // double? | The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting. (optional) 
            var hourlyWage = 1.2;  // double? | Hourly wage associated with the employment position being reported. (optional) 
            var id = id_example;  // string |  (optional) 
            var offerDate = 2013-10-20;  // DateTime? | Date at which the staff member was made an official offer for this employment. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStaffEducationOrganizationEmploymentAssociation&gt; result = apiInstance.GetStaffEducationOrganizationEmploymentAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, employmentStatusDescriptor, hireDate, educationOrganizationId, staffUniqueId, credentialIdentifier, stateOfIssueStateAbbreviationDescriptor, separationDescriptor, separationReasonDescriptor, department, endDate, fullTimeEquivalency, hourlyWage, id, offerDate, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationEmploymentAssociationsApi.GetStaffEducationOrganizationEmploymentAssociations: " + e.Message );
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
 **employmentStatusDescriptor** | **string**| Reflects the type of employment or contract; for example:         Probationary         Contractual         Substitute/temporary         Tenured or permanent         Volunteer/no contract         ... | [optional] 
 **hireDate** | **DateTime?**| The month, day, and year on which an individual was hired for a position. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **staffUniqueId** | **string**| A unique alphanumeric code assigned to a staff. | [optional] 
 **credentialIdentifier** | **string**| Identifier or serial number assigned to the credential. | [optional] 
 **stateOfIssueStateAbbreviationDescriptor** | **string**| The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a license/credential was issued. | [optional] 
 **separationDescriptor** | **string**| Type of employment separation; for example: Voluntary separation, Involuntary separation,         Mutual agreement         Other, etc. | [optional] 
 **separationReasonDescriptor** | **string**| Reason for terminating the employment; for example:         Employment in education         Employment outside of education         Retirement         Family/personal relocation         Change of assignment. | [optional] 
 **department** | **string**| The department or suborganization the employee/contractor is associated with in the EducationOrganization. | [optional] 
 **endDate** | **DateTime?**| The month, day, and year on which a contract between an individual and a governing authority ends or is terminated under the provisions of the contract (or the date on which the agreement is made invalid). | [optional] 
 **fullTimeEquivalency** | **double?**| The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting. | [optional] 
 **hourlyWage** | **double?**| Hourly wage associated with the employment position being reported. | [optional] 
 **id** | **string**|  | [optional] 
 **offerDate** | **DateTime?**| Date at which the staff member was made an official offer for this employment. | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<EdFiStaffEducationOrganizationEmploymentAssociation>**](EdFiStaffEducationOrganizationEmploymentAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstaffeducationorganizationemploymentassociationsbyid"></a>
# **GetStaffEducationOrganizationEmploymentAssociationsById**
> EdFiStaffEducationOrganizationEmploymentAssociation GetStaffEducationOrganizationEmploymentAssociationsById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class GetStaffEducationOrganizationEmploymentAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationEmploymentAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStaffEducationOrganizationEmploymentAssociation result = apiInstance.GetStaffEducationOrganizationEmploymentAssociationsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationEmploymentAssociationsApi.GetStaffEducationOrganizationEmploymentAssociationsById: " + e.Message );
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

[**EdFiStaffEducationOrganizationEmploymentAssociation**](EdFiStaffEducationOrganizationEmploymentAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststaffeducationorganizationemploymentassociation"></a>
# **PostStaffEducationOrganizationEmploymentAssociation**
> void PostStaffEducationOrganizationEmploymentAssociation (EdFiStaffEducationOrganizationEmploymentAssociation staffEducationOrganizationEmploymentAssociation)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error. The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately. It is recommended to use POST for both create and update except while updating natural key of a resource in which case PUT operation must be used.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class PostStaffEducationOrganizationEmploymentAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationEmploymentAssociationsApi();
            var staffEducationOrganizationEmploymentAssociation = new EdFiStaffEducationOrganizationEmploymentAssociation(); // EdFiStaffEducationOrganizationEmploymentAssociation | The JSON representation of the \"staffEducationOrganizationEmploymentAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStaffEducationOrganizationEmploymentAssociation(staffEducationOrganizationEmploymentAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationEmploymentAssociationsApi.PostStaffEducationOrganizationEmploymentAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffEducationOrganizationEmploymentAssociation** | [**EdFiStaffEducationOrganizationEmploymentAssociation**](EdFiStaffEducationOrganizationEmploymentAssociation.md)| The JSON representation of the \&quot;staffEducationOrganizationEmploymentAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstaffeducationorganizationemploymentassociation"></a>
# **PutStaffEducationOrganizationEmploymentAssociation**
> void PutStaffEducationOrganizationEmploymentAssociation (string id, EdFiStaffEducationOrganizationEmploymentAssociation staffEducationOrganizationEmploymentAssociation, string ifMatch = null)

Updates a resource based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, this API resource is not configured for cascading natural key updates. Natural key values for this resource cannot be changed using PUT operation and will not be modified in the database, and so recommendation is to use POST as that supports upsert behavior.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class PutStaffEducationOrganizationEmploymentAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationEmploymentAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var staffEducationOrganizationEmploymentAssociation = new EdFiStaffEducationOrganizationEmploymentAssociation(); // EdFiStaffEducationOrganizationEmploymentAssociation | The JSON representation of the \"staffEducationOrganizationEmploymentAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutStaffEducationOrganizationEmploymentAssociation(id, staffEducationOrganizationEmploymentAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationEmploymentAssociationsApi.PutStaffEducationOrganizationEmploymentAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **staffEducationOrganizationEmploymentAssociation** | [**EdFiStaffEducationOrganizationEmploymentAssociation**](EdFiStaffEducationOrganizationEmploymentAssociation.md)| The JSON representation of the \&quot;staffEducationOrganizationEmploymentAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

