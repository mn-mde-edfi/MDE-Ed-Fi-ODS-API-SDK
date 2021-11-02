# EdFi.OdsApi.Sdk.Models.Identity.EdFiStudentNeglectedOrDelinquentProgramAssociation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**BeginDate** | **DateTime?** | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**ElaProgressLevelDescriptor** | **string** | The progress measured from pre- to post- test for ELA. | [optional] 
**EndDate** | **DateTime?** | The month, day, and year on which the Student exited the Program or stopped receiving services. | [optional] 
**MathematicsProgressLevelDescriptor** | **string** | The progress measured from pre- to post-test for Mathematics. | [optional] 
**NeglectedOrDelinquentProgramDescriptor** | **string** | The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA). | [optional] 
**NeglectedOrDelinquentProgramServices** | [**List&lt;EdFiStudentNeglectedOrDelinquentProgramAssociationNeglectedOrDelinquentProgramService&gt;**](EdFiStudentNeglectedOrDelinquentProgramAssociationNeglectedOrDelinquentProgramService.md) | An unordered collection of studentNeglectedOrDelinquentProgramAssociationNeglectedOrDelinquentProgramServices. Indicates the service(s) being provided to the Student by the Neglected or Delinquent Program. | [optional] 
**ParticipationStatus** | [**EdFiGeneralStudentProgramAssociationParticipationStatus**](EdFiGeneralStudentProgramAssociationParticipationStatus.md) |  | [optional] 
**ProgramParticipationStatuses** | [**List&lt;EdFiGeneralStudentProgramAssociationProgramParticipationStatus&gt;**](EdFiGeneralStudentProgramAssociationProgramParticipationStatus.md) | An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation. | [optional] 
**ReasonExitedDescriptor** | **string** | The reason the child left the Program within a school or district. | [optional] 
**ServedOutsideOfRegularSession** | **bool?** | Indicates whether the Student received services during the summer session or between sessions. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | [**StudentNeglectedOrDelinquentProgramAssociationExtensions**](StudentNeglectedOrDelinquentProgramAssociationExtensions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

