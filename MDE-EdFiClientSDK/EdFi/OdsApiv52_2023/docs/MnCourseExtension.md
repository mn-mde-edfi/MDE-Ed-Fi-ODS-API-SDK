# EdFi.OdsApi.Sdk.Models.Identity.MnCourseExtension
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CareerClusterDescriptor** | **string** | Career cluster defines the industry or occupational focus for a career pathways program, plan of study, or course. | [optional] 
**EarlyEducationCourseLocationDescriptor** | **string** | Classification of instruction site for Early Education. E.g., child&#39;s home or care center. | [optional] 
**StandardAddressedDescriptor** | **string** | Locality of entity who&#39;s learning standard is addressed by this course. E.g., State, Federal, or Local. | [optional] 
**SequenceLimit** | **int?** | The upper limit of this course within a sequence. E.g., (1 of N) | [optional] 
**AssessmentTools** | [**List&lt;MnCourseAssessmentTool&gt;**](MnCourseAssessmentTool.md) | An unordered collection of courseAssessmentTools. Assessment tool that has been implemented for the course. General purpose but intially implemented for Early Education. | [optional] 
**CurriculumUseds** | [**List&lt;MnCourseCurriculumUsed&gt;**](MnCourseCurriculumUsed.md) | An unordered collection of courseCurriculumUseds. Curriculum as implemented for the course. General purpose but intially implemented for Early Education. | [optional] 
**LevelTypes** | [**List&lt;MnCourseLevelType&gt;**](MnCourseLevelType.md) | An unordered collection of courseLevelTypes. The &#39;type level&#39; of which the course is associated. E.g, Advanced, Articulated, Basic, Dual, General, No credit, Occupational | [optional] 
**Programs** | [**List&lt;MnCourseProgram&gt;**](MnCourseProgram.md) | An unordered collection of coursePrograms. Program associated to the course. General purpose but intially extended for Early Education. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

