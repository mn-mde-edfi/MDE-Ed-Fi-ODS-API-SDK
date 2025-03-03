# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile.EdFiAssessmentReadable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**AcademicSubjects** | [**List&lt;EdFiAssessmentAcademicSubjectReadable&gt;**](EdFiAssessmentAcademicSubjectReadable.md) | An unordered collection of assessmentAcademicSubjects. The description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language) of an assessment. | 
**AssessmentIdentifier** | **string** | A unique number or alphanumeric code assigned to an assessment. | 
**Namespace** | **string** | Namespace for the assessment. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | [optional] 
**AdaptiveAssessment** | **bool?** | Indicates that the assessment is adaptive. | [optional] 
**AssessedGradeLevels** | [**List&lt;EdFiAssessmentAssessedGradeLevelReadable&gt;**](EdFiAssessmentAssessedGradeLevelReadable.md) | An unordered collection of assessmentAssessedGradeLevels. The grade level(s) for which an assessment is designed. The semantics of null is assumed to mean that the assessment is not associated with any grade level. | [optional] 
**AssessmentCategoryDescriptor** | **string** | The category of an assessment based on format and content. | [optional] 
**AssessmentFamily** | **string** | The assessment family this assessment is a member of. | [optional] 
**AssessmentForm** | **string** | Identifies the form of the assessment, for example a regular versus makeup form, multiple choice versus constructed response, etc. | [optional] 
**AssessmentTitle** | **string** | The title or name of the assessment. | 
**AssessmentVersion** | **int?** | The version identifier for the assessment. | [optional] 
**ContentStandard** | [**EdFiAssessmentContentStandardReadable**](EdFiAssessmentContentStandardReadable.md) |  | [optional] 
**IdentificationCodes** | [**List&lt;EdFiAssessmentIdentificationCodeReadable&gt;**](EdFiAssessmentIdentificationCodeReadable.md) | An unordered collection of assessmentIdentificationCodes. A unique number or alphanumeric code assigned to an assessment by a school, school system, a state, or other agency or entity. | [optional] 
**Languages** | [**List&lt;EdFiAssessmentLanguageReadable&gt;**](EdFiAssessmentLanguageReadable.md) | An unordered collection of assessmentLanguages. An indication of the languages in which the assessment is designed. | [optional] 
**MaxRawScore** | **double?** | The maximum raw score achievable across all assessment items that are correct and scored at the maximum. | [optional] 
**Nomenclature** | **string** | Reflects the specific nomenclature used for assessment. | [optional] 
**PerformanceLevels** | [**List&lt;EdFiAssessmentPerformanceLevelReadable&gt;**](EdFiAssessmentPerformanceLevelReadable.md) | An unordered collection of assessmentPerformanceLevels. Definition of the performance levels and the associated cut scores. Three styles are supported: 1. Specification of performance level by minimum and maximum score, 2. Specification of performance level by cut score, using only minimum score, 3. Specification of performance level without any mapping to scores. | [optional] 
**Periods** | [**List&lt;EdFiAssessmentPeriodReadable&gt;**](EdFiAssessmentPeriodReadable.md) | An unordered collection of assessmentPeriods. The period or window in which an assessment is supposed to be administered. | [optional] 
**PlatformTypes** | [**List&lt;EdFiAssessmentPlatformTypeReadable&gt;**](EdFiAssessmentPlatformTypeReadable.md) | An unordered collection of assessmentPlatformTypes. The platforms with which the assessment may be delivered. | [optional] 
**Programs** | [**List&lt;EdFiAssessmentProgramReadable&gt;**](EdFiAssessmentProgramReadable.md) | An unordered collection of assessmentPrograms. The programs associated with the assessment. | [optional] 
**RevisionDate** | **DateTime?** | The month, day, and year that the conceptual design for the assessment was most recently revised substantially. | [optional] 
**Scores** | [**List&lt;EdFiAssessmentScoreReadable&gt;**](EdFiAssessmentScoreReadable.md) | An unordered collection of assessmentScores. Definition of the scores to be expected from this assessment. | [optional] 
**Sections** | [**List&lt;EdFiAssessmentSectionReadable&gt;**](EdFiAssessmentSectionReadable.md) | An unordered collection of assessmentSections. The Section(s) to which the assessment is associated. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

