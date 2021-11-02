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
    /// EdFiStaffAbsenceEvent
    /// </summary>
    [DataContract]
    public partial class EdFiStaffAbsenceEvent :  IEquatable<EdFiStaffAbsenceEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffAbsenceEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStaffAbsenceEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffAbsenceEvent" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="absenceEventCategoryDescriptor">The code describing the type of absence. (required).</param>
        /// <param name="eventDate">Date for this leave event. (required).</param>
        /// <param name="staffReference">staffReference (required).</param>
        /// <param name="absenceEventReason">Expanded reason for the staff absence..</param>
        /// <param name="hoursAbsent">The hours the staff was absent, if not the entire working day..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStaffAbsenceEvent(string id = default(string), string absenceEventCategoryDescriptor = default(string), DateTime? eventDate = default(DateTime?), EdFiStaffReference staffReference = default(EdFiStaffReference), string absenceEventReason = default(string), double? hoursAbsent = default(double?), string etag = default(string))
        {
            // to ensure "absenceEventCategoryDescriptor" is required (not null)
            if (absenceEventCategoryDescriptor == null)
            {
                throw new InvalidDataException("absenceEventCategoryDescriptor is a required property for EdFiStaffAbsenceEvent and cannot be null");
            }
            else
            {
                this.AbsenceEventCategoryDescriptor = absenceEventCategoryDescriptor;
            }
            // to ensure "eventDate" is required (not null)
            if (eventDate == null)
            {
                throw new InvalidDataException("eventDate is a required property for EdFiStaffAbsenceEvent and cannot be null");
            }
            else
            {
                this.EventDate = eventDate;
            }
            // to ensure "staffReference" is required (not null)
            if (staffReference == null)
            {
                throw new InvalidDataException("staffReference is a required property for EdFiStaffAbsenceEvent and cannot be null");
            }
            else
            {
                this.StaffReference = staffReference;
            }
            this.Id = id;
            this.AbsenceEventReason = absenceEventReason;
            this.HoursAbsent = hoursAbsent;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The code describing the type of absence.
        /// </summary>
        /// <value>The code describing the type of absence.</value>
        [DataMember(Name="absenceEventCategoryDescriptor", EmitDefaultValue=false)]
        public string AbsenceEventCategoryDescriptor { get; set; }

        /// <summary>
        /// Date for this leave event.
        /// </summary>
        /// <value>Date for this leave event.</value>
        [DataMember(Name="eventDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EventDate { get; set; }

        /// <summary>
        /// Gets or Sets StaffReference
        /// </summary>
        [DataMember(Name="staffReference", EmitDefaultValue=false)]
        public EdFiStaffReference StaffReference { get; set; }

        /// <summary>
        /// Expanded reason for the staff absence.
        /// </summary>
        /// <value>Expanded reason for the staff absence.</value>
        [DataMember(Name="absenceEventReason", EmitDefaultValue=false)]
        public string AbsenceEventReason { get; set; }

        /// <summary>
        /// The hours the staff was absent, if not the entire working day.
        /// </summary>
        /// <value>The hours the staff was absent, if not the entire working day.</value>
        [DataMember(Name="hoursAbsent", EmitDefaultValue=false)]
        public double? HoursAbsent { get; set; }

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
            sb.Append("class EdFiStaffAbsenceEvent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AbsenceEventCategoryDescriptor: ").Append(AbsenceEventCategoryDescriptor).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  StaffReference: ").Append(StaffReference).Append("\n");
            sb.Append("  AbsenceEventReason: ").Append(AbsenceEventReason).Append("\n");
            sb.Append("  HoursAbsent: ").Append(HoursAbsent).Append("\n");
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
            return this.Equals(input as EdFiStaffAbsenceEvent);
        }

        /// <summary>
        /// Returns true if EdFiStaffAbsenceEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStaffAbsenceEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStaffAbsenceEvent input)
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
                    this.AbsenceEventCategoryDescriptor == input.AbsenceEventCategoryDescriptor ||
                    (this.AbsenceEventCategoryDescriptor != null &&
                    this.AbsenceEventCategoryDescriptor.Equals(input.AbsenceEventCategoryDescriptor))
                ) && 
                (
                    this.EventDate == input.EventDate ||
                    (this.EventDate != null &&
                    this.EventDate.Equals(input.EventDate))
                ) && 
                (
                    this.StaffReference == input.StaffReference ||
                    (this.StaffReference != null &&
                    this.StaffReference.Equals(input.StaffReference))
                ) && 
                (
                    this.AbsenceEventReason == input.AbsenceEventReason ||
                    (this.AbsenceEventReason != null &&
                    this.AbsenceEventReason.Equals(input.AbsenceEventReason))
                ) && 
                (
                    this.HoursAbsent == input.HoursAbsent ||
                    (this.HoursAbsent != null &&
                    this.HoursAbsent.Equals(input.HoursAbsent))
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
                if (this.AbsenceEventCategoryDescriptor != null)
                    hashCode = hashCode * 59 + this.AbsenceEventCategoryDescriptor.GetHashCode();
                if (this.EventDate != null)
                    hashCode = hashCode * 59 + this.EventDate.GetHashCode();
                if (this.StaffReference != null)
                    hashCode = hashCode * 59 + this.StaffReference.GetHashCode();
                if (this.AbsenceEventReason != null)
                    hashCode = hashCode * 59 + this.AbsenceEventReason.GetHashCode();
                if (this.HoursAbsent != null)
                    hashCode = hashCode * 59 + this.HoursAbsent.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
