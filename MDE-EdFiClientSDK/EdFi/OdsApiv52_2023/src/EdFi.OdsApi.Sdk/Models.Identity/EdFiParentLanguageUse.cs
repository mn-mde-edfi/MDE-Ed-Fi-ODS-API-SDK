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
    /// EdFiParentLanguageUse
    /// </summary>
    [DataContract]
    public partial class EdFiParentLanguageUse :  IEquatable<EdFiParentLanguageUse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiParentLanguageUse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiParentLanguageUse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiParentLanguageUse" /> class.
        /// </summary>
        /// <param name="languageUseDescriptor">A description of how the language is used (e.g. Home Language, Native Language, Spoken Language). (required).</param>
        public EdFiParentLanguageUse(string languageUseDescriptor = default(string))
        {
            // to ensure "languageUseDescriptor" is required (not null)
            if (languageUseDescriptor == null)
            {
                throw new InvalidDataException("languageUseDescriptor is a required property for EdFiParentLanguageUse and cannot be null");
            }
            else
            {
                this.LanguageUseDescriptor = languageUseDescriptor;
            }
        }
        
        /// <summary>
        /// A description of how the language is used (e.g. Home Language, Native Language, Spoken Language).
        /// </summary>
        /// <value>A description of how the language is used (e.g. Home Language, Native Language, Spoken Language).</value>
        [DataMember(Name="languageUseDescriptor", EmitDefaultValue=false)]
        public string LanguageUseDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiParentLanguageUse {\n");
            sb.Append("  LanguageUseDescriptor: ").Append(LanguageUseDescriptor).Append("\n");
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
            return this.Equals(input as EdFiParentLanguageUse);
        }

        /// <summary>
        /// Returns true if EdFiParentLanguageUse instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiParentLanguageUse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiParentLanguageUse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LanguageUseDescriptor == input.LanguageUseDescriptor ||
                    (this.LanguageUseDescriptor != null &&
                    this.LanguageUseDescriptor.Equals(input.LanguageUseDescriptor))
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
                if (this.LanguageUseDescriptor != null)
                    hashCode = hashCode * 59 + this.LanguageUseDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
