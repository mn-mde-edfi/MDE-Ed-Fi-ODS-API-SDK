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
    /// EdFiGradeReference
    /// </summary>
    [DataContract]
    public partial class EdFiGradeReference :  IEquatable<EdFiGradeReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGradeReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiGradeReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGradeReference" /> class.
        /// </summary>
        /// <param name="BeginDate">Month, day, and year of the Student&#39;s entry or assignment to the Section. (required).</param>
        /// <param name="GradeTypeDescriptor">The type of grade reported (e.g., Exam, Final, Grading Period). (required).</param>
        /// <param name="GradingPeriodDescriptor">The name of the period for which grades are reported. (required).</param>
        /// <param name="GradingPeriodSchoolYear">The identifier for the grading period school year. (required).</param>
        /// <param name="GradingPeriodSequence">The sequential order of this period relative to other periods. (required).</param>
        /// <param name="LocalCourseCode">The local code assigned by the School that identifies the course offering provided for the instruction of students. (required).</param>
        /// <param name="SchoolId">The identifier assigned to a school. (required).</param>
        /// <param name="SchoolYear">The identifier for the school year. (required).</param>
        /// <param name="SectionIdentifier">The local identifier assigned to a section. (required).</param>
        /// <param name="SessionName">The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). (required).</param>
        /// <param name="StudentUniqueId">A unique alphanumeric code assigned to a student. (required).</param>
        /// <param name="Link">Link.</param>
        public EdFiGradeReference(DateTime? BeginDate = default(DateTime?), string GradeTypeDescriptor = default(string), string GradingPeriodDescriptor = default(string), int? GradingPeriodSchoolYear = default(int?), int? GradingPeriodSequence = default(int?), string LocalCourseCode = default(string), int? SchoolId = default(int?), int? SchoolYear = default(int?), string SectionIdentifier = default(string), string SessionName = default(string), string StudentUniqueId = default(string), Link Link = default(Link))
        {
            // to ensure "BeginDate" is required (not null)
            if (BeginDate == null)
            {
                throw new InvalidDataException("BeginDate is a required property for EdFiGradeReference and cannot be null");
            }
            else
            {
                this.BeginDate = BeginDate;
            }
            // to ensure "GradeTypeDescriptor" is required (not null)
            if (GradeTypeDescriptor == null)
            {
                throw new InvalidDataException("GradeTypeDescriptor is a required property for EdFiGradeReference and cannot be null");
            }
            else
            {
                this.GradeTypeDescriptor = GradeTypeDescriptor;
            }
            // to ensure "GradingPeriodDescriptor" is required (not null)
            if (GradingPeriodDescriptor == null)
            {
                throw new InvalidDataException("GradingPeriodDescriptor is a required property for EdFiGradeReference and cannot be null");
            }
            else
            {
                this.GradingPeriodDescriptor = GradingPeriodDescriptor;
            }
            // to ensure "GradingPeriodSchoolYear" is required (not null)
            if (GradingPeriodSchoolYear == null)
            {
                throw new InvalidDataException("GradingPeriodSchoolYear is a required property for EdFiGradeReference and cannot be null");
            }
            else
            {
                this.GradingPeriodSchoolYear = GradingPeriodSchoolYear;
            }
            // to ensure "GradingPeriodSequence" is required (not null)
            if (GradingPeriodSequence == null)
            {
                throw new InvalidDataException("GradingPeriodSequence is a required property for EdFiGradeReference and cannot be null");
            }
            else
            {
                this.GradingPeriodSequence = GradingPeriodSequence;
            }
            // to ensure "LocalCourseCode" is required (not null)
            if (LocalCourseCode == null)
            {
                throw new InvalidDataException("LocalCourseCode is a required property for EdFiGradeReference and cannot be null");
            }
            else
            {
                this.LocalCourseCode = LocalCourseCode;
            }
            // to ensure "SchoolId" is required (not null)
            if (SchoolId == null)
            {
                throw new InvalidDataException("SchoolId is a required property for EdFiGradeReference and cannot be null");
            }
            else
            {
                this.SchoolId = SchoolId;
            }
            // to ensure "SchoolYear" is required (not null)
            if (SchoolYear == null)
            {
                throw new InvalidDataException("SchoolYear is a required property for EdFiGradeReference and cannot be null");
            }
            else
            {
                this.SchoolYear = SchoolYear;
            }
            // to ensure "SectionIdentifier" is required (not null)
            if (SectionIdentifier == null)
            {
                throw new InvalidDataException("SectionIdentifier is a required property for EdFiGradeReference and cannot be null");
            }
            else
            {
                this.SectionIdentifier = SectionIdentifier;
            }
            // to ensure "SessionName" is required (not null)
            if (SessionName == null)
            {
                throw new InvalidDataException("SessionName is a required property for EdFiGradeReference and cannot be null");
            }
            else
            {
                this.SessionName = SessionName;
            }
            // to ensure "StudentUniqueId" is required (not null)
            if (StudentUniqueId == null)
            {
                throw new InvalidDataException("StudentUniqueId is a required property for EdFiGradeReference and cannot be null");
            }
            else
            {
                this.StudentUniqueId = StudentUniqueId;
            }
            this.Link = Link;
        }
        
        /// <summary>
        /// Month, day, and year of the Student&#39;s entry or assignment to the Section.
        /// </summary>
        /// <value>Month, day, and year of the Student&#39;s entry or assignment to the Section.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// The type of grade reported (e.g., Exam, Final, Grading Period).
        /// </summary>
        /// <value>The type of grade reported (e.g., Exam, Final, Grading Period).</value>
        [DataMember(Name="gradeTypeDescriptor", EmitDefaultValue=false)]
        public string GradeTypeDescriptor { get; set; }

        /// <summary>
        /// The name of the period for which grades are reported.
        /// </summary>
        /// <value>The name of the period for which grades are reported.</value>
        [DataMember(Name="gradingPeriodDescriptor", EmitDefaultValue=false)]
        public string GradingPeriodDescriptor { get; set; }

        /// <summary>
        /// The identifier for the grading period school year.
        /// </summary>
        /// <value>The identifier for the grading period school year.</value>
        [DataMember(Name="gradingPeriodSchoolYear", EmitDefaultValue=false)]
        public int? GradingPeriodSchoolYear { get; set; }

        /// <summary>
        /// The sequential order of this period relative to other periods.
        /// </summary>
        /// <value>The sequential order of this period relative to other periods.</value>
        [DataMember(Name="gradingPeriodSequence", EmitDefaultValue=false)]
        public int? GradingPeriodSequence { get; set; }

        /// <summary>
        /// The local code assigned by the School that identifies the course offering provided for the instruction of students.
        /// </summary>
        /// <value>The local code assigned by the School that identifies the course offering provided for the instruction of students.</value>
        [DataMember(Name="localCourseCode", EmitDefaultValue=false)]
        public string LocalCourseCode { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name="schoolId", EmitDefaultValue=false)]
        public int? SchoolId { get; set; }

        /// <summary>
        /// The identifier for the school year.
        /// </summary>
        /// <value>The identifier for the school year.</value>
        [DataMember(Name="schoolYear", EmitDefaultValue=false)]
        public int? SchoolYear { get; set; }

        /// <summary>
        /// The local identifier assigned to a section.
        /// </summary>
        /// <value>The local identifier assigned to a section.</value>
        [DataMember(Name="sectionIdentifier", EmitDefaultValue=false)]
        public string SectionIdentifier { get; set; }

        /// <summary>
        /// The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer).
        /// </summary>
        /// <value>The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer).</value>
        [DataMember(Name="sessionName", EmitDefaultValue=false)]
        public string SessionName { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [DataMember(Name="studentUniqueId", EmitDefaultValue=false)]
        public string StudentUniqueId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiGradeReference {\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  GradeTypeDescriptor: ").Append(GradeTypeDescriptor).Append("\n");
            sb.Append("  GradingPeriodDescriptor: ").Append(GradingPeriodDescriptor).Append("\n");
            sb.Append("  GradingPeriodSchoolYear: ").Append(GradingPeriodSchoolYear).Append("\n");
            sb.Append("  GradingPeriodSequence: ").Append(GradingPeriodSequence).Append("\n");
            sb.Append("  LocalCourseCode: ").Append(LocalCourseCode).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  SchoolYear: ").Append(SchoolYear).Append("\n");
            sb.Append("  SectionIdentifier: ").Append(SectionIdentifier).Append("\n");
            sb.Append("  SessionName: ").Append(SessionName).Append("\n");
            sb.Append("  StudentUniqueId: ").Append(StudentUniqueId).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as EdFiGradeReference);
        }

        /// <summary>
        /// Returns true if EdFiGradeReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiGradeReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiGradeReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.GradeTypeDescriptor == input.GradeTypeDescriptor ||
                    (this.GradeTypeDescriptor != null &&
                    this.GradeTypeDescriptor.Equals(input.GradeTypeDescriptor))
                ) && 
                (
                    this.GradingPeriodDescriptor == input.GradingPeriodDescriptor ||
                    (this.GradingPeriodDescriptor != null &&
                    this.GradingPeriodDescriptor.Equals(input.GradingPeriodDescriptor))
                ) && 
                (
                    this.GradingPeriodSchoolYear == input.GradingPeriodSchoolYear ||
                    (this.GradingPeriodSchoolYear != null &&
                    this.GradingPeriodSchoolYear.Equals(input.GradingPeriodSchoolYear))
                ) && 
                (
                    this.GradingPeriodSequence == input.GradingPeriodSequence ||
                    (this.GradingPeriodSequence != null &&
                    this.GradingPeriodSequence.Equals(input.GradingPeriodSequence))
                ) && 
                (
                    this.LocalCourseCode == input.LocalCourseCode ||
                    (this.LocalCourseCode != null &&
                    this.LocalCourseCode.Equals(input.LocalCourseCode))
                ) && 
                (
                    this.SchoolId == input.SchoolId ||
                    (this.SchoolId != null &&
                    this.SchoolId.Equals(input.SchoolId))
                ) && 
                (
                    this.SchoolYear == input.SchoolYear ||
                    (this.SchoolYear != null &&
                    this.SchoolYear.Equals(input.SchoolYear))
                ) && 
                (
                    this.SectionIdentifier == input.SectionIdentifier ||
                    (this.SectionIdentifier != null &&
                    this.SectionIdentifier.Equals(input.SectionIdentifier))
                ) && 
                (
                    this.SessionName == input.SessionName ||
                    (this.SessionName != null &&
                    this.SessionName.Equals(input.SessionName))
                ) && 
                (
                    this.StudentUniqueId == input.StudentUniqueId ||
                    (this.StudentUniqueId != null &&
                    this.StudentUniqueId.Equals(input.StudentUniqueId))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                if (this.BeginDate != null)
                    hashCode = hashCode * 59 + this.BeginDate.GetHashCode();
                if (this.GradeTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.GradeTypeDescriptor.GetHashCode();
                if (this.GradingPeriodDescriptor != null)
                    hashCode = hashCode * 59 + this.GradingPeriodDescriptor.GetHashCode();
                if (this.GradingPeriodSchoolYear != null)
                    hashCode = hashCode * 59 + this.GradingPeriodSchoolYear.GetHashCode();
                if (this.GradingPeriodSequence != null)
                    hashCode = hashCode * 59 + this.GradingPeriodSequence.GetHashCode();
                if (this.LocalCourseCode != null)
                    hashCode = hashCode * 59 + this.LocalCourseCode.GetHashCode();
                if (this.SchoolId != null)
                    hashCode = hashCode * 59 + this.SchoolId.GetHashCode();
                if (this.SchoolYear != null)
                    hashCode = hashCode * 59 + this.SchoolYear.GetHashCode();
                if (this.SectionIdentifier != null)
                    hashCode = hashCode * 59 + this.SectionIdentifier.GetHashCode();
                if (this.SessionName != null)
                    hashCode = hashCode * 59 + this.SessionName.GetHashCode();
                if (this.StudentUniqueId != null)
                    hashCode = hashCode * 59 + this.StudentUniqueId.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
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
            // GradeTypeDescriptor (string) maxLength
            if(this.GradeTypeDescriptor != null && this.GradeTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GradeTypeDescriptor, length must be less than 306.", new [] { "GradeTypeDescriptor" });
            }

            // GradingPeriodDescriptor (string) maxLength
            if(this.GradingPeriodDescriptor != null && this.GradingPeriodDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GradingPeriodDescriptor, length must be less than 306.", new [] { "GradingPeriodDescriptor" });
            }

            // LocalCourseCode (string) maxLength
            if(this.LocalCourseCode != null && this.LocalCourseCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocalCourseCode, length must be less than 60.", new [] { "LocalCourseCode" });
            }

            // SectionIdentifier (string) maxLength
            if(this.SectionIdentifier != null && this.SectionIdentifier.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionIdentifier, length must be less than 255.", new [] { "SectionIdentifier" });
            }

            // SessionName (string) maxLength
            if(this.SessionName != null && this.SessionName.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SessionName, length must be less than 60.", new [] { "SessionName" });
            }

            // StudentUniqueId (string) maxLength
            if(this.StudentUniqueId != null && this.StudentUniqueId.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentUniqueId, length must be less than 32.", new [] { "StudentUniqueId" });
            }

            yield break;
        }
    }

}