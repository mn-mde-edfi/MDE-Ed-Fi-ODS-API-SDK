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
    /// EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable
    /// </summary>
    [DataContract(Name = "edFi_studentLanguageInstructionProgramAssociationLanguageInstructionProgramService_readable")]
    public partial class EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable : IEquatable<EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable" /> class.
        /// </summary>
        /// <param name="languageInstructionProgramServiceDescriptor">Indicates the service being provided to the student by the Language Instruction Program. (required).</param>
        public EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable(string languageInstructionProgramServiceDescriptor = default(string))
        {
            // to ensure "languageInstructionProgramServiceDescriptor" is required (not null)
            if (languageInstructionProgramServiceDescriptor == null)
            {
                throw new ArgumentNullException("languageInstructionProgramServiceDescriptor is a required property for EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable and cannot be null");
            }
            this.LanguageInstructionProgramServiceDescriptor = languageInstructionProgramServiceDescriptor;
        }

        /// <summary>
        /// Indicates the service being provided to the student by the Language Instruction Program.
        /// </summary>
        /// <value>Indicates the service being provided to the student by the Language Instruction Program.</value>
        [DataMember(Name = "languageInstructionProgramServiceDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string LanguageInstructionProgramServiceDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable {\n");
            sb.Append("  LanguageInstructionProgramServiceDescriptor: ").Append(LanguageInstructionProgramServiceDescriptor).Append("\n");
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
            return this.Equals(input as EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable);
        }

        /// <summary>
        /// Returns true if EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LanguageInstructionProgramServiceDescriptor == input.LanguageInstructionProgramServiceDescriptor ||
                    (this.LanguageInstructionProgramServiceDescriptor != null &&
                    this.LanguageInstructionProgramServiceDescriptor.Equals(input.LanguageInstructionProgramServiceDescriptor))
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
                if (this.LanguageInstructionProgramServiceDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.LanguageInstructionProgramServiceDescriptor.GetHashCode();
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
            // LanguageInstructionProgramServiceDescriptor (string) maxLength
            if (this.LanguageInstructionProgramServiceDescriptor != null && this.LanguageInstructionProgramServiceDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LanguageInstructionProgramServiceDescriptor, length must be less than 306.", new [] { "LanguageInstructionProgramServiceDescriptor" });
            }

            yield break;
        }
    }

}
