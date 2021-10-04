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
    /// EdFiStudentSectionAssociationReference
    /// </summary>
    [DataContract]
    public partial class EdFiStudentSectionAssociationReference :  IEquatable<EdFiStudentSectionAssociationReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSectionAssociationReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentSectionAssociationReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSectionAssociationReference" /> class.
        /// </summary>
        /// <param name="beginDate">Month, day, and year of the Student&#39;s entry or assignment to the Section. (required).</param>
        /// <param name="localCourseCode">The local code assigned by the School that identifies the course offering provided for the instruction of students. (required).</param>
        /// <param name="schoolId">The identifier assigned to a school. (required).</param>
        /// <param name="schoolYear">The identifier for the school year. (required).</param>
        /// <param name="sectionIdentifier">The local identifier assigned to a section. (required).</param>
        /// <param name="sessionName">The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). (required).</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student. (required).</param>
        /// <param name="link">link.</param>
        public EdFiStudentSectionAssociationReference(DateTime? beginDate = default(DateTime?), string localCourseCode = default(string), int? schoolId = default(int?), int? schoolYear = default(int?), string sectionIdentifier = default(string), string sessionName = default(string), string studentUniqueId = default(string), Link link = default(Link))
        {
            // to ensure "beginDate" is required (not null)
            if (beginDate == null)
            {
                throw new InvalidDataException("beginDate is a required property for EdFiStudentSectionAssociationReference and cannot be null");
            }
            else
            {
                this.BeginDate = beginDate;
            }
            // to ensure "localCourseCode" is required (not null)
            if (localCourseCode == null)
            {
                throw new InvalidDataException("localCourseCode is a required property for EdFiStudentSectionAssociationReference and cannot be null");
            }
            else
            {
                this.LocalCourseCode = localCourseCode;
            }
            // to ensure "schoolId" is required (not null)
            if (schoolId == null)
            {
                throw new InvalidDataException("schoolId is a required property for EdFiStudentSectionAssociationReference and cannot be null");
            }
            else
            {
                this.SchoolId = schoolId;
            }
            // to ensure "schoolYear" is required (not null)
            if (schoolYear == null)
            {
                throw new InvalidDataException("schoolYear is a required property for EdFiStudentSectionAssociationReference and cannot be null");
            }
            else
            {
                this.SchoolYear = schoolYear;
            }
            // to ensure "sectionIdentifier" is required (not null)
            if (sectionIdentifier == null)
            {
                throw new InvalidDataException("sectionIdentifier is a required property for EdFiStudentSectionAssociationReference and cannot be null");
            }
            else
            {
                this.SectionIdentifier = sectionIdentifier;
            }
            // to ensure "sessionName" is required (not null)
            if (sessionName == null)
            {
                throw new InvalidDataException("sessionName is a required property for EdFiStudentSectionAssociationReference and cannot be null");
            }
            else
            {
                this.SessionName = sessionName;
            }
            // to ensure "studentUniqueId" is required (not null)
            if (studentUniqueId == null)
            {
                throw new InvalidDataException("studentUniqueId is a required property for EdFiStudentSectionAssociationReference and cannot be null");
            }
            else
            {
                this.StudentUniqueId = studentUniqueId;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// Month, day, and year of the Student&#39;s entry or assignment to the Section.
        /// </summary>
        /// <value>Month, day, and year of the Student&#39;s entry or assignment to the Section.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

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
            sb.Append("class EdFiStudentSectionAssociationReference {\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
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
            return this.Equals(input as EdFiStudentSectionAssociationReference);
        }

        /// <summary>
        /// Returns true if EdFiStudentSectionAssociationReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentSectionAssociationReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentSectionAssociationReference input)
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
    }

}
