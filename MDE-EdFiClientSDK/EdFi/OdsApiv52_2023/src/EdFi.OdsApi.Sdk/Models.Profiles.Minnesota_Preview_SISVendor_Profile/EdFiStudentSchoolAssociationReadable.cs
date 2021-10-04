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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile
{
    /// <summary>
    /// EdFiStudentSchoolAssociationReadable
    /// </summary>
    [DataContract]
    public partial class EdFiStudentSchoolAssociationReadable :  IEquatable<EdFiStudentSchoolAssociationReadable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSchoolAssociationReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentSchoolAssociationReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSchoolAssociationReadable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="entryDate">The month, day, and year on which an individual enters and begins to receive instructional services in a school. (required).</param>
        /// <param name="calendarReference">calendarReference.</param>
        /// <param name="schoolReference">schoolReference (required).</param>
        /// <param name="schoolYearTypeReference">schoolYearTypeReference.</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="entryGradeLevelDescriptor">The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session. (required).</param>
        /// <param name="entryTypeDescriptor">The process by which a student enters a school during a given academic session..</param>
        /// <param name="exitWithdrawDate">The recorded exit or withdraw date for the student..</param>
        /// <param name="exitWithdrawTypeDescriptor">The circumstances under which the student exited from membership in an educational institution..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">ext.</param>
        public EdFiStudentSchoolAssociationReadable(string id = default(string), DateTime? entryDate = default(DateTime?), EdFiCalendarReference calendarReference = default(EdFiCalendarReference), EdFiSchoolReference schoolReference = default(EdFiSchoolReference), EdFiSchoolYearTypeReference schoolYearTypeReference = default(EdFiSchoolYearTypeReference), EdFiStudentReference studentReference = default(EdFiStudentReference), string entryGradeLevelDescriptor = default(string), string entryTypeDescriptor = default(string), DateTime? exitWithdrawDate = default(DateTime?), string exitWithdrawTypeDescriptor = default(string), string etag = default(string), StudentSchoolAssociationExtensionsReadable ext = default(StudentSchoolAssociationExtensionsReadable))
        {
            // to ensure "entryDate" is required (not null)
            if (entryDate == null)
            {
                throw new InvalidDataException("entryDate is a required property for EdFiStudentSchoolAssociationReadable and cannot be null");
            }
            else
            {
                this.EntryDate = entryDate;
            }
            // to ensure "schoolReference" is required (not null)
            if (schoolReference == null)
            {
                throw new InvalidDataException("schoolReference is a required property for EdFiStudentSchoolAssociationReadable and cannot be null");
            }
            else
            {
                this.SchoolReference = schoolReference;
            }
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new InvalidDataException("studentReference is a required property for EdFiStudentSchoolAssociationReadable and cannot be null");
            }
            else
            {
                this.StudentReference = studentReference;
            }
            // to ensure "entryGradeLevelDescriptor" is required (not null)
            if (entryGradeLevelDescriptor == null)
            {
                throw new InvalidDataException("entryGradeLevelDescriptor is a required property for EdFiStudentSchoolAssociationReadable and cannot be null");
            }
            else
            {
                this.EntryGradeLevelDescriptor = entryGradeLevelDescriptor;
            }
            this.Id = id;
            this.CalendarReference = calendarReference;
            this.SchoolYearTypeReference = schoolYearTypeReference;
            this.EntryTypeDescriptor = entryTypeDescriptor;
            this.ExitWithdrawDate = exitWithdrawDate;
            this.ExitWithdrawTypeDescriptor = exitWithdrawTypeDescriptor;
            this.Etag = etag;
            this.Ext = ext;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The month, day, and year on which an individual enters and begins to receive instructional services in a school.
        /// </summary>
        /// <value>The month, day, and year on which an individual enters and begins to receive instructional services in a school.</value>
        [DataMember(Name="entryDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EntryDate { get; set; }

        /// <summary>
        /// Gets or Sets CalendarReference
        /// </summary>
        [DataMember(Name="calendarReference", EmitDefaultValue=false)]
        public EdFiCalendarReference CalendarReference { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name="schoolReference", EmitDefaultValue=false)]
        public EdFiSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// Gets or Sets SchoolYearTypeReference
        /// </summary>
        [DataMember(Name="schoolYearTypeReference", EmitDefaultValue=false)]
        public EdFiSchoolYearTypeReference SchoolYearTypeReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name="studentReference", EmitDefaultValue=false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session.
        /// </summary>
        /// <value>The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session.</value>
        [DataMember(Name="entryGradeLevelDescriptor", EmitDefaultValue=false)]
        public string EntryGradeLevelDescriptor { get; set; }

        /// <summary>
        /// The process by which a student enters a school during a given academic session.
        /// </summary>
        /// <value>The process by which a student enters a school during a given academic session.</value>
        [DataMember(Name="entryTypeDescriptor", EmitDefaultValue=false)]
        public string EntryTypeDescriptor { get; set; }

        /// <summary>
        /// The recorded exit or withdraw date for the student.
        /// </summary>
        /// <value>The recorded exit or withdraw date for the student.</value>
        [DataMember(Name="exitWithdrawDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ExitWithdrawDate { get; set; }

        /// <summary>
        /// The circumstances under which the student exited from membership in an educational institution.
        /// </summary>
        /// <value>The circumstances under which the student exited from membership in an educational institution.</value>
        [DataMember(Name="exitWithdrawTypeDescriptor", EmitDefaultValue=false)]
        public string ExitWithdrawTypeDescriptor { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or Sets Ext
        /// </summary>
        [DataMember(Name="_ext", EmitDefaultValue=false)]
        public StudentSchoolAssociationExtensionsReadable Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentSchoolAssociationReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EntryDate: ").Append(EntryDate).Append("\n");
            sb.Append("  CalendarReference: ").Append(CalendarReference).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  SchoolYearTypeReference: ").Append(SchoolYearTypeReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  EntryGradeLevelDescriptor: ").Append(EntryGradeLevelDescriptor).Append("\n");
            sb.Append("  EntryTypeDescriptor: ").Append(EntryTypeDescriptor).Append("\n");
            sb.Append("  ExitWithdrawDate: ").Append(ExitWithdrawDate).Append("\n");
            sb.Append("  ExitWithdrawTypeDescriptor: ").Append(ExitWithdrawTypeDescriptor).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
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
            return this.Equals(input as EdFiStudentSchoolAssociationReadable);
        }

        /// <summary>
        /// Returns true if EdFiStudentSchoolAssociationReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentSchoolAssociationReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentSchoolAssociationReadable input)
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
                    this.EntryDate == input.EntryDate ||
                    (this.EntryDate != null &&
                    this.EntryDate.Equals(input.EntryDate))
                ) && 
                (
                    this.CalendarReference == input.CalendarReference ||
                    (this.CalendarReference != null &&
                    this.CalendarReference.Equals(input.CalendarReference))
                ) && 
                (
                    this.SchoolReference == input.SchoolReference ||
                    (this.SchoolReference != null &&
                    this.SchoolReference.Equals(input.SchoolReference))
                ) && 
                (
                    this.SchoolYearTypeReference == input.SchoolYearTypeReference ||
                    (this.SchoolYearTypeReference != null &&
                    this.SchoolYearTypeReference.Equals(input.SchoolYearTypeReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.EntryGradeLevelDescriptor == input.EntryGradeLevelDescriptor ||
                    (this.EntryGradeLevelDescriptor != null &&
                    this.EntryGradeLevelDescriptor.Equals(input.EntryGradeLevelDescriptor))
                ) && 
                (
                    this.EntryTypeDescriptor == input.EntryTypeDescriptor ||
                    (this.EntryTypeDescriptor != null &&
                    this.EntryTypeDescriptor.Equals(input.EntryTypeDescriptor))
                ) && 
                (
                    this.ExitWithdrawDate == input.ExitWithdrawDate ||
                    (this.ExitWithdrawDate != null &&
                    this.ExitWithdrawDate.Equals(input.ExitWithdrawDate))
                ) && 
                (
                    this.ExitWithdrawTypeDescriptor == input.ExitWithdrawTypeDescriptor ||
                    (this.ExitWithdrawTypeDescriptor != null &&
                    this.ExitWithdrawTypeDescriptor.Equals(input.ExitWithdrawTypeDescriptor))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.Ext == input.Ext ||
                    (this.Ext != null &&
                    this.Ext.Equals(input.Ext))
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
                if (this.EntryDate != null)
                    hashCode = hashCode * 59 + this.EntryDate.GetHashCode();
                if (this.CalendarReference != null)
                    hashCode = hashCode * 59 + this.CalendarReference.GetHashCode();
                if (this.SchoolReference != null)
                    hashCode = hashCode * 59 + this.SchoolReference.GetHashCode();
                if (this.SchoolYearTypeReference != null)
                    hashCode = hashCode * 59 + this.SchoolYearTypeReference.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.EntryGradeLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.EntryGradeLevelDescriptor.GetHashCode();
                if (this.EntryTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.EntryTypeDescriptor.GetHashCode();
                if (this.ExitWithdrawDate != null)
                    hashCode = hashCode * 59 + this.ExitWithdrawDate.GetHashCode();
                if (this.ExitWithdrawTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.ExitWithdrawTypeDescriptor.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
                return hashCode;
            }
        }
    }

}
