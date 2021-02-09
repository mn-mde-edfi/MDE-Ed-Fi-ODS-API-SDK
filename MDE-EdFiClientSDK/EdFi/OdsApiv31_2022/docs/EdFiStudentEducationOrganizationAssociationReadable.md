# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile.EdFiStudentEducationOrganizationAssociationReadable
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**HispanicLatinoEthnicity** | **bool?** | An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race. The term, \&quot;Spanish origin,\&quot; can be used in addition to \&quot;Hispanic or Latino.\&quot; | [optional] 
**Languages** | [**List&lt;EdFiStudentEducationOrganizationAssociationLanguageReadable&gt;**](EdFiStudentEducationOrganizationAssociationLanguageReadable.md) | An unordered collection of studentEducationOrganizationAssociationLanguages. The language(s) the individual uses to communicate. It is strongly recommended that entries use only ISO 639-3 language codes. | [optional] 
**Races** | [**List&lt;EdFiStudentEducationOrganizationAssociationRaceReadable&gt;**](EdFiStudentEducationOrganizationAssociationRaceReadable.md) | An unordered collection of studentEducationOrganizationAssociationRaces. The general racial category which most clearly reflects the individual&#39;s recognition of his or her community or with which the individual most identifies. The data model allows for multiple entries so that each individual can specify all appropriate races. | [optional] 
**SexDescriptor** | **string** | A person&#39;s gender. | 
**StudentCharacteristics** | [**List&lt;EdFiStudentEducationOrganizationAssociationStudentCharacteristicReadable&gt;**](EdFiStudentEducationOrganizationAssociationStudentCharacteristicReadable.md) | An unordered collection of studentEducationOrganizationAssociationStudentCharacteristics. Reflects important characteristics of the student&#39;s home situation:          Displaced Homemaker, Immigrant, Migratory, Military Parent, Pregnant Teen, Single Parent, and Unaccompanied Youth. | [optional] 
**StudentIdentificationCodes** | [**List&lt;EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeReadable&gt;**](EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeReadable.md) | An unordered collection of studentEducationOrganizationAssociationStudentIdentificationCodes. A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | [**StudentEducationOrganizationAssociationExtensionsReadable**](StudentEducationOrganizationAssociationExtensionsReadable.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

