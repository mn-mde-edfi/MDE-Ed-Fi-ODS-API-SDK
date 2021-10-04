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

namespace EdFi.OdsApi.Sdk.Models.Identity
{
    /// <summary>
    /// EdFiSessionGradingPeriod
    /// </summary>
    [DataContract]
    public partial class EdFiSessionGradingPeriod :  IEquatable<EdFiSessionGradingPeriod>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSessionGradingPeriod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSessionGradingPeriod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSessionGradingPeriod" /> class.
        /// </summary>
        /// <param name="gradingPeriodReference">gradingPeriodReference (required).</param>
        public EdFiSessionGradingPeriod(EdFiGradingPeriodReference gradingPeriodReference = default(EdFiGradingPeriodReference))
        {
            // to ensure "gradingPeriodReference" is required (not null)
            if (gradingPeriodReference == null)
            {
                throw new InvalidDataException("gradingPeriodReference is a required property for EdFiSessionGradingPeriod and cannot be null");
            }
            else
            {
                this.GradingPeriodReference = gradingPeriodReference;
            }
        }
        
        /// <summary>
        /// Gets or Sets GradingPeriodReference
        /// </summary>
        [DataMember(Name="gradingPeriodReference", EmitDefaultValue=false)]
        public EdFiGradingPeriodReference GradingPeriodReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiSessionGradingPeriod {\n");
            sb.Append("  GradingPeriodReference: ").Append(GradingPeriodReference).Append("\n");
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
            return this.Equals(input as EdFiSessionGradingPeriod);
        }

        /// <summary>
        /// Returns true if EdFiSessionGradingPeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSessionGradingPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSessionGradingPeriod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GradingPeriodReference == input.GradingPeriodReference ||
                    (this.GradingPeriodReference != null &&
                    this.GradingPeriodReference.Equals(input.GradingPeriodReference))
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
                if (this.GradingPeriodReference != null)
                    hashCode = hashCode * 59 + this.GradingPeriodReference.GetHashCode();
                return hashCode;
            }
        }
    }

}
