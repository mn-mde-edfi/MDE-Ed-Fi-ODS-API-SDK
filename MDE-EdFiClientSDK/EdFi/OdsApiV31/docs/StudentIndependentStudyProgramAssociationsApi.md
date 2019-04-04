# EdFi.OdsApi.Sdk.Apis.All.StudentIndependentStudyProgramAssociationsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentIndependentStudyProgramAssociationById**](StudentIndependentStudyProgramAssociationsApi.md#deletestudentindependentstudyprogramassociationbyid) | **DELETE** /MN/studentIndependentStudyProgramAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentIndependentStudyProgramAssociations**](StudentIndependentStudyProgramAssociationsApi.md#getstudentindependentstudyprogramassociations) | **GET** /MN/studentIndependentStudyProgramAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentIndependentStudyProgramAssociationsById**](StudentIndependentStudyProgramAssociationsApi.md#getstudentindependentstudyprogramassociationsbyid) | **GET** /MN/studentIndependentStudyProgramAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudentIndependentStudyProgramAssociation**](StudentIndependentStudyProgramAssociationsApi.md#poststudentindependentstudyprogramassociation) | **POST** /MN/studentIndependentStudyProgramAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudentIndependentStudyProgramAssociation**](StudentIndependentStudyProgramAssociationsApi.md#putstudentindependentstudyprogramassociation) | **PUT** /MN/studentIndependentStudyProgramAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudentindependentstudyprogramassociationbyid"></a>
# **DeleteStudentIndependentStudyProgramAssociationById**
> void DeleteStudentIndependentStudyProgramAssociationById (string id, string ifMatch = null)

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
    public class DeleteStudentIndependentStudyProgramAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentIndependentStudyProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentIndependentStudyProgramAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentIndependentStudyProgramAssociationsApi.DeleteStudentIndependentStudyProgramAssociationById: " + e.Message );
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

<a name="getstudentindependentstudyprogramassociations"></a>
# **GetStudentIndependentStudyProgramAssociations**
> List<MnStudentIndependentStudyProgramAssociation> GetStudentIndependentStudyProgramAssociations (int? offset = null, int? limit = null, bool? totalCount = null, DateTime? beginDate = null, int? educationOrganizationId = null, int? programEducationOrganizationId = null, string programName = null, string programTypeDescriptor = null, string studentUniqueId = null)

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
    public class GetStudentIndependentStudyProgramAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentIndependentStudyProgramAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var beginDate = 2013-10-20;  // DateTime? | The month, day, and year on which the Student first received services. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programName = programName_example;  // string | The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. (optional) 
            var programTypeDescriptor = programTypeDescriptor_example;  // string | The type of program. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;MnStudentIndependentStudyProgramAssociation&gt; result = apiInstance.GetStudentIndependentStudyProgramAssociations(offset, limit, totalCount, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentIndependentStudyProgramAssociationsApi.GetStudentIndependentStudyProgramAssociations: " + e.Message );
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

### Return type

[**List<MnStudentIndependentStudyProgramAssociation>**](MnStudentIndependentStudyProgramAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentindependentstudyprogramassociationsbyid"></a>
# **GetStudentIndependentStudyProgramAssociationsById**
> MnStudentIndependentStudyProgramAssociation GetStudentIndependentStudyProgramAssociationsById (string id, string ifNoneMatch = null)

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
    public class GetStudentIndependentStudyProgramAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentIndependentStudyProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                MnStudentIndependentStudyProgramAssociation result = apiInstance.GetStudentIndependentStudyProgramAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentIndependentStudyProgramAssociationsApi.GetStudentIndependentStudyProgramAssociationsById: " + e.Message );
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

[**MnStudentIndependentStudyProgramAssociation**](MnStudentIndependentStudyProgramAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentindependentstudyprogramassociation"></a>
# **PostStudentIndependentStudyProgramAssociation**
> void PostStudentIndependentStudyProgramAssociation (MnStudentIndependentStudyProgramAssociation studentIndependentStudyProgramAssociation)

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
    public class PostStudentIndependentStudyProgramAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentIndependentStudyProgramAssociationsApi();
            var studentIndependentStudyProgramAssociation = new MnStudentIndependentStudyProgramAssociation(); // MnStudentIndependentStudyProgramAssociation | The JSON representation of the \"studentIndependentStudyProgramAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentIndependentStudyProgramAssociation(studentIndependentStudyProgramAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentIndependentStudyProgramAssociationsApi.PostStudentIndependentStudyProgramAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentIndependentStudyProgramAssociation** | [**MnStudentIndependentStudyProgramAssociation**](MnStudentIndependentStudyProgramAssociation.md)| The JSON representation of the \&quot;studentIndependentStudyProgramAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentindependentstudyprogramassociation"></a>
# **PutStudentIndependentStudyProgramAssociation**
> void PutStudentIndependentStudyProgramAssociation (string id, MnStudentIndependentStudyProgramAssociation studentIndependentStudyProgramAssociation, string ifMatch = null)

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
    public class PutStudentIndependentStudyProgramAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentIndependentStudyProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentIndependentStudyProgramAssociation = new MnStudentIndependentStudyProgramAssociation(); // MnStudentIndependentStudyProgramAssociation | The JSON representation of the \"studentIndependentStudyProgramAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStudentIndependentStudyProgramAssociation(id, studentIndependentStudyProgramAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentIndependentStudyProgramAssociationsApi.PutStudentIndependentStudyProgramAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentIndependentStudyProgramAssociation** | [**MnStudentIndependentStudyProgramAssociation**](MnStudentIndependentStudyProgramAssociation.md)| The JSON representation of the \&quot;studentIndependentStudyProgramAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

