# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile.MnStudentAssessmentExtensionReadable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssessmentFormatDescriptor** | **string** | Format for which an assessment was administered. E.g., Online or Paper | [optional] 
**AssessmentTierDescriptor** | **string** | Tier descriptor for Assessment. E.g., Listening, Reading, Speaking, Writing | [optional] 
**AttemptLogicMetDescriptor** | **string** | Indication of whether student has met assessment Attempt Logic. | [optional] 
**GeneralEnrollmentDescriptor** | **string** | General type of enrollment for a student. E.g., R-Regular, N-Nonpublic, H-Homeschool | [optional] 
**FirstOperationalPassageDescriptor** | **string** | Delivery Method for Operational Passage 1. | [optional] 
**SecondOperationalPassageDescriptor** | **string** | Delivery Method for Operational Passage 2. | [optional] 
**ThirdOperationalPassageDescriptor** | **string** | Delivery Method for Operational Passage 3. | [optional] 
**SexDescriptor** | **string** | Student&#39;s birth sex. | 
**BirthDate** | **DateTime** | Student&#39;s birthdate. | 
**CatStudentTestId** | **string** | CAT Student Test ID | [optional] 
**FirstName** | **string** | A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. | 
**ItemAttempted** | **bool** | Indicates whether or not an item on the assessment was attempted. | [optional] 
**LastSurname** | **string** | The name borne in common by members of a family. | 
**MiddleName** | **string** | A secondary name given to an individual at birth, baptism, or during another naming ceremony. | 
**SiteEducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | [optional] 
**Characteristics** | [**List&lt;MnStudentAssessmentCharacteristicReadable&gt;**](MnStudentAssessmentCharacteristicReadable.md) | An unordered collection of studentAssessmentCharacteristics. Generic characteristics about an Assessment other than Accommodations. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

