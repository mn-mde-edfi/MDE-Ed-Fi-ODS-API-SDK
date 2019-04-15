# EdFi.OdsApi.Sdk.Apis.All.StaffEducationOrganizationAssignmentAssociationsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStaffEducationOrganizationAssignmentAssociationById**](StaffEducationOrganizationAssignmentAssociationsApi.md#deletestaffeducationorganizationassignmentassociationbyid) | **DELETE** /ed-fi/staffEducationOrganizationAssignmentAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStaffEducationOrganizationAssignmentAssociations**](StaffEducationOrganizationAssignmentAssociationsApi.md#getstaffeducationorganizationassignmentassociations) | **GET** /ed-fi/staffEducationOrganizationAssignmentAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStaffEducationOrganizationAssignmentAssociationsById**](StaffEducationOrganizationAssignmentAssociationsApi.md#getstaffeducationorganizationassignmentassociationsbyid) | **GET** /ed-fi/staffEducationOrganizationAssignmentAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStaffEducationOrganizationAssignmentAssociation**](StaffEducationOrganizationAssignmentAssociationsApi.md#poststaffeducationorganizationassignmentassociation) | **POST** /ed-fi/staffEducationOrganizationAssignmentAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStaffEducationOrganizationAssignmentAssociation**](StaffEducationOrganizationAssignmentAssociationsApi.md#putstaffeducationorganizationassignmentassociation) | **PUT** /ed-fi/staffEducationOrganizationAssignmentAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestaffeducationorganizationassignmentassociationbyid"></a>
# **DeleteStaffEducationOrganizationAssignmentAssociationById**
> void DeleteStaffEducationOrganizationAssignmentAssociationById (string id, string ifMatch = null)

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
    public class DeleteStaffEducationOrganizationAssignmentAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationAssignmentAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStaffEducationOrganizationAssignmentAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.DeleteStaffEducationOrganizationAssignmentAssociationById: " + e.Message );
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

<a name="getstaffeducationorganizationassignmentassociations"></a>
# **GetStaffEducationOrganizationAssignmentAssociations**
> List<EdFiStaffEducationOrganizationAssignmentAssociation> GetStaffEducationOrganizationAssignmentAssociations (int? offset = null, int? limit = null, bool? totalCount = null, string staffClassificationDescriptor = null, DateTime? beginDate = null, int? educationOrganizationId = null, string staffUniqueId = null, string credentialIdentifier = null, string stateOfIssueStateAbbreviationDescriptor = null, int? employmentEducationOrganizationId = null, string employmentStatusDescriptor = null, DateTime? employmentHireDate = null, DateTime? endDate = null, string id = null, int? orderOfAssignment = null, string positionTitle = null)

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
    public class GetStaffEducationOrganizationAssignmentAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationAssignmentAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var staffClassificationDescriptor = staffClassificationDescriptor_example;  // string | The titles of employment, official status, or rank of education staff. (optional) 
            var beginDate = 2013-10-20;  // DateTime? | Month, day, and year of the start or effective date of a staff member's employment, contract, or relationship with the LEA. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var staffUniqueId = staffUniqueId_example;  // string | A unique alphanumeric code assigned to a staff. (optional) 
            var credentialIdentifier = credentialIdentifier_example;  // string | Identifier or serial number assigned to the credential. (optional) 
            var stateOfIssueStateAbbreviationDescriptor = stateOfIssueStateAbbreviationDescriptor_example;  // string | The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a license/credential was issued. (optional) 
            var employmentEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var employmentStatusDescriptor = employmentStatusDescriptor_example;  // string | Reflects the type of employment or contract; for example:          Probationary          Contractual          Substitute/temporary          Tenured or permanent          Volunteer/no contract          ... (optional) 
            var employmentHireDate = 2013-10-20;  // DateTime? | The month, day, and year on which an individual was hired for a position. (optional) 
            var endDate = 2013-10-20;  // DateTime? | Month, day, and year of the end or termination date of a staff member's employment, contract, or relationship with the LEA. (optional) 
            var id = id_example;  // string |  (optional) 
            var orderOfAssignment = 56;  // int? | Describes whether the assignment is this the staff member's primary assignment, secondary assignment, etc. (optional) 
            var positionTitle = positionTitle_example;  // string | The descriptive name of an individual's position. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStaffEducationOrganizationAssignmentAssociation&gt; result = apiInstance.GetStaffEducationOrganizationAssignmentAssociations(offset, limit, totalCount, staffClassificationDescriptor, beginDate, educationOrganizationId, staffUniqueId, credentialIdentifier, stateOfIssueStateAbbreviationDescriptor, employmentEducationOrganizationId, employmentStatusDescriptor, employmentHireDate, endDate, id, orderOfAssignment, positionTitle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.GetStaffEducationOrganizationAssignmentAssociations: " + e.Message );
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
 **staffClassificationDescriptor** | **string**| The titles of employment, official status, or rank of education staff. | [optional] 
 **beginDate** | **DateTime?**| Month, day, and year of the start or effective date of a staff member&#39;s employment, contract, or relationship with the LEA. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **staffUniqueId** | **string**| A unique alphanumeric code assigned to a staff. | [optional] 
 **credentialIdentifier** | **string**| Identifier or serial number assigned to the credential. | [optional] 
 **stateOfIssueStateAbbreviationDescriptor** | **string**| The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a license/credential was issued. | [optional] 
 **employmentEducationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **employmentStatusDescriptor** | **string**| Reflects the type of employment or contract; for example:          Probationary          Contractual          Substitute/temporary          Tenured or permanent          Volunteer/no contract          ... | [optional] 
 **employmentHireDate** | **DateTime?**| The month, day, and year on which an individual was hired for a position. | [optional] 
 **endDate** | **DateTime?**| Month, day, and year of the end or termination date of a staff member&#39;s employment, contract, or relationship with the LEA. | [optional] 
 **id** | **string**|  | [optional] 
 **orderOfAssignment** | **int?**| Describes whether the assignment is this the staff member&#39;s primary assignment, secondary assignment, etc. | [optional] 
 **positionTitle** | **string**| The descriptive name of an individual&#39;s position. | [optional] 

### Return type

[**List<EdFiStaffEducationOrganizationAssignmentAssociation>**](EdFiStaffEducationOrganizationAssignmentAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstaffeducationorganizationassignmentassociationsbyid"></a>
# **GetStaffEducationOrganizationAssignmentAssociationsById**
> EdFiStaffEducationOrganizationAssignmentAssociation GetStaffEducationOrganizationAssignmentAssociationsById (string id, string ifNoneMatch = null)

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
    public class GetStaffEducationOrganizationAssignmentAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationAssignmentAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStaffEducationOrganizationAssignmentAssociation result = apiInstance.GetStaffEducationOrganizationAssignmentAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.GetStaffEducationOrganizationAssignmentAssociationsById: " + e.Message );
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

[**EdFiStaffEducationOrganizationAssignmentAssociation**](EdFiStaffEducationOrganizationAssignmentAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststaffeducationorganizationassignmentassociation"></a>
# **PostStaffEducationOrganizationAssignmentAssociation**
> void PostStaffEducationOrganizationAssignmentAssociation (EdFiStaffEducationOrganizationAssignmentAssociation staffEducationOrganizationAssignmentAssociation)

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
    public class PostStaffEducationOrganizationAssignmentAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationAssignmentAssociationsApi();
            var staffEducationOrganizationAssignmentAssociation = new EdFiStaffEducationOrganizationAssignmentAssociation(); // EdFiStaffEducationOrganizationAssignmentAssociation | The JSON representation of the \"staffEducationOrganizationAssignmentAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStaffEducationOrganizationAssignmentAssociation(staffEducationOrganizationAssignmentAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.PostStaffEducationOrganizationAssignmentAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffEducationOrganizationAssignmentAssociation** | [**EdFiStaffEducationOrganizationAssignmentAssociation**](EdFiStaffEducationOrganizationAssignmentAssociation.md)| The JSON representation of the \&quot;staffEducationOrganizationAssignmentAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstaffeducationorganizationassignmentassociation"></a>
# **PutStaffEducationOrganizationAssignmentAssociation**
> void PutStaffEducationOrganizationAssignmentAssociation (string id, EdFiStaffEducationOrganizationAssignmentAssociation staffEducationOrganizationAssignmentAssociation, string ifMatch = null)

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
    public class PutStaffEducationOrganizationAssignmentAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffEducationOrganizationAssignmentAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var staffEducationOrganizationAssignmentAssociation = new EdFiStaffEducationOrganizationAssignmentAssociation(); // EdFiStaffEducationOrganizationAssignmentAssociation | The JSON representation of the \"staffEducationOrganizationAssignmentAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStaffEducationOrganizationAssignmentAssociation(id, staffEducationOrganizationAssignmentAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffEducationOrganizationAssignmentAssociationsApi.PutStaffEducationOrganizationAssignmentAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **staffEducationOrganizationAssignmentAssociation** | [**EdFiStaffEducationOrganizationAssignmentAssociation**](EdFiStaffEducationOrganizationAssignmentAssociation.md)| The JSON representation of the \&quot;staffEducationOrganizationAssignmentAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

