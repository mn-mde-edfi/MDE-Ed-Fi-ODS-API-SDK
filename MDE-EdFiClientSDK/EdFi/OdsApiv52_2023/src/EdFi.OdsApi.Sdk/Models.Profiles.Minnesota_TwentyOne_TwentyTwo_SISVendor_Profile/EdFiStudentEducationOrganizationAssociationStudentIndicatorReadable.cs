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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = EdFi.OdsApi.Sdk.Client.SwaggerDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_TwentyOne_TwentyTwo_SISVendor_Profile
{
    /// <summary>
    /// EdFiStudentEducationOrganizationAssociationStudentIndicatorReadable
    /// </summary>
    [DataContract]
    public partial class EdFiStudentEducationOrganizationAssociationStudentIndicatorReadable :  IEquatable<EdFiStudentEducationOrganizationAssociationStudentIndicatorReadable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationStudentIndicatorReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentEducationOrganizationAssociationStudentIndicatorReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationStudentIndicatorReadable" /> class.
        /// </summary>
        /// <param name="indicatorName">The name of the indicator or metric. (required).</param>
        /// <param name="indicator">The value of the indicator or metric. (required).</param>
        /// <param name="indicatorGroup">The name for a group of indicators..</param>
        public EdFiStudentEducationOrganizationAssociationStudentIndicatorReadable(string indicatorName = default(string), string indicator = default(string), string indicatorGroup = default(string))
        {
            // to ensure "indicatorName" is required (not null)
            if (indicatorName == null)
            {
                throw new InvalidDataException("indicatorName is a required property for EdFiStudentEducationOrganizationAssociationStudentIndicatorReadable and cannot be null");
            }
            else
            {
                this.IndicatorName = indicatorName;
            }
            // to ensure "indicator" is required (not null)
            if (indicator == null)
            {
                throw new InvalidDataException("indicator is a required property for EdFiStudentEducationOrganizationAssociationStudentIndicatorReadable and cannot be null");
            }
            else
            {
                this.Indicator = indicator;
            }
            this.IndicatorGroup = indicatorGroup;
        }
        
        /// <summary>
        /// The name of the indicator or metric.
        /// </summary>
        /// <value>The name of the indicator or metric.</value>
        [DataMember(Name="indicatorName", EmitDefaultValue=false)]
        public string IndicatorName { get; set; }

        /// <summary>
        /// The value of the indicator or metric.
        /// </summary>
        /// <value>The value of the indicator or metric.</value>
        [DataMember(Name="indicator", EmitDefaultValue=false)]
        public string Indicator { get; set; }

        /// <summary>
        /// The name for a group of indicators.
        /// </summary>
        /// <value>The name for a group of indicators.</value>
        [DataMember(Name="indicatorGroup", EmitDefaultValue=false)]
        public string IndicatorGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentEducationOrganizationAssociationStudentIndicatorReadable {\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiStudentEducationOrganizationAssociationStudentIndicatorReadable);
        }

        /// <summary>
        /// Returns true if EdFiStudentEducationOrganizationAssociationStudentIndicatorReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentEducationOrganizationAssociationStudentIndicatorReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentEducationOrganizationAssociationStudentIndicatorReadable input)
        {
            if (input == null)
                return false;

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
                    hashCode = hashCode * 59 + this.IndicatorName.GetHashCode();
                if (this.Indicator != null)
                    hashCode = hashCode * 59 + this.Indicator.GetHashCode();
                if (this.IndicatorGroup != null)
                    hashCode = hashCode * 59 + this.IndicatorGroup.GetHashCode();
                return hashCode;
            }
        }
    }

}
