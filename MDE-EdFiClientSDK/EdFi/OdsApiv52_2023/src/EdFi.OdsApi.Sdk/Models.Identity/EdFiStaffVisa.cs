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
    /// EdFiStaffVisa
    /// </summary>
    [DataContract]
    public partial class EdFiStaffVisa :  IEquatable<EdFiStaffVisa>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffVisa" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStaffVisa() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffVisa" /> class.
        /// </summary>
        /// <param name="visaDescriptor">An indicator of a non-US citizen&#39;s Visa type. (required).</param>
        public EdFiStaffVisa(string visaDescriptor = default(string))
        {
            // to ensure "visaDescriptor" is required (not null)
            if (visaDescriptor == null)
            {
                throw new InvalidDataException("visaDescriptor is a required property for EdFiStaffVisa and cannot be null");
            }
            else
            {
                this.VisaDescriptor = visaDescriptor;
            }
        }
        
        /// <summary>
        /// An indicator of a non-US citizen&#39;s Visa type.
        /// </summary>
        /// <value>An indicator of a non-US citizen&#39;s Visa type.</value>
        [DataMember(Name="visaDescriptor", EmitDefaultValue=false)]
        public string VisaDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStaffVisa {\n");
            sb.Append("  VisaDescriptor: ").Append(VisaDescriptor).Append("\n");
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
            return this.Equals(input as EdFiStaffVisa);
        }

        /// <summary>
        /// Returns true if EdFiStaffVisa instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStaffVisa to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStaffVisa input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VisaDescriptor == input.VisaDescriptor ||
                    (this.VisaDescriptor != null &&
                    this.VisaDescriptor.Equals(input.VisaDescriptor))
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
                if (this.VisaDescriptor != null)
                    hashCode = hashCode * 59 + this.VisaDescriptor.GetHashCode();
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
            // VisaDescriptor (string) maxLength
            if(this.VisaDescriptor != null && this.VisaDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisaDescriptor, length must be less than 306.", new [] { "VisaDescriptor" });
            }

            yield break;
        }
    }

}
