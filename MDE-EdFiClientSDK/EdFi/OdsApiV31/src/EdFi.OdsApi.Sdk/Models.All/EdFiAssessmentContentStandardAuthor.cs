/* 
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface. The Ed-Fi ODS / API supports both transactional and bulk modes of operation.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
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

namespace EdFi.OdsApi.Sdk.Models.All
{
    /// <summary>
    /// EdFiAssessmentContentStandardAuthor
    /// </summary>
    [DataContract]
    public partial class EdFiAssessmentContentStandardAuthor :  IEquatable<EdFiAssessmentContentStandardAuthor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentContentStandardAuthor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiAssessmentContentStandardAuthor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentContentStandardAuthor" /> class.
        /// </summary>
        /// <param name="Author">The person or organization chiefly responsible for the intellectual content of the standard. (required).</param>
        public EdFiAssessmentContentStandardAuthor(string Author = default(string))
        {
            // to ensure "Author" is required (not null)
            if (Author == null)
            {
                throw new InvalidDataException("Author is a required property for EdFiAssessmentContentStandardAuthor and cannot be null");
            }
            else
            {
                this.Author = Author;
            }
        }
        
        /// <summary>
        /// The person or organization chiefly responsible for the intellectual content of the standard.
        /// </summary>
        /// <value>The person or organization chiefly responsible for the intellectual content of the standard.</value>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public string Author { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiAssessmentContentStandardAuthor {\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as EdFiAssessmentContentStandardAuthor);
        }

        /// <summary>
        /// Returns true if EdFiAssessmentContentStandardAuthor instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiAssessmentContentStandardAuthor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiAssessmentContentStandardAuthor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
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
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
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
            // Author (string) maxLength
            if(this.Author != null && this.Author.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Author, length must be less than 100.", new [] { "Author" });
            }

            yield break;
        }
    }

}
