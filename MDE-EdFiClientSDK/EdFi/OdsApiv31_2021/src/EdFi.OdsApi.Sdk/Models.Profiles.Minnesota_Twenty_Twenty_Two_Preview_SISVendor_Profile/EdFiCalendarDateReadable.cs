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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile
{
    /// <summary>
    /// EdFiCalendarDateReadable
    /// </summary>
    [DataContract]
    public partial class EdFiCalendarDateReadable :  IEquatable<EdFiCalendarDateReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCalendarDateReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCalendarDateReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCalendarDateReadable" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="CalendarEvents">An unordered collection of calendarDateCalendarEvents. The type of scheduled or unscheduled event for the day. (required).</param>
        /// <param name="Date">The month, day, and year of the CalendarEvent. (required).</param>
        /// <param name="CalendarReference">CalendarReference (required).</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiCalendarDateReadable(string Id = default(string), List<EdFiCalendarDateCalendarEventReadable> CalendarEvents = default(List<EdFiCalendarDateCalendarEventReadable>), DateTime? Date = default(DateTime?), EdFiCalendarReference CalendarReference = default(EdFiCalendarReference), string Etag = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiCalendarDateReadable and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "CalendarEvents" is required (not null)
            if (CalendarEvents == null)
            {
                throw new InvalidDataException("CalendarEvents is a required property for EdFiCalendarDateReadable and cannot be null");
            }
            else
            {
                this.CalendarEvents = CalendarEvents;
            }
            // to ensure "Date" is required (not null)
            if (Date == null)
            {
                throw new InvalidDataException("Date is a required property for EdFiCalendarDateReadable and cannot be null");
            }
            else
            {
                this.Date = Date;
            }
            // to ensure "CalendarReference" is required (not null)
            if (CalendarReference == null)
            {
                throw new InvalidDataException("CalendarReference is a required property for EdFiCalendarDateReadable and cannot be null");
            }
            else
            {
                this.CalendarReference = CalendarReference;
            }
            this.Etag = Etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// An unordered collection of calendarDateCalendarEvents. The type of scheduled or unscheduled event for the day.
        /// </summary>
        /// <value>An unordered collection of calendarDateCalendarEvents. The type of scheduled or unscheduled event for the day.</value>
        [DataMember(Name="calendarEvents", EmitDefaultValue=false)]
        public List<EdFiCalendarDateCalendarEventReadable> CalendarEvents { get; set; }

        /// <summary>
        /// The month, day, and year of the CalendarEvent.
        /// </summary>
        /// <value>The month, day, and year of the CalendarEvent.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets CalendarReference
        /// </summary>
        [DataMember(Name="calendarReference", EmitDefaultValue=false)]
        public EdFiCalendarReference CalendarReference { get; set; }

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
            sb.Append("class EdFiCalendarDateReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CalendarEvents: ").Append(CalendarEvents).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  CalendarReference: ").Append(CalendarReference).Append("\n");
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
            return this.Equals(input as EdFiCalendarDateReadable);
        }

        /// <summary>
        /// Returns true if EdFiCalendarDateReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCalendarDateReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCalendarDateReadable input)
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
                    this.CalendarEvents == input.CalendarEvents ||
                    this.CalendarEvents != null &&
                    this.CalendarEvents.SequenceEqual(input.CalendarEvents)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.CalendarReference == input.CalendarReference ||
                    (this.CalendarReference != null &&
                    this.CalendarReference.Equals(input.CalendarReference))
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
                if (this.CalendarEvents != null)
                    hashCode = hashCode * 59 + this.CalendarEvents.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.CalendarReference != null)
                    hashCode = hashCode * 59 + this.CalendarReference.GetHashCode();
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
            yield break;
        }
    }

}
