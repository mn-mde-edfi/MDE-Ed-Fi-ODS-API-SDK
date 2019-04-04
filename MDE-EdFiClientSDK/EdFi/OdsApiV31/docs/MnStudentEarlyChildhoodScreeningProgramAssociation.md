# EdFi.OdsApi.Sdk.Models.All.MnStudentEarlyChildhoodScreeningProgramAssociation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**BeginDate** | **DateTime?** | The month, day, and year on which the Student first received services. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**EarlyChildhoodScreenerDescriptor** | **string** | This descriptor contains codes indicating who completed a screening for a student in the Early Childhood Screening program. | [optional] 
**EarlyChildhoodScreeningExitStatusDescriptor** | **string** | Early Childhood Screening Exit Status. | [optional] 
**EndDate** | **DateTime?** | The month, day, and year on which the Student exited the Program or stopped receiving services. | [optional] 
**ReasonExitedDescriptor** | **string** | The reason the child left the Program within a school or district. | [optional] 
**ServedOutsideOfRegularSession** | **bool?** | Indicates whether the Student received services during the summer session or between sessions. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

