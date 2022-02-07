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
    /// MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable
    /// </summary>
    [DataContract]
    public partial class MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable :  IEquatable<MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable" /> class.
        /// </summary>
        /// <param name="academicHonorCategoryDescriptor">A designation of the type of academic distinctions earned by or awarded to the student. (required).</param>
        /// <param name="honorDescription">A description of the type of academic distinctions earned by or awarded to the individual. (required).</param>
        /// <param name="achievementCategoryDescriptor">The category of achievement attributed to the learner. (required).</param>
        /// <param name="assessmentCategoryDescriptor">The skills assessment used to test for award. (required).</param>
        /// <param name="assessedGradeLevelDescriptor">The grade level of the student when tested for award. (required).</param>
        /// <param name="assessmentTitle">The title/name of the skills assessment administered..</param>
        /// <param name="honorAwardDate">The date the honor was awarded or earned..</param>
        /// <param name="honorAwardExpiresDate">Date on which the award expires..</param>
        /// <param name="assessedSchoolYearTypeReference">assessedSchoolYearTypeReference (required).</param>
        /// <param name="languages">An unordered collection of studentEducationOrganizationAssociationLanguageAcademicHonorLanguages. The language (non-English) in which the student earned this honor. For bilingual seals or world languages proficiency certificate, one language; for multilingual seals, multiple languages. (required).</param>
        public MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable(string academicHonorCategoryDescriptor = default(string), string honorDescription = default(string), string achievementCategoryDescriptor = default(string), string assessmentCategoryDescriptor = default(string), string assessedGradeLevelDescriptor = default(string), string assessmentTitle = default(string), DateTime? honorAwardDate = default(DateTime?), DateTime? honorAwardExpiresDate = default(DateTime?), EdFiSchoolYearTypeReference assessedSchoolYearTypeReference = default(EdFiSchoolYearTypeReference), List<MnStudentEducationOrganizationAssociationLanguageAcademicHonorLanguageWritable> languages = default(List<MnStudentEducationOrganizationAssociationLanguageAcademicHonorLanguageWritable>))
        {
            // to ensure "academicHonorCategoryDescriptor" is required (not null)
            if (academicHonorCategoryDescriptor == null)
            {
                throw new InvalidDataException("academicHonorCategoryDescriptor is a required property for MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable and cannot be null");
            }
            else
            {
                this.AcademicHonorCategoryDescriptor = academicHonorCategoryDescriptor;
            }
            // to ensure "honorDescription" is required (not null)
            if (honorDescription == null)
            {
                throw new InvalidDataException("honorDescription is a required property for MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable and cannot be null");
            }
            else
            {
                this.HonorDescription = honorDescription;
            }
            // to ensure "achievementCategoryDescriptor" is required (not null)
            if (achievementCategoryDescriptor == null)
            {
                throw new InvalidDataException("achievementCategoryDescriptor is a required property for MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable and cannot be null");
            }
            else
            {
                this.AchievementCategoryDescriptor = achievementCategoryDescriptor;
            }
            // to ensure "assessmentCategoryDescriptor" is required (not null)
            if (assessmentCategoryDescriptor == null)
            {
                throw new InvalidDataException("assessmentCategoryDescriptor is a required property for MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable and cannot be null");
            }
            else
            {
                this.AssessmentCategoryDescriptor = assessmentCategoryDescriptor;
            }
            // to ensure "assessedGradeLevelDescriptor" is required (not null)
            if (assessedGradeLevelDescriptor == null)
            {
                throw new InvalidDataException("assessedGradeLevelDescriptor is a required property for MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable and cannot be null");
            }
            else
            {
                this.AssessedGradeLevelDescriptor = assessedGradeLevelDescriptor;
            }
            // to ensure "assessedSchoolYearTypeReference" is required (not null)
            if (assessedSchoolYearTypeReference == null)
            {
                throw new InvalidDataException("assessedSchoolYearTypeReference is a required property for MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable and cannot be null");
            }
            else
            {
                this.AssessedSchoolYearTypeReference = assessedSchoolYearTypeReference;
            }
            // to ensure "languages" is required (not null)
            if (languages == null)
            {
                throw new InvalidDataException("languages is a required property for MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable and cannot be null");
            }
            else
            {
                this.Languages = languages;
            }
            this.AssessmentTitle = assessmentTitle;
            this.HonorAwardDate = honorAwardDate;
            this.HonorAwardExpiresDate = honorAwardExpiresDate;
        }
        
        /// <summary>
        /// A designation of the type of academic distinctions earned by or awarded to the student.
        /// </summary>
        /// <value>A designation of the type of academic distinctions earned by or awarded to the student.</value>
        [DataMember(Name="academicHonorCategoryDescriptor", EmitDefaultValue=false)]
        public string AcademicHonorCategoryDescriptor { get; set; }

        /// <summary>
        /// A description of the type of academic distinctions earned by or awarded to the individual.
        /// </summary>
        /// <value>A description of the type of academic distinctions earned by or awarded to the individual.</value>
        [DataMember(Name="honorDescription", EmitDefaultValue=false)]
        public string HonorDescription { get; set; }

        /// <summary>
        /// The category of achievement attributed to the learner.
        /// </summary>
        /// <value>The category of achievement attributed to the learner.</value>
        [DataMember(Name="achievementCategoryDescriptor", EmitDefaultValue=false)]
        public string AchievementCategoryDescriptor { get; set; }

        /// <summary>
        /// The skills assessment used to test for award.
        /// </summary>
        /// <value>The skills assessment used to test for award.</value>
        [DataMember(Name="assessmentCategoryDescriptor", EmitDefaultValue=false)]
        public string AssessmentCategoryDescriptor { get; set; }

        /// <summary>
        /// The grade level of the student when tested for award.
        /// </summary>
        /// <value>The grade level of the student when tested for award.</value>
        [DataMember(Name="assessedGradeLevelDescriptor", EmitDefaultValue=false)]
        public string AssessedGradeLevelDescriptor { get; set; }

        /// <summary>
        /// The title/name of the skills assessment administered.
        /// </summary>
        /// <value>The title/name of the skills assessment administered.</value>
        [DataMember(Name="assessmentTitle", EmitDefaultValue=false)]
        public string AssessmentTitle { get; set; }

        /// <summary>
        /// The date the honor was awarded or earned.
        /// </summary>
        /// <value>The date the honor was awarded or earned.</value>
        [DataMember(Name="honorAwardDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? HonorAwardDate { get; set; }

        /// <summary>
        /// Date on which the award expires.
        /// </summary>
        /// <value>Date on which the award expires.</value>
        [DataMember(Name="honorAwardExpiresDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? HonorAwardExpiresDate { get; set; }

        /// <summary>
        /// Gets or Sets AssessedSchoolYearTypeReference
        /// </summary>
        [DataMember(Name="assessedSchoolYearTypeReference", EmitDefaultValue=false)]
        public EdFiSchoolYearTypeReference AssessedSchoolYearTypeReference { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationLanguageAcademicHonorLanguages. The language (non-English) in which the student earned this honor. For bilingual seals or world languages proficiency certificate, one language; for multilingual seals, multiple languages.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationLanguageAcademicHonorLanguages. The language (non-English) in which the student earned this honor. For bilingual seals or world languages proficiency certificate, one language; for multilingual seals, multiple languages.</value>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<MnStudentEducationOrganizationAssociationLanguageAcademicHonorLanguageWritable> Languages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable {\n");
            sb.Append("  AcademicHonorCategoryDescriptor: ").Append(AcademicHonorCategoryDescriptor).Append("\n");
            sb.Append("  HonorDescription: ").Append(HonorDescription).Append("\n");
            sb.Append("  AchievementCategoryDescriptor: ").Append(AchievementCategoryDescriptor).Append("\n");
            sb.Append("  AssessmentCategoryDescriptor: ").Append(AssessmentCategoryDescriptor).Append("\n");
            sb.Append("  AssessedGradeLevelDescriptor: ").Append(AssessedGradeLevelDescriptor).Append("\n");
            sb.Append("  AssessmentTitle: ").Append(AssessmentTitle).Append("\n");
            sb.Append("  HonorAwardDate: ").Append(HonorAwardDate).Append("\n");
            sb.Append("  HonorAwardExpiresDate: ").Append(HonorAwardExpiresDate).Append("\n");
            sb.Append("  AssessedSchoolYearTypeReference: ").Append(AssessedSchoolYearTypeReference).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
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
            return this.Equals(input as MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable);
        }

        /// <summary>
        /// Returns true if MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentEducationOrganizationAssociationLanguageAcademicHonorWritable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcademicHonorCategoryDescriptor == input.AcademicHonorCategoryDescriptor ||
                    (this.AcademicHonorCategoryDescriptor != null &&
                    this.AcademicHonorCategoryDescriptor.Equals(input.AcademicHonorCategoryDescriptor))
                ) && 
                (
                    this.HonorDescription == input.HonorDescription ||
                    (this.HonorDescription != null &&
                    this.HonorDescription.Equals(input.HonorDescription))
                ) && 
                (
                    this.AchievementCategoryDescriptor == input.AchievementCategoryDescriptor ||
                    (this.AchievementCategoryDescriptor != null &&
                    this.AchievementCategoryDescriptor.Equals(input.AchievementCategoryDescriptor))
                ) && 
                (
                    this.AssessmentCategoryDescriptor == input.AssessmentCategoryDescriptor ||
                    (this.AssessmentCategoryDescriptor != null &&
                    this.AssessmentCategoryDescriptor.Equals(input.AssessmentCategoryDescriptor))
                ) && 
                (
                    this.AssessedGradeLevelDescriptor == input.AssessedGradeLevelDescriptor ||
                    (this.AssessedGradeLevelDescriptor != null &&
                    this.AssessedGradeLevelDescriptor.Equals(input.AssessedGradeLevelDescriptor))
                ) && 
                (
                    this.AssessmentTitle == input.AssessmentTitle ||
                    (this.AssessmentTitle != null &&
                    this.AssessmentTitle.Equals(input.AssessmentTitle))
                ) && 
                (
                    this.HonorAwardDate == input.HonorAwardDate ||
                    (this.HonorAwardDate != null &&
                    this.HonorAwardDate.Equals(input.HonorAwardDate))
                ) && 
                (
                    this.HonorAwardExpiresDate == input.HonorAwardExpiresDate ||
                    (this.HonorAwardExpiresDate != null &&
                    this.HonorAwardExpiresDate.Equals(input.HonorAwardExpiresDate))
                ) && 
                (
                    this.AssessedSchoolYearTypeReference == input.AssessedSchoolYearTypeReference ||
                    (this.AssessedSchoolYearTypeReference != null &&
                    this.AssessedSchoolYearTypeReference.Equals(input.AssessedSchoolYearTypeReference))
                ) && 
                (
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
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
                if (this.AcademicHonorCategoryDescriptor != null)
                    hashCode = hashCode * 59 + this.AcademicHonorCategoryDescriptor.GetHashCode();
                if (this.HonorDescription != null)
                    hashCode = hashCode * 59 + this.HonorDescription.GetHashCode();
                if (this.AchievementCategoryDescriptor != null)
                    hashCode = hashCode * 59 + this.AchievementCategoryDescriptor.GetHashCode();
                if (this.AssessmentCategoryDescriptor != null)
                    hashCode = hashCode * 59 + this.AssessmentCategoryDescriptor.GetHashCode();
                if (this.AssessedGradeLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.AssessedGradeLevelDescriptor.GetHashCode();
                if (this.AssessmentTitle != null)
                    hashCode = hashCode * 59 + this.AssessmentTitle.GetHashCode();
                if (this.HonorAwardDate != null)
                    hashCode = hashCode * 59 + this.HonorAwardDate.GetHashCode();
                if (this.HonorAwardExpiresDate != null)
                    hashCode = hashCode * 59 + this.HonorAwardExpiresDate.GetHashCode();
                if (this.AssessedSchoolYearTypeReference != null)
                    hashCode = hashCode * 59 + this.AssessedSchoolYearTypeReference.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
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
            // AcademicHonorCategoryDescriptor (string) maxLength
            if(this.AcademicHonorCategoryDescriptor != null && this.AcademicHonorCategoryDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AcademicHonorCategoryDescriptor, length must be less than 306.", new [] { "AcademicHonorCategoryDescriptor" });
            }

            // HonorDescription (string) maxLength
            if(this.HonorDescription != null && this.HonorDescription.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HonorDescription, length must be less than 80.", new [] { "HonorDescription" });
            }

            // AchievementCategoryDescriptor (string) maxLength
            if(this.AchievementCategoryDescriptor != null && this.AchievementCategoryDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AchievementCategoryDescriptor, length must be less than 306.", new [] { "AchievementCategoryDescriptor" });
            }

            // AssessmentCategoryDescriptor (string) maxLength
            if(this.AssessmentCategoryDescriptor != null && this.AssessmentCategoryDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentCategoryDescriptor, length must be less than 306.", new [] { "AssessmentCategoryDescriptor" });
            }

            // AssessedGradeLevelDescriptor (string) maxLength
            if(this.AssessedGradeLevelDescriptor != null && this.AssessedGradeLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessedGradeLevelDescriptor, length must be less than 306.", new [] { "AssessedGradeLevelDescriptor" });
            }

            // AssessmentTitle (string) maxLength
            if(this.AssessmentTitle != null && this.AssessmentTitle.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentTitle, length must be less than 100.", new [] { "AssessmentTitle" });
            }

            yield break;
        }
    }

}