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
    /// MnStudentNeglectedOrDelinquentProgramAssociationExtensionReadable
    /// </summary>
    [DataContract]
    public partial class MnStudentNeglectedOrDelinquentProgramAssociationExtensionReadable :  IEquatable<MnStudentNeglectedOrDelinquentProgramAssociationExtensionReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentNeglectedOrDelinquentProgramAssociationExtensionReadable" /> class.
        /// </summary>
        /// <param name="neglectedOrDelinquentProgramOutcomeDescriptor">Neglected or delinquent program outcome..</param>
        /// <param name="exitedNeglectedOrDelinquentProgramOutcomeDescriptor">Neglected or delinquent exited-program outcome..</param>
        public MnStudentNeglectedOrDelinquentProgramAssociationExtensionReadable(string neglectedOrDelinquentProgramOutcomeDescriptor = default(string), string exitedNeglectedOrDelinquentProgramOutcomeDescriptor = default(string))
        {
            this.NeglectedOrDelinquentProgramOutcomeDescriptor = neglectedOrDelinquentProgramOutcomeDescriptor;
            this.ExitedNeglectedOrDelinquentProgramOutcomeDescriptor = exitedNeglectedOrDelinquentProgramOutcomeDescriptor;
        }
        
        /// <summary>
        /// Neglected or delinquent program outcome.
        /// </summary>
        /// <value>Neglected or delinquent program outcome.</value>
        [DataMember(Name="neglectedOrDelinquentProgramOutcomeDescriptor", EmitDefaultValue=false)]
        public string NeglectedOrDelinquentProgramOutcomeDescriptor { get; set; }

        /// <summary>
        /// Neglected or delinquent exited-program outcome.
        /// </summary>
        /// <value>Neglected or delinquent exited-program outcome.</value>
        [DataMember(Name="exitedNeglectedOrDelinquentProgramOutcomeDescriptor", EmitDefaultValue=false)]
        public string ExitedNeglectedOrDelinquentProgramOutcomeDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnStudentNeglectedOrDelinquentProgramAssociationExtensionReadable {\n");
            sb.Append("  NeglectedOrDelinquentProgramOutcomeDescriptor: ").Append(NeglectedOrDelinquentProgramOutcomeDescriptor).Append("\n");
            sb.Append("  ExitedNeglectedOrDelinquentProgramOutcomeDescriptor: ").Append(ExitedNeglectedOrDelinquentProgramOutcomeDescriptor).Append("\n");
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
            return this.Equals(input as MnStudentNeglectedOrDelinquentProgramAssociationExtensionReadable);
        }

        /// <summary>
        /// Returns true if MnStudentNeglectedOrDelinquentProgramAssociationExtensionReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentNeglectedOrDelinquentProgramAssociationExtensionReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentNeglectedOrDelinquentProgramAssociationExtensionReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NeglectedOrDelinquentProgramOutcomeDescriptor == input.NeglectedOrDelinquentProgramOutcomeDescriptor ||
                    (this.NeglectedOrDelinquentProgramOutcomeDescriptor != null &&
                    this.NeglectedOrDelinquentProgramOutcomeDescriptor.Equals(input.NeglectedOrDelinquentProgramOutcomeDescriptor))
                ) && 
                (
                    this.ExitedNeglectedOrDelinquentProgramOutcomeDescriptor == input.ExitedNeglectedOrDelinquentProgramOutcomeDescriptor ||
                    (this.ExitedNeglectedOrDelinquentProgramOutcomeDescriptor != null &&
                    this.ExitedNeglectedOrDelinquentProgramOutcomeDescriptor.Equals(input.ExitedNeglectedOrDelinquentProgramOutcomeDescriptor))
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
                if (this.NeglectedOrDelinquentProgramOutcomeDescriptor != null)
                    hashCode = hashCode * 59 + this.NeglectedOrDelinquentProgramOutcomeDescriptor.GetHashCode();
                if (this.ExitedNeglectedOrDelinquentProgramOutcomeDescriptor != null)
                    hashCode = hashCode * 59 + this.ExitedNeglectedOrDelinquentProgramOutcomeDescriptor.GetHashCode();
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
            // NeglectedOrDelinquentProgramOutcomeDescriptor (string) maxLength
            if(this.NeglectedOrDelinquentProgramOutcomeDescriptor != null && this.NeglectedOrDelinquentProgramOutcomeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NeglectedOrDelinquentProgramOutcomeDescriptor, length must be less than 306.", new [] { "NeglectedOrDelinquentProgramOutcomeDescriptor" });
            }

            // ExitedNeglectedOrDelinquentProgramOutcomeDescriptor (string) maxLength
            if(this.ExitedNeglectedOrDelinquentProgramOutcomeDescriptor != null && this.ExitedNeglectedOrDelinquentProgramOutcomeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExitedNeglectedOrDelinquentProgramOutcomeDescriptor, length must be less than 306.", new [] { "ExitedNeglectedOrDelinquentProgramOutcomeDescriptor" });
            }

            yield break;
        }
    }

}
