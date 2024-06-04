# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile.MnStudentSAAPProgramAssociationReadable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**BeginDate** | **DateTime** | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. | 
**EducationOrganizationReference** | [**MnEducationOrganizationReference**](MnEducationOrganizationReference.md) |  | 
**ProgramReference** | [**MnProgramReference**](MnProgramReference.md) |  | 
**StudentReference** | [**MnStudentReference**](MnStudentReference.md) |  | 
**EndDate** | **DateTime** | The month, day, and year on which the Student exited the Program or stopped receiving services. | [optional] 
**IndependentStudyIndicator** | **bool** | State-approved alternative programs (SAAP) that also have a state-approved Independent Study(IS) component use this flag to identify independent study participants. | 
**SaapConcurrentIndicator** | **bool** | An indicator representing a Student who is enrolled less than full-time at a traditional school and who is also enrolled at a State Approved Alternative Program (SAAP). | 
**SaapCredits** | **double** | SAAP Credits. | 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

