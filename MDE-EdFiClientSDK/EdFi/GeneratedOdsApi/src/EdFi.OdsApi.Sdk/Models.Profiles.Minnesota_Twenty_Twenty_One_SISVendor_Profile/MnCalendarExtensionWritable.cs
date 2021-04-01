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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_One_SISVendor_Profile
{
    /// <summary>
    /// MnCalendarExtensionWritable
    /// </summary>
    [DataContract]
    public partial class MnCalendarExtensionWritable :  IEquatable<MnCalendarExtensionWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCalendarExtensionWritable" /> class.
        /// </summary>
        /// <param name="KindergartenScheduleDescriptor">Kindergarten Schedule.</param>
        /// <param name="CalendarDescription">Calendar description..</param>
        /// <param name="DaysInSession">Days in session..</param>
        /// <param name="InstructionalDays">The total number of Instructional days during the current school year..</param>
        /// <param name="LengthOfDay">Length of Day..</param>
        public MnCalendarExtensionWritable(string KindergartenScheduleDescriptor = default(string), string CalendarDescription = default(string), double? DaysInSession = default(double?), double? InstructionalDays = default(double?), int? LengthOfDay = default(int?))
        {
            this.KindergartenScheduleDescriptor = KindergartenScheduleDescriptor;
            this.CalendarDescription = CalendarDescription;
            this.DaysInSession = DaysInSession;
            this.InstructionalDays = InstructionalDays;
            this.LengthOfDay = LengthOfDay;
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
            sb.Append("class MnCalendarExtensionWritable {\n");
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
            return this.Equals(input as MnCalendarExtensionWritable);
        }

        /// <summary>
        /// Returns true if MnCalendarExtensionWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnCalendarExtensionWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnCalendarExtensionWritable input)
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

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // KindergartenScheduleDescriptor (string) maxLength
            if(this.KindergartenScheduleDescriptor != null && this.KindergartenScheduleDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for KindergartenScheduleDescriptor, length must be less than 306.", new [] { "KindergartenScheduleDescriptor" });
            }

            // CalendarDescription (string) maxLength
            if(this.CalendarDescription != null && this.CalendarDescription.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CalendarDescription, length must be less than 100.", new [] { "CalendarDescription" });
            }

            yield break;
        }
    }

}
