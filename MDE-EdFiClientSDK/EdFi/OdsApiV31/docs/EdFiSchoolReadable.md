# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile.EdFiSchoolReadable
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**Addresses** | [**List&lt;EdFiEducationOrganizationAddressSchoolReadable&gt;**](EdFiEducationOrganizationAddressSchoolReadable.md) | An unordered collection of educationOrganizationAddresses. The set of elements that describes the physical location of the education entity, including the street address, city, state, ZIP code, and ZIP code + 4. | 
**Categories** | [**List&lt;EdFiEducationOrganizationCategorySchoolReadable&gt;**](EdFiEducationOrganizationCategorySchoolReadable.md) | An unordered collection of educationOrganizationCategories. The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state. | 
**GradeLevels** | [**List&lt;EdFiSchoolGradeLevelReadable&gt;**](EdFiSchoolGradeLevelReadable.md) | An unordered collection of schoolGradeLevels. The grade levels served at the school. | 
**SchoolId** | **int?** | The identifier assigned to a school. | 
**LocalEducationAgencyReference** | [**EdFiLocalEducationAgencyReference**](EdFiLocalEducationAgencyReference.md) |  | [optional] 
**IdentificationCodes** | [**List&lt;EdFiEducationOrganizationIdentificationCodeSchoolReadable&gt;**](EdFiEducationOrganizationIdentificationCodeSchoolReadable.md) | An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity. | [optional] 
**NameOfInstitution** | **string** | The full, legally accepted name of the institution. | 
**TitleIPartASchoolDesignationDescriptor** | **string** | Denotes the Title I Part A designation for the school. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | [**SchoolExtensionsReadable**](SchoolExtensionsReadable.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

