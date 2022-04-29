# EdFi.OdsApi.Sdk.Models.Identity.MnStudentAssessmentExtension
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssessmentFormatDescriptor** | **string** | Format for which an assessment was administered. E.g., Online or Paper | [optional] 
**AssessmentTierDescriptor** | **string** | Tier descriptor for Assessment. E.g., Listening, Reading, Speaking, Writing | [optional] 
**GeneralEnrollmentDescriptor** | **string** | General type of enrollment for a student. E.g., R-Regular, N-Nonpublic, H-Homeschool | [optional] 
**CatStudentTestId** | **string** | CAT Student Test ID | [optional] 
**LearningLocatorCode** | **string** | Learning locator code | [optional] 
**TimeOnTest** | **int?** | Total recorded time duration in seconds | [optional] 
**SiteEducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | [optional] 
**Characteristics** | [**List&lt;MnStudentAssessmentCharacteristic&gt;**](MnStudentAssessmentCharacteristic.md) | An unordered collection of studentAssessmentCharacteristics. Generic characteristics about an Assessment other than Accommodations. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

