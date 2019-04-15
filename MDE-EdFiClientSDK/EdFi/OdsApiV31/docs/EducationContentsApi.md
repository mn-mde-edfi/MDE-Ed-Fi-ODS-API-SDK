# EdFi.OdsApi.Sdk.Apis.All.EducationContentsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteEducationContentById**](EducationContentsApi.md#deleteeducationcontentbyid) | **DELETE** /ed-fi/educationContents/{id} | Deletes an existing resource using the resource identifier.
[**GetEducationContents**](EducationContentsApi.md#geteducationcontents) | **GET** /ed-fi/educationContents | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetEducationContentsById**](EducationContentsApi.md#geteducationcontentsbyid) | **GET** /ed-fi/educationContents/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostEducationContent**](EducationContentsApi.md#posteducationcontent) | **POST** /ed-fi/educationContents | Creates or updates resources based on the natural key values of the supplied resource.
[**PutEducationContent**](EducationContentsApi.md#puteducationcontent) | **PUT** /ed-fi/educationContents/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteeducationcontentbyid"></a>
# **DeleteEducationContentById**
> void DeleteEducationContentById (string id, string ifMatch = null)

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
    public class DeleteEducationContentByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationContentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteEducationContentById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationContentsApi.DeleteEducationContentById: " + e.Message );
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

<a name="geteducationcontents"></a>
# **GetEducationContents**
> List<EdFiEducationContent> GetEducationContents (int? offset = null, int? limit = null, bool? totalCount = null, string contentIdentifier = null, string learningStandardId = null, string contentClassDescriptor = null, string costRateDescriptor = null, string interactivityStyleDescriptor = null, bool? additionalAuthorsIndicator = null, double? cost = null, string description = null, string id = null, string learningResourceMetadataURI = null, string _namespace = null, DateTime? publicationDate = null, int? publicationYear = null, string publisher = null, string shortDescription = null, string timeRequired = null, string useRightsURL = null, string version = null)

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
    public class GetEducationContentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationContentsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var contentIdentifier = contentIdentifier_example;  // string | A unique identifier for the EducationContent. (optional) 
            var learningStandardId = learningStandardId_example;  // string | The identifier for the specific learning standard (e.g., 111.15.3.1.A). (optional) 
            var contentClassDescriptor = contentClassDescriptor_example;  // string | The predominate type or kind characterizing the learning resource. (optional) 
            var costRateDescriptor = costRateDescriptor_example;  // string | The rate by which the cost applies. (optional) 
            var interactivityStyleDescriptor = interactivityStyleDescriptor_example;  // string | The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed. (optional) 
            var additionalAuthorsIndicator = true;  // bool? | Indicates whether there are additional un-named authors. In a research report, this is often marked by the abbreviation \"et al\". (optional) 
            var cost = 1.2;  // double? | An amount that has to be paid or spent to buy or obtain the EducationContent. (optional) 
            var description = description_example;  // string | An extended written representation of the education content. (optional) 
            var id = id_example;  // string |  (optional) 
            var learningResourceMetadataURI = learningResourceMetadataURI_example;  // string | The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item. (optional) 
            var _namespace = _namespace_example;  // string | Namespace for the EducationContent. (optional) 
            var publicationDate = 2013-10-20;  // DateTime? | The date on which this content was first published. (optional) 
            var publicationYear = 56;  // int? | The year at which this content was first published. (optional) 
            var publisher = publisher_example;  // string | The organization credited with publishing the resource. (optional) 
            var shortDescription = shortDescription_example;  // string | A short description or name of the entity. (optional) 
            var timeRequired = timeRequired_example;  // string | Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience. (optional) 
            var useRightsURL = useRightsURL_example;  // string | The URL where the owner specifies permissions for using the resource. (optional) 
            var version = version_example;  // string | The version identifier for the content. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiEducationContent&gt; result = apiInstance.GetEducationContents(offset, limit, totalCount, contentIdentifier, learningStandardId, contentClassDescriptor, costRateDescriptor, interactivityStyleDescriptor, additionalAuthorsIndicator, cost, description, id, learningResourceMetadataURI, _namespace, publicationDate, publicationYear, publisher, shortDescription, timeRequired, useRightsURL, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationContentsApi.GetEducationContents: " + e.Message );
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
 **contentIdentifier** | **string**| A unique identifier for the EducationContent. | [optional] 
 **learningStandardId** | **string**| The identifier for the specific learning standard (e.g., 111.15.3.1.A). | [optional] 
 **contentClassDescriptor** | **string**| The predominate type or kind characterizing the learning resource. | [optional] 
 **costRateDescriptor** | **string**| The rate by which the cost applies. | [optional] 
 **interactivityStyleDescriptor** | **string**| The predominate mode of learning supported by the learning resource. Acceptable values are active, expositive, or mixed. | [optional] 
 **additionalAuthorsIndicator** | **bool?**| Indicates whether there are additional un-named authors. In a research report, this is often marked by the abbreviation \&quot;et al\&quot;. | [optional] 
 **cost** | **double?**| An amount that has to be paid or spent to buy or obtain the EducationContent. | [optional] 
 **description** | **string**| An extended written representation of the education content. | [optional] 
 **id** | **string**|  | [optional] 
 **learningResourceMetadataURI** | **string**| The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item. | [optional] 
 **_namespace** | **string**| Namespace for the EducationContent. | [optional] 
 **publicationDate** | **DateTime?**| The date on which this content was first published. | [optional] 
 **publicationYear** | **int?**| The year at which this content was first published. | [optional] 
 **publisher** | **string**| The organization credited with publishing the resource. | [optional] 
 **shortDescription** | **string**| A short description or name of the entity. | [optional] 
 **timeRequired** | **string**| Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience. | [optional] 
 **useRightsURL** | **string**| The URL where the owner specifies permissions for using the resource. | [optional] 
 **version** | **string**| The version identifier for the content. | [optional] 

### Return type

[**List<EdFiEducationContent>**](EdFiEducationContent.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteducationcontentsbyid"></a>
# **GetEducationContentsById**
> EdFiEducationContent GetEducationContentsById (string id, string ifNoneMatch = null)

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
    public class GetEducationContentsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationContentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiEducationContent result = apiInstance.GetEducationContentsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationContentsApi.GetEducationContentsById: " + e.Message );
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

[**EdFiEducationContent**](EdFiEducationContent.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posteducationcontent"></a>
# **PostEducationContent**
> void PostEducationContent (EdFiEducationContent educationContent)

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
    public class PostEducationContentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationContentsApi();
            var educationContent = new EdFiEducationContent(); // EdFiEducationContent | The JSON representation of the \"educationContent\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostEducationContent(educationContent);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationContentsApi.PostEducationContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **educationContent** | [**EdFiEducationContent**](EdFiEducationContent.md)| The JSON representation of the \&quot;educationContent\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="puteducationcontent"></a>
# **PutEducationContent**
> void PutEducationContent (string id, EdFiEducationContent educationContent, string ifMatch = null)

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
    public class PutEducationContentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EducationContentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var educationContent = new EdFiEducationContent(); // EdFiEducationContent | The JSON representation of the \"educationContent\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutEducationContent(id, educationContent, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EducationContentsApi.PutEducationContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **educationContent** | [**EdFiEducationContent**](EdFiEducationContent.md)| The JSON representation of the \&quot;educationContent\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

