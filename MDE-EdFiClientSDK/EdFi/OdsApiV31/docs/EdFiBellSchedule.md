# EdFi.OdsApi.Sdk.Models.All.EdFiBellSchedule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**BellScheduleName** | **string** | Name or title of the BellSchedule. | 
**ClassPeriods** | [**List&lt;EdFiBellScheduleClassPeriod&gt;**](EdFiBellScheduleClassPeriod.md) | An unordered collection of bellScheduleClassPeriods. The class periods that compose this BellSchedule. | 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**AlternateDayName** | **string** | An alternate name for the day (e.g., Red, Blue). | [optional] 
**Dates** | [**List&lt;EdFiBellScheduleDate&gt;**](EdFiBellScheduleDate.md) | An unordered collection of bellScheduleDates. The dates for which the BellSchedule applies. | [optional] 
**GradeLevels** | [**List&lt;EdFiBellScheduleGradeLevel&gt;**](EdFiBellScheduleGradeLevel.md) | An unordered collection of bellScheduleGradeLevels. The grade levels the particular BellSchedule applies to. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

