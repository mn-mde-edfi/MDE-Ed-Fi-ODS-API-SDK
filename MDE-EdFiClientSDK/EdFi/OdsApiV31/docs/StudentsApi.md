# EdFi.OdsApi.Sdk.Apis.All.StudentsApi

All URIs are relative to *https://test.edfi.education.mn.gov:443/edfi.ods.webapi/data/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentById**](StudentsApi.md#deletestudentbyid) | **DELETE** /ed-fi/students/{id} | Deletes an existing resource using the resource identifier.
[**GetStudents**](StudentsApi.md#getstudents) | **GET** /ed-fi/students | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentsById**](StudentsApi.md#getstudentsbyid) | **GET** /ed-fi/students/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudent**](StudentsApi.md#poststudent) | **POST** /ed-fi/students | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudent**](StudentsApi.md#putstudent) | **PUT** /ed-fi/students/{id} | Updates or creates a resource based on the resource identifier.


<a name="deletestudentbyid"></a>
# **DeleteStudentById**
> void DeleteStudentById (string id, string ifMatch = null)

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
    public class DeleteStudentByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentsApi.DeleteStudentById: " + e.Message );
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

<a name="getstudents"></a>
# **GetStudents**
> List<EdFiStudent> GetStudents (int? offset = null, int? limit = null, bool? totalCount = null, string studentUniqueId = null, string citizenshipStatusDescriptor = null, string birthCountryDescriptor = null, string birthSexDescriptor = null, string birthStateAbbreviationDescriptor = null, string birthCity = null, DateTime? birthDate = null, string birthInternationalProvince = null, DateTime? dateEnteredUS = null, string firstName = null, string generationCodeSuffix = null, string id = null, string lastSurname = null, string maidenName = null, string middleName = null, bool? multipleBirthStatus = null, string personalTitlePrefix = null)

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
    public class GetStudentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var citizenshipStatusDescriptor = citizenshipStatusDescriptor_example;  // string | An indicator of whether or not the person is a U.S. citizen. (optional) 
            var birthCountryDescriptor = birthCountryDescriptor_example;  // string | The country in which an individual is born. It is strongly recommended that entries use only ISO 3166 2-letter country codes. (optional) 
            var birthSexDescriptor = birthSexDescriptor_example;  // string | A person's gender at birth. (optional) 
            var birthStateAbbreviationDescriptor = birthStateAbbreviationDescriptor_example;  // string | The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which an individual was born. (optional) 
            var birthCity = birthCity_example;  // string | The city the student was born in. (optional) 
            var birthDate = 2013-10-20;  // DateTime? | The month, day, and year on which an individual was born. (optional) 
            var birthInternationalProvince = birthInternationalProvince_example;  // string | For students born outside of the U.S., the Province or jurisdiction in which an individual is born. (optional) 
            var dateEnteredUS = 2013-10-20;  // DateTime? | For students born outside of the U.S., the date the student entered the U.S. (optional) 
            var firstName = firstName_example;  // string | A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. (optional) 
            var generationCodeSuffix = generationCodeSuffix_example;  // string | An appendage, if any, used to denote an individual's generation in his family (e.g., Jr., Sr., III). (optional) 
            var id = id_example;  // string |  (optional) 
            var lastSurname = lastSurname_example;  // string | The name borne in common by members of a family. (optional) 
            var maidenName = maidenName_example;  // string | The person's maiden name. (optional) 
            var middleName = middleName_example;  // string | A secondary name given to an individual at birth, baptism, or during another naming ceremony. (optional) 
            var multipleBirthStatus = true;  // bool? | Indicator of whether the student was born with other siblings (i.e., twins, triplets, etc.) (optional) 
            var personalTitlePrefix = personalTitlePrefix_example;  // string | A prefix used to denote the title, degree, position, or seniority of the person. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudent&gt; result = apiInstance.GetStudents(offset, limit, totalCount, studentUniqueId, citizenshipStatusDescriptor, birthCountryDescriptor, birthSexDescriptor, birthStateAbbreviationDescriptor, birthCity, birthDate, birthInternationalProvince, dateEnteredUS, firstName, generationCodeSuffix, id, lastSurname, maidenName, middleName, multipleBirthStatus, personalTitlePrefix);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentsApi.GetStudents: " + e.Message );
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
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **citizenshipStatusDescriptor** | **string**| An indicator of whether or not the person is a U.S. citizen. | [optional] 
 **birthCountryDescriptor** | **string**| The country in which an individual is born. It is strongly recommended that entries use only ISO 3166 2-letter country codes. | [optional] 
 **birthSexDescriptor** | **string**| A person&#39;s gender at birth. | [optional] 
 **birthStateAbbreviationDescriptor** | **string**| The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which an individual was born. | [optional] 
 **birthCity** | **string**| The city the student was born in. | [optional] 
 **birthDate** | **DateTime?**| The month, day, and year on which an individual was born. | [optional] 
 **birthInternationalProvince** | **string**| For students born outside of the U.S., the Province or jurisdiction in which an individual is born. | [optional] 
 **dateEnteredUS** | **DateTime?**| For students born outside of the U.S., the date the student entered the U.S. | [optional] 
 **firstName** | **string**| A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. | [optional] 
 **generationCodeSuffix** | **string**| An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III). | [optional] 
 **id** | **string**|  | [optional] 
 **lastSurname** | **string**| The name borne in common by members of a family. | [optional] 
 **maidenName** | **string**| The person&#39;s maiden name. | [optional] 
 **middleName** | **string**| A secondary name given to an individual at birth, baptism, or during another naming ceremony. | [optional] 
 **multipleBirthStatus** | **bool?**| Indicator of whether the student was born with other siblings (i.e., twins, triplets, etc.) | [optional] 
 **personalTitlePrefix** | **string**| A prefix used to denote the title, degree, position, or seniority of the person. | [optional] 

### Return type

[**List<EdFiStudent>**](EdFiStudent.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentsbyid"></a>
# **GetStudentsById**
> EdFiStudent GetStudentsById (string id, string ifNoneMatch = null)

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
    public class GetStudentsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudent result = apiInstance.GetStudentsById(id, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentsApi.GetStudentsById: " + e.Message );
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

[**EdFiStudent**](EdFiStudent.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudent"></a>
# **PostStudent**
> void PostStudent (EdFiStudent student)

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
    public class PostStudentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentsApi();
            var student = new EdFiStudent(); // EdFiStudent | The JSON representation of the \"student\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudent(student);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentsApi.PostStudent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **student** | [**EdFiStudent**](EdFiStudent.md)| The JSON representation of the \&quot;student\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudent"></a>
# **PutStudent**
> void PutStudent (string id, EdFiStudent student, string ifMatch = null)

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
    public class PutStudentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var student = new EdFiStudent(); // EdFiStudent | The JSON representation of the \"student\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates or creates a resource based on the resource identifier.
                apiInstance.PutStudent(id, student, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentsApi.PutStudent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **student** | [**EdFiStudent**](EdFiStudent.md)| The JSON representation of the \&quot;student\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

