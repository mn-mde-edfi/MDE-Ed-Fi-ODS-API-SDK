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
    /// EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceWritable
    /// </summary>
    [DataContract]
    public partial class EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceWritable :  IEquatable<EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceWritable" /> class.
        /// </summary>
        /// <param name="LanguageInstructionProgramServiceDescriptor">Indicates the service being provided to the student by the Language Instruction Program. (required).</param>
        public EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceWritable(string LanguageInstructionProgramServiceDescriptor = default(string))
        {
            // to ensure "LanguageInstructionProgramServiceDescriptor" is required (not null)
            if (LanguageInstructionProgramServiceDescriptor == null)
            {
                throw new InvalidDataException("LanguageInstructionProgramServiceDescriptor is a required property for EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceWritable and cannot be null");
            }
            else
            {
                this.LanguageInstructionProgramServiceDescriptor = LanguageInstructionProgramServiceDescriptor;
            }
        }
        
        /// <summary>
        /// Indicates the service being provided to the student by the Language Instruction Program.
        /// </summary>
        /// <value>Indicates the service being provided to the student by the Language Instruction Program.</value>
        [DataMember(Name="languageInstructionProgramServiceDescriptor", EmitDefaultValue=false)]
        public string LanguageInstructionProgramServiceDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceWritable {\n");
            sb.Append("  LanguageInstructionProgramServiceDescriptor: ").Append(LanguageInstructionProgramServiceDescriptor).Append("\n");
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
            return this.Equals(input as EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceWritable);
        }

        /// <summary>
        /// Returns true if EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceWritable input)
        {
            if (input == null)
                return false;

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
                    hashCode = hashCode * 59 + this.LanguageInstructionProgramServiceDescriptor.GetHashCode();
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
            // LanguageInstructionProgramServiceDescriptor (string) maxLength
            if(this.LanguageInstructionProgramServiceDescriptor != null && this.LanguageInstructionProgramServiceDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LanguageInstructionProgramServiceDescriptor, length must be less than 306.", new [] { "LanguageInstructionProgramServiceDescriptor" });
            }

            yield break;
        }
    }

}
