# EdFi.OdsApi.Sdk.Models.All.EdFiClassPeriod
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**ClassPeriodName** | **string** | An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules). | 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**MeetingTimes** | [**List&lt;EdFiClassPeriodMeetingTime&gt;**](EdFiClassPeriodMeetingTime.md) | An unordered collection of classPeriodMeetingTimes. The meeting time(s) for a class period. | [optional] 
**OfficialAttendancePeriod** | **bool?** | Indicator of whether this class period is used for official daily attendance. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

