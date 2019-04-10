# EdFi.OdsApi.Sdk.Models.All.EdFiStudentSchoolAssociation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**EntryDate** | **DateTime?** | The month, day, and year on which an individual enters and begins to receive instructional services in a school. | 
**CalendarReference** | [**EdFiCalendarReference**](EdFiCalendarReference.md) |  | [optional] 
**ClassOfSchoolYearTypeReference** | [**EdFiSchoolYearTypeReference**](EdFiSchoolYearTypeReference.md) |  | [optional] 
**GraduationPlanReference** | [**EdFiGraduationPlanReference**](EdFiGraduationPlanReference.md) |  | [optional] 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**SchoolYearTypeReference** | [**EdFiSchoolYearTypeReference**](EdFiSchoolYearTypeReference.md) |  | [optional] 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**EducationPlans** | [**List&lt;EdFiStudentSchoolAssociationEducationPlan&gt;**](EdFiStudentSchoolAssociationEducationPlan.md) | An unordered collection of studentSchoolAssociationEducationPlans. The type of education plan(s) the student is following, if appropriate. | [optional] 
**EmployedWhileEnrolled** | **bool?** | An individual who is a paid employee or works in his or her own business, profession, or farm and at the same time is enrolled in secondary, postsecondary, or adult education. | [optional] 
**EntryGradeLevelDescriptor** | **string** | The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session. | 
**EntryGradeLevelReasonDescriptor** | **string** | The primary reason as to why a staff member determined that a student should be promoted or not (or be demoted) at the end of a given school term. | [optional] 
**EntryTypeDescriptor** | **string** | The process by which a student enters a school during a given academic session. | [optional] 
**ExitWithdrawDate** | **DateTime?** | The month, day, and year of the first day after the date of an individual&#39;s last attendance at a school (if known), the day on which an individual graduated, or the date on which it becomes known officially that an individual left school. | [optional] 
**ExitWithdrawTypeDescriptor** | **string** | The circumstances under which the student exited from membership in an educational institution. | [optional] 
**PrimarySchool** | **bool?** | Indicates if a given enrollment record should be considered the primary record for a student. | [optional] 
**RepeatGradeIndicator** | **bool?** | An indicator of whether the student is enrolling to repeat a grade level, either by failure or an agreement to hold the student back. | [optional] 
**ResidencyStatusDescriptor** | **string** | An indication of the location of a persons legal residence relative to (within or outside of) the boundaries of the public school attended and its administrative unit. | [optional] 
**SchoolChoiceTransfer** | **bool?** | An indication of whether students transferred in or out of the school did so during the school year under the provisions for public school choice in accordance with Title I, Part A, Section 1116. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | [**StudentSchoolAssociationExtensions**](StudentSchoolAssociationExtensions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

