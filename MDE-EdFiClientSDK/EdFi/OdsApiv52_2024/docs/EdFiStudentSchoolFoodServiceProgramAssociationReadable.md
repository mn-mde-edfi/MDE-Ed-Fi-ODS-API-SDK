# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Two_Twenty_Three_SISVendor_Profile.EdFiStudentSchoolFoodServiceProgramAssociationReadable
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**BeginDate** | **DateTime?** | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**DirectCertification** | **bool?** | Indicates that the student&#39;s National School Lunch Program (NSLP) eligibility has been determined through direct certification. | [optional] 
**EndDate** | **DateTime?** | The month, day, and year on which the Student exited the Program or stopped receiving services. | [optional] 
**SchoolFoodServiceProgramServices** | [**List&lt;EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable&gt;**](EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable.md) | An unordered collection of studentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServices. Indicates the service(s) being provided to the Student by the School Food Service Program. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

