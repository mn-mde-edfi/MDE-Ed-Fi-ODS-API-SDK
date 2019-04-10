# EdFi.OdsApi.Sdk.Apis.All.InterventionPrescriptionsApi

All URIs are relative to *https://localhost:56641/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteInterventionPrescriptionById**](InterventionPrescriptionsApi.md#deleteinterventionprescriptionbyid) | **DELETE** /ed-fi/interventionPrescriptions/{id} | Deletes an existing resource using the resource identifier.
[**GetInterventionPrescriptions**](InterventionPrescriptionsApi.md#getinterventionprescriptions) | **GET** /ed-fi/interventionPrescriptions | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetInterventionPrescriptionsById**](InterventionPrescriptionsApi.md#getinterventionprescriptionsbyid) | **GET** /ed-fi/interventionPrescriptions/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostInterventionPrescription**](InterventionPrescriptionsApi.md#postinterventionprescription) | **POST** /ed-fi/interventionPrescriptions | Creates or updates resources based on the natural key values of the supplied resource.
[**PutInterventionPrescription**](InterventionPrescriptionsApi.md#putinterventionprescription) | **PUT** /ed-fi/interventionPrescriptions/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteinterventionprescriptionbyid"></a>
# **DeleteInterventionPrescriptionById**
> void DeleteInterventionPrescriptionById (string id, string ifMatch = null)

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
    public class DeleteInterventionPrescriptionByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InterventionPrescriptionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteInterventionPrescriptionById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InterventionPrescriptionsApi.DeleteInterventionPrescriptionById: " + e.Message );
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

<a name="getinterventionprescriptions"></a>
# **GetInterventionPrescriptions**
> List<EdFiInterventionPrescription> GetInterventionPrescriptions (int? offset = null, int? limit = null, bool? totalCount = null, string interventionPrescriptionIdentificationCode = null, int? educationOrganizationId = null, string deliveryMethodDescriptor = null, string interventionClassDescriptor = null, string id = null, int? maxDosage = null, int? minDosage = null)

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
    public class GetInterventionPrescriptionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InterventionPrescriptionsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var interventionPrescriptionIdentificationCode = interventionPrescriptionIdentificationCode_example;  // string | A unique number or alphanumeric code assigned to an intervention prescription. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var deliveryMethodDescriptor = deliveryMethodDescriptor_example;  // string | The way in which an intervention was implemented: individual, small group, whole class, or whole school. (optional) 
            var interventionClassDescriptor = interventionClassDescriptor_example;  // string | The way in which an intervention is used: curriculum, supplement, or practice. (optional) 
            var id = id_example;  // string |  (optional) 
            var maxDosage = 56;  // int? | The maximum duration of time in minutes that is recommended for the intervention. (optional) 
            var minDosage = 56;  // int? | The minimum duration of time in minutes that is recommended for the intervention. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiInterventionPrescription&gt; result = apiInstance.GetInterventionPrescriptions(offset, limit, totalCount, interventionPrescriptionIdentificationCode, educationOrganizationId, deliveryMethodDescriptor, interventionClassDescriptor, id, maxDosage, minDosage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InterventionPrescriptionsApi.GetInterventionPrescriptions: " + e.Message );
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
 **interventionPrescriptionIdentificationCode** | **string**| A unique number or alphanumeric code assigned to an intervention prescription. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **deliveryMethodDescriptor** | **string**| The way in which an intervention was implemented: individual, small group, whole class, or whole school. | [optional] 
 **interventionClassDescriptor** | **string**| The way in which an intervention is used: curriculum, supplement, or practice. | [optional] 
 **id** | **string**|  | [optional] 
 **maxDosage** | **int?**| The maximum duration of time in minutes that is recommended for the intervention. | [optional] 
 **minDosage** | **int?**| The minimum duration of time in minutes that is recommended for the intervention. | [optional] 

### Return type

[**List<EdFiInterventionPrescription>**](EdFiInterventionPrescription.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinterventionprescriptionsbyid"></a>
# **GetInterventionPrescriptionsById**
> EdFiInterventionPrescription GetInterventionPrescriptionsById (string id, string ifNoneMatch = null)

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
    public class GetInterventionPrescriptionsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InterventionPrescriptionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiInterventionPrescription result = apiInstance.GetInterventionPrescriptionsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InterventionPrescriptionsApi.GetInterventionPrescriptionsById: " + e.Message );
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

[**EdFiInterventionPrescription**](EdFiInterventionPrescription.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postinterventionprescription"></a>
# **PostInterventionPrescription**
> void PostInterventionPrescription (EdFiInterventionPrescription interventionPrescription)

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
    public class PostInterventionPrescriptionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InterventionPrescriptionsApi();
            var interventionPrescription = new EdFiInterventionPrescription(); // EdFiInterventionPrescription | The JSON representation of the \"interventionPrescription\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostInterventionPrescription(interventionPrescription);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InterventionPrescriptionsApi.PostInterventionPrescription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interventionPrescription** | [**EdFiInterventionPrescription**](EdFiInterventionPrescription.md)| The JSON representation of the \&quot;interventionPrescription\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putinterventionprescription"></a>
# **PutInterventionPrescription**
> void PutInterventionPrescription (string id, EdFiInterventionPrescription interventionPrescription, string ifMatch = null)

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
    public class PutInterventionPrescriptionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InterventionPrescriptionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var interventionPrescription = new EdFiInterventionPrescription(); // EdFiInterventionPrescription | The JSON representation of the \"interventionPrescription\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutInterventionPrescription(id, interventionPrescription, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InterventionPrescriptionsApi.PutInterventionPrescription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **interventionPrescription** | [**EdFiInterventionPrescription**](EdFiInterventionPrescription.md)| The JSON representation of the \&quot;interventionPrescription\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

