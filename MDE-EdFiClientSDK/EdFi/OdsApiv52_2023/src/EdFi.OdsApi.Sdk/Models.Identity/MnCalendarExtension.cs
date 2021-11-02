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
    /// MnCalendarExtension
    /// </summary>
    [DataContract]
    public partial class MnCalendarExtension :  IEquatable<MnCalendarExtension>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCalendarExtension" /> class.
        /// </summary>
        /// <param name="kindergartenScheduleDescriptor">Kindergarten Schedule.</param>
        /// <param name="calendarDescription">Calendar description..</param>
        /// <param name="daysInSession">Days in session..</param>
        /// <param name="instructionalDays">The total number of Instructional days during the current school year..</param>
        /// <param name="lengthOfDay">Length of Day..</param>
        public MnCalendarExtension(string kindergartenScheduleDescriptor = default(string), string calendarDescription = default(string), double? daysInSession = default(double?), double? instructionalDays = default(double?), int? lengthOfDay = default(int?))
        {
            this.KindergartenScheduleDescriptor = kindergartenScheduleDescriptor;
            this.CalendarDescription = calendarDescription;
            this.DaysInSession = daysInSession;
            this.InstructionalDays = instructionalDays;
            this.LengthOfDay = lengthOfDay;
        }
        
        /// <summary>
        /// Kindergarten Schedule
        /// </summary>
        /// <value>Kindergarten Schedule</value>
        [DataMember(Name="kindergartenScheduleDescriptor", EmitDefaultValue=false)]
        public string KindergartenScheduleDescriptor { get; set; }

        /// <summary>
        /// Calendar description.
        /// </summary>
        /// <value>Calendar description.</value>
        [DataMember(Name="calendarDescription", EmitDefaultValue=false)]
        public string CalendarDescription { get; set; }

        /// <summary>
        /// Days in session.
        /// </summary>
        /// <value>Days in session.</value>
        [DataMember(Name="daysInSession", EmitDefaultValue=false)]
        public double? DaysInSession { get; set; }

        /// <summary>
        /// The total number of Instructional days during the current school year.
        /// </summary>
        /// <value>The total number of Instructional days during the current school year.</value>
        [DataMember(Name="instructionalDays", EmitDefaultValue=false)]
        public double? InstructionalDays { get; set; }

        /// <summary>
        /// Length of Day.
        /// </summary>
        /// <value>Length of Day.</value>
        [DataMember(Name="lengthOfDay", EmitDefaultValue=false)]
        public int? LengthOfDay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnCalendarExtension {\n");
            sb.Append("  KindergartenScheduleDescriptor: ").Append(KindergartenScheduleDescriptor).Append("\n");
            sb.Append("  CalendarDescription: ").Append(CalendarDescription).Append("\n");
            sb.Append("  DaysInSession: ").Append(DaysInSession).Append("\n");
            sb.Append("  InstructionalDays: ").Append(InstructionalDays).Append("\n");
            sb.Append("  LengthOfDay: ").Append(LengthOfDay).Append("\n");
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
            return this.Equals(input as MnCalendarExtension);
        }

        /// <summary>
        /// Returns true if MnCalendarExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of MnCalendarExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnCalendarExtension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KindergartenScheduleDescriptor == input.KindergartenScheduleDescriptor ||
                    (this.KindergartenScheduleDescriptor != null &&
                    this.KindergartenScheduleDescriptor.Equals(input.KindergartenScheduleDescriptor))
                ) && 
                (
                    this.CalendarDescription == input.CalendarDescription ||
                    (this.CalendarDescription != null &&
                    this.CalendarDescription.Equals(input.CalendarDescription))
                ) && 
                (
                    this.DaysInSession == input.DaysInSession ||
                    (this.DaysInSession != null &&
                    this.DaysInSession.Equals(input.DaysInSession))
                ) && 
                (
                    this.InstructionalDays == input.InstructionalDays ||
                    (this.InstructionalDays != null &&
                    this.InstructionalDays.Equals(input.InstructionalDays))
                ) && 
                (
                    this.LengthOfDay == input.LengthOfDay ||
                    (this.LengthOfDay != null &&
                    this.LengthOfDay.Equals(input.LengthOfDay))
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
                if (this.KindergartenScheduleDescriptor != null)
                    hashCode = hashCode * 59 + this.KindergartenScheduleDescriptor.GetHashCode();
                if (this.CalendarDescription != null)
                    hashCode = hashCode * 59 + this.CalendarDescription.GetHashCode();
                if (this.DaysInSession != null)
                    hashCode = hashCode * 59 + this.DaysInSession.GetHashCode();
                if (this.InstructionalDays != null)
                    hashCode = hashCode * 59 + this.InstructionalDays.GetHashCode();
                if (this.LengthOfDay != null)
                    hashCode = hashCode * 59 + this.LengthOfDay.GetHashCode();
                return hashCode;
            }
        }
    }

}
