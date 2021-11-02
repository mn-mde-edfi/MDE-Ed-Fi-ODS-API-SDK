# EdFi.OdsApi.Sdk.Apis.Identity.CredentialsApi

All URIs are relative to *http://localhost:54746/data/v3/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCredentialById**](CredentialsApi.md#deletecredentialbyid) | **DELETE** /ed-fi/credentials/{id} | Deletes an existing resource using the resource identifier.
[**DeletesCredentials**](CredentialsApi.md#deletescredentials) | **GET** /ed-fi/credentials/deletes | Retrieves deleted resources based on change version.
[**GetCredentials**](CredentialsApi.md#getcredentials) | **GET** /ed-fi/credentials | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetCredentialsById**](CredentialsApi.md#getcredentialsbyid) | **GET** /ed-fi/credentials/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostCredential**](CredentialsApi.md#postcredential) | **POST** /ed-fi/credentials | Creates or updates resources based on the natural key values of the supplied resource.
[**PutCredential**](CredentialsApi.md#putcredential) | **PUT** /ed-fi/credentials/{id} | Updates a resource based on the resource identifier.


<a name="deletecredentialbyid"></a>
# **DeleteCredentialById**
> void DeleteCredentialById (string id, string ifMatch = null)

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
    public class DeleteCredentialByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteCredentialById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.DeleteCredentialById: " + e.Message );
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

<a name="deletescredentials"></a>
# **DeletesCredentials**
> List<DeletedResource> DeletesCredentials (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, string snapshotIdentifier = null)

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
    public class DeletesCredentialsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List&lt;DeletedResource&gt; result = apiInstance.DeletesCredentials(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.DeletesCredentials: " + e.Message );
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

<a name="getcredentials"></a>
# **GetCredentials**
> List<EdFiCredential> GetCredentials (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, bool? totalCount = null, string stateOfIssueStateAbbreviationDescriptor = null, string credentialIdentifier = null, string credentialFieldDescriptor = null, string credentialTypeDescriptor = null, string teachingCredentialBasisDescriptor = null, string teachingCredentialDescriptor = null, DateTime? effectiveDate = null, DateTime? expirationDate = null, string id = null, DateTime? issuanceDate = null, string _namespace = null, string snapshotIdentifier = null)

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
    public class GetCredentialsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var stateOfIssueStateAbbreviationDescriptor = stateOfIssueStateAbbreviationDescriptor_example;  // string | The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a license/credential was issued. (optional) 
            var credentialIdentifier = credentialIdentifier_example;  // string | Identifier or serial number assigned to the credential. (optional) 
            var credentialFieldDescriptor = credentialFieldDescriptor_example;  // string | The field of certification for the certificate (e.g., Mathematics, Music). (optional) 
            var credentialTypeDescriptor = credentialTypeDescriptor_example;  // string | An indication of the category of credential an individual holds. (optional) 
            var teachingCredentialBasisDescriptor = teachingCredentialBasisDescriptor_example;  // string | An indication of the pre-determined criteria for granting the teaching credential that an individual holds. (optional) 
            var teachingCredentialDescriptor = teachingCredentialDescriptor_example;  // string | An indication of the category of a legal document giving authorization to perform teaching assignment services. (optional) 
            var effectiveDate = 2013-10-20;  // DateTime? | The year, month and day on which an active credential held by an individual was issued. (optional) 
            var expirationDate = 2013-10-20;  // DateTime? | The month, day, and year on which an active credential held by an individual will expire. (optional) 
            var id = id_example;  // string |  (optional) 
            var issuanceDate = 2013-10-20;  // DateTime? | The month, day, and year on which an active credential was issued to an individual. (optional) 
            var _namespace = _namespace_example;  // string | Namespace for the Credential. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiCredential&gt; result = apiInstance.GetCredentials(offset, limit, minChangeVersion, maxChangeVersion, totalCount, stateOfIssueStateAbbreviationDescriptor, credentialIdentifier, credentialFieldDescriptor, credentialTypeDescriptor, teachingCredentialBasisDescriptor, teachingCredentialDescriptor, effectiveDate, expirationDate, id, issuanceDate, _namespace, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.GetCredentials: " + e.Message );
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
 **stateOfIssueStateAbbreviationDescriptor** | **string**| The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a license/credential was issued. | [optional] 
 **credentialIdentifier** | **string**| Identifier or serial number assigned to the credential. | [optional] 
 **credentialFieldDescriptor** | **string**| The field of certification for the certificate (e.g., Mathematics, Music). | [optional] 
 **credentialTypeDescriptor** | **string**| An indication of the category of credential an individual holds. | [optional] 
 **teachingCredentialBasisDescriptor** | **string**| An indication of the pre-determined criteria for granting the teaching credential that an individual holds. | [optional] 
 **teachingCredentialDescriptor** | **string**| An indication of the category of a legal document giving authorization to perform teaching assignment services. | [optional] 
 **effectiveDate** | **DateTime?**| The year, month and day on which an active credential held by an individual was issued. | [optional] 
 **expirationDate** | **DateTime?**| The month, day, and year on which an active credential held by an individual will expire. | [optional] 
 **id** | **string**|  | [optional] 
 **issuanceDate** | **DateTime?**| The month, day, and year on which an active credential was issued to an individual. | [optional] 
 **_namespace** | **string**| Namespace for the Credential. | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<EdFiCredential>**](EdFiCredential.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcredentialsbyid"></a>
# **GetCredentialsById**
> EdFiCredential GetCredentialsById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

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
    public class GetCredentialsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiCredential result = apiInstance.GetCredentialsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.GetCredentialsById: " + e.Message );
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

[**EdFiCredential**](EdFiCredential.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcredential"></a>
# **PostCredential**
> void PostCredential (EdFiCredential credential)

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
    public class PostCredentialExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var credential = new EdFiCredential(); // EdFiCredential | The JSON representation of the \"credential\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostCredential(credential);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.PostCredential: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **credential** | [**EdFiCredential**](EdFiCredential.md)| The JSON representation of the \&quot;credential\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcredential"></a>
# **PutCredential**
> void PutCredential (string id, EdFiCredential credential, string ifMatch = null)

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
    public class PutCredentialExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CredentialsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var credential = new EdFiCredential(); // EdFiCredential | The JSON representation of the \"credential\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutCredential(id, credential, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CredentialsApi.PutCredential: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **credential** | [**EdFiCredential**](EdFiCredential.md)| The JSON representation of the \&quot;credential\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

