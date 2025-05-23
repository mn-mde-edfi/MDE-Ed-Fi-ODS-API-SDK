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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile
{
    /// <summary>
    /// MnGradeExtensionWritable
    /// </summary>
    [DataContract(Name = "mn_gradeExtension_writable")]
    public partial class MnGradeExtensionWritable : IEquatable<MnGradeExtensionWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnGradeExtensionWritable" /> class.
        /// </summary>
        /// <param name="academicSubjectDescriptor">This descriptor holds the description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language)..</param>
        /// <param name="collegeCreditEarned">College credit earned..</param>
        /// <param name="collegeGradeEarned">College grade earned..</param>
        /// <param name="localCreditEarned">College credit earned..</param>
        public MnGradeExtensionWritable(string academicSubjectDescriptor = default(string), double? collegeCreditEarned = default(double?), string collegeGradeEarned = default(string), double? localCreditEarned = default(double?))
        {
            this.AcademicSubjectDescriptor = academicSubjectDescriptor;
            this.CollegeCreditEarned = collegeCreditEarned;
            this.CollegeGradeEarned = collegeGradeEarned;
            this.LocalCreditEarned = localCreditEarned;
        }

        /// <summary>
        /// This descriptor holds the description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language).
        /// </summary>
        /// <value>This descriptor holds the description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language).</value>
        [DataMember(Name = "academicSubjectDescriptor", EmitDefaultValue = true)]
        public string AcademicSubjectDescriptor { get; set; }

        /// <summary>
        /// College credit earned.
        /// </summary>
        /// <value>College credit earned.</value>
        [DataMember(Name = "collegeCreditEarned", EmitDefaultValue = true)]
        public double? CollegeCreditEarned { get; set; }

        /// <summary>
        /// College grade earned.
        /// </summary>
        /// <value>College grade earned.</value>
        [DataMember(Name = "collegeGradeEarned", EmitDefaultValue = true)]
        public string CollegeGradeEarned { get; set; }

        /// <summary>
        /// College credit earned.
        /// </summary>
        /// <value>College credit earned.</value>
        [DataMember(Name = "localCreditEarned", EmitDefaultValue = true)]
        public double? LocalCreditEarned { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MnGradeExtensionWritable {\n");
            sb.Append("  AcademicSubjectDescriptor: ").Append(AcademicSubjectDescriptor).Append("\n");
            sb.Append("  CollegeCreditEarned: ").Append(CollegeCreditEarned).Append("\n");
            sb.Append("  CollegeGradeEarned: ").Append(CollegeGradeEarned).Append("\n");
            sb.Append("  LocalCreditEarned: ").Append(LocalCreditEarned).Append("\n");
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
            return this.Equals(input as MnGradeExtensionWritable);
        }

        /// <summary>
        /// Returns true if MnGradeExtensionWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnGradeExtensionWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnGradeExtensionWritable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcademicSubjectDescriptor == input.AcademicSubjectDescriptor ||
                    (this.AcademicSubjectDescriptor != null &&
                    this.AcademicSubjectDescriptor.Equals(input.AcademicSubjectDescriptor))
                ) && 
                (
                    this.CollegeCreditEarned == input.CollegeCreditEarned ||
                    (this.CollegeCreditEarned != null &&
                    this.CollegeCreditEarned.Equals(input.CollegeCreditEarned))
                ) && 
                (
                    this.CollegeGradeEarned == input.CollegeGradeEarned ||
                    (this.CollegeGradeEarned != null &&
                    this.CollegeGradeEarned.Equals(input.CollegeGradeEarned))
                ) && 
                (
                    this.LocalCreditEarned == input.LocalCreditEarned ||
                    (this.LocalCreditEarned != null &&
                    this.LocalCreditEarned.Equals(input.LocalCreditEarned))
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
                if (this.AcademicSubjectDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.AcademicSubjectDescriptor.GetHashCode();
                }
                if (this.CollegeCreditEarned != null)
                {
                    hashCode = (hashCode * 59) + this.CollegeCreditEarned.GetHashCode();
                }
                if (this.CollegeGradeEarned != null)
                {
                    hashCode = (hashCode * 59) + this.CollegeGradeEarned.GetHashCode();
                }
                if (this.LocalCreditEarned != null)
                {
                    hashCode = (hashCode * 59) + this.LocalCreditEarned.GetHashCode();
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
            // AcademicSubjectDescriptor (string) maxLength
            if (this.AcademicSubjectDescriptor != null && this.AcademicSubjectDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AcademicSubjectDescriptor, length must be less than 306.", new [] { "AcademicSubjectDescriptor" });
            }

            // CollegeGradeEarned (string) maxLength
            if (this.CollegeGradeEarned != null && this.CollegeGradeEarned.Length > 16)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CollegeGradeEarned, length must be less than 16.", new [] { "CollegeGradeEarned" });
            }

            yield break;
        }
    }

}
