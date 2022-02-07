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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Two_Twenty_Three_SISVendor_Profile
{
    /// <summary>
    /// MnStudentEducationOrganizationAssociationExtensionWritable
    /// </summary>
    [DataContract]
    public partial class MnStudentEducationOrganizationAssociationExtensionWritable :  IEquatable<MnStudentEducationOrganizationAssociationExtensionWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentEducationOrganizationAssociationExtensionWritable" /> class.
        /// </summary>
        /// <param name="birthDate">The month, day, and year on which an individual was born..</param>
        /// <param name="firstName">A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change..</param>
        /// <param name="generationCodeSuffix">An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III)..</param>
        /// <param name="lastSurname">The name borne in common by members of a family..</param>
        /// <param name="middleName">A secondary name given to an individual at birth, baptism, or during another naming ceremony..</param>
        /// <param name="genderIdentities">An unordered collection of studentEducationOrganizationAssociationGenderIdentities. Gender identity..</param>
        /// <param name="languageAcademicHonors">An unordered collection of studentEducationOrganizationAssociationLanguageAcademicHonors. Academic honors..</param>
        /// <param name="optOutIndicators">An unordered collection of studentEducationOrganizationAssociationOptOutIndicators. Opt Out Indicators..</param>
        /// <param name="preferredPronouns">An unordered collection of studentEducationOrganizationAssociationPreferredPronouns. Preferred pronoun..</param>
        public MnStudentEducationOrganizationAssociationExtensionWritable(DateTime? birthDate = default(DateTime?), string firstName = default(string), string generationCodeSuffix = default(string), string lastSurname = default(string), string middleName = default(string), List<MnStudentEducationOrganizationAssociationGenderIdentityWritable> genderIdentities = default(List<MnStudentEducationOrganizationAssociationGenderIdentityWritable>), List<MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable> languageAcademicHonors = default(List<MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable>), List<MnStudentEducationOrganizationAssociationOptOutIndicatorsWritable> optOutIndicators = default(List<MnStudentEducationOrganizationAssociationOptOutIndicatorsWritable>), List<MnStudentEducationOrganizationAssociationPreferredPronounWritable> preferredPronouns = default(List<MnStudentEducationOrganizationAssociationPreferredPronounWritable>))
        {
            this.BirthDate = birthDate;
            this.FirstName = firstName;
            this.GenerationCodeSuffix = generationCodeSuffix;
            this.LastSurname = lastSurname;
            this.MiddleName = middleName;
            this.GenderIdentities = genderIdentities;
            this.LanguageAcademicHonors = languageAcademicHonors;
            this.OptOutIndicators = optOutIndicators;
            this.PreferredPronouns = preferredPronouns;
        }
        
        /// <summary>
        /// The month, day, and year on which an individual was born.
        /// </summary>
        /// <value>The month, day, and year on which an individual was born.</value>
        [DataMember(Name="birthDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.
        /// </summary>
        /// <value>A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III).
        /// </summary>
        /// <value>An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III).</value>
        [DataMember(Name="generationCodeSuffix", EmitDefaultValue=false)]
        public string GenerationCodeSuffix { get; set; }

        /// <summary>
        /// The name borne in common by members of a family.
        /// </summary>
        /// <value>The name borne in common by members of a family.</value>
        [DataMember(Name="lastSurname", EmitDefaultValue=false)]
        public string LastSurname { get; set; }

        /// <summary>
        /// A secondary name given to an individual at birth, baptism, or during another naming ceremony.
        /// </summary>
        /// <value>A secondary name given to an individual at birth, baptism, or during another naming ceremony.</value>
        [DataMember(Name="middleName", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationGenderIdentities. Gender identity.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationGenderIdentities. Gender identity.</value>
        [DataMember(Name="genderIdentities", EmitDefaultValue=false)]
        public List<MnStudentEducationOrganizationAssociationGenderIdentityWritable> GenderIdentities { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationLanguageAcademicHonors. Academic honors.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationLanguageAcademicHonors. Academic honors.</value>
        [DataMember(Name="languageAcademicHonors", EmitDefaultValue=false)]
        public List<MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable> LanguageAcademicHonors { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationOptOutIndicators. Opt Out Indicators.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationOptOutIndicators. Opt Out Indicators.</value>
        [DataMember(Name="optOutIndicators", EmitDefaultValue=false)]
        public List<MnStudentEducationOrganizationAssociationOptOutIndicatorsWritable> OptOutIndicators { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationPreferredPronouns. Preferred pronoun.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationPreferredPronouns. Preferred pronoun.</value>
        [DataMember(Name="preferredPronouns", EmitDefaultValue=false)]
        public List<MnStudentEducationOrganizationAssociationPreferredPronounWritable> PreferredPronouns { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnStudentEducationOrganizationAssociationExtensionWritable {\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  GenerationCodeSuffix: ").Append(GenerationCodeSuffix).Append("\n");
            sb.Append("  LastSurname: ").Append(LastSurname).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  GenderIdentities: ").Append(GenderIdentities).Append("\n");
            sb.Append("  LanguageAcademicHonors: ").Append(LanguageAcademicHonors).Append("\n");
            sb.Append("  OptOutIndicators: ").Append(OptOutIndicators).Append("\n");
            sb.Append("  PreferredPronouns: ").Append(PreferredPronouns).Append("\n");
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
            return this.Equals(input as MnStudentEducationOrganizationAssociationExtensionWritable);
        }

        /// <summary>
        /// Returns true if MnStudentEducationOrganizationAssociationExtensionWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentEducationOrganizationAssociationExtensionWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentEducationOrganizationAssociationExtensionWritable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BirthDate == input.BirthDate ||
                    (this.BirthDate != null &&
                    this.BirthDate.Equals(input.BirthDate))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.GenerationCodeSuffix == input.GenerationCodeSuffix ||
                    (this.GenerationCodeSuffix != null &&
                    this.GenerationCodeSuffix.Equals(input.GenerationCodeSuffix))
                ) && 
                (
                    this.LastSurname == input.LastSurname ||
                    (this.LastSurname != null &&
                    this.LastSurname.Equals(input.LastSurname))
                ) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && 
                (
                    this.GenderIdentities == input.GenderIdentities ||
                    this.GenderIdentities != null &&
                    this.GenderIdentities.SequenceEqual(input.GenderIdentities)
                ) && 
                (
                    this.LanguageAcademicHonors == input.LanguageAcademicHonors ||
                    this.LanguageAcademicHonors != null &&
                    this.LanguageAcademicHonors.SequenceEqual(input.LanguageAcademicHonors)
                ) && 
                (
                    this.OptOutIndicators == input.OptOutIndicators ||
                    this.OptOutIndicators != null &&
                    this.OptOutIndicators.SequenceEqual(input.OptOutIndicators)
                ) && 
                (
                    this.PreferredPronouns == input.PreferredPronouns ||
                    this.PreferredPronouns != null &&
                    this.PreferredPronouns.SequenceEqual(input.PreferredPronouns)
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
                if (this.BirthDate != null)
                    hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.GenerationCodeSuffix != null)
                    hashCode = hashCode * 59 + this.GenerationCodeSuffix.GetHashCode();
                if (this.LastSurname != null)
                    hashCode = hashCode * 59 + this.LastSurname.GetHashCode();
                if (this.MiddleName != null)
                    hashCode = hashCode * 59 + this.MiddleName.GetHashCode();
                if (this.GenderIdentities != null)
                    hashCode = hashCode * 59 + this.GenderIdentities.GetHashCode();
                if (this.LanguageAcademicHonors != null)
                    hashCode = hashCode * 59 + this.LanguageAcademicHonors.GetHashCode();
                if (this.OptOutIndicators != null)
                    hashCode = hashCode * 59 + this.OptOutIndicators.GetHashCode();
                if (this.PreferredPronouns != null)
                    hashCode = hashCode * 59 + this.PreferredPronouns.GetHashCode();
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
            // FirstName (string) maxLength
            if(this.FirstName != null && this.FirstName.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 75.", new [] { "FirstName" });
            }

            // GenerationCodeSuffix (string) maxLength
            if(this.GenerationCodeSuffix != null && this.GenerationCodeSuffix.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GenerationCodeSuffix, length must be less than 10.", new [] { "GenerationCodeSuffix" });
            }

            // LastSurname (string) maxLength
            if(this.LastSurname != null && this.LastSurname.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastSurname, length must be less than 75.", new [] { "LastSurname" });
            }

            // MiddleName (string) maxLength
            if(this.MiddleName != null && this.MiddleName.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MiddleName, length must be less than 75.", new [] { "MiddleName" });
            }

            yield break;
        }
    }

}
