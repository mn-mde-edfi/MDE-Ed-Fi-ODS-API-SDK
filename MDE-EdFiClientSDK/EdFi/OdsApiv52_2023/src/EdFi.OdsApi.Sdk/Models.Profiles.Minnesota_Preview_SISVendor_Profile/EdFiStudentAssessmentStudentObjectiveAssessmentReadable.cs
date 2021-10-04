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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile
{
    /// <summary>
    /// EdFiStudentAssessmentStudentObjectiveAssessmentReadable
    /// </summary>
    [DataContract]
    public partial class EdFiStudentAssessmentStudentObjectiveAssessmentReadable :  IEquatable<EdFiStudentAssessmentStudentObjectiveAssessmentReadable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAssessmentStudentObjectiveAssessmentReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentAssessmentStudentObjectiveAssessmentReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAssessmentStudentObjectiveAssessmentReadable" /> class.
        /// </summary>
        /// <param name="objectiveAssessmentReference">objectiveAssessmentReference (required).</param>
        /// <param name="performanceLevels">An unordered collection of studentAssessmentStudentObjectiveAssessmentPerformanceLevels. The PerformanceLevel(s) achieved for the ObjectiveAssessment..</param>
        /// <param name="scoreResults">An unordered collection of studentAssessmentStudentObjectiveAssessmentScoreResults. A meaningful score or statistical expression of the performance of an individual. The results can be expressed as a number, percentile, range, level, etc. (required).</param>
        /// <param name="ext">ext.</param>
        public EdFiStudentAssessmentStudentObjectiveAssessmentReadable(EdFiObjectiveAssessmentReference objectiveAssessmentReference = default(EdFiObjectiveAssessmentReference), List<EdFiStudentAssessmentStudentObjectiveAssessmentPerformanceLevelReadable> performanceLevels = default(List<EdFiStudentAssessmentStudentObjectiveAssessmentPerformanceLevelReadable>), List<EdFiStudentAssessmentStudentObjectiveAssessmentScoreResultReadable> scoreResults = default(List<EdFiStudentAssessmentStudentObjectiveAssessmentScoreResultReadable>), StudentAssessmentStudentObjectiveAssessmentExtensionsReadable ext = default(StudentAssessmentStudentObjectiveAssessmentExtensionsReadable))
        {
            // to ensure "objectiveAssessmentReference" is required (not null)
            if (objectiveAssessmentReference == null)
            {
                throw new InvalidDataException("objectiveAssessmentReference is a required property for EdFiStudentAssessmentStudentObjectiveAssessmentReadable and cannot be null");
            }
            else
            {
                this.ObjectiveAssessmentReference = objectiveAssessmentReference;
            }
            // to ensure "scoreResults" is required (not null)
            if (scoreResults == null)
            {
                throw new InvalidDataException("scoreResults is a required property for EdFiStudentAssessmentStudentObjectiveAssessmentReadable and cannot be null");
            }
            else
            {
                this.ScoreResults = scoreResults;
            }
            this.PerformanceLevels = performanceLevels;
            this.Ext = ext;
        }
        
        /// <summary>
        /// Gets or Sets ObjectiveAssessmentReference
        /// </summary>
        [DataMember(Name="objectiveAssessmentReference", EmitDefaultValue=false)]
        public EdFiObjectiveAssessmentReference ObjectiveAssessmentReference { get; set; }

        /// <summary>
        /// An unordered collection of studentAssessmentStudentObjectiveAssessmentPerformanceLevels. The PerformanceLevel(s) achieved for the ObjectiveAssessment.
        /// </summary>
        /// <value>An unordered collection of studentAssessmentStudentObjectiveAssessmentPerformanceLevels. The PerformanceLevel(s) achieved for the ObjectiveAssessment.</value>
        [DataMember(Name="performanceLevels", EmitDefaultValue=false)]
        public List<EdFiStudentAssessmentStudentObjectiveAssessmentPerformanceLevelReadable> PerformanceLevels { get; set; }

        /// <summary>
        /// An unordered collection of studentAssessmentStudentObjectiveAssessmentScoreResults. A meaningful score or statistical expression of the performance of an individual. The results can be expressed as a number, percentile, range, level, etc.
        /// </summary>
        /// <value>An unordered collection of studentAssessmentStudentObjectiveAssessmentScoreResults. A meaningful score or statistical expression of the performance of an individual. The results can be expressed as a number, percentile, range, level, etc.</value>
        [DataMember(Name="scoreResults", EmitDefaultValue=false)]
        public List<EdFiStudentAssessmentStudentObjectiveAssessmentScoreResultReadable> ScoreResults { get; set; }

        /// <summary>
        /// Gets or Sets Ext
        /// </summary>
        [DataMember(Name="_ext", EmitDefaultValue=false)]
        public StudentAssessmentStudentObjectiveAssessmentExtensionsReadable Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentAssessmentStudentObjectiveAssessmentReadable {\n");
            sb.Append("  ObjectiveAssessmentReference: ").Append(ObjectiveAssessmentReference).Append("\n");
            sb.Append("  PerformanceLevels: ").Append(PerformanceLevels).Append("\n");
            sb.Append("  ScoreResults: ").Append(ScoreResults).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
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
            return this.Equals(input as EdFiStudentAssessmentStudentObjectiveAssessmentReadable);
        }

        /// <summary>
        /// Returns true if EdFiStudentAssessmentStudentObjectiveAssessmentReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentAssessmentStudentObjectiveAssessmentReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentAssessmentStudentObjectiveAssessmentReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectiveAssessmentReference == input.ObjectiveAssessmentReference ||
                    (this.ObjectiveAssessmentReference != null &&
                    this.ObjectiveAssessmentReference.Equals(input.ObjectiveAssessmentReference))
                ) && 
                (
                    this.PerformanceLevels == input.PerformanceLevels ||
                    this.PerformanceLevels != null &&
                    this.PerformanceLevels.SequenceEqual(input.PerformanceLevels)
                ) && 
                (
                    this.ScoreResults == input.ScoreResults ||
                    this.ScoreResults != null &&
                    this.ScoreResults.SequenceEqual(input.ScoreResults)
                ) && 
                (
                    this.Ext == input.Ext ||
                    (this.Ext != null &&
                    this.Ext.Equals(input.Ext))
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
                if (this.ObjectiveAssessmentReference != null)
                    hashCode = hashCode * 59 + this.ObjectiveAssessmentReference.GetHashCode();
                if (this.PerformanceLevels != null)
                    hashCode = hashCode * 59 + this.PerformanceLevels.GetHashCode();
                if (this.ScoreResults != null)
                    hashCode = hashCode * 59 + this.ScoreResults.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
                return hashCode;
            }
        }
    }

}
