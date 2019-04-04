# EdFi.OdsApi.Sdk.Models.All.EdFiGrade
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**GradeTypeDescriptor** | **string** | The type of grade reported (e.g., Exam, Final, Grading Period). | 
**GradingPeriodReference** | [**EdFiGradingPeriodReference**](EdFiGradingPeriodReference.md) |  | 
**StudentSectionAssociationReference** | [**EdFiStudentSectionAssociationReference**](EdFiStudentSectionAssociationReference.md) |  | 
**DiagnosticStatement** | **string** | A statement provided by the teacher that provides information in addition to the grade or assessment score. | [optional] 
**LetterGradeEarned** | **string** | A final or interim (grading period) indicator of student performance in a class as submitted by the instructor. | [optional] 
**NumericGradeEarned** | **double?** | A final or interim (grading period) indicator of student performance in a class as submitted by the instructor. | [optional] 
**PerformanceBaseConversionDescriptor** | **string** | A conversion of the level to a standard set of performance levels. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

