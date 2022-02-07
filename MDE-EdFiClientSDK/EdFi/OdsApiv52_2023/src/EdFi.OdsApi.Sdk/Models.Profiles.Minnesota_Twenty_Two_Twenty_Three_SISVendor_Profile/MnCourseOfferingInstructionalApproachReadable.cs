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
    /// MnCourseOfferingInstructionalApproachReadable
    /// </summary>
    [DataContract]
    public partial class MnCourseOfferingInstructionalApproachReadable :  IEquatable<MnCourseOfferingInstructionalApproachReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCourseOfferingInstructionalApproachReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnCourseOfferingInstructionalApproachReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCourseOfferingInstructionalApproachReadable" /> class.
        /// </summary>
        /// <param name="instructionalApproachDescriptor">Instructional approach. (required).</param>
        /// <param name="implementationStatusDescriptor">Status of implementation of the instructional approach..</param>
        public MnCourseOfferingInstructionalApproachReadable(string instructionalApproachDescriptor = default(string), string implementationStatusDescriptor = default(string))
        {
            // to ensure "instructionalApproachDescriptor" is required (not null)
            if (instructionalApproachDescriptor == null)
            {
                throw new InvalidDataException("instructionalApproachDescriptor is a required property for MnCourseOfferingInstructionalApproachReadable and cannot be null");
            }
            else
            {
                this.InstructionalApproachDescriptor = instructionalApproachDescriptor;
            }
            this.ImplementationStatusDescriptor = implementationStatusDescriptor;
        }
        
        /// <summary>
        /// Instructional approach.
        /// </summary>
        /// <value>Instructional approach.</value>
        [DataMember(Name="instructionalApproachDescriptor", EmitDefaultValue=false)]
        public string InstructionalApproachDescriptor { get; set; }

        /// <summary>
        /// Status of implementation of the instructional approach.
        /// </summary>
        /// <value>Status of implementation of the instructional approach.</value>
        [DataMember(Name="implementationStatusDescriptor", EmitDefaultValue=false)]
        public string ImplementationStatusDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnCourseOfferingInstructionalApproachReadable {\n");
            sb.Append("  InstructionalApproachDescriptor: ").Append(InstructionalApproachDescriptor).Append("\n");
            sb.Append("  ImplementationStatusDescriptor: ").Append(ImplementationStatusDescriptor).Append("\n");
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
            return this.Equals(input as MnCourseOfferingInstructionalApproachReadable);
        }

        /// <summary>
        /// Returns true if MnCourseOfferingInstructionalApproachReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnCourseOfferingInstructionalApproachReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnCourseOfferingInstructionalApproachReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstructionalApproachDescriptor == input.InstructionalApproachDescriptor ||
                    (this.InstructionalApproachDescriptor != null &&
                    this.InstructionalApproachDescriptor.Equals(input.InstructionalApproachDescriptor))
                ) && 
                (
                    this.ImplementationStatusDescriptor == input.ImplementationStatusDescriptor ||
                    (this.ImplementationStatusDescriptor != null &&
                    this.ImplementationStatusDescriptor.Equals(input.ImplementationStatusDescriptor))
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
                if (this.InstructionalApproachDescriptor != null)
                    hashCode = hashCode * 59 + this.InstructionalApproachDescriptor.GetHashCode();
                if (this.ImplementationStatusDescriptor != null)
                    hashCode = hashCode * 59 + this.ImplementationStatusDescriptor.GetHashCode();
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
            // InstructionalApproachDescriptor (string) maxLength
            if(this.InstructionalApproachDescriptor != null && this.InstructionalApproachDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstructionalApproachDescriptor, length must be less than 306.", new [] { "InstructionalApproachDescriptor" });
            }

            // ImplementationStatusDescriptor (string) maxLength
            if(this.ImplementationStatusDescriptor != null && this.ImplementationStatusDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImplementationStatusDescriptor, length must be less than 306.", new [] { "ImplementationStatusDescriptor" });
            }

            yield break;
        }
    }

}
