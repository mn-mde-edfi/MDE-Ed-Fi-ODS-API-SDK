# EdFi.OdsApi.Sdk.Models.All.EdFiStudentNeglectedOrDelinquentProgramAssociation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**BeginDate** | **DateTime?** | The month, day, and year on which the Student first received services. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**ElaProgressLevelDescriptor** | **string** | The progress measured from pre- to post- test for ELA. | [optional] 
**EndDate** | **DateTime?** | The month, day, and year on which the Student exited the Program or stopped receiving services. | [optional] 
**MathematicsProgressLevelDescriptor** | **string** | The progress measured from pre- to post-test for Mathematics. | [optional] 
**NeglectedOrDelinquentProgramDescriptor** | **string** | The type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA). | [optional] 
**NeglectedOrDelinquentProgramServices** | [**List&lt;EdFiStudentNeglectedOrDelinquentProgramAssociationNeglectedOrDelinquentProgramService&gt;**](EdFiStudentNeglectedOrDelinquentProgramAssociationNeglectedOrDelinquentProgramService.md) | An unordered collection of studentNeglectedOrDelinquentProgramAssociationNeglectedOrDelinquentProgramServices. Indicates the service(s) being provided to the Student by the Neglected or Delinquent Program. | [optional] 
**ReasonExitedDescriptor** | **string** | The reason the child left the Program within a school or district. | [optional] 
**ServedOutsideOfRegularSession** | **bool?** | Indicates whether the Student received services during the summer session or between sessions. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

