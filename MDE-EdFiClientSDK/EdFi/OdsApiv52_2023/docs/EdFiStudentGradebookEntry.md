# EdFi.OdsApi.Sdk.Models.Identity.EdFiStudentGradebookEntry
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**GradebookEntryReference** | [**EdFiGradebookEntryReference**](EdFiGradebookEntryReference.md) |  | 
**StudentSectionAssociationReference** | [**EdFiStudentSectionAssociationReference**](EdFiStudentSectionAssociationReference.md) |  | 
**CompetencyLevelDescriptor** | **string** | The CompetencyLevel assessed for the student for the referenced LearningObjective. | [optional] 
**DateFulfilled** | **DateTime?** | The date an assignment was turned in or the date of an assessment. | [optional] 
**DiagnosticStatement** | **string** | A statement provided by the teacher that provides information in addition to the grade or assessment score. | [optional] 
**LetterGradeEarned** | **string** | A final or interim (grading period) indicator of student performance in a class as submitted by the instructor. | [optional] 
**NumericGradeEarned** | **double?** | A final or interim (grading period) indicator of student performance in a class as submitted by the instructor. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

