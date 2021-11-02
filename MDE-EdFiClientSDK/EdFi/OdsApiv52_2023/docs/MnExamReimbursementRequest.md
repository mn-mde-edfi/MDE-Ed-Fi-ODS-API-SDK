# EdFi.OdsApi.Sdk.Models.Identity.MnExamReimbursementRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**TestedDate** | **DateTime?** | Date student took the test. | 
**StudentEducationOrganizationAssociationReference** | [**EdFiStudentEducationOrganizationAssociationReference**](EdFiStudentEducationOrganizationAssociationReference.md) |  | 
**AssessmentCategoryDescriptor** | **string** | Test that requires reimbursement. E.g., ACT, ACT plus Writing, SAT, SAT with Essay. | 
**ReimbursementRequested** | **bool?** | Reimbursement was requested. | 
**UnableToPay** | **bool?** | Reimbursement for a student determined by the district as &#39;unable to pay&#39;. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

