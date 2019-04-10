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
    /// EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramService
    /// </summary>
    [DataContract]
    public partial class EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramService :  IEquatable<EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramService" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramService() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramService" /> class.
        /// </summary>
        /// <param name="LanguageInstructionProgramServiceDescriptor">Indicates the service being provided to the student by the Language Instruction Program. (required).</param>
        /// <param name="PrimaryIndicator">True if service is a primary service..</param>
        /// <param name="ServiceBeginDate">First date the Student was in this option for the current school year..</param>
        /// <param name="ServiceEndDate">Last date the Student was in this option for the current school year..</param>
        public EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramService(string LanguageInstructionProgramServiceDescriptor = default(string), bool? PrimaryIndicator = default(bool?), DateTime? ServiceBeginDate = default(DateTime?), DateTime? ServiceEndDate = default(DateTime?))
        {
            // to ensure "LanguageInstructionProgramServiceDescriptor" is required (not null)
            if (LanguageInstructionProgramServiceDescriptor == null)
            {
                throw new InvalidDataException("LanguageInstructionProgramServiceDescriptor is a required property for EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramService and cannot be null");
            }
            else
            {
                this.LanguageInstructionProgramServiceDescriptor = LanguageInstructionProgramServiceDescriptor;
            }
            this.PrimaryIndicator = PrimaryIndicator;
            this.ServiceBeginDate = ServiceBeginDate;
            this.ServiceEndDate = ServiceEndDate;
        }
        
        /// <summary>
        /// Indicates the service being provided to the student by the Language Instruction Program.
        /// </summary>
        /// <value>Indicates the service being provided to the student by the Language Instruction Program.</value>
        [DataMember(Name="languageInstructionProgramServiceDescriptor", EmitDefaultValue=false)]
        public string LanguageInstructionProgramServiceDescriptor { get; set; }

        /// <summary>
        /// True if service is a primary service.
        /// </summary>
        /// <value>True if service is a primary service.</value>
        [DataMember(Name="primaryIndicator", EmitDefaultValue=false)]
        public bool? PrimaryIndicator { get; set; }

        /// <summary>
        /// First date the Student was in this option for the current school year.
        /// </summary>
        /// <value>First date the Student was in this option for the current school year.</value>
        [DataMember(Name="serviceBeginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ServiceBeginDate { get; set; }

        /// <summary>
        /// Last date the Student was in this option for the current school year.
        /// </summary>
        /// <value>Last date the Student was in this option for the current school year.</value>
        [DataMember(Name="serviceEndDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ServiceEndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramService {\n");
            sb.Append("  LanguageInstructionProgramServiceDescriptor: ").Append(LanguageInstructionProgramServiceDescriptor).Append("\n");
            sb.Append("  PrimaryIndicator: ").Append(PrimaryIndicator).Append("\n");
            sb.Append("  ServiceBeginDate: ").Append(ServiceBeginDate).Append("\n");
            sb.Append("  ServiceEndDate: ").Append(ServiceEndDate).Append("\n");
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
            return this.Equals(input as EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramService);
        }

        /// <summary>
        /// Returns true if EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramService instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramService input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LanguageInstructionProgramServiceDescriptor == input.LanguageInstructionProgramServiceDescriptor ||
                    (this.LanguageInstructionProgramServiceDescriptor != null &&
                    this.LanguageInstructionProgramServiceDescriptor.Equals(input.LanguageInstructionProgramServiceDescriptor))
                ) && 
                (
                    this.PrimaryIndicator == input.PrimaryIndicator ||
                    (this.PrimaryIndicator != null &&
                    this.PrimaryIndicator.Equals(input.PrimaryIndicator))
                ) && 
                (
                    this.ServiceBeginDate == input.ServiceBeginDate ||
                    (this.ServiceBeginDate != null &&
                    this.ServiceBeginDate.Equals(input.ServiceBeginDate))
                ) && 
                (
                    this.ServiceEndDate == input.ServiceEndDate ||
                    (this.ServiceEndDate != null &&
                    this.ServiceEndDate.Equals(input.ServiceEndDate))
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
                if (this.PrimaryIndicator != null)
                    hashCode = hashCode * 59 + this.PrimaryIndicator.GetHashCode();
                if (this.ServiceBeginDate != null)
                    hashCode = hashCode * 59 + this.ServiceBeginDate.GetHashCode();
                if (this.ServiceEndDate != null)
                    hashCode = hashCode * 59 + this.ServiceEndDate.GetHashCode();
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