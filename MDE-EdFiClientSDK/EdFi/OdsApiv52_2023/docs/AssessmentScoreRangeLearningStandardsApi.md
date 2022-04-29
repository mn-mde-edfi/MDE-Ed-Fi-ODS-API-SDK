# EdFi.OdsApi.Sdk.Apis.Identity.AssessmentScoreRangeLearningStandardsApi

All URIs are relative to *https://test.edfi5.education.mn.gov:443/api/data/v3/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteAssessmentScoreRangeLearningStandardById**](AssessmentScoreRangeLearningStandardsApi.md#deleteassessmentscorerangelearningstandardbyid) | **DELETE** /ed-fi/assessmentScoreRangeLearningStandards/{id} | Deletes an existing resource using the resource identifier.
[**DeletesAssessmentScoreRangeLearningStandards**](AssessmentScoreRangeLearningStandardsApi.md#deletesassessmentscorerangelearningstandards) | **GET** /ed-fi/assessmentScoreRangeLearningStandards/deletes | Retrieves deleted resources based on change version.
[**GetAssessmentScoreRangeLearningStandards**](AssessmentScoreRangeLearningStandardsApi.md#getassessmentscorerangelearningstandards) | **GET** /ed-fi/assessmentScoreRangeLearningStandards | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetAssessmentScoreRangeLearningStandardsById**](AssessmentScoreRangeLearningStandardsApi.md#getassessmentscorerangelearningstandardsbyid) | **GET** /ed-fi/assessmentScoreRangeLearningStandards/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostAssessmentScoreRangeLearningStandard**](AssessmentScoreRangeLearningStandardsApi.md#postassessmentscorerangelearningstandard) | **POST** /ed-fi/assessmentScoreRangeLearningStandards | Creates or updates resources based on the natural key values of the supplied resource.
[**PutAssessmentScoreRangeLearningStandard**](AssessmentScoreRangeLearningStandardsApi.md#putassessmentscorerangelearningstandard) | **PUT** /ed-fi/assessmentScoreRangeLearningStandards/{id} | Updates a resource based on the resource identifier.


<a name="deleteassessmentscorerangelearningstandardbyid"></a>
# **DeleteAssessmentScoreRangeLearningStandardById**
> void DeleteAssessmentScoreRangeLearningStandardById (string id, string ifMatch = null)

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
    public class DeleteAssessmentScoreRangeLearningStandardByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentScoreRangeLearningStandardsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteAssessmentScoreRangeLearningStandardById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentScoreRangeLearningStandardsApi.DeleteAssessmentScoreRangeLearningStandardById: " + e.Message );
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

<a name="deletesassessmentscorerangelearningstandards"></a>
# **DeletesAssessmentScoreRangeLearningStandards**
> List<DeletedResource> DeletesAssessmentScoreRangeLearningStandards (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, string snapshotIdentifier = null)

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
    public class DeletesAssessmentScoreRangeLearningStandardsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentScoreRangeLearningStandardsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List&lt;DeletedResource&gt; result = apiInstance.DeletesAssessmentScoreRangeLearningStandards(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentScoreRangeLearningStandardsApi.DeletesAssessmentScoreRangeLearningStandards: " + e.Message );
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

<a name="getassessmentscorerangelearningstandards"></a>
# **GetAssessmentScoreRangeLearningStandards**
> List<EdFiAssessmentScoreRangeLearningStandard> GetAssessmentScoreRangeLearningStandards (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, bool? totalCount = null, string scoreRangeId = null, string assessmentIdentifier = null, string _namespace = null, string identificationCode = null, string assessmentReportingMethodDescriptor = null, string id = null, string maximumScore = null, string minimumScore = null, string snapshotIdentifier = null)

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
    public class GetAssessmentScoreRangeLearningStandardsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentScoreRangeLearningStandardsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var scoreRangeId = scoreRangeId_example;  // string | A unique number or alphanumeric code assigned to the score range associated with one or more learning standards. (optional) 
            var assessmentIdentifier = assessmentIdentifier_example;  // string | A unique number or alphanumeric code assigned to an assessment. (optional) 
            var _namespace = _namespace_example;  // string | Namespace for the Assessment. (optional) 
            var identificationCode = identificationCode_example;  // string | A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, a state, or other agency or entity. (optional) 
            var assessmentReportingMethodDescriptor = assessmentReportingMethodDescriptor_example;  // string | The assessment reporting method defined (e.g., scale score, RIT scale score) associated with the referenced learning standard(s). (optional) 
            var id = id_example;  // string |  (optional) 
            var maximumScore = maximumScore_example;  // string | The maximum score in the score range. (optional) 
            var minimumScore = minimumScore_example;  // string | The minimum score in the score range. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiAssessmentScoreRangeLearningStandard&gt; result = apiInstance.GetAssessmentScoreRangeLearningStandards(offset, limit, minChangeVersion, maxChangeVersion, totalCount, scoreRangeId, assessmentIdentifier, _namespace, identificationCode, assessmentReportingMethodDescriptor, id, maximumScore, minimumScore, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentScoreRangeLearningStandardsApi.GetAssessmentScoreRangeLearningStandards: " + e.Message );
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
 **scoreRangeId** | **string**| A unique number or alphanumeric code assigned to the score range associated with one or more learning standards. | [optional] 
 **assessmentIdentifier** | **string**| A unique number or alphanumeric code assigned to an assessment. | [optional] 
 **_namespace** | **string**| Namespace for the Assessment. | [optional] 
 **identificationCode** | **string**| A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, a state, or other agency or entity. | [optional] 
 **assessmentReportingMethodDescriptor** | **string**| The assessment reporting method defined (e.g., scale score, RIT scale score) associated with the referenced learning standard(s). | [optional] 
 **id** | **string**|  | [optional] 
 **maximumScore** | **string**| The maximum score in the score range. | [optional] 
 **minimumScore** | **string**| The minimum score in the score range. | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<EdFiAssessmentScoreRangeLearningStandard>**](EdFiAssessmentScoreRangeLearningStandard.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassessmentscorerangelearningstandardsbyid"></a>
# **GetAssessmentScoreRangeLearningStandardsById**
> EdFiAssessmentScoreRangeLearningStandard GetAssessmentScoreRangeLearningStandardsById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

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
    public class GetAssessmentScoreRangeLearningStandardsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentScoreRangeLearningStandardsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiAssessmentScoreRangeLearningStandard result = apiInstance.GetAssessmentScoreRangeLearningStandardsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentScoreRangeLearningStandardsApi.GetAssessmentScoreRangeLearningStandardsById: " + e.Message );
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

[**EdFiAssessmentScoreRangeLearningStandard**](EdFiAssessmentScoreRangeLearningStandard.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postassessmentscorerangelearningstandard"></a>
# **PostAssessmentScoreRangeLearningStandard**
> void PostAssessmentScoreRangeLearningStandard (EdFiAssessmentScoreRangeLearningStandard assessmentScoreRangeLearningStandard)

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
    public class PostAssessmentScoreRangeLearningStandardExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentScoreRangeLearningStandardsApi();
            var assessmentScoreRangeLearningStandard = new EdFiAssessmentScoreRangeLearningStandard(); // EdFiAssessmentScoreRangeLearningStandard | The JSON representation of the \"assessmentScoreRangeLearningStandard\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostAssessmentScoreRangeLearningStandard(assessmentScoreRangeLearningStandard);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentScoreRangeLearningStandardsApi.PostAssessmentScoreRangeLearningStandard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assessmentScoreRangeLearningStandard** | [**EdFiAssessmentScoreRangeLearningStandard**](EdFiAssessmentScoreRangeLearningStandard.md)| The JSON representation of the \&quot;assessmentScoreRangeLearningStandard\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putassessmentscorerangelearningstandard"></a>
# **PutAssessmentScoreRangeLearningStandard**
> void PutAssessmentScoreRangeLearningStandard (string id, EdFiAssessmentScoreRangeLearningStandard assessmentScoreRangeLearningStandard, string ifMatch = null)

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
    public class PutAssessmentScoreRangeLearningStandardExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentScoreRangeLearningStandardsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var assessmentScoreRangeLearningStandard = new EdFiAssessmentScoreRangeLearningStandard(); // EdFiAssessmentScoreRangeLearningStandard | The JSON representation of the \"assessmentScoreRangeLearningStandard\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutAssessmentScoreRangeLearningStandard(id, assessmentScoreRangeLearningStandard, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentScoreRangeLearningStandardsApi.PutAssessmentScoreRangeLearningStandard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **assessmentScoreRangeLearningStandard** | [**EdFiAssessmentScoreRangeLearningStandard**](EdFiAssessmentScoreRangeLearningStandard.md)| The JSON representation of the \&quot;assessmentScoreRangeLearningStandard\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

