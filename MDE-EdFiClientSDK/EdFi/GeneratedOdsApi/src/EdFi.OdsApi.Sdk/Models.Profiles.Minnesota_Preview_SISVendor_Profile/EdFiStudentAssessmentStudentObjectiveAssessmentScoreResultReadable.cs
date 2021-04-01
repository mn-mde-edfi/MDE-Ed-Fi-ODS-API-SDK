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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile
{
    /// <summary>
    /// EdFiStudentAssessmentStudentObjectiveAssessmentScoreResultReadable
    /// </summary>
    [DataContract]
    public partial class EdFiStudentAssessmentStudentObjectiveAssessmentScoreResultReadable :  IEquatable<EdFiStudentAssessmentStudentObjectiveAssessmentScoreResultReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAssessmentStudentObjectiveAssessmentScoreResultReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentAssessmentStudentObjectiveAssessmentScoreResultReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAssessmentStudentObjectiveAssessmentScoreResultReadable" /> class.
        /// </summary>
        /// <param name="AssessmentReportingMethodDescriptor">The method that the administrator of the assessment uses to report the performance and achievement of all students. It may be a qualitative method such as performance level descriptors or a quantitative method such as a numerical grade or cut score. More than one type of reporting method may be used. (required).</param>
        /// <param name="ResultDatatypeTypeDescriptor">The datatype of the result. The results can be expressed as a number, percentile, range, level, etc. (required).</param>
        /// <param name="Result">The value of a meaningful raw score or statistical expression of the performance of an individual. The results can be expressed as a number, percentile, range, level, etc. (required).</param>
        public EdFiStudentAssessmentStudentObjectiveAssessmentScoreResultReadable(string AssessmentReportingMethodDescriptor = default(string), string ResultDatatypeTypeDescriptor = default(string), string Result = default(string))
        {
            // to ensure "AssessmentReportingMethodDescriptor" is required (not null)
            if (AssessmentReportingMethodDescriptor == null)
            {
                throw new InvalidDataException("AssessmentReportingMethodDescriptor is a required property for EdFiStudentAssessmentStudentObjectiveAssessmentScoreResultReadable and cannot be null");
            }
            else
            {
                this.AssessmentReportingMethodDescriptor = AssessmentReportingMethodDescriptor;
            }
            // to ensure "ResultDatatypeTypeDescriptor" is required (not null)
            if (ResultDatatypeTypeDescriptor == null)
            {
                throw new InvalidDataException("ResultDatatypeTypeDescriptor is a required property for EdFiStudentAssessmentStudentObjectiveAssessmentScoreResultReadable and cannot be null");
            }
            else
            {
                this.ResultDatatypeTypeDescriptor = ResultDatatypeTypeDescriptor;
            }
            // to ensure "Result" is required (not null)
            if (Result == null)
            {
                throw new InvalidDataException("Result is a required property for EdFiStudentAssessmentStudentObjectiveAssessmentScoreResultReadable and cannot be null");
            }
            else
            {
                this.Result = Result;
            }
        }
        
        /// <summary>
        /// The method that the administrator of the assessment uses to report the performance and achievement of all students. It may be a qualitative method such as performance level descriptors or a quantitative method such as a numerical grade or cut score. More than one type of reporting method may be used.
        /// </summary>
        /// <value>The method that the administrator of the assessment uses to report the performance and achievement of all students. It may be a qualitative method such as performance level descriptors or a quantitative method such as a numerical grade or cut score. More than one type of reporting method may be used.</value>
        [DataMember(Name="assessmentReportingMethodDescriptor", EmitDefaultValue=false)]
        public string AssessmentReportingMethodDescriptor { get; set; }

        /// <summary>
        /// The datatype of the result. The results can be expressed as a number, percentile, range, level, etc.
        /// </summary>
        /// <value>The datatype of the result. The results can be expressed as a number, percentile, range, level, etc.</value>
        [DataMember(Name="resultDatatypeTypeDescriptor", EmitDefaultValue=false)]
        public string ResultDatatypeTypeDescriptor { get; set; }

        /// <summary>
        /// The value of a meaningful raw score or statistical expression of the performance of an individual. The results can be expressed as a number, percentile, range, level, etc.
        /// </summary>
        /// <value>The value of a meaningful raw score or statistical expression of the performance of an individual. The results can be expressed as a number, percentile, range, level, etc.</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public string Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentAssessmentStudentObjectiveAssessmentScoreResultReadable {\n");
            sb.Append("  AssessmentReportingMethodDescriptor: ").Append(AssessmentReportingMethodDescriptor).Append("\n");
            sb.Append("  ResultDatatypeTypeDescriptor: ").Append(ResultDatatypeTypeDescriptor).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(input as EdFiStudentAssessmentStudentObjectiveAssessmentScoreResultReadable);
        }

        /// <summary>
        /// Returns true if EdFiStudentAssessmentStudentObjectiveAssessmentScoreResultReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentAssessmentStudentObjectiveAssessmentScoreResultReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentAssessmentStudentObjectiveAssessmentScoreResultReadable input)
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
                    this.ResultDatatypeTypeDescriptor == input.ResultDatatypeTypeDescriptor ||
                    (this.ResultDatatypeTypeDescriptor != null &&
                    this.ResultDatatypeTypeDescriptor.Equals(input.ResultDatatypeTypeDescriptor))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
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
                if (this.ResultDatatypeTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.ResultDatatypeTypeDescriptor.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
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

            // ResultDatatypeTypeDescriptor (string) maxLength
            if(this.ResultDatatypeTypeDescriptor != null && this.ResultDatatypeTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResultDatatypeTypeDescriptor, length must be less than 306.", new [] { "ResultDatatypeTypeDescriptor" });
            }

            // Result (string) maxLength
            if(this.Result != null && this.Result.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Result, length must be less than 35.", new [] { "Result" });
            }

            yield break;
        }
    }

}
