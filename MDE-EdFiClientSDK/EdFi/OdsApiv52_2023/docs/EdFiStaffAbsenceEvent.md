# EdFi.OdsApi.Sdk.Models.Identity.EdFiStaffAbsenceEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**AbsenceEventCategoryDescriptor** | **string** | The code describing the type of absence. | 
**EventDate** | **DateTime?** | Date for this leave event. | 
**StaffReference** | [**EdFiStaffReference**](EdFiStaffReference.md) |  | 
**AbsenceEventReason** | **string** | Expanded reason for the staff absence. | [optional] 
**HoursAbsent** | **double?** | The hours the staff was absent, if not the entire working day. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

