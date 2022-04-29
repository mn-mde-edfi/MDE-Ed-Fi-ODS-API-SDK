# EdFi.OdsApi.Sdk.Models.Identity.EdFiStudentCompetencyObjective
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**GradingPeriodReference** | [**EdFiGradingPeriodReference**](EdFiGradingPeriodReference.md) |  | 
**ObjectiveCompetencyObjectiveReference** | [**EdFiCompetencyObjectiveReference**](EdFiCompetencyObjectiveReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**CompetencyLevelDescriptor** | **string** | The competency level assessed for the student for the referenced competency objective. | 
**DiagnosticStatement** | **string** | A statement provided by the teacher that provides information in addition to the grade or assessment score. | [optional] 
**GeneralStudentProgramAssociations** | [**List&lt;EdFiStudentCompetencyObjectiveGeneralStudentProgramAssociation&gt;**](EdFiStudentCompetencyObjectiveGeneralStudentProgramAssociation.md) | An unordered collection of studentCompetencyObjectiveGeneralStudentProgramAssociations. Relates the Student and Program associated with the CompetencyObjective. | [optional] 
**StudentSectionAssociations** | [**List&lt;EdFiStudentCompetencyObjectiveStudentSectionAssociation&gt;**](EdFiStudentCompetencyObjectiveStudentSectionAssociation.md) | An unordered collection of studentCompetencyObjectiveStudentSectionAssociations. Relates the Student and Section associated with the CompetencyObjective. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

