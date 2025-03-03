# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile.EdFiCourseWritable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**CourseCode** | **string** | A unique alphanumeric code assigned to a course. | 
**IdentificationCodes** | [**List&lt;EdFiCourseIdentificationCodeWritable&gt;**](EdFiCourseIdentificationCodeWritable.md) | An unordered collection of courseIdentificationCodes. The code that identifies the organization of subject matter and related learning experiences provided for the instruction of students. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**CourseDefinedByDescriptor** | **string** | Specifies whether the course was defined by the SEA, LEA, School, or national organization. | [optional] 
**CourseDescription** | **string** | A description of the content standards and goals covered in the course. Reference may be made to state or national content standards. | [optional] 
**CourseTitle** | **string** | The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, and language arts). | 
**DateCourseAdopted** | **DateTime?** | Date the course was adopted by the education agency. | [optional] 
**HighSchoolCourseRequirement** | **bool?** | An indication that this course may satisfy high school graduation requirements in the course&#39;s subject area. | [optional] 
**LearningStandards** | [**List&lt;EdFiCourseLearningStandardWritable&gt;**](EdFiCourseLearningStandardWritable.md) | An unordered collection of courseLearningStandards. Learning standard(s) to be taught by the course. | [optional] 
**LevelCharacteristics** | [**List&lt;EdFiCourseLevelCharacteristicWritable&gt;**](EdFiCourseLevelCharacteristicWritable.md) | An unordered collection of courseLevelCharacteristics. The type of specific program or designation with which the course is associated (e.g., AP, IB, Dual Credit, CTE). | [optional] 
**MaximumAvailableCredits** | **double?** | The value of credits or units of value awarded for the completion of a course. | [optional] 
**NumberOfParts** | **int** | The number of parts identified for a course. | 
**OfferedGradeLevels** | [**List&lt;EdFiCourseOfferedGradeLevelWritable&gt;**](EdFiCourseOfferedGradeLevelWritable.md) | An unordered collection of courseOfferedGradeLevels. The grade levels in which the course is offered. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | [**CourseExtensionsWritable**](CourseExtensionsWritable.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

