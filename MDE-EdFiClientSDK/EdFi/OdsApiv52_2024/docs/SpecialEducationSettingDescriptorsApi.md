# EdFi.OdsApi.Sdk.Apis.Descriptors.SpecialEducationSettingDescriptorsApi

All URIs are relative to *https://test.edfi5.education.mn.gov:443/sb24/api/data/v3/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSpecialEducationSettingDescriptorById**](SpecialEducationSettingDescriptorsApi.md#deletespecialeducationsettingdescriptorbyid) | **DELETE** /ed-fi/specialEducationSettingDescriptors/{id} | Deletes an existing resource using the resource identifier.
[**DeletesSpecialEducationSettingDescriptors**](SpecialEducationSettingDescriptorsApi.md#deletesspecialeducationsettingdescriptors) | **GET** /ed-fi/specialEducationSettingDescriptors/deletes | Retrieves deleted resources based on change version.
[**GetSpecialEducationSettingDescriptors**](SpecialEducationSettingDescriptorsApi.md#getspecialeducationsettingdescriptors) | **GET** /ed-fi/specialEducationSettingDescriptors | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetSpecialEducationSettingDescriptorsById**](SpecialEducationSettingDescriptorsApi.md#getspecialeducationsettingdescriptorsbyid) | **GET** /ed-fi/specialEducationSettingDescriptors/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostSpecialEducationSettingDescriptor**](SpecialEducationSettingDescriptorsApi.md#postspecialeducationsettingdescriptor) | **POST** /ed-fi/specialEducationSettingDescriptors | Creates or updates resources based on the natural key values of the supplied resource.
[**PutSpecialEducationSettingDescriptor**](SpecialEducationSettingDescriptorsApi.md#putspecialeducationsettingdescriptor) | **PUT** /ed-fi/specialEducationSettingDescriptors/{id} | Updates a resource based on the resource identifier.


<a name="deletespecialeducationsettingdescriptorbyid"></a>
# **DeleteSpecialEducationSettingDescriptorById**
> void DeleteSpecialEducationSettingDescriptorById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Descriptors;

namespace Example
{
    public class DeleteSpecialEducationSettingDescriptorByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SpecialEducationSettingDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteSpecialEducationSettingDescriptorById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecialEducationSettingDescriptorsApi.DeleteSpecialEducationSettingDescriptorById: " + e.Message );
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

<a name="deletesspecialeducationsettingdescriptors"></a>
# **DeletesSpecialEducationSettingDescriptors**
> List<DeletedResource> DeletesSpecialEducationSettingDescriptors (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, string snapshotIdentifier = null)

Retrieves deleted resources based on change version.

The DELETES operation is used to retrieve deleted resources.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Descriptors;

namespace Example
{
    public class DeletesSpecialEducationSettingDescriptorsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SpecialEducationSettingDescriptorsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List&lt;DeletedResource&gt; result = apiInstance.DeletesSpecialEducationSettingDescriptors(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecialEducationSettingDescriptorsApi.DeletesSpecialEducationSettingDescriptors: " + e.Message );
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

<a name="getspecialeducationsettingdescriptors"></a>
# **GetSpecialEducationSettingDescriptors**
> List<EdFiSpecialEducationSettingDescriptor> GetSpecialEducationSettingDescriptors (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, bool? totalCount = null, int? specialEducationSettingDescriptorId = null, string snapshotIdentifier = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Descriptors;

namespace Example
{
    public class GetSpecialEducationSettingDescriptorsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SpecialEducationSettingDescriptorsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var specialEducationSettingDescriptorId = 56;  // int? | A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiSpecialEducationSettingDescriptor&gt; result = apiInstance.GetSpecialEducationSettingDescriptors(offset, limit, minChangeVersion, maxChangeVersion, totalCount, specialEducationSettingDescriptorId, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecialEducationSettingDescriptorsApi.GetSpecialEducationSettingDescriptors: " + e.Message );
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
 **specialEducationSettingDescriptorId** | **int?**| A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<EdFiSpecialEducationSettingDescriptor>**](EdFiSpecialEducationSettingDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getspecialeducationsettingdescriptorsbyid"></a>
# **GetSpecialEducationSettingDescriptorsById**
> EdFiSpecialEducationSettingDescriptor GetSpecialEducationSettingDescriptorsById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Descriptors;

namespace Example
{
    public class GetSpecialEducationSettingDescriptorsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SpecialEducationSettingDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiSpecialEducationSettingDescriptor result = apiInstance.GetSpecialEducationSettingDescriptorsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecialEducationSettingDescriptorsApi.GetSpecialEducationSettingDescriptorsById: " + e.Message );
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

[**EdFiSpecialEducationSettingDescriptor**](EdFiSpecialEducationSettingDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postspecialeducationsettingdescriptor"></a>
# **PostSpecialEducationSettingDescriptor**
> void PostSpecialEducationSettingDescriptor (EdFiSpecialEducationSettingDescriptor specialEducationSettingDescriptor)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error. The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately. It is recommended to use POST for both create and update except while updating natural key of a resource in which case PUT operation must be used.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Descriptors;

namespace Example
{
    public class PostSpecialEducationSettingDescriptorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SpecialEducationSettingDescriptorsApi();
            var specialEducationSettingDescriptor = new EdFiSpecialEducationSettingDescriptor(); // EdFiSpecialEducationSettingDescriptor | The JSON representation of the \"specialEducationSettingDescriptor\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostSpecialEducationSettingDescriptor(specialEducationSettingDescriptor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecialEducationSettingDescriptorsApi.PostSpecialEducationSettingDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **specialEducationSettingDescriptor** | [**EdFiSpecialEducationSettingDescriptor**](EdFiSpecialEducationSettingDescriptor.md)| The JSON representation of the \&quot;specialEducationSettingDescriptor\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putspecialeducationsettingdescriptor"></a>
# **PutSpecialEducationSettingDescriptor**
> void PutSpecialEducationSettingDescriptor (string id, EdFiSpecialEducationSettingDescriptor specialEducationSettingDescriptor, string ifMatch = null)

Updates a resource based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, this API resource is not configured for cascading natural key updates. Natural key values for this resource cannot be changed using PUT operation and will not be modified in the database, and so recommendation is to use POST as that supports upsert behavior.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Descriptors;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Descriptors;

namespace Example
{
    public class PutSpecialEducationSettingDescriptorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SpecialEducationSettingDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var specialEducationSettingDescriptor = new EdFiSpecialEducationSettingDescriptor(); // EdFiSpecialEducationSettingDescriptor | The JSON representation of the \"specialEducationSettingDescriptor\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutSpecialEducationSettingDescriptor(id, specialEducationSettingDescriptor, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SpecialEducationSettingDescriptorsApi.PutSpecialEducationSettingDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **specialEducationSettingDescriptor** | [**EdFiSpecialEducationSettingDescriptor**](EdFiSpecialEducationSettingDescriptor.md)| The JSON representation of the \&quot;specialEducationSettingDescriptor\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

