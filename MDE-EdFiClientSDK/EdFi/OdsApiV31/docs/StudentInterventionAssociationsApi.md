# EdFi.OdsApi.Sdk.Apis.All.StudentInterventionAssociationsApi

All URIs are relative to *https://localhost:56641/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentInterventionAssociationById**](StudentInterventionAssociationsApi.md#deletestudentinterventionassociationbyid) | **DELETE** /ed-fi/studentInterventionAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentInterventionAssociations**](StudentInterventionAssociationsApi.md#getstudentinterventionassociations) | **GET** /ed-fi/studentInterventionAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentInterventionAssociationsById**](StudentInterventionAssociationsApi.md#getstudentinterventionassociationsbyid) | **GET** /ed-fi/studentInterventionAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudentInterventionAssociation**](StudentInterventionAssociationsApi.md#poststudentinterventionassociation) | **POST** /ed-fi/studentInterventionAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudentInterventionAssociation**](StudentInterventionAssociationsApi.md#putstudentinterventionassociation) | **PUT** /ed-fi/studentInterventionAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudentinterventionassociationbyid"></a>
# **DeleteStudentInterventionAssociationById**
> void DeleteStudentInterventionAssociationById (string id, string ifMatch = null)

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
    public class DeleteStudentInterventionAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentInterventionAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentInterventionAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentInterventionAssociationsApi.DeleteStudentInterventionAssociationById: " + e.Message );
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

<a name="getstudentinterventionassociations"></a>
# **GetStudentInterventionAssociations**
> List<EdFiStudentInterventionAssociation> GetStudentInterventionAssociations (int? offset = null, int? limit = null, bool? totalCount = null, int? educationOrganizationId = null, string interventionIdentificationCode = null, string studentUniqueId = null, string cohortIdentifier = null, int? cohortEducationOrganizationId = null, string diagnosticStatement = null, int? dosage = null, string id = null)

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
    public class GetStudentInterventionAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentInterventionAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var interventionIdentificationCode = interventionIdentificationCode_example;  // string | A unique number or alphanumeric code assigned to an intervention. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var cohortIdentifier = cohortIdentifier_example;  // string | The name or ID for the Cohort. (optional) 
            var cohortEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var diagnosticStatement = diagnosticStatement_example;  // string | A statement provided by the assigner that provides information regarding why the student was assigned to this intervention. (optional) 
            var dosage = 56;  // int? | The duration of time in minutes for which the student was assigned to participate in the intervention. (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentInterventionAssociation&gt; result = apiInstance.GetStudentInterventionAssociations(offset, limit, totalCount, educationOrganizationId, interventionIdentificationCode, studentUniqueId, cohortIdentifier, cohortEducationOrganizationId, diagnosticStatement, dosage, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentInterventionAssociationsApi.GetStudentInterventionAssociations: " + e.Message );
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
 **interventionIdentificationCode** | **string**| A unique number or alphanumeric code assigned to an intervention. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **cohortIdentifier** | **string**| The name or ID for the Cohort. | [optional] 
 **cohortEducationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **diagnosticStatement** | **string**| A statement provided by the assigner that provides information regarding why the student was assigned to this intervention. | [optional] 
 **dosage** | **int?**| The duration of time in minutes for which the student was assigned to participate in the intervention. | [optional] 
 **id** | **string**|  | [optional] 

### Return type

[**List<EdFiStudentInterventionAssociation>**](EdFiStudentInterventionAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentinterventionassociationsbyid"></a>
# **GetStudentInterventionAssociationsById**
> EdFiStudentInterventionAssociation GetStudentInterventionAssociationsById (string id, string ifNoneMatch = null)

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
    public class GetStudentInterventionAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentInterventionAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentInterventionAssociation result = apiInstance.GetStudentInterventionAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentInterventionAssociationsApi.GetStudentInterventionAssociationsById: " + e.Message );
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

[**EdFiStudentInterventionAssociation**](EdFiStudentInterventionAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentinterventionassociation"></a>
# **PostStudentInterventionAssociation**
> void PostStudentInterventionAssociation (EdFiStudentInterventionAssociation studentInterventionAssociation)

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
    public class PostStudentInterventionAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentInterventionAssociationsApi();
            var studentInterventionAssociation = new EdFiStudentInterventionAssociation(); // EdFiStudentInterventionAssociation | The JSON representation of the \"studentInterventionAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentInterventionAssociation(studentInterventionAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentInterventionAssociationsApi.PostStudentInterventionAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentInterventionAssociation** | [**EdFiStudentInterventionAssociation**](EdFiStudentInterventionAssociation.md)| The JSON representation of the \&quot;studentInterventionAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentinterventionassociation"></a>
# **PutStudentInterventionAssociation**
> void PutStudentInterventionAssociation (string id, EdFiStudentInterventionAssociation studentInterventionAssociation, string ifMatch = null)

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
    public class PutStudentInterventionAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentInterventionAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentInterventionAssociation = new EdFiStudentInterventionAssociation(); // EdFiStudentInterventionAssociation | The JSON representation of the \"studentInterventionAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStudentInterventionAssociation(id, studentInterventionAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentInterventionAssociationsApi.PutStudentInterventionAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentInterventionAssociation** | [**EdFiStudentInterventionAssociation**](EdFiStudentInterventionAssociation.md)| The JSON representation of the \&quot;studentInterventionAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

