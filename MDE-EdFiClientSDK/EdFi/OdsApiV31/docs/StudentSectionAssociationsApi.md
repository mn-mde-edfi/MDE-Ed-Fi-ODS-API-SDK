# EdFi.OdsApi.Sdk.Apis.All.StudentSectionAssociationsApi

All URIs are relative to *https://localhost:56641/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentSectionAssociationById**](StudentSectionAssociationsApi.md#deletestudentsectionassociationbyid) | **DELETE** /ed-fi/studentSectionAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentSectionAssociations**](StudentSectionAssociationsApi.md#getstudentsectionassociations) | **GET** /ed-fi/studentSectionAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentSectionAssociationsById**](StudentSectionAssociationsApi.md#getstudentsectionassociationsbyid) | **GET** /ed-fi/studentSectionAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudentSectionAssociation**](StudentSectionAssociationsApi.md#poststudentsectionassociation) | **POST** /ed-fi/studentSectionAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudentSectionAssociation**](StudentSectionAssociationsApi.md#putstudentsectionassociation) | **PUT** /ed-fi/studentSectionAssociations/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudentsectionassociationbyid"></a>
# **DeleteStudentSectionAssociationById**
> void DeleteStudentSectionAssociationById (string id, string ifMatch = null)

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
    public class DeleteStudentSectionAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSectionAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentSectionAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSectionAssociationsApi.DeleteStudentSectionAssociationById: " + e.Message );
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

<a name="getstudentsectionassociations"></a>
# **GetStudentSectionAssociations**
> List<EdFiStudentSectionAssociation> GetStudentSectionAssociations (int? offset = null, int? limit = null, bool? totalCount = null, DateTime? beginDate = null, string localCourseCode = null, int? schoolId = null, int? schoolYear = null, string sectionIdentifier = null, string sessionName = null, string studentUniqueId = null, string attemptStatusDescriptor = null, string repeatIdentifierDescriptor = null, DateTime? endDate = null, bool? homeroomIndicator = null, string id = null, bool? teacherStudentDataLinkExclusion = null)

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
    public class GetStudentSectionAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSectionAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var beginDate = 2013-10-20;  // DateTime? | Month, day, and year of the Student's entry or assignment to the Section. (optional) 
            var localCourseCode = localCourseCode_example;  // string | The local code assigned by the School that identifies the course offering provided for the instruction of students. (optional) 
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var schoolYear = 56;  // int? | The identifier for the school year. (optional) 
            var sectionIdentifier = sectionIdentifier_example;  // string | The local identifier assigned to a section. (optional) 
            var sessionName = sessionName_example;  // string | The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var attemptStatusDescriptor = attemptStatusDescriptor_example;  // string | An indication of the student's attempt status for the section. (optional) 
            var repeatIdentifierDescriptor = repeatIdentifierDescriptor_example;  // string | An indication as to whether a student has previously taken a given course.          Repeated, counted in grade point average          Repeated, not counted in grade point average          Not repeated          Other. (optional) 
            var endDate = 2013-10-20;  // DateTime? | Month, day, and year of the withdrawal or exit of the Student from the Section. (optional) 
            var homeroomIndicator = true;  // bool? | Indicates the Section is the student's homeroom. Homeroom period may the convention for taking daily attendance. (optional) 
            var id = id_example;  // string |  (optional) 
            var teacherStudentDataLinkExclusion = true;  // bool? | Indicates that the student-section combination is excluded from calculation of value-added or growth attribution calculations used for a particular teacher evaluation. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentSectionAssociation&gt; result = apiInstance.GetStudentSectionAssociations(offset, limit, totalCount, beginDate, localCourseCode, schoolId, schoolYear, sectionIdentifier, sessionName, studentUniqueId, attemptStatusDescriptor, repeatIdentifierDescriptor, endDate, homeroomIndicator, id, teacherStudentDataLinkExclusion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSectionAssociationsApi.GetStudentSectionAssociations: " + e.Message );
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
 **beginDate** | **DateTime?**| Month, day, and year of the Student&#39;s entry or assignment to the Section. | [optional] 
 **localCourseCode** | **string**| The local code assigned by the School that identifies the course offering provided for the instruction of students. | [optional] 
 **schoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **schoolYear** | **int?**| The identifier for the school year. | [optional] 
 **sectionIdentifier** | **string**| The local identifier assigned to a section. | [optional] 
 **sessionName** | **string**| The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **attemptStatusDescriptor** | **string**| An indication of the student&#39;s attempt status for the section. | [optional] 
 **repeatIdentifierDescriptor** | **string**| An indication as to whether a student has previously taken a given course.          Repeated, counted in grade point average          Repeated, not counted in grade point average          Not repeated          Other. | [optional] 
 **endDate** | **DateTime?**| Month, day, and year of the withdrawal or exit of the Student from the Section. | [optional] 
 **homeroomIndicator** | **bool?**| Indicates the Section is the student&#39;s homeroom. Homeroom period may the convention for taking daily attendance. | [optional] 
 **id** | **string**|  | [optional] 
 **teacherStudentDataLinkExclusion** | **bool?**| Indicates that the student-section combination is excluded from calculation of value-added or growth attribution calculations used for a particular teacher evaluation. | [optional] 

### Return type

[**List<EdFiStudentSectionAssociation>**](EdFiStudentSectionAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentsectionassociationsbyid"></a>
# **GetStudentSectionAssociationsById**
> EdFiStudentSectionAssociation GetStudentSectionAssociationsById (string id, string ifNoneMatch = null)

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
    public class GetStudentSectionAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSectionAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentSectionAssociation result = apiInstance.GetStudentSectionAssociationsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSectionAssociationsApi.GetStudentSectionAssociationsById: " + e.Message );
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

[**EdFiStudentSectionAssociation**](EdFiStudentSectionAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentsectionassociation"></a>
# **PostStudentSectionAssociation**
> void PostStudentSectionAssociation (EdFiStudentSectionAssociation studentSectionAssociation)

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
    public class PostStudentSectionAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSectionAssociationsApi();
            var studentSectionAssociation = new EdFiStudentSectionAssociation(); // EdFiStudentSectionAssociation | The JSON representation of the \"studentSectionAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentSectionAssociation(studentSectionAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSectionAssociationsApi.PostStudentSectionAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentSectionAssociation** | [**EdFiStudentSectionAssociation**](EdFiStudentSectionAssociation.md)| The JSON representation of the \&quot;studentSectionAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentsectionassociation"></a>
# **PutStudentSectionAssociation**
> void PutStudentSectionAssociation (string id, EdFiStudentSectionAssociation studentSectionAssociation, string ifMatch = null)

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
    public class PutStudentSectionAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentSectionAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentSectionAssociation = new EdFiStudentSectionAssociation(); // EdFiStudentSectionAssociation | The JSON representation of the \"studentSectionAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStudentSectionAssociation(id, studentSectionAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentSectionAssociationsApi.PutStudentSectionAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentSectionAssociation** | [**EdFiStudentSectionAssociation**](EdFiStudentSectionAssociation.md)| The JSON representation of the \&quot;studentSectionAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

