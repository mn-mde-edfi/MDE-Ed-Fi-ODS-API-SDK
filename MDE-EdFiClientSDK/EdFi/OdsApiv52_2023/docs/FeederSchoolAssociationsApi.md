# EdFi.OdsApi.Sdk.Apis.Identity.FeederSchoolAssociationsApi

All URIs are relative to *https://test.edfi5.education.mn.gov:443/api/data/v3/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteFeederSchoolAssociationById**](FeederSchoolAssociationsApi.md#deletefeederschoolassociationbyid) | **DELETE** /ed-fi/feederSchoolAssociations/{id} | Deletes an existing resource using the resource identifier.
[**DeletesFeederSchoolAssociations**](FeederSchoolAssociationsApi.md#deletesfeederschoolassociations) | **GET** /ed-fi/feederSchoolAssociations/deletes | Retrieves deleted resources based on change version.
[**GetFeederSchoolAssociations**](FeederSchoolAssociationsApi.md#getfeederschoolassociations) | **GET** /ed-fi/feederSchoolAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetFeederSchoolAssociationsById**](FeederSchoolAssociationsApi.md#getfeederschoolassociationsbyid) | **GET** /ed-fi/feederSchoolAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostFeederSchoolAssociation**](FeederSchoolAssociationsApi.md#postfeederschoolassociation) | **POST** /ed-fi/feederSchoolAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutFeederSchoolAssociation**](FeederSchoolAssociationsApi.md#putfeederschoolassociation) | **PUT** /ed-fi/feederSchoolAssociations/{id} | Updates a resource based on the resource identifier.


<a name="deletefeederschoolassociationbyid"></a>
# **DeleteFeederSchoolAssociationById**
> void DeleteFeederSchoolAssociationById (string id, string ifMatch = null)

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
    public class DeleteFeederSchoolAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FeederSchoolAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteFeederSchoolAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeederSchoolAssociationsApi.DeleteFeederSchoolAssociationById: " + e.Message );
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

<a name="deletesfeederschoolassociations"></a>
# **DeletesFeederSchoolAssociations**
> List<DeletedResource> DeletesFeederSchoolAssociations (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, string snapshotIdentifier = null)

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
    public class DeletesFeederSchoolAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FeederSchoolAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List&lt;DeletedResource&gt; result = apiInstance.DeletesFeederSchoolAssociations(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeederSchoolAssociationsApi.DeletesFeederSchoolAssociations: " + e.Message );
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

<a name="getfeederschoolassociations"></a>
# **GetFeederSchoolAssociations**
> List<EdFiFeederSchoolAssociation> GetFeederSchoolAssociations (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, bool? totalCount = null, DateTime? beginDate = null, int? feederSchoolId = null, int? schoolId = null, DateTime? endDate = null, string feederRelationshipDescription = null, string id = null, string snapshotIdentifier = null)

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
    public class GetFeederSchoolAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FeederSchoolAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var beginDate = 2013-10-20;  // DateTime? | The month, day, and year of the first day of the feeder school association. (optional) 
            var feederSchoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var endDate = 2013-10-20;  // DateTime? | The month, day, and year of the last day of the feeder school association. (optional) 
            var feederRelationshipDescription = feederRelationshipDescription_example;  // string | Describes the relationship from the feeder school to the receiving school, for example by program emphasis, such as special education, language immersion, science, or performing art. (optional) 
            var id = id_example;  // string |  (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiFeederSchoolAssociation&gt; result = apiInstance.GetFeederSchoolAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, beginDate, feederSchoolId, schoolId, endDate, feederRelationshipDescription, id, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeederSchoolAssociationsApi.GetFeederSchoolAssociations: " + e.Message );
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
 **beginDate** | **DateTime?**| The month, day, and year of the first day of the feeder school association. | [optional] 
 **feederSchoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **schoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **endDate** | **DateTime?**| The month, day, and year of the last day of the feeder school association. | [optional] 
 **feederRelationshipDescription** | **string**| Describes the relationship from the feeder school to the receiving school, for example by program emphasis, such as special education, language immersion, science, or performing art. | [optional] 
 **id** | **string**|  | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<EdFiFeederSchoolAssociation>**](EdFiFeederSchoolAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeederschoolassociationsbyid"></a>
# **GetFeederSchoolAssociationsById**
> EdFiFeederSchoolAssociation GetFeederSchoolAssociationsById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

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
    public class GetFeederSchoolAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FeederSchoolAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiFeederSchoolAssociation result = apiInstance.GetFeederSchoolAssociationsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeederSchoolAssociationsApi.GetFeederSchoolAssociationsById: " + e.Message );
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

[**EdFiFeederSchoolAssociation**](EdFiFeederSchoolAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postfeederschoolassociation"></a>
# **PostFeederSchoolAssociation**
> void PostFeederSchoolAssociation (EdFiFeederSchoolAssociation feederSchoolAssociation)

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
    public class PostFeederSchoolAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FeederSchoolAssociationsApi();
            var feederSchoolAssociation = new EdFiFeederSchoolAssociation(); // EdFiFeederSchoolAssociation | The JSON representation of the \"feederSchoolAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostFeederSchoolAssociation(feederSchoolAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeederSchoolAssociationsApi.PostFeederSchoolAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **feederSchoolAssociation** | [**EdFiFeederSchoolAssociation**](EdFiFeederSchoolAssociation.md)| The JSON representation of the \&quot;feederSchoolAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putfeederschoolassociation"></a>
# **PutFeederSchoolAssociation**
> void PutFeederSchoolAssociation (string id, EdFiFeederSchoolAssociation feederSchoolAssociation, string ifMatch = null)

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
    public class PutFeederSchoolAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FeederSchoolAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var feederSchoolAssociation = new EdFiFeederSchoolAssociation(); // EdFiFeederSchoolAssociation | The JSON representation of the \"feederSchoolAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutFeederSchoolAssociation(id, feederSchoolAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FeederSchoolAssociationsApi.PutFeederSchoolAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **feederSchoolAssociation** | [**EdFiFeederSchoolAssociation**](EdFiFeederSchoolAssociation.md)| The JSON representation of the \&quot;feederSchoolAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

