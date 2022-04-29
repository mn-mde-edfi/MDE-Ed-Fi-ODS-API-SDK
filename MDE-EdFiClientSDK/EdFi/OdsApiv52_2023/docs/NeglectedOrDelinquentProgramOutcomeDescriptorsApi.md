# EdFi.OdsApi.Sdk.Apis.Identity.NeglectedOrDelinquentProgramOutcomeDescriptorsApi

All URIs are relative to *https://test.edfi5.education.mn.gov:443/api/data/v3/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteNeglectedOrDelinquentProgramOutcomeDescriptorById**](NeglectedOrDelinquentProgramOutcomeDescriptorsApi.md#deleteneglectedordelinquentprogramoutcomedescriptorbyid) | **DELETE** /MN/neglectedOrDelinquentProgramOutcomeDescriptors/{id} | Deletes an existing resource using the resource identifier.
[**DeletesNeglectedOrDelinquentProgramOutcomeDescriptors**](NeglectedOrDelinquentProgramOutcomeDescriptorsApi.md#deletesneglectedordelinquentprogramoutcomedescriptors) | **GET** /MN/neglectedOrDelinquentProgramOutcomeDescriptors/deletes | Retrieves deleted resources based on change version.
[**GetNeglectedOrDelinquentProgramOutcomeDescriptors**](NeglectedOrDelinquentProgramOutcomeDescriptorsApi.md#getneglectedordelinquentprogramoutcomedescriptors) | **GET** /MN/neglectedOrDelinquentProgramOutcomeDescriptors | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetNeglectedOrDelinquentProgramOutcomeDescriptorsById**](NeglectedOrDelinquentProgramOutcomeDescriptorsApi.md#getneglectedordelinquentprogramoutcomedescriptorsbyid) | **GET** /MN/neglectedOrDelinquentProgramOutcomeDescriptors/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostNeglectedOrDelinquentProgramOutcomeDescriptor**](NeglectedOrDelinquentProgramOutcomeDescriptorsApi.md#postneglectedordelinquentprogramoutcomedescriptor) | **POST** /MN/neglectedOrDelinquentProgramOutcomeDescriptors | Creates or updates resources based on the natural key values of the supplied resource.
[**PutNeglectedOrDelinquentProgramOutcomeDescriptor**](NeglectedOrDelinquentProgramOutcomeDescriptorsApi.md#putneglectedordelinquentprogramoutcomedescriptor) | **PUT** /MN/neglectedOrDelinquentProgramOutcomeDescriptors/{id} | Updates a resource based on the resource identifier.


<a name="deleteneglectedordelinquentprogramoutcomedescriptorbyid"></a>
# **DeleteNeglectedOrDelinquentProgramOutcomeDescriptorById**
> void DeleteNeglectedOrDelinquentProgramOutcomeDescriptorById (string id, string ifMatch = null)

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
    public class DeleteNeglectedOrDelinquentProgramOutcomeDescriptorByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NeglectedOrDelinquentProgramOutcomeDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteNeglectedOrDelinquentProgramOutcomeDescriptorById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NeglectedOrDelinquentProgramOutcomeDescriptorsApi.DeleteNeglectedOrDelinquentProgramOutcomeDescriptorById: " + e.Message );
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

<a name="deletesneglectedordelinquentprogramoutcomedescriptors"></a>
# **DeletesNeglectedOrDelinquentProgramOutcomeDescriptors**
> List<DeletedResource> DeletesNeglectedOrDelinquentProgramOutcomeDescriptors (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, string snapshotIdentifier = null)

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
    public class DeletesNeglectedOrDelinquentProgramOutcomeDescriptorsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NeglectedOrDelinquentProgramOutcomeDescriptorsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List&lt;DeletedResource&gt; result = apiInstance.DeletesNeglectedOrDelinquentProgramOutcomeDescriptors(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NeglectedOrDelinquentProgramOutcomeDescriptorsApi.DeletesNeglectedOrDelinquentProgramOutcomeDescriptors: " + e.Message );
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

<a name="getneglectedordelinquentprogramoutcomedescriptors"></a>
# **GetNeglectedOrDelinquentProgramOutcomeDescriptors**
> List<MnNeglectedOrDelinquentProgramOutcomeDescriptor> GetNeglectedOrDelinquentProgramOutcomeDescriptors (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, bool? totalCount = null, int? neglectedOrDelinquentProgramOutcomeDescriptorId = null, string snapshotIdentifier = null)

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
    public class GetNeglectedOrDelinquentProgramOutcomeDescriptorsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NeglectedOrDelinquentProgramOutcomeDescriptorsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var neglectedOrDelinquentProgramOutcomeDescriptorId = 56;  // int? | A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;MnNeglectedOrDelinquentProgramOutcomeDescriptor&gt; result = apiInstance.GetNeglectedOrDelinquentProgramOutcomeDescriptors(offset, limit, minChangeVersion, maxChangeVersion, totalCount, neglectedOrDelinquentProgramOutcomeDescriptorId, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NeglectedOrDelinquentProgramOutcomeDescriptorsApi.GetNeglectedOrDelinquentProgramOutcomeDescriptors: " + e.Message );
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
 **neglectedOrDelinquentProgramOutcomeDescriptorId** | **int?**| A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table. | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<MnNeglectedOrDelinquentProgramOutcomeDescriptor>**](MnNeglectedOrDelinquentProgramOutcomeDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getneglectedordelinquentprogramoutcomedescriptorsbyid"></a>
# **GetNeglectedOrDelinquentProgramOutcomeDescriptorsById**
> MnNeglectedOrDelinquentProgramOutcomeDescriptor GetNeglectedOrDelinquentProgramOutcomeDescriptorsById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

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
    public class GetNeglectedOrDelinquentProgramOutcomeDescriptorsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NeglectedOrDelinquentProgramOutcomeDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                MnNeglectedOrDelinquentProgramOutcomeDescriptor result = apiInstance.GetNeglectedOrDelinquentProgramOutcomeDescriptorsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NeglectedOrDelinquentProgramOutcomeDescriptorsApi.GetNeglectedOrDelinquentProgramOutcomeDescriptorsById: " + e.Message );
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

[**MnNeglectedOrDelinquentProgramOutcomeDescriptor**](MnNeglectedOrDelinquentProgramOutcomeDescriptor.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postneglectedordelinquentprogramoutcomedescriptor"></a>
# **PostNeglectedOrDelinquentProgramOutcomeDescriptor**
> void PostNeglectedOrDelinquentProgramOutcomeDescriptor (MnNeglectedOrDelinquentProgramOutcomeDescriptor neglectedOrDelinquentProgramOutcomeDescriptor)

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
    public class PostNeglectedOrDelinquentProgramOutcomeDescriptorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NeglectedOrDelinquentProgramOutcomeDescriptorsApi();
            var neglectedOrDelinquentProgramOutcomeDescriptor = new MnNeglectedOrDelinquentProgramOutcomeDescriptor(); // MnNeglectedOrDelinquentProgramOutcomeDescriptor | The JSON representation of the \"neglectedOrDelinquentProgramOutcomeDescriptor\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostNeglectedOrDelinquentProgramOutcomeDescriptor(neglectedOrDelinquentProgramOutcomeDescriptor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NeglectedOrDelinquentProgramOutcomeDescriptorsApi.PostNeglectedOrDelinquentProgramOutcomeDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **neglectedOrDelinquentProgramOutcomeDescriptor** | [**MnNeglectedOrDelinquentProgramOutcomeDescriptor**](MnNeglectedOrDelinquentProgramOutcomeDescriptor.md)| The JSON representation of the \&quot;neglectedOrDelinquentProgramOutcomeDescriptor\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putneglectedordelinquentprogramoutcomedescriptor"></a>
# **PutNeglectedOrDelinquentProgramOutcomeDescriptor**
> void PutNeglectedOrDelinquentProgramOutcomeDescriptor (string id, MnNeglectedOrDelinquentProgramOutcomeDescriptor neglectedOrDelinquentProgramOutcomeDescriptor, string ifMatch = null)

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
    public class PutNeglectedOrDelinquentProgramOutcomeDescriptorExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NeglectedOrDelinquentProgramOutcomeDescriptorsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var neglectedOrDelinquentProgramOutcomeDescriptor = new MnNeglectedOrDelinquentProgramOutcomeDescriptor(); // MnNeglectedOrDelinquentProgramOutcomeDescriptor | The JSON representation of the \"neglectedOrDelinquentProgramOutcomeDescriptor\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutNeglectedOrDelinquentProgramOutcomeDescriptor(id, neglectedOrDelinquentProgramOutcomeDescriptor, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NeglectedOrDelinquentProgramOutcomeDescriptorsApi.PutNeglectedOrDelinquentProgramOutcomeDescriptor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **neglectedOrDelinquentProgramOutcomeDescriptor** | [**MnNeglectedOrDelinquentProgramOutcomeDescriptor**](MnNeglectedOrDelinquentProgramOutcomeDescriptor.md)| The JSON representation of the \&quot;neglectedOrDelinquentProgramOutcomeDescriptor\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

