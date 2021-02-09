# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile.MnStudentEarlyEducationProgramAssociationWritable
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**BeginDate** | **DateTime?** | The month, day, and year on which the Student first received services. | 
**EducationOrganizationReference** | [**MnEducationOrganizationReference**](MnEducationOrganizationReference.md) |  | 
**ProgramReference** | [**MnProgramReference**](MnProgramReference.md) |  | 
**StudentReference** | [**MnStudentReference**](MnStudentReference.md) |  | 
**EndDate** | **DateTime?** | The month, day, and year on which the Student exited the Program or stopped receiving services. | [optional] 
**FundingSources** | [**List&lt;MnStudentEarlyEducationProgramAssociationFundingSourceWritable&gt;**](MnStudentEarlyEducationProgramAssociationFundingSourceWritable.md) | An unordered collection of studentEarlyEducationProgramAssociationFundingSources. Funding source. | [optional] 
**ReasonExitedDescriptor** | **string** | The reason the child left the Program within a school or district. | [optional] 
**ServedOutsideOfRegularSession** | **bool?** | Indicates whether the Student received services during the summer session or between sessions. | [optional] 
**ServiceAttendanceHours** | **int?** | Indicates a student&#39;s service attendance hours. | [optional] 
**ServiceMembershipHours** | **int?** | Indicates a student&#39;s service membership hours. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

