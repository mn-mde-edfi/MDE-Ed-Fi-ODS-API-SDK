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
    /// EdFiSchoolGradeLevelReadable
    /// </summary>
    [DataContract(Name = "edFi_schoolGradeLevel_readable")]
    public partial class EdFiSchoolGradeLevelReadable : IEquatable<EdFiSchoolGradeLevelReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSchoolGradeLevelReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSchoolGradeLevelReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSchoolGradeLevelReadable" /> class.
        /// </summary>
        /// <param name="gradeLevelDescriptor">The grade levels served at the school. (required).</param>
        public EdFiSchoolGradeLevelReadable(string gradeLevelDescriptor = default(string))
        {
            // to ensure "gradeLevelDescriptor" is required (not null)
            if (gradeLevelDescriptor == null)
            {
                throw new ArgumentNullException("gradeLevelDescriptor is a required property for EdFiSchoolGradeLevelReadable and cannot be null");
            }
            this.GradeLevelDescriptor = gradeLevelDescriptor;
        }

        /// <summary>
        /// The grade levels served at the school.
        /// </summary>
        /// <value>The grade levels served at the school.</value>
        [DataMember(Name = "gradeLevelDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string GradeLevelDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiSchoolGradeLevelReadable {\n");
            sb.Append("  GradeLevelDescriptor: ").Append(GradeLevelDescriptor).Append("\n");
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
            return this.Equals(input as EdFiSchoolGradeLevelReadable);
        }

        /// <summary>
        /// Returns true if EdFiSchoolGradeLevelReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSchoolGradeLevelReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSchoolGradeLevelReadable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GradeLevelDescriptor == input.GradeLevelDescriptor ||
                    (this.GradeLevelDescriptor != null &&
                    this.GradeLevelDescriptor.Equals(input.GradeLevelDescriptor))
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
                if (this.GradeLevelDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.GradeLevelDescriptor.GetHashCode();
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
            // GradeLevelDescriptor (string) maxLength
            if (this.GradeLevelDescriptor != null && this.GradeLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GradeLevelDescriptor, length must be less than 306.", new [] { "GradeLevelDescriptor" });
            }

            yield break;
        }
    }

}
