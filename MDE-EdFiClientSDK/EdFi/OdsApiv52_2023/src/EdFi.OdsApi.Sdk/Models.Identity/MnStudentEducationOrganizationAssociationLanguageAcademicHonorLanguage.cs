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
    /// MnStudentEducationOrganizationAssociationLanguageAcademicHonorLanguage
    /// </summary>
    [DataContract]
    public partial class MnStudentEducationOrganizationAssociationLanguageAcademicHonorLanguage :  IEquatable<MnStudentEducationOrganizationAssociationLanguageAcademicHonorLanguage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentEducationOrganizationAssociationLanguageAcademicHonorLanguage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentEducationOrganizationAssociationLanguageAcademicHonorLanguage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentEducationOrganizationAssociationLanguageAcademicHonorLanguage" /> class.
        /// </summary>
        /// <param name="languageDescriptor">The language (non-English) in which the student earned this honor. For bilingual seals or world languages proficiency certificate, one language; for multilingual seals, multiple languages. (required).</param>
        public MnStudentEducationOrganizationAssociationLanguageAcademicHonorLanguage(string languageDescriptor = default(string))
        {
            // to ensure "languageDescriptor" is required (not null)
            if (languageDescriptor == null)
            {
                throw new InvalidDataException("languageDescriptor is a required property for MnStudentEducationOrganizationAssociationLanguageAcademicHonorLanguage and cannot be null");
            }
            else
            {
                this.LanguageDescriptor = languageDescriptor;
            }
        }
        
        /// <summary>
        /// The language (non-English) in which the student earned this honor. For bilingual seals or world languages proficiency certificate, one language; for multilingual seals, multiple languages.
        /// </summary>
        /// <value>The language (non-English) in which the student earned this honor. For bilingual seals or world languages proficiency certificate, one language; for multilingual seals, multiple languages.</value>
        [DataMember(Name="languageDescriptor", EmitDefaultValue=false)]
        public string LanguageDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnStudentEducationOrganizationAssociationLanguageAcademicHonorLanguage {\n");
            sb.Append("  LanguageDescriptor: ").Append(LanguageDescriptor).Append("\n");
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
            return this.Equals(input as MnStudentEducationOrganizationAssociationLanguageAcademicHonorLanguage);
        }

        /// <summary>
        /// Returns true if MnStudentEducationOrganizationAssociationLanguageAcademicHonorLanguage instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentEducationOrganizationAssociationLanguageAcademicHonorLanguage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentEducationOrganizationAssociationLanguageAcademicHonorLanguage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LanguageDescriptor == input.LanguageDescriptor ||
                    (this.LanguageDescriptor != null &&
                    this.LanguageDescriptor.Equals(input.LanguageDescriptor))
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
