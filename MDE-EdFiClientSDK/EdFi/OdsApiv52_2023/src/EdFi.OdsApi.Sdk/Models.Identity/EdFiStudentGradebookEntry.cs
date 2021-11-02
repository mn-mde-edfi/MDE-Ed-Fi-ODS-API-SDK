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
    /// EdFiStudentGradebookEntry
    /// </summary>
    [DataContract]
    public partial class EdFiStudentGradebookEntry :  IEquatable<EdFiStudentGradebookEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentGradebookEntry" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentGradebookEntry() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentGradebookEntry" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="gradebookEntryReference">gradebookEntryReference (required).</param>
        /// <param name="studentSectionAssociationReference">studentSectionAssociationReference (required).</param>
        /// <param name="competencyLevelDescriptor">The CompetencyLevel assessed for the student for the referenced LearningObjective..</param>
        /// <param name="dateFulfilled">The date an assignment was turned in or the date of an assessment..</param>
        /// <param name="diagnosticStatement">A statement provided by the teacher that provides information in addition to the grade or assessment score..</param>
        /// <param name="letterGradeEarned">A final or interim (grading period) indicator of student performance in a class as submitted by the instructor..</param>
        /// <param name="numericGradeEarned">A final or interim (grading period) indicator of student performance in a class as submitted by the instructor..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStudentGradebookEntry(string id = default(string), EdFiGradebookEntryReference gradebookEntryReference = default(EdFiGradebookEntryReference), EdFiStudentSectionAssociationReference studentSectionAssociationReference = default(EdFiStudentSectionAssociationReference), string competencyLevelDescriptor = default(string), DateTime? dateFulfilled = default(DateTime?), string diagnosticStatement = default(string), string letterGradeEarned = default(string), double? numericGradeEarned = default(double?), string etag = default(string))
        {
            // to ensure "gradebookEntryReference" is required (not null)
            if (gradebookEntryReference == null)
            {
                throw new InvalidDataException("gradebookEntryReference is a required property for EdFiStudentGradebookEntry and cannot be null");
            }
            else
            {
                this.GradebookEntryReference = gradebookEntryReference;
            }
            // to ensure "studentSectionAssociationReference" is required (not null)
            if (studentSectionAssociationReference == null)
            {
                throw new InvalidDataException("studentSectionAssociationReference is a required property for EdFiStudentGradebookEntry and cannot be null");
            }
            else
            {
                this.StudentSectionAssociationReference = studentSectionAssociationReference;
            }
            this.Id = id;
            this.CompetencyLevelDescriptor = competencyLevelDescriptor;
            this.DateFulfilled = dateFulfilled;
            this.DiagnosticStatement = diagnosticStatement;
            this.LetterGradeEarned = letterGradeEarned;
            this.NumericGradeEarned = numericGradeEarned;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets GradebookEntryReference
        /// </summary>
        [DataMember(Name="gradebookEntryReference", EmitDefaultValue=false)]
        public EdFiGradebookEntryReference GradebookEntryReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentSectionAssociationReference
        /// </summary>
        [DataMember(Name="studentSectionAssociationReference", EmitDefaultValue=false)]
        public EdFiStudentSectionAssociationReference StudentSectionAssociationReference { get; set; }

        /// <summary>
        /// The CompetencyLevel assessed for the student for the referenced LearningObjective.
        /// </summary>
        /// <value>The CompetencyLevel assessed for the student for the referenced LearningObjective.</value>
        [DataMember(Name="competencyLevelDescriptor", EmitDefaultValue=false)]
        public string CompetencyLevelDescriptor { get; set; }

        /// <summary>
        /// The date an assignment was turned in or the date of an assessment.
        /// </summary>
        /// <value>The date an assignment was turned in or the date of an assessment.</value>
        [DataMember(Name="dateFulfilled", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DateFulfilled { get; set; }

        /// <summary>
        /// A statement provided by the teacher that provides information in addition to the grade or assessment score.
        /// </summary>
        /// <value>A statement provided by the teacher that provides information in addition to the grade or assessment score.</value>
        [DataMember(Name="diagnosticStatement", EmitDefaultValue=false)]
        public string DiagnosticStatement { get; set; }

        /// <summary>
        /// A final or interim (grading period) indicator of student performance in a class as submitted by the instructor.
        /// </summary>
        /// <value>A final or interim (grading period) indicator of student performance in a class as submitted by the instructor.</value>
        [DataMember(Name="letterGradeEarned", EmitDefaultValue=false)]
        public string LetterGradeEarned { get; set; }

        /// <summary>
        /// A final or interim (grading period) indicator of student performance in a class as submitted by the instructor.
        /// </summary>
        /// <value>A final or interim (grading period) indicator of student performance in a class as submitted by the instructor.</value>
        [DataMember(Name="numericGradeEarned", EmitDefaultValue=false)]
        public double? NumericGradeEarned { get; set; }

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
            sb.Append("class EdFiStudentGradebookEntry {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GradebookEntryReference: ").Append(GradebookEntryReference).Append("\n");
            sb.Append("  StudentSectionAssociationReference: ").Append(StudentSectionAssociationReference).Append("\n");
            sb.Append("  CompetencyLevelDescriptor: ").Append(CompetencyLevelDescriptor).Append("\n");
            sb.Append("  DateFulfilled: ").Append(DateFulfilled).Append("\n");
            sb.Append("  DiagnosticStatement: ").Append(DiagnosticStatement).Append("\n");
            sb.Append("  LetterGradeEarned: ").Append(LetterGradeEarned).Append("\n");
            sb.Append("  NumericGradeEarned: ").Append(NumericGradeEarned).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            return this.Equals(input as EdFiStudentGradebookEntry);
        }

        /// <summary>
        /// Returns true if EdFiStudentGradebookEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentGradebookEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentGradebookEntry input)
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
                    this.GradebookEntryReference == input.GradebookEntryReference ||
                    (this.GradebookEntryReference != null &&
                    this.GradebookEntryReference.Equals(input.GradebookEntryReference))
                ) && 
                (
                    this.StudentSectionAssociationReference == input.StudentSectionAssociationReference ||
                    (this.StudentSectionAssociationReference != null &&
                    this.StudentSectionAssociationReference.Equals(input.StudentSectionAssociationReference))
                ) && 
                (
                    this.CompetencyLevelDescriptor == input.CompetencyLevelDescriptor ||
                    (this.CompetencyLevelDescriptor != null &&
                    this.CompetencyLevelDescriptor.Equals(input.CompetencyLevelDescriptor))
                ) && 
                (
                    this.DateFulfilled == input.DateFulfilled ||
                    (this.DateFulfilled != null &&
                    this.DateFulfilled.Equals(input.DateFulfilled))
                ) && 
                (
                    this.DiagnosticStatement == input.DiagnosticStatement ||
                    (this.DiagnosticStatement != null &&
                    this.DiagnosticStatement.Equals(input.DiagnosticStatement))
                ) && 
                (
                    this.LetterGradeEarned == input.LetterGradeEarned ||
                    (this.LetterGradeEarned != null &&
                    this.LetterGradeEarned.Equals(input.LetterGradeEarned))
                ) && 
                (
                    this.NumericGradeEarned == input.NumericGradeEarned ||
                    (this.NumericGradeEarned != null &&
                    this.NumericGradeEarned.Equals(input.NumericGradeEarned))
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
                if (this.GradebookEntryReference != null)
                    hashCode = hashCode * 59 + this.GradebookEntryReference.GetHashCode();
                if (this.StudentSectionAssociationReference != null)
                    hashCode = hashCode * 59 + this.StudentSectionAssociationReference.GetHashCode();
                if (this.CompetencyLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.CompetencyLevelDescriptor.GetHashCode();
                if (this.DateFulfilled != null)
                    hashCode = hashCode * 59 + this.DateFulfilled.GetHashCode();
                if (this.DiagnosticStatement != null)
                    hashCode = hashCode * 59 + this.DiagnosticStatement.GetHashCode();
                if (this.LetterGradeEarned != null)
                    hashCode = hashCode * 59 + this.LetterGradeEarned.GetHashCode();
                if (this.NumericGradeEarned != null)
                    hashCode = hashCode * 59 + this.NumericGradeEarned.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
