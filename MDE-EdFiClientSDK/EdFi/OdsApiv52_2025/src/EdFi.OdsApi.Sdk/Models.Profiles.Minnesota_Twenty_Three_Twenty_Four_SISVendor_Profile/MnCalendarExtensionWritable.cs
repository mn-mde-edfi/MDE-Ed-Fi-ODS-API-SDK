/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdFi.OdsApi.Sdk.Client.OpenAPIDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Three_Twenty_Four_SISVendor_Profile
{
    /// <summary>
    /// MnCalendarExtensionWritable
    /// </summary>
    [DataContract(Name = "mn_calendarExtension_writable")]
    public partial class MnCalendarExtensionWritable : IEquatable<MnCalendarExtensionWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCalendarExtensionWritable" /> class.
        /// </summary>
        /// <param name="kindergartenScheduleDescriptor">Kindergarten Schedule.</param>
        /// <param name="instructionalDays">The total number of Instructional days during the current school year..</param>
        /// <param name="lengthOfDay">Length of Day..</param>
        public MnCalendarExtensionWritable(string kindergartenScheduleDescriptor = default(string), double instructionalDays = default(double), int lengthOfDay = default(int))
        {
            this.KindergartenScheduleDescriptor = kindergartenScheduleDescriptor;
            this.InstructionalDays = instructionalDays;
            this.LengthOfDay = lengthOfDay;
        }

        /// <summary>
        /// Kindergarten Schedule
        /// </summary>
        /// <value>Kindergarten Schedule</value>
        [DataMember(Name = "kindergartenScheduleDescriptor", EmitDefaultValue = false)]
        public string KindergartenScheduleDescriptor { get; set; }

        /// <summary>
        /// The total number of Instructional days during the current school year.
        /// </summary>
        /// <value>The total number of Instructional days during the current school year.</value>
        [DataMember(Name = "instructionalDays", EmitDefaultValue = false)]
        public double InstructionalDays { get; set; }

        /// <summary>
        /// Length of Day.
        /// </summary>
        /// <value>Length of Day.</value>
        [DataMember(Name = "lengthOfDay", EmitDefaultValue = false)]
        public int LengthOfDay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MnCalendarExtensionWritable {\n");
            sb.Append("  KindergartenScheduleDescriptor: ").Append(KindergartenScheduleDescriptor).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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
            {
                return false;
            }
            return 
                (
                    this.KindergartenScheduleDescriptor == input.KindergartenScheduleDescriptor ||
                    (this.KindergartenScheduleDescriptor != null &&
                    this.KindergartenScheduleDescriptor.Equals(input.KindergartenScheduleDescriptor))
                ) && 
                (
                    this.InstructionalDays == input.InstructionalDays ||
                    this.InstructionalDays.Equals(input.InstructionalDays)
                ) && 
                (
                    this.LengthOfDay == input.LengthOfDay ||
                    this.LengthOfDay.Equals(input.LengthOfDay)
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
                {
                    hashCode = (hashCode * 59) + this.KindergartenScheduleDescriptor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InstructionalDays.GetHashCode();
                hashCode = (hashCode * 59) + this.LengthOfDay.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // KindergartenScheduleDescriptor (string) maxLength
            if (this.KindergartenScheduleDescriptor != null && this.KindergartenScheduleDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for KindergartenScheduleDescriptor, length must be less than 306.", new [] { "KindergartenScheduleDescriptor" });
            }

            yield break;
        }
    }

}
