# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile.EdFiDisciplineActionWritable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**DisciplineActionIdentifier** | **string** | Identifier assigned by the education organization to the DisciplineAction. | 
**DisciplineDate** | **DateTime** | The date of the DisciplineAction. | 
**Disciplines** | [**List&lt;EdFiDisciplineActionDisciplineWritable&gt;**](EdFiDisciplineActionDisciplineWritable.md) | An unordered collection of disciplineActionDisciplines. Type of action, such as removal from the classroom, used to discipline the student involved as a perpetrator in a discipline incident. | 
**ResponsibilitySchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**ActualDisciplineActionLength** | **double** | Indicates the actual length in school days of a student&#39;s disciplinary assignment. | [optional] 
**DisciplineActionLength** | **double** | The length of time in school days for the DisciplineAction (e.g. removal, detention), if applicable. | [optional] 
**StudentDisciplineIncidentBehaviorAssociations** | [**List&lt;EdFiDisciplineActionStudentDisciplineIncidentBehaviorAssociationWritable&gt;**](EdFiDisciplineActionStudentDisciplineIncidentBehaviorAssociationWritable.md) | An unordered collection of disciplineActionStudentDisciplineIncidentBehaviorAssociations. A reference to the behavior(s) by the student that led or contributed to this specific action. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | [**DisciplineActionExtensionsWritable**](DisciplineActionExtensionsWritable.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

