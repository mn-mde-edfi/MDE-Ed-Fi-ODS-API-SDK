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
    /// EdFiClassPeriodMeetingTime
    /// </summary>
    [DataContract]
    public partial class EdFiClassPeriodMeetingTime :  IEquatable<EdFiClassPeriodMeetingTime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiClassPeriodMeetingTime" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiClassPeriodMeetingTime() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiClassPeriodMeetingTime" /> class.
        /// </summary>
        /// <param name="EndTime">An indication of the time of day the meeting time ends. (required).</param>
        /// <param name="StartTime">An indication of the time of day the meeting time begins. (required).</param>
        public EdFiClassPeriodMeetingTime(string EndTime = default(string), string StartTime = default(string))
        {
            // to ensure "EndTime" is required (not null)
            if (EndTime == null)
            {
                throw new InvalidDataException("EndTime is a required property for EdFiClassPeriodMeetingTime and cannot be null");
            }
            else
            {
                this.EndTime = EndTime;
            }
            // to ensure "StartTime" is required (not null)
            if (StartTime == null)
            {
                throw new InvalidDataException("StartTime is a required property for EdFiClassPeriodMeetingTime and cannot be null");
            }
            else
            {
                this.StartTime = StartTime;
            }
        }
        
        /// <summary>
        /// An indication of the time of day the meeting time ends.
        /// </summary>
        /// <value>An indication of the time of day the meeting time ends.</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// An indication of the time of day the meeting time begins.
        /// </summary>
        /// <value>An indication of the time of day the meeting time begins.</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiClassPeriodMeetingTime {\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
            return this.Equals(input as EdFiClassPeriodMeetingTime);
        }

        /// <summary>
        /// Returns true if EdFiClassPeriodMeetingTime instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiClassPeriodMeetingTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiClassPeriodMeetingTime input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
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
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
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
