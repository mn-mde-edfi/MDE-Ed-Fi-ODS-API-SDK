# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_One_SISVendor_Profile.EdFiStudentSpecialEducationProgramAssociationWritable
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**BeginDate** | **DateTime?** | The month, day, and year on which the Student first received services. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**Disabilities** | [**List&lt;EdFiStudentSpecialEducationProgramAssociationDisabilityWritable&gt;**](EdFiStudentSpecialEducationProgramAssociationDisabilityWritable.md) | An unordered collection of studentSpecialEducationProgramAssociationDisabilities. The disability condition(s) that best describes an individual&#39;s impairment, as related to special education services received. | [optional] 
**EndDate** | **DateTime?** | The month, day, and year on which the Student exited the Program or stopped receiving services. | [optional] 
**SpecialEducationSettingDescriptor** | **string** | The major instructional setting (more than 50 percent of a student&#39;s special education program). | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | [**StudentSpecialEducationProgramAssociationExtensionsWritable**](StudentSpecialEducationProgramAssociationExtensionsWritable.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

