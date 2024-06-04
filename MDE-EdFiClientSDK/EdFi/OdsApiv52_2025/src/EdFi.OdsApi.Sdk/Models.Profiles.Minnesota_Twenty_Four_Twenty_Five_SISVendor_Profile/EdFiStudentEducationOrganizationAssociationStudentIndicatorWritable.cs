/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdFi.OdsApi.Sdk.Client.OpenAPIDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile
{
    /// <summary>
    /// EdFiStudentEducationOrganizationAssociationStudentIndicatorWritable
    /// </summary>
    [DataContract(Name = "edFi_studentEducationOrganizationAssociationStudentIndicator_writable")]
    public partial class EdFiStudentEducationOrganizationAssociationStudentIndicatorWritable : IEquatable<EdFiStudentEducationOrganizationAssociationStudentIndicatorWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationStudentIndicatorWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentEducationOrganizationAssociationStudentIndicatorWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationStudentIndicatorWritable" /> class.
        /// </summary>
        /// <param name="indicatorName">The name of the indicator or metric. (required).</param>
        /// <param name="indicator">The value of the indicator or metric. (required).</param>
        /// <param name="indicatorGroup">The name for a group of indicators..</param>
        public EdFiStudentEducationOrganizationAssociationStudentIndicatorWritable(string indicatorName = default(string), string indicator = default(string), string indicatorGroup = default(string))
        {
            // to ensure "indicatorName" is required (not null)
            if (indicatorName == null)
            {
                throw new ArgumentNullException("indicatorName is a required property for EdFiStudentEducationOrganizationAssociationStudentIndicatorWritable and cannot be null");
            }
            this.IndicatorName = indicatorName;
            // to ensure "indicator" is required (not null)
            if (indicator == null)
            {
                throw new ArgumentNullException("indicator is a required property for EdFiStudentEducationOrganizationAssociationStudentIndicatorWritable and cannot be null");
            }
            this.Indicator = indicator;
            this.IndicatorGroup = indicatorGroup;
        }

        /// <summary>
        /// The name of the indicator or metric.
        /// </summary>
        /// <value>The name of the indicator or metric.</value>
        [DataMember(Name = "indicatorName", IsRequired = true, EmitDefaultValue = false)]
        public string IndicatorName { get; set; }

        /// <summary>
        /// The value of the indicator or metric.
        /// </summary>
        /// <value>The value of the indicator or metric.</value>
        [DataMember(Name = "indicator", IsRequired = true, EmitDefaultValue = false)]
        public string Indicator { get; set; }

        /// <summary>
        /// The name for a group of indicators.
        /// </summary>
        /// <value>The name for a group of indicators.</value>
        [DataMember(Name = "indicatorGroup", EmitDefaultValue = false)]
        public string IndicatorGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentEducationOrganizationAssociationStudentIndicatorWritable {\n");
            sb.Append("  IndicatorName: ").Append(IndicatorName).Append("\n");
            sb.Append("  Indicator: ").Append(Indicator).Append("\n");
            sb.Append("  IndicatorGroup: ").Append(IndicatorGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiStudentEducationOrganizationAssociationStudentIndicatorWritable);
        }

        /// <summary>
        /// Returns true if EdFiStudentEducationOrganizationAssociationStudentIndicatorWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentEducationOrganizationAssociationStudentIndicatorWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentEducationOrganizationAssociationStudentIndicatorWritable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IndicatorName == input.IndicatorName ||
                    (this.IndicatorName != null &&
                    this.IndicatorName.Equals(input.IndicatorName))
                ) && 
                (
                    this.Indicator == input.Indicator ||
                    (this.Indicator != null &&
                    this.Indicator.Equals(input.Indicator))
                ) && 
                (
                    this.IndicatorGroup == input.IndicatorGroup ||
                    (this.IndicatorGroup != null &&
                    this.IndicatorGroup.Equals(input.IndicatorGroup))
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
                if (this.IndicatorName != null)
                {
                    hashCode = (hashCode * 59) + this.IndicatorName.GetHashCode();
                }
                if (this.Indicator != null)
                {
                    hashCode = (hashCode * 59) + this.Indicator.GetHashCode();
                }
                if (this.IndicatorGroup != null)
                {
                    hashCode = (hashCode * 59) + this.IndicatorGroup.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // IndicatorName (string) maxLength
            if (this.IndicatorName != null && this.IndicatorName.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IndicatorName, length must be less than 200.", new [] { "IndicatorName" });
            }

            // Indicator (string) maxLength
            if (this.Indicator != null && this.Indicator.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Indicator, length must be less than 60.", new [] { "Indicator" });
            }

            // IndicatorGroup (string) maxLength
            if (this.IndicatorGroup != null && this.IndicatorGroup.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IndicatorGroup, length must be less than 200.", new [] { "IndicatorGroup" });
            }

            yield break;
        }
    }

}
