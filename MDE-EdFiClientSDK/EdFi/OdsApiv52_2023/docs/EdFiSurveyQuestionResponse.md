# EdFi.OdsApi.Sdk.Models.Identity.EdFiSurveyQuestionResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**SurveyQuestionReference** | [**EdFiSurveyQuestionReference**](EdFiSurveyQuestionReference.md) |  | 
**SurveyResponseReference** | [**EdFiSurveyResponseReference**](EdFiSurveyResponseReference.md) |  | 
**Comment** | **string** | Additional information provided by the responder about the question in the survey. | [optional] 
**NoResponse** | **bool?** | Indicates there was no response to the question. | [optional] 
**SurveyQuestionMatrixElementResponses** | [**List&lt;EdFiSurveyQuestionResponseSurveyQuestionMatrixElementResponse&gt;**](EdFiSurveyQuestionResponseSurveyQuestionMatrixElementResponse.md) | An unordered collection of surveyQuestionResponseSurveyQuestionMatrixElementResponses. For matrix questions, the response for each row of the matrix. | [optional] 
**Values** | [**List&lt;EdFiSurveyQuestionResponseValue&gt;**](EdFiSurveyQuestionResponseValue.md) | An unordered collection of surveyQuestionResponseValues. For free-form, single- or multiple-selection questions, one or more responses. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

