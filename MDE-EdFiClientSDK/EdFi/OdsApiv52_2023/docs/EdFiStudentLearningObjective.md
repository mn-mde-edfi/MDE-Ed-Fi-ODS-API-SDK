# EdFi.OdsApi.Sdk.Models.Identity.EdFiStudentLearningObjective
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**GradingPeriodReference** | [**EdFiGradingPeriodReference**](EdFiGradingPeriodReference.md) |  | 
**LearningObjectiveReference** | [**EdFiLearningObjectiveReference**](EdFiLearningObjectiveReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**CompetencyLevelDescriptor** | **string** | The CompetencyLevel assessed for the student for the referenced LearningObjective. | 
**DiagnosticStatement** | **string** | A statement provided by the teacher that provides information in addition to the grade or assessment score. | [optional] 
**GeneralStudentProgramAssociations** | [**List&lt;EdFiStudentLearningObjectiveGeneralStudentProgramAssociation&gt;**](EdFiStudentLearningObjectiveGeneralStudentProgramAssociation.md) | An unordered collection of studentLearningObjectiveGeneralStudentProgramAssociations. Relates the Student and Program associated with the LearningObjective. | [optional] 
**StudentSectionAssociations** | [**List&lt;EdFiStudentLearningObjectiveStudentSectionAssociation&gt;**](EdFiStudentLearningObjectiveStudentSectionAssociation.md) | An unordered collection of studentLearningObjectiveStudentSectionAssociations. Relates the Student and Section associated with the LearningObjective. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

