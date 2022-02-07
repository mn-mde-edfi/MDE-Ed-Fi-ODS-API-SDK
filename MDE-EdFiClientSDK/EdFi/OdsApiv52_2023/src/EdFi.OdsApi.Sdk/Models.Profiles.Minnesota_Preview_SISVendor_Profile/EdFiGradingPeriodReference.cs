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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = EdFi.OdsApi.Sdk.Client.SwaggerDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile
{
    /// <summary>
    /// EdFiGradingPeriodReference
    /// </summary>
    [DataContract]
    public partial class EdFiGradingPeriodReference :  IEquatable<EdFiGradingPeriodReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGradingPeriodReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiGradingPeriodReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGradingPeriodReference" /> class.
        /// </summary>
        /// <param name="gradingPeriodDescriptor">The name of the period for which grades are reported. (required).</param>
        /// <param name="periodSequence">The sequential order of this period relative to other periods. (required).</param>
        /// <param name="schoolId">The identifier assigned to a school. (required).</param>
        /// <param name="schoolYear">The identifier for the grading period school year. (required).</param>
        /// <param name="link">link.</param>
        public EdFiGradingPeriodReference(string gradingPeriodDescriptor = default(string), int? periodSequence = default(int?), int? schoolId = default(int?), int? schoolYear = default(int?), Link link = default(Link))
        {
            // to ensure "gradingPeriodDescriptor" is required (not null)
            if (gradingPeriodDescriptor == null)
            {
                throw new InvalidDataException("gradingPeriodDescriptor is a required property for EdFiGradingPeriodReference and cannot be null");
            }
            else
            {
                this.GradingPeriodDescriptor = gradingPeriodDescriptor;
            }
            // to ensure "periodSequence" is required (not null)
            if (periodSequence == null)
            {
                throw new InvalidDataException("periodSequence is a required property for EdFiGradingPeriodReference and cannot be null");
            }
            else
            {
                this.PeriodSequence = periodSequence;
            }
            // to ensure "schoolId" is required (not null)
            if (schoolId == null)
            {
                throw new InvalidDataException("schoolId is a required property for EdFiGradingPeriodReference and cannot be null");
            }
            else
            {
                this.SchoolId = schoolId;
            }
            // to ensure "schoolYear" is required (not null)
            if (schoolYear == null)
            {
                throw new InvalidDataException("schoolYear is a required property for EdFiGradingPeriodReference and cannot be null");
            }
            else
            {
                this.SchoolYear = schoolYear;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// The name of the period for which grades are reported.
        /// </summary>
        /// <value>The name of the period for which grades are reported.</value>
        [DataMember(Name="gradingPeriodDescriptor", EmitDefaultValue=false)]
        public string GradingPeriodDescriptor { get; set; }

        /// <summary>
        /// The sequential order of this period relative to other periods.
        /// </summary>
        /// <value>The sequential order of this period relative to other periods.</value>
        [DataMember(Name="periodSequence", EmitDefaultValue=false)]
        public int? PeriodSequence { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name="schoolId", EmitDefaultValue=false)]
        public int? SchoolId { get; set; }

        /// <summary>
        /// The identifier for the grading period school year.
        /// </summary>
        /// <value>The identifier for the grading period school year.</value>
        [DataMember(Name="schoolYear", EmitDefaultValue=false)]
        public int? SchoolYear { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiGradingPeriodReference {\n");
            sb.Append("  GradingPeriodDescriptor: ").Append(GradingPeriodDescriptor).Append("\n");
            sb.Append("  PeriodSequence: ").Append(PeriodSequence).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiGradingPeriodReference);
        }

        /// <summary>
        /// Returns true if EdFiGradingPeriodReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiGradingPeriodReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiGradingPeriodReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GradingPeriodDescriptor == input.GradingPeriodDescriptor ||
                    (this.GradingPeriodDescriptor != null &&
                    this.GradingPeriodDescriptor.Equals(input.GradingPeriodDescriptor))
                ) && 
                (
                    this.PeriodSequence == input.PeriodSequence ||
                    (this.PeriodSequence != null &&
                    this.PeriodSequence.Equals(input.PeriodSequence))
                ) && 
                (
                    this.SchoolId == input.SchoolId ||
                    (this.SchoolId != null &&
                    this.SchoolId.Equals(input.SchoolId))
                ) && 
                (
                    this.SchoolYear == input.SchoolYear ||
                    (this.SchoolYear != null &&
                    this.SchoolYear.Equals(input.SchoolYear))
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
                if (this.GradingPeriodDescriptor != null)
                    hashCode = hashCode * 59 + this.GradingPeriodDescriptor.GetHashCode();
                if (this.PeriodSequence != null)
                    hashCode = hashCode * 59 + this.PeriodSequence.GetHashCode();
                if (this.SchoolId != null)
                    hashCode = hashCode * 59 + this.SchoolId.GetHashCode();
                if (this.SchoolYear != null)
                    hashCode = hashCode * 59 + this.SchoolYear.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
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
            // GradingPeriodDescriptor (string) maxLength
            if(this.GradingPeriodDescriptor != null && this.GradingPeriodDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GradingPeriodDescriptor, length must be less than 306.", new [] { "GradingPeriodDescriptor" });
            }

            yield break;
        }
    }

}
