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
    /// EdFiStudentEducationOrganizationAssociationDisabilityDesignation
    /// </summary>
    [DataContract]
    public partial class EdFiStudentEducationOrganizationAssociationDisabilityDesignation :  IEquatable<EdFiStudentEducationOrganizationAssociationDisabilityDesignation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationDisabilityDesignation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentEducationOrganizationAssociationDisabilityDesignation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationDisabilityDesignation" /> class.
        /// </summary>
        /// <param name="DisabilityDesignationDescriptor">Whether the disability is IDEA, Section 504, or other disability designation. (required).</param>
        public EdFiStudentEducationOrganizationAssociationDisabilityDesignation(string DisabilityDesignationDescriptor = default(string))
        {
            // to ensure "DisabilityDesignationDescriptor" is required (not null)
            if (DisabilityDesignationDescriptor == null)
            {
                throw new InvalidDataException("DisabilityDesignationDescriptor is a required property for EdFiStudentEducationOrganizationAssociationDisabilityDesignation and cannot be null");
            }
            else
            {
                this.DisabilityDesignationDescriptor = DisabilityDesignationDescriptor;
            }
        }
        
        /// <summary>
        /// Whether the disability is IDEA, Section 504, or other disability designation.
        /// </summary>
        /// <value>Whether the disability is IDEA, Section 504, or other disability designation.</value>
        [DataMember(Name="disabilityDesignationDescriptor", EmitDefaultValue=false)]
        public string DisabilityDesignationDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentEducationOrganizationAssociationDisabilityDesignation {\n");
            sb.Append("  DisabilityDesignationDescriptor: ").Append(DisabilityDesignationDescriptor).Append("\n");
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
            return this.Equals(input as EdFiStudentEducationOrganizationAssociationDisabilityDesignation);
        }

        /// <summary>
        /// Returns true if EdFiStudentEducationOrganizationAssociationDisabilityDesignation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentEducationOrganizationAssociationDisabilityDesignation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentEducationOrganizationAssociationDisabilityDesignation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisabilityDesignationDescriptor == input.DisabilityDesignationDescriptor ||
                    (this.DisabilityDesignationDescriptor != null &&
                    this.DisabilityDesignationDescriptor.Equals(input.DisabilityDesignationDescriptor))
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
                if (this.DisabilityDesignationDescriptor != null)
                    hashCode = hashCode * 59 + this.DisabilityDesignationDescriptor.GetHashCode();
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
            // DisabilityDesignationDescriptor (string) maxLength
            if(this.DisabilityDesignationDescriptor != null && this.DisabilityDesignationDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisabilityDesignationDescriptor, length must be less than 306.", new [] { "DisabilityDesignationDescriptor" });
            }

            yield break;
        }
    }

}
