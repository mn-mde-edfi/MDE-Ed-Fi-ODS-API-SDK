# EdFi.OdsApi.Sdk.Apis.All.StudentDisciplineIncidentAssociationsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentDisciplineIncidentAssociationById**](StudentDisciplineIncidentAssociationsApi.md#deletestudentdisciplineincidentassociationbyid) | **DELETE** /ed-fi/studentDisciplineIncidentAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentDisciplineIncidentAssociations**](StudentDisciplineIncidentAssociationsApi.md#getstudentdisciplineincidentassociations) | **GET** /ed-fi/studentDisciplineIncidentAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentDisciplineIncidentAssociationsById**](StudentDisciplineIncidentAssociationsApi.md#getstudentdisciplineincidentassociationsbyid) | **GET** /ed-fi/studentDisciplineIncidentAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudentDisciplineIncidentAssociation**](StudentDisciplineIncidentAssociationsApi.md#poststudentdisciplineincidentassociation) | **POST** /ed-fi/studentDisciplineIncidentAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudentDisciplineIncidentAssociation**](StudentDisciplineIncidentAssociationsApi.md#putstudentdisciplineincidentassociation) | **PUT** /ed-fi/studentDisciplineIncidentAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudentdisciplineincidentassociationbyid"></a>
# **DeleteStudentDisciplineIncidentAssociationById**
> void DeleteStudentDisciplineIncidentAssociationById (string id, string ifMatch = null)

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
    public class DeleteStudentDisciplineIncidentAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentDisciplineIncidentAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentDisciplineIncidentAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentDisciplineIncidentAssociationsApi.DeleteStudentDisciplineIncidentAssociationById: " + e.Message );
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

<a name="getstudentdisciplineincidentassociations"></a>
# **GetStudentDisciplineIncidentAssociations**
> List<EdFiStudentDisciplineIncidentAssociation> GetStudentDisciplineIncidentAssociations (int? offset = null, int? limit = null, bool? totalCount = null, string incidentIdentifier = null, int? schoolId = null, string studentUniqueId = null, string studentParticipationCodeDescriptor = null, string id = null)

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
    public class GetStudentDisciplineIncidentAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentDisciplineIncidentAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var incidentIdentifier = incidentIdentifier_example;  // string | A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders. (optional) 
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var studentParticipationCodeDescriptor = studentParticipationCodeDescriptor_example;  // string | The role or type of participation of a student in a discipline incident;           for example:          Victim          Perpetrator          Witness          Reporter. (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentDisciplineIncidentAssociation&gt; result = apiInstance.GetStudentDisciplineIncidentAssociations(offset, limit, totalCount, incidentIdentifier, schoolId, studentUniqueId, studentParticipationCodeDescriptor, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentDisciplineIncidentAssociationsApi.GetStudentDisciplineIncidentAssociations: " + e.Message );
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
 **incidentIdentifier** | **string**| A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders. | [optional] 
 **schoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **studentParticipationCodeDescriptor** | **string**| The role or type of participation of a student in a discipline incident;           for example:          Victim          Perpetrator          Witness          Reporter. | [optional] 
 **id** | **string**|  | [optional] 

### Return type

[**List<EdFiStudentDisciplineIncidentAssociation>**](EdFiStudentDisciplineIncidentAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentdisciplineincidentassociationsbyid"></a>
# **GetStudentDisciplineIncidentAssociationsById**
> EdFiStudentDisciplineIncidentAssociation GetStudentDisciplineIncidentAssociationsById (string id, string ifNoneMatch = null)

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
    public class GetStudentDisciplineIncidentAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentDisciplineIncidentAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentDisciplineIncidentAssociation result = apiInstance.GetStudentDisciplineIncidentAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentDisciplineIncidentAssociationsApi.GetStudentDisciplineIncidentAssociationsById: " + e.Message );
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

[**EdFiStudentDisciplineIncidentAssociation**](EdFiStudentDisciplineIncidentAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentdisciplineincidentassociation"></a>
# **PostStudentDisciplineIncidentAssociation**
> void PostStudentDisciplineIncidentAssociation (EdFiStudentDisciplineIncidentAssociation studentDisciplineIncidentAssociation)

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
    public class PostStudentDisciplineIncidentAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentDisciplineIncidentAssociationsApi();
            var studentDisciplineIncidentAssociation = new EdFiStudentDisciplineIncidentAssociation(); // EdFiStudentDisciplineIncidentAssociation | The JSON representation of the \"studentDisciplineIncidentAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentDisciplineIncidentAssociation(studentDisciplineIncidentAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentDisciplineIncidentAssociationsApi.PostStudentDisciplineIncidentAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentDisciplineIncidentAssociation** | [**EdFiStudentDisciplineIncidentAssociation**](EdFiStudentDisciplineIncidentAssociation.md)| The JSON representation of the \&quot;studentDisciplineIncidentAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentdisciplineincidentassociation"></a>
# **PutStudentDisciplineIncidentAssociation**
> void PutStudentDisciplineIncidentAssociation (string id, EdFiStudentDisciplineIncidentAssociation studentDisciplineIncidentAssociation, string ifMatch = null)

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
    public class PutStudentDisciplineIncidentAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentDisciplineIncidentAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentDisciplineIncidentAssociation = new EdFiStudentDisciplineIncidentAssociation(); // EdFiStudentDisciplineIncidentAssociation | The JSON representation of the \"studentDisciplineIncidentAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStudentDisciplineIncidentAssociation(id, studentDisciplineIncidentAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentDisciplineIncidentAssociationsApi.PutStudentDisciplineIncidentAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentDisciplineIncidentAssociation** | [**EdFiStudentDisciplineIncidentAssociation**](EdFiStudentDisciplineIncidentAssociation.md)| The JSON representation of the \&quot;studentDisciplineIncidentAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

