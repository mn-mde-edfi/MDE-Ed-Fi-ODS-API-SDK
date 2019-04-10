# EdFi.OdsApi.Sdk.Apis.All.StudentSpecialEducationProgramAssociationsApi

All URIs are relative to *https://localhost:56641/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentSpecialEducationProgramAssociationById**](StudentSpecialEducationProgramAssociationsApi.md#deletestudentspecialeducationprogramassociationbyid) | **DELETE** /ed-fi/studentSpecialEducationProgramAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentSpecialEducationProgramAssociations**](StudentSpecialEducationProgramAssociationsApi.md#getstudentspecialeducationprogramassociations) | **GET** /ed-fi/studentSpecialEducationProgramAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentSpecialEducationProgramAssociationsById**](StudentSpecialEducationProgramAssociationsApi.md#getstudentspecialeducationprogramassociationsbyid) | **GET** /ed-fi/studentSpecialEducationProgramAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudentSpecialEducationProgramAssociation**](StudentSpecialEducationProgramAssociationsApi.md#poststudentspecialeducationprogramassociation) | **POST** /ed-fi/studentSpecialEducationProgramAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudentSpecialEducationProgramAssociation**](StudentSpecialEducationProgramAssociationsApi.md#putstudentspecialeducationprogramassociation) | **PUT** /ed-fi/studentSpecialEducationProgramAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudentspecialeducationprogramassociationbyid"></a>
# **DeleteStudentSpecialEducationProgramAssociationById**
> void DeleteStudentSpecialEducationProgramAssociationById (string id, string ifMatch = null)

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
    public class DeleteStudentSpecialEducationProgramAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentSpecialEducationProgramAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.DeleteStudentSpecialEducationProgramAssociationById: " + e.Message );
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

<a name="getstudentspecialeducationprogramassociations"></a>
# **GetStudentSpecialEducationProgramAssociations**
> List<EdFiStudentSpecialEducationProgramAssociation> GetStudentSpecialEducationProgramAssociations (int? offset = null, int? limit = null, bool? totalCount = null, DateTime? beginDate = null, int? educationOrganizationId = null, int? programEducationOrganizationId = null, string programName = null, string programTypeDescriptor = null, string studentUniqueId = null, string specialEducationSettingDescriptor = null, bool? ideaEligibility = null, DateTime? iepBeginDate = null, DateTime? iepEndDate = null, DateTime? iepReviewDate = null, DateTime? lastEvaluationDate = null, bool? medicallyFragile = null, bool? multiplyDisabled = null, double? schoolHoursPerWeek = null, double? specialEducationHoursPerWeek = null)

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
    public class GetStudentSpecialEducationProgramAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var beginDate = 2013-10-20;  // DateTime? | The month, day, and year on which the Student first received services. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programName = programName_example;  // string | The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. (optional) 
            var programTypeDescriptor = programTypeDescriptor_example;  // string | The type of program. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var specialEducationSettingDescriptor = specialEducationSettingDescriptor_example;  // string | The major instructional setting (more than 50 percent of a student's special education program). (optional) 
            var ideaEligibility = true;  // bool? | Indicator of the eligibility of the student to receive special education services according to the Individuals with Disabilities Education Act (IDEA). (optional) 
            var iepBeginDate = 2013-10-20;  // DateTime? | The effective date of the most recent IEP. (optional) 
            var iepEndDate = 2013-10-20;  // DateTime? | The end date of the most recent IEP. (optional) 
            var iepReviewDate = 2013-10-20;  // DateTime? | The date of the last IEP review. (optional) 
            var lastEvaluationDate = 2013-10-20;  // DateTime? | The date of the last special education evaluation. (optional) 
            var medicallyFragile = true;  // bool? | Indicates whether the Student receiving special education and related services is:          1) in the age range of birth to 22 years, and          2) has a serious, ongoing illness or a chronic condition that has lasted or is anticipated to last at least 12 or more months or has required at least one month of hospitalization, and that requires daily, ongoing medical treatments and monitoring by appropriately trained personnel which may include parents or other family members, and          3) requires the routine use of medical device or of assistive technology to compensate for the loss of usefulness of a body function needed to participate in activities of daily living, and          4) lives with ongoing threat to his or her continued well-being.          Aligns with federal requirements. (optional) 
            var multiplyDisabled = true;  // bool? | Indicates whether the Student receiving special education and related services has been designated as multiply disabled by the admission, review, and dismissal committee as aligned with federal requirements. (optional) 
            var schoolHoursPerWeek = 1.2;  // double? | Indicate the total number of hours of instructional time per week for the school that the student attends. (optional) 
            var specialEducationHoursPerWeek = 1.2;  // double? | The number of hours per week for special education instruction and therapy. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentSpecialEducationProgramAssociation&gt; result = apiInstance.GetStudentSpecialEducationProgramAssociations(offset, limit, totalCount, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, specialEducationSettingDescriptor, ideaEligibility, iepBeginDate, iepEndDate, iepReviewDate, lastEvaluationDate, medicallyFragile, multiplyDisabled, schoolHoursPerWeek, specialEducationHoursPerWeek);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.GetStudentSpecialEducationProgramAssociations: " + e.Message );
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
 **specialEducationSettingDescriptor** | **string**| The major instructional setting (more than 50 percent of a student&#39;s special education program). | [optional] 
 **ideaEligibility** | **bool?**| Indicator of the eligibility of the student to receive special education services according to the Individuals with Disabilities Education Act (IDEA). | [optional] 
 **iepBeginDate** | **DateTime?**| The effective date of the most recent IEP. | [optional] 
 **iepEndDate** | **DateTime?**| The end date of the most recent IEP. | [optional] 
 **iepReviewDate** | **DateTime?**| The date of the last IEP review. | [optional] 
 **lastEvaluationDate** | **DateTime?**| The date of the last special education evaluation. | [optional] 
 **medicallyFragile** | **bool?**| Indicates whether the Student receiving special education and related services is:          1) in the age range of birth to 22 years, and          2) has a serious, ongoing illness or a chronic condition that has lasted or is anticipated to last at least 12 or more months or has required at least one month of hospitalization, and that requires daily, ongoing medical treatments and monitoring by appropriately trained personnel which may include parents or other family members, and          3) requires the routine use of medical device or of assistive technology to compensate for the loss of usefulness of a body function needed to participate in activities of daily living, and          4) lives with ongoing threat to his or her continued well-being.          Aligns with federal requirements. | [optional] 
 **multiplyDisabled** | **bool?**| Indicates whether the Student receiving special education and related services has been designated as multiply disabled by the admission, review, and dismissal committee as aligned with federal requirements. | [optional] 
 **schoolHoursPerWeek** | **double?**| Indicate the total number of hours of instructional time per week for the school that the student attends. | [optional] 
 **specialEducationHoursPerWeek** | **double?**| The number of hours per week for special education instruction and therapy. | [optional] 

### Return type

[**List<EdFiStudentSpecialEducationProgramAssociation>**](EdFiStudentSpecialEducationProgramAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentspecialeducationprogramassociationsbyid"></a>
# **GetStudentSpecialEducationProgramAssociationsById**
> EdFiStudentSpecialEducationProgramAssociation GetStudentSpecialEducationProgramAssociationsById (string id, string ifNoneMatch = null)

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
    public class GetStudentSpecialEducationProgramAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentSpecialEducationProgramAssociation result = apiInstance.GetStudentSpecialEducationProgramAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.GetStudentSpecialEducationProgramAssociationsById: " + e.Message );
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

[**EdFiStudentSpecialEducationProgramAssociation**](EdFiStudentSpecialEducationProgramAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentspecialeducationprogramassociation"></a>
# **PostStudentSpecialEducationProgramAssociation**
> void PostStudentSpecialEducationProgramAssociation (EdFiStudentSpecialEducationProgramAssociation studentSpecialEducationProgramAssociation)

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
    public class PostStudentSpecialEducationProgramAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramAssociationsApi();
            var studentSpecialEducationProgramAssociation = new EdFiStudentSpecialEducationProgramAssociation(); // EdFiStudentSpecialEducationProgramAssociation | The JSON representation of the \"studentSpecialEducationProgramAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentSpecialEducationProgramAssociation(studentSpecialEducationProgramAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.PostStudentSpecialEducationProgramAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentSpecialEducationProgramAssociation** | [**EdFiStudentSpecialEducationProgramAssociation**](EdFiStudentSpecialEducationProgramAssociation.md)| The JSON representation of the \&quot;studentSpecialEducationProgramAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentspecialeducationprogramassociation"></a>
# **PutStudentSpecialEducationProgramAssociation**
> void PutStudentSpecialEducationProgramAssociation (string id, EdFiStudentSpecialEducationProgramAssociation studentSpecialEducationProgramAssociation, string ifMatch = null)

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
    public class PutStudentSpecialEducationProgramAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSpecialEducationProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentSpecialEducationProgramAssociation = new EdFiStudentSpecialEducationProgramAssociation(); // EdFiStudentSpecialEducationProgramAssociation | The JSON representation of the \"studentSpecialEducationProgramAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStudentSpecialEducationProgramAssociation(id, studentSpecialEducationProgramAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSpecialEducationProgramAssociationsApi.PutStudentSpecialEducationProgramAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentSpecialEducationProgramAssociation** | [**EdFiStudentSpecialEducationProgramAssociation**](EdFiStudentSpecialEducationProgramAssociation.md)| The JSON representation of the \&quot;studentSpecialEducationProgramAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

