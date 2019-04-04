# EdFi.OdsApi.Sdk.Models.All.EdFiStudentTitleIPartAProgramAssociation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**BeginDate** | **DateTime?** | The month, day, and year on which the Student first received services. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**EndDate** | **DateTime?** | The month, day, and year on which the Student exited the Program or stopped receiving services. | [optional] 
**ReasonExitedDescriptor** | **string** | The reason the child left the Program within a school or district. | [optional] 
**ServedOutsideOfRegularSession** | **bool?** | Indicates whether the Student received services during the summer session or between sessions. | [optional] 
**Services** | [**List&lt;EdFiStudentTitleIPartAProgramAssociationService&gt;**](EdFiStudentTitleIPartAProgramAssociationService.md) | An unordered collection of studentTitleIPartAProgramAssociationServices. Indicates the Service(s) being provided to the Student by the Program. | [optional] 
**TitleIPartAParticipantDescriptor** | **string** | An indication of the type of Title I program, if any, in which the student is participating and by which the student is served:          Public Targeted Assistance Program          Public Schoolwide Program          Private School Students Participating          Local Neglected Program. | 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

