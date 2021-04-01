# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile.EdFiStudentLanguageInstructionProgramAssociationWritable
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**BeginDate** | **DateTime?** | The month, day, and year on which the Student first received services. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**EndDate** | **DateTime?** | The month, day, and year on which the Student exited the Program or stopped receiving services. | [optional] 
**EnglishLearnerParticipation** | **bool?** | An indication that an English Learner student is served by an English language instruction educational program supported with Title III of ESEA funds. | [optional] 
**LanguageInstructionProgramServices** | [**List&lt;EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceWritable&gt;**](EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceWritable.md) | An unordered collection of studentLanguageInstructionProgramAssociationLanguageInstructionProgramServices. Indicates the service(s) being provided to the Student by the Language Instruction Program. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

