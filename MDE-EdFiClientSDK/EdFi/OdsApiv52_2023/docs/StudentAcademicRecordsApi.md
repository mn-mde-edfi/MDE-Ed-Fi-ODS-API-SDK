# EdFi.OdsApi.Sdk.Apis.Identity.StudentAcademicRecordsApi

All URIs are relative to *https://test.edfi5.education.mn.gov:443/api/data/v3/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStudentAcademicRecordById**](StudentAcademicRecordsApi.md#deletestudentacademicrecordbyid) | **DELETE** /ed-fi/studentAcademicRecords/{id} | Deletes an existing resource using the resource identifier.
[**DeletesStudentAcademicRecords**](StudentAcademicRecordsApi.md#deletesstudentacademicrecords) | **GET** /ed-fi/studentAcademicRecords/deletes | Retrieves deleted resources based on change version.
[**GetStudentAcademicRecords**](StudentAcademicRecordsApi.md#getstudentacademicrecords) | **GET** /ed-fi/studentAcademicRecords | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentAcademicRecordsById**](StudentAcademicRecordsApi.md#getstudentacademicrecordsbyid) | **GET** /ed-fi/studentAcademicRecords/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PostStudentAcademicRecord**](StudentAcademicRecordsApi.md#poststudentacademicrecord) | **POST** /ed-fi/studentAcademicRecords | Creates or updates resources based on the natural key values of the supplied resource.
[**PutStudentAcademicRecord**](StudentAcademicRecordsApi.md#putstudentacademicrecord) | **PUT** /ed-fi/studentAcademicRecords/{id} | Updates a resource based on the resource identifier.


<a name="deletestudentacademicrecordbyid"></a>
# **DeleteStudentAcademicRecordById**
> void DeleteStudentAcademicRecordById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class DeleteStudentAcademicRecordByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAcademicRecordsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentAcademicRecordById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAcademicRecordsApi.DeleteStudentAcademicRecordById: " + e.Message );
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

<a name="deletesstudentacademicrecords"></a>
# **DeletesStudentAcademicRecords**
> List<DeletedResource> DeletesStudentAcademicRecords (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, string snapshotIdentifier = null)

Retrieves deleted resources based on change version.

The DELETES operation is used to retrieve deleted resources.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class DeletesStudentAcademicRecordsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAcademicRecordsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List&lt;DeletedResource&gt; result = apiInstance.DeletesStudentAcademicRecords(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAcademicRecordsApi.DeletesStudentAcademicRecords: " + e.Message );
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
 **minChangeVersion** | **int?**| Used in synchronization to set sequence minimum ChangeVersion | [optional] 
 **maxChangeVersion** | **int?**| Used in synchronization to set sequence maximum ChangeVersion | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<DeletedResource>**](DeletedResource.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentacademicrecords"></a>
# **GetStudentAcademicRecords**
> List<EdFiStudentAcademicRecord> GetStudentAcademicRecords (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, bool? totalCount = null, string termDescriptor = null, int? educationOrganizationId = null, int? schoolYear = null, string studentUniqueId = null, string cumulativeEarnedCreditTypeDescriptor = null, string cumulativeAttemptedCreditTypeDescriptor = null, string sessionEarnedCreditTypeDescriptor = null, string sessionAttemptedCreditTypeDescriptor = null, double? cumulativeAttemptedCreditConversion = null, double? cumulativeAttemptedCredits = null, double? cumulativeEarnedCreditConversion = null, double? cumulativeEarnedCredits = null, double? cumulativeGradePointAverage = null, double? cumulativeGradePointsEarned = null, string gradeValueQualifier = null, string id = null, DateTime? projectedGraduationDate = null, double? sessionAttemptedCreditConversion = null, double? sessionAttemptedCredits = null, double? sessionEarnedCreditConversion = null, double? sessionEarnedCredits = null, double? sessionGradePointAverage = null, double? sessionGradePointsEarned = null, string snapshotIdentifier = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class GetStudentAcademicRecordsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAcademicRecordsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var termDescriptor = termDescriptor_example;  // string | The term for the session during the school year. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var schoolYear = 56;  // int? | The identifier for the school year. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var cumulativeEarnedCreditTypeDescriptor = cumulativeEarnedCreditTypeDescriptor_example;  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var cumulativeAttemptedCreditTypeDescriptor = cumulativeAttemptedCreditTypeDescriptor_example;  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var sessionEarnedCreditTypeDescriptor = sessionEarnedCreditTypeDescriptor_example;  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var sessionAttemptedCreditTypeDescriptor = sessionAttemptedCreditTypeDescriptor_example;  // string | The type of credits or units of value awarded for the completion of a course. (optional) 
            var cumulativeAttemptedCreditConversion = 1.2;  // double? | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var cumulativeAttemptedCredits = 1.2;  // double? | The value of credits or units of value awarded for the completion of a course. (optional) 
            var cumulativeEarnedCreditConversion = 1.2;  // double? | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var cumulativeEarnedCredits = 1.2;  // double? | The value of credits or units of value awarded for the completion of a course. (optional) 
            var cumulativeGradePointAverage = 1.2;  // double? | A measure of average performance in all courses taken by an individual during his or her school career as determined for record-keeping purposes. This is obtained by dividing the total grade points received by the total number of credits attempted. This usually includes grade points received and credits attempted in his or her current school as well as those transferred from schools in which the individual was previously enrolled. (optional) 
            var cumulativeGradePointsEarned = 1.2;  // double? | The cumulative number of grade points an individual earns by successfully completing courses or examinations during his or her enrollment in the current school as well as those transferred from schools in which the individual had been previously enrolled. (optional) 
            var gradeValueQualifier = gradeValueQualifier_example;  // string | The scale of equivalents, if applicable, for grades awarded as indicators of performance in schoolwork. For example, numerical equivalents for letter grades used in determining a student's Grade Point Average (A=4, B=3, C=2, D=1 in a four-point system) or letter equivalents for percentage grades (90-100%=A, 80-90%=B, etc.) (optional) 
            var id = id_example;  // string |  (optional) 
            var projectedGraduationDate = 2013-10-20;  // DateTime? | The month and year the student is projected to graduate. (optional) 
            var sessionAttemptedCreditConversion = 1.2;  // double? | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var sessionAttemptedCredits = 1.2;  // double? | The value of credits or units of value awarded for the completion of a course. (optional) 
            var sessionEarnedCreditConversion = 1.2;  // double? | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. (optional) 
            var sessionEarnedCredits = 1.2;  // double? | The value of credits or units of value awarded for the completion of a course. (optional) 
            var sessionGradePointAverage = 1.2;  // double? | The grade point average for an individual computed as the grade points earned during the session divided by the number of credits attempted. (optional) 
            var sessionGradePointsEarned = 1.2;  // double? | The number of grade points an individual earned for this session. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;EdFiStudentAcademicRecord&gt; result = apiInstance.GetStudentAcademicRecords(offset, limit, minChangeVersion, maxChangeVersion, totalCount, termDescriptor, educationOrganizationId, schoolYear, studentUniqueId, cumulativeEarnedCreditTypeDescriptor, cumulativeAttemptedCreditTypeDescriptor, sessionEarnedCreditTypeDescriptor, sessionAttemptedCreditTypeDescriptor, cumulativeAttemptedCreditConversion, cumulativeAttemptedCredits, cumulativeEarnedCreditConversion, cumulativeEarnedCredits, cumulativeGradePointAverage, cumulativeGradePointsEarned, gradeValueQualifier, id, projectedGraduationDate, sessionAttemptedCreditConversion, sessionAttemptedCredits, sessionEarnedCreditConversion, sessionEarnedCredits, sessionGradePointAverage, sessionGradePointsEarned, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAcademicRecordsApi.GetStudentAcademicRecords: " + e.Message );
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
 **minChangeVersion** | **int?**| Used in synchronization to set sequence minimum ChangeVersion | [optional] 
 **maxChangeVersion** | **int?**| Used in synchronization to set sequence maximum ChangeVersion | [optional] 
 **totalCount** | **bool?**| Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false]
 **termDescriptor** | **string**| The term for the session during the school year. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **schoolYear** | **int?**| The identifier for the school year. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **cumulativeEarnedCreditTypeDescriptor** | **string**| The type of credits or units of value awarded for the completion of a course. | [optional] 
 **cumulativeAttemptedCreditTypeDescriptor** | **string**| The type of credits or units of value awarded for the completion of a course. | [optional] 
 **sessionEarnedCreditTypeDescriptor** | **string**| The type of credits or units of value awarded for the completion of a course. | [optional] 
 **sessionAttemptedCreditTypeDescriptor** | **string**| The type of credits or units of value awarded for the completion of a course. | [optional] 
 **cumulativeAttemptedCreditConversion** | **double?**| Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
 **cumulativeAttemptedCredits** | **double?**| The value of credits or units of value awarded for the completion of a course. | [optional] 
 **cumulativeEarnedCreditConversion** | **double?**| Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
 **cumulativeEarnedCredits** | **double?**| The value of credits or units of value awarded for the completion of a course. | [optional] 
 **cumulativeGradePointAverage** | **double?**| A measure of average performance in all courses taken by an individual during his or her school career as determined for record-keeping purposes. This is obtained by dividing the total grade points received by the total number of credits attempted. This usually includes grade points received and credits attempted in his or her current school as well as those transferred from schools in which the individual was previously enrolled. | [optional] 
 **cumulativeGradePointsEarned** | **double?**| The cumulative number of grade points an individual earns by successfully completing courses or examinations during his or her enrollment in the current school as well as those transferred from schools in which the individual had been previously enrolled. | [optional] 
 **gradeValueQualifier** | **string**| The scale of equivalents, if applicable, for grades awarded as indicators of performance in schoolwork. For example, numerical equivalents for letter grades used in determining a student&#39;s Grade Point Average (A&#x3D;4, B&#x3D;3, C&#x3D;2, D&#x3D;1 in a four-point system) or letter equivalents for percentage grades (90-100%&#x3D;A, 80-90%&#x3D;B, etc.) | [optional] 
 **id** | **string**|  | [optional] 
 **projectedGraduationDate** | **DateTime?**| The month and year the student is projected to graduate. | [optional] 
 **sessionAttemptedCreditConversion** | **double?**| Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
 **sessionAttemptedCredits** | **double?**| The value of credits or units of value awarded for the completion of a course. | [optional] 
 **sessionEarnedCreditConversion** | **double?**| Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
 **sessionEarnedCredits** | **double?**| The value of credits or units of value awarded for the completion of a course. | [optional] 
 **sessionGradePointAverage** | **double?**| The grade point average for an individual computed as the grade points earned during the session divided by the number of credits attempted. | [optional] 
 **sessionGradePointsEarned** | **double?**| The number of grade points an individual earned for this session. | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<EdFiStudentAcademicRecord>**](EdFiStudentAcademicRecord.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentacademicrecordsbyid"></a>
# **GetStudentAcademicRecordsById**
> EdFiStudentAcademicRecord GetStudentAcademicRecordsById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class GetStudentAcademicRecordsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAcademicRecordsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentAcademicRecord result = apiInstance.GetStudentAcademicRecordsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAcademicRecordsApi.GetStudentAcademicRecordsById: " + e.Message );
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
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**EdFiStudentAcademicRecord**](EdFiStudentAcademicRecord.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentacademicrecord"></a>
# **PostStudentAcademicRecord**
> void PostStudentAcademicRecord (EdFiStudentAcademicRecord studentAcademicRecord)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error. The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately. It is recommended to use POST for both create and update except while updating natural key of a resource in which case PUT operation must be used.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class PostStudentAcademicRecordExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAcademicRecordsApi();
            var studentAcademicRecord = new EdFiStudentAcademicRecord(); // EdFiStudentAcademicRecord | The JSON representation of the \"studentAcademicRecord\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentAcademicRecord(studentAcademicRecord);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAcademicRecordsApi.PostStudentAcademicRecord: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentAcademicRecord** | [**EdFiStudentAcademicRecord**](EdFiStudentAcademicRecord.md)| The JSON representation of the \&quot;studentAcademicRecord\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentacademicrecord"></a>
# **PutStudentAcademicRecord**
> void PutStudentAcademicRecord (string id, EdFiStudentAcademicRecord studentAcademicRecord, string ifMatch = null)

Updates a resource based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, this API resource is not configured for cascading natural key updates. Natural key values for this resource cannot be changed using PUT operation and will not be modified in the database, and so recommendation is to use POST as that supports upsert behavior.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Identity;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Identity;

namespace Example
{
    public class PutStudentAcademicRecordExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentAcademicRecordsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentAcademicRecord = new EdFiStudentAcademicRecord(); // EdFiStudentAcademicRecord | The JSON representation of the \"studentAcademicRecord\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutStudentAcademicRecord(id, studentAcademicRecord, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentAcademicRecordsApi.PutStudentAcademicRecord: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentAcademicRecord** | [**EdFiStudentAcademicRecord**](EdFiStudentAcademicRecord.md)| The JSON representation of the \&quot;studentAcademicRecord\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

