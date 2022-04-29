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
    /// EdFiProgramCharacteristic
    /// </summary>
    [DataContract]
    public partial class EdFiProgramCharacteristic :  IEquatable<EdFiProgramCharacteristic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiProgramCharacteristic" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiProgramCharacteristic() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiProgramCharacteristic" /> class.
        /// </summary>
        /// <param name="programCharacteristicDescriptor">Reflects important characteristics of the Program, such as categories or particular indications. (required).</param>
        public EdFiProgramCharacteristic(string programCharacteristicDescriptor = default(string))
        {
            // to ensure "programCharacteristicDescriptor" is required (not null)
            if (programCharacteristicDescriptor == null)
            {
                throw new InvalidDataException("programCharacteristicDescriptor is a required property for EdFiProgramCharacteristic and cannot be null");
            }
            else
            {
                this.ProgramCharacteristicDescriptor = programCharacteristicDescriptor;
            }
        }
        
        /// <summary>
        /// Reflects important characteristics of the Program, such as categories or particular indications.
        /// </summary>
        /// <value>Reflects important characteristics of the Program, such as categories or particular indications.</value>
        [DataMember(Name="programCharacteristicDescriptor", EmitDefaultValue=false)]
        public string ProgramCharacteristicDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiProgramCharacteristic {\n");
            sb.Append("  ProgramCharacteristicDescriptor: ").Append(ProgramCharacteristicDescriptor).Append("\n");
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
            return this.Equals(input as EdFiProgramCharacteristic);
        }

        /// <summary>
        /// Returns true if EdFiProgramCharacteristic instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiProgramCharacteristic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiProgramCharacteristic input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProgramCharacteristicDescriptor == input.ProgramCharacteristicDescriptor ||
                    (this.ProgramCharacteristicDescriptor != null &&
                    this.ProgramCharacteristicDescriptor.Equals(input.ProgramCharacteristicDescriptor))
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
                if (this.ProgramCharacteristicDescriptor != null)
                    hashCode = hashCode * 59 + this.ProgramCharacteristicDescriptor.GetHashCode();
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
            // ProgramCharacteristicDescriptor (string) maxLength
            if(this.ProgramCharacteristicDescriptor != null && this.ProgramCharacteristicDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramCharacteristicDescriptor, length must be less than 306.", new [] { "ProgramCharacteristicDescriptor" });
            }

            yield break;
        }
    }

}
