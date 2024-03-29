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
    /// EdFiOpenStaffPosition
    /// </summary>
    [DataContract]
    public partial class EdFiOpenStaffPosition :  IEquatable<EdFiOpenStaffPosition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiOpenStaffPosition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiOpenStaffPosition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiOpenStaffPosition" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="RequisitionNumber">The number or identifier assigned to an open staff position, typically a requisition number assigned by Human Resources. (required).</param>
        /// <param name="EducationOrganizationReference">EducationOrganizationReference (required).</param>
        /// <param name="AcademicSubjects">An unordered collection of openStaffPositionAcademicSubjects. The teaching field required for the OpenStaffPosition, for example English/Language Arts, Reading, Mathematics, Science, Social Sciences, etc..</param>
        /// <param name="DatePosted">Date the OpenStaffPosition was posted. (required).</param>
        /// <param name="DatePostingRemoved">The date the posting was removed or filled..</param>
        /// <param name="EmploymentStatusDescriptor">Reflects the type of employment or contract desired for the position; for example:          Probationary          Contractual          Substitute/temporary          Tenured or permanent          Volunteer/no contract          ... (required).</param>
        /// <param name="InstructionalGradeLevels">An unordered collection of openStaffPositionInstructionalGradeLevels. The set of grade levels for which the position&#39;s assignment is responsible..</param>
        /// <param name="PositionTitle">The descriptive name of an individual&#39;s position..</param>
        /// <param name="PostingResultDescriptor">Indication of whether the OpenStaffPosition was filled or retired without filling..</param>
        /// <param name="ProgramAssignmentDescriptor">The name of the program for which the OpenStaffPosition will be assigned; for example:          Regular education          Title I-Academic          Title I-Non-Academic          Special Education&#39;          Bilingual/English as a Second Language..</param>
        /// <param name="StaffClassificationDescriptor">The titles of employment, official status, or rank of education staff. (required).</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiOpenStaffPosition(string Id = default(string), string RequisitionNumber = default(string), EdFiEducationOrganizationReference EducationOrganizationReference = default(EdFiEducationOrganizationReference), List<EdFiOpenStaffPositionAcademicSubject> AcademicSubjects = default(List<EdFiOpenStaffPositionAcademicSubject>), DateTime? DatePosted = default(DateTime?), DateTime? DatePostingRemoved = default(DateTime?), string EmploymentStatusDescriptor = default(string), List<EdFiOpenStaffPositionInstructionalGradeLevel> InstructionalGradeLevels = default(List<EdFiOpenStaffPositionInstructionalGradeLevel>), string PositionTitle = default(string), string PostingResultDescriptor = default(string), string ProgramAssignmentDescriptor = default(string), string StaffClassificationDescriptor = default(string), string Etag = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiOpenStaffPosition and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "RequisitionNumber" is required (not null)
            if (RequisitionNumber == null)
            {
                throw new InvalidDataException("RequisitionNumber is a required property for EdFiOpenStaffPosition and cannot be null");
            }
            else
            {
                this.RequisitionNumber = RequisitionNumber;
            }
            // to ensure "EducationOrganizationReference" is required (not null)
            if (EducationOrganizationReference == null)
            {
                throw new InvalidDataException("EducationOrganizationReference is a required property for EdFiOpenStaffPosition and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = EducationOrganizationReference;
            }
            // to ensure "DatePosted" is required (not null)
            if (DatePosted == null)
            {
                throw new InvalidDataException("DatePosted is a required property for EdFiOpenStaffPosition and cannot be null");
            }
            else
            {
                this.DatePosted = DatePosted;
            }
            // to ensure "EmploymentStatusDescriptor" is required (not null)
            if (EmploymentStatusDescriptor == null)
            {
                throw new InvalidDataException("EmploymentStatusDescriptor is a required property for EdFiOpenStaffPosition and cannot be null");
            }
            else
            {
                this.EmploymentStatusDescriptor = EmploymentStatusDescriptor;
            }
            // to ensure "StaffClassificationDescriptor" is required (not null)
            if (StaffClassificationDescriptor == null)
            {
                throw new InvalidDataException("StaffClassificationDescriptor is a required property for EdFiOpenStaffPosition and cannot be null");
            }
            else
            {
                this.StaffClassificationDescriptor = StaffClassificationDescriptor;
            }
            this.AcademicSubjects = AcademicSubjects;
            this.DatePostingRemoved = DatePostingRemoved;
            this.InstructionalGradeLevels = InstructionalGradeLevels;
            this.PositionTitle = PositionTitle;
            this.PostingResultDescriptor = PostingResultDescriptor;
            this.ProgramAssignmentDescriptor = ProgramAssignmentDescriptor;
            this.Etag = Etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The number or identifier assigned to an open staff position, typically a requisition number assigned by Human Resources.
        /// </summary>
        /// <value>The number or identifier assigned to an open staff position, typically a requisition number assigned by Human Resources.</value>
        [DataMember(Name="requisitionNumber", EmitDefaultValue=false)]
        public string RequisitionNumber { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name="educationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// An unordered collection of openStaffPositionAcademicSubjects. The teaching field required for the OpenStaffPosition, for example English/Language Arts, Reading, Mathematics, Science, Social Sciences, etc.
        /// </summary>
        /// <value>An unordered collection of openStaffPositionAcademicSubjects. The teaching field required for the OpenStaffPosition, for example English/Language Arts, Reading, Mathematics, Science, Social Sciences, etc.</value>
        [DataMember(Name="academicSubjects", EmitDefaultValue=false)]
        public List<EdFiOpenStaffPositionAcademicSubject> AcademicSubjects { get; set; }

        /// <summary>
        /// Date the OpenStaffPosition was posted.
        /// </summary>
        /// <value>Date the OpenStaffPosition was posted.</value>
        [DataMember(Name="datePosted", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DatePosted { get; set; }

        /// <summary>
        /// The date the posting was removed or filled.
        /// </summary>
        /// <value>The date the posting was removed or filled.</value>
        [DataMember(Name="datePostingRemoved", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DatePostingRemoved { get; set; }

        /// <summary>
        /// Reflects the type of employment or contract desired for the position; for example:          Probationary          Contractual          Substitute/temporary          Tenured or permanent          Volunteer/no contract          ...
        /// </summary>
        /// <value>Reflects the type of employment or contract desired for the position; for example:          Probationary          Contractual          Substitute/temporary          Tenured or permanent          Volunteer/no contract          ...</value>
        [DataMember(Name="employmentStatusDescriptor", EmitDefaultValue=false)]
        public string EmploymentStatusDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of openStaffPositionInstructionalGradeLevels. The set of grade levels for which the position&#39;s assignment is responsible.
        /// </summary>
        /// <value>An unordered collection of openStaffPositionInstructionalGradeLevels. The set of grade levels for which the position&#39;s assignment is responsible.</value>
        [DataMember(Name="instructionalGradeLevels", EmitDefaultValue=false)]
        public List<EdFiOpenStaffPositionInstructionalGradeLevel> InstructionalGradeLevels { get; set; }

        /// <summary>
        /// The descriptive name of an individual&#39;s position.
        /// </summary>
        /// <value>The descriptive name of an individual&#39;s position.</value>
        [DataMember(Name="positionTitle", EmitDefaultValue=false)]
        public string PositionTitle { get; set; }

        /// <summary>
        /// Indication of whether the OpenStaffPosition was filled or retired without filling.
        /// </summary>
        /// <value>Indication of whether the OpenStaffPosition was filled or retired without filling.</value>
        [DataMember(Name="postingResultDescriptor", EmitDefaultValue=false)]
        public string PostingResultDescriptor { get; set; }

        /// <summary>
        /// The name of the program for which the OpenStaffPosition will be assigned; for example:          Regular education          Title I-Academic          Title I-Non-Academic          Special Education&#39;          Bilingual/English as a Second Language.
        /// </summary>
        /// <value>The name of the program for which the OpenStaffPosition will be assigned; for example:          Regular education          Title I-Academic          Title I-Non-Academic          Special Education&#39;          Bilingual/English as a Second Language.</value>
        [DataMember(Name="programAssignmentDescriptor", EmitDefaultValue=false)]
        public string ProgramAssignmentDescriptor { get; set; }

        /// <summary>
        /// The titles of employment, official status, or rank of education staff.
        /// </summary>
        /// <value>The titles of employment, official status, or rank of education staff.</value>
        [DataMember(Name="staffClassificationDescriptor", EmitDefaultValue=false)]
        public string StaffClassificationDescriptor { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiOpenStaffPosition {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RequisitionNumber: ").Append(RequisitionNumber).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  AcademicSubjects: ").Append(AcademicSubjects).Append("\n");
            sb.Append("  DatePosted: ").Append(DatePosted).Append("\n");
            sb.Append("  DatePostingRemoved: ").Append(DatePostingRemoved).Append("\n");
            sb.Append("  EmploymentStatusDescriptor: ").Append(EmploymentStatusDescriptor).Append("\n");
            sb.Append("  InstructionalGradeLevels: ").Append(InstructionalGradeLevels).Append("\n");
            sb.Append("  PositionTitle: ").Append(PositionTitle).Append("\n");
            sb.Append("  PostingResultDescriptor: ").Append(PostingResultDescriptor).Append("\n");
            sb.Append("  ProgramAssignmentDescriptor: ").Append(ProgramAssignmentDescriptor).Append("\n");
            sb.Append("  StaffClassificationDescriptor: ").Append(StaffClassificationDescriptor).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            return this.Equals(input as EdFiOpenStaffPosition);
        }

        /// <summary>
        /// Returns true if EdFiOpenStaffPosition instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiOpenStaffPosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiOpenStaffPosition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RequisitionNumber == input.RequisitionNumber ||
                    (this.RequisitionNumber != null &&
                    this.RequisitionNumber.Equals(input.RequisitionNumber))
                ) && 
                (
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.AcademicSubjects == input.AcademicSubjects ||
                    this.AcademicSubjects != null &&
                    this.AcademicSubjects.SequenceEqual(input.AcademicSubjects)
                ) && 
                (
                    this.DatePosted == input.DatePosted ||
                    (this.DatePosted != null &&
                    this.DatePosted.Equals(input.DatePosted))
                ) && 
                (
                    this.DatePostingRemoved == input.DatePostingRemoved ||
                    (this.DatePostingRemoved != null &&
                    this.DatePostingRemoved.Equals(input.DatePostingRemoved))
                ) && 
                (
                    this.EmploymentStatusDescriptor == input.EmploymentStatusDescriptor ||
                    (this.EmploymentStatusDescriptor != null &&
                    this.EmploymentStatusDescriptor.Equals(input.EmploymentStatusDescriptor))
                ) && 
                (
                    this.InstructionalGradeLevels == input.InstructionalGradeLevels ||
                    this.InstructionalGradeLevels != null &&
                    this.InstructionalGradeLevels.SequenceEqual(input.InstructionalGradeLevels)
                ) && 
                (
                    this.PositionTitle == input.PositionTitle ||
                    (this.PositionTitle != null &&
                    this.PositionTitle.Equals(input.PositionTitle))
                ) && 
                (
                    this.PostingResultDescriptor == input.PostingResultDescriptor ||
                    (this.PostingResultDescriptor != null &&
                    this.PostingResultDescriptor.Equals(input.PostingResultDescriptor))
                ) && 
                (
                    this.ProgramAssignmentDescriptor == input.ProgramAssignmentDescriptor ||
                    (this.ProgramAssignmentDescriptor != null &&
                    this.ProgramAssignmentDescriptor.Equals(input.ProgramAssignmentDescriptor))
                ) && 
                (
                    this.StaffClassificationDescriptor == input.StaffClassificationDescriptor ||
                    (this.StaffClassificationDescriptor != null &&
                    this.StaffClassificationDescriptor.Equals(input.StaffClassificationDescriptor))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RequisitionNumber != null)
                    hashCode = hashCode * 59 + this.RequisitionNumber.GetHashCode();
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.AcademicSubjects != null)
                    hashCode = hashCode * 59 + this.AcademicSubjects.GetHashCode();
                if (this.DatePosted != null)
                    hashCode = hashCode * 59 + this.DatePosted.GetHashCode();
                if (this.DatePostingRemoved != null)
                    hashCode = hashCode * 59 + this.DatePostingRemoved.GetHashCode();
                if (this.EmploymentStatusDescriptor != null)
                    hashCode = hashCode * 59 + this.EmploymentStatusDescriptor.GetHashCode();
                if (this.InstructionalGradeLevels != null)
                    hashCode = hashCode * 59 + this.InstructionalGradeLevels.GetHashCode();
                if (this.PositionTitle != null)
                    hashCode = hashCode * 59 + this.PositionTitle.GetHashCode();
                if (this.PostingResultDescriptor != null)
                    hashCode = hashCode * 59 + this.PostingResultDescriptor.GetHashCode();
                if (this.ProgramAssignmentDescriptor != null)
                    hashCode = hashCode * 59 + this.ProgramAssignmentDescriptor.GetHashCode();
                if (this.StaffClassificationDescriptor != null)
                    hashCode = hashCode * 59 + this.StaffClassificationDescriptor.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
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
            // RequisitionNumber (string) maxLength
            if(this.RequisitionNumber != null && this.RequisitionNumber.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RequisitionNumber, length must be less than 20.", new [] { "RequisitionNumber" });
            }

            // EmploymentStatusDescriptor (string) maxLength
            if(this.EmploymentStatusDescriptor != null && this.EmploymentStatusDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmploymentStatusDescriptor, length must be less than 306.", new [] { "EmploymentStatusDescriptor" });
            }

            // PositionTitle (string) maxLength
            if(this.PositionTitle != null && this.PositionTitle.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PositionTitle, length must be less than 100.", new [] { "PositionTitle" });
            }

            // PostingResultDescriptor (string) maxLength
            if(this.PostingResultDescriptor != null && this.PostingResultDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostingResultDescriptor, length must be less than 306.", new [] { "PostingResultDescriptor" });
            }

            // ProgramAssignmentDescriptor (string) maxLength
            if(this.ProgramAssignmentDescriptor != null && this.ProgramAssignmentDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramAssignmentDescriptor, length must be less than 306.", new [] { "ProgramAssignmentDescriptor" });
            }

            // StaffClassificationDescriptor (string) maxLength
            if(this.StaffClassificationDescriptor != null && this.StaffClassificationDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StaffClassificationDescriptor, length must be less than 306.", new [] { "StaffClassificationDescriptor" });
            }

            yield break;
        }
    }

}
