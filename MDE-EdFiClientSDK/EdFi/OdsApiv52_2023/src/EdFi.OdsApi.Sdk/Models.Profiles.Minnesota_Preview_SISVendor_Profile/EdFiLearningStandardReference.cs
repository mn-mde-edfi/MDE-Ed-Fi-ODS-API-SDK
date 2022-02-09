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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile
{
    /// <summary>
    /// EdFiLearningStandardReference
    /// </summary>
    [DataContract]
    public partial class EdFiLearningStandardReference :  IEquatable<EdFiLearningStandardReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLearningStandardReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiLearningStandardReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLearningStandardReference" /> class.
        /// </summary>
        /// <param name="learningStandardId">The identifier for the specific learning standard (e.g., 111.15.3.1.A). (required).</param>
        /// <param name="link">link.</param>
        public EdFiLearningStandardReference(string learningStandardId = default(string), Link link = default(Link))
        {
            // to ensure "learningStandardId" is required (not null)
            if (learningStandardId == null)
            {
                throw new InvalidDataException("learningStandardId is a required property for EdFiLearningStandardReference and cannot be null");
            }
            else
            {
                this.LearningStandardId = learningStandardId;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// The identifier for the specific learning standard (e.g., 111.15.3.1.A).
        /// </summary>
        /// <value>The identifier for the specific learning standard (e.g., 111.15.3.1.A).</value>
        [DataMember(Name="learningStandardId", EmitDefaultValue=false)]
        public string LearningStandardId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiLearningStandardReference {\n");
            sb.Append("  LearningStandardId: ").Append(LearningStandardId).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as EdFiLearningStandardReference);
        }

        /// <summary>
        /// Returns true if EdFiLearningStandardReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiLearningStandardReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiLearningStandardReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LearningStandardId == input.LearningStandardId ||
                    (this.LearningStandardId != null &&
                    this.LearningStandardId.Equals(input.LearningStandardId))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                if (this.LearningStandardId != null)
                    hashCode = hashCode * 59 + this.LearningStandardId.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
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
            // LearningStandardId (string) maxLength
            if(this.LearningStandardId != null && this.LearningStandardId.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LearningStandardId, length must be less than 60.", new [] { "LearningStandardId" });
            }

            yield break;
        }
    }

}
