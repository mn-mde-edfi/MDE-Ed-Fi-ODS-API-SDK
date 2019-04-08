# EdFi.OdsApi.Sdk.Apis.MN.EarlyChildhoodScreeningExitStatusDescriptorsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteEarlyChildhoodScreeningExitStatusDescriptorById**](EarlyChildhoodScreeningExitStatusDescriptorsApi.md#deleteearlychildhoodscreeningexitstatusdescriptorbyid) | **DELETE** /MN/earlyChildhoodScreeningExitStatusDescriptors/{id} | Deletes an existing resource using the resource identifier.
[**GetEarlyChildhoodScreeningExitStatusDescriptors**](EarlyChildhoodScreeningExitStatusDescriptorsApi.md#getearlychildhoodscreeningexitstatusdescriptors) | **GET** /MN/earlyChildhoodScreeningExitStatusDescriptors | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetEarlyChildhoodScreeningExitStatusDescriptorsById**](EarlyChildhoodScreeningExitStatusDescriptorsApi.md#getearlychildhoodscreeningexitstatusdescriptorsbyid) | **GET** /MN/earlyChildhoodScreeningExitStatusDescriptors/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostEarlyChildhoodScreeningExitStatusDescriptor**](EarlyChildhoodScreeningExitStatusDescriptorsApi.md#postearlychildhoodscreeningexitstatusdescriptor) | **POST** /MN/earlyChildhoodScreeningExitStatusDescriptors | Creates or updates resources based on the natural key values of the supplied resource.
[**PutEarlyChildhoodScreeningExitStatusDescriptor**](EarlyChildhoodScreeningExitStatusDescriptorsApi.md#putearlychildhoodscreeningexitstatusdescriptor) | **PUT** /MN/earlyChildhoodScreeningExitStatusDescriptors/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteearlychildhoodscreeningexitstatusdescriptorbyid"></a>
# **DeleteEarlyChildhoodScreeningExitStatusDescriptorById**
> void DeleteEarlyChildhoodScreeningExitStatusDescriptorById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.MN;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.MN;

namespace Example
{
    public class DeleteEarlyChildhoodScreeningExitStatusDescriptorByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EarlyChildhoodScreeningExitStatusDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteEarlyChildhoodScreeningExitStatusDescriptorById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EarlyChildhoodScreeningExitStatusDescriptorsApi.DeleteEarlyChildhoodScreeningExitStatusDescriptorById: " + e.Message );
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

<a name="getearlychildhoodscreeningexitstatusdescriptors"></a>
# **GetEarlyChildhoodScreeningExitStatusDescriptors**
> List<MnEarlyChildhoodScreeningExitStatusDescriptor> GetEarlyChildhoodScreeningExitStatusDescriptors (int? offset = null, int? limit = null, bool? totalCount = null, int? earlyChildhoodScreeningExitStatusDescriptorId = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.MN;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.MN;

namespace Example
{
    public class GetEarlyChildhoodScreeningExitStatusDescriptorsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EarlyChildhoodScreeningExitStatusDescriptorsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var earlyChildhoodScreeningExitStatusDescriptorId = 56;  // int? | A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;MnEarlyChildhoodScreeningExitStatusDescriptor&gt; result = apiInstance.GetEarlyChildhoodScreeningExitStatusDescriptors(offset, limit, totalCount, earlyChildhoodScreeningExitStatusDescriptorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EarlyChildhoodScreeningExitStatusDescriptorsApi.GetEarlyChildhoodScreeningExitStatusDescriptors: " + e.Message );
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
 **earlyChildhoodScreeningExitStatusDescriptorId** | **int?**| A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. | [optional] 

### Return type

[**List<MnEarlyChildhoodScreeningExitStatusDescriptor>**](MnEarlyChildhoodScreeningExitStatusDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getearlychildhoodscreeningexitstatusdescriptorsbyid"></a>
# **GetEarlyChildhoodScreeningExitStatusDescriptorsById**
> MnEarlyChildhoodScreeningExitStatusDescriptor GetEarlyChildhoodScreeningExitStatusDescriptorsById (string id, string ifNoneMatch = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.MN;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.MN;

namespace Example
{
    public class GetEarlyChildhoodScreeningExitStatusDescriptorsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EarlyChildhoodScreeningExitStatusDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                MnEarlyChildhoodScreeningExitStatusDescriptor result = apiInstance.GetEarlyChildhoodScreeningExitStatusDescriptorsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EarlyChildhoodScreeningExitStatusDescriptorsApi.GetEarlyChildhoodScreeningExitStatusDescriptorsById: " + e.Message );
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

[**MnEarlyChildhoodScreeningExitStatusDescriptor**](MnEarlyChildhoodScreeningExitStatusDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postearlychildhoodscreeningexitstatusdescriptor"></a>
# **PostEarlyChildhoodScreeningExitStatusDescriptor**
> void PostEarlyChildhoodScreeningExitStatusDescriptor (MnEarlyChildhoodScreeningExitStatusDescriptor earlyChildhoodScreeningExitStatusDescriptor)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error (you must use a PUT operation to update a resource by \"id\"). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.MN;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.MN;

namespace Example
{
    public class PostEarlyChildhoodScreeningExitStatusDescriptorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EarlyChildhoodScreeningExitStatusDescriptorsApi();
            var earlyChildhoodScreeningExitStatusDescriptor = new MnEarlyChildhoodScreeningExitStatusDescriptor(); // MnEarlyChildhoodScreeningExitStatusDescriptor | The JSON representation of the \"earlyChildhoodScreeningExitStatusDescriptor\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostEarlyChildhoodScreeningExitStatusDescriptor(earlyChildhoodScreeningExitStatusDescriptor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EarlyChildhoodScreeningExitStatusDescriptorsApi.PostEarlyChildhoodScreeningExitStatusDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **earlyChildhoodScreeningExitStatusDescriptor** | [**MnEarlyChildhoodScreeningExitStatusDescriptor**](MnEarlyChildhoodScreeningExitStatusDescriptor.md)| The JSON representation of the \&quot;earlyChildhoodScreeningExitStatusDescriptor\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putearlychildhoodscreeningexitstatusdescriptor"></a>
# **PutEarlyChildhoodScreeningExitStatusDescriptor**
> void PutEarlyChildhoodScreeningExitStatusDescriptor (string id, MnEarlyChildhoodScreeningExitStatusDescriptor earlyChildhoodScreeningExitStatusDescriptor, string ifMatch = null)

Updates or creates a resource based on the resource identifier.

The PUT operation is used to update or create a resource by identifier. If the resource doesn't exist, the resource will be created using that identifier. Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource \"id\" is provided in the JSON body, it will be ignored as well.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.MN;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.MN;

namespace Example
{
    public class PutEarlyChildhoodScreeningExitStatusDescriptorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EarlyChildhoodScreeningExitStatusDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var earlyChildhoodScreeningExitStatusDescriptor = new MnEarlyChildhoodScreeningExitStatusDescriptor(); // MnEarlyChildhoodScreeningExitStatusDescriptor | The JSON representation of the \"earlyChildhoodScreeningExitStatusDescriptor\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutEarlyChildhoodScreeningExitStatusDescriptor(id, earlyChildhoodScreeningExitStatusDescriptor, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EarlyChildhoodScreeningExitStatusDescriptorsApi.PutEarlyChildhoodScreeningExitStatusDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **earlyChildhoodScreeningExitStatusDescriptor** | [**MnEarlyChildhoodScreeningExitStatusDescriptor**](MnEarlyChildhoodScreeningExitStatusDescriptor.md)| The JSON representation of the \&quot;earlyChildhoodScreeningExitStatusDescriptor\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

