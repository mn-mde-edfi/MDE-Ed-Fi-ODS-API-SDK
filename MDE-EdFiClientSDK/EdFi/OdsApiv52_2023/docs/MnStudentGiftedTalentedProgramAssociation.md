# EdFi.OdsApi.Sdk.Models.Identity.MnStudentGiftedTalentedProgramAssociation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**BeginDate** | **DateTime?** | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**EndDate** | **DateTime?** | The month, day, and year on which the Student exited the Program or stopped receiving services. | [optional] 
**GiftedTalentedParticipationDescriptor** | **string** | The Gifted Talented Participation Descriptor. | 
**ParticipationStatus** | [**EdFiGeneralStudentProgramAssociationParticipationStatus**](EdFiGeneralStudentProgramAssociationParticipationStatus.md) |  | [optional] 
**ProgramParticipationStatuses** | [**List&lt;EdFiGeneralStudentProgramAssociationProgramParticipationStatus&gt;**](EdFiGeneralStudentProgramAssociationProgramParticipationStatus.md) | An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation. | [optional] 
**ReasonExitedDescriptor** | **string** | The reason the child left the Program within a school or district. | [optional] 
**ServedOutsideOfRegularSession** | **bool?** | Indicates whether the Student received services during the summer session or between sessions. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

