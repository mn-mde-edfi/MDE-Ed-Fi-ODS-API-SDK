# EdFi.OdsApi.Sdk.Apis.All.SchoolsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSchoolById**](SchoolsApi.md#deleteschoolbyid) | **DELETE** /ed-fi/schools/{id} | Deletes an existing resource using the resource identifier.
[**GetSchools**](SchoolsApi.md#getschools) | **GET** /ed-fi/schools | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetSchoolsById**](SchoolsApi.md#getschoolsbyid) | **GET** /ed-fi/schools/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostSchool**](SchoolsApi.md#postschool) | **POST** /ed-fi/schools | Creates or updates resources based on the natural key values of the supplied resource.
[**PutSchool**](SchoolsApi.md#putschool) | **PUT** /ed-fi/schools/{id} | Updates or creates a resource based on the resource identifier.


<a name="deleteschoolbyid"></a>
# **DeleteSchoolById**
> void DeleteSchoolById (string id, string ifMatch = null)

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
    public class DeleteSchoolByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteSchoolById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchoolsApi.DeleteSchoolById: " + e.Message );
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

<a name="getschools"></a>
# **GetSchools**
> List<EdFiSchool> GetSchools (int? offset = null, int? limit = null, bool? totalCount = null, int? schoolId = null, int? localEducationAgencyId = null, int? charterApprovalSchoolYear = null, string administrativeFundingControlDescriptor = null, string charterApprovalAgencyTypeDescriptor = null, string charterStatusDescriptor = null, string internetAccessDescriptor = null, string magnetSpecialProgramEmphasisSchoolDescriptor = null, string schoolTypeDescriptor = null, string titleIPartASchoolDesignationDescriptor = null)

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
    public class GetSchoolsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var localEducationAgencyId = 56;  // int? | The identifier assigned to a local education agency. (optional) 
            var charterApprovalSchoolYear = 56;  // int? | The school year in which a charter school was initially approved. (optional) 
            var administrativeFundingControlDescriptor = administrativeFundingControlDescriptor_example;  // string | The type of education institution as classified by its funding source, for example public or private. (optional) 
            var charterApprovalAgencyTypeDescriptor = charterApprovalAgencyTypeDescriptor_example;  // string | The type of agency that approved the establishment or continuation of a charter school. (optional) 
            var charterStatusDescriptor = charterStatusDescriptor_example;  // string | A school or agency providing free public elementary or secondary education to eligible students under a specific charter granted by the state legislature or other appropriate authority and designated by such authority to be a charter school. (optional) 
            var internetAccessDescriptor = internetAccessDescriptor_example;  // string | The type of Internet access available. (optional) 
            var magnetSpecialProgramEmphasisSchoolDescriptor = magnetSpecialProgramEmphasisSchoolDescriptor_example;  // string | A school that has been designed: 1) to attract students of different racial/ethnic backgrounds for the purpose of reducing, preventing, or eliminating racial isolation; and/or 2) to provide an academic or social focus on a particular theme (e.g., science/math, performing arts, gifted/talented, or foreign language). (optional) 
            var schoolTypeDescriptor = schoolTypeDescriptor_example;  // string | The type of education institution as classified by its primary focus. (optional) 
            var titleIPartASchoolDesignationDescriptor = titleIPartASchoolDesignationDescriptor_example;  // string | Denotes the Title I Part A designation for the school. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiSchool&gt; result = apiInstance.GetSchools(offset, limit, totalCount, schoolId, localEducationAgencyId, charterApprovalSchoolYear, administrativeFundingControlDescriptor, charterApprovalAgencyTypeDescriptor, charterStatusDescriptor, internetAccessDescriptor, magnetSpecialProgramEmphasisSchoolDescriptor, schoolTypeDescriptor, titleIPartASchoolDesignationDescriptor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchoolsApi.GetSchools: " + e.Message );
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
 **schoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **localEducationAgencyId** | **int?**| The identifier assigned to a local education agency. | [optional] 
 **charterApprovalSchoolYear** | **int?**| The school year in which a charter school was initially approved. | [optional] 
 **administrativeFundingControlDescriptor** | **string**| The type of education institution as classified by its funding source, for example public or private. | [optional] 
 **charterApprovalAgencyTypeDescriptor** | **string**| The type of agency that approved the establishment or continuation of a charter school. | [optional] 
 **charterStatusDescriptor** | **string**| A school or agency providing free public elementary or secondary education to eligible students under a specific charter granted by the state legislature or other appropriate authority and designated by such authority to be a charter school. | [optional] 
 **internetAccessDescriptor** | **string**| The type of Internet access available. | [optional] 
 **magnetSpecialProgramEmphasisSchoolDescriptor** | **string**| A school that has been designed: 1) to attract students of different racial/ethnic backgrounds for the purpose of reducing, preventing, or eliminating racial isolation; and/or 2) to provide an academic or social focus on a particular theme (e.g., science/math, performing arts, gifted/talented, or foreign language). | [optional] 
 **schoolTypeDescriptor** | **string**| The type of education institution as classified by its primary focus. | [optional] 
 **titleIPartASchoolDesignationDescriptor** | **string**| Denotes the Title I Part A designation for the school. | [optional] 

### Return type

[**List<EdFiSchool>**](EdFiSchool.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getschoolsbyid"></a>
# **GetSchoolsById**
> EdFiSchool GetSchoolsById (string id, string ifNoneMatch = null)

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
    public class GetSchoolsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiSchool result = apiInstance.GetSchoolsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchoolsApi.GetSchoolsById: " + e.Message );
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

[**EdFiSchool**](EdFiSchool.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postschool"></a>
# **PostSchool**
> void PostSchool (EdFiSchool school)

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
    public class PostSchoolExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolsApi();
            var school = new EdFiSchool(); // EdFiSchool | The JSON representation of the \"school\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostSchool(school);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchoolsApi.PostSchool: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **school** | [**EdFiSchool**](EdFiSchool.md)| The JSON representation of the \&quot;school\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putschool"></a>
# **PutSchool**
> void PutSchool (string id, EdFiSchool school, string ifMatch = null)

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
    public class PutSchoolExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var school = new EdFiSchool(); // EdFiSchool | The JSON representation of the \"school\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutSchool(id, school, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchoolsApi.PutSchool: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **school** | [**EdFiSchool**](EdFiSchool.md)| The JSON representation of the \&quot;school\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

