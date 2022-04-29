# EdFi.OdsApi.Sdk.Apis.Identity.LearningStandardEquivalenceAssociationsApi

All URIs are relative to *https://test.edfi5.education.mn.gov:443/api/data/v3/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteLearningStandardEquivalenceAssociationById**](LearningStandardEquivalenceAssociationsApi.md#deletelearningstandardequivalenceassociationbyid) | **DELETE** /ed-fi/learningStandardEquivalenceAssociations/{id} | Deletes an existing resource using the resource identifier.
[**DeletesLearningStandardEquivalenceAssociations**](LearningStandardEquivalenceAssociationsApi.md#deleteslearningstandardequivalenceassociations) | **GET** /ed-fi/learningStandardEquivalenceAssociations/deletes | Retrieves deleted resources based on change version.
[**GetLearningStandardEquivalenceAssociations**](LearningStandardEquivalenceAssociationsApi.md#getlearningstandardequivalenceassociations) | **GET** /ed-fi/learningStandardEquivalenceAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetLearningStandardEquivalenceAssociationsById**](LearningStandardEquivalenceAssociationsApi.md#getlearningstandardequivalenceassociationsbyid) | **GET** /ed-fi/learningStandardEquivalenceAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostLearningStandardEquivalenceAssociation**](LearningStandardEquivalenceAssociationsApi.md#postlearningstandardequivalenceassociation) | **POST** /ed-fi/learningStandardEquivalenceAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutLearningStandardEquivalenceAssociation**](LearningStandardEquivalenceAssociationsApi.md#putlearningstandardequivalenceassociation) | **PUT** /ed-fi/learningStandardEquivalenceAssociations/{id} | Updates a resource based on the resource identifier.


<a name="deletelearningstandardequivalenceassociationbyid"></a>
# **DeleteLearningStandardEquivalenceAssociationById**
> void DeleteLearningStandardEquivalenceAssociationById (string id, string ifMatch = null)

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
    public class DeleteLearningStandardEquivalenceAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardEquivalenceAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteLearningStandardEquivalenceAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningStandardEquivalenceAssociationsApi.DeleteLearningStandardEquivalenceAssociationById: " + e.Message );
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

<a name="deleteslearningstandardequivalenceassociations"></a>
# **DeletesLearningStandardEquivalenceAssociations**
> List<DeletedResource> DeletesLearningStandardEquivalenceAssociations (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, string snapshotIdentifier = null)

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
    public class DeletesLearningStandardEquivalenceAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardEquivalenceAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List&lt;DeletedResource&gt; result = apiInstance.DeletesLearningStandardEquivalenceAssociations(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningStandardEquivalenceAssociationsApi.DeletesLearningStandardEquivalenceAssociations: " + e.Message );
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

<a name="getlearningstandardequivalenceassociations"></a>
# **GetLearningStandardEquivalenceAssociations**
> List<EdFiLearningStandardEquivalenceAssociation> GetLearningStandardEquivalenceAssociations (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, bool? totalCount = null, string _namespace = null, string sourceLearningStandardId = null, string targetLearningStandardId = null, string learningStandardEquivalenceStrengthDescriptor = null, DateTime? effectiveDate = null, string id = null, string learningStandardEquivalenceStrengthDescription = null, string snapshotIdentifier = null)

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
    public class GetLearningStandardEquivalenceAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardEquivalenceAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var _namespace = _namespace_example;  // string | The namespace of the organization that has created and owns the association. (optional) 
            var sourceLearningStandardId = sourceLearningStandardId_example;  // string | The identifier for the specific learning standard (e.g., 111.15.3.1.A). (optional) 
            var targetLearningStandardId = targetLearningStandardId_example;  // string | The identifier for the specific learning standard (e.g., 111.15.3.1.A). (optional) 
            var learningStandardEquivalenceStrengthDescriptor = learningStandardEquivalenceStrengthDescriptor_example;  // string | A measure that indicates the strength or quality of the equivalence relationship. (optional) 
            var effectiveDate = 2013-10-20;  // DateTime? | The date that the association is considered to be applicable or effective. (optional) 
            var id = id_example;  // string |  (optional) 
            var learningStandardEquivalenceStrengthDescription = learningStandardEquivalenceStrengthDescription_example;  // string | Captures supplemental information on the relationship. Recommended for use only when the match is  partial. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiLearningStandardEquivalenceAssociation&gt; result = apiInstance.GetLearningStandardEquivalenceAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, _namespace, sourceLearningStandardId, targetLearningStandardId, learningStandardEquivalenceStrengthDescriptor, effectiveDate, id, learningStandardEquivalenceStrengthDescription, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningStandardEquivalenceAssociationsApi.GetLearningStandardEquivalenceAssociations: " + e.Message );
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
 **_namespace** | **string**| The namespace of the organization that has created and owns the association. | [optional] 
 **sourceLearningStandardId** | **string**| The identifier for the specific learning standard (e.g., 111.15.3.1.A). | [optional] 
 **targetLearningStandardId** | **string**| The identifier for the specific learning standard (e.g., 111.15.3.1.A). | [optional] 
 **learningStandardEquivalenceStrengthDescriptor** | **string**| A measure that indicates the strength or quality of the equivalence relationship. | [optional] 
 **effectiveDate** | **DateTime?**| The date that the association is considered to be applicable or effective. | [optional] 
 **id** | **string**|  | [optional] 
 **learningStandardEquivalenceStrengthDescription** | **string**| Captures supplemental information on the relationship. Recommended for use only when the match is  partial. | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<EdFiLearningStandardEquivalenceAssociation>**](EdFiLearningStandardEquivalenceAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlearningstandardequivalenceassociationsbyid"></a>
# **GetLearningStandardEquivalenceAssociationsById**
> EdFiLearningStandardEquivalenceAssociation GetLearningStandardEquivalenceAssociationsById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

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
    public class GetLearningStandardEquivalenceAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardEquivalenceAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiLearningStandardEquivalenceAssociation result = apiInstance.GetLearningStandardEquivalenceAssociationsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningStandardEquivalenceAssociationsApi.GetLearningStandardEquivalenceAssociationsById: " + e.Message );
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

[**EdFiLearningStandardEquivalenceAssociation**](EdFiLearningStandardEquivalenceAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postlearningstandardequivalenceassociation"></a>
# **PostLearningStandardEquivalenceAssociation**
> void PostLearningStandardEquivalenceAssociation (EdFiLearningStandardEquivalenceAssociation learningStandardEquivalenceAssociation)

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
    public class PostLearningStandardEquivalenceAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardEquivalenceAssociationsApi();
            var learningStandardEquivalenceAssociation = new EdFiLearningStandardEquivalenceAssociation(); // EdFiLearningStandardEquivalenceAssociation | The JSON representation of the \"learningStandardEquivalenceAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostLearningStandardEquivalenceAssociation(learningStandardEquivalenceAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningStandardEquivalenceAssociationsApi.PostLearningStandardEquivalenceAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **learningStandardEquivalenceAssociation** | [**EdFiLearningStandardEquivalenceAssociation**](EdFiLearningStandardEquivalenceAssociation.md)| The JSON representation of the \&quot;learningStandardEquivalenceAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putlearningstandardequivalenceassociation"></a>
# **PutLearningStandardEquivalenceAssociation**
> void PutLearningStandardEquivalenceAssociation (string id, EdFiLearningStandardEquivalenceAssociation learningStandardEquivalenceAssociation, string ifMatch = null)

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
    public class PutLearningStandardEquivalenceAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LearningStandardEquivalenceAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var learningStandardEquivalenceAssociation = new EdFiLearningStandardEquivalenceAssociation(); // EdFiLearningStandardEquivalenceAssociation | The JSON representation of the \"learningStandardEquivalenceAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutLearningStandardEquivalenceAssociation(id, learningStandardEquivalenceAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LearningStandardEquivalenceAssociationsApi.PutLearningStandardEquivalenceAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **learningStandardEquivalenceAssociation** | [**EdFiLearningStandardEquivalenceAssociation**](EdFiLearningStandardEquivalenceAssociation.md)| The JSON representation of the \&quot;learningStandardEquivalenceAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

