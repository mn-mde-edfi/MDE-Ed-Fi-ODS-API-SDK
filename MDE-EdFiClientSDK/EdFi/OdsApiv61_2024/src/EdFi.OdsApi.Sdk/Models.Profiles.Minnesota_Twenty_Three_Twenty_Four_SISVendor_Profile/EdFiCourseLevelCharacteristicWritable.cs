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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Three_Twenty_Four_SISVendor_Profile
{
    /// <summary>
    /// EdFiCourseLevelCharacteristicWritable
    /// </summary>
    [DataContract(Name = "edFi_courseLevelCharacteristic_writable")]
    public partial class EdFiCourseLevelCharacteristicWritable : IEquatable<EdFiCourseLevelCharacteristicWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseLevelCharacteristicWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCourseLevelCharacteristicWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseLevelCharacteristicWritable" /> class.
        /// </summary>
        /// <param name="courseLevelCharacteristicDescriptor">The type of specific program or designation with which the course is associated (e.g., AP, IB, Dual Credit, CTE). (required).</param>
        public EdFiCourseLevelCharacteristicWritable(string courseLevelCharacteristicDescriptor = default(string))
        {
            // to ensure "courseLevelCharacteristicDescriptor" is required (not null)
            if (courseLevelCharacteristicDescriptor == null)
            {
                throw new ArgumentNullException("courseLevelCharacteristicDescriptor is a required property for EdFiCourseLevelCharacteristicWritable and cannot be null");
            }
            this.CourseLevelCharacteristicDescriptor = courseLevelCharacteristicDescriptor;
        }

        /// <summary>
        /// The type of specific program or designation with which the course is associated (e.g., AP, IB, Dual Credit, CTE).
        /// </summary>
        /// <value>The type of specific program or designation with which the course is associated (e.g., AP, IB, Dual Credit, CTE).</value>
        [DataMember(Name = "courseLevelCharacteristicDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string CourseLevelCharacteristicDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiCourseLevelCharacteristicWritable {\n");
            sb.Append("  CourseLevelCharacteristicDescriptor: ").Append(CourseLevelCharacteristicDescriptor).Append("\n");
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
            return this.Equals(input as EdFiCourseLevelCharacteristicWritable);
        }

        /// <summary>
        /// Returns true if EdFiCourseLevelCharacteristicWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCourseLevelCharacteristicWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCourseLevelCharacteristicWritable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CourseLevelCharacteristicDescriptor == input.CourseLevelCharacteristicDescriptor ||
                    (this.CourseLevelCharacteristicDescriptor != null &&
                    this.CourseLevelCharacteristicDescriptor.Equals(input.CourseLevelCharacteristicDescriptor))
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
                if (this.CourseLevelCharacteristicDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.CourseLevelCharacteristicDescriptor.GetHashCode();
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
            // CourseLevelCharacteristicDescriptor (string) maxLength
            if (this.CourseLevelCharacteristicDescriptor != null && this.CourseLevelCharacteristicDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CourseLevelCharacteristicDescriptor, length must be less than 306.", new [] { "CourseLevelCharacteristicDescriptor" });
            }

            yield break;
        }
    }

}
