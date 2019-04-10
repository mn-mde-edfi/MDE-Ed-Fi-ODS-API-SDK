# EdFi.OdsApi.Sdk.Apis.All.StaffSchoolAssociationsApi

All URIs are relative to *https://localhost:56641/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStaffSchoolAssociationById**](StaffSchoolAssociationsApi.md#deletestaffschoolassociationbyid) | **DELETE** /ed-fi/staffSchoolAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStaffSchoolAssociations**](StaffSchoolAssociationsApi.md#getstaffschoolassociations) | **GET** /ed-fi/staffSchoolAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStaffSchoolAssociationsById**](StaffSchoolAssociationsApi.md#getstaffschoolassociationsbyid) | **GET** /ed-fi/staffSchoolAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStaffSchoolAssociation**](StaffSchoolAssociationsApi.md#poststaffschoolassociation) | **POST** /ed-fi/staffSchoolAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStaffSchoolAssociation**](StaffSchoolAssociationsApi.md#putstaffschoolassociation) | **PUT** /ed-fi/staffSchoolAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestaffschoolassociationbyid"></a>
# **DeleteStaffSchoolAssociationById**
> void DeleteStaffSchoolAssociationById (string id, string ifMatch = null)

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
    public class DeleteStaffSchoolAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffSchoolAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStaffSchoolAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffSchoolAssociationsApi.DeleteStaffSchoolAssociationById: " + e.Message );
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

<a name="getstaffschoolassociations"></a>
# **GetStaffSchoolAssociations**
> List<EdFiStaffSchoolAssociation> GetStaffSchoolAssociations (int? offset = null, int? limit = null, bool? totalCount = null, string programAssignmentDescriptor = null, int? schoolId = null, string staffUniqueId = null, string calendarCode = null, int? schoolYear = null, string id = null)

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
    public class GetStaffSchoolAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffSchoolAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var programAssignmentDescriptor = programAssignmentDescriptor_example;  // string | The name of the program for which the individual is assigned; for example:          Regular education          Title I-Academic          Title I-Non-Academic          Special Education          Bilingual/English as a Second Language. (optional) 
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var staffUniqueId = staffUniqueId_example;  // string | A unique alphanumeric code assigned to a staff. (optional) 
            var calendarCode = calendarCode_example;  // string | The identifier for the Calendar. (optional) 
            var schoolYear = 56;  // int? | Identifier for a school year. (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStaffSchoolAssociation&gt; result = apiInstance.GetStaffSchoolAssociations(offset, limit, totalCount, programAssignmentDescriptor, schoolId, staffUniqueId, calendarCode, schoolYear, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffSchoolAssociationsApi.GetStaffSchoolAssociations: " + e.Message );
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
 **programAssignmentDescriptor** | **string**| The name of the program for which the individual is assigned; for example:          Regular education          Title I-Academic          Title I-Non-Academic          Special Education          Bilingual/English as a Second Language. | [optional] 
 **schoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **staffUniqueId** | **string**| A unique alphanumeric code assigned to a staff. | [optional] 
 **calendarCode** | **string**| The identifier for the Calendar. | [optional] 
 **schoolYear** | **int?**| Identifier for a school year. | [optional] 
 **id** | **string**|  | [optional] 

### Return type

[**List<EdFiStaffSchoolAssociation>**](EdFiStaffSchoolAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstaffschoolassociationsbyid"></a>
# **GetStaffSchoolAssociationsById**
> EdFiStaffSchoolAssociation GetStaffSchoolAssociationsById (string id, string ifNoneMatch = null)

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
    public class GetStaffSchoolAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffSchoolAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStaffSchoolAssociation result = apiInstance.GetStaffSchoolAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffSchoolAssociationsApi.GetStaffSchoolAssociationsById: " + e.Message );
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

[**EdFiStaffSchoolAssociation**](EdFiStaffSchoolAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststaffschoolassociation"></a>
# **PostStaffSchoolAssociation**
> void PostStaffSchoolAssociation (EdFiStaffSchoolAssociation staffSchoolAssociation)

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
    public class PostStaffSchoolAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffSchoolAssociationsApi();
            var staffSchoolAssociation = new EdFiStaffSchoolAssociation(); // EdFiStaffSchoolAssociation | The JSON representation of the \"staffSchoolAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStaffSchoolAssociation(staffSchoolAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffSchoolAssociationsApi.PostStaffSchoolAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffSchoolAssociation** | [**EdFiStaffSchoolAssociation**](EdFiStaffSchoolAssociation.md)| The JSON representation of the \&quot;staffSchoolAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstaffschoolassociation"></a>
# **PutStaffSchoolAssociation**
> void PutStaffSchoolAssociation (string id, EdFiStaffSchoolAssociation staffSchoolAssociation, string ifMatch = null)

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
    public class PutStaffSchoolAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffSchoolAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var staffSchoolAssociation = new EdFiStaffSchoolAssociation(); // EdFiStaffSchoolAssociation | The JSON representation of the \"staffSchoolAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStaffSchoolAssociation(id, staffSchoolAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffSchoolAssociationsApi.PutStaffSchoolAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **staffSchoolAssociation** | [**EdFiStaffSchoolAssociation**](EdFiStaffSchoolAssociation.md)| The JSON representation of the \&quot;staffSchoolAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

