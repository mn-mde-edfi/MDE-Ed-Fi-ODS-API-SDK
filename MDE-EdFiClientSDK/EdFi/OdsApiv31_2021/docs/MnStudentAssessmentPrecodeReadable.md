# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile.MnStudentAssessmentPrecodeReadable
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**PrecodeTypeDescriptor** | **string** | Type of pre-code record. For example, MCA/MTAS, ACCESS/ALT-ACCESS | 
**SiteStudentAssessmentPrecodeSiteReference** | [**MnStudentAssessmentPrecodeSiteReference**](MnStudentAssessmentPrecodeSiteReference.md) |  | [optional] 
**StudentEducationOrganizationAssociationReference** | [**MnStudentEducationOrganizationAssociationReference**](MnStudentEducationOrganizationAssociationReference.md) |  | 
**AcademicSubjects** | [**List&lt;MnStudentAssessmentPrecodeAcademicSubjectReadable&gt;**](MnStudentAssessmentPrecodeAcademicSubjectReadable.md) | An unordered collection of studentAssessmentPrecodeAcademicSubjects. The description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language) of an assessment. | [optional] 
**Accommodations** | [**List&lt;MnStudentAssessmentPrecodeAccommodationReadable&gt;**](MnStudentAssessmentPrecodeAccommodationReadable.md) | An unordered collection of studentAssessmentPrecodeAccommodations. The specific type of special variation used in how an examination is presented, how it is administered, or how the test taker is allowed to respond. This generally refers to changes that do not substantially alter what the examination measures. The proper use of accommodations does not substantially change academic level or performance criteria. For example:          Braille          Enlarged monitor view          Extra time          Large Print          Setting          Oral Administration          ... | [optional] 
**AssessedGradeLevelDescriptor** | **string** | The grade level tested for student when assessed. | [optional] 
**AssessmentTitle** | **string** | Refers to the test name of the assessment taken by the student. | [optional] 
**CustomGroup** | **string** | District use special sort order | [optional] 
**EnrolledGradeLevelDescriptor** | **string** | The grade level for which student is enrolled. | [optional] 
**GeneralEnrollmentDescriptor** | **string** | Student enrollment at the time of assessment pre-coding. For example H-Homeschool, N-Nonpublic, R-Regular | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

