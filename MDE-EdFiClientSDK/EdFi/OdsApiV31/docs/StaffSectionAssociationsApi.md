# EdFi.OdsApi.Sdk.Apis.All.StaffSectionAssociationsApi

All URIs are relative to *https://localhost:56641/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStaffSectionAssociationById**](StaffSectionAssociationsApi.md#deletestaffsectionassociationbyid) | **DELETE** /ed-fi/staffSectionAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStaffSectionAssociations**](StaffSectionAssociationsApi.md#getstaffsectionassociations) | **GET** /ed-fi/staffSectionAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStaffSectionAssociationsById**](StaffSectionAssociationsApi.md#getstaffsectionassociationsbyid) | **GET** /ed-fi/staffSectionAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStaffSectionAssociation**](StaffSectionAssociationsApi.md#poststaffsectionassociation) | **POST** /ed-fi/staffSectionAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStaffSectionAssociation**](StaffSectionAssociationsApi.md#putstaffsectionassociation) | **PUT** /ed-fi/staffSectionAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestaffsectionassociationbyid"></a>
# **DeleteStaffSectionAssociationById**
> void DeleteStaffSectionAssociationById (string id, string ifMatch = null)

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
    public class DeleteStaffSectionAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffSectionAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStaffSectionAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffSectionAssociationsApi.DeleteStaffSectionAssociationById: " + e.Message );
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

<a name="getstaffsectionassociations"></a>
# **GetStaffSectionAssociations**
> List<EdFiStaffSectionAssociation> GetStaffSectionAssociations (int? offset = null, int? limit = null, bool? totalCount = null, string localCourseCode = null, int? schoolId = null, int? schoolYear = null, string sectionIdentifier = null, string sessionName = null, string staffUniqueId = null, string classroomPositionDescriptor = null, DateTime? beginDate = null, DateTime? endDate = null, bool? highlyQualifiedTeacher = null, string id = null, double? percentageContribution = null, bool? teacherStudentDataLinkExclusion = null)

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
    public class GetStaffSectionAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffSectionAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var localCourseCode = localCourseCode_example;  // string | The local code assigned by the School that identifies the course offering provided for the instruction of students. (optional) 
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var schoolYear = 56;  // int? | The identifier for the school year. (optional) 
            var sectionIdentifier = sectionIdentifier_example;  // string | The local identifier assigned to a section. (optional) 
            var sessionName = sessionName_example;  // string | The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). (optional) 
            var staffUniqueId = staffUniqueId_example;  // string | A unique alphanumeric code assigned to a staff. (optional) 
            var classroomPositionDescriptor = classroomPositionDescriptor_example;  // string | The type of position the Staff member holds in the specific class/section; for example:          Teacher of Record, Assistant Teacher, Support Teacher, Substitute Teacher... (optional) 
            var beginDate = 2013-10-20;  // DateTime? | Month, day, and year of a teacher's assignment to the Section. If blank, defaults to the first day of the first grading period for the Section. (optional) 
            var endDate = 2013-10-20;  // DateTime? | Month, day, and year of the last day of a staff member's assignment to the Section. (optional) 
            var highlyQualifiedTeacher = true;  // bool? | An indication of whether a teacher is classified as highly qualified for his/her assignment according to state definition. This attribute indicates the teacher is highly qualified for this section being taught. (optional) 
            var id = id_example;  // string |  (optional) 
            var percentageContribution = 1.2;  // double? | Indicates the percentage of the total scheduled course time, academic standards, and/or learning activities delivered in this section by this staff member. A teacher of record designation may be based solely or partially on this contribution percentage. (optional) 
            var teacherStudentDataLinkExclusion = true;  // bool? | Indicates that the entire section is excluded from calculation of value-added or growth attribution calculations used for a particular teacher evaluation. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStaffSectionAssociation&gt; result = apiInstance.GetStaffSectionAssociations(offset, limit, totalCount, localCourseCode, schoolId, schoolYear, sectionIdentifier, sessionName, staffUniqueId, classroomPositionDescriptor, beginDate, endDate, highlyQualifiedTeacher, id, percentageContribution, teacherStudentDataLinkExclusion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffSectionAssociationsApi.GetStaffSectionAssociations: " + e.Message );
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
 **localCourseCode** | **string**| The local code assigned by the School that identifies the course offering provided for the instruction of students. | [optional] 
 **schoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **schoolYear** | **int?**| The identifier for the school year. | [optional] 
 **sectionIdentifier** | **string**| The local identifier assigned to a section. | [optional] 
 **sessionName** | **string**| The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). | [optional] 
 **staffUniqueId** | **string**| A unique alphanumeric code assigned to a staff. | [optional] 
 **classroomPositionDescriptor** | **string**| The type of position the Staff member holds in the specific class/section; for example:          Teacher of Record, Assistant Teacher, Support Teacher, Substitute Teacher... | [optional] 
 **beginDate** | **DateTime?**| Month, day, and year of a teacher&#39;s assignment to the Section. If blank, defaults to the first day of the first grading period for the Section. | [optional] 
 **endDate** | **DateTime?**| Month, day, and year of the last day of a staff member&#39;s assignment to the Section. | [optional] 
 **highlyQualifiedTeacher** | **bool?**| An indication of whether a teacher is classified as highly qualified for his/her assignment according to state definition. This attribute indicates the teacher is highly qualified for this section being taught. | [optional] 
 **id** | **string**|  | [optional] 
 **percentageContribution** | **double?**| Indicates the percentage of the total scheduled course time, academic standards, and/or learning activities delivered in this section by this staff member. A teacher of record designation may be based solely or partially on this contribution percentage. | [optional] 
 **teacherStudentDataLinkExclusion** | **bool?**| Indicates that the entire section is excluded from calculation of value-added or growth attribution calculations used for a particular teacher evaluation. | [optional] 

### Return type

[**List<EdFiStaffSectionAssociation>**](EdFiStaffSectionAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstaffsectionassociationsbyid"></a>
# **GetStaffSectionAssociationsById**
> EdFiStaffSectionAssociation GetStaffSectionAssociationsById (string id, string ifNoneMatch = null)

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
    public class GetStaffSectionAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffSectionAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStaffSectionAssociation result = apiInstance.GetStaffSectionAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffSectionAssociationsApi.GetStaffSectionAssociationsById: " + e.Message );
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

[**EdFiStaffSectionAssociation**](EdFiStaffSectionAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststaffsectionassociation"></a>
# **PostStaffSectionAssociation**
> void PostStaffSectionAssociation (EdFiStaffSectionAssociation staffSectionAssociation)

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
    public class PostStaffSectionAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffSectionAssociationsApi();
            var staffSectionAssociation = new EdFiStaffSectionAssociation(); // EdFiStaffSectionAssociation | The JSON representation of the \"staffSectionAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStaffSectionAssociation(staffSectionAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffSectionAssociationsApi.PostStaffSectionAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staffSectionAssociation** | [**EdFiStaffSectionAssociation**](EdFiStaffSectionAssociation.md)| The JSON representation of the \&quot;staffSectionAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstaffsectionassociation"></a>
# **PutStaffSectionAssociation**
> void PutStaffSectionAssociation (string id, EdFiStaffSectionAssociation staffSectionAssociation, string ifMatch = null)

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
    public class PutStaffSectionAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StaffSectionAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var staffSectionAssociation = new EdFiStaffSectionAssociation(); // EdFiStaffSectionAssociation | The JSON representation of the \"staffSectionAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStaffSectionAssociation(id, staffSectionAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffSectionAssociationsApi.PutStaffSectionAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **staffSectionAssociation** | [**EdFiStaffSectionAssociation**](EdFiStaffSectionAssociation.md)| The JSON representation of the \&quot;staffSectionAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

