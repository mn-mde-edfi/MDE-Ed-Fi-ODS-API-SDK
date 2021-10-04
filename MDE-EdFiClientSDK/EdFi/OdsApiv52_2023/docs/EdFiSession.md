# EdFi.OdsApi.Sdk.Models.Identity.EdFiSession
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**SessionName** | **string** | The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). | 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**SchoolYearTypeReference** | [**EdFiSchoolYearTypeReference**](EdFiSchoolYearTypeReference.md) |  | 
**AcademicWeeks** | [**List&lt;EdFiSessionAcademicWeek&gt;**](EdFiSessionAcademicWeek.md) | An unordered collection of sessionAcademicWeeks. The academic weeks associated with the school year. | [optional] 
**BeginDate** | **DateTime?** | Month, day, and year of the first day of the Session. | 
**EndDate** | **DateTime?** | Month, day and year of the last day of the Session. | 
**GradingPeriods** | [**List&lt;EdFiSessionGradingPeriod&gt;**](EdFiSessionGradingPeriod.md) | An unordered collection of sessionGradingPeriods. Grading periods associated with the session. | [optional] 
**TermDescriptor** | **string** | An descriptor value indicating the term (e.g. &#39;Semester&#39;, &#39;Quarter&#39;, etc.). | 
**TotalInstructionalDays** | **int?** | The total number of instructional days in the school calendar. | 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | [**SessionExtensions**](SessionExtensions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

