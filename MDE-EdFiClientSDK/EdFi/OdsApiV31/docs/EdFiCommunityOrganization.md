# EdFi.OdsApi.Sdk.Models.All.EdFiCommunityOrganization
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**Addresses** | [**List&lt;EdFiEducationOrganizationAddress&gt;**](EdFiEducationOrganizationAddress.md) | An unordered collection of educationOrganizationAddresses. The set of elements that describes the physical location of the education entity, including the street address, city, state, ZIP code, and ZIP code + 4. | 
**Categories** | [**List&lt;EdFiEducationOrganizationCategory&gt;**](EdFiEducationOrganizationCategory.md) | An unordered collection of educationOrganizationCategories. The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state. | 
**CommunityOrganizationId** | **int?** | The identifier assigned to a CommunityOrganization. | 
**IdentificationCodes** | [**List&lt;EdFiEducationOrganizationIdentificationCode&gt;**](EdFiEducationOrganizationIdentificationCode.md) | An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity. | [optional] 
**InstitutionTelephones** | [**List&lt;EdFiEducationOrganizationInstitutionTelephone&gt;**](EdFiEducationOrganizationInstitutionTelephone.md) | An unordered collection of educationOrganizationInstitutionTelephones. The 10-digit telephone number, including the area code, for the education entity. | [optional] 
**InternationalAddresses** | [**List&lt;EdFiEducationOrganizationInternationalAddress&gt;**](EdFiEducationOrganizationInternationalAddress.md) | An unordered collection of educationOrganizationInternationalAddresses. The set of elements that describes the international physical location of the education entity. | [optional] 
**NameOfInstitution** | **string** | The full, legally accepted name of the institution. | 
**OperationalStatusDescriptor** | **string** | The current operational status of the EducationOrganization (e.g., active, inactive). | [optional] 
**ShortNameOfInstitution** | **string** | A short name for the institution. | [optional] 
**WebSite** | **string** | The public web site address (URL) for the EducationOrganization. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

