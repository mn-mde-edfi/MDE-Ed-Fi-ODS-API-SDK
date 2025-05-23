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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile
{
    /// <summary>
    /// MnCalendarReference
    /// </summary>
    [DataContract(Name = "mn_calendarReference")]
    public partial class MnCalendarReference : IEquatable<MnCalendarReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCalendarReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnCalendarReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnCalendarReference" /> class.
        /// </summary>
        /// <param name="calendarCode">The identifier for the Calendar. (required).</param>
        /// <param name="schoolId">The identifier assigned to a school. (required).</param>
        /// <param name="schoolYear">The identifier for the school year associated with the Calendar. (required).</param>
        /// <param name="link">link.</param>
        public MnCalendarReference(string calendarCode = default(string), int schoolId = default(int), int schoolYear = default(int), Link link = default(Link))
        {
            // to ensure "calendarCode" is required (not null)
            if (calendarCode == null)
            {
                throw new ArgumentNullException("calendarCode is a required property for MnCalendarReference and cannot be null");
            }
            this.CalendarCode = calendarCode;
            this.SchoolId = schoolId;
            this.SchoolYear = schoolYear;
            this.Link = link;
        }

        /// <summary>
        /// The identifier for the Calendar.
        /// </summary>
        /// <value>The identifier for the Calendar.</value>
        [DataMember(Name = "calendarCode", IsRequired = true, EmitDefaultValue = false)]
        public string CalendarCode { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name = "schoolId", IsRequired = true, EmitDefaultValue = false)]
        public int SchoolId { get; set; }

        /// <summary>
        /// The identifier for the school year associated with the Calendar.
        /// </summary>
        /// <value>The identifier for the school year associated with the Calendar.</value>
        [DataMember(Name = "schoolYear", IsRequired = true, EmitDefaultValue = false)]
        public int SchoolYear { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MnCalendarReference {\n");
            sb.Append("  CalendarCode: ").Append(CalendarCode).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  SchoolYear: ").Append(SchoolYear).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as MnCalendarReference);
        }

        /// <summary>
        /// Returns true if MnCalendarReference instances are equal
        /// </summary>
        /// <param name="input">Instance of MnCalendarReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnCalendarReference input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CalendarCode == input.CalendarCode ||
                    (this.CalendarCode != null &&
                    this.CalendarCode.Equals(input.CalendarCode))
                ) && 
                (
                    this.SchoolId == input.SchoolId ||
                    this.SchoolId.Equals(input.SchoolId)
                ) && 
                (
                    this.SchoolYear == input.SchoolYear ||
                    this.SchoolYear.Equals(input.SchoolYear)
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                if (this.CalendarCode != null)
                {
                    hashCode = (hashCode * 59) + this.CalendarCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SchoolId.GetHashCode();
                hashCode = (hashCode * 59) + this.SchoolYear.GetHashCode();
                if (this.Link != null)
                {
                    hashCode = (hashCode * 59) + this.Link.GetHashCode();
                }
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
            // CalendarCode (string) maxLength
            if (this.CalendarCode != null && this.CalendarCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CalendarCode, length must be less than 60.", new [] { "CalendarCode" });
            }

            yield break;
        }
    }

}
