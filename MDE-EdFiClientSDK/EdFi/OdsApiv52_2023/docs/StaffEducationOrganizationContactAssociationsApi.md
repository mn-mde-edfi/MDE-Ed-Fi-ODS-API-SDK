# EdFi.OdsApi.Sdk.Apis.Identity.StaffEducationOrganizationContactAssociationsApi

All URIs are relative to *http://localhost:54746/data/v3/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStaffEducationOrganizationContactAssociationById**](StaffEducationOrganizationContactAssociationsApi.md#deletestaffeducationorganizationcontactassociationbyid) | **DELETE** /ed-fi/staffEducationOrganizationContactAssociations/{id} | Deletes an existing resource using the resource identifier.
[**DeletesStaffEducationOrganizationContactAssociations**](StaffEducationOrganizationContactAssociationsApi.md#deletesstaffeducationorganizationcontactassociations) | **GET** /ed-fi/staffEducationOrganizationContactAssociations/deletes | Retrieves deleted resources based on change version.
[**GetStaffEducationOrganizationContactAssociations**](StaffEducationOrganizationContactAssociationsApi.md#getstaffeducationorganizationcontactassociations) | **GET** /ed-fi/staffEducationOrganizationContactAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStaffEducationOrganizationContactAssociationsById**](StaffEducationOrganizationContactAssociationsApi.md#getstaffeducationorganizationcontactassociationsbyid) | **GET** /ed-fi/staffEducationOrganizationContactAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStaffEducationOrganizationContactAssociation**](StaffEducationOrganizationContactAssociationsApi.md#poststaffeducationorganizationcontactassociation) | **POST** /ed-fi/staffEducationOrganizationContactAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStaffEducationOrganizationContactAssociation**](StaffEducationOrganizationContactAssociationsApi.md#putstaffeducationorganizationcontactassociation) | **PUT** /ed-fi/staffEducationOrganizationContactAssociations/{id} | Updates a resource based on the resource identifier.


<a name="deletestaffeducationorganizationcontactassociationbyid"></a>
# **DeleteStaffEducationOrganizationContactAssociationById**
> void DeleteStaffEducationOrganizationContactAssociationById (string id, string ifMatch = null)

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
    public class DeleteStaffEducationOrganizationContactAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationContactAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStaffEducationOrganizationContactAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationContactAssociationsApi.DeleteStaffEducationOrganizationContactAssociationById: " + e.Message );
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

<a name="deletesstaffeducationorganizationcontactassociations"></a>
# **DeletesStaffEducationOrganizationContactAssociations**
> List<DeletedResource> DeletesStaffEducationOrganizationContactAssociations (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, string snapshotIdentifier = null)

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
    public class DeletesStaffEducationOrganizationContactAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationContactAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List&lt;DeletedResource&gt; result = apiInstance.DeletesStaffEducationOrganizationContactAssociations(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationContactAssociationsApi.DeletesStaffEducationOrganizationContactAssociations: " + e.Message );
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

<a name="getstaffeducationorganizationcontactassociations"></a>
# **GetStaffEducationOrganizationContactAssociations**
> List<EdFiStaffEducationOrganizationContactAssociation> GetStaffEducationOrganizationContactAssociations (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, bool? totalCount = null, string contactTitle = null, int? educationOrganizationId = null, string staffUniqueId = null, string contactTypeDescriptor = null, string electronicMailAddress = null, string id = null, string snapshotIdentifier = null)

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
    public class GetStaffEducationOrganizationContactAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationContactAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var contactTitle = contactTitle_example;  // string | The title of the contact in the context of the EducationOrganization. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var staffUniqueId = staffUniqueId_example;  // string | A unique alphanumeric code assigned to a staff. (optional) 
            var contactTypeDescriptor = contactTypeDescriptor_example;  // string | Indicates the type for the contact information. (optional) 
            var electronicMailAddress = electronicMailAddress_example;  // string | The email for the contact associated with the EducationOrganization. (optional) 
            var id = id_example;  // string |  (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStaffEducationOrganizationContactAssociation&gt; result = apiInstance.GetStaffEducationOrganizationContactAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, contactTitle, educationOrganizationId, staffUniqueId, contactTypeDescriptor, electronicMailAddress, id, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationContactAssociationsApi.GetStaffEducationOrganizationContactAssociations: " + e.Message );
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
 **contactTitle** | **string**| The title of the contact in the context of the EducationOrganization. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **staffUniqueId** | **string**| A unique alphanumeric code assigned to a staff. | [optional] 
 **contactTypeDescriptor** | **string**| Indicates the type for the contact information. | [optional] 
 **electronicMailAddress** | **string**| The email for the contact associated with the EducationOrganization. | [optional] 
 **id** | **string**|  | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<EdFiStaffEducationOrganizationContactAssociation>**](EdFiStaffEducationOrganizationContactAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstaffeducationorganizationcontactassociationsbyid"></a>
# **GetStaffEducationOrganizationContactAssociationsById**
> EdFiStaffEducationOrganizationContactAssociation GetStaffEducationOrganizationContactAssociationsById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

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
    public class GetStaffEducationOrganizationContactAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationContactAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStaffEducationOrganizationContactAssociation result = apiInstance.GetStaffEducationOrganizationContactAssociationsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationContactAssociationsApi.GetStaffEducationOrganizationContactAssociationsById: " + e.Message );
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

[**EdFiStaffEducationOrganizationContactAssociation**](EdFiStaffEducationOrganizationContactAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststaffeducationorganizationcontactassociation"></a>
# **PostStaffEducationOrganizationContactAssociation**
> void PostStaffEducationOrganizationContactAssociation (EdFiStaffEducationOrganizationContactAssociation staffEducationOrganizationContactAssociation)

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
    public class PostStaffEducationOrganizationContactAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationContactAssociationsApi();
            var staffEducationOrganizationContactAssociation = new EdFiStaffEducationOrganizationContactAssociation(); // EdFiStaffEducationOrganizationContactAssociation | The JSON representation of the \"staffEducationOrganizationContactAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStaffEducationOrganizationContactAssociation(staffEducationOrganizationContactAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationContactAssociationsApi.PostStaffEducationOrganizationContactAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffEducationOrganizationContactAssociation** | [**EdFiStaffEducationOrganizationContactAssociation**](EdFiStaffEducationOrganizationContactAssociation.md)| The JSON representation of the \&quot;staffEducationOrganizationContactAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstaffeducationorganizationcontactassociation"></a>
# **PutStaffEducationOrganizationContactAssociation**
> void PutStaffEducationOrganizationContactAssociation (string id, EdFiStaffEducationOrganizationContactAssociation staffEducationOrganizationContactAssociation, string ifMatch = null)

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
    public class PutStaffEducationOrganizationContactAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationContactAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var staffEducationOrganizationContactAssociation = new EdFiStaffEducationOrganizationContactAssociation(); // EdFiStaffEducationOrganizationContactAssociation | The JSON representation of the \"staffEducationOrganizationContactAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutStaffEducationOrganizationContactAssociation(id, staffEducationOrganizationContactAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationContactAssociationsApi.PutStaffEducationOrganizationContactAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **staffEducationOrganizationContactAssociation** | [**EdFiStaffEducationOrganizationContactAssociation**](EdFiStaffEducationOrganizationContactAssociation.md)| The JSON representation of the \&quot;staffEducationOrganizationContactAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

