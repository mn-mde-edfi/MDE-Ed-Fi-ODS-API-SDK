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
    /// EdFiStudentAcademicRecordRecognition
    /// </summary>
    [DataContract]
    public partial class EdFiStudentAcademicRecordRecognition :  IEquatable<EdFiStudentAcademicRecordRecognition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAcademicRecordRecognition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentAcademicRecordRecognition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAcademicRecordRecognition" /> class.
        /// </summary>
        /// <param name="RecognitionTypeDescriptor">The nature of recognition given to the learner for accomplishments in a co-curricular, or extra-curricular activity. (required).</param>
        /// <param name="AchievementCategoryDescriptor">The category of achievement attributed to the learner..</param>
        /// <param name="AchievementCategorySystem">The system that defines the categories by which an achievement is attributed to the learner..</param>
        /// <param name="AchievementTitle">The title assigned to the achievement..</param>
        /// <param name="Criteria">The criteria for competency-based completion of the achievement/award..</param>
        /// <param name="CriteriaURL">The Uniform Resource Locator (URL) for the unique address of a web page describing the competency-based completion criteria for the achievement/award..</param>
        /// <param name="EvidenceStatement">A statement or reference describing the evidence that the learner met the criteria for attainment of the Achievement..</param>
        /// <param name="ImageURL">The Uniform Resource Locator (URL) for the unique address of an image representing an award or badge associated with the Achievement..</param>
        /// <param name="IssuerName">The name of the agent, entity, or institution issuing the element..</param>
        /// <param name="IssuerOriginURL">The Uniform Resource Locator (URL) from which the award was issued..</param>
        /// <param name="RecognitionAwardDate">The date the recognition was awarded or earned..</param>
        /// <param name="RecognitionAwardExpiresDate">Date on which the award expires..</param>
        /// <param name="RecognitionDescription">A description of the type of academic distinctions earned by or awarded to the individual..</param>
        public EdFiStudentAcademicRecordRecognition(string RecognitionTypeDescriptor = default(string), string AchievementCategoryDescriptor = default(string), string AchievementCategorySystem = default(string), string AchievementTitle = default(string), string Criteria = default(string), string CriteriaURL = default(string), string EvidenceStatement = default(string), string ImageURL = default(string), string IssuerName = default(string), string IssuerOriginURL = default(string), DateTime? RecognitionAwardDate = default(DateTime?), DateTime? RecognitionAwardExpiresDate = default(DateTime?), string RecognitionDescription = default(string))
        {
            // to ensure "RecognitionTypeDescriptor" is required (not null)
            if (RecognitionTypeDescriptor == null)
            {
                throw new InvalidDataException("RecognitionTypeDescriptor is a required property for EdFiStudentAcademicRecordRecognition and cannot be null");
            }
            else
            {
                this.RecognitionTypeDescriptor = RecognitionTypeDescriptor;
            }
            this.AchievementCategoryDescriptor = AchievementCategoryDescriptor;
            this.AchievementCategorySystem = AchievementCategorySystem;
            this.AchievementTitle = AchievementTitle;
            this.Criteria = Criteria;
            this.CriteriaURL = CriteriaURL;
            this.EvidenceStatement = EvidenceStatement;
            this.ImageURL = ImageURL;
            this.IssuerName = IssuerName;
            this.IssuerOriginURL = IssuerOriginURL;
            this.RecognitionAwardDate = RecognitionAwardDate;
            this.RecognitionAwardExpiresDate = RecognitionAwardExpiresDate;
            this.RecognitionDescription = RecognitionDescription;
        }
        
        /// <summary>
        /// The nature of recognition given to the learner for accomplishments in a co-curricular, or extra-curricular activity.
        /// </summary>
        /// <value>The nature of recognition given to the learner for accomplishments in a co-curricular, or extra-curricular activity.</value>
        [DataMember(Name="recognitionTypeDescriptor", EmitDefaultValue=false)]
        public string RecognitionTypeDescriptor { get; set; }

        /// <summary>
        /// The category of achievement attributed to the learner.
        /// </summary>
        /// <value>The category of achievement attributed to the learner.</value>
        [DataMember(Name="achievementCategoryDescriptor", EmitDefaultValue=false)]
        public string AchievementCategoryDescriptor { get; set; }

        /// <summary>
        /// The system that defines the categories by which an achievement is attributed to the learner.
        /// </summary>
        /// <value>The system that defines the categories by which an achievement is attributed to the learner.</value>
        [DataMember(Name="achievementCategorySystem", EmitDefaultValue=false)]
        public string AchievementCategorySystem { get; set; }

        /// <summary>
        /// The title assigned to the achievement.
        /// </summary>
        /// <value>The title assigned to the achievement.</value>
        [DataMember(Name="achievementTitle", EmitDefaultValue=false)]
        public string AchievementTitle { get; set; }

        /// <summary>
        /// The criteria for competency-based completion of the achievement/award.
        /// </summary>
        /// <value>The criteria for competency-based completion of the achievement/award.</value>
        [DataMember(Name="criteria", EmitDefaultValue=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// The Uniform Resource Locator (URL) for the unique address of a web page describing the competency-based completion criteria for the achievement/award.
        /// </summary>
        /// <value>The Uniform Resource Locator (URL) for the unique address of a web page describing the competency-based completion criteria for the achievement/award.</value>
        [DataMember(Name="criteriaURL", EmitDefaultValue=false)]
        public string CriteriaURL { get; set; }

        /// <summary>
        /// A statement or reference describing the evidence that the learner met the criteria for attainment of the Achievement.
        /// </summary>
        /// <value>A statement or reference describing the evidence that the learner met the criteria for attainment of the Achievement.</value>
        [DataMember(Name="evidenceStatement", EmitDefaultValue=false)]
        public string EvidenceStatement { get; set; }

        /// <summary>
        /// The Uniform Resource Locator (URL) for the unique address of an image representing an award or badge associated with the Achievement.
        /// </summary>
        /// <value>The Uniform Resource Locator (URL) for the unique address of an image representing an award or badge associated with the Achievement.</value>
        [DataMember(Name="imageURL", EmitDefaultValue=false)]
        public string ImageURL { get; set; }

        /// <summary>
        /// The name of the agent, entity, or institution issuing the element.
        /// </summary>
        /// <value>The name of the agent, entity, or institution issuing the element.</value>
        [DataMember(Name="issuerName", EmitDefaultValue=false)]
        public string IssuerName { get; set; }

        /// <summary>
        /// The Uniform Resource Locator (URL) from which the award was issued.
        /// </summary>
        /// <value>The Uniform Resource Locator (URL) from which the award was issued.</value>
        [DataMember(Name="issuerOriginURL", EmitDefaultValue=false)]
        public string IssuerOriginURL { get; set; }

        /// <summary>
        /// The date the recognition was awarded or earned.
        /// </summary>
        /// <value>The date the recognition was awarded or earned.</value>
        [DataMember(Name="recognitionAwardDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? RecognitionAwardDate { get; set; }

        /// <summary>
        /// Date on which the award expires.
        /// </summary>
        /// <value>Date on which the award expires.</value>
        [DataMember(Name="recognitionAwardExpiresDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? RecognitionAwardExpiresDate { get; set; }

        /// <summary>
        /// A description of the type of academic distinctions earned by or awarded to the individual.
        /// </summary>
        /// <value>A description of the type of academic distinctions earned by or awarded to the individual.</value>
        [DataMember(Name="recognitionDescription", EmitDefaultValue=false)]
        public string RecognitionDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentAcademicRecordRecognition {\n");
            sb.Append("  RecognitionTypeDescriptor: ").Append(RecognitionTypeDescriptor).Append("\n");
            sb.Append("  AchievementCategoryDescriptor: ").Append(AchievementCategoryDescriptor).Append("\n");
            sb.Append("  AchievementCategorySystem: ").Append(AchievementCategorySystem).Append("\n");
            sb.Append("  AchievementTitle: ").Append(AchievementTitle).Append("\n");
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
            sb.Append("  CriteriaURL: ").Append(CriteriaURL).Append("\n");
            sb.Append("  EvidenceStatement: ").Append(EvidenceStatement).Append("\n");
            sb.Append("  ImageURL: ").Append(ImageURL).Append("\n");
            sb.Append("  IssuerName: ").Append(IssuerName).Append("\n");
            sb.Append("  IssuerOriginURL: ").Append(IssuerOriginURL).Append("\n");
            sb.Append("  RecognitionAwardDate: ").Append(RecognitionAwardDate).Append("\n");
            sb.Append("  RecognitionAwardExpiresDate: ").Append(RecognitionAwardExpiresDate).Append("\n");
            sb.Append("  RecognitionDescription: ").Append(RecognitionDescription).Append("\n");
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
            return this.Equals(input as EdFiStudentAcademicRecordRecognition);
        }

        /// <summary>
        /// Returns true if EdFiStudentAcademicRecordRecognition instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentAcademicRecordRecognition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentAcademicRecordRecognition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecognitionTypeDescriptor == input.RecognitionTypeDescriptor ||
                    (this.RecognitionTypeDescriptor != null &&
                    this.RecognitionTypeDescriptor.Equals(input.RecognitionTypeDescriptor))
                ) && 
                (
                    this.AchievementCategoryDescriptor == input.AchievementCategoryDescriptor ||
                    (this.AchievementCategoryDescriptor != null &&
                    this.AchievementCategoryDescriptor.Equals(input.AchievementCategoryDescriptor))
                ) && 
                (
                    this.AchievementCategorySystem == input.AchievementCategorySystem ||
                    (this.AchievementCategorySystem != null &&
                    this.AchievementCategorySystem.Equals(input.AchievementCategorySystem))
                ) && 
                (
                    this.AchievementTitle == input.AchievementTitle ||
                    (this.AchievementTitle != null &&
                    this.AchievementTitle.Equals(input.AchievementTitle))
                ) && 
                (
                    this.Criteria == input.Criteria ||
                    (this.Criteria != null &&
                    this.Criteria.Equals(input.Criteria))
                ) && 
                (
                    this.CriteriaURL == input.CriteriaURL ||
                    (this.CriteriaURL != null &&
                    this.CriteriaURL.Equals(input.CriteriaURL))
                ) && 
                (
                    this.EvidenceStatement == input.EvidenceStatement ||
                    (this.EvidenceStatement != null &&
                    this.EvidenceStatement.Equals(input.EvidenceStatement))
                ) && 
                (
                    this.ImageURL == input.ImageURL ||
                    (this.ImageURL != null &&
                    this.ImageURL.Equals(input.ImageURL))
                ) && 
                (
                    this.IssuerName == input.IssuerName ||
                    (this.IssuerName != null &&
                    this.IssuerName.Equals(input.IssuerName))
                ) && 
                (
                    this.IssuerOriginURL == input.IssuerOriginURL ||
                    (this.IssuerOriginURL != null &&
                    this.IssuerOriginURL.Equals(input.IssuerOriginURL))
                ) && 
                (
                    this.RecognitionAwardDate == input.RecognitionAwardDate ||
                    (this.RecognitionAwardDate != null &&
                    this.RecognitionAwardDate.Equals(input.RecognitionAwardDate))
                ) && 
                (
                    this.RecognitionAwardExpiresDate == input.RecognitionAwardExpiresDate ||
                    (this.RecognitionAwardExpiresDate != null &&
                    this.RecognitionAwardExpiresDate.Equals(input.RecognitionAwardExpiresDate))
                ) && 
                (
                    this.RecognitionDescription == input.RecognitionDescription ||
                    (this.RecognitionDescription != null &&
                    this.RecognitionDescription.Equals(input.RecognitionDescription))
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
                if (this.RecognitionTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.RecognitionTypeDescriptor.GetHashCode();
                if (this.AchievementCategoryDescriptor != null)
                    hashCode = hashCode * 59 + this.AchievementCategoryDescriptor.GetHashCode();
                if (this.AchievementCategorySystem != null)
                    hashCode = hashCode * 59 + this.AchievementCategorySystem.GetHashCode();
                if (this.AchievementTitle != null)
                    hashCode = hashCode * 59 + this.AchievementTitle.GetHashCode();
                if (this.Criteria != null)
                    hashCode = hashCode * 59 + this.Criteria.GetHashCode();
                if (this.CriteriaURL != null)
                    hashCode = hashCode * 59 + this.CriteriaURL.GetHashCode();
                if (this.EvidenceStatement != null)
                    hashCode = hashCode * 59 + this.EvidenceStatement.GetHashCode();
                if (this.ImageURL != null)
                    hashCode = hashCode * 59 + this.ImageURL.GetHashCode();
                if (this.IssuerName != null)
                    hashCode = hashCode * 59 + this.IssuerName.GetHashCode();
                if (this.IssuerOriginURL != null)
                    hashCode = hashCode * 59 + this.IssuerOriginURL.GetHashCode();
                if (this.RecognitionAwardDate != null)
                    hashCode = hashCode * 59 + this.RecognitionAwardDate.GetHashCode();
                if (this.RecognitionAwardExpiresDate != null)
                    hashCode = hashCode * 59 + this.RecognitionAwardExpiresDate.GetHashCode();
                if (this.RecognitionDescription != null)
                    hashCode = hashCode * 59 + this.RecognitionDescription.GetHashCode();
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
            // RecognitionTypeDescriptor (string) maxLength
            if(this.RecognitionTypeDescriptor != null && this.RecognitionTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecognitionTypeDescriptor, length must be less than 306.", new [] { "RecognitionTypeDescriptor" });
            }

            // AchievementCategoryDescriptor (string) maxLength
            if(this.AchievementCategoryDescriptor != null && this.AchievementCategoryDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AchievementCategoryDescriptor, length must be less than 306.", new [] { "AchievementCategoryDescriptor" });
            }

            // AchievementCategorySystem (string) maxLength
            if(this.AchievementCategorySystem != null && this.AchievementCategorySystem.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AchievementCategorySystem, length must be less than 60.", new [] { "AchievementCategorySystem" });
            }

            // AchievementTitle (string) maxLength
            if(this.AchievementTitle != null && this.AchievementTitle.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AchievementTitle, length must be less than 60.", new [] { "AchievementTitle" });
            }

            // Criteria (string) maxLength
            if(this.Criteria != null && this.Criteria.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Criteria, length must be less than 150.", new [] { "Criteria" });
            }

            // CriteriaURL (string) maxLength
            if(this.CriteriaURL != null && this.CriteriaURL.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CriteriaURL, length must be less than 255.", new [] { "CriteriaURL" });
            }

            // EvidenceStatement (string) maxLength
            if(this.EvidenceStatement != null && this.EvidenceStatement.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvidenceStatement, length must be less than 150.", new [] { "EvidenceStatement" });
            }

            // ImageURL (string) maxLength
            if(this.ImageURL != null && this.ImageURL.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImageURL, length must be less than 255.", new [] { "ImageURL" });
            }

            // IssuerName (string) maxLength
            if(this.IssuerName != null && this.IssuerName.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssuerName, length must be less than 150.", new [] { "IssuerName" });
            }

            // IssuerOriginURL (string) maxLength
            if(this.IssuerOriginURL != null && this.IssuerOriginURL.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssuerOriginURL, length must be less than 255.", new [] { "IssuerOriginURL" });
            }

            // RecognitionDescription (string) maxLength
            if(this.RecognitionDescription != null && this.RecognitionDescription.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecognitionDescription, length must be less than 80.", new [] { "RecognitionDescription" });
            }

            yield break;
        }
    }

}
