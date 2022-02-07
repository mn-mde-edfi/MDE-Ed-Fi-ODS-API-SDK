# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Two_Twenty_Three_SISVendor_Profile.EdFiSectionReadable
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**SectionIdentifier** | **string** | The local identifier assigned to a section. | 
**CourseOfferingReference** | [**EdFiCourseOfferingReference**](EdFiCourseOfferingReference.md) |  | 
**Characteristics** | [**List&lt;EdFiSectionCharacteristicReadable&gt;**](EdFiSectionCharacteristicReadable.md) | An unordered collection of sectionCharacteristics. Reflects important characteristics of the Section, such as whether or not attendance is taken and the Section is graded. | [optional] 
**ClassPeriods** | [**List&lt;EdFiSectionClassPeriodReadable&gt;**](EdFiSectionClassPeriodReadable.md) | An unordered collection of sectionClassPeriods. The class period during which the Section meets. | [optional] 
**InstructionLanguageDescriptor** | **string** | The primary language of instruction, if omitted English is assumed. | [optional] 
**MediumOfInstructionDescriptor** | **string** | The media through which teachers provide instruction to students and students and teachers communicate about instructional matters; for example:         Technology-based instruction in classroom         Correspondence instruction         Face-to-face instruction         Virtual/On-line Distance learning         Center-based instruction         ... | [optional] 
**SequenceOfCourse** | **int?** | When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | [**SectionExtensionsReadable**](SectionExtensionsReadable.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

