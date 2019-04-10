# EdFi.OdsApi.Sdk.Apis.All.EducationOrganizationInterventionPrescriptionAssociationsApi

All URIs are relative to *https://localhost:56641/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteEducationOrganizationInterventionPrescriptionAssociationById**](EducationOrganizationInterventionPrescriptionAssociationsApi.md#deleteeducationorganizationinterventionprescriptionassociationbyid) | **DELETE** /ed-fi/educationOrganizationInterventionPrescriptionAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetEducationOrganizationInterventionPrescriptionAssociations**](EducationOrganizationInterventionPrescriptionAssociationsApi.md#geteducationorganizationinterventionprescriptionassociations) | **GET** /ed-fi/educationOrganizationInterventionPrescriptionAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetEducationOrganizationInterventionPrescriptionAssociationsById**](EducationOrganizationInterventionPrescriptionAssociationsApi.md#geteducationorganizationinterventionprescriptionassociationsbyid) | **GET** /ed-fi/educationOrganizationInterventionPrescriptionAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostEducationOrganizationInterventionPrescriptionAssociation**](EducationOrganizationInterventionPrescriptionAssociationsApi.md#posteducationorganizationinterventionprescriptionassociation) | **POST** /ed-fi/educationOrganizationInterventionPrescriptionAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutEducationOrganizationInterventionPrescriptionAssociation**](EducationOrganizationInterventionPrescriptionAssociationsApi.md#puteducationorganizationinterventionprescriptionassociation) | **PUT** /ed-fi/educationOrganizationInterventionPrescriptionAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteeducationorganizationinterventionprescriptionassociationbyid"></a>
# **DeleteEducationOrganizationInterventionPrescriptionAssociationById**
> void DeleteEducationOrganizationInterventionPrescriptionAssociationById (string id, string ifMatch = null)

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
    public class DeleteEducationOrganizationInterventionPrescriptionAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationOrganizationInterventionPrescriptionAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteEducationOrganizationInterventionPrescriptionAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationOrganizationInterventionPrescriptionAssociationsApi.DeleteEducationOrganizationInterventionPrescriptionAssociationById: " + e.Message );
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

<a name="geteducationorganizationinterventionprescriptionassociations"></a>
# **GetEducationOrganizationInterventionPrescriptionAssociations**
> List<EdFiEducationOrganizationInterventionPrescriptionAssociation> GetEducationOrganizationInterventionPrescriptionAssociations (int? offset = null, int? limit = null, bool? totalCount = null, int? educationOrganizationId = null, int? interventionPrescriptionEducationOrganizationId = null, string interventionPrescriptionIdentificationCode = null, DateTime? beginDate = null, DateTime? endDate = null, string id = null)

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
    public class GetEducationOrganizationInterventionPrescriptionAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationOrganizationInterventionPrescriptionAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var interventionPrescriptionEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var interventionPrescriptionIdentificationCode = interventionPrescriptionIdentificationCode_example;  // string | A unique number or alphanumeric code assigned to an intervention prescription. (optional) 
            var beginDate = 2013-10-20;  // DateTime? | The begin date of the period during which the InterventionPrescription is available. (optional) 
            var endDate = 2013-10-20;  // DateTime? | The end date of the period during which the InterventionPrescription is available. (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiEducationOrganizationInterventionPrescriptionAssociation&gt; result = apiInstance.GetEducationOrganizationInterventionPrescriptionAssociations(offset, limit, totalCount, educationOrganizationId, interventionPrescriptionEducationOrganizationId, interventionPrescriptionIdentificationCode, beginDate, endDate, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationOrganizationInterventionPrescriptionAssociationsApi.GetEducationOrganizationInterventionPrescriptionAssociations: " + e.Message );
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
 **interventionPrescriptionEducationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **interventionPrescriptionIdentificationCode** | **string**| A unique number or alphanumeric code assigned to an intervention prescription. | [optional] 
 **beginDate** | **DateTime?**| The begin date of the period during which the InterventionPrescription is available. | [optional] 
 **endDate** | **DateTime?**| The end date of the period during which the InterventionPrescription is available. | [optional] 
 **id** | **string**|  | [optional] 

### Return type

[**List<EdFiEducationOrganizationInterventionPrescriptionAssociation>**](EdFiEducationOrganizationInterventionPrescriptionAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteducationorganizationinterventionprescriptionassociationsbyid"></a>
# **GetEducationOrganizationInterventionPrescriptionAssociationsById**
> EdFiEducationOrganizationInterventionPrescriptionAssociation GetEducationOrganizationInterventionPrescriptionAssociationsById (string id, string ifNoneMatch = null)

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
    public class GetEducationOrganizationInterventionPrescriptionAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationOrganizationInterventionPrescriptionAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiEducationOrganizationInterventionPrescriptionAssociation result = apiInstance.GetEducationOrganizationInterventionPrescriptionAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationOrganizationInterventionPrescriptionAssociationsApi.GetEducationOrganizationInterventionPrescriptionAssociationsById: " + e.Message );
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

[**EdFiEducationOrganizationInterventionPrescriptionAssociation**](EdFiEducationOrganizationInterventionPrescriptionAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posteducationorganizationinterventionprescriptionassociation"></a>
# **PostEducationOrganizationInterventionPrescriptionAssociation**
> void PostEducationOrganizationInterventionPrescriptionAssociation (EdFiEducationOrganizationInterventionPrescriptionAssociation educationOrganizationInterventionPrescriptionAssociation)

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
    public class PostEducationOrganizationInterventionPrescriptionAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationOrganizationInterventionPrescriptionAssociationsApi();
            var educationOrganizationInterventionPrescriptionAssociation = new EdFiEducationOrganizationInterventionPrescriptionAssociation(); // EdFiEducationOrganizationInterventionPrescriptionAssociation | The JSON representation of the \"educationOrganizationInterventionPrescriptionAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostEducationOrganizationInterventionPrescriptionAssociation(educationOrganizationInterventionPrescriptionAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationOrganizationInterventionPrescriptionAssociationsApi.PostEducationOrganizationInterventionPrescriptionAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **educationOrganizationInterventionPrescriptionAssociation** | [**EdFiEducationOrganizationInterventionPrescriptionAssociation**](EdFiEducationOrganizationInterventionPrescriptionAssociation.md)| The JSON representation of the \&quot;educationOrganizationInterventionPrescriptionAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="puteducationorganizationinterventionprescriptionassociation"></a>
# **PutEducationOrganizationInterventionPrescriptionAssociation**
> void PutEducationOrganizationInterventionPrescriptionAssociation (string id, EdFiEducationOrganizationInterventionPrescriptionAssociation educationOrganizationInterventionPrescriptionAssociation, string ifMatch = null)

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
    public class PutEducationOrganizationInterventionPrescriptionAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationOrganizationInterventionPrescriptionAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var educationOrganizationInterventionPrescriptionAssociation = new EdFiEducationOrganizationInterventionPrescriptionAssociation(); // EdFiEducationOrganizationInterventionPrescriptionAssociation | The JSON representation of the \"educationOrganizationInterventionPrescriptionAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutEducationOrganizationInterventionPrescriptionAssociation(id, educationOrganizationInterventionPrescriptionAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationOrganizationInterventionPrescriptionAssociationsApi.PutEducationOrganizationInterventionPrescriptionAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **educationOrganizationInterventionPrescriptionAssociation** | [**EdFiEducationOrganizationInterventionPrescriptionAssociation**](EdFiEducationOrganizationInterventionPrescriptionAssociation.md)| The JSON representation of the \&quot;educationOrganizationInterventionPrescriptionAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

