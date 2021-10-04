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
    /// EdFiClassPeriod
    /// </summary>
    [DataContract]
    public partial class EdFiClassPeriod :  IEquatable<EdFiClassPeriod>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiClassPeriod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiClassPeriod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiClassPeriod" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="classPeriodName">An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules). (required).</param>
        /// <param name="schoolReference">schoolReference (required).</param>
        /// <param name="meetingTimes">An unordered collection of classPeriodMeetingTimes. The meeting time(s) for a class period..</param>
        /// <param name="officialAttendancePeriod">Indicator of whether this class period is used for official daily attendance. Alternatively, official daily attendance may be tied to a Section..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">ext.</param>
        public EdFiClassPeriod(string id = default(string), string classPeriodName = default(string), EdFiSchoolReference schoolReference = default(EdFiSchoolReference), List<EdFiClassPeriodMeetingTime> meetingTimes = default(List<EdFiClassPeriodMeetingTime>), bool? officialAttendancePeriod = default(bool?), string etag = default(string), ClassPeriodExtensions ext = default(ClassPeriodExtensions))
        {
            // to ensure "classPeriodName" is required (not null)
            if (classPeriodName == null)
            {
                throw new InvalidDataException("classPeriodName is a required property for EdFiClassPeriod and cannot be null");
            }
            else
            {
                this.ClassPeriodName = classPeriodName;
            }
            // to ensure "schoolReference" is required (not null)
            if (schoolReference == null)
            {
                throw new InvalidDataException("schoolReference is a required property for EdFiClassPeriod and cannot be null");
            }
            else
            {
                this.SchoolReference = schoolReference;
            }
            this.Id = id;
            this.MeetingTimes = meetingTimes;
            this.OfficialAttendancePeriod = officialAttendancePeriod;
            this.Etag = etag;
            this.Ext = ext;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).
        /// </summary>
        /// <value>An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).</value>
        [DataMember(Name="classPeriodName", EmitDefaultValue=false)]
        public string ClassPeriodName { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name="schoolReference", EmitDefaultValue=false)]
        public EdFiSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// An unordered collection of classPeriodMeetingTimes. The meeting time(s) for a class period.
        /// </summary>
        /// <value>An unordered collection of classPeriodMeetingTimes. The meeting time(s) for a class period.</value>
        [DataMember(Name="meetingTimes", EmitDefaultValue=false)]
        public List<EdFiClassPeriodMeetingTime> MeetingTimes { get; set; }

        /// <summary>
        /// Indicator of whether this class period is used for official daily attendance. Alternatively, official daily attendance may be tied to a Section.
        /// </summary>
        /// <value>Indicator of whether this class period is used for official daily attendance. Alternatively, official daily attendance may be tied to a Section.</value>
        [DataMember(Name="officialAttendancePeriod", EmitDefaultValue=false)]
        public bool? OfficialAttendancePeriod { get; set; }

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
        public ClassPeriodExtensions Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiClassPeriod {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ClassPeriodName: ").Append(ClassPeriodName).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  MeetingTimes: ").Append(MeetingTimes).Append("\n");
            sb.Append("  OfficialAttendancePeriod: ").Append(OfficialAttendancePeriod).Append("\n");
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
            return this.Equals(input as EdFiClassPeriod);
        }

        /// <summary>
        /// Returns true if EdFiClassPeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiClassPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiClassPeriod input)
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
                    this.ClassPeriodName == input.ClassPeriodName ||
                    (this.ClassPeriodName != null &&
                    this.ClassPeriodName.Equals(input.ClassPeriodName))
                ) && 
                (
                    this.SchoolReference == input.SchoolReference ||
                    (this.SchoolReference != null &&
                    this.SchoolReference.Equals(input.SchoolReference))
                ) && 
                (
                    this.MeetingTimes == input.MeetingTimes ||
                    this.MeetingTimes != null &&
                    this.MeetingTimes.SequenceEqual(input.MeetingTimes)
                ) && 
                (
                    this.OfficialAttendancePeriod == input.OfficialAttendancePeriod ||
                    (this.OfficialAttendancePeriod != null &&
                    this.OfficialAttendancePeriod.Equals(input.OfficialAttendancePeriod))
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
                if (this.ClassPeriodName != null)
                    hashCode = hashCode * 59 + this.ClassPeriodName.GetHashCode();
                if (this.SchoolReference != null)
                    hashCode = hashCode * 59 + this.SchoolReference.GetHashCode();
                if (this.MeetingTimes != null)
                    hashCode = hashCode * 59 + this.MeetingTimes.GetHashCode();
                if (this.OfficialAttendancePeriod != null)
                    hashCode = hashCode * 59 + this.OfficialAttendancePeriod.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
                return hashCode;
            }
        }
    }

}
