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

namespace EdFi.OdsApi.Sdk.Models.Identity
{
    /// <summary>
    /// EdFiStudentCTEProgramAssociationCTEProgram
    /// </summary>
    [DataContract]
    public partial class EdFiStudentCTEProgramAssociationCTEProgram :  IEquatable<EdFiStudentCTEProgramAssociationCTEProgram>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentCTEProgramAssociationCTEProgram" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentCTEProgramAssociationCTEProgram() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentCTEProgramAssociationCTEProgram" /> class.
        /// </summary>
        /// <param name="careerPathwayDescriptor">A sequence of courses within an area of interest that is a student&#39;s educational road map to a chosen career. (required).</param>
        /// <param name="cipCode">Number and description of the CIP Code associated with the student&#39;s CTEProgram..</param>
        /// <param name="cteProgramCompletionIndicator">A boolean indicator of whether the Student has completed the CTEProgram..</param>
        /// <param name="primaryCTEProgramIndicator">A boolean indicator of whether this CTEProgram, is the student&#39;s primary CTEProgram..</param>
        public EdFiStudentCTEProgramAssociationCTEProgram(string careerPathwayDescriptor = default(string), string cipCode = default(string), bool? cteProgramCompletionIndicator = default(bool?), bool? primaryCTEProgramIndicator = default(bool?))
        {
            // to ensure "careerPathwayDescriptor" is required (not null)
            if (careerPathwayDescriptor == null)
            {
                throw new InvalidDataException("careerPathwayDescriptor is a required property for EdFiStudentCTEProgramAssociationCTEProgram and cannot be null");
            }
            else
            {
                this.CareerPathwayDescriptor = careerPathwayDescriptor;
            }
            this.CipCode = cipCode;
            this.CteProgramCompletionIndicator = cteProgramCompletionIndicator;
            this.PrimaryCTEProgramIndicator = primaryCTEProgramIndicator;
        }
        
        /// <summary>
        /// A sequence of courses within an area of interest that is a student&#39;s educational road map to a chosen career.
        /// </summary>
        /// <value>A sequence of courses within an area of interest that is a student&#39;s educational road map to a chosen career.</value>
        [DataMember(Name="careerPathwayDescriptor", EmitDefaultValue=false)]
        public string CareerPathwayDescriptor { get; set; }

        /// <summary>
        /// Number and description of the CIP Code associated with the student&#39;s CTEProgram.
        /// </summary>
        /// <value>Number and description of the CIP Code associated with the student&#39;s CTEProgram.</value>
        [DataMember(Name="cipCode", EmitDefaultValue=false)]
        public string CipCode { get; set; }

        /// <summary>
        /// A boolean indicator of whether the Student has completed the CTEProgram.
        /// </summary>
        /// <value>A boolean indicator of whether the Student has completed the CTEProgram.</value>
        [DataMember(Name="cteProgramCompletionIndicator", EmitDefaultValue=false)]
        public bool? CteProgramCompletionIndicator { get; set; }

        /// <summary>
        /// A boolean indicator of whether this CTEProgram, is the student&#39;s primary CTEProgram.
        /// </summary>
        /// <value>A boolean indicator of whether this CTEProgram, is the student&#39;s primary CTEProgram.</value>
        [DataMember(Name="primaryCTEProgramIndicator", EmitDefaultValue=false)]
        public bool? PrimaryCTEProgramIndicator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentCTEProgramAssociationCTEProgram {\n");
            sb.Append("  CareerPathwayDescriptor: ").Append(CareerPathwayDescriptor).Append("\n");
            sb.Append("  CipCode: ").Append(CipCode).Append("\n");
            sb.Append("  CteProgramCompletionIndicator: ").Append(CteProgramCompletionIndicator).Append("\n");
            sb.Append("  PrimaryCTEProgramIndicator: ").Append(PrimaryCTEProgramIndicator).Append("\n");
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
            return this.Equals(input as EdFiStudentCTEProgramAssociationCTEProgram);
        }

        /// <summary>
        /// Returns true if EdFiStudentCTEProgramAssociationCTEProgram instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentCTEProgramAssociationCTEProgram to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentCTEProgramAssociationCTEProgram input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CareerPathwayDescriptor == input.CareerPathwayDescriptor ||
                    (this.CareerPathwayDescriptor != null &&
                    this.CareerPathwayDescriptor.Equals(input.CareerPathwayDescriptor))
                ) && 
                (
                    this.CipCode == input.CipCode ||
                    (this.CipCode != null &&
                    this.CipCode.Equals(input.CipCode))
                ) && 
                (
                    this.CteProgramCompletionIndicator == input.CteProgramCompletionIndicator ||
                    (this.CteProgramCompletionIndicator != null &&
                    this.CteProgramCompletionIndicator.Equals(input.CteProgramCompletionIndicator))
                ) && 
                (
                    this.PrimaryCTEProgramIndicator == input.PrimaryCTEProgramIndicator ||
                    (this.PrimaryCTEProgramIndicator != null &&
                    this.PrimaryCTEProgramIndicator.Equals(input.PrimaryCTEProgramIndicator))
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
                if (this.CareerPathwayDescriptor != null)
                    hashCode = hashCode * 59 + this.CareerPathwayDescriptor.GetHashCode();
                if (this.CipCode != null)
                    hashCode = hashCode * 59 + this.CipCode.GetHashCode();
                if (this.CteProgramCompletionIndicator != null)
                    hashCode = hashCode * 59 + this.CteProgramCompletionIndicator.GetHashCode();
                if (this.PrimaryCTEProgramIndicator != null)
                    hashCode = hashCode * 59 + this.PrimaryCTEProgramIndicator.GetHashCode();
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
            // CareerPathwayDescriptor (string) maxLength
            if(this.CareerPathwayDescriptor != null && this.CareerPathwayDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CareerPathwayDescriptor, length must be less than 306.", new [] { "CareerPathwayDescriptor" });
            }

            // CipCode (string) maxLength
            if(this.CipCode != null && this.CipCode.Length > 120)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CipCode, length must be less than 120.", new [] { "CipCode" });
            }

            yield break;
        }
    }

}
