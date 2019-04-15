# EdFi.OdsApi.Sdk.Apis.All.DisciplineIncidentsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteDisciplineIncidentById**](DisciplineIncidentsApi.md#deletedisciplineincidentbyid) | **DELETE** /ed-fi/disciplineIncidents/{id} | Deletes an existing resource using the resource identifier.
[**GetDisciplineIncidents**](DisciplineIncidentsApi.md#getdisciplineincidents) | **GET** /ed-fi/disciplineIncidents | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetDisciplineIncidentsById**](DisciplineIncidentsApi.md#getdisciplineincidentsbyid) | **GET** /ed-fi/disciplineIncidents/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostDisciplineIncident**](DisciplineIncidentsApi.md#postdisciplineincident) | **POST** /ed-fi/disciplineIncidents | Creates or updates resources based on the natural key values of the supplied resource.
[**PutDisciplineIncident**](DisciplineIncidentsApi.md#putdisciplineincident) | **PUT** /ed-fi/disciplineIncidents/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletedisciplineincidentbyid"></a>
# **DeleteDisciplineIncidentById**
> void DeleteDisciplineIncidentById (string id, string ifMatch = null)

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
    public class DeleteDisciplineIncidentByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisciplineIncidentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteDisciplineIncidentById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisciplineIncidentsApi.DeleteDisciplineIncidentById: " + e.Message );
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

<a name="getdisciplineincidents"></a>
# **GetDisciplineIncidents**
> List<EdFiDisciplineIncident> GetDisciplineIncidents (int? offset = null, int? limit = null, bool? totalCount = null, string incidentIdentifier = null, int? schoolId = null, string staffUniqueId = null, string incidentLocationDescriptor = null, string reporterDescriptionDescriptor = null, string caseNumber = null, string id = null, double? incidentCost = null, DateTime? incidentDate = null, string incidentDescription = null, string incidentTime = null, bool? reportedToLawEnforcement = null, string reporterName = null)

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
    public class GetDisciplineIncidentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisciplineIncidentsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var incidentIdentifier = incidentIdentifier_example;  // string | A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders. (optional) 
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var staffUniqueId = staffUniqueId_example;  // string | A unique alphanumeric code assigned to a staff. (optional) 
            var incidentLocationDescriptor = incidentLocationDescriptor_example;  // string | Identifies where the DisciplineIncident occurred and whether or not it occurred on school, for example:          On school          Administrative offices area          Cafeteria area          Classroom          Hallway or stairs          ... (optional) 
            var reporterDescriptionDescriptor = reporterDescriptionDescriptor_example;  // string | Information on the type of individual who reported the DisciplineIncident. When known and/or if useful, use a more specific option code (e.g., \"Counselor\" rather than \"Professional Staff\"); for example:          Student          Parent/guardian          Law enforcement officer          Nonschool personnel          Representative of visiting school          ... (optional) 
            var caseNumber = caseNumber_example;  // string | The case number assigned to the DisciplineIncident by law enforcement or other organization. (optional) 
            var id = id_example;  // string |  (optional) 
            var incidentCost = 1.2;  // double? | The value of any quantifiable monetary loss directly resulting from the DisciplineIncident. Examples include the value of repairs necessitated by vandalism of a school facility, or the value of personnel resources used for repairs or consumed by the incident. (optional) 
            var incidentDate = 2013-10-20;  // DateTime? | The month, day, and year on which the DisciplineIncident occurred. (optional) 
            var incidentDescription = incidentDescription_example;  // string | The description for an incident. (optional) 
            var incidentTime = incidentTime_example;  // string | An indication of the time of day the incident took place. (optional) 
            var reportedToLawEnforcement = true;  // bool? | Indicator of whether the incident was reported to law enforcement. (optional) 
            var reporterName = reporterName_example;  // string | Identifies the reporter of the DisciplineIncident by name. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiDisciplineIncident&gt; result = apiInstance.GetDisciplineIncidents(offset, limit, totalCount, incidentIdentifier, schoolId, staffUniqueId, incidentLocationDescriptor, reporterDescriptionDescriptor, caseNumber, id, incidentCost, incidentDate, incidentDescription, incidentTime, reportedToLawEnforcement, reporterName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisciplineIncidentsApi.GetDisciplineIncidents: " + e.Message );
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
 **incidentIdentifier** | **string**| A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders. | [optional] 
 **schoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **staffUniqueId** | **string**| A unique alphanumeric code assigned to a staff. | [optional] 
 **incidentLocationDescriptor** | **string**| Identifies where the DisciplineIncident occurred and whether or not it occurred on school, for example:          On school          Administrative offices area          Cafeteria area          Classroom          Hallway or stairs          ... | [optional] 
 **reporterDescriptionDescriptor** | **string**| Information on the type of individual who reported the DisciplineIncident. When known and/or if useful, use a more specific option code (e.g., \&quot;Counselor\&quot; rather than \&quot;Professional Staff\&quot;); for example:          Student          Parent/guardian          Law enforcement officer          Nonschool personnel          Representative of visiting school          ... | [optional] 
 **caseNumber** | **string**| The case number assigned to the DisciplineIncident by law enforcement or other organization. | [optional] 
 **id** | **string**|  | [optional] 
 **incidentCost** | **double?**| The value of any quantifiable monetary loss directly resulting from the DisciplineIncident. Examples include the value of repairs necessitated by vandalism of a school facility, or the value of personnel resources used for repairs or consumed by the incident. | [optional] 
 **incidentDate** | **DateTime?**| The month, day, and year on which the DisciplineIncident occurred. | [optional] 
 **incidentDescription** | **string**| The description for an incident. | [optional] 
 **incidentTime** | **string**| An indication of the time of day the incident took place. | [optional] 
 **reportedToLawEnforcement** | **bool?**| Indicator of whether the incident was reported to law enforcement. | [optional] 
 **reporterName** | **string**| Identifies the reporter of the DisciplineIncident by name. | [optional] 

### Return type

[**List<EdFiDisciplineIncident>**](EdFiDisciplineIncident.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdisciplineincidentsbyid"></a>
# **GetDisciplineIncidentsById**
> EdFiDisciplineIncident GetDisciplineIncidentsById (string id, string ifNoneMatch = null)

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
    public class GetDisciplineIncidentsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisciplineIncidentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiDisciplineIncident result = apiInstance.GetDisciplineIncidentsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisciplineIncidentsApi.GetDisciplineIncidentsById: " + e.Message );
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

[**EdFiDisciplineIncident**](EdFiDisciplineIncident.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdisciplineincident"></a>
# **PostDisciplineIncident**
> void PostDisciplineIncident (EdFiDisciplineIncident disciplineIncident)

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
    public class PostDisciplineIncidentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisciplineIncidentsApi();
            var disciplineIncident = new EdFiDisciplineIncident(); // EdFiDisciplineIncident | The JSON representation of the \"disciplineIncident\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostDisciplineIncident(disciplineIncident);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisciplineIncidentsApi.PostDisciplineIncident: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **disciplineIncident** | [**EdFiDisciplineIncident**](EdFiDisciplineIncident.md)| The JSON representation of the \&quot;disciplineIncident\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putdisciplineincident"></a>
# **PutDisciplineIncident**
> void PutDisciplineIncident (string id, EdFiDisciplineIncident disciplineIncident, string ifMatch = null)

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
    public class PutDisciplineIncidentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DisciplineIncidentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var disciplineIncident = new EdFiDisciplineIncident(); // EdFiDisciplineIncident | The JSON representation of the \"disciplineIncident\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutDisciplineIncident(id, disciplineIncident, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DisciplineIncidentsApi.PutDisciplineIncident: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **disciplineIncident** | [**EdFiDisciplineIncident**](EdFiDisciplineIncident.md)| The JSON representation of the \&quot;disciplineIncident\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

