# EdFi.OdsApi.Sdk.Apis.All.InterventionsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteInterventionById**](InterventionsApi.md#deleteinterventionbyid) | **DELETE** /ed-fi/interventions/{id} | Deletes an existing resource using the resource identifier.
[**GetInterventions**](InterventionsApi.md#getinterventions) | **GET** /ed-fi/interventions | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetInterventionsById**](InterventionsApi.md#getinterventionsbyid) | **GET** /ed-fi/interventions/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostIntervention**](InterventionsApi.md#postintervention) | **POST** /ed-fi/interventions | Creates or updates resources based on the natural key values of the supplied resource.
[**PutIntervention**](InterventionsApi.md#putintervention) | **PUT** /ed-fi/interventions/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteinterventionbyid"></a>
# **DeleteInterventionById**
> void DeleteInterventionById (string id, string ifMatch = null)

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
    public class DeleteInterventionByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InterventionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteInterventionById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InterventionsApi.DeleteInterventionById: " + e.Message );
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

<a name="getinterventions"></a>
# **GetInterventions**
> List<EdFiIntervention> GetInterventions (int? offset = null, int? limit = null, bool? totalCount = null, string interventionIdentificationCode = null, int? educationOrganizationId = null, string deliveryMethodDescriptor = null, string interventionClassDescriptor = null, DateTime? beginDate = null, DateTime? endDate = null, string id = null, int? maxDosage = null, int? minDosage = null)

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
    public class GetInterventionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InterventionsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var interventionIdentificationCode = interventionIdentificationCode_example;  // string | A unique number or alphanumeric code assigned to an intervention. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var deliveryMethodDescriptor = deliveryMethodDescriptor_example;  // string | The way in which an intervention was implemented: individual, small group, whole class, or whole school. (optional) 
            var interventionClassDescriptor = interventionClassDescriptor_example;  // string | The way in which an intervention is used: curriculum, supplement, or practice. (optional) 
            var beginDate = 2013-10-20;  // DateTime? | The start date for the intervention implementation. (optional) 
            var endDate = 2013-10-20;  // DateTime? | The end date for the intervention implementation. (optional) 
            var id = id_example;  // string |  (optional) 
            var maxDosage = 56;  // int? | The maximum duration of time in minutes that may be assigned for the intervention. (optional) 
            var minDosage = 56;  // int? | The minimum duration of time in minutes that may be assigned for the intervention. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiIntervention&gt; result = apiInstance.GetInterventions(offset, limit, totalCount, interventionIdentificationCode, educationOrganizationId, deliveryMethodDescriptor, interventionClassDescriptor, beginDate, endDate, id, maxDosage, minDosage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InterventionsApi.GetInterventions: " + e.Message );
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
 **interventionIdentificationCode** | **string**| A unique number or alphanumeric code assigned to an intervention. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **deliveryMethodDescriptor** | **string**| The way in which an intervention was implemented: individual, small group, whole class, or whole school. | [optional] 
 **interventionClassDescriptor** | **string**| The way in which an intervention is used: curriculum, supplement, or practice. | [optional] 
 **beginDate** | **DateTime?**| The start date for the intervention implementation. | [optional] 
 **endDate** | **DateTime?**| The end date for the intervention implementation. | [optional] 
 **id** | **string**|  | [optional] 
 **maxDosage** | **int?**| The maximum duration of time in minutes that may be assigned for the intervention. | [optional] 
 **minDosage** | **int?**| The minimum duration of time in minutes that may be assigned for the intervention. | [optional] 

### Return type

[**List<EdFiIntervention>**](EdFiIntervention.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinterventionsbyid"></a>
# **GetInterventionsById**
> EdFiIntervention GetInterventionsById (string id, string ifNoneMatch = null)

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
    public class GetInterventionsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InterventionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiIntervention result = apiInstance.GetInterventionsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InterventionsApi.GetInterventionsById: " + e.Message );
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

[**EdFiIntervention**](EdFiIntervention.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postintervention"></a>
# **PostIntervention**
> void PostIntervention (EdFiIntervention intervention)

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
    public class PostInterventionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InterventionsApi();
            var intervention = new EdFiIntervention(); // EdFiIntervention | The JSON representation of the \"intervention\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostIntervention(intervention);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InterventionsApi.PostIntervention: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **intervention** | [**EdFiIntervention**](EdFiIntervention.md)| The JSON representation of the \&quot;intervention\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putintervention"></a>
# **PutIntervention**
> void PutIntervention (string id, EdFiIntervention intervention, string ifMatch = null)

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
    public class PutInterventionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InterventionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var intervention = new EdFiIntervention(); // EdFiIntervention | The JSON representation of the \"intervention\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutIntervention(id, intervention, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InterventionsApi.PutIntervention: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **intervention** | [**EdFiIntervention**](EdFiIntervention.md)| The JSON representation of the \&quot;intervention\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

