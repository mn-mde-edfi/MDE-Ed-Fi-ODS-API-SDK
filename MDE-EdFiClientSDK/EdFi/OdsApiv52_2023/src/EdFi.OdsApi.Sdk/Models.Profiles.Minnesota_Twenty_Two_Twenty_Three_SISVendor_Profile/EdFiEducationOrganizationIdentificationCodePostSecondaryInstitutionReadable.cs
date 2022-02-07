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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = EdFi.OdsApi.Sdk.Client.SwaggerDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Two_Twenty_Three_SISVendor_Profile
{
    /// <summary>
    /// EdFiEducationOrganizationIdentificationCodePostSecondaryInstitutionReadable
    /// </summary>
    [DataContract]
    public partial class EdFiEducationOrganizationIdentificationCodePostSecondaryInstitutionReadable :  IEquatable<EdFiEducationOrganizationIdentificationCodePostSecondaryInstitutionReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationOrganizationIdentificationCodePostSecondaryInstitutionReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiEducationOrganizationIdentificationCodePostSecondaryInstitutionReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationOrganizationIdentificationCodePostSecondaryInstitutionReadable" /> class.
        /// </summary>
        /// <param name="educationOrganizationIdentificationSystemDescriptor">The school system, state, or agency assigning the identification code. (required).</param>
        /// <param name="identificationCode">A unique number or alphanumeric code that is assigned to an education organization by a school, school system, state, or other agency or entity. (required).</param>
        public EdFiEducationOrganizationIdentificationCodePostSecondaryInstitutionReadable(string educationOrganizationIdentificationSystemDescriptor = default(string), string identificationCode = default(string))
        {
            // to ensure "educationOrganizationIdentificationSystemDescriptor" is required (not null)
            if (educationOrganizationIdentificationSystemDescriptor == null)
            {
                throw new InvalidDataException("educationOrganizationIdentificationSystemDescriptor is a required property for EdFiEducationOrganizationIdentificationCodePostSecondaryInstitutionReadable and cannot be null");
            }
            else
            {
                this.EducationOrganizationIdentificationSystemDescriptor = educationOrganizationIdentificationSystemDescriptor;
            }
            // to ensure "identificationCode" is required (not null)
            if (identificationCode == null)
            {
                throw new InvalidDataException("identificationCode is a required property for EdFiEducationOrganizationIdentificationCodePostSecondaryInstitutionReadable and cannot be null");
            }
            else
            {
                this.IdentificationCode = identificationCode;
            }
        }
        
        /// <summary>
        /// The school system, state, or agency assigning the identification code.
        /// </summary>
        /// <value>The school system, state, or agency assigning the identification code.</value>
        [DataMember(Name="educationOrganizationIdentificationSystemDescriptor", EmitDefaultValue=false)]
        public string EducationOrganizationIdentificationSystemDescriptor { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code that is assigned to an education organization by a school, school system, state, or other agency or entity.
        /// </summary>
        /// <value>A unique number or alphanumeric code that is assigned to an education organization by a school, school system, state, or other agency or entity.</value>
        [DataMember(Name="identificationCode", EmitDefaultValue=false)]
        public string IdentificationCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiEducationOrganizationIdentificationCodePostSecondaryInstitutionReadable {\n");
            sb.Append("  EducationOrganizationIdentificationSystemDescriptor: ").Append(EducationOrganizationIdentificationSystemDescriptor).Append("\n");
            sb.Append("  IdentificationCode: ").Append(IdentificationCode).Append("\n");
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
            return this.Equals(input as EdFiEducationOrganizationIdentificationCodePostSecondaryInstitutionReadable);
        }

        /// <summary>
        /// Returns true if EdFiEducationOrganizationIdentificationCodePostSecondaryInstitutionReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiEducationOrganizationIdentificationCodePostSecondaryInstitutionReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiEducationOrganizationIdentificationCodePostSecondaryInstitutionReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EducationOrganizationIdentificationSystemDescriptor == input.EducationOrganizationIdentificationSystemDescriptor ||
                    (this.EducationOrganizationIdentificationSystemDescriptor != null &&
                    this.EducationOrganizationIdentificationSystemDescriptor.Equals(input.EducationOrganizationIdentificationSystemDescriptor))
                ) && 
                (
                    this.IdentificationCode == input.IdentificationCode ||
                    (this.IdentificationCode != null &&
                    this.IdentificationCode.Equals(input.IdentificationCode))
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
                if (this.EducationOrganizationIdentificationSystemDescriptor != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationIdentificationSystemDescriptor.GetHashCode();
                if (this.IdentificationCode != null)
                    hashCode = hashCode * 59 + this.IdentificationCode.GetHashCode();
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
            // EducationOrganizationIdentificationSystemDescriptor (string) maxLength
            if(this.EducationOrganizationIdentificationSystemDescriptor != null && this.EducationOrganizationIdentificationSystemDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EducationOrganizationIdentificationSystemDescriptor, length must be less than 306.", new [] { "EducationOrganizationIdentificationSystemDescriptor" });
            }

            // IdentificationCode (string) maxLength
            if(this.IdentificationCode != null && this.IdentificationCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdentificationCode, length must be less than 60.", new [] { "IdentificationCode" });
            }

            yield break;
        }
    }

}
