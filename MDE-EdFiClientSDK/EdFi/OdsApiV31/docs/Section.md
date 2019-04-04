# EdFi.OdsApi.Sdk.Models.Composites.EnrollmentComposite.Section
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**LocalCourseCode** | **string** | The local code assigned by the School that identifies the course offering provided for the instruction of students. | 
**SectionIdentifier** | **string** | The local identifier assigned to a section. | 
**AcademicSubjectDescriptor** | **string** | The intended major subject area of the course. | [optional] 
**AvailableCredits** | **double?** | The value of credits or units of value awarded for the completion of a course. | [optional] 
**ClassPeriods** | [**List&lt;SectionSectionClassPeriod&gt;**](SectionSectionClassPeriod.md) | An unordered collection of sectionClassPeriods.  | [optional] 
**EducationalEnvironmentDescriptor** | **string** | The setting in which a child receives education and related services; for example:          Center-based instruction          Home-based instruction          Hospital class          Mainstream          Residential care and treatment facility          ... | [optional] 
**Location** | [**SectionLocation**](SectionLocation.md) |  | [optional] 
**LocationSchoolReference** | [**SectionSchool**](SectionSchool.md) |  | [optional] 
**SequenceOfCourse** | **int?** | When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1. | [optional] 
**Session** | [**SectionSession**](SectionSession.md) |  | [optional] 
**Staff** | [**List&lt;SectionStaffSectionAssociation&gt;**](SectionStaffSectionAssociation.md) | An unordered collection of staffSectionAssociations.  | [optional] 
**Students** | [**List&lt;SectionStudentSectionAssociation&gt;**](SectionStudentSectionAssociation.md) | An unordered collection of studentSectionAssociations.  | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

