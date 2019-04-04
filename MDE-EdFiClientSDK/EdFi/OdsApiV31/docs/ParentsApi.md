# EdFi.OdsApi.Sdk.Apis.All.ParentsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteParentById**](ParentsApi.md#deleteparentbyid) | **DELETE** /ed-fi/parents/{id} | Deletes an existing resource using the resource identifier.
[**GetParents**](ParentsApi.md#getparents) | **GET** /ed-fi/parents | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetParentsById**](ParentsApi.md#getparentsbyid) | **GET** /ed-fi/parents/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostParent**](ParentsApi.md#postparent) | **POST** /ed-fi/parents | Creates or updates resources based on the natural key values of the supplied resource.
[**PutParent**](ParentsApi.md#putparent) | **PUT** /ed-fi/parents/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteparentbyid"></a>
# **DeleteParentById**
> void DeleteParentById (string id, string ifMatch = null)

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
    public class DeleteParentByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ParentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteParentById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParentsApi.DeleteParentById: " + e.Message );
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

<a name="getparents"></a>
# **GetParents**
> List<EdFiParent> GetParents (int? offset = null, int? limit = null, bool? totalCount = null, string parentUniqueId = null, string sexDescriptor = null, string firstName = null, string generationCodeSuffix = null, string id = null, string lastSurname = null, string loginId = null, string maidenName = null, string middleName = null, string personalTitlePrefix = null)

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
    public class GetParentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ParentsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var parentUniqueId = parentUniqueId_example;  // string | A unique alphanumeric code assigned to a parent. (optional) 
            var sexDescriptor = sexDescriptor_example;  // string | A person's gender. (optional) 
            var firstName = firstName_example;  // string | A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. (optional) 
            var generationCodeSuffix = generationCodeSuffix_example;  // string | An appendage, if any, used to denote an individual's generation in his family (e.g., Jr., Sr., III). (optional) 
            var id = id_example;  // string |  (optional) 
            var lastSurname = lastSurname_example;  // string | The name borne in common by members of a family. (optional) 
            var loginId = loginId_example;  // string | The login ID for the user; used for security access control interface. (optional) 
            var maidenName = maidenName_example;  // string | The person's maiden name. (optional) 
            var middleName = middleName_example;  // string | A secondary name given to an individual at birth, baptism, or during another naming ceremony. (optional) 
            var personalTitlePrefix = personalTitlePrefix_example;  // string | A prefix used to denote the title, degree, position, or seniority of the person. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiParent&gt; result = apiInstance.GetParents(offset, limit, totalCount, parentUniqueId, sexDescriptor, firstName, generationCodeSuffix, id, lastSurname, loginId, maidenName, middleName, personalTitlePrefix);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParentsApi.GetParents: " + e.Message );
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
 **parentUniqueId** | **string**| A unique alphanumeric code assigned to a parent. | [optional] 
 **sexDescriptor** | **string**| A person&#39;s gender. | [optional] 
 **firstName** | **string**| A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. | [optional] 
 **generationCodeSuffix** | **string**| An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III). | [optional] 
 **id** | **string**|  | [optional] 
 **lastSurname** | **string**| The name borne in common by members of a family. | [optional] 
 **loginId** | **string**| The login ID for the user; used for security access control interface. | [optional] 
 **maidenName** | **string**| The person&#39;s maiden name. | [optional] 
 **middleName** | **string**| A secondary name given to an individual at birth, baptism, or during another naming ceremony. | [optional] 
 **personalTitlePrefix** | **string**| A prefix used to denote the title, degree, position, or seniority of the person. | [optional] 

### Return type

[**List<EdFiParent>**](EdFiParent.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparentsbyid"></a>
# **GetParentsById**
> EdFiParent GetParentsById (string id, string ifNoneMatch = null)

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
    public class GetParentsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ParentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiParent result = apiInstance.GetParentsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParentsApi.GetParentsById: " + e.Message );
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

[**EdFiParent**](EdFiParent.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postparent"></a>
# **PostParent**
> void PostParent (EdFiParent parent)

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
    public class PostParentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ParentsApi();
            var parent = new EdFiParent(); // EdFiParent | The JSON representation of the \"parent\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostParent(parent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParentsApi.PostParent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parent** | [**EdFiParent**](EdFiParent.md)| The JSON representation of the \&quot;parent\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putparent"></a>
# **PutParent**
> void PutParent (string id, EdFiParent parent, string ifMatch = null)

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
    public class PutParentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ParentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var parent = new EdFiParent(); // EdFiParent | The JSON representation of the \"parent\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutParent(id, parent, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParentsApi.PutParent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **parent** | [**EdFiParent**](EdFiParent.md)| The JSON representation of the \&quot;parent\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

