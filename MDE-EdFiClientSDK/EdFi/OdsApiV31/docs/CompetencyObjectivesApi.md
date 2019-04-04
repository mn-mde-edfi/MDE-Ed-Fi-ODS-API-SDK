# EdFi.OdsApi.Sdk.Apis.All.CompetencyObjectivesApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCompetencyObjectiveById**](CompetencyObjectivesApi.md#deletecompetencyobjectivebyid) | **DELETE** /ed-fi/competencyObjectives/{id} | Deletes an existing resource using the resource identifier.
[**GetCompetencyObjectives**](CompetencyObjectivesApi.md#getcompetencyobjectives) | **GET** /ed-fi/competencyObjectives | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetCompetencyObjectivesById**](CompetencyObjectivesApi.md#getcompetencyobjectivesbyid) | **GET** /ed-fi/competencyObjectives/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostCompetencyObjective**](CompetencyObjectivesApi.md#postcompetencyobjective) | **POST** /ed-fi/competencyObjectives | Creates or updates resources based on the natural key values of the supplied resource.
[**PutCompetencyObjective**](CompetencyObjectivesApi.md#putcompetencyobjective) | **PUT** /ed-fi/competencyObjectives/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletecompetencyobjectivebyid"></a>
# **DeleteCompetencyObjectiveById**
> void DeleteCompetencyObjectiveById (string id, string ifMatch = null)

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
    public class DeleteCompetencyObjectiveByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CompetencyObjectivesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteCompetencyObjectiveById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompetencyObjectivesApi.DeleteCompetencyObjectiveById: " + e.Message );
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

<a name="getcompetencyobjectives"></a>
# **GetCompetencyObjectives**
> List<EdFiCompetencyObjective> GetCompetencyObjectives (int? offset = null, int? limit = null, bool? totalCount = null, string objectiveGradeLevelDescriptor = null, string objective = null, int? educationOrganizationId = null, string competencyObjectiveId = null, string description = null, string id = null, string successCriteria = null)

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
    public class GetCompetencyObjectivesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CompetencyObjectivesApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var objectiveGradeLevelDescriptor = objectiveGradeLevelDescriptor_example;  // string | The grade level for which the CompetencyObjective is targeted. (optional) 
            var objective = objective_example;  // string | The designated title of the CompetencyObjective. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var competencyObjectiveId = competencyObjectiveId_example;  // string | The Identifier for the CompetencyObjective. (optional) 
            var description = description_example;  // string | The description of the student competency objective. (optional) 
            var id = id_example;  // string |  (optional) 
            var successCriteria = successCriteria_example;  // string | One or more statements that describes the criteria used by teachers and students to check for attainment of a competency objective. This criteria gives clear indications as to the degree to which learning is moving through the Zone or Proximal Development toward independent achievement of the CompetencyObjective. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiCompetencyObjective&gt; result = apiInstance.GetCompetencyObjectives(offset, limit, totalCount, objectiveGradeLevelDescriptor, objective, educationOrganizationId, competencyObjectiveId, description, id, successCriteria);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompetencyObjectivesApi.GetCompetencyObjectives: " + e.Message );
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
 **objectiveGradeLevelDescriptor** | **string**| The grade level for which the CompetencyObjective is targeted. | [optional] 
 **objective** | **string**| The designated title of the CompetencyObjective. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **competencyObjectiveId** | **string**| The Identifier for the CompetencyObjective. | [optional] 
 **description** | **string**| The description of the student competency objective. | [optional] 
 **id** | **string**|  | [optional] 
 **successCriteria** | **string**| One or more statements that describes the criteria used by teachers and students to check for attainment of a competency objective. This criteria gives clear indications as to the degree to which learning is moving through the Zone or Proximal Development toward independent achievement of the CompetencyObjective. | [optional] 

### Return type

[**List<EdFiCompetencyObjective>**](EdFiCompetencyObjective.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcompetencyobjectivesbyid"></a>
# **GetCompetencyObjectivesById**
> EdFiCompetencyObjective GetCompetencyObjectivesById (string id, string ifNoneMatch = null)

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
    public class GetCompetencyObjectivesByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CompetencyObjectivesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiCompetencyObjective result = apiInstance.GetCompetencyObjectivesById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompetencyObjectivesApi.GetCompetencyObjectivesById: " + e.Message );
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

[**EdFiCompetencyObjective**](EdFiCompetencyObjective.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcompetencyobjective"></a>
# **PostCompetencyObjective**
> void PostCompetencyObjective (EdFiCompetencyObjective competencyObjective)

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
    public class PostCompetencyObjectiveExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CompetencyObjectivesApi();
            var competencyObjective = new EdFiCompetencyObjective(); // EdFiCompetencyObjective | The JSON representation of the \"competencyObjective\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostCompetencyObjective(competencyObjective);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompetencyObjectivesApi.PostCompetencyObjective: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **competencyObjective** | [**EdFiCompetencyObjective**](EdFiCompetencyObjective.md)| The JSON representation of the \&quot;competencyObjective\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcompetencyobjective"></a>
# **PutCompetencyObjective**
> void PutCompetencyObjective (string id, EdFiCompetencyObjective competencyObjective, string ifMatch = null)

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
    public class PutCompetencyObjectiveExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CompetencyObjectivesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var competencyObjective = new EdFiCompetencyObjective(); // EdFiCompetencyObjective | The JSON representation of the \"competencyObjective\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutCompetencyObjective(id, competencyObjective, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompetencyObjectivesApi.PutCompetencyObjective: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **competencyObjective** | [**EdFiCompetencyObjective**](EdFiCompetencyObjective.md)| The JSON representation of the \&quot;competencyObjective\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

