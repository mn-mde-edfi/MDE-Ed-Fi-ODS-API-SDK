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
    /// EdFiSectionClassPeriod
    /// </summary>
    [DataContract]
    public partial class EdFiSectionClassPeriod :  IEquatable<EdFiSectionClassPeriod>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSectionClassPeriod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSectionClassPeriod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSectionClassPeriod" /> class.
        /// </summary>
        /// <param name="classPeriodReference">classPeriodReference (required).</param>
        public EdFiSectionClassPeriod(EdFiClassPeriodReference classPeriodReference = default(EdFiClassPeriodReference))
        {
            // to ensure "classPeriodReference" is required (not null)
            if (classPeriodReference == null)
            {
                throw new InvalidDataException("classPeriodReference is a required property for EdFiSectionClassPeriod and cannot be null");
            }
            else
            {
                this.ClassPeriodReference = classPeriodReference;
            }
        }
        
        /// <summary>
        /// Gets or Sets ClassPeriodReference
        /// </summary>
        [DataMember(Name="classPeriodReference", EmitDefaultValue=false)]
        public EdFiClassPeriodReference ClassPeriodReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiSectionClassPeriod {\n");
            sb.Append("  ClassPeriodReference: ").Append(ClassPeriodReference).Append("\n");
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
            return this.Equals(input as EdFiSectionClassPeriod);
        }

        /// <summary>
        /// Returns true if EdFiSectionClassPeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSectionClassPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSectionClassPeriod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClassPeriodReference == input.ClassPeriodReference ||
                    (this.ClassPeriodReference != null &&
                    this.ClassPeriodReference.Equals(input.ClassPeriodReference))
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
                if (this.ClassPeriodReference != null)
                    hashCode = hashCode * 59 + this.ClassPeriodReference.GetHashCode();
                return hashCode;
            }
        }
    }

}
