# EdFi.OdsApi.Sdk.Models.All.EdFiPostSecondaryInstitution
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**Addresses** | [**List&lt;EdFiEducationOrganizationAddress&gt;**](EdFiEducationOrganizationAddress.md) | An unordered collection of educationOrganizationAddresses. The set of elements that describes the physical location of the education entity, including the street address, city, state, ZIP code, and ZIP code + 4. | 
**Categories** | [**List&lt;EdFiEducationOrganizationCategory&gt;**](EdFiEducationOrganizationCategory.md) | An unordered collection of educationOrganizationCategories. The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state. | 
**PostSecondaryInstitutionId** | **int?** | The ID of the post secondary institution. | 
**AdministrativeFundingControlDescriptor** | **string** | A classification of whether a postsecondary institution is operated by publicly elected or appointed officials (public control) or by privately elected or appointed officials and derives its major source of funds from private sources (private control). | [optional] 
**IdentificationCodes** | [**List&lt;EdFiEducationOrganizationIdentificationCode&gt;**](EdFiEducationOrganizationIdentificationCode.md) | An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity. | [optional] 
**InstitutionTelephones** | [**List&lt;EdFiEducationOrganizationInstitutionTelephone&gt;**](EdFiEducationOrganizationInstitutionTelephone.md) | An unordered collection of educationOrganizationInstitutionTelephones. The 10-digit telephone number, including the area code, for the education entity. | [optional] 
**InternationalAddresses** | [**List&lt;EdFiEducationOrganizationInternationalAddress&gt;**](EdFiEducationOrganizationInternationalAddress.md) | An unordered collection of educationOrganizationInternationalAddresses. The set of elements that describes the international physical location of the education entity. | [optional] 
**MediumOfInstructions** | [**List&lt;EdFiPostSecondaryInstitutionMediumOfInstruction&gt;**](EdFiPostSecondaryInstitutionMediumOfInstruction.md) | An unordered collection of postSecondaryInstitutionMediumOfInstructions. The categories in which an institution serves the students. | [optional] 
**NameOfInstitution** | **string** | The full, legally accepted name of the institution. | 
**OperationalStatusDescriptor** | **string** | The current operational status of the EducationOrganization (e.g., active, inactive). | [optional] 
**PostSecondaryInstitutionLevelDescriptor** | **string** | A classification of whether a post secondary institution&#39;s highest level of offering is a program of 4-years or higher (4 year), 2-but-less-than 4-years (2 year), or less than 2-years. | [optional] 
**ShortNameOfInstitution** | **string** | A short name for the institution. | [optional] 
**WebSite** | **string** | The public web site address (URL) for the EducationOrganization. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

