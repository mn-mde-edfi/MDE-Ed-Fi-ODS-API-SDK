# EdFi.OdsApi.Sdk.Models.Identity.EdFiInterventionStudy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**InterventionStudyIdentificationCode** | **string** | A unique number or alphanumeric code assigned to an intervention study. | 
**EducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | 
**InterventionPrescriptionReference** | [**EdFiInterventionPrescriptionReference**](EdFiInterventionPrescriptionReference.md) |  | 
**AppropriateGradeLevels** | [**List&lt;EdFiInterventionStudyAppropriateGradeLevel&gt;**](EdFiInterventionStudyAppropriateGradeLevel.md) | An unordered collection of interventionStudyAppropriateGradeLevels. Grade levels participating in this study. | [optional] 
**AppropriateSexes** | [**List&lt;EdFiInterventionStudyAppropriateSex&gt;**](EdFiInterventionStudyAppropriateSex.md) | An unordered collection of interventionStudyAppropriateSexes. Sexes participating in this study. If omitted, considered generally applicable. | [optional] 
**DeliveryMethodDescriptor** | **string** | The way in which an intervention was implemented: individual, small group, whole class, or whole school. | 
**EducationContents** | [**List&lt;EdFiInterventionStudyEducationContent&gt;**](EdFiInterventionStudyEducationContent.md) | An unordered collection of interventionStudyEducationContents. Relates the education content source to the education content. | [optional] 
**InterventionClassDescriptor** | **string** | The way in which an intervention is used: curriculum, supplement, or practice. | 
**InterventionEffectivenesses** | [**List&lt;EdFiInterventionStudyInterventionEffectiveness&gt;**](EdFiInterventionStudyInterventionEffectiveness.md) | An unordered collection of interventionStudyInterventionEffectivenesses. Measurement of the effectiveness of the InterventionStudy per diagnosis. | [optional] 
**LearningResourceMetadataURIs** | [**List&lt;EdFiInterventionStudyLearningResourceMetadataURI&gt;**](EdFiInterventionStudyLearningResourceMetadataURI.md) | An unordered collection of interventionStudyLearningResourceMetadataURIs. The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item. | [optional] 
**Participants** | **int?** | The number of participants observed in the study. | 
**PopulationServeds** | [**List&lt;EdFiInterventionStudyPopulationServed&gt;**](EdFiInterventionStudyPopulationServed.md) | An unordered collection of interventionStudyPopulationServeds. A subset of students that are the focus of the InterventionStudy. | [optional] 
**StateAbbreviations** | [**List&lt;EdFiInterventionStudyStateAbbreviation&gt;**](EdFiInterventionStudyStateAbbreviation.md) | An unordered collection of interventionStudyStateAbbreviations. The abbreviation for the state (within the United States) or outlying area, the school system of which the participants of the study are considered to be a part. | [optional] 
**Uris** | [**List&lt;EdFiInterventionStudyURI&gt;**](EdFiInterventionStudyURI.md) | An unordered collection of interventionStudyURIs. The URI (typical a URL) pointing to an education content item. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

