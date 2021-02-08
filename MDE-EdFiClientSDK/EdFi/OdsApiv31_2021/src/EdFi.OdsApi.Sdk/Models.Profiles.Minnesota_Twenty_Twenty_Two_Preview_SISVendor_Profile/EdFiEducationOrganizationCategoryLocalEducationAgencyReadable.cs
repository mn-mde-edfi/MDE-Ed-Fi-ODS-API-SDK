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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile
{
    /// <summary>
    /// EdFiEducationOrganizationCategoryLocalEducationAgencyReadable
    /// </summary>
    [DataContract]
    public partial class EdFiEducationOrganizationCategoryLocalEducationAgencyReadable :  IEquatable<EdFiEducationOrganizationCategoryLocalEducationAgencyReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationOrganizationCategoryLocalEducationAgencyReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiEducationOrganizationCategoryLocalEducationAgencyReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationOrganizationCategoryLocalEducationAgencyReadable" /> class.
        /// </summary>
        /// <param name="EducationOrganizationCategoryDescriptor">The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state. (required).</param>
        public EdFiEducationOrganizationCategoryLocalEducationAgencyReadable(string EducationOrganizationCategoryDescriptor = default(string))
        {
            // to ensure "EducationOrganizationCategoryDescriptor" is required (not null)
            if (EducationOrganizationCategoryDescriptor == null)
            {
                throw new InvalidDataException("EducationOrganizationCategoryDescriptor is a required property for EdFiEducationOrganizationCategoryLocalEducationAgencyReadable and cannot be null");
            }
            else
            {
                this.EducationOrganizationCategoryDescriptor = EducationOrganizationCategoryDescriptor;
            }
        }
        
        /// <summary>
        /// The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state.
        /// </summary>
        /// <value>The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state.</value>
        [DataMember(Name="educationOrganizationCategoryDescriptor", EmitDefaultValue=false)]
        public string EducationOrganizationCategoryDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiEducationOrganizationCategoryLocalEducationAgencyReadable {\n");
            sb.Append("  EducationOrganizationCategoryDescriptor: ").Append(EducationOrganizationCategoryDescriptor).Append("\n");
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
            return this.Equals(input as EdFiEducationOrganizationCategoryLocalEducationAgencyReadable);
        }

        /// <summary>
        /// Returns true if EdFiEducationOrganizationCategoryLocalEducationAgencyReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiEducationOrganizationCategoryLocalEducationAgencyReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiEducationOrganizationCategoryLocalEducationAgencyReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EducationOrganizationCategoryDescriptor == input.EducationOrganizationCategoryDescriptor ||
                    (this.EducationOrganizationCategoryDescriptor != null &&
                    this.EducationOrganizationCategoryDescriptor.Equals(input.EducationOrganizationCategoryDescriptor))
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
                if (this.EducationOrganizationCategoryDescriptor != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationCategoryDescriptor.GetHashCode();
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
            // EducationOrganizationCategoryDescriptor (string) maxLength
            if(this.EducationOrganizationCategoryDescriptor != null && this.EducationOrganizationCategoryDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EducationOrganizationCategoryDescriptor, length must be less than 306.", new [] { "EducationOrganizationCategoryDescriptor" });
            }

            yield break;
        }
    }

}
