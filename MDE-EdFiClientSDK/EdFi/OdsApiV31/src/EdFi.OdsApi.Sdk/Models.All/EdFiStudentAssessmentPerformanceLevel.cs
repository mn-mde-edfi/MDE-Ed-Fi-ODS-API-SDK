/* 
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface. The Ed-Fi ODS / API supports both transactional and bulk modes of operation.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
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

namespace EdFi.OdsApi.Sdk.Models.All
{
    /// <summary>
    /// EdFiStudentAssessmentPerformanceLevel
    /// </summary>
    [DataContract]
    public partial class EdFiStudentAssessmentPerformanceLevel :  IEquatable<EdFiStudentAssessmentPerformanceLevel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAssessmentPerformanceLevel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentAssessmentPerformanceLevel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAssessmentPerformanceLevel" /> class.
        /// </summary>
        /// <param name="AssessmentReportingMethodDescriptor">The method that the instructor of the class uses to report the performance and achievement. It may be a qualitative method such as individualized teacher comments or a quantitative method such as a letter or numerical grade. In some cases, more than one type of reporting method may be used. (required).</param>
        /// <param name="PerformanceLevelDescriptor">A specification of which performance level value describes the student proficiency. (required).</param>
        /// <param name="PerformanceLevelMet">Optional indicator of whether the performance level was met. (required).</param>
        public EdFiStudentAssessmentPerformanceLevel(string AssessmentReportingMethodDescriptor = default(string), string PerformanceLevelDescriptor = default(string), bool? PerformanceLevelMet = default(bool?))
        {
            // to ensure "AssessmentReportingMethodDescriptor" is required (not null)
            if (AssessmentReportingMethodDescriptor == null)
            {
                throw new InvalidDataException("AssessmentReportingMethodDescriptor is a required property for EdFiStudentAssessmentPerformanceLevel and cannot be null");
            }
            else
            {
                this.AssessmentReportingMethodDescriptor = AssessmentReportingMethodDescriptor;
            }
            // to ensure "PerformanceLevelDescriptor" is required (not null)
            if (PerformanceLevelDescriptor == null)
            {
                throw new InvalidDataException("PerformanceLevelDescriptor is a required property for EdFiStudentAssessmentPerformanceLevel and cannot be null");
            }
            else
            {
                this.PerformanceLevelDescriptor = PerformanceLevelDescriptor;
            }
            // to ensure "PerformanceLevelMet" is required (not null)
            if (PerformanceLevelMet == null)
            {
                throw new InvalidDataException("PerformanceLevelMet is a required property for EdFiStudentAssessmentPerformanceLevel and cannot be null");
            }
            else
            {
                this.PerformanceLevelMet = PerformanceLevelMet;
            }
        }
        
        /// <summary>
        /// The method that the instructor of the class uses to report the performance and achievement. It may be a qualitative method such as individualized teacher comments or a quantitative method such as a letter or numerical grade. In some cases, more than one type of reporting method may be used.
        /// </summary>
        /// <value>The method that the instructor of the class uses to report the performance and achievement. It may be a qualitative method such as individualized teacher comments or a quantitative method such as a letter or numerical grade. In some cases, more than one type of reporting method may be used.</value>
        [DataMember(Name="assessmentReportingMethodDescriptor", EmitDefaultValue=false)]
        public string AssessmentReportingMethodDescriptor { get; set; }

        /// <summary>
        /// A specification of which performance level value describes the student proficiency.
        /// </summary>
        /// <value>A specification of which performance level value describes the student proficiency.</value>
        [DataMember(Name="performanceLevelDescriptor", EmitDefaultValue=false)]
        public string PerformanceLevelDescriptor { get; set; }

        /// <summary>
        /// Optional indicator of whether the performance level was met.
        /// </summary>
        /// <value>Optional indicator of whether the performance level was met.</value>
        [DataMember(Name="performanceLevelMet", EmitDefaultValue=false)]
        public bool? PerformanceLevelMet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentAssessmentPerformanceLevel {\n");
            sb.Append("  AssessmentReportingMethodDescriptor: ").Append(AssessmentReportingMethodDescriptor).Append("\n");
            sb.Append("  PerformanceLevelDescriptor: ").Append(PerformanceLevelDescriptor).Append("\n");
            sb.Append("  PerformanceLevelMet: ").Append(PerformanceLevelMet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as EdFiStudentAssessmentPerformanceLevel);
        }

        /// <summary>
        /// Returns true if EdFiStudentAssessmentPerformanceLevel instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentAssessmentPerformanceLevel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentAssessmentPerformanceLevel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssessmentReportingMethodDescriptor == input.AssessmentReportingMethodDescriptor ||
                    (this.AssessmentReportingMethodDescriptor != null &&
                    this.AssessmentReportingMethodDescriptor.Equals(input.AssessmentReportingMethodDescriptor))
                ) && 
                (
                    this.PerformanceLevelDescriptor == input.PerformanceLevelDescriptor ||
                    (this.PerformanceLevelDescriptor != null &&
                    this.PerformanceLevelDescriptor.Equals(input.PerformanceLevelDescriptor))
                ) && 
                (
                    this.PerformanceLevelMet == input.PerformanceLevelMet ||
                    (this.PerformanceLevelMet != null &&
                    this.PerformanceLevelMet.Equals(input.PerformanceLevelMet))
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
                if (this.AssessmentReportingMethodDescriptor != null)
                    hashCode = hashCode * 59 + this.AssessmentReportingMethodDescriptor.GetHashCode();
                if (this.PerformanceLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.PerformanceLevelDescriptor.GetHashCode();
                if (this.PerformanceLevelMet != null)
                    hashCode = hashCode * 59 + this.PerformanceLevelMet.GetHashCode();
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
            // AssessmentReportingMethodDescriptor (string) maxLength
            if(this.AssessmentReportingMethodDescriptor != null && this.AssessmentReportingMethodDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentReportingMethodDescriptor, length must be less than 306.", new [] { "AssessmentReportingMethodDescriptor" });
            }

            // PerformanceLevelDescriptor (string) maxLength
            if(this.PerformanceLevelDescriptor != null && this.PerformanceLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PerformanceLevelDescriptor, length must be less than 306.", new [] { "PerformanceLevelDescriptor" });
            }

            yield break;
        }
    }

}
