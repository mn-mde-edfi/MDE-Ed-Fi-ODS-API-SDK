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
    /// EdFiLearningStandardContentStandardAuthor
    /// </summary>
    [DataContract]
    public partial class EdFiLearningStandardContentStandardAuthor :  IEquatable<EdFiLearningStandardContentStandardAuthor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLearningStandardContentStandardAuthor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiLearningStandardContentStandardAuthor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLearningStandardContentStandardAuthor" /> class.
        /// </summary>
        /// <param name="author">The person or organization chiefly responsible for the intellectual content of the standard. (required).</param>
        public EdFiLearningStandardContentStandardAuthor(string author = default(string))
        {
            // to ensure "author" is required (not null)
            if (author == null)
            {
                throw new InvalidDataException("author is a required property for EdFiLearningStandardContentStandardAuthor and cannot be null");
            }
            else
            {
                this.Author = author;
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
            sb.Append("class EdFiLearningStandardContentStandardAuthor {\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
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
            return this.Equals(input as EdFiLearningStandardContentStandardAuthor);
        }

        /// <summary>
        /// Returns true if EdFiLearningStandardContentStandardAuthor instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiLearningStandardContentStandardAuthor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiLearningStandardContentStandardAuthor input)
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
    }

}
