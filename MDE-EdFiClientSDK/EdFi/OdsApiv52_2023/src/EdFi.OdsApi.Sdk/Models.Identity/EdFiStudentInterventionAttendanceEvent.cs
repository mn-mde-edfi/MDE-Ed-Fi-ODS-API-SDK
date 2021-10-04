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
    /// EdFiStudentInterventionAttendanceEvent
    /// </summary>
    [DataContract]
    public partial class EdFiStudentInterventionAttendanceEvent :  IEquatable<EdFiStudentInterventionAttendanceEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentInterventionAttendanceEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentInterventionAttendanceEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentInterventionAttendanceEvent" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="attendanceEventCategoryDescriptor">A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy. (required).</param>
        /// <param name="eventDate">Date for this attendance event. (required).</param>
        /// <param name="interventionReference">interventionReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="attendanceEventReason">The reported reason for a student&#39;s absence..</param>
        /// <param name="educationalEnvironmentDescriptor">The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section..</param>
        /// <param name="eventDuration">The amount of time for the event as recognized by the school: 1 day &#x3D; 1, 1/2 day &#x3D; 0.5, 1/3 day &#x3D; 0.33..</param>
        /// <param name="interventionDuration">The duration in minutes in which the student participated in the intervention during this instance..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStudentInterventionAttendanceEvent(string id = default(string), string attendanceEventCategoryDescriptor = default(string), DateTime? eventDate = default(DateTime?), EdFiInterventionReference interventionReference = default(EdFiInterventionReference), EdFiStudentReference studentReference = default(EdFiStudentReference), string attendanceEventReason = default(string), string educationalEnvironmentDescriptor = default(string), double? eventDuration = default(double?), int? interventionDuration = default(int?), string etag = default(string))
        {
            // to ensure "attendanceEventCategoryDescriptor" is required (not null)
            if (attendanceEventCategoryDescriptor == null)
            {
                throw new InvalidDataException("attendanceEventCategoryDescriptor is a required property for EdFiStudentInterventionAttendanceEvent and cannot be null");
            }
            else
            {
                this.AttendanceEventCategoryDescriptor = attendanceEventCategoryDescriptor;
            }
            // to ensure "eventDate" is required (not null)
            if (eventDate == null)
            {
                throw new InvalidDataException("eventDate is a required property for EdFiStudentInterventionAttendanceEvent and cannot be null");
            }
            else
            {
                this.EventDate = eventDate;
            }
            // to ensure "interventionReference" is required (not null)
            if (interventionReference == null)
            {
                throw new InvalidDataException("interventionReference is a required property for EdFiStudentInterventionAttendanceEvent and cannot be null");
            }
            else
            {
                this.InterventionReference = interventionReference;
            }
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new InvalidDataException("studentReference is a required property for EdFiStudentInterventionAttendanceEvent and cannot be null");
            }
            else
            {
                this.StudentReference = studentReference;
            }
            this.Id = id;
            this.AttendanceEventReason = attendanceEventReason;
            this.EducationalEnvironmentDescriptor = educationalEnvironmentDescriptor;
            this.EventDuration = eventDuration;
            this.InterventionDuration = interventionDuration;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy.
        /// </summary>
        /// <value>A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy.</value>
        [DataMember(Name="attendanceEventCategoryDescriptor", EmitDefaultValue=false)]
        public string AttendanceEventCategoryDescriptor { get; set; }

        /// <summary>
        /// Date for this attendance event.
        /// </summary>
        /// <value>Date for this attendance event.</value>
        [DataMember(Name="eventDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EventDate { get; set; }

        /// <summary>
        /// Gets or Sets InterventionReference
        /// </summary>
        [DataMember(Name="interventionReference", EmitDefaultValue=false)]
        public EdFiInterventionReference InterventionReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name="studentReference", EmitDefaultValue=false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// The reported reason for a student&#39;s absence.
        /// </summary>
        /// <value>The reported reason for a student&#39;s absence.</value>
        [DataMember(Name="attendanceEventReason", EmitDefaultValue=false)]
        public string AttendanceEventReason { get; set; }

        /// <summary>
        /// The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section.
        /// </summary>
        /// <value>The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section.</value>
        [DataMember(Name="educationalEnvironmentDescriptor", EmitDefaultValue=false)]
        public string EducationalEnvironmentDescriptor { get; set; }

        /// <summary>
        /// The amount of time for the event as recognized by the school: 1 day &#x3D; 1, 1/2 day &#x3D; 0.5, 1/3 day &#x3D; 0.33.
        /// </summary>
        /// <value>The amount of time for the event as recognized by the school: 1 day &#x3D; 1, 1/2 day &#x3D; 0.5, 1/3 day &#x3D; 0.33.</value>
        [DataMember(Name="eventDuration", EmitDefaultValue=false)]
        public double? EventDuration { get; set; }

        /// <summary>
        /// The duration in minutes in which the student participated in the intervention during this instance.
        /// </summary>
        /// <value>The duration in minutes in which the student participated in the intervention during this instance.</value>
        [DataMember(Name="interventionDuration", EmitDefaultValue=false)]
        public int? InterventionDuration { get; set; }

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
            sb.Append("class EdFiStudentInterventionAttendanceEvent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AttendanceEventCategoryDescriptor: ").Append(AttendanceEventCategoryDescriptor).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  InterventionReference: ").Append(InterventionReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  AttendanceEventReason: ").Append(AttendanceEventReason).Append("\n");
            sb.Append("  EducationalEnvironmentDescriptor: ").Append(EducationalEnvironmentDescriptor).Append("\n");
            sb.Append("  EventDuration: ").Append(EventDuration).Append("\n");
            sb.Append("  InterventionDuration: ").Append(InterventionDuration).Append("\n");
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
            return this.Equals(input as EdFiStudentInterventionAttendanceEvent);
        }

        /// <summary>
        /// Returns true if EdFiStudentInterventionAttendanceEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentInterventionAttendanceEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentInterventionAttendanceEvent input)
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
                    this.AttendanceEventCategoryDescriptor == input.AttendanceEventCategoryDescriptor ||
                    (this.AttendanceEventCategoryDescriptor != null &&
                    this.AttendanceEventCategoryDescriptor.Equals(input.AttendanceEventCategoryDescriptor))
                ) && 
                (
                    this.EventDate == input.EventDate ||
                    (this.EventDate != null &&
                    this.EventDate.Equals(input.EventDate))
                ) && 
                (
                    this.InterventionReference == input.InterventionReference ||
                    (this.InterventionReference != null &&
                    this.InterventionReference.Equals(input.InterventionReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.AttendanceEventReason == input.AttendanceEventReason ||
                    (this.AttendanceEventReason != null &&
                    this.AttendanceEventReason.Equals(input.AttendanceEventReason))
                ) && 
                (
                    this.EducationalEnvironmentDescriptor == input.EducationalEnvironmentDescriptor ||
                    (this.EducationalEnvironmentDescriptor != null &&
                    this.EducationalEnvironmentDescriptor.Equals(input.EducationalEnvironmentDescriptor))
                ) && 
                (
                    this.EventDuration == input.EventDuration ||
                    (this.EventDuration != null &&
                    this.EventDuration.Equals(input.EventDuration))
                ) && 
                (
                    this.InterventionDuration == input.InterventionDuration ||
                    (this.InterventionDuration != null &&
                    this.InterventionDuration.Equals(input.InterventionDuration))
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
                if (this.AttendanceEventCategoryDescriptor != null)
                    hashCode = hashCode * 59 + this.AttendanceEventCategoryDescriptor.GetHashCode();
                if (this.EventDate != null)
                    hashCode = hashCode * 59 + this.EventDate.GetHashCode();
                if (this.InterventionReference != null)
                    hashCode = hashCode * 59 + this.InterventionReference.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.AttendanceEventReason != null)
                    hashCode = hashCode * 59 + this.AttendanceEventReason.GetHashCode();
                if (this.EducationalEnvironmentDescriptor != null)
                    hashCode = hashCode * 59 + this.EducationalEnvironmentDescriptor.GetHashCode();
                if (this.EventDuration != null)
                    hashCode = hashCode * 59 + this.EventDuration.GetHashCode();
                if (this.InterventionDuration != null)
                    hashCode = hashCode * 59 + this.InterventionDuration.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
