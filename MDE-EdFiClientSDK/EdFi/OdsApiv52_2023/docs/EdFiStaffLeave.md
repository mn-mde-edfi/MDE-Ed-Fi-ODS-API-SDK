# EdFi.OdsApi.Sdk.Models.Identity.EdFiStaffLeave
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**BeginDate** | **DateTime?** | The begin date of the staff leave. | 
**StaffLeaveEventCategoryDescriptor** | **string** | The code describing the type of leave taken, for example: Sick, Personal, Vacation. | 
**StaffReference** | [**EdFiStaffReference**](EdFiStaffReference.md) |  | 
**EndDate** | **DateTime?** | The end date of the staff leave. | [optional] 
**Reason** | **string** | Expanded reason for the staff leave. | [optional] 
**SubstituteAssigned** | **bool?** | Indicator of whether a substitute was assigned during the period of staff leave. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

