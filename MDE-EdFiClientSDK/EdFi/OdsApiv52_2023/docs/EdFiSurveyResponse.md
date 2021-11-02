# EdFi.OdsApi.Sdk.Models.Identity.EdFiSurveyResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**SurveyResponseIdentifier** | **string** | The identifier of the survey typically from the survey application. | 
**ParentReference** | [**EdFiParentReference**](EdFiParentReference.md) |  | [optional] 
**StaffReference** | [**EdFiStaffReference**](EdFiStaffReference.md) |  | [optional] 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | [optional] 
**SurveyReference** | [**EdFiSurveyReference**](EdFiSurveyReference.md) |  | 
**ElectronicMailAddress** | **string** | Email address of the respondent. | [optional] 
**FullName** | **string** | Full name of the respondent. | [optional] 
**Location** | **string** | Location of the respondent, often a city, district, or school. | [optional] 
**ResponseDate** | **DateTime?** | Date of the survey response. | 
**ResponseTime** | **int?** | The amount of time (in seconds) it took for the respondent to complete the survey. | [optional] 
**SurveyLevels** | [**List&lt;EdFiSurveyResponseSurveyLevel&gt;**](EdFiSurveyResponseSurveyLevel.md) | An unordered collection of surveyResponseSurveyLevels. Provides information about the respondents of a survey and how they can be grouped together. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

