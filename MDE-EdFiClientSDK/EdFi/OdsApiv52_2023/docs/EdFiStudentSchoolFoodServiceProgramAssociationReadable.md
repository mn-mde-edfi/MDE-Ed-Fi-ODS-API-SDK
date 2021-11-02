# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile.EdFiStudentSchoolFoodServiceProgramAssociationReadable
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**BeginDate** | **DateTime?** | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**ProgramReference** | [**EdFiProgramReference**](EdFiProgramReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**EndDate** | **DateTime?** | The month, day, and year on which the Student exited the Program or stopped receiving services. | [optional] 
**SchoolFoodServiceProgramServices** | [**List&lt;EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable&gt;**](EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable.md) | An unordered collection of studentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServices. Indicates the service(s) being provided to the Student by the School Food Service Program. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

