# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile.MnStudentEarlyEducationProgramAssociationReadable
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**BeginDate** | **DateTime?** | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. | 
**EducationOrganizationReference** | [**MnEducationOrganizationReference**](MnEducationOrganizationReference.md) |  | 
**ProgramReference** | [**MnProgramReference**](MnProgramReference.md) |  | 
**StudentReference** | [**MnStudentReference**](MnStudentReference.md) |  | 
**FundingSources** | [**List&lt;MnStudentEarlyEducationProgramAssociationFundingSourceReadable&gt;**](MnStudentEarlyEducationProgramAssociationFundingSourceReadable.md) | An unordered collection of studentEarlyEducationProgramAssociationFundingSources. Funding source. | [optional] 
**ReasonExitedDescriptor** | **string** | The reason the child left the Program within a school or district. | [optional] 
**ServedOutsideOfRegularSession** | **bool?** | Indicates whether the Student received services during the summer session or between sessions. | [optional] 
**ServiceAttendanceHours** | **int?** | Indicates a student&#39;s service attendance hours. | [optional] 
**ServiceMembershipHours** | **int?** | Indicates a student&#39;s service membership hours. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

