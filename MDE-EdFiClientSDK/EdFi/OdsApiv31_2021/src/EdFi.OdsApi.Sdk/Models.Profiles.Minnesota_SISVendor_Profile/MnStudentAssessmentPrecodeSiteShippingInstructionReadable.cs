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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile
{
    /// <summary>
    /// MnStudentAssessmentPrecodeSiteShippingInstructionReadable
    /// </summary>
    [DataContract]
    public partial class MnStudentAssessmentPrecodeSiteShippingInstructionReadable :  IEquatable<MnStudentAssessmentPrecodeSiteShippingInstructionReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentAssessmentPrecodeSiteShippingInstructionReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentAssessmentPrecodeSiteShippingInstructionReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentAssessmentPrecodeSiteShippingInstructionReadable" /> class.
        /// </summary>
        /// <param name="ShippingInstructionDescriptor">Shipping instructions such as Labels, Shipping Date, Shipping Preference (required).</param>
        public MnStudentAssessmentPrecodeSiteShippingInstructionReadable(string ShippingInstructionDescriptor = default(string))
        {
            // to ensure "ShippingInstructionDescriptor" is required (not null)
            if (ShippingInstructionDescriptor == null)
            {
                throw new InvalidDataException("ShippingInstructionDescriptor is a required property for MnStudentAssessmentPrecodeSiteShippingInstructionReadable and cannot be null");
            }
            else
            {
                this.ShippingInstructionDescriptor = ShippingInstructionDescriptor;
            }
        }
        
        /// <summary>
        /// Shipping instructions such as Labels, Shipping Date, Shipping Preference
        /// </summary>
        /// <value>Shipping instructions such as Labels, Shipping Date, Shipping Preference</value>
        [DataMember(Name="shippingInstructionDescriptor", EmitDefaultValue=false)]
        public string ShippingInstructionDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnStudentAssessmentPrecodeSiteShippingInstructionReadable {\n");
            sb.Append("  ShippingInstructionDescriptor: ").Append(ShippingInstructionDescriptor).Append("\n");
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
            return this.Equals(input as MnStudentAssessmentPrecodeSiteShippingInstructionReadable);
        }

        /// <summary>
        /// Returns true if MnStudentAssessmentPrecodeSiteShippingInstructionReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentAssessmentPrecodeSiteShippingInstructionReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentAssessmentPrecodeSiteShippingInstructionReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShippingInstructionDescriptor == input.ShippingInstructionDescriptor ||
                    (this.ShippingInstructionDescriptor != null &&
                    this.ShippingInstructionDescriptor.Equals(input.ShippingInstructionDescriptor))
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
                if (this.ShippingInstructionDescriptor != null)
                    hashCode = hashCode * 59 + this.ShippingInstructionDescriptor.GetHashCode();
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
            // ShippingInstructionDescriptor (string) maxLength
            if(this.ShippingInstructionDescriptor != null && this.ShippingInstructionDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShippingInstructionDescriptor, length must be less than 306.", new [] { "ShippingInstructionDescriptor" });
            }

            yield break;
        }
    }

}