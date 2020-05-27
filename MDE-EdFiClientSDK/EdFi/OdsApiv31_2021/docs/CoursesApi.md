# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile.CoursesApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/sb20_/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletecourseById**](CoursesApi.md#deletecoursebyid) | **DELETE** /ed-fi/courses/{id} | Deletes an existing resource using the resource identifier.
[**GetCourses**](CoursesApi.md#getcourses) | **GET** /ed-fi/courses | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetCoursesById**](CoursesApi.md#getcoursesbyid) | **GET** /ed-fi/courses/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**Postcourse**](CoursesApi.md#postcourse) | **POST** /ed-fi/courses | Creates or updates resources based on the natural key values of the supplied resource.
[**Putcourse**](CoursesApi.md#putcourse) | **PUT** /ed-fi/courses/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletecoursebyid"></a>
# **DeletecourseById**
> void DeletecourseById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;

namespace Example
{
    public class DeletecourseByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CoursesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeletecourseById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoursesApi.DeletecourseById: " + e.Message );
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

 - **Content-Type**: application/vnd.ed-fi.course.minnesota-twentytwentytwopreview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcourses"></a>
# **GetCourses**
> List<EdFiCourseReadable> GetCourses (int? offset = null, int? limit = null, bool? totalCount = null, string courseCode = null, int? educationOrganizationId = null, string courseDefinedByDescriptor = null, string courseDescription = null, string courseTitle = null, DateTime? dateCourseAdopted = null, bool? highSchoolCourseRequirement = null, string id = null, double? maximumAvailableCredits = null, int? numberOfParts = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;

namespace Example
{
    public class GetCoursesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CoursesApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var courseCode = courseCode_example;  // string | A unique alphanumeric code assigned to a course. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var courseDefinedByDescriptor = courseDefinedByDescriptor_example;  // string | Specifies whether the course was defined by the SEA, LEA, School, or national organization. (optional) 
            var courseDescription = courseDescription_example;  // string | A description of the content standards and goals covered in the course. Reference may be made to state or national content standards. (optional) 
            var courseTitle = courseTitle_example;  // string | The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, and language arts). (optional) 
            var dateCourseAdopted = 2013-10-20;  // DateTime? | Date the course was adopted by the education agency. (optional) 
            var highSchoolCourseRequirement = true;  // bool? | An indication that this course may satisfy high school graduation requirements in the course's subject area. (optional) 
            var id = id_example;  // string |  (optional) 
            var maximumAvailableCredits = 1.2;  // double? | The value of credits or units of value awarded for the completion of a course. (optional) 
            var numberOfParts = 56;  // int? | The number of parts identified for a course. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiCourseReadable&gt; result = apiInstance.GetCourses(offset, limit, totalCount, courseCode, educationOrganizationId, courseDefinedByDescriptor, courseDescription, courseTitle, dateCourseAdopted, highSchoolCourseRequirement, id, maximumAvailableCredits, numberOfParts);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoursesApi.GetCourses: " + e.Message );
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
 **courseCode** | **string**| A unique alphanumeric code assigned to a course. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **courseDefinedByDescriptor** | **string**| Specifies whether the course was defined by the SEA, LEA, School, or national organization. | [optional] 
 **courseDescription** | **string**| A description of the content standards and goals covered in the course. Reference may be made to state or national content standards. | [optional] 
 **courseTitle** | **string**| The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, and language arts). | [optional] 
 **dateCourseAdopted** | **DateTime?**| Date the course was adopted by the education agency. | [optional] 
 **highSchoolCourseRequirement** | **bool?**| An indication that this course may satisfy high school graduation requirements in the course&#39;s subject area. | [optional] 
 **id** | **string**|  | [optional] 
 **maximumAvailableCredits** | **double?**| The value of credits or units of value awarded for the completion of a course. | [optional] 
 **numberOfParts** | **int?**| The number of parts identified for a course. | [optional] 

### Return type

[**List<EdFiCourseReadable>**](EdFiCourseReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.course.minnesota-twentytwentytwopreview-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcoursesbyid"></a>
# **GetCoursesById**
> EdFiCourseReadable GetCoursesById (string id, string ifNoneMatch = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;

namespace Example
{
    public class GetCoursesByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CoursesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiCourseReadable result = apiInstance.GetCoursesById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoursesApi.GetCoursesById: " + e.Message );
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

[**EdFiCourseReadable**](EdFiCourseReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.course.minnesota-twentytwentytwopreview-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcourse"></a>
# **Postcourse**
> void Postcourse (EdFiCourseWritable course)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error (you must use a PUT operation to update a resource by \"id\"). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;

namespace Example
{
    public class PostcourseExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CoursesApi();
            var course = new EdFiCourseWritable(); // EdFiCourseWritable | The JSON representation of the \"course\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.Postcourse(course);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoursesApi.Postcourse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **course** | [**EdFiCourseWritable**](EdFiCourseWritable.md)| The JSON representation of the \&quot;course\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.course.minnesota-twentytwentytwopreview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putcourse"></a>
# **Putcourse**
> void Putcourse (string id, EdFiCourseWritable course, string ifMatch = null)

Updates or creates a resource based on the resource identifier.

The PUT operation is used to update or create a resource by identifier. If the resource doesn't exist, the resource will be created using that identifier. Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource \"id\" is provided in the JSON body, it will be ignored as well.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile;

namespace Example
{
    public class PutcourseExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CoursesApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var course = new EdFiCourseWritable(); // EdFiCourseWritable | The JSON representation of the \"course\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.Putcourse(id, course, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CoursesApi.Putcourse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **course** | [**EdFiCourseWritable**](EdFiCourseWritable.md)| The JSON representation of the \&quot;course\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.course.minnesota-twentytwentytwopreview-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

