# EdFi.OdsApi.Sdk.Apis.Identity.StudentDisciplineIncidentNonOffenderAssociationsApi

All URIs are relative to *http://localhost:54746/data/v3/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentDisciplineIncidentNonOffenderAssociationById**](StudentDisciplineIncidentNonOffenderAssociationsApi.md#deletestudentdisciplineincidentnonoffenderassociationbyid) | **DELETE** /ed-fi/studentDisciplineIncidentNonOffenderAssociations/{id} | Deletes an existing resource using the resource identifier.
[**DeletesStudentDisciplineIncidentNonOffenderAssociations**](StudentDisciplineIncidentNonOffenderAssociationsApi.md#deletesstudentdisciplineincidentnonoffenderassociations) | **GET** /ed-fi/studentDisciplineIncidentNonOffenderAssociations/deletes | Retrieves deleted resources based on change version.
[**GetStudentDisciplineIncidentNonOffenderAssociations**](StudentDisciplineIncidentNonOffenderAssociationsApi.md#getstudentdisciplineincidentnonoffenderassociations) | **GET** /ed-fi/studentDisciplineIncidentNonOffenderAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentDisciplineIncidentNonOffenderAssociationsById**](StudentDisciplineIncidentNonOffenderAssociationsApi.md#getstudentdisciplineincidentnonoffenderassociationsbyid) | **GET** /ed-fi/studentDisciplineIncidentNonOffenderAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudentDisciplineIncidentNonOffenderAssociation**](StudentDisciplineIncidentNonOffenderAssociationsApi.md#poststudentdisciplineincidentnonoffenderassociation) | **POST** /ed-fi/studentDisciplineIncidentNonOffenderAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudentDisciplineIncidentNonOffenderAssociation**](StudentDisciplineIncidentNonOffenderAssociationsApi.md#putstudentdisciplineincidentnonoffenderassociation) | **PUT** /ed-fi/studentDisciplineIncidentNonOffenderAssociations/{id} | Updates a resource based on the resource identifier.


<a name="deletestudentdisciplineincidentnonoffenderassociationbyid"></a>
# **DeleteStudentDisciplineIncidentNonOffenderAssociationById**
> void DeleteStudentDisciplineIncidentNonOffenderAssociationById (string id, string ifMatch = null)

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
    public class DeleteStudentDisciplineIncidentNonOffenderAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentDisciplineIncidentNonOffenderAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentDisciplineIncidentNonOffenderAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentDisciplineIncidentNonOffenderAssociationsApi.DeleteStudentDisciplineIncidentNonOffenderAssociationById: " + e.Message );
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

<a name="deletesstudentdisciplineincidentnonoffenderassociations"></a>
# **DeletesStudentDisciplineIncidentNonOffenderAssociations**
> List<DeletedResource> DeletesStudentDisciplineIncidentNonOffenderAssociations (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, string snapshotIdentifier = null)

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
    public class DeletesStudentDisciplineIncidentNonOffenderAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentDisciplineIncidentNonOffenderAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List&lt;DeletedResource&gt; result = apiInstance.DeletesStudentDisciplineIncidentNonOffenderAssociations(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentDisciplineIncidentNonOffenderAssociationsApi.DeletesStudentDisciplineIncidentNonOffenderAssociations: " + e.Message );
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

<a name="getstudentdisciplineincidentnonoffenderassociations"></a>
# **GetStudentDisciplineIncidentNonOffenderAssociations**
> List<EdFiStudentDisciplineIncidentNonOffenderAssociation> GetStudentDisciplineIncidentNonOffenderAssociations (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, bool? totalCount = null, string incidentIdentifier = null, int? schoolId = null, string studentUniqueId = null, string id = null, string snapshotIdentifier = null)

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
    public class GetStudentDisciplineIncidentNonOffenderAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentDisciplineIncidentNonOffenderAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var incidentIdentifier = incidentIdentifier_example;  // string | A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders. (optional) 
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var id = id_example;  // string |  (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentDisciplineIncidentNonOffenderAssociation&gt; result = apiInstance.GetStudentDisciplineIncidentNonOffenderAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, incidentIdentifier, schoolId, studentUniqueId, id, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentDisciplineIncidentNonOffenderAssociationsApi.GetStudentDisciplineIncidentNonOffenderAssociations: " + e.Message );
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
 **incidentIdentifier** | **string**| A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders. | [optional] 
 **schoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **id** | **string**|  | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<EdFiStudentDisciplineIncidentNonOffenderAssociation>**](EdFiStudentDisciplineIncidentNonOffenderAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentdisciplineincidentnonoffenderassociationsbyid"></a>
# **GetStudentDisciplineIncidentNonOffenderAssociationsById**
> EdFiStudentDisciplineIncidentNonOffenderAssociation GetStudentDisciplineIncidentNonOffenderAssociationsById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

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
    public class GetStudentDisciplineIncidentNonOffenderAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentDisciplineIncidentNonOffenderAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentDisciplineIncidentNonOffenderAssociation result = apiInstance.GetStudentDisciplineIncidentNonOffenderAssociationsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentDisciplineIncidentNonOffenderAssociationsApi.GetStudentDisciplineIncidentNonOffenderAssociationsById: " + e.Message );
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

[**EdFiStudentDisciplineIncidentNonOffenderAssociation**](EdFiStudentDisciplineIncidentNonOffenderAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentdisciplineincidentnonoffenderassociation"></a>
# **PostStudentDisciplineIncidentNonOffenderAssociation**
> void PostStudentDisciplineIncidentNonOffenderAssociation (EdFiStudentDisciplineIncidentNonOffenderAssociation studentDisciplineIncidentNonOffenderAssociation)

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
    public class PostStudentDisciplineIncidentNonOffenderAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentDisciplineIncidentNonOffenderAssociationsApi();
            var studentDisciplineIncidentNonOffenderAssociation = new EdFiStudentDisciplineIncidentNonOffenderAssociation(); // EdFiStudentDisciplineIncidentNonOffenderAssociation | The JSON representation of the \"studentDisciplineIncidentNonOffenderAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentDisciplineIncidentNonOffenderAssociation(studentDisciplineIncidentNonOffenderAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentDisciplineIncidentNonOffenderAssociationsApi.PostStudentDisciplineIncidentNonOffenderAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentDisciplineIncidentNonOffenderAssociation** | [**EdFiStudentDisciplineIncidentNonOffenderAssociation**](EdFiStudentDisciplineIncidentNonOffenderAssociation.md)| The JSON representation of the \&quot;studentDisciplineIncidentNonOffenderAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentdisciplineincidentnonoffenderassociation"></a>
# **PutStudentDisciplineIncidentNonOffenderAssociation**
> void PutStudentDisciplineIncidentNonOffenderAssociation (string id, EdFiStudentDisciplineIncidentNonOffenderAssociation studentDisciplineIncidentNonOffenderAssociation, string ifMatch = null)

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
    public class PutStudentDisciplineIncidentNonOffenderAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentDisciplineIncidentNonOffenderAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentDisciplineIncidentNonOffenderAssociation = new EdFiStudentDisciplineIncidentNonOffenderAssociation(); // EdFiStudentDisciplineIncidentNonOffenderAssociation | The JSON representation of the \"studentDisciplineIncidentNonOffenderAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutStudentDisciplineIncidentNonOffenderAssociation(id, studentDisciplineIncidentNonOffenderAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentDisciplineIncidentNonOffenderAssociationsApi.PutStudentDisciplineIncidentNonOffenderAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentDisciplineIncidentNonOffenderAssociation** | [**EdFiStudentDisciplineIncidentNonOffenderAssociation**](EdFiStudentDisciplineIncidentNonOffenderAssociation.md)| The JSON representation of the \&quot;studentDisciplineIncidentNonOffenderAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

