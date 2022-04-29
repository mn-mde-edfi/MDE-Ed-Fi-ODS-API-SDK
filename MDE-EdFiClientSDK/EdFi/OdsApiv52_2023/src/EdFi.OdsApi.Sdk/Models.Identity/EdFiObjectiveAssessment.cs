/* 
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = EdFi.OdsApi.Sdk.Client.SwaggerDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Identity
{
    /// <summary>
    /// EdFiObjectiveAssessment
    /// </summary>
    [DataContract]
    public partial class EdFiObjectiveAssessment :  IEquatable<EdFiObjectiveAssessment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiObjectiveAssessment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiObjectiveAssessment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiObjectiveAssessment" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="identificationCode">A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, a state, or other agency or entity. (required).</param>
        /// <param name="assessmentReference">assessmentReference (required).</param>
        /// <param name="parentObjectiveAssessmentReference">parentObjectiveAssessmentReference.</param>
        /// <param name="academicSubjectDescriptor">The subject area of the objective assessment..</param>
        /// <param name="assessmentItems">An unordered collection of objectiveAssessmentAssessmentItems. References individual test items, if appropriate..</param>
        /// <param name="description">The description of the ObjectiveAssessment (e.g., vocabulary, measurement, or geometry)..</param>
        /// <param name="learningObjectives">An unordered collection of objectiveAssessmentLearningObjectives. References the LearningObjective(s) the ObjectiveAssessment tests..</param>
        /// <param name="learningStandards">An unordered collection of objectiveAssessmentLearningStandards. LearningStandard tested by this ObjectiveAssessment..</param>
        /// <param name="maxRawScore">The maximum raw score achievable across all assessment items that are correct and scored at the maximum..</param>
        /// <param name="nomenclature">Reflects the specific nomenclature used for this level of ObjectiveAssessment..</param>
        /// <param name="percentOfAssessment">The percentage of the Assessment that tests this objective..</param>
        /// <param name="performanceLevels">An unordered collection of objectiveAssessmentPerformanceLevels. Definition of the performance levels and the associated cut scores. Three styles are supported:         1. Specification of performance level by minimum and maximum score         2. Specification of performance level by cut score, using only minimum score         3. Specification of performance level without any mapping to scores.</param>
        /// <param name="scores">An unordered collection of objectiveAssessmentScores. Definition of the scores to be expected from this objective assessment..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiObjectiveAssessment(string id = default(string), string identificationCode = default(string), EdFiAssessmentReference assessmentReference = default(EdFiAssessmentReference), EdFiObjectiveAssessmentReference parentObjectiveAssessmentReference = default(EdFiObjectiveAssessmentReference), string academicSubjectDescriptor = default(string), List<EdFiObjectiveAssessmentAssessmentItem> assessmentItems = default(List<EdFiObjectiveAssessmentAssessmentItem>), string description = default(string), List<EdFiObjectiveAssessmentLearningObjective> learningObjectives = default(List<EdFiObjectiveAssessmentLearningObjective>), List<EdFiObjectiveAssessmentLearningStandard> learningStandards = default(List<EdFiObjectiveAssessmentLearningStandard>), double? maxRawScore = default(double?), string nomenclature = default(string), double? percentOfAssessment = default(double?), List<EdFiObjectiveAssessmentPerformanceLevel> performanceLevels = default(List<EdFiObjectiveAssessmentPerformanceLevel>), List<EdFiObjectiveAssessmentScore> scores = default(List<EdFiObjectiveAssessmentScore>), string etag = default(string))
        {
            // to ensure "identificationCode" is required (not null)
            if (identificationCode == null)
            {
                throw new InvalidDataException("identificationCode is a required property for EdFiObjectiveAssessment and cannot be null");
            }
            else
            {
                this.IdentificationCode = identificationCode;
            }
            // to ensure "assessmentReference" is required (not null)
            if (assessmentReference == null)
            {
                throw new InvalidDataException("assessmentReference is a required property for EdFiObjectiveAssessment and cannot be null");
            }
            else
            {
                this.AssessmentReference = assessmentReference;
            }
            this.Id = id;
            this.ParentObjectiveAssessmentReference = parentObjectiveAssessmentReference;
            this.AcademicSubjectDescriptor = academicSubjectDescriptor;
            this.AssessmentItems = assessmentItems;
            this.Description = description;
            this.LearningObjectives = learningObjectives;
            this.LearningStandards = learningStandards;
            this.MaxRawScore = maxRawScore;
            this.Nomenclature = nomenclature;
            this.PercentOfAssessment = percentOfAssessment;
            this.PerformanceLevels = performanceLevels;
            this.Scores = scores;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, a state, or other agency or entity.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, a state, or other agency or entity.</value>
        [DataMember(Name="identificationCode", EmitDefaultValue=false)]
        public string IdentificationCode { get; set; }

        /// <summary>
        /// Gets or Sets AssessmentReference
        /// </summary>
        [DataMember(Name="assessmentReference", EmitDefaultValue=false)]
        public EdFiAssessmentReference AssessmentReference { get; set; }

        /// <summary>
        /// Gets or Sets ParentObjectiveAssessmentReference
        /// </summary>
        [DataMember(Name="parentObjectiveAssessmentReference", EmitDefaultValue=false)]
        public EdFiObjectiveAssessmentReference ParentObjectiveAssessmentReference { get; set; }

        /// <summary>
        /// The subject area of the objective assessment.
        /// </summary>
        /// <value>The subject area of the objective assessment.</value>
        [DataMember(Name="academicSubjectDescriptor", EmitDefaultValue=false)]
        public string AcademicSubjectDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of objectiveAssessmentAssessmentItems. References individual test items, if appropriate.
        /// </summary>
        /// <value>An unordered collection of objectiveAssessmentAssessmentItems. References individual test items, if appropriate.</value>
        [DataMember(Name="assessmentItems", EmitDefaultValue=false)]
        public List<EdFiObjectiveAssessmentAssessmentItem> AssessmentItems { get; set; }

        /// <summary>
        /// The description of the ObjectiveAssessment (e.g., vocabulary, measurement, or geometry).
        /// </summary>
        /// <value>The description of the ObjectiveAssessment (e.g., vocabulary, measurement, or geometry).</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// An unordered collection of objectiveAssessmentLearningObjectives. References the LearningObjective(s) the ObjectiveAssessment tests.
        /// </summary>
        /// <value>An unordered collection of objectiveAssessmentLearningObjectives. References the LearningObjective(s) the ObjectiveAssessment tests.</value>
        [DataMember(Name="learningObjectives", EmitDefaultValue=false)]
        public List<EdFiObjectiveAssessmentLearningObjective> LearningObjectives { get; set; }

        /// <summary>
        /// An unordered collection of objectiveAssessmentLearningStandards. LearningStandard tested by this ObjectiveAssessment.
        /// </summary>
        /// <value>An unordered collection of objectiveAssessmentLearningStandards. LearningStandard tested by this ObjectiveAssessment.</value>
        [DataMember(Name="learningStandards", EmitDefaultValue=false)]
        public List<EdFiObjectiveAssessmentLearningStandard> LearningStandards { get; set; }

        /// <summary>
        /// The maximum raw score achievable across all assessment items that are correct and scored at the maximum.
        /// </summary>
        /// <value>The maximum raw score achievable across all assessment items that are correct and scored at the maximum.</value>
        [DataMember(Name="maxRawScore", EmitDefaultValue=false)]
        public double? MaxRawScore { get; set; }

        /// <summary>
        /// Reflects the specific nomenclature used for this level of ObjectiveAssessment.
        /// </summary>
        /// <value>Reflects the specific nomenclature used for this level of ObjectiveAssessment.</value>
        [DataMember(Name="nomenclature", EmitDefaultValue=false)]
        public string Nomenclature { get; set; }

        /// <summary>
        /// The percentage of the Assessment that tests this objective.
        /// </summary>
        /// <value>The percentage of the Assessment that tests this objective.</value>
        [DataMember(Name="percentOfAssessment", EmitDefaultValue=false)]
        public double? PercentOfAssessment { get; set; }

        /// <summary>
        /// An unordered collection of objectiveAssessmentPerformanceLevels. Definition of the performance levels and the associated cut scores. Three styles are supported:         1. Specification of performance level by minimum and maximum score         2. Specification of performance level by cut score, using only minimum score         3. Specification of performance level without any mapping to scores
        /// </summary>
        /// <value>An unordered collection of objectiveAssessmentPerformanceLevels. Definition of the performance levels and the associated cut scores. Three styles are supported:         1. Specification of performance level by minimum and maximum score         2. Specification of performance level by cut score, using only minimum score         3. Specification of performance level without any mapping to scores</value>
        [DataMember(Name="performanceLevels", EmitDefaultValue=false)]
        public List<EdFiObjectiveAssessmentPerformanceLevel> PerformanceLevels { get; set; }

        /// <summary>
        /// An unordered collection of objectiveAssessmentScores. Definition of the scores to be expected from this objective assessment.
        /// </summary>
        /// <value>An unordered collection of objectiveAssessmentScores. Definition of the scores to be expected from this objective assessment.</value>
        [DataMember(Name="scores", EmitDefaultValue=false)]
        public List<EdFiObjectiveAssessmentScore> Scores { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiObjectiveAssessment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdentificationCode: ").Append(IdentificationCode).Append("\n");
            sb.Append("  AssessmentReference: ").Append(AssessmentReference).Append("\n");
            sb.Append("  ParentObjectiveAssessmentReference: ").Append(ParentObjectiveAssessmentReference).Append("\n");
            sb.Append("  AcademicSubjectDescriptor: ").Append(AcademicSubjectDescriptor).Append("\n");
            sb.Append("  AssessmentItems: ").Append(AssessmentItems).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LearningObjectives: ").Append(LearningObjectives).Append("\n");
            sb.Append("  LearningStandards: ").Append(LearningStandards).Append("\n");
            sb.Append("  MaxRawScore: ").Append(MaxRawScore).Append("\n");
            sb.Append("  Nomenclature: ").Append(Nomenclature).Append("\n");
            sb.Append("  PercentOfAssessment: ").Append(PercentOfAssessment).Append("\n");
            sb.Append("  PerformanceLevels: ").Append(PerformanceLevels).Append("\n");
            sb.Append("  Scores: ").Append(Scores).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiObjectiveAssessment);
        }

        /// <summary>
        /// Returns true if EdFiObjectiveAssessment instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiObjectiveAssessment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiObjectiveAssessment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IdentificationCode == input.IdentificationCode ||
                    (this.IdentificationCode != null &&
                    this.IdentificationCode.Equals(input.IdentificationCode))
                ) && 
                (
                    this.AssessmentReference == input.AssessmentReference ||
                    (this.AssessmentReference != null &&
                    this.AssessmentReference.Equals(input.AssessmentReference))
                ) && 
                (
                    this.ParentObjectiveAssessmentReference == input.ParentObjectiveAssessmentReference ||
                    (this.ParentObjectiveAssessmentReference != null &&
                    this.ParentObjectiveAssessmentReference.Equals(input.ParentObjectiveAssessmentReference))
                ) && 
                (
                    this.AcademicSubjectDescriptor == input.AcademicSubjectDescriptor ||
                    (this.AcademicSubjectDescriptor != null &&
                    this.AcademicSubjectDescriptor.Equals(input.AcademicSubjectDescriptor))
                ) && 
                (
                    this.AssessmentItems == input.AssessmentItems ||
                    this.AssessmentItems != null &&
                    this.AssessmentItems.SequenceEqual(input.AssessmentItems)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.LearningObjectives == input.LearningObjectives ||
                    this.LearningObjectives != null &&
                    this.LearningObjectives.SequenceEqual(input.LearningObjectives)
                ) && 
                (
                    this.LearningStandards == input.LearningStandards ||
                    this.LearningStandards != null &&
                    this.LearningStandards.SequenceEqual(input.LearningStandards)
                ) && 
                (
                    this.MaxRawScore == input.MaxRawScore ||
                    (this.MaxRawScore != null &&
                    this.MaxRawScore.Equals(input.MaxRawScore))
                ) && 
                (
                    this.Nomenclature == input.Nomenclature ||
                    (this.Nomenclature != null &&
                    this.Nomenclature.Equals(input.Nomenclature))
                ) && 
                (
                    this.PercentOfAssessment == input.PercentOfAssessment ||
                    (this.PercentOfAssessment != null &&
                    this.PercentOfAssessment.Equals(input.PercentOfAssessment))
                ) && 
                (
                    this.PerformanceLevels == input.PerformanceLevels ||
                    this.PerformanceLevels != null &&
                    this.PerformanceLevels.SequenceEqual(input.PerformanceLevels)
                ) && 
                (
                    this.Scores == input.Scores ||
                    this.Scores != null &&
                    this.Scores.SequenceEqual(input.Scores)
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IdentificationCode != null)
                    hashCode = hashCode * 59 + this.IdentificationCode.GetHashCode();
                if (this.AssessmentReference != null)
                    hashCode = hashCode * 59 + this.AssessmentReference.GetHashCode();
                if (this.ParentObjectiveAssessmentReference != null)
                    hashCode = hashCode * 59 + this.ParentObjectiveAssessmentReference.GetHashCode();
                if (this.AcademicSubjectDescriptor != null)
                    hashCode = hashCode * 59 + this.AcademicSubjectDescriptor.GetHashCode();
                if (this.AssessmentItems != null)
                    hashCode = hashCode * 59 + this.AssessmentItems.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LearningObjectives != null)
                    hashCode = hashCode * 59 + this.LearningObjectives.GetHashCode();
                if (this.LearningStandards != null)
                    hashCode = hashCode * 59 + this.LearningStandards.GetHashCode();
                if (this.MaxRawScore != null)
                    hashCode = hashCode * 59 + this.MaxRawScore.GetHashCode();
                if (this.Nomenclature != null)
                    hashCode = hashCode * 59 + this.Nomenclature.GetHashCode();
                if (this.PercentOfAssessment != null)
                    hashCode = hashCode * 59 + this.PercentOfAssessment.GetHashCode();
                if (this.PerformanceLevels != null)
                    hashCode = hashCode * 59 + this.PerformanceLevels.GetHashCode();
                if (this.Scores != null)
                    hashCode = hashCode * 59 + this.Scores.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // IdentificationCode (string) maxLength
            if(this.IdentificationCode != null && this.IdentificationCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdentificationCode, length must be less than 60.", new [] { "IdentificationCode" });
            }

            // AcademicSubjectDescriptor (string) maxLength
            if(this.AcademicSubjectDescriptor != null && this.AcademicSubjectDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AcademicSubjectDescriptor, length must be less than 306.", new [] { "AcademicSubjectDescriptor" });
            }

            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 1024.", new [] { "Description" });
            }

            // Nomenclature (string) maxLength
            if(this.Nomenclature != null && this.Nomenclature.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Nomenclature, length must be less than 35.", new [] { "Nomenclature" });
            }

            yield break;
        }
    }

}
