# EdFi.OdsApi.Sdk.Models.Identity.EdFiCohort
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**CohortIdentifier** | **string** | The name or ID for the Cohort. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**AcademicSubjectDescriptor** | **string** | The academic subject associated with an academic intervention. | [optional] 
**CohortDescription** | **string** | The description of the Cohort and its purpose. | [optional] 
**CohortScopeDescriptor** | **string** | The scope of cohort (e.g., school, district, classroom). | [optional] 
**CohortTypeDescriptor** | **string** | The type of cohort (e.g., academic intervention, classroom breakout). | 
**Programs** | [**List&lt;EdFiCohortProgram&gt;**](EdFiCohortProgram.md) | An unordered collection of cohortPrograms. The (optional) program associated with this Cohort (e.g., special education). | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

