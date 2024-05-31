/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdFi.OdsApi.Sdk.Client.OpenAPIDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Three_Twenty_Four_SISVendor_Profile
{
    /// <summary>
    /// MnCourseAssessmentToolReadable
    /// </summary>
    [DataContract(Name = "mn_courseAssessmentTool_readable")]
    public partial class MnCourseAssessmentToolReadable : IEquatable<MnCourseAssessmentToolReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCourseAssessmentToolReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnCourseAssessmentToolReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCourseAssessmentToolReadable" /> class.
        /// </summary>
        /// <param name="assessmentToolDescriptor">Assessment tool. (required).</param>
        /// <param name="implementationStatusDescriptor">Status of implementation of the assessment tool..</param>
        public MnCourseAssessmentToolReadable(string assessmentToolDescriptor = default(string), string implementationStatusDescriptor = default(string))
        {
            // to ensure "assessmentToolDescriptor" is required (not null)
            if (assessmentToolDescriptor == null)
            {
                throw new ArgumentNullException("assessmentToolDescriptor is a required property for MnCourseAssessmentToolReadable and cannot be null");
            }
            this.AssessmentToolDescriptor = assessmentToolDescriptor;
            this.ImplementationStatusDescriptor = implementationStatusDescriptor;
        }

        /// <summary>
        /// Assessment tool.
        /// </summary>
        /// <value>Assessment tool.</value>
        [DataMember(Name = "assessmentToolDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string AssessmentToolDescriptor { get; set; }

        /// <summary>
        /// Status of implementation of the assessment tool.
        /// </summary>
        /// <value>Status of implementation of the assessment tool.</value>
        [DataMember(Name = "implementationStatusDescriptor", EmitDefaultValue = false)]
        public string ImplementationStatusDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MnCourseAssessmentToolReadable {\n");
            sb.Append("  AssessmentToolDescriptor: ").Append(AssessmentToolDescriptor).Append("\n");
            sb.Append("  ImplementationStatusDescriptor: ").Append(ImplementationStatusDescriptor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MnCourseAssessmentToolReadable);
        }

        /// <summary>
        /// Returns true if MnCourseAssessmentToolReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnCourseAssessmentToolReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnCourseAssessmentToolReadable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AssessmentToolDescriptor == input.AssessmentToolDescriptor ||
                    (this.AssessmentToolDescriptor != null &&
                    this.AssessmentToolDescriptor.Equals(input.AssessmentToolDescriptor))
                ) && 
                (
                    this.ImplementationStatusDescriptor == input.ImplementationStatusDescriptor ||
                    (this.ImplementationStatusDescriptor != null &&
                    this.ImplementationStatusDescriptor.Equals(input.ImplementationStatusDescriptor))
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
                if (this.AssessmentToolDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.AssessmentToolDescriptor.GetHashCode();
                }
                if (this.ImplementationStatusDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.ImplementationStatusDescriptor.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // AssessmentToolDescriptor (string) maxLength
            if (this.AssessmentToolDescriptor != null && this.AssessmentToolDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentToolDescriptor, length must be less than 306.", new [] { "AssessmentToolDescriptor" });
            }

            // ImplementationStatusDescriptor (string) maxLength
            if (this.ImplementationStatusDescriptor != null && this.ImplementationStatusDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImplementationStatusDescriptor, length must be less than 306.", new [] { "ImplementationStatusDescriptor" });
            }

            yield break;
        }
    }

}
