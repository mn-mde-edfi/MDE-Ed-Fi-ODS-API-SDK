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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = EdFi.OdsApi.Sdk.Client.SwaggerDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Identity
{
    /// <summary>
    /// EdFiGraduationPlanRequiredAssessment
    /// </summary>
    [DataContract]
    public partial class EdFiGraduationPlanRequiredAssessment :  IEquatable<EdFiGraduationPlanRequiredAssessment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGraduationPlanRequiredAssessment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiGraduationPlanRequiredAssessment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGraduationPlanRequiredAssessment" /> class.
        /// </summary>
        /// <param name="assessmentReference">assessmentReference (required).</param>
        /// <param name="scores">An unordered collection of graduationPlanRequiredAssessmentScores. Score required to be met or exceeded..</param>
        /// <param name="performanceLevel">performanceLevel.</param>
        public EdFiGraduationPlanRequiredAssessment(EdFiAssessmentReference assessmentReference = default(EdFiAssessmentReference), List<EdFiGraduationPlanRequiredAssessmentScore> scores = default(List<EdFiGraduationPlanRequiredAssessmentScore>), EdFiGraduationPlanRequiredAssessmentPerformanceLevel performanceLevel = default(EdFiGraduationPlanRequiredAssessmentPerformanceLevel))
        {
            // to ensure "assessmentReference" is required (not null)
            if (assessmentReference == null)
            {
                throw new InvalidDataException("assessmentReference is a required property for EdFiGraduationPlanRequiredAssessment and cannot be null");
            }
            else
            {
                this.AssessmentReference = assessmentReference;
            }
            this.Scores = scores;
            this.PerformanceLevel = performanceLevel;
        }
        
        /// <summary>
        /// Gets or Sets AssessmentReference
        /// </summary>
        [DataMember(Name="assessmentReference", EmitDefaultValue=false)]
        public EdFiAssessmentReference AssessmentReference { get; set; }

        /// <summary>
        /// An unordered collection of graduationPlanRequiredAssessmentScores. Score required to be met or exceeded.
        /// </summary>
        /// <value>An unordered collection of graduationPlanRequiredAssessmentScores. Score required to be met or exceeded.</value>
        [DataMember(Name="scores", EmitDefaultValue=false)]
        public List<EdFiGraduationPlanRequiredAssessmentScore> Scores { get; set; }

        /// <summary>
        /// Gets or Sets PerformanceLevel
        /// </summary>
        [DataMember(Name="performanceLevel", EmitDefaultValue=false)]
        public EdFiGraduationPlanRequiredAssessmentPerformanceLevel PerformanceLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiGraduationPlanRequiredAssessment {\n");
            sb.Append("  AssessmentReference: ").Append(AssessmentReference).Append("\n");
            sb.Append("  Scores: ").Append(Scores).Append("\n");
            sb.Append("  PerformanceLevel: ").Append(PerformanceLevel).Append("\n");
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
            return this.Equals(input as EdFiGraduationPlanRequiredAssessment);
        }

        /// <summary>
        /// Returns true if EdFiGraduationPlanRequiredAssessment instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiGraduationPlanRequiredAssessment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiGraduationPlanRequiredAssessment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssessmentReference == input.AssessmentReference ||
                    (this.AssessmentReference != null &&
                    this.AssessmentReference.Equals(input.AssessmentReference))
                ) && 
                (
                    this.Scores == input.Scores ||
                    this.Scores != null &&
                    this.Scores.SequenceEqual(input.Scores)
                ) && 
                (
                    this.PerformanceLevel == input.PerformanceLevel ||
                    (this.PerformanceLevel != null &&
                    this.PerformanceLevel.Equals(input.PerformanceLevel))
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
                if (this.AssessmentReference != null)
                    hashCode = hashCode * 59 + this.AssessmentReference.GetHashCode();
                if (this.Scores != null)
                    hashCode = hashCode * 59 + this.Scores.GetHashCode();
                if (this.PerformanceLevel != null)
                    hashCode = hashCode * 59 + this.PerformanceLevel.GetHashCode();
                return hashCode;
            }
        }
    }

}
