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
    /// EdFiStudentInterventionAttendanceEvent
    /// </summary>
    [DataContract]
    public partial class EdFiStudentInterventionAttendanceEvent :  IEquatable<EdFiStudentInterventionAttendanceEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentInterventionAttendanceEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentInterventionAttendanceEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentInterventionAttendanceEvent" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="AttendanceEventCategoryDescriptor">A code describing the attendance event, for example:          Present          Unexcused absence          Excused absence          Tardy. (required).</param>
        /// <param name="EventDate">Date for this attendance event. (required).</param>
        /// <param name="InterventionReference">InterventionReference (required).</param>
        /// <param name="StudentReference">StudentReference (required).</param>
        /// <param name="AttendanceEventReason">The reported reason for a student&#39;s absence..</param>
        /// <param name="EducationalEnvironmentDescriptor">The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section..</param>
        /// <param name="EventDuration">The amount of time for the event as recognized by the school: 1 day &#x3D; 1, 1/2 day &#x3D; 0.5, 1/3 day &#x3D; 0.33..</param>
        /// <param name="InterventionDuration">The duration in minutes in which the student participated in the intervention during this instance..</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStudentInterventionAttendanceEvent(string Id = default(string), string AttendanceEventCategoryDescriptor = default(string), DateTime? EventDate = default(DateTime?), EdFiInterventionReference InterventionReference = default(EdFiInterventionReference), EdFiStudentReference StudentReference = default(EdFiStudentReference), string AttendanceEventReason = default(string), string EducationalEnvironmentDescriptor = default(string), double? EventDuration = default(double?), int? InterventionDuration = default(int?), string Etag = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiStudentInterventionAttendanceEvent and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "AttendanceEventCategoryDescriptor" is required (not null)
            if (AttendanceEventCategoryDescriptor == null)
            {
                throw new InvalidDataException("AttendanceEventCategoryDescriptor is a required property for EdFiStudentInterventionAttendanceEvent and cannot be null");
            }
            else
            {
                this.AttendanceEventCategoryDescriptor = AttendanceEventCategoryDescriptor;
            }
            // to ensure "EventDate" is required (not null)
            if (EventDate == null)
            {
                throw new InvalidDataException("EventDate is a required property for EdFiStudentInterventionAttendanceEvent and cannot be null");
            }
            else
            {
                this.EventDate = EventDate;
            }
            // to ensure "InterventionReference" is required (not null)
            if (InterventionReference == null)
            {
                throw new InvalidDataException("InterventionReference is a required property for EdFiStudentInterventionAttendanceEvent and cannot be null");
            }
            else
            {
                this.InterventionReference = InterventionReference;
            }
            // to ensure "StudentReference" is required (not null)
            if (StudentReference == null)
            {
                throw new InvalidDataException("StudentReference is a required property for EdFiStudentInterventionAttendanceEvent and cannot be null");
            }
            else
            {
                this.StudentReference = StudentReference;
            }
            this.AttendanceEventReason = AttendanceEventReason;
            this.EducationalEnvironmentDescriptor = EducationalEnvironmentDescriptor;
            this.EventDuration = EventDuration;
            this.InterventionDuration = InterventionDuration;
            this.Etag = Etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A code describing the attendance event, for example:          Present          Unexcused absence          Excused absence          Tardy.
        /// </summary>
        /// <value>A code describing the attendance event, for example:          Present          Unexcused absence          Excused absence          Tardy.</value>
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

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // AttendanceEventCategoryDescriptor (string) maxLength
            if(this.AttendanceEventCategoryDescriptor != null && this.AttendanceEventCategoryDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AttendanceEventCategoryDescriptor, length must be less than 306.", new [] { "AttendanceEventCategoryDescriptor" });
            }

            // AttendanceEventReason (string) maxLength
            if(this.AttendanceEventReason != null && this.AttendanceEventReason.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AttendanceEventReason, length must be less than 40.", new [] { "AttendanceEventReason" });
            }

            // EducationalEnvironmentDescriptor (string) maxLength
            if(this.EducationalEnvironmentDescriptor != null && this.EducationalEnvironmentDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EducationalEnvironmentDescriptor, length must be less than 306.", new [] { "EducationalEnvironmentDescriptor" });
            }

            yield break;
        }
    }

}