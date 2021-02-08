# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile.EdFiSessionWritable
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**SessionName** | **string** | The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). | 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**SchoolYearTypeReference** | [**EdFiSchoolYearTypeReference**](EdFiSchoolYearTypeReference.md) |  | 
**BeginDate** | **DateTime?** | Month, day, and year of the first day of the Session. | 
**EndDate** | **DateTime?** | Month, day and year of the last day of the Session. | 
**TermDescriptor** | **string** | An descriptor value indicating the term (e.g. &#39;Fall Semester&#39;, &#39;Second Quarter&#39;, &#39;Summer Semester&#39;, etc.). | 
**TotalInstructionalDays** | **int?** | The total number of instructional days in the school calendar. | 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | [**SessionExtensionsWritable**](SessionExtensionsWritable.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

