# EdFi.OdsApi.Sdk.Models.All.EdFiStudentSpecialEducationProgramAssociation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**BeginDate** | **DateTime?** | The month, day, and year on which the Student first received services. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**Disabilities** | [**List&lt;EdFiStudentSpecialEducationProgramAssociationDisability&gt;**](EdFiStudentSpecialEducationProgramAssociationDisability.md) | An unordered collection of studentSpecialEducationProgramAssociationDisabilities. The disability condition(s) that best describes an individual&#39;s impairment, as related to special education services received. | [optional] 
**EndDate** | **DateTime?** | The month, day, and year on which the Student exited the Program or stopped receiving services. | [optional] 
**IdeaEligibility** | **bool?** | Indicator of the eligibility of the student to receive special education services according to the Individuals with Disabilities Education Act (IDEA). | [optional] 
**IepBeginDate** | **DateTime?** | The effective date of the most recent IEP. | [optional] 
**IepEndDate** | **DateTime?** | The end date of the most recent IEP. | [optional] 
**IepReviewDate** | **DateTime?** | The date of the last IEP review. | [optional] 
**LastEvaluationDate** | **DateTime?** | The date of the last special education evaluation. | [optional] 
**MedicallyFragile** | **bool?** | Indicates whether the Student receiving special education and related services is:          1) in the age range of birth to 22 years, and          2) has a serious, ongoing illness or a chronic condition that has lasted or is anticipated to last at least 12 or more months or has required at least one month of hospitalization, and that requires daily, ongoing medical treatments and monitoring by appropriately trained personnel which may include parents or other family members, and          3) requires the routine use of medical device or of assistive technology to compensate for the loss of usefulness of a body function needed to participate in activities of daily living, and          4) lives with ongoing threat to his or her continued well-being.          Aligns with federal requirements. | [optional] 
**MultiplyDisabled** | **bool?** | Indicates whether the Student receiving special education and related services has been designated as multiply disabled by the admission, review, and dismissal committee as aligned with federal requirements. | [optional] 
**ReasonExitedDescriptor** | **string** | The reason the child left the Program within a school or district. | [optional] 
**SchoolHoursPerWeek** | **double?** | Indicate the total number of hours of instructional time per week for the school that the student attends. | [optional] 
**ServedOutsideOfRegularSession** | **bool?** | Indicates whether the Student received services during the summer session or between sessions. | [optional] 
**ServiceProviders** | [**List&lt;EdFiStudentSpecialEducationProgramAssociationServiceProvider&gt;**](EdFiStudentSpecialEducationProgramAssociationServiceProvider.md) | An unordered collection of studentSpecialEducationProgramAssociationServiceProviders. The Staff providing special education services to the Student. | [optional] 
**SpecialEducationHoursPerWeek** | **double?** | The number of hours per week for special education instruction and therapy. | [optional] 
**SpecialEducationProgramServices** | [**List&lt;EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService&gt;**](EdFiStudentSpecialEducationProgramAssociationSpecialEducationProgramService.md) | An unordered collection of studentSpecialEducationProgramAssociationSpecialEducationProgramServices. Indicates the Service(s) being provided to the Student by the Special Education Program. | [optional] 
**SpecialEducationSettingDescriptor** | **string** | The major instructional setting (more than 50 percent of a student&#39;s special education program). | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | [**StudentSpecialEducationProgramAssociationExtensions**](StudentSpecialEducationProgramAssociationExtensions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

