# EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile.EdFiDisciplineIncidentReadable

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**IncidentIdentifier** | **string** | A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders. | 
**Locations** | [**List&lt;EdFiDisciplineIncidentLocationReadable&gt;**](EdFiDisciplineIncidentLocationReadable.md) | An unordered collection of disciplineIncidentLocations. Identifies where the DisciplineIncident occurred and whether or not it occurred on school, for example:        On school        Administrative offices area        Cafeteria area        Classroom        Hallway or stairs        ... | 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**IncidentDate** | **DateTime** | The month, day, and year on which the DisciplineIncident occurred. | 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | [**DisciplineIncidentExtensionsReadable**](DisciplineIncidentExtensionsReadable.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

