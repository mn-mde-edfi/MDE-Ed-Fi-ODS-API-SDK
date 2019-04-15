# EdFi.OdsApi.Sdk.Apis.All.StudentNeglectedOrDelinquentProgramAssociationsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentNeglectedOrDelinquentProgramAssociationById**](StudentNeglectedOrDelinquentProgramAssociationsApi.md#deletestudentneglectedordelinquentprogramassociationbyid) | **DELETE** /ed-fi/studentNeglectedOrDelinquentProgramAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentNeglectedOrDelinquentProgramAssociations**](StudentNeglectedOrDelinquentProgramAssociationsApi.md#getstudentneglectedordelinquentprogramassociations) | **GET** /ed-fi/studentNeglectedOrDelinquentProgramAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentNeglectedOrDelinquentProgramAssociationsById**](StudentNeglectedOrDelinquentProgramAssociationsApi.md#getstudentneglectedordelinquentprogramassociationsbyid) | **GET** /ed-fi/studentNeglectedOrDelinquentProgramAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudentNeglectedOrDelinquentProgramAssociation**](StudentNeglectedOrDelinquentProgramAssociationsApi.md#poststudentneglectedordelinquentprogramassociation) | **POST** /ed-fi/studentNeglectedOrDelinquentProgramAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudentNeglectedOrDelinquentProgramAssociation**](StudentNeglectedOrDelinquentProgramAssociationsApi.md#putstudentneglectedordelinquentprogramassociation) | **PUT** /ed-fi/studentNeglectedOrDelinquentProgramAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudentneglectedordelinquentprogramassociationbyid"></a>
# **DeleteStudentNeglectedOrDelinquentProgramAssociationById**
> void DeleteStudentNeglectedOrDelinquentProgramAssociationById (string id, string ifMatch = null)

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
    public class DeleteStudentNeglectedOrDelinquentProgramAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentNeglectedOrDelinquentProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentNeglectedOrDelinquentProgramAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentNeglectedOrDelinquentProgramAssociationsApi.DeleteStudentNeglectedOrDelinquentProgramAssociationById: " + e.Message );
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

<a name="getstudentneglectedordelinquentprogramassociations"></a>
# **GetStudentNeglectedOrDelinquentProgramAssociations**
> List<EdFiStudentNeglectedOrDelinquentProgramAssociation> GetStudentNeglectedOrDelinquentProgramAssociations (int? offset = null, int? limit = null, bool? totalCount = null, DateTime? beginDate = null, int? educationOrganizationId = null, int? programEducationOrganizationId = null, string programName = null, string programTypeDescriptor = null, string studentUniqueId = null, string neglectedOrDelinquentProgramDescriptor = null, string elaProgressLevelDescriptor = null, string mathematicsProgressLevelDescriptor = null)

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
    public class GetStudentNeglectedOrDelinquentProgramAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentNeglectedOrDelinquentProgramAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var beginDate = 2013-10-20;  // DateTime? | The month, day, and year on which the Student first received services. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programName = programName_example;  // string | The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. (optional) 
            var programTypeDescriptor = programTypeDescriptor_example;  // string | The type of program. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var neglectedOrDelinquentProgramDescriptor = neglectedOrDelinquentProgramDescriptor_example;  // string | The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA). (optional) 
            var elaProgressLevelDescriptor = elaProgressLevelDescriptor_example;  // string | The progress measured from pre- to post- test for ELA. (optional) 
            var mathematicsProgressLevelDescriptor = mathematicsProgressLevelDescriptor_example;  // string | The progress measured from pre- to post-test for Mathematics. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentNeglectedOrDelinquentProgramAssociation&gt; result = apiInstance.GetStudentNeglectedOrDelinquentProgramAssociations(offset, limit, totalCount, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, neglectedOrDelinquentProgramDescriptor, elaProgressLevelDescriptor, mathematicsProgressLevelDescriptor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentNeglectedOrDelinquentProgramAssociationsApi.GetStudentNeglectedOrDelinquentProgramAssociations: " + e.Message );
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
 **beginDate** | **DateTime?**| The month, day, and year on which the Student first received services. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **programEducationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **programName** | **string**| The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. | [optional] 
 **programTypeDescriptor** | **string**| The type of program. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **neglectedOrDelinquentProgramDescriptor** | **string**| The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA). | [optional] 
 **elaProgressLevelDescriptor** | **string**| The progress measured from pre- to post- test for ELA. | [optional] 
 **mathematicsProgressLevelDescriptor** | **string**| The progress measured from pre- to post-test for Mathematics. | [optional] 

### Return type

[**List<EdFiStudentNeglectedOrDelinquentProgramAssociation>**](EdFiStudentNeglectedOrDelinquentProgramAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentneglectedordelinquentprogramassociationsbyid"></a>
# **GetStudentNeglectedOrDelinquentProgramAssociationsById**
> EdFiStudentNeglectedOrDelinquentProgramAssociation GetStudentNeglectedOrDelinquentProgramAssociationsById (string id, string ifNoneMatch = null)

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
    public class GetStudentNeglectedOrDelinquentProgramAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentNeglectedOrDelinquentProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentNeglectedOrDelinquentProgramAssociation result = apiInstance.GetStudentNeglectedOrDelinquentProgramAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentNeglectedOrDelinquentProgramAssociationsApi.GetStudentNeglectedOrDelinquentProgramAssociationsById: " + e.Message );
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

[**EdFiStudentNeglectedOrDelinquentProgramAssociation**](EdFiStudentNeglectedOrDelinquentProgramAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentneglectedordelinquentprogramassociation"></a>
# **PostStudentNeglectedOrDelinquentProgramAssociation**
> void PostStudentNeglectedOrDelinquentProgramAssociation (EdFiStudentNeglectedOrDelinquentProgramAssociation studentNeglectedOrDelinquentProgramAssociation)

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
    public class PostStudentNeglectedOrDelinquentProgramAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentNeglectedOrDelinquentProgramAssociationsApi();
            var studentNeglectedOrDelinquentProgramAssociation = new EdFiStudentNeglectedOrDelinquentProgramAssociation(); // EdFiStudentNeglectedOrDelinquentProgramAssociation | The JSON representation of the \"studentNeglectedOrDelinquentProgramAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentNeglectedOrDelinquentProgramAssociation(studentNeglectedOrDelinquentProgramAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentNeglectedOrDelinquentProgramAssociationsApi.PostStudentNeglectedOrDelinquentProgramAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentNeglectedOrDelinquentProgramAssociation** | [**EdFiStudentNeglectedOrDelinquentProgramAssociation**](EdFiStudentNeglectedOrDelinquentProgramAssociation.md)| The JSON representation of the \&quot;studentNeglectedOrDelinquentProgramAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentneglectedordelinquentprogramassociation"></a>
# **PutStudentNeglectedOrDelinquentProgramAssociation**
> void PutStudentNeglectedOrDelinquentProgramAssociation (string id, EdFiStudentNeglectedOrDelinquentProgramAssociation studentNeglectedOrDelinquentProgramAssociation, string ifMatch = null)

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
    public class PutStudentNeglectedOrDelinquentProgramAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentNeglectedOrDelinquentProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentNeglectedOrDelinquentProgramAssociation = new EdFiStudentNeglectedOrDelinquentProgramAssociation(); // EdFiStudentNeglectedOrDelinquentProgramAssociation | The JSON representation of the \"studentNeglectedOrDelinquentProgramAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStudentNeglectedOrDelinquentProgramAssociation(id, studentNeglectedOrDelinquentProgramAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentNeglectedOrDelinquentProgramAssociationsApi.PutStudentNeglectedOrDelinquentProgramAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentNeglectedOrDelinquentProgramAssociation** | [**EdFiStudentNeglectedOrDelinquentProgramAssociation**](EdFiStudentNeglectedOrDelinquentProgramAssociation.md)| The JSON representation of the \&quot;studentNeglectedOrDelinquentProgramAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

