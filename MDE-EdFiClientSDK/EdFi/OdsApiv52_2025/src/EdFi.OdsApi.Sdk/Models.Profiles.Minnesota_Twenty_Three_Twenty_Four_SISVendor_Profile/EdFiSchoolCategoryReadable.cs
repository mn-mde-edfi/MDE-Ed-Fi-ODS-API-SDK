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
    /// EdFiSchoolCategoryReadable
    /// </summary>
    [DataContract(Name = "edFi_schoolCategory_readable")]
    public partial class EdFiSchoolCategoryReadable : IEquatable<EdFiSchoolCategoryReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSchoolCategoryReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSchoolCategoryReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSchoolCategoryReadable" /> class.
        /// </summary>
        /// <param name="schoolCategoryDescriptor">The one or more categories of school. For example: High School, Middle School, and/or Elementary School. (required).</param>
        public EdFiSchoolCategoryReadable(string schoolCategoryDescriptor = default(string))
        {
            // to ensure "schoolCategoryDescriptor" is required (not null)
            if (schoolCategoryDescriptor == null)
            {
                throw new ArgumentNullException("schoolCategoryDescriptor is a required property for EdFiSchoolCategoryReadable and cannot be null");
            }
            this.SchoolCategoryDescriptor = schoolCategoryDescriptor;
        }

        /// <summary>
        /// The one or more categories of school. For example: High School, Middle School, and/or Elementary School.
        /// </summary>
        /// <value>The one or more categories of school. For example: High School, Middle School, and/or Elementary School.</value>
        [DataMember(Name = "schoolCategoryDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string SchoolCategoryDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiSchoolCategoryReadable {\n");
            sb.Append("  SchoolCategoryDescriptor: ").Append(SchoolCategoryDescriptor).Append("\n");
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
            return this.Equals(input as EdFiSchoolCategoryReadable);
        }

        /// <summary>
        /// Returns true if EdFiSchoolCategoryReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSchoolCategoryReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSchoolCategoryReadable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SchoolCategoryDescriptor == input.SchoolCategoryDescriptor ||
                    (this.SchoolCategoryDescriptor != null &&
                    this.SchoolCategoryDescriptor.Equals(input.SchoolCategoryDescriptor))
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
                if (this.SchoolCategoryDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolCategoryDescriptor.GetHashCode();
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
            // SchoolCategoryDescriptor (string) maxLength
            if (this.SchoolCategoryDescriptor != null && this.SchoolCategoryDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SchoolCategoryDescriptor, length must be less than 306.", new [] { "SchoolCategoryDescriptor" });
            }

            yield break;
        }
    }

}
