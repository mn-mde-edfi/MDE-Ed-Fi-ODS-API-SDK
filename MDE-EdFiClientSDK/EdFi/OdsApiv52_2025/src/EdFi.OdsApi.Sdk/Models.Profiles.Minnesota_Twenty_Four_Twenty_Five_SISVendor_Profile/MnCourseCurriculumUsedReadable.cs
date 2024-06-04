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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile
{
    /// <summary>
    /// MnCourseCurriculumUsedReadable
    /// </summary>
    [DataContract(Name = "mn_courseCurriculumUsed_readable")]
    public partial class MnCourseCurriculumUsedReadable : IEquatable<MnCourseCurriculumUsedReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCourseCurriculumUsedReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnCourseCurriculumUsedReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCourseCurriculumUsedReadable" /> class.
        /// </summary>
        /// <param name="curriculumUsedDescriptor">The type of curriculum used in an early learning classroom or group. (required).</param>
        /// <param name="implementationStatusDescriptor">Status of implementation of the curriculum used..</param>
        public MnCourseCurriculumUsedReadable(string curriculumUsedDescriptor = default(string), string implementationStatusDescriptor = default(string))
        {
            // to ensure "curriculumUsedDescriptor" is required (not null)
            if (curriculumUsedDescriptor == null)
            {
                throw new ArgumentNullException("curriculumUsedDescriptor is a required property for MnCourseCurriculumUsedReadable and cannot be null");
            }
            this.CurriculumUsedDescriptor = curriculumUsedDescriptor;
            this.ImplementationStatusDescriptor = implementationStatusDescriptor;
        }

        /// <summary>
        /// The type of curriculum used in an early learning classroom or group.
        /// </summary>
        /// <value>The type of curriculum used in an early learning classroom or group.</value>
        [DataMember(Name = "curriculumUsedDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string CurriculumUsedDescriptor { get; set; }

        /// <summary>
        /// Status of implementation of the curriculum used.
        /// </summary>
        /// <value>Status of implementation of the curriculum used.</value>
        [DataMember(Name = "implementationStatusDescriptor", EmitDefaultValue = false)]
        public string ImplementationStatusDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MnCourseCurriculumUsedReadable {\n");
            sb.Append("  CurriculumUsedDescriptor: ").Append(CurriculumUsedDescriptor).Append("\n");
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
            return this.Equals(input as MnCourseCurriculumUsedReadable);
        }

        /// <summary>
        /// Returns true if MnCourseCurriculumUsedReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnCourseCurriculumUsedReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnCourseCurriculumUsedReadable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CurriculumUsedDescriptor == input.CurriculumUsedDescriptor ||
                    (this.CurriculumUsedDescriptor != null &&
                    this.CurriculumUsedDescriptor.Equals(input.CurriculumUsedDescriptor))
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
                if (this.CurriculumUsedDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.CurriculumUsedDescriptor.GetHashCode();
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
            // CurriculumUsedDescriptor (string) maxLength
            if (this.CurriculumUsedDescriptor != null && this.CurriculumUsedDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CurriculumUsedDescriptor, length must be less than 306.", new [] { "CurriculumUsedDescriptor" });
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
