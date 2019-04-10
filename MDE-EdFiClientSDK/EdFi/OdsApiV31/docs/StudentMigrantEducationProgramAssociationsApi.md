# EdFi.OdsApi.Sdk.Apis.All.StudentMigrantEducationProgramAssociationsApi

All URIs are relative to *https://localhost:56641/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentMigrantEducationProgramAssociationById**](StudentMigrantEducationProgramAssociationsApi.md#deletestudentmigranteducationprogramassociationbyid) | **DELETE** /ed-fi/studentMigrantEducationProgramAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentMigrantEducationProgramAssociations**](StudentMigrantEducationProgramAssociationsApi.md#getstudentmigranteducationprogramassociations) | **GET** /ed-fi/studentMigrantEducationProgramAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentMigrantEducationProgramAssociationsById**](StudentMigrantEducationProgramAssociationsApi.md#getstudentmigranteducationprogramassociationsbyid) | **GET** /ed-fi/studentMigrantEducationProgramAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudentMigrantEducationProgramAssociation**](StudentMigrantEducationProgramAssociationsApi.md#poststudentmigranteducationprogramassociation) | **POST** /ed-fi/studentMigrantEducationProgramAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudentMigrantEducationProgramAssociation**](StudentMigrantEducationProgramAssociationsApi.md#putstudentmigranteducationprogramassociation) | **PUT** /ed-fi/studentMigrantEducationProgramAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudentmigranteducationprogramassociationbyid"></a>
# **DeleteStudentMigrantEducationProgramAssociationById**
> void DeleteStudentMigrantEducationProgramAssociationById (string id, string ifMatch = null)

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
    public class DeleteStudentMigrantEducationProgramAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentMigrantEducationProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentMigrantEducationProgramAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.DeleteStudentMigrantEducationProgramAssociationById: " + e.Message );
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

<a name="getstudentmigranteducationprogramassociations"></a>
# **GetStudentMigrantEducationProgramAssociations**
> List<EdFiStudentMigrantEducationProgramAssociation> GetStudentMigrantEducationProgramAssociations (int? offset = null, int? limit = null, bool? totalCount = null, DateTime? beginDate = null, int? educationOrganizationId = null, int? programEducationOrganizationId = null, string programName = null, string programTypeDescriptor = null, string studentUniqueId = null, string continuationOfServicesReasonDescriptor = null, DateTime? eligibilityExpirationDate = null, DateTime? lastQualifyingMove = null, bool? priorityForServices = null, DateTime? qualifyingArrivalDate = null, DateTime? stateResidencyDate = null, DateTime? usInitialEntry = null, DateTime? usInitialSchoolEntry = null, DateTime? usMostRecentEntry = null)

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
    public class GetStudentMigrantEducationProgramAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentMigrantEducationProgramAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var beginDate = 2013-10-20;  // DateTime? | The month, day, and year on which the Student first received services. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programName = programName_example;  // string | The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. (optional) 
            var programTypeDescriptor = programTypeDescriptor_example;  // string | The type of program. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var continuationOfServicesReasonDescriptor = continuationOfServicesReasonDescriptor_example;  // string | The \"continuation of services\" provision found in Section 1304(e) of the statute provides that (1) a child who ceases to be a migratory child during a school term shall be eligible for services until the end of such term; (2) a child who is no longer a migratory child may continue to receive services for one additional school year, but only if comparable services are not available through other programs; and (3) secondary school students who were eligible for services in secondary school may continue to be served through credit accrual programs until graduation. Only students who received services at any time during their 36 month eligibility period may continue to receive services (not necessarily the same service). (optional) 
            var eligibilityExpirationDate = 2013-10-20;  // DateTime? | The Eligibility Expiration Date is used to determine end of eligibility and to account for a child's eligibility expiring earlier than 36 months from the child's QAD. A child's eligibility would end earlier than 36 months from the child's QAD, if the child is no longer entitled to a free public education (e.g., graduated with a high school diploma, obtained a high school equivalency diploma (HSED), or for other reasons as determined by States' requirements), or if the child passes away. (optional) 
            var lastQualifyingMove = 2013-10-20;  // DateTime? | Date the last qualifying move occurred; used to compute MEP status. (optional) 
            var priorityForServices = true;  // bool? | Report migratory children who are classified as having \"priority for services\" because they are failing, or most at risk of failing to meet the State's challenging State academic content standards and challenging State student academic achievement standards, and their education has been interrupted during the regular school year. (optional) 
            var qualifyingArrivalDate = 2013-10-20;  // DateTime? | The Qualifying Arrival Date (QAD) is the date the child joins the worker who has already moved, or the date when the worker joins the child who has already moved. The QAD is the date that the child's eligibility for the MEP begins. The QAD is not affected by subsequent non-qualifying moves. (optional) 
            var stateResidencyDate = 2013-10-20;  // DateTime? | The verified State residency for the student. (optional) 
            var usInitialEntry = 2013-10-20;  // DateTime? | The month, day, and year on which the Student first entered the U.S. (optional) 
            var usInitialSchoolEntry = 2013-10-20;  // DateTime? | The month, day, and year on which the Student first entered a U.S. school. (optional) 
            var usMostRecentEntry = 2013-10-20;  // DateTime? | The month, day, and year of the Student's most recent entry into the U.S. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentMigrantEducationProgramAssociation&gt; result = apiInstance.GetStudentMigrantEducationProgramAssociations(offset, limit, totalCount, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, continuationOfServicesReasonDescriptor, eligibilityExpirationDate, lastQualifyingMove, priorityForServices, qualifyingArrivalDate, stateResidencyDate, usInitialEntry, usInitialSchoolEntry, usMostRecentEntry);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.GetStudentMigrantEducationProgramAssociations: " + e.Message );
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
 **continuationOfServicesReasonDescriptor** | **string**| The \&quot;continuation of services\&quot; provision found in Section 1304(e) of the statute provides that (1) a child who ceases to be a migratory child during a school term shall be eligible for services until the end of such term; (2) a child who is no longer a migratory child may continue to receive services for one additional school year, but only if comparable services are not available through other programs; and (3) secondary school students who were eligible for services in secondary school may continue to be served through credit accrual programs until graduation. Only students who received services at any time during their 36 month eligibility period may continue to receive services (not necessarily the same service). | [optional] 
 **eligibilityExpirationDate** | **DateTime?**| The Eligibility Expiration Date is used to determine end of eligibility and to account for a child&#39;s eligibility expiring earlier than 36 months from the child&#39;s QAD. A child&#39;s eligibility would end earlier than 36 months from the child&#39;s QAD, if the child is no longer entitled to a free public education (e.g., graduated with a high school diploma, obtained a high school equivalency diploma (HSED), or for other reasons as determined by States&#39; requirements), or if the child passes away. | [optional] 
 **lastQualifyingMove** | **DateTime?**| Date the last qualifying move occurred; used to compute MEP status. | [optional] 
 **priorityForServices** | **bool?**| Report migratory children who are classified as having \&quot;priority for services\&quot; because they are failing, or most at risk of failing to meet the State&#39;s challenging State academic content standards and challenging State student academic achievement standards, and their education has been interrupted during the regular school year. | [optional] 
 **qualifyingArrivalDate** | **DateTime?**| The Qualifying Arrival Date (QAD) is the date the child joins the worker who has already moved, or the date when the worker joins the child who has already moved. The QAD is the date that the child&#39;s eligibility for the MEP begins. The QAD is not affected by subsequent non-qualifying moves. | [optional] 
 **stateResidencyDate** | **DateTime?**| The verified State residency for the student. | [optional] 
 **usInitialEntry** | **DateTime?**| The month, day, and year on which the Student first entered the U.S. | [optional] 
 **usInitialSchoolEntry** | **DateTime?**| The month, day, and year on which the Student first entered a U.S. school. | [optional] 
 **usMostRecentEntry** | **DateTime?**| The month, day, and year of the Student&#39;s most recent entry into the U.S. | [optional] 

### Return type

[**List<EdFiStudentMigrantEducationProgramAssociation>**](EdFiStudentMigrantEducationProgramAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentmigranteducationprogramassociationsbyid"></a>
# **GetStudentMigrantEducationProgramAssociationsById**
> EdFiStudentMigrantEducationProgramAssociation GetStudentMigrantEducationProgramAssociationsById (string id, string ifNoneMatch = null)

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
    public class GetStudentMigrantEducationProgramAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentMigrantEducationProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentMigrantEducationProgramAssociation result = apiInstance.GetStudentMigrantEducationProgramAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.GetStudentMigrantEducationProgramAssociationsById: " + e.Message );
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

[**EdFiStudentMigrantEducationProgramAssociation**](EdFiStudentMigrantEducationProgramAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentmigranteducationprogramassociation"></a>
# **PostStudentMigrantEducationProgramAssociation**
> void PostStudentMigrantEducationProgramAssociation (EdFiStudentMigrantEducationProgramAssociation studentMigrantEducationProgramAssociation)

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
    public class PostStudentMigrantEducationProgramAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentMigrantEducationProgramAssociationsApi();
            var studentMigrantEducationProgramAssociation = new EdFiStudentMigrantEducationProgramAssociation(); // EdFiStudentMigrantEducationProgramAssociation | The JSON representation of the \"studentMigrantEducationProgramAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentMigrantEducationProgramAssociation(studentMigrantEducationProgramAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.PostStudentMigrantEducationProgramAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentMigrantEducationProgramAssociation** | [**EdFiStudentMigrantEducationProgramAssociation**](EdFiStudentMigrantEducationProgramAssociation.md)| The JSON representation of the \&quot;studentMigrantEducationProgramAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentmigranteducationprogramassociation"></a>
# **PutStudentMigrantEducationProgramAssociation**
> void PutStudentMigrantEducationProgramAssociation (string id, EdFiStudentMigrantEducationProgramAssociation studentMigrantEducationProgramAssociation, string ifMatch = null)

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
    public class PutStudentMigrantEducationProgramAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentMigrantEducationProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentMigrantEducationProgramAssociation = new EdFiStudentMigrantEducationProgramAssociation(); // EdFiStudentMigrantEducationProgramAssociation | The JSON representation of the \"studentMigrantEducationProgramAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStudentMigrantEducationProgramAssociation(id, studentMigrantEducationProgramAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentMigrantEducationProgramAssociationsApi.PutStudentMigrantEducationProgramAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentMigrantEducationProgramAssociation** | [**EdFiStudentMigrantEducationProgramAssociation**](EdFiStudentMigrantEducationProgramAssociation.md)| The JSON representation of the \&quot;studentMigrantEducationProgramAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

