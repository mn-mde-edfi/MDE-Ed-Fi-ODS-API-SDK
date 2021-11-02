# EdFi.OdsApi.Sdk.Apis.Identity.SurveyQuestionsApi

All URIs are relative to *http://localhost:54746/data/v3/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSurveyQuestionById**](SurveyQuestionsApi.md#deletesurveyquestionbyid) | **DELETE** /ed-fi/surveyQuestions/{id} | Deletes an existing resource using the resource identifier.
[**DeletesSurveyQuestions**](SurveyQuestionsApi.md#deletessurveyquestions) | **GET** /ed-fi/surveyQuestions/deletes | Retrieves deleted resources based on change version.
[**GetSurveyQuestions**](SurveyQuestionsApi.md#getsurveyquestions) | **GET** /ed-fi/surveyQuestions | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetSurveyQuestionsById**](SurveyQuestionsApi.md#getsurveyquestionsbyid) | **GET** /ed-fi/surveyQuestions/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostSurveyQuestion**](SurveyQuestionsApi.md#postsurveyquestion) | **POST** /ed-fi/surveyQuestions | Creates or updates resources based on the natural key values of the supplied resource.
[**PutSurveyQuestion**](SurveyQuestionsApi.md#putsurveyquestion) | **PUT** /ed-fi/surveyQuestions/{id} | Updates a resource based on the resource identifier.


<a name="deletesurveyquestionbyid"></a>
# **DeleteSurveyQuestionById**
> void DeleteSurveyQuestionById (string id, string ifMatch = null)

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
    public class DeleteSurveyQuestionByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SurveyQuestionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteSurveyQuestionById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SurveyQuestionsApi.DeleteSurveyQuestionById: " + e.Message );
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

<a name="deletessurveyquestions"></a>
# **DeletesSurveyQuestions**
> List<DeletedResource> DeletesSurveyQuestions (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, string snapshotIdentifier = null)

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
    public class DeletesSurveyQuestionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SurveyQuestionsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List&lt;DeletedResource&gt; result = apiInstance.DeletesSurveyQuestions(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SurveyQuestionsApi.DeletesSurveyQuestions: " + e.Message );
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

<a name="getsurveyquestions"></a>
# **GetSurveyQuestions**
> List<EdFiSurveyQuestion> GetSurveyQuestions (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, bool? totalCount = null, string questionCode = null, string _namespace = null, string surveyIdentifier = null, string surveySectionTitle = null, string questionFormDescriptor = null, string id = null, string questionText = null, string snapshotIdentifier = null)

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
    public class GetSurveyQuestionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SurveyQuestionsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var questionCode = questionCode_example;  // string | The identifying code for the question, unique for the survey. (optional) 
            var _namespace = _namespace_example;  // string | Namespace for the Survey. (optional) 
            var surveyIdentifier = surveyIdentifier_example;  // string | The unique survey identifier from the survey tool. (optional) 
            var surveySectionTitle = surveySectionTitle_example;  // string | The title or label for the survey section. (optional) 
            var questionFormDescriptor = questionFormDescriptor_example;  // string | The form or type of question. (optional) 
            var id = id_example;  // string |  (optional) 
            var questionText = questionText_example;  // string | The text of the question. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiSurveyQuestion&gt; result = apiInstance.GetSurveyQuestions(offset, limit, minChangeVersion, maxChangeVersion, totalCount, questionCode, _namespace, surveyIdentifier, surveySectionTitle, questionFormDescriptor, id, questionText, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SurveyQuestionsApi.GetSurveyQuestions: " + e.Message );
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
 **questionCode** | **string**| The identifying code for the question, unique for the survey. | [optional] 
 **_namespace** | **string**| Namespace for the Survey. | [optional] 
 **surveyIdentifier** | **string**| The unique survey identifier from the survey tool. | [optional] 
 **surveySectionTitle** | **string**| The title or label for the survey section. | [optional] 
 **questionFormDescriptor** | **string**| The form or type of question. | [optional] 
 **id** | **string**|  | [optional] 
 **questionText** | **string**| The text of the question. | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<EdFiSurveyQuestion>**](EdFiSurveyQuestion.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsurveyquestionsbyid"></a>
# **GetSurveyQuestionsById**
> EdFiSurveyQuestion GetSurveyQuestionsById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

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
    public class GetSurveyQuestionsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SurveyQuestionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiSurveyQuestion result = apiInstance.GetSurveyQuestionsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SurveyQuestionsApi.GetSurveyQuestionsById: " + e.Message );
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

[**EdFiSurveyQuestion**](EdFiSurveyQuestion.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsurveyquestion"></a>
# **PostSurveyQuestion**
> void PostSurveyQuestion (EdFiSurveyQuestion surveyQuestion)

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
    public class PostSurveyQuestionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SurveyQuestionsApi();
            var surveyQuestion = new EdFiSurveyQuestion(); // EdFiSurveyQuestion | The JSON representation of the \"surveyQuestion\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostSurveyQuestion(surveyQuestion);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SurveyQuestionsApi.PostSurveyQuestion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **surveyQuestion** | [**EdFiSurveyQuestion**](EdFiSurveyQuestion.md)| The JSON representation of the \&quot;surveyQuestion\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsurveyquestion"></a>
# **PutSurveyQuestion**
> void PutSurveyQuestion (string id, EdFiSurveyQuestion surveyQuestion, string ifMatch = null)

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
    public class PutSurveyQuestionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SurveyQuestionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var surveyQuestion = new EdFiSurveyQuestion(); // EdFiSurveyQuestion | The JSON representation of the \"surveyQuestion\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutSurveyQuestion(id, surveyQuestion, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SurveyQuestionsApi.PutSurveyQuestion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **surveyQuestion** | [**EdFiSurveyQuestion**](EdFiSurveyQuestion.md)| The JSON representation of the \&quot;surveyQuestion\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

