# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile.EdFiStudentAssessmentReadable
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**StudentAssessmentIdentifier** | **string** | A unique number or alphanumeric code assigned to an assessment administered to a student. | 
**AssessmentReference** | [**EdFiAssessmentReference**](EdFiAssessmentReference.md) |  | 
**SchoolYearTypeReference** | [**EdFiSchoolYearTypeReference**](EdFiSchoolYearTypeReference.md) |  | [optional] 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**Accommodations** | [**List&lt;EdFiStudentAssessmentAccommodationReadable&gt;**](EdFiStudentAssessmentAccommodationReadable.md) | An unordered collection of studentAssessmentAccommodations. The specific type of special variation used in how an examination is presented, how it is administered, or how the test taker is allowed to respond. This generally refers to changes that do not substantially alter what the examination measures. The proper use of accommodations does not substantially change academic level or performance criteria. For example:         Braille         Enlarged monitor view         Extra time         Large Print         Setting         Oral Administration         ... | [optional] 
**AdministrationDate** | **DateTime?** | The date and time an assessment was completed by the student. The use of ISO-8601 formats with a timezone designator (UTC or time offset) is recommended in order to prevent ambiguity due to time zones. | 
**AdministrationEndDate** | **DateTime?** | The date and time an assessment administration ended. | [optional] 
**AdministrationEnvironmentDescriptor** | **string** | The environment in which the test was administered. | [optional] 
**AdministrationLanguageDescriptor** | **string** | The language in which an assessment is written and/or administered. | [optional] 
**EventCircumstanceDescriptor** | **string** | An unusual event occurred during the administration of the assessment. This could include fire alarm, student became ill, etc. | [optional] 
**EventDescription** | **string** | Describes special events that occur before during or after the assessment session that may impact use of results. | [optional] 
**Items** | [**List&lt;EdFiStudentAssessmentItemReadable&gt;**](EdFiStudentAssessmentItemReadable.md) | An unordered collection of studentAssessmentItems. The student&#39;s response to an assessment item and the item-level scores such as correct, incorrect, or met standard. | [optional] 
**PerformanceLevels** | [**List&lt;EdFiStudentAssessmentPerformanceLevelReadable&gt;**](EdFiStudentAssessmentPerformanceLevelReadable.md) | An unordered collection of studentAssessmentPerformanceLevels. The performance level(s) achieved for the StudentAssessment. | [optional] 
**PlatformTypeDescriptor** | **string** | The platform with which the assessment was delivered to the student during the assessment session. | [optional] 
**ReasonNotTestedDescriptor** | **string** | The primary reason student is not tested. For example:         Absent         Refusal by parent         Refusal by student         Medical waiver         Illness         Disruptive behavior         LEP Exempt         ... | [optional] 
**RetestIndicatorDescriptor** | **string** | Indicator if the test was retaken. For example:         Primary administration         First retest         Second retest         ... | [optional] 
**ScoreResults** | [**List&lt;EdFiStudentAssessmentScoreResultReadable&gt;**](EdFiStudentAssessmentScoreResultReadable.md) | An unordered collection of studentAssessmentScoreResults. A meaningful score or statistical expression of the performance of an individual. The results can be expressed as a number, percentile, range, level, etc. | [optional] 
**SerialNumber** | **string** | The unique number for the assessment form or answer document. | [optional] 
**StudentObjectiveAssessments** | [**List&lt;EdFiStudentAssessmentStudentObjectiveAssessmentReadable&gt;**](EdFiStudentAssessmentStudentObjectiveAssessmentReadable.md) | An unordered collection of studentAssessmentStudentObjectiveAssessments. The student&#39;s score and/or performance levels earned for an ObjectiveAssessment. | [optional] 
**WhenAssessedGradeLevelDescriptor** | **string** | The grade level of a student when assessed. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | [**StudentAssessmentExtensionsReadable**](StudentAssessmentExtensionsReadable.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

