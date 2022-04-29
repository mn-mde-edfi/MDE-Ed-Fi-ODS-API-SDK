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
    /// EdFiEducationOrganizationIndicator
    /// </summary>
    [DataContract]
    public partial class EdFiEducationOrganizationIndicator :  IEquatable<EdFiEducationOrganizationIndicator>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationOrganizationIndicator" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiEducationOrganizationIndicator() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationOrganizationIndicator" /> class.
        /// </summary>
        /// <param name="indicatorDescriptor">The name or code for the indicator or metric. (required).</param>
        /// <param name="indicatorGroupDescriptor">The name for a group of indicators..</param>
        /// <param name="indicatorLevelDescriptor">The value of the indicator or metric, as a value from a controlled vocabulary. The semantics of an empty value is \&quot;not submitted.\&quot;.</param>
        /// <param name="designatedBy">The person, organization, or department that defined the metric..</param>
        /// <param name="indicatorValue">The value of the indicator or metric. The semantics of an empty value is \&quot;not submitted.\&quot;.</param>
        /// <param name="periods">An unordered collection of educationOrganizationIndicatorPeriods. The time period or as-of date for the indicator..</param>
        public EdFiEducationOrganizationIndicator(string indicatorDescriptor = default(string), string indicatorGroupDescriptor = default(string), string indicatorLevelDescriptor = default(string), string designatedBy = default(string), string indicatorValue = default(string), List<EdFiEducationOrganizationIndicatorPeriod> periods = default(List<EdFiEducationOrganizationIndicatorPeriod>))
        {
            // to ensure "indicatorDescriptor" is required (not null)
            if (indicatorDescriptor == null)
            {
                throw new InvalidDataException("indicatorDescriptor is a required property for EdFiEducationOrganizationIndicator and cannot be null");
            }
            else
            {
                this.IndicatorDescriptor = indicatorDescriptor;
            }
            this.IndicatorGroupDescriptor = indicatorGroupDescriptor;
            this.IndicatorLevelDescriptor = indicatorLevelDescriptor;
            this.DesignatedBy = designatedBy;
            this.IndicatorValue = indicatorValue;
            this.Periods = periods;
        }
        
        /// <summary>
        /// The name or code for the indicator or metric.
        /// </summary>
        /// <value>The name or code for the indicator or metric.</value>
        [DataMember(Name="indicatorDescriptor", EmitDefaultValue=false)]
        public string IndicatorDescriptor { get; set; }

        /// <summary>
        /// The name for a group of indicators.
        /// </summary>
        /// <value>The name for a group of indicators.</value>
        [DataMember(Name="indicatorGroupDescriptor", EmitDefaultValue=false)]
        public string IndicatorGroupDescriptor { get; set; }

        /// <summary>
        /// The value of the indicator or metric, as a value from a controlled vocabulary. The semantics of an empty value is \&quot;not submitted.\&quot;
        /// </summary>
        /// <value>The value of the indicator or metric, as a value from a controlled vocabulary. The semantics of an empty value is \&quot;not submitted.\&quot;</value>
        [DataMember(Name="indicatorLevelDescriptor", EmitDefaultValue=false)]
        public string IndicatorLevelDescriptor { get; set; }

        /// <summary>
        /// The person, organization, or department that defined the metric.
        /// </summary>
        /// <value>The person, organization, or department that defined the metric.</value>
        [DataMember(Name="designatedBy", EmitDefaultValue=false)]
        public string DesignatedBy { get; set; }

        /// <summary>
        /// The value of the indicator or metric. The semantics of an empty value is \&quot;not submitted.\&quot;
        /// </summary>
        /// <value>The value of the indicator or metric. The semantics of an empty value is \&quot;not submitted.\&quot;</value>
        [DataMember(Name="indicatorValue", EmitDefaultValue=false)]
        public string IndicatorValue { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationIndicatorPeriods. The time period or as-of date for the indicator.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationIndicatorPeriods. The time period or as-of date for the indicator.</value>
        [DataMember(Name="periods", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationIndicatorPeriod> Periods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiEducationOrganizationIndicator {\n");
            sb.Append("  IndicatorDescriptor: ").Append(IndicatorDescriptor).Append("\n");
            sb.Append("  IndicatorGroupDescriptor: ").Append(IndicatorGroupDescriptor).Append("\n");
            sb.Append("  IndicatorLevelDescriptor: ").Append(IndicatorLevelDescriptor).Append("\n");
            sb.Append("  DesignatedBy: ").Append(DesignatedBy).Append("\n");
            sb.Append("  IndicatorValue: ").Append(IndicatorValue).Append("\n");
            sb.Append("  Periods: ").Append(Periods).Append("\n");
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
            return this.Equals(input as EdFiEducationOrganizationIndicator);
        }

        /// <summary>
        /// Returns true if EdFiEducationOrganizationIndicator instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiEducationOrganizationIndicator to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiEducationOrganizationIndicator input)
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
                    this.IndicatorGroupDescriptor == input.IndicatorGroupDescriptor ||
                    (this.IndicatorGroupDescriptor != null &&
                    this.IndicatorGroupDescriptor.Equals(input.IndicatorGroupDescriptor))
                ) && 
                (
                    this.IndicatorLevelDescriptor == input.IndicatorLevelDescriptor ||
                    (this.IndicatorLevelDescriptor != null &&
                    this.IndicatorLevelDescriptor.Equals(input.IndicatorLevelDescriptor))
                ) && 
                (
                    this.DesignatedBy == input.DesignatedBy ||
                    (this.DesignatedBy != null &&
                    this.DesignatedBy.Equals(input.DesignatedBy))
                ) && 
                (
                    this.IndicatorValue == input.IndicatorValue ||
                    (this.IndicatorValue != null &&
                    this.IndicatorValue.Equals(input.IndicatorValue))
                ) && 
                (
                    this.Periods == input.Periods ||
                    this.Periods != null &&
                    this.Periods.SequenceEqual(input.Periods)
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
                if (this.IndicatorGroupDescriptor != null)
                    hashCode = hashCode * 59 + this.IndicatorGroupDescriptor.GetHashCode();
                if (this.IndicatorLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.IndicatorLevelDescriptor.GetHashCode();
                if (this.DesignatedBy != null)
                    hashCode = hashCode * 59 + this.DesignatedBy.GetHashCode();
                if (this.IndicatorValue != null)
                    hashCode = hashCode * 59 + this.IndicatorValue.GetHashCode();
                if (this.Periods != null)
                    hashCode = hashCode * 59 + this.Periods.GetHashCode();
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

            // IndicatorGroupDescriptor (string) maxLength
            if(this.IndicatorGroupDescriptor != null && this.IndicatorGroupDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IndicatorGroupDescriptor, length must be less than 306.", new [] { "IndicatorGroupDescriptor" });
            }

            // IndicatorLevelDescriptor (string) maxLength
            if(this.IndicatorLevelDescriptor != null && this.IndicatorLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IndicatorLevelDescriptor, length must be less than 306.", new [] { "IndicatorLevelDescriptor" });
            }

            // DesignatedBy (string) maxLength
            if(this.DesignatedBy != null && this.DesignatedBy.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DesignatedBy, length must be less than 60.", new [] { "DesignatedBy" });
            }

            // IndicatorValue (string) maxLength
            if(this.IndicatorValue != null && this.IndicatorValue.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IndicatorValue, length must be less than 60.", new [] { "IndicatorValue" });
            }

            yield break;
        }
    }

}
