# EdFi.OdsApi.Sdk.Models.Identity.MnStudentAssessmentPrecodeSite
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**PrecodeTypeDescriptor** | **string** | Type of pre-code site record. For example, MCA/MTAS, ACCESS/ALT-ACCESS | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ContactElectronicMailAddress** | **string** | Email address or login of administrative contact | [optional] 
**ContactFirstName** | **string** | First name of administrative contact | [optional] 
**ContactLastSurname** | **string** | Last name of administrative contact | [optional] 
**ContactTelephones** | [**List&lt;MnStudentAssessmentPrecodeSiteContactTelephone&gt;**](MnStudentAssessmentPrecodeSiteContactTelephone.md) | An unordered collection of studentAssessmentPrecodeSiteContactTelephones. The telephone number(s) for the administrative contact, and extension if applicable. | [optional] 
**ContactTitle** | **string** | Title of administrative contact | [optional] 
**ShippingInstructions** | [**List&lt;MnStudentAssessmentPrecodeSiteShippingInstruction&gt;**](MnStudentAssessmentPrecodeSiteShippingInstruction.md) | An unordered collection of studentAssessmentPrecodeSiteShippingInstructions. Shipping instructions such as Labels, Shipping Date, Shipping Preference | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

