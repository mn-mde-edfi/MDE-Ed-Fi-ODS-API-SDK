# EdFi.OdsApi.Sdk.Models.Identity.EdFiStudentDisciplineIncidentAssociation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**DisciplineIncidentReference** | [**EdFiDisciplineIncidentReference**](EdFiDisciplineIncidentReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**Behaviors** | [**List&lt;EdFiStudentDisciplineIncidentAssociationBehavior&gt;**](EdFiStudentDisciplineIncidentAssociationBehavior.md) | An unordered collection of studentDisciplineIncidentAssociationBehaviors. Describes behavior by category and provides a detailed description. | [optional] 
**StudentParticipationCodeDescriptor** | **string** | The role or type of participation of a student in a discipline incident;         for example:         Victim         Perpetrator         Witness         Reporter. | 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

