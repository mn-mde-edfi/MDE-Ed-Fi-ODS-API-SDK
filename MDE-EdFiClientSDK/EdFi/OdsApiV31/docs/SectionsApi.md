# EdFi.OdsApi.Sdk.Apis.All.SectionsApi

All URIs are relative to *https://localhost:56641/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSectionById**](SectionsApi.md#deletesectionbyid) | **DELETE** /ed-fi/sections/{id} | Deletes an existing resource using the resource identifier.
[**GetSections**](SectionsApi.md#getsections) | **GET** /ed-fi/sections | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetSectionsById**](SectionsApi.md#getsectionsbyid) | **GET** /ed-fi/sections/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostSection**](SectionsApi.md#postsection) | **POST** /ed-fi/sections | Creates or updates resources based on the natural key values of the supplied resource.
[**PutSection**](SectionsApi.md#putsection) | **PUT** /ed-fi/sections/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletesectionbyid"></a>
# **DeleteSectionById**
> void DeleteSectionById (string id, string ifMatch = null)

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
    public class DeleteSectionByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SectionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteSectionById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SectionsApi.DeleteSectionById: " + e.Message );
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

<a name="getsections"></a>
# **GetSections**
> List<EdFiSection> GetSections (int? offset = null, int? limit = null, bool? totalCount = null, string sectionIdentifier = null, string localCourseCode = null, int? schoolId = null, int? schoolYear = null, string sessionName = null, string locationClassroomIdentificationCode = null, int? locationSchoolId = null, string availableCreditTypeDescriptor = null, string educationalEnvironmentDescriptor = null, string instructionLanguageDescriptor = null, string mediumOfInstructionDescriptor = null, string populationServedDescriptor = null, double? availableCreditConversion = null, double? availableCredits = null, string id = null, int? sequenceOfCourse = null)

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
    public class GetSectionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SectionsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var sectionIdentifier = sectionIdentifier_example;  // string | The local identifier assigned to a section. (optional) 
            var localCourseCode = localCourseCode_example;  // string | The local code assigned by the School that identifies the course offering provided for the instruction of students. (optional) 
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var schoolYear = 56;  // int? | The identifier for the school year. (optional) 
            var sessionName = sessionName_example;  // string | The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). (optional) 
            var locationClassroomIdentificationCode = locationClassroomIdentificationCode_example;  // string | A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity. (optional) 
            var locationSchoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var availableCreditTypeDescriptor = availableCreditTypeDescriptor_example;  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var educationalEnvironmentDescriptor = educationalEnvironmentDescriptor_example;  // string | The setting in which a child receives education and related services; for example:          Center-based instruction          Home-based instruction          Hospital class          Mainstream          Residential care and treatment facility          ... (optional) 
            var instructionLanguageDescriptor = instructionLanguageDescriptor_example;  // string | The primary language of instruction, if omitted English is assumed. (optional) 
            var mediumOfInstructionDescriptor = mediumOfInstructionDescriptor_example;  // string | The media through which teachers provide instruction to students and students and teachers communicate about instructional matters; for example:          Technology-based instruction in classroom          Correspondence instruction          Face-to-face instruction          Virtual/On-line Distance learning          Center-based instruction          ... (optional) 
            var populationServedDescriptor = populationServedDescriptor_example;  // string | The type of students the Section is offered and tailored to; for example:          Bilingual students          Remedial education students          Gifted and talented students          Career and Technical Education students          Special education students          ... (optional) 
            var availableCreditConversion = 1.2;  // double? | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var availableCredits = 1.2;  // double? | The value of credits or units of value awarded for the completion of a course. (optional) 
            var id = id_example;  // string |  (optional) 
            var sequenceOfCourse = 56;  // int? | When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiSection&gt; result = apiInstance.GetSections(offset, limit, totalCount, sectionIdentifier, localCourseCode, schoolId, schoolYear, sessionName, locationClassroomIdentificationCode, locationSchoolId, availableCreditTypeDescriptor, educationalEnvironmentDescriptor, instructionLanguageDescriptor, mediumOfInstructionDescriptor, populationServedDescriptor, availableCreditConversion, availableCredits, id, sequenceOfCourse);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SectionsApi.GetSections: " + e.Message );
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
 **sectionIdentifier** | **string**| The local identifier assigned to a section. | [optional] 
 **localCourseCode** | **string**| The local code assigned by the School that identifies the course offering provided for the instruction of students. | [optional] 
 **schoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **schoolYear** | **int?**| The identifier for the school year. | [optional] 
 **sessionName** | **string**| The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). | [optional] 
 **locationClassroomIdentificationCode** | **string**| A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity. | [optional] 
 **locationSchoolId** | **int?**| The identifier assigned to a school. | [optional] 
 **availableCreditTypeDescriptor** | **string**| The type of credits or units of value awarded for the completion of a course. | [optional] 
 **educationalEnvironmentDescriptor** | **string**| The setting in which a child receives education and related services; for example:          Center-based instruction          Home-based instruction          Hospital class          Mainstream          Residential care and treatment facility          ... | [optional] 
 **instructionLanguageDescriptor** | **string**| The primary language of instruction, if omitted English is assumed. | [optional] 
 **mediumOfInstructionDescriptor** | **string**| The media through which teachers provide instruction to students and students and teachers communicate about instructional matters; for example:          Technology-based instruction in classroom          Correspondence instruction          Face-to-face instruction          Virtual/On-line Distance learning          Center-based instruction          ... | [optional] 
 **populationServedDescriptor** | **string**| The type of students the Section is offered and tailored to; for example:          Bilingual students          Remedial education students          Gifted and talented students          Career and Technical Education students          Special education students          ... | [optional] 
 **availableCreditConversion** | **double?**| Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
 **availableCredits** | **double?**| The value of credits or units of value awarded for the completion of a course. | [optional] 
 **id** | **string**|  | [optional] 
 **sequenceOfCourse** | **int?**| When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1. | [optional] 

### Return type

[**List<EdFiSection>**](EdFiSection.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsectionsbyid"></a>
# **GetSectionsById**
> EdFiSection GetSectionsById (string id, string ifNoneMatch = null)

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
    public class GetSectionsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SectionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiSection result = apiInstance.GetSectionsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SectionsApi.GetSectionsById: " + e.Message );
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

[**EdFiSection**](EdFiSection.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsection"></a>
# **PostSection**
> void PostSection (EdFiSection section)

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
    public class PostSectionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SectionsApi();
            var section = new EdFiSection(); // EdFiSection | The JSON representation of the \"section\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostSection(section);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SectionsApi.PostSection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **section** | [**EdFiSection**](EdFiSection.md)| The JSON representation of the \&quot;section\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsection"></a>
# **PutSection**
> void PutSection (string id, EdFiSection section, string ifMatch = null)

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
    public class PutSectionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SectionsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var section = new EdFiSection(); // EdFiSection | The JSON representation of the \"section\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutSection(id, section, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SectionsApi.PutSection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **section** | [**EdFiSection**](EdFiSection.md)| The JSON representation of the \&quot;section\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

