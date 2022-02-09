# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Two_Twenty_Three_SISVendor_Profile.EdFiStudentNeglectedOrDelinquentProgramAssociationReadable
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
**NeglectedOrDelinquentProgramServices** | [**List&lt;EdFiStudentNeglectedOrDelinquentProgramAssociationNeglectedOrDelinquentProgramServiceReadable&gt;**](EdFiStudentNeglectedOrDelinquentProgramAssociationNeglectedOrDelinquentProgramServiceReadable.md) | An unordered collection of studentNeglectedOrDelinquentProgramAssociationNeglectedOrDelinquentProgramServices. Indicates the service(s) being provided to the Student by the Neglected or Delinquent Program. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | [**StudentNeglectedOrDelinquentProgramAssociationExtensionsReadable**](StudentNeglectedOrDelinquentProgramAssociationExtensionsReadable.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

