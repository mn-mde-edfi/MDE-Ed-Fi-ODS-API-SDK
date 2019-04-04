# EdFi.OdsApi.Sdk.Models.All.MnStudentSAAPProgramAssociation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**BeginDate** | **DateTime?** | The month, day, and year on which the Student first received services. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**EndDate** | **DateTime?** | The month, day, and year on which the Student exited the Program or stopped receiving services. | [optional] 
**IndependentStudyIndicator** | **bool?** | State-approved alternative programs (SAAP) that also have a state-approved Independent Study (IS) component use this flag to identify independent study participants. | 
**ReasonExitedDescriptor** | **string** | The reason the child left the Program within a school or district. | [optional] 
**SaapConcurrentIndicator** | **bool?** | An indicator representing a Student who is enrolled less than full-time at a traditional school and who is also enrolled at a State Approved Alternative Program (SAAP). | 
**SaapCredits** | **int?** | SAAP Credits. | 
**ServedOutsideOfRegularSession** | **bool?** | Indicates whether the Student received services during the summer session or between sessions. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

