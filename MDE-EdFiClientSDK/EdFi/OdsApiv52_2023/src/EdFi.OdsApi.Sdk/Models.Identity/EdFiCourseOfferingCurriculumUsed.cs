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
    /// EdFiCourseOfferingCurriculumUsed
    /// </summary>
    [DataContract]
    public partial class EdFiCourseOfferingCurriculumUsed :  IEquatable<EdFiCourseOfferingCurriculumUsed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseOfferingCurriculumUsed" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCourseOfferingCurriculumUsed() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseOfferingCurriculumUsed" /> class.
        /// </summary>
        /// <param name="curriculumUsedDescriptor">The type of curriculum used in an early learning classroom or group. (required).</param>
        public EdFiCourseOfferingCurriculumUsed(string curriculumUsedDescriptor = default(string))
        {
            // to ensure "curriculumUsedDescriptor" is required (not null)
            if (curriculumUsedDescriptor == null)
            {
                throw new InvalidDataException("curriculumUsedDescriptor is a required property for EdFiCourseOfferingCurriculumUsed and cannot be null");
            }
            else
            {
                this.CurriculumUsedDescriptor = curriculumUsedDescriptor;
            }
        }
        
        /// <summary>
        /// The type of curriculum used in an early learning classroom or group.
        /// </summary>
        /// <value>The type of curriculum used in an early learning classroom or group.</value>
        [DataMember(Name="curriculumUsedDescriptor", EmitDefaultValue=false)]
        public string CurriculumUsedDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiCourseOfferingCurriculumUsed {\n");
            sb.Append("  CurriculumUsedDescriptor: ").Append(CurriculumUsedDescriptor).Append("\n");
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
            return this.Equals(input as EdFiCourseOfferingCurriculumUsed);
        }

        /// <summary>
        /// Returns true if EdFiCourseOfferingCurriculumUsed instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCourseOfferingCurriculumUsed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCourseOfferingCurriculumUsed input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurriculumUsedDescriptor == input.CurriculumUsedDescriptor ||
                    (this.CurriculumUsedDescriptor != null &&
                    this.CurriculumUsedDescriptor.Equals(input.CurriculumUsedDescriptor))
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
                if (this.CurriculumUsedDescriptor != null)
                    hashCode = hashCode * 59 + this.CurriculumUsedDescriptor.GetHashCode();
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
            // CurriculumUsedDescriptor (string) maxLength
            if(this.CurriculumUsedDescriptor != null && this.CurriculumUsedDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CurriculumUsedDescriptor, length must be less than 306.", new [] { "CurriculumUsedDescriptor" });
            }

            yield break;
        }
    }

}
