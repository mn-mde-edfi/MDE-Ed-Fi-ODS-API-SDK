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
    /// EdFiCourseTranscript
    /// </summary>
    [DataContract]
    public partial class EdFiCourseTranscript :  IEquatable<EdFiCourseTranscript>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseTranscript" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCourseTranscript() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseTranscript" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="CourseAttemptResultDescriptor">The result from the student&#39;s attempt to take the course, for example:          Pass          Fail          Incomplete          Withdrawn. (required).</param>
        /// <param name="CourseReference">CourseReference (required).</param>
        /// <param name="ExternalEducationOrganizationReference">ExternalEducationOrganizationReference.</param>
        /// <param name="StudentAcademicRecordReference">StudentAcademicRecordReference (required).</param>
        /// <param name="AlternativeCourseCode">The local code assigned by the school that identifies the course offering, the code from an external educational organization, or other alternate course code..</param>
        /// <param name="AlternativeCourseTitle">The descriptive name given to a course of study offered in the school, if different from the CourseTitle..</param>
        /// <param name="AttemptedCreditConversion">Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units..</param>
        /// <param name="AttemptedCredits">The value of credits or units of value awarded for the completion of a course..</param>
        /// <param name="AttemptedCreditTypeDescriptor">The type of credits or units of value awarded for the completion of a course..</param>
        /// <param name="CourseRepeatCodeDescriptor">Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student&#39;s academic grade average..</param>
        /// <param name="CourseTitle">The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, language arts)..</param>
        /// <param name="EarnedAdditionalCredits">An unordered collection of courseTranscriptEarnedAdditionalCredits. The number of additional credits a student attempted and could earn for successfully completing a given course (e.g., dual credit, AP, IB)..</param>
        /// <param name="EarnedCreditConversion">Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units..</param>
        /// <param name="EarnedCredits">The value of credits or units of value awarded for the completion of a course. (required).</param>
        /// <param name="EarnedCreditTypeDescriptor">The type of credits or units of value awarded for the completion of a course..</param>
        /// <param name="FinalLetterGradeEarned">The final indicator of student performance in a class as submitted by the instructor..</param>
        /// <param name="FinalNumericGradeEarned">The final indicator of student performance in a class as submitted by the instructor..</param>
        /// <param name="MethodCreditEarnedDescriptor">The method the credits were earned (e.g., Classroom, Examination, Transfer)..</param>
        /// <param name="WhenTakenGradeLevelDescriptor">Student&#39;s grade level at time of course..</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiCourseTranscript(string Id = default(string), string CourseAttemptResultDescriptor = default(string), EdFiCourseReference CourseReference = default(EdFiCourseReference), EdFiEducationOrganizationReference ExternalEducationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiStudentAcademicRecordReference StudentAcademicRecordReference = default(EdFiStudentAcademicRecordReference), string AlternativeCourseCode = default(string), string AlternativeCourseTitle = default(string), double? AttemptedCreditConversion = default(double?), double? AttemptedCredits = default(double?), string AttemptedCreditTypeDescriptor = default(string), string CourseRepeatCodeDescriptor = default(string), string CourseTitle = default(string), List<EdFiCourseTranscriptEarnedAdditionalCredits> EarnedAdditionalCredits = default(List<EdFiCourseTranscriptEarnedAdditionalCredits>), double? EarnedCreditConversion = default(double?), double? EarnedCredits = default(double?), string EarnedCreditTypeDescriptor = default(string), string FinalLetterGradeEarned = default(string), double? FinalNumericGradeEarned = default(double?), string MethodCreditEarnedDescriptor = default(string), string WhenTakenGradeLevelDescriptor = default(string), string Etag = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiCourseTranscript and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "CourseAttemptResultDescriptor" is required (not null)
            if (CourseAttemptResultDescriptor == null)
            {
                throw new InvalidDataException("CourseAttemptResultDescriptor is a required property for EdFiCourseTranscript and cannot be null");
            }
            else
            {
                this.CourseAttemptResultDescriptor = CourseAttemptResultDescriptor;
            }
            // to ensure "CourseReference" is required (not null)
            if (CourseReference == null)
            {
                throw new InvalidDataException("CourseReference is a required property for EdFiCourseTranscript and cannot be null");
            }
            else
            {
                this.CourseReference = CourseReference;
            }
            // to ensure "StudentAcademicRecordReference" is required (not null)
            if (StudentAcademicRecordReference == null)
            {
                throw new InvalidDataException("StudentAcademicRecordReference is a required property for EdFiCourseTranscript and cannot be null");
            }
            else
            {
                this.StudentAcademicRecordReference = StudentAcademicRecordReference;
            }
            // to ensure "EarnedCredits" is required (not null)
            if (EarnedCredits == null)
            {
                throw new InvalidDataException("EarnedCredits is a required property for EdFiCourseTranscript and cannot be null");
            }
            else
            {
                this.EarnedCredits = EarnedCredits;
            }
            this.ExternalEducationOrganizationReference = ExternalEducationOrganizationReference;
            this.AlternativeCourseCode = AlternativeCourseCode;
            this.AlternativeCourseTitle = AlternativeCourseTitle;
            this.AttemptedCreditConversion = AttemptedCreditConversion;
            this.AttemptedCredits = AttemptedCredits;
            this.AttemptedCreditTypeDescriptor = AttemptedCreditTypeDescriptor;
            this.CourseRepeatCodeDescriptor = CourseRepeatCodeDescriptor;
            this.CourseTitle = CourseTitle;
            this.EarnedAdditionalCredits = EarnedAdditionalCredits;
            this.EarnedCreditConversion = EarnedCreditConversion;
            this.EarnedCreditTypeDescriptor = EarnedCreditTypeDescriptor;
            this.FinalLetterGradeEarned = FinalLetterGradeEarned;
            this.FinalNumericGradeEarned = FinalNumericGradeEarned;
            this.MethodCreditEarnedDescriptor = MethodCreditEarnedDescriptor;
            this.WhenTakenGradeLevelDescriptor = WhenTakenGradeLevelDescriptor;
            this.Etag = Etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The result from the student&#39;s attempt to take the course, for example:          Pass          Fail          Incomplete          Withdrawn.
        /// </summary>
        /// <value>The result from the student&#39;s attempt to take the course, for example:          Pass          Fail          Incomplete          Withdrawn.</value>
        [DataMember(Name="courseAttemptResultDescriptor", EmitDefaultValue=false)]
        public string CourseAttemptResultDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets CourseReference
        /// </summary>
        [DataMember(Name="courseReference", EmitDefaultValue=false)]
        public EdFiCourseReference CourseReference { get; set; }

        /// <summary>
        /// Gets or Sets ExternalEducationOrganizationReference
        /// </summary>
        [DataMember(Name="externalEducationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference ExternalEducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentAcademicRecordReference
        /// </summary>
        [DataMember(Name="studentAcademicRecordReference", EmitDefaultValue=false)]
        public EdFiStudentAcademicRecordReference StudentAcademicRecordReference { get; set; }

        /// <summary>
        /// The local code assigned by the school that identifies the course offering, the code from an external educational organization, or other alternate course code.
        /// </summary>
        /// <value>The local code assigned by the school that identifies the course offering, the code from an external educational organization, or other alternate course code.</value>
        [DataMember(Name="alternativeCourseCode", EmitDefaultValue=false)]
        public string AlternativeCourseCode { get; set; }

        /// <summary>
        /// The descriptive name given to a course of study offered in the school, if different from the CourseTitle.
        /// </summary>
        /// <value>The descriptive name given to a course of study offered in the school, if different from the CourseTitle.</value>
        [DataMember(Name="alternativeCourseTitle", EmitDefaultValue=false)]
        public string AlternativeCourseTitle { get; set; }

        /// <summary>
        /// Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.
        /// </summary>
        /// <value>Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.</value>
        [DataMember(Name="attemptedCreditConversion", EmitDefaultValue=false)]
        public double? AttemptedCreditConversion { get; set; }

        /// <summary>
        /// The value of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The value of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="attemptedCredits", EmitDefaultValue=false)]
        public double? AttemptedCredits { get; set; }

        /// <summary>
        /// The type of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The type of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="attemptedCreditTypeDescriptor", EmitDefaultValue=false)]
        public string AttemptedCreditTypeDescriptor { get; set; }

        /// <summary>
        /// Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student&#39;s academic grade average.
        /// </summary>
        /// <value>Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student&#39;s academic grade average.</value>
        [DataMember(Name="courseRepeatCodeDescriptor", EmitDefaultValue=false)]
        public string CourseRepeatCodeDescriptor { get; set; }

        /// <summary>
        /// The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, language arts).
        /// </summary>
        /// <value>The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, language arts).</value>
        [DataMember(Name="courseTitle", EmitDefaultValue=false)]
        public string CourseTitle { get; set; }

        /// <summary>
        /// An unordered collection of courseTranscriptEarnedAdditionalCredits. The number of additional credits a student attempted and could earn for successfully completing a given course (e.g., dual credit, AP, IB).
        /// </summary>
        /// <value>An unordered collection of courseTranscriptEarnedAdditionalCredits. The number of additional credits a student attempted and could earn for successfully completing a given course (e.g., dual credit, AP, IB).</value>
        [DataMember(Name="earnedAdditionalCredits", EmitDefaultValue=false)]
        public List<EdFiCourseTranscriptEarnedAdditionalCredits> EarnedAdditionalCredits { get; set; }

        /// <summary>
        /// Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.
        /// </summary>
        /// <value>Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.</value>
        [DataMember(Name="earnedCreditConversion", EmitDefaultValue=false)]
        public double? EarnedCreditConversion { get; set; }

        /// <summary>
        /// The value of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The value of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="earnedCredits", EmitDefaultValue=false)]
        public double? EarnedCredits { get; set; }

        /// <summary>
        /// The type of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The type of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="earnedCreditTypeDescriptor", EmitDefaultValue=false)]
        public string EarnedCreditTypeDescriptor { get; set; }

        /// <summary>
        /// The final indicator of student performance in a class as submitted by the instructor.
        /// </summary>
        /// <value>The final indicator of student performance in a class as submitted by the instructor.</value>
        [DataMember(Name="finalLetterGradeEarned", EmitDefaultValue=false)]
        public string FinalLetterGradeEarned { get; set; }

        /// <summary>
        /// The final indicator of student performance in a class as submitted by the instructor.
        /// </summary>
        /// <value>The final indicator of student performance in a class as submitted by the instructor.</value>
        [DataMember(Name="finalNumericGradeEarned", EmitDefaultValue=false)]
        public double? FinalNumericGradeEarned { get; set; }

        /// <summary>
        /// The method the credits were earned (e.g., Classroom, Examination, Transfer).
        /// </summary>
        /// <value>The method the credits were earned (e.g., Classroom, Examination, Transfer).</value>
        [DataMember(Name="methodCreditEarnedDescriptor", EmitDefaultValue=false)]
        public string MethodCreditEarnedDescriptor { get; set; }

        /// <summary>
        /// Student&#39;s grade level at time of course.
        /// </summary>
        /// <value>Student&#39;s grade level at time of course.</value>
        [DataMember(Name="whenTakenGradeLevelDescriptor", EmitDefaultValue=false)]
        public string WhenTakenGradeLevelDescriptor { get; set; }

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
            sb.Append("class EdFiCourseTranscript {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CourseAttemptResultDescriptor: ").Append(CourseAttemptResultDescriptor).Append("\n");
            sb.Append("  CourseReference: ").Append(CourseReference).Append("\n");
            sb.Append("  ExternalEducationOrganizationReference: ").Append(ExternalEducationOrganizationReference).Append("\n");
            sb.Append("  StudentAcademicRecordReference: ").Append(StudentAcademicRecordReference).Append("\n");
            sb.Append("  AlternativeCourseCode: ").Append(AlternativeCourseCode).Append("\n");
            sb.Append("  AlternativeCourseTitle: ").Append(AlternativeCourseTitle).Append("\n");
            sb.Append("  AttemptedCreditConversion: ").Append(AttemptedCreditConversion).Append("\n");
            sb.Append("  AttemptedCredits: ").Append(AttemptedCredits).Append("\n");
            sb.Append("  AttemptedCreditTypeDescriptor: ").Append(AttemptedCreditTypeDescriptor).Append("\n");
            sb.Append("  CourseRepeatCodeDescriptor: ").Append(CourseRepeatCodeDescriptor).Append("\n");
            sb.Append("  CourseTitle: ").Append(CourseTitle).Append("\n");
            sb.Append("  EarnedAdditionalCredits: ").Append(EarnedAdditionalCredits).Append("\n");
            sb.Append("  EarnedCreditConversion: ").Append(EarnedCreditConversion).Append("\n");
            sb.Append("  EarnedCredits: ").Append(EarnedCredits).Append("\n");
            sb.Append("  EarnedCreditTypeDescriptor: ").Append(EarnedCreditTypeDescriptor).Append("\n");
            sb.Append("  FinalLetterGradeEarned: ").Append(FinalLetterGradeEarned).Append("\n");
            sb.Append("  FinalNumericGradeEarned: ").Append(FinalNumericGradeEarned).Append("\n");
            sb.Append("  MethodCreditEarnedDescriptor: ").Append(MethodCreditEarnedDescriptor).Append("\n");
            sb.Append("  WhenTakenGradeLevelDescriptor: ").Append(WhenTakenGradeLevelDescriptor).Append("\n");
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
            return this.Equals(input as EdFiCourseTranscript);
        }

        /// <summary>
        /// Returns true if EdFiCourseTranscript instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCourseTranscript to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCourseTranscript input)
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
                    this.CourseAttemptResultDescriptor == input.CourseAttemptResultDescriptor ||
                    (this.CourseAttemptResultDescriptor != null &&
                    this.CourseAttemptResultDescriptor.Equals(input.CourseAttemptResultDescriptor))
                ) && 
                (
                    this.CourseReference == input.CourseReference ||
                    (this.CourseReference != null &&
                    this.CourseReference.Equals(input.CourseReference))
                ) && 
                (
                    this.ExternalEducationOrganizationReference == input.ExternalEducationOrganizationReference ||
                    (this.ExternalEducationOrganizationReference != null &&
                    this.ExternalEducationOrganizationReference.Equals(input.ExternalEducationOrganizationReference))
                ) && 
                (
                    this.StudentAcademicRecordReference == input.StudentAcademicRecordReference ||
                    (this.StudentAcademicRecordReference != null &&
                    this.StudentAcademicRecordReference.Equals(input.StudentAcademicRecordReference))
                ) && 
                (
                    this.AlternativeCourseCode == input.AlternativeCourseCode ||
                    (this.AlternativeCourseCode != null &&
                    this.AlternativeCourseCode.Equals(input.AlternativeCourseCode))
                ) && 
                (
                    this.AlternativeCourseTitle == input.AlternativeCourseTitle ||
                    (this.AlternativeCourseTitle != null &&
                    this.AlternativeCourseTitle.Equals(input.AlternativeCourseTitle))
                ) && 
                (
                    this.AttemptedCreditConversion == input.AttemptedCreditConversion ||
                    (this.AttemptedCreditConversion != null &&
                    this.AttemptedCreditConversion.Equals(input.AttemptedCreditConversion))
                ) && 
                (
                    this.AttemptedCredits == input.AttemptedCredits ||
                    (this.AttemptedCredits != null &&
                    this.AttemptedCredits.Equals(input.AttemptedCredits))
                ) && 
                (
                    this.AttemptedCreditTypeDescriptor == input.AttemptedCreditTypeDescriptor ||
                    (this.AttemptedCreditTypeDescriptor != null &&
                    this.AttemptedCreditTypeDescriptor.Equals(input.AttemptedCreditTypeDescriptor))
                ) && 
                (
                    this.CourseRepeatCodeDescriptor == input.CourseRepeatCodeDescriptor ||
                    (this.CourseRepeatCodeDescriptor != null &&
                    this.CourseRepeatCodeDescriptor.Equals(input.CourseRepeatCodeDescriptor))
                ) && 
                (
                    this.CourseTitle == input.CourseTitle ||
                    (this.CourseTitle != null &&
                    this.CourseTitle.Equals(input.CourseTitle))
                ) && 
                (
                    this.EarnedAdditionalCredits == input.EarnedAdditionalCredits ||
                    this.EarnedAdditionalCredits != null &&
                    this.EarnedAdditionalCredits.SequenceEqual(input.EarnedAdditionalCredits)
                ) && 
                (
                    this.EarnedCreditConversion == input.EarnedCreditConversion ||
                    (this.EarnedCreditConversion != null &&
                    this.EarnedCreditConversion.Equals(input.EarnedCreditConversion))
                ) && 
                (
                    this.EarnedCredits == input.EarnedCredits ||
                    (this.EarnedCredits != null &&
                    this.EarnedCredits.Equals(input.EarnedCredits))
                ) && 
                (
                    this.EarnedCreditTypeDescriptor == input.EarnedCreditTypeDescriptor ||
                    (this.EarnedCreditTypeDescriptor != null &&
                    this.EarnedCreditTypeDescriptor.Equals(input.EarnedCreditTypeDescriptor))
                ) && 
                (
                    this.FinalLetterGradeEarned == input.FinalLetterGradeEarned ||
                    (this.FinalLetterGradeEarned != null &&
                    this.FinalLetterGradeEarned.Equals(input.FinalLetterGradeEarned))
                ) && 
                (
                    this.FinalNumericGradeEarned == input.FinalNumericGradeEarned ||
                    (this.FinalNumericGradeEarned != null &&
                    this.FinalNumericGradeEarned.Equals(input.FinalNumericGradeEarned))
                ) && 
                (
                    this.MethodCreditEarnedDescriptor == input.MethodCreditEarnedDescriptor ||
                    (this.MethodCreditEarnedDescriptor != null &&
                    this.MethodCreditEarnedDescriptor.Equals(input.MethodCreditEarnedDescriptor))
                ) && 
                (
                    this.WhenTakenGradeLevelDescriptor == input.WhenTakenGradeLevelDescriptor ||
                    (this.WhenTakenGradeLevelDescriptor != null &&
                    this.WhenTakenGradeLevelDescriptor.Equals(input.WhenTakenGradeLevelDescriptor))
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
                if (this.CourseAttemptResultDescriptor != null)
                    hashCode = hashCode * 59 + this.CourseAttemptResultDescriptor.GetHashCode();
                if (this.CourseReference != null)
                    hashCode = hashCode * 59 + this.CourseReference.GetHashCode();
                if (this.ExternalEducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.ExternalEducationOrganizationReference.GetHashCode();
                if (this.StudentAcademicRecordReference != null)
                    hashCode = hashCode * 59 + this.StudentAcademicRecordReference.GetHashCode();
                if (this.AlternativeCourseCode != null)
                    hashCode = hashCode * 59 + this.AlternativeCourseCode.GetHashCode();
                if (this.AlternativeCourseTitle != null)
                    hashCode = hashCode * 59 + this.AlternativeCourseTitle.GetHashCode();
                if (this.AttemptedCreditConversion != null)
                    hashCode = hashCode * 59 + this.AttemptedCreditConversion.GetHashCode();
                if (this.AttemptedCredits != null)
                    hashCode = hashCode * 59 + this.AttemptedCredits.GetHashCode();
                if (this.AttemptedCreditTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.AttemptedCreditTypeDescriptor.GetHashCode();
                if (this.CourseRepeatCodeDescriptor != null)
                    hashCode = hashCode * 59 + this.CourseRepeatCodeDescriptor.GetHashCode();
                if (this.CourseTitle != null)
                    hashCode = hashCode * 59 + this.CourseTitle.GetHashCode();
                if (this.EarnedAdditionalCredits != null)
                    hashCode = hashCode * 59 + this.EarnedAdditionalCredits.GetHashCode();
                if (this.EarnedCreditConversion != null)
                    hashCode = hashCode * 59 + this.EarnedCreditConversion.GetHashCode();
                if (this.EarnedCredits != null)
                    hashCode = hashCode * 59 + this.EarnedCredits.GetHashCode();
                if (this.EarnedCreditTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.EarnedCreditTypeDescriptor.GetHashCode();
                if (this.FinalLetterGradeEarned != null)
                    hashCode = hashCode * 59 + this.FinalLetterGradeEarned.GetHashCode();
                if (this.FinalNumericGradeEarned != null)
                    hashCode = hashCode * 59 + this.FinalNumericGradeEarned.GetHashCode();
                if (this.MethodCreditEarnedDescriptor != null)
                    hashCode = hashCode * 59 + this.MethodCreditEarnedDescriptor.GetHashCode();
                if (this.WhenTakenGradeLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.WhenTakenGradeLevelDescriptor.GetHashCode();
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
            // CourseAttemptResultDescriptor (string) maxLength
            if(this.CourseAttemptResultDescriptor != null && this.CourseAttemptResultDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CourseAttemptResultDescriptor, length must be less than 306.", new [] { "CourseAttemptResultDescriptor" });
            }

            // AlternativeCourseCode (string) maxLength
            if(this.AlternativeCourseCode != null && this.AlternativeCourseCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AlternativeCourseCode, length must be less than 60.", new [] { "AlternativeCourseCode" });
            }

            // AlternativeCourseTitle (string) maxLength
            if(this.AlternativeCourseTitle != null && this.AlternativeCourseTitle.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AlternativeCourseTitle, length must be less than 60.", new [] { "AlternativeCourseTitle" });
            }

            // AttemptedCreditTypeDescriptor (string) maxLength
            if(this.AttemptedCreditTypeDescriptor != null && this.AttemptedCreditTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AttemptedCreditTypeDescriptor, length must be less than 306.", new [] { "AttemptedCreditTypeDescriptor" });
            }

            // CourseRepeatCodeDescriptor (string) maxLength
            if(this.CourseRepeatCodeDescriptor != null && this.CourseRepeatCodeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CourseRepeatCodeDescriptor, length must be less than 306.", new [] { "CourseRepeatCodeDescriptor" });
            }

            // CourseTitle (string) maxLength
            if(this.CourseTitle != null && this.CourseTitle.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CourseTitle, length must be less than 60.", new [] { "CourseTitle" });
            }

            // EarnedCreditTypeDescriptor (string) maxLength
            if(this.EarnedCreditTypeDescriptor != null && this.EarnedCreditTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EarnedCreditTypeDescriptor, length must be less than 306.", new [] { "EarnedCreditTypeDescriptor" });
            }

            // FinalLetterGradeEarned (string) maxLength
            if(this.FinalLetterGradeEarned != null && this.FinalLetterGradeEarned.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FinalLetterGradeEarned, length must be less than 20.", new [] { "FinalLetterGradeEarned" });
            }

            // MethodCreditEarnedDescriptor (string) maxLength
            if(this.MethodCreditEarnedDescriptor != null && this.MethodCreditEarnedDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MethodCreditEarnedDescriptor, length must be less than 306.", new [] { "MethodCreditEarnedDescriptor" });
            }

            // WhenTakenGradeLevelDescriptor (string) maxLength
            if(this.WhenTakenGradeLevelDescriptor != null && this.WhenTakenGradeLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WhenTakenGradeLevelDescriptor, length must be less than 306.", new [] { "WhenTakenGradeLevelDescriptor" });
            }

            yield break;
        }
    }

}
