# EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile.StudentEarlyChildhoodScreeningProgramAssociationsApi

All URIs are relative to *http://localhost:54746/data/v3/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletesStudentEarlyChildhoodScreeningProgramAssociations**](StudentEarlyChildhoodScreeningProgramAssociationsApi.md#deletesstudentearlychildhoodscreeningprogramassociations) | **GET** /MN/studentEarlyChildhoodScreeningProgramAssociations/deletes | Retrieves deleted resources based on change version.
[**DeletestudentEarlyChildhoodScreeningProgramAssociationById**](StudentEarlyChildhoodScreeningProgramAssociationsApi.md#deletestudentearlychildhoodscreeningprogramassociationbyid) | **DELETE** /MN/studentEarlyChildhoodScreeningProgramAssociations/{id} | Deletes an existing resource using the resource identifier.
[**GetStudentEarlyChildhoodScreeningProgramAssociations**](StudentEarlyChildhoodScreeningProgramAssociationsApi.md#getstudentearlychildhoodscreeningprogramassociations) | **GET** /MN/studentEarlyChildhoodScreeningProgramAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern).
[**GetStudentEarlyChildhoodScreeningProgramAssociationsById**](StudentEarlyChildhoodScreeningProgramAssociationsApi.md#getstudentearlychildhoodscreeningprogramassociationsbyid) | **GET** /MN/studentEarlyChildhoodScreeningProgramAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern).
[**PoststudentEarlyChildhoodScreeningProgramAssociation**](StudentEarlyChildhoodScreeningProgramAssociationsApi.md#poststudentearlychildhoodscreeningprogramassociation) | **POST** /MN/studentEarlyChildhoodScreeningProgramAssociations | Creates or updates resources based on the natural key values of the supplied resource.
[**PutstudentEarlyChildhoodScreeningProgramAssociation**](StudentEarlyChildhoodScreeningProgramAssociationsApi.md#putstudentearlychildhoodscreeningprogramassociation) | **PUT** /MN/studentEarlyChildhoodScreeningProgramAssociations/{id} | Updates a resource based on the resource identifier.


<a name="deletesstudentearlychildhoodscreeningprogramassociations"></a>
# **DeletesStudentEarlyChildhoodScreeningProgramAssociations**
> List<DeletedResource> DeletesStudentEarlyChildhoodScreeningProgramAssociations (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, string snapshotIdentifier = null)

Retrieves deleted resources based on change version.

The DELETES operation is used to retrieve deleted resources.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile;

namespace Example
{
    public class DeletesStudentEarlyChildhoodScreeningProgramAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEarlyChildhoodScreeningProgramAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List&lt;DeletedResource&gt; result = apiInstance.DeletesStudentEarlyChildhoodScreeningProgramAssociations(offset, limit, minChangeVersion, maxChangeVersion, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentEarlyChildhoodScreeningProgramAssociationsApi.DeletesStudentEarlyChildhoodScreeningProgramAssociations: " + e.Message );
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

 - **Content-Type**: application/vnd.ed-fi.studentearlychildhoodscreeningprogramassociation.minnesota-twentytwo-twentythree-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletestudentearlychildhoodscreeningprogramassociationbyid"></a>
# **DeletestudentEarlyChildhoodScreeningProgramAssociationById**
> void DeletestudentEarlyChildhoodScreeningProgramAssociationById (string id, string ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile;

namespace Example
{
    public class DeletestudentEarlyChildhoodScreeningProgramAssociationByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEarlyChildhoodScreeningProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeletestudentEarlyChildhoodScreeningProgramAssociationById(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentEarlyChildhoodScreeningProgramAssociationsApi.DeletestudentEarlyChildhoodScreeningProgramAssociationById: " + e.Message );
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

 - **Content-Type**: application/vnd.ed-fi.studentearlychildhoodscreeningprogramassociation.minnesota-twentytwo-twentythree-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentearlychildhoodscreeningprogramassociations"></a>
# **GetStudentEarlyChildhoodScreeningProgramAssociations**
> List<MnStudentEarlyChildhoodScreeningProgramAssociationReadable> GetStudentEarlyChildhoodScreeningProgramAssociations (int? offset = null, int? limit = null, int? minChangeVersion = null, int? maxChangeVersion = null, bool? totalCount = null, DateTime? beginDate = null, int? educationOrganizationId = null, int? programEducationOrganizationId = null, string programName = null, string programTypeDescriptor = null, string studentUniqueId = null, string earlyChildhoodScreenerDescriptor = null, string earlyChildhoodScreeningExitStatusDescriptor = null, string snapshotIdentifier = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile;

namespace Example
{
    public class GetStudentEarlyChildhoodScreeningProgramAssociationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEarlyChildhoodScreeningProgramAssociationsApi();
            var offset = 56;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 56;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 56;  // int? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 56;  // int? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = true;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var beginDate = 2013-10-20;  // DateTime? | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. (optional) 
            var educationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programEducationOrganizationId = 56;  // int? | The identifier assigned to an education organization. (optional) 
            var programName = programName_example;  // string | The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. (optional) 
            var programTypeDescriptor = programTypeDescriptor_example;  // string | The type of program. (optional) 
            var studentUniqueId = studentUniqueId_example;  // string | A unique alphanumeric code assigned to a student. (optional) 
            var earlyChildhoodScreenerDescriptor = earlyChildhoodScreenerDescriptor_example;  // string | This descriptor contains codes indicating who completed a screening for a student in the Early Childhood Screening program. (optional) 
            var earlyChildhoodScreeningExitStatusDescriptor = earlyChildhoodScreeningExitStatusDescriptor_example;  // string | Early Childhood Screening Exit Status. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List&lt;MnStudentEarlyChildhoodScreeningProgramAssociationReadable&gt; result = apiInstance.GetStudentEarlyChildhoodScreeningProgramAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, beginDate, educationOrganizationId, programEducationOrganizationId, programName, programTypeDescriptor, studentUniqueId, earlyChildhoodScreenerDescriptor, earlyChildhoodScreeningExitStatusDescriptor, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentEarlyChildhoodScreeningProgramAssociationsApi.GetStudentEarlyChildhoodScreeningProgramAssociations: " + e.Message );
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
 **beginDate** | **DateTime?**| The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. | [optional] 
 **educationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **programEducationOrganizationId** | **int?**| The identifier assigned to an education organization. | [optional] 
 **programName** | **string**| The formal name of the Program of instruction, training, services, or benefits available through federal, state, or local agencies. | [optional] 
 **programTypeDescriptor** | **string**| The type of program. | [optional] 
 **studentUniqueId** | **string**| A unique alphanumeric code assigned to a student. | [optional] 
 **earlyChildhoodScreenerDescriptor** | **string**| This descriptor contains codes indicating who completed a screening for a student in the Early Childhood Screening program. | [optional] 
 **earlyChildhoodScreeningExitStatusDescriptor** | **string**| Early Childhood Screening Exit Status. | [optional] 
 **snapshotIdentifier** | **string**| Indicates the Snapshot-Identifier that should be used. | [optional] 

### Return type

[**List<MnStudentEarlyChildhoodScreeningProgramAssociationReadable>**](MnStudentEarlyChildhoodScreeningProgramAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.studentearlychildhoodscreeningprogramassociation.minnesota-twentytwo-twentythree-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstudentearlychildhoodscreeningprogramassociationsbyid"></a>
# **GetStudentEarlyChildhoodScreeningProgramAssociationsById**
> MnStudentEarlyChildhoodScreeningProgramAssociationReadable GetStudentEarlyChildhoodScreeningProgramAssociationsById (string id, string ifNoneMatch = null, string snapshotIdentifier = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile;

namespace Example
{
    public class GetStudentEarlyChildhoodScreeningProgramAssociationsByIdExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEarlyChildhoodScreeningProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = ifNoneMatch_example;  // string | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = snapshotIdentifier_example;  // string | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                MnStudentEarlyChildhoodScreeningProgramAssociationReadable result = apiInstance.GetStudentEarlyChildhoodScreeningProgramAssociationsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentEarlyChildhoodScreeningProgramAssociationsApi.GetStudentEarlyChildhoodScreeningProgramAssociationsById: " + e.Message );
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

[**MnStudentEarlyChildhoodScreeningProgramAssociationReadable**](MnStudentEarlyChildhoodScreeningProgramAssociationReadable.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.ed-fi.studentearlychildhoodscreeningprogramassociation.minnesota-twentytwo-twentythree-sisvendorprofile.readable+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="poststudentearlychildhoodscreeningprogramassociation"></a>
# **PoststudentEarlyChildhoodScreeningProgramAssociation**
> void PoststudentEarlyChildhoodScreeningProgramAssociation (MnStudentEarlyChildhoodScreeningProgramAssociationWritable studentEarlyChildhoodScreeningProgramAssociation)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error. The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately. It is recommended to use POST for both create and update except while updating natural key of a resource in which case PUT operation must be used.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile;

namespace Example
{
    public class PoststudentEarlyChildhoodScreeningProgramAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEarlyChildhoodScreeningProgramAssociationsApi();
            var studentEarlyChildhoodScreeningProgramAssociation = new MnStudentEarlyChildhoodScreeningProgramAssociationWritable(); // MnStudentEarlyChildhoodScreeningProgramAssociationWritable | The JSON representation of the \"studentEarlyChildhoodScreeningProgramAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PoststudentEarlyChildhoodScreeningProgramAssociation(studentEarlyChildhoodScreeningProgramAssociation);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentEarlyChildhoodScreeningProgramAssociationsApi.PoststudentEarlyChildhoodScreeningProgramAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **studentEarlyChildhoodScreeningProgramAssociation** | [**MnStudentEarlyChildhoodScreeningProgramAssociationWritable**](MnStudentEarlyChildhoodScreeningProgramAssociationWritable.md)| The JSON representation of the \&quot;studentEarlyChildhoodScreeningProgramAssociation\&quot; resource to be created or updated. | 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studentearlychildhoodscreeningprogramassociation.minnesota-twentytwo-twentythree-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putstudentearlychildhoodscreeningprogramassociation"></a>
# **PutstudentEarlyChildhoodScreeningProgramAssociation**
> void PutstudentEarlyChildhoodScreeningProgramAssociation (string id, MnStudentEarlyChildhoodScreeningProgramAssociationWritable studentEarlyChildhoodScreeningProgramAssociation, string ifMatch = null)

Updates a resource based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, this API resource is not configured for cascading natural key updates. Natural key values for this resource cannot be changed using PUT operation and will not be modified in the database, and so recommendation is to use POST as that supports upsert behavior.

### Example
```csharp
using System;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.Apis.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile;
using EdFi.OdsApi.Sdk.Client;
using EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile;

namespace Example
{
    public class PutstudentEarlyChildhoodScreeningProgramAssociationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentEarlyChildhoodScreeningProgramAssociationsApi();
            var id = id_example;  // string | A resource identifier that uniquely identifies the resource.
            var studentEarlyChildhoodScreeningProgramAssociation = new MnStudentEarlyChildhoodScreeningProgramAssociationWritable(); // MnStudentEarlyChildhoodScreeningProgramAssociationWritable | The JSON representation of the \"studentEarlyChildhoodScreeningProgramAssociation\" resource to be created or updated.
            var ifMatch = ifMatch_example;  // string | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutstudentEarlyChildhoodScreeningProgramAssociation(id, studentEarlyChildhoodScreeningProgramAssociation, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StudentEarlyChildhoodScreeningProgramAssociationsApi.PutstudentEarlyChildhoodScreeningProgramAssociation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A resource identifier that uniquely identifies the resource. | 
 **studentEarlyChildhoodScreeningProgramAssociation** | [**MnStudentEarlyChildhoodScreeningProgramAssociationWritable**](MnStudentEarlyChildhoodScreeningProgramAssociationWritable.md)| The JSON representation of the \&quot;studentEarlyChildhoodScreeningProgramAssociation\&quot; resource to be created or updated. | 
 **ifMatch** | **string**| The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/vnd.ed-fi.studentearlychildhoodscreeningprogramassociation.minnesota-twentytwo-twentythree-sisvendorprofile.writable+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

