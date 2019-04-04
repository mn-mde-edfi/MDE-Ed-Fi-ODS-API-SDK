# EdFi.OdsApi.Sdk.Models.All.EdFiStudentSchoolFoodServiceProgramAssociation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**BeginDate** | **DateTime?** | The month, day, and year on which the Student first received services. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**DirectCertification** | **bool?** | Indicates that the student&#39;s National School Lunch Program (NSLP) eligibility has been determined through direct certification. | [optional] 
**EndDate** | **DateTime?** | The month, day, and year on which the Student exited the Program or stopped receiving services. | [optional] 
**ReasonExitedDescriptor** | **string** | The reason the child left the Program within a school or district. | [optional] 
**SchoolFoodServiceProgramServices** | [**List&lt;EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramService&gt;**](EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramService.md) | An unordered collection of studentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServices. Indicates the service(s) being provided to the Student by the School Food Service Program. | [optional] 
**ServedOutsideOfRegularSession** | **bool?** | Indicates whether the Student received services during the summer session or between sessions. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

