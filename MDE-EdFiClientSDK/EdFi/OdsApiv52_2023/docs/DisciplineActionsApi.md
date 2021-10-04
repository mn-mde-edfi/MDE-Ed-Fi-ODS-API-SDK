# EdFi.OdsApi.Sdk.Apis.Identity.DisciplineActionsApi

All URIs are relative to *http://localhost:54746/data/v3/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteDisciplineActionById**](DisciplineActionsApi.md#deletedisciplineactionbyid) | **DELETE** /ed-fi/disciplineActions/{id} | Deletes an existing resource using the resource identifier.
[**DeletesDisciplineActions**](DisciplineActionsApi.md#deletesdisciplineactions) | **GET** /ed-fi/disciplineActions/deletes | Retrieves deleted resources based on change version.
[**GetDisciplineActions**](DisciplineActionsApi.md#getdisciplineactions) | **GET** /ed-fi/disciplineActions | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetDisciplineActionsById**](DisciplineActionsApi.md#getdisciplineactionsbyid) | **GET** /ed-fi/disciplineActions/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostDisciplineAction**](DisciplineActionsApi.md#postdisciplineaction) | **POST** /ed-fi/disciplineActions | Creates or updates resources based on the natural key values of the supplied resource.
[**PutDisciplineAction**](DisciplineActionsApi.md#putdisciplineaction) | **PUT** /ed-fi/disciplineActions/{id} | Updates a resource based on the resource identifier.


<a name="deletedisciplineactionbyid"></a>
# **DeleteDisciplineActionById**
> void DeleteDisciplineActionById (string id, string ifMatch = null)

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
    public class DeleteDisciplineActionByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisciplineActionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteDisciplineActionById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisciplineActionsApi.DeleteDisciplineActionById: " + e.Message );
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

<a name="deletesdisciplineactions"></a>
# **DeletesDisciplineActions**
> List<DeletedResource> DeletesDisciplineActions (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, string snapshotIdentifier = null)

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
    public class DeletesDisciplineActionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisciplineActionsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List&lt;DeletedResource&gt; result = apiInstance.DeletesDisciplineActions(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisciplineActionsApi.DeletesDisciplineActions: " + e.Message );
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

<a name="getdisciplineactions"></a>
# **GetDisciplineActions**
> List<EdFiDisciplineAction> GetDisciplineActions (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, bool? totalCount = null, string disciplineActionIdentifier = null, DateTime? disciplineDate = null, string studentUniqueId = null, int? responsibilitySchoolId = null, int? assignmentSchoolId = null, string disciplineActionLengthDifferenceReasonDescriptor = null, double? actualDisciplineActionLength = null, double? disciplineActionLength = null, string id = null, bool? iepPlacementMeetingIndicator = null, bool? receivedEducationServicesDuringExpulsion = null, bool? relatedToZeroTolerancePolicy = null, string snapshotIdentifier = null)

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
    public class GetDisciplineActionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisciplineActionsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var disciplineActionIdentifier = disciplineActionIdentifier_example;  // string | Identifier assigned by the education organization to the DisciplineAction. (optional) 
            var disciplineDate = 2013-10-20;  // DateTime? | The date of the DisciplineAction. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var responsibilitySchoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var assignmentSchoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var disciplineActionLengthDifferenceReasonDescriptor = disciplineActionLengthDifferenceReasonDescriptor_example;  // string | Indicates the reason for the difference, if any, between the official and actual lengths of a student's disciplinary assignment. (optional) 
            var actualDisciplineActionLength = 1.2;  // double? | Indicates the actual length in school days of a student's disciplinary assignment. (optional) 
            var disciplineActionLength = 1.2;  // double? | The length of time in school days for the DisciplineAction (e.g. removal, detention), if applicable. (optional) 
            var id = id_example;  // string |  (optional) 
            var iepPlacementMeetingIndicator = true;  // bool? | An indication as to whether an offense and/or disciplinary action resulted in a meeting of a student's Individualized Education Program (IEP) team to determine appropriate placement. (optional) 
            var receivedEducationServicesDuringExpulsion = true;  // bool? | An indication of whether the student received educational services when removed from the regular school program for disciplinary reasons. (optional) 
            var relatedToZeroTolerancePolicy = true;  // bool? | An indication of whether or not this disciplinary action taken against a student was imposed as a consequence of state or local zero tolerance policies. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiDisciplineAction&gt; result = apiInstance.GetDisciplineActions(offset, limit, minChangeVersion, maxChangeVersion, totalCount, disciplineActionIdentifier, disciplineDate, studentUniqueId, responsibilitySchoolId, assignmentSchoolId, disciplineActionLengthDifferenceReasonDescriptor, actualDisciplineActionLength, disciplineActionLength, id, iepPlacementMeetingIndicator, receivedEducationServicesDuringExpulsion, relatedToZeroTolerancePolicy, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisciplineActionsApi.GetDisciplineActions: " + e.Message );
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
 **disciplineActionIdentifier** | **string**| Identifier assigned by the education organization to the DisciplineAction. | [optional] 
 **disciplineDate** | **DateTime?**| The date of the DisciplineAction. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **responsibilitySchoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **assignmentSchoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **disciplineActionLengthDifferenceReasonDescriptor** | **string**| Indicates the reason for the difference, if any, between the official and actual lengths of a student&#39;s disciplinary assignment. | [optional] 
 **actualDisciplineActionLength** | **double?**| Indicates the actual length in school days of a student&#39;s disciplinary assignment. | [optional] 
 **disciplineActionLength** | **double?**| The length of time in school days for the DisciplineAction (e.g. removal, detention), if applicable. | [optional] 
 **id** | **string**|  | [optional] 
 **iepPlacementMeetingIndicator** | **bool?**| An indication as to whether an offense and/or disciplinary action resulted in a meeting of a student&#39;s Individualized Education Program (IEP) team to determine appropriate placement. | [optional] 
 **receivedEducationServicesDuringExpulsion** | **bool?**| An indication of whether the student received educational services when removed from the regular school program for disciplinary reasons. | [optional] 
 **relatedToZeroTolerancePolicy** | **bool?**| An indication of whether or not this disciplinary action taken against a student was imposed as a consequence of state or local zero tolerance policies. | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<EdFiDisciplineAction>**](EdFiDisciplineAction.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdisciplineactionsbyid"></a>
# **GetDisciplineActionsById**
> EdFiDisciplineAction GetDisciplineActionsById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

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
    public class GetDisciplineActionsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisciplineActionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiDisciplineAction result = apiInstance.GetDisciplineActionsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisciplineActionsApi.GetDisciplineActionsById: " + e.Message );
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

[**EdFiDisciplineAction**](EdFiDisciplineAction.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdisciplineaction"></a>
# **PostDisciplineAction**
> void PostDisciplineAction (EdFiDisciplineAction disciplineAction)

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
    public class PostDisciplineActionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisciplineActionsApi();
            var disciplineAction = new EdFiDisciplineAction(); // EdFiDisciplineAction | The JSON representation of the \"disciplineAction\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostDisciplineAction(disciplineAction);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisciplineActionsApi.PostDisciplineAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **disciplineAction** | [**EdFiDisciplineAction**](EdFiDisciplineAction.md)| The JSON representation of the \&quot;disciplineAction\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putdisciplineaction"></a>
# **PutDisciplineAction**
> void PutDisciplineAction (string id, EdFiDisciplineAction disciplineAction, string ifMatch = null)

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
    public class PutDisciplineActionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisciplineActionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var disciplineAction = new EdFiDisciplineAction(); // EdFiDisciplineAction | The JSON representation of the \"disciplineAction\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutDisciplineAction(id, disciplineAction, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisciplineActionsApi.PutDisciplineAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **disciplineAction** | [**EdFiDisciplineAction**](EdFiDisciplineAction.md)| The JSON representation of the \&quot;disciplineAction\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

