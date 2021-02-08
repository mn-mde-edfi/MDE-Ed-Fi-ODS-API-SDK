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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile
{
    /// <summary>
    /// EdFiParentLanguageReadable
    /// </summary>
    [DataContract]
    public partial class EdFiParentLanguageReadable :  IEquatable<EdFiParentLanguageReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiParentLanguageReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiParentLanguageReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiParentLanguageReadable" /> class.
        /// </summary>
        /// <param name="LanguageDescriptor">A specification of which written or spoken communication is being used. (required).</param>
        /// <param name="Uses">An unordered collection of parentLanguageUses. A description of how the language is used (e.g. Home Language, Native Language, Spoken Language)..</param>
        public EdFiParentLanguageReadable(string LanguageDescriptor = default(string), List<EdFiParentLanguageUseReadable> Uses = default(List<EdFiParentLanguageUseReadable>))
        {
            // to ensure "LanguageDescriptor" is required (not null)
            if (LanguageDescriptor == null)
            {
                throw new InvalidDataException("LanguageDescriptor is a required property for EdFiParentLanguageReadable and cannot be null");
            }
            else
            {
                this.LanguageDescriptor = LanguageDescriptor;
            }
            this.Uses = Uses;
        }
        
        /// <summary>
        /// A specification of which written or spoken communication is being used.
        /// </summary>
        /// <value>A specification of which written or spoken communication is being used.</value>
        [DataMember(Name="languageDescriptor", EmitDefaultValue=false)]
        public string LanguageDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of parentLanguageUses. A description of how the language is used (e.g. Home Language, Native Language, Spoken Language).
        /// </summary>
        /// <value>An unordered collection of parentLanguageUses. A description of how the language is used (e.g. Home Language, Native Language, Spoken Language).</value>
        [DataMember(Name="uses", EmitDefaultValue=false)]
        public List<EdFiParentLanguageUseReadable> Uses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiParentLanguageReadable {\n");
            sb.Append("  LanguageDescriptor: ").Append(LanguageDescriptor).Append("\n");
            sb.Append("  Uses: ").Append(Uses).Append("\n");
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
            return this.Equals(input as EdFiParentLanguageReadable);
        }

        /// <summary>
        /// Returns true if EdFiParentLanguageReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiParentLanguageReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiParentLanguageReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LanguageDescriptor == input.LanguageDescriptor ||
                    (this.LanguageDescriptor != null &&
                    this.LanguageDescriptor.Equals(input.LanguageDescriptor))
                ) && 
                (
                    this.Uses == input.Uses ||
                    this.Uses != null &&
                    this.Uses.SequenceEqual(input.Uses)
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
                if (this.LanguageDescriptor != null)
                    hashCode = hashCode * 59 + this.LanguageDescriptor.GetHashCode();
                if (this.Uses != null)
                    hashCode = hashCode * 59 + this.Uses.GetHashCode();
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
            // LanguageDescriptor (string) maxLength
            if(this.LanguageDescriptor != null && this.LanguageDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LanguageDescriptor, length must be less than 306.", new [] { "LanguageDescriptor" });
            }

            yield break;
        }
    }

}
