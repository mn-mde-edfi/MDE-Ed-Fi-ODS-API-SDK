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
    /// EdFiStudentAcademicRecordAcademicHonor
    /// </summary>
    [DataContract]
    public partial class EdFiStudentAcademicRecordAcademicHonor :  IEquatable<EdFiStudentAcademicRecordAcademicHonor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAcademicRecordAcademicHonor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentAcademicRecordAcademicHonor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAcademicRecordAcademicHonor" /> class.
        /// </summary>
        /// <param name="academicHonorCategoryDescriptor">A designation of the type of academic distinctions earned by or awarded to the student. (required).</param>
        /// <param name="honorDescription">A description of the type of academic distinctions earned by or awarded to the individual. (required).</param>
        /// <param name="achievementCategoryDescriptor">The category of achievement attributed to the learner..</param>
        /// <param name="achievementCategorySystem">The system that defines the categories by which an achievement is attributed to the learner..</param>
        /// <param name="achievementTitle">The title assigned to the achievement..</param>
        /// <param name="criteria">The criteria for competency-based completion of the achievement/award..</param>
        /// <param name="criteriaURL">The Uniform Resource Locator (URL) for the unique address of a web page describing the competency-based completion criteria for the achievement/award..</param>
        /// <param name="evidenceStatement">A statement or reference describing the evidence that the learner met the criteria for attainment of the Achievement..</param>
        /// <param name="honorAwardDate">The date the honor was awarded or earned..</param>
        /// <param name="honorAwardExpiresDate">Date on which the award expires..</param>
        /// <param name="imageURL">The Uniform Resource Locator (URL) for the unique address of an image representing an award or badge associated with the Achievement..</param>
        /// <param name="issuerName">The name of the agent, entity, or institution issuing the element..</param>
        /// <param name="issuerOriginURL">The Uniform Resource Locator (URL) from which the award was issued..</param>
        public EdFiStudentAcademicRecordAcademicHonor(string academicHonorCategoryDescriptor = default(string), string honorDescription = default(string), string achievementCategoryDescriptor = default(string), string achievementCategorySystem = default(string), string achievementTitle = default(string), string criteria = default(string), string criteriaURL = default(string), string evidenceStatement = default(string), DateTime? honorAwardDate = default(DateTime?), DateTime? honorAwardExpiresDate = default(DateTime?), string imageURL = default(string), string issuerName = default(string), string issuerOriginURL = default(string))
        {
            // to ensure "academicHonorCategoryDescriptor" is required (not null)
            if (academicHonorCategoryDescriptor == null)
            {
                throw new InvalidDataException("academicHonorCategoryDescriptor is a required property for EdFiStudentAcademicRecordAcademicHonor and cannot be null");
            }
            else
            {
                this.AcademicHonorCategoryDescriptor = academicHonorCategoryDescriptor;
            }
            // to ensure "honorDescription" is required (not null)
            if (honorDescription == null)
            {
                throw new InvalidDataException("honorDescription is a required property for EdFiStudentAcademicRecordAcademicHonor and cannot be null");
            }
            else
            {
                this.HonorDescription = honorDescription;
            }
            this.AchievementCategoryDescriptor = achievementCategoryDescriptor;
            this.AchievementCategorySystem = achievementCategorySystem;
            this.AchievementTitle = achievementTitle;
            this.Criteria = criteria;
            this.CriteriaURL = criteriaURL;
            this.EvidenceStatement = evidenceStatement;
            this.HonorAwardDate = honorAwardDate;
            this.HonorAwardExpiresDate = honorAwardExpiresDate;
            this.ImageURL = imageURL;
            this.IssuerName = issuerName;
            this.IssuerOriginURL = issuerOriginURL;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentAcademicRecordAcademicHonor {\n");
            sb.Append("  AcademicHonorCategoryDescriptor: ").Append(AcademicHonorCategoryDescriptor).Append("\n");
            sb.Append("  HonorDescription: ").Append(HonorDescription).Append("\n");
            sb.Append("  AchievementCategoryDescriptor: ").Append(AchievementCategoryDescriptor).Append("\n");
            sb.Append("  AchievementCategorySystem: ").Append(AchievementCategorySystem).Append("\n");
            sb.Append("  AchievementTitle: ").Append(AchievementTitle).Append("\n");
            sb.Append("  Criteria: ").Append(Criteria).Append("\n");
            sb.Append("  CriteriaURL: ").Append(CriteriaURL).Append("\n");
            sb.Append("  EvidenceStatement: ").Append(EvidenceStatement).Append("\n");
            sb.Append("  HonorAwardDate: ").Append(HonorAwardDate).Append("\n");
            sb.Append("  HonorAwardExpiresDate: ").Append(HonorAwardExpiresDate).Append("\n");
            sb.Append("  ImageURL: ").Append(ImageURL).Append("\n");
            sb.Append("  IssuerName: ").Append(IssuerName).Append("\n");
            sb.Append("  IssuerOriginURL: ").Append(IssuerOriginURL).Append("\n");
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
            return this.Equals(input as EdFiStudentAcademicRecordAcademicHonor);
        }

        /// <summary>
        /// Returns true if EdFiStudentAcademicRecordAcademicHonor instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentAcademicRecordAcademicHonor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentAcademicRecordAcademicHonor input)
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
                if (this.HonorAwardDate != null)
                    hashCode = hashCode * 59 + this.HonorAwardDate.GetHashCode();
                if (this.HonorAwardExpiresDate != null)
                    hashCode = hashCode * 59 + this.HonorAwardExpiresDate.GetHashCode();
                if (this.ImageURL != null)
                    hashCode = hashCode * 59 + this.ImageURL.GetHashCode();
                if (this.IssuerName != null)
                    hashCode = hashCode * 59 + this.IssuerName.GetHashCode();
                if (this.IssuerOriginURL != null)
                    hashCode = hashCode * 59 + this.IssuerOriginURL.GetHashCode();
                return hashCode;
            }
        }
    }

}
