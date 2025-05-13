# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile.MnStudentEarlyEducationProgramAssociationReadable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**BeginDate** | **DateTime** | The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. | 
**CalendarReference** | [**MnCalendarReference**](MnCalendarReference.md) |  | [optional] 
**EducationOrganizationReference** | [**MnEducationOrganizationReference**](MnEducationOrganizationReference.md) |  | 
**ProgramReference** | [**MnProgramReference**](MnProgramReference.md) |  | 
**StudentReference** | [**MnStudentReference**](MnStudentReference.md) |  | 
**FundingSources** | [**List&lt;MnStudentEarlyEducationProgramAssociationFundingSourceReadable&gt;**](MnStudentEarlyEducationProgramAssociationFundingSourceReadable.md) | An unordered collection of studentEarlyEducationProgramAssociationFundingSources. Funding source. | [optional] 
**Memberships** | [**List&lt;MnStudentEarlyEducationProgramAssociationMembershipReadable&gt;**](MnStudentEarlyEducationProgramAssociationMembershipReadable.md) | An unordered collection of studentEarlyEducationProgramAssociationMemberships. Entity containing Attendance Days or Hours, Membership Days or Hours, Percent Enrolled and flag indicated whether reported Membership and Attendance includes Days or Hours. | [optional] 
**ProgramSectionDescriptor** | **string** | Descriptor of the program section. | [optional] 
**ReasonExitedDescriptor** | **string** | The reason the student left the program within a school or district. | [optional] 
**ServedOutsideOfRegularSession** | **bool?** | Indicates whether the student received services during the summer session or between sessions. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

