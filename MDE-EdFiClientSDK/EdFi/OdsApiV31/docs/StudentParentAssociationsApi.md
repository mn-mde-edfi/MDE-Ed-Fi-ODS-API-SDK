# EdFi.OdsApi.Sdk.Apis.All.StudentParentAssociationsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentParentAssociationById**](StudentParentAssociationsApi.md#deletestudentparentassociationbyid) | **DELETE** /ed-fi/studentParentAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentParentAssociations**](StudentParentAssociationsApi.md#getstudentparentassociations) | **GET** /ed-fi/studentParentAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentParentAssociationsById**](StudentParentAssociationsApi.md#getstudentparentassociationsbyid) | **GET** /ed-fi/studentParentAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudentParentAssociation**](StudentParentAssociationsApi.md#poststudentparentassociation) | **POST** /ed-fi/studentParentAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudentParentAssociation**](StudentParentAssociationsApi.md#putstudentparentassociation) | **PUT** /ed-fi/studentParentAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudentparentassociationbyid"></a>
# **DeleteStudentParentAssociationById**
> void DeleteStudentParentAssociationById (string id, string ifMatch = null)

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
    public class DeleteStudentParentAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentParentAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentParentAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentParentAssociationsApi.DeleteStudentParentAssociationById: " + e.Message );
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

<a name="getstudentparentassociations"></a>
# **GetStudentParentAssociations**
> List<EdFiStudentParentAssociation> GetStudentParentAssociations (int? offset = null, int? limit = null, bool? totalCount = null, string parentUniqueId = null, string studentUniqueId = null, string relationDescriptor = null, int? contactPriority = null, string contactRestrictions = null, bool? emergencyContactStatus = null, string id = null, bool? livesWith = null, bool? primaryContactStatus = null)

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
    public class GetStudentParentAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentParentAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var parentUniqueId = parentUniqueId_example;  // string | A unique alphanumeric code assigned to a parent. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var relationDescriptor = relationDescriptor_example;  // string | The nature of an individual's relationship to a student; for example:          Father, Mother, Step Father, Step Mother, Foster Father, Foster Mother, Guardian, etc. (optional) 
            var contactPriority = 56;  // int? | The numeric order of the preferred sequence or priority of contact. (optional) 
            var contactRestrictions = contactRestrictions_example;  // string | Restrictions for student and/or teacher contact with the individual (e.g., the student may not be picked up by the individual). (optional) 
            var emergencyContactStatus = true;  // bool? | Indicator of whether the person is a designated emergency contact for the Student. (optional) 
            var id = id_example;  // string |  (optional) 
            var livesWith = true;  // bool? | Indicator of whether the Student lives with the associated parent. (optional) 
            var primaryContactStatus = true;  // bool? | Indicator of whether the person is a primary parental contact for the Student. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentParentAssociation&gt; result = apiInstance.GetStudentParentAssociations(offset, limit, totalCount, parentUniqueId, studentUniqueId, relationDescriptor, contactPriority, contactRestrictions, emergencyContactStatus, id, livesWith, primaryContactStatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentParentAssociationsApi.GetStudentParentAssociations: " + e.Message );
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
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **relationDescriptor** | **string**| The nature of an individual&#39;s relationship to a student; for example:          Father, Mother, Step Father, Step Mother, Foster Father, Foster Mother, Guardian, etc. | [optional] 
 **contactPriority** | **int?**| The numeric order of the preferred sequence or priority of contact. | [optional] 
 **contactRestrictions** | **string**| Restrictions for student and/or teacher contact with the individual (e.g., the student may not be picked up by the individual). | [optional] 
 **emergencyContactStatus** | **bool?**| Indicator of whether the person is a designated emergency contact for the Student. | [optional] 
 **id** | **string**|  | [optional] 
 **livesWith** | **bool?**| Indicator of whether the Student lives with the associated parent. | [optional] 
 **primaryContactStatus** | **bool?**| Indicator of whether the person is a primary parental contact for the Student. | [optional] 

### Return type

[**List<EdFiStudentParentAssociation>**](EdFiStudentParentAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentparentassociationsbyid"></a>
# **GetStudentParentAssociationsById**
> EdFiStudentParentAssociation GetStudentParentAssociationsById (string id, string ifNoneMatch = null)

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
    public class GetStudentParentAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentParentAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentParentAssociation result = apiInstance.GetStudentParentAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentParentAssociationsApi.GetStudentParentAssociationsById: " + e.Message );
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

[**EdFiStudentParentAssociation**](EdFiStudentParentAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentparentassociation"></a>
# **PostStudentParentAssociation**
> void PostStudentParentAssociation (EdFiStudentParentAssociation studentParentAssociation)

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
    public class PostStudentParentAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentParentAssociationsApi();
            var studentParentAssociation = new EdFiStudentParentAssociation(); // EdFiStudentParentAssociation | The JSON representation of the \"studentParentAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentParentAssociation(studentParentAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentParentAssociationsApi.PostStudentParentAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentParentAssociation** | [**EdFiStudentParentAssociation**](EdFiStudentParentAssociation.md)| The JSON representation of the \&quot;studentParentAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentparentassociation"></a>
# **PutStudentParentAssociation**
> void PutStudentParentAssociation (string id, EdFiStudentParentAssociation studentParentAssociation, string ifMatch = null)

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
    public class PutStudentParentAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentParentAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentParentAssociation = new EdFiStudentParentAssociation(); // EdFiStudentParentAssociation | The JSON representation of the \"studentParentAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStudentParentAssociation(id, studentParentAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentParentAssociationsApi.PutStudentParentAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentParentAssociation** | [**EdFiStudentParentAssociation**](EdFiStudentParentAssociation.md)| The JSON representation of the \&quot;studentParentAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

