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
    /// MnSchoolAttributeEducationOrganizationIndicatorWritable
    /// </summary>
    [DataContract]
    public partial class MnSchoolAttributeEducationOrganizationIndicatorWritable :  IEquatable<MnSchoolAttributeEducationOrganizationIndicatorWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnSchoolAttributeEducationOrganizationIndicatorWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnSchoolAttributeEducationOrganizationIndicatorWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnSchoolAttributeEducationOrganizationIndicatorWritable" /> class.
        /// </summary>
        /// <param name="indicatorDescriptor">The name or code for the indicator or metric. (required).</param>
        /// <param name="indicatorLevelDescriptor">The value of the indicator or metric, as a value from a controlled vocabulary. The semantics of an empty value is \&quot;not submitted.\&quot;.</param>
        public MnSchoolAttributeEducationOrganizationIndicatorWritable(string indicatorDescriptor = default(string), string indicatorLevelDescriptor = default(string))
        {
            // to ensure "indicatorDescriptor" is required (not null)
            if (indicatorDescriptor == null)
            {
                throw new InvalidDataException("indicatorDescriptor is a required property for MnSchoolAttributeEducationOrganizationIndicatorWritable and cannot be null");
            }
            else
            {
                this.IndicatorDescriptor = indicatorDescriptor;
            }
            this.IndicatorLevelDescriptor = indicatorLevelDescriptor;
        }
        
        /// <summary>
        /// The name or code for the indicator or metric.
        /// </summary>
        /// <value>The name or code for the indicator or metric.</value>
        [DataMember(Name="indicatorDescriptor", EmitDefaultValue=false)]
        public string IndicatorDescriptor { get; set; }

        /// <summary>
        /// The value of the indicator or metric, as a value from a controlled vocabulary. The semantics of an empty value is \&quot;not submitted.\&quot;
        /// </summary>
        /// <value>The value of the indicator or metric, as a value from a controlled vocabulary. The semantics of an empty value is \&quot;not submitted.\&quot;</value>
        [DataMember(Name="indicatorLevelDescriptor", EmitDefaultValue=false)]
        public string IndicatorLevelDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnSchoolAttributeEducationOrganizationIndicatorWritable {\n");
            sb.Append("  IndicatorDescriptor: ").Append(IndicatorDescriptor).Append("\n");
            sb.Append("  IndicatorLevelDescriptor: ").Append(IndicatorLevelDescriptor).Append("\n");
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
            return this.Equals(input as MnSchoolAttributeEducationOrganizationIndicatorWritable);
        }

        /// <summary>
        /// Returns true if MnSchoolAttributeEducationOrganizationIndicatorWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnSchoolAttributeEducationOrganizationIndicatorWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnSchoolAttributeEducationOrganizationIndicatorWritable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IndicatorDescriptor == input.IndicatorDescriptor ||
                    (this.IndicatorDescriptor != null &&
                    this.IndicatorDescriptor.Equals(input.IndicatorDescriptor))
                ) && 
                (
                    this.IndicatorLevelDescriptor == input.IndicatorLevelDescriptor ||
                    (this.IndicatorLevelDescriptor != null &&
                    this.IndicatorLevelDescriptor.Equals(input.IndicatorLevelDescriptor))
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
                if (this.IndicatorDescriptor != null)
                    hashCode = hashCode * 59 + this.IndicatorDescriptor.GetHashCode();
                if (this.IndicatorLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.IndicatorLevelDescriptor.GetHashCode();
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
            // IndicatorDescriptor (string) maxLength
            if(this.IndicatorDescriptor != null && this.IndicatorDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IndicatorDescriptor, length must be less than 306.", new [] { "IndicatorDescriptor" });
            }

            // IndicatorLevelDescriptor (string) maxLength
            if(this.IndicatorLevelDescriptor != null && this.IndicatorLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IndicatorLevelDescriptor, length must be less than 306.", new [] { "IndicatorLevelDescriptor" });
            }

            yield break;
        }
    }

}
