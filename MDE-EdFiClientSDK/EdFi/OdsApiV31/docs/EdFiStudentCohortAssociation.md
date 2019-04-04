# EdFi.OdsApi.Sdk.Models.All.EdFiStudentCohortAssociation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**BeginDate** | **DateTime?** | The month, day, and year on which the Student was first identified as part of the Cohort. | 
**CohortReference** | [**EdFiCohortReference**](EdFiCohortReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**EndDate** | **DateTime?** | The month, day, and year on which the Student was removed as part of the Cohort. | [optional] 
**Sections** | [**List&lt;EdFiStudentCohortAssociationSection&gt;**](EdFiStudentCohortAssociationSection.md) | An unordered collection of studentCohortAssociationSections. The Cohort representing the subdivision of students within one or more sections. For example, a group of students may be given additional instruction and tracked as a cohort. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

