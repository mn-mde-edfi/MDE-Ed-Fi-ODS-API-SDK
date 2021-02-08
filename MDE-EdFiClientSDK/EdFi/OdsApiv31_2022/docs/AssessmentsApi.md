# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile.AssessmentsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/sb21_/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteassessmentById**](AssessmentsApi.md#deleteassessmentbyid) | **DELETE** /ed-fi/assessments/{id} | Deletes an existing resource using the resource identifier.
[**GetAssessments**](AssessmentsApi.md#getassessments) | **GET** /ed-fi/assessments | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetAssessmentsById**](AssessmentsApi.md#getassessmentsbyid) | **GET** /ed-fi/assessments/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**Postassessment**](AssessmentsApi.md#postassessment) | **POST** /ed-fi/assessments | Creates or updates resources based on the natural key values of the supplied resource.
[**Putassessment**](AssessmentsApi.md#putassessment) | **PUT** /ed-fi/assessments/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteassessmentbyid"></a>
# **DeleteassessmentById**
> void DeleteassessmentById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class DeleteassessmentByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteassessmentById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentsApi.DeleteassessmentById: " + e.Message );
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

 - **Content-Type**: application/vnd.ed-fi.assessment.minnesota-preview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassessments"></a>
# **GetAssessments**
> List<EdFiAssessmentReadable> GetAssessments (int? offset = null, int? limit = null, bool? totalCount = null, string assessmentIdentifier = null, string _namespace = null, int? educationOrganizationId = null, string assessmentCategoryDescriptor = null, bool? adaptiveAssessment = null, string assessmentFamily = null, string assessmentForm = null, string assessmentTitle = null, int? assessmentVersion = null, string id = null, int? maxRawScore = null, string nomenclature = null, DateTime? revisionDate = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class GetAssessmentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var assessmentIdentifier = assessmentIdentifier_example;  // string | A unique number or alphanumeric code assigned to an assessment. (optional) 
            var _namespace = _namespace_example;  // string | Namespace for the Assessment. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var assessmentCategoryDescriptor = assessmentCategoryDescriptor_example;  // string | The category of an assessment based on format and content. For example:          Achievement test          Advanced placement test          Alternate assessment/grade-level standards          Attitudinal test          Cognitive and perceptual skills test          ... (optional) 
            var adaptiveAssessment = true;  // bool? | Indicates that the assessment is adaptive. (optional) 
            var assessmentFamily = assessmentFamily_example;  // string | The AssessmentFamily this Assessment is a member of. (optional) 
            var assessmentForm = assessmentForm_example;  // string | Identifies the form of the assessment, for example a regular versus makeup form, multiple choice versus constructed response, etc. (optional) 
            var assessmentTitle = assessmentTitle_example;  // string | The title or name of the Assessment. (optional) 
            var assessmentVersion = 56;  // int? | The version identifier for the assessment. (optional) 
            var id = id_example;  // string |  (optional) 
            var maxRawScore = 56;  // int? | The maximum raw score achievable across all assessment items that are correct and scored at the maximum. (optional) 
            var nomenclature = nomenclature_example;  // string | Reflects the specific nomenclature used for Assessment. (optional) 
            var revisionDate = 2013-10-20;  // DateTime? | The month, day, and year that the conceptual design for the assessment was most recently revised substantially. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiAssessmentReadable&gt; result = apiInstance.GetAssessments(offset, limit, totalCount, assessmentIdentifier, _namespace, educationOrganizationId, assessmentCategoryDescriptor, adaptiveAssessment, assessmentFamily, assessmentForm, assessmentTitle, assessmentVersion, id, maxRawScore, nomenclature, revisionDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentsApi.GetAssessments: " + e.Message );
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
 **assessmentIdentifier** | **string**| A unique number or alphanumeric code assigned to an assessment. | [optional] 
 **_namespace** | **string**| Namespace for the Assessment. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **assessmentCategoryDescriptor** | **string**| The category of an assessment based on format and content. For example:          Achievement test          Advanced placement test          Alternate assessment/grade-level standards          Attitudinal test          Cognitive and perceptual skills test          ... | [optional] 
 **adaptiveAssessment** | **bool?**| Indicates that the assessment is adaptive. | [optional] 
 **assessmentFamily** | **string**| The AssessmentFamily this Assessment is a member of. | [optional] 
 **assessmentForm** | **string**| Identifies the form of the assessment, for example a regular versus makeup form, multiple choice versus constructed response, etc. | [optional] 
 **assessmentTitle** | **string**| The title or name of the Assessment. | [optional] 
 **assessmentVersion** | **int?**| The version identifier for the assessment. | [optional] 
 **id** | **string**|  | [optional] 
 **maxRawScore** | **int?**| The maximum raw score achievable across all assessment items that are correct and scored at the maximum. | [optional] 
 **nomenclature** | **string**| Reflects the specific nomenclature used for Assessment. | [optional] 
 **revisionDate** | **DateTime?**| The month, day, and year that the conceptual design for the assessment was most recently revised substantially. | [optional] 

### Return type

[**List<EdFiAssessmentReadable>**](EdFiAssessmentReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.assessment.minnesota-preview-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassessmentsbyid"></a>
# **GetAssessmentsById**
> EdFiAssessmentReadable GetAssessmentsById (string id, string ifNoneMatch = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class GetAssessmentsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiAssessmentReadable result = apiInstance.GetAssessmentsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentsApi.GetAssessmentsById: " + e.Message );
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

[**EdFiAssessmentReadable**](EdFiAssessmentReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.assessment.minnesota-preview-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postassessment"></a>
# **Postassessment**
> void Postassessment (EdFiAssessmentWritable assessment)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error (you must use a PUT operation to update a resource by \"id\"). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class PostassessmentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentsApi();
            var assessment = new EdFiAssessmentWritable(); // EdFiAssessmentWritable | The JSON representation of the \"assessment\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.Postassessment(assessment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentsApi.Postassessment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assessment** | [**EdFiAssessmentWritable**](EdFiAssessmentWritable.md)| The JSON representation of the \&quot;assessment\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.assessment.minnesota-preview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putassessment"></a>
# **Putassessment**
> void Putassessment (string id, EdFiAssessmentWritable assessment, string ifMatch = null)

Updates or creates a resource based on the resource identifier.

The PUT operation is used to update or create a resource by identifier. If the resource doesn't exist, the resource will be created using that identifier. Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource \"id\" is provided in the JSON body, it will be ignored as well.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile;

namespace Example
{
    public class PutassessmentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AssessmentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var assessment = new EdFiAssessmentWritable(); // EdFiAssessmentWritable | The JSON representation of the \"assessment\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.Putassessment(id, assessment, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AssessmentsApi.Putassessment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **assessment** | [**EdFiAssessmentWritable**](EdFiAssessmentWritable.md)| The JSON representation of the \&quot;assessment\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.assessment.minnesota-preview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

