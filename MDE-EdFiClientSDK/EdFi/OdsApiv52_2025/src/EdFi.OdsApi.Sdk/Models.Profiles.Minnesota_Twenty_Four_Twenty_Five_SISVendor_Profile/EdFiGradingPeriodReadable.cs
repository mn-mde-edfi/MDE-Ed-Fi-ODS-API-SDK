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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile
{
    /// <summary>
    /// EdFiGradingPeriodReadable
    /// </summary>
    [DataContract(Name = "edFi_gradingPeriod_readable")]
    public partial class EdFiGradingPeriodReadable : IEquatable<EdFiGradingPeriodReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGradingPeriodReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiGradingPeriodReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGradingPeriodReadable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="gradingPeriodDescriptor">The name of the period for which grades are reported. (required).</param>
        /// <param name="periodSequence">The sequential order of this period relative to other periods. (required).</param>
        /// <param name="schoolReference">schoolReference (required).</param>
        /// <param name="schoolYearTypeReference">schoolYearTypeReference (required).</param>
        /// <param name="beginDate">Month, day, and year of the first day of the GradingPeriod. (required).</param>
        /// <param name="endDate">Month, day, and year of the last day of the GradingPeriod. (required).</param>
        /// <param name="totalInstructionalDays">Total days available for educational instruction during the GradingPeriod. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiGradingPeriodReadable(string id = default(string), string gradingPeriodDescriptor = default(string), int periodSequence = default(int), EdFiSchoolReference schoolReference = default(EdFiSchoolReference), EdFiSchoolYearTypeReference schoolYearTypeReference = default(EdFiSchoolYearTypeReference), DateTime beginDate = default(DateTime), DateTime endDate = default(DateTime), int totalInstructionalDays = default(int), string etag = default(string))
        {
            // to ensure "gradingPeriodDescriptor" is required (not null)
            if (gradingPeriodDescriptor == null)
            {
                throw new ArgumentNullException("gradingPeriodDescriptor is a required property for EdFiGradingPeriodReadable and cannot be null");
            }
            this.GradingPeriodDescriptor = gradingPeriodDescriptor;
            this.PeriodSequence = periodSequence;
            // to ensure "schoolReference" is required (not null)
            if (schoolReference == null)
            {
                throw new ArgumentNullException("schoolReference is a required property for EdFiGradingPeriodReadable and cannot be null");
            }
            this.SchoolReference = schoolReference;
            // to ensure "schoolYearTypeReference" is required (not null)
            if (schoolYearTypeReference == null)
            {
                throw new ArgumentNullException("schoolYearTypeReference is a required property for EdFiGradingPeriodReadable and cannot be null");
            }
            this.SchoolYearTypeReference = schoolYearTypeReference;
            this.BeginDate = beginDate;
            this.EndDate = endDate;
            this.TotalInstructionalDays = totalInstructionalDays;
            this.Id = id;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the period for which grades are reported.
        /// </summary>
        /// <value>The name of the period for which grades are reported.</value>
        [DataMember(Name = "gradingPeriodDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string GradingPeriodDescriptor { get; set; }

        /// <summary>
        /// The sequential order of this period relative to other periods.
        /// </summary>
        /// <value>The sequential order of this period relative to other periods.</value>
        [DataMember(Name = "periodSequence", IsRequired = true, EmitDefaultValue = false)]
        public int PeriodSequence { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name = "schoolReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// Gets or Sets SchoolYearTypeReference
        /// </summary>
        [DataMember(Name = "schoolYearTypeReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiSchoolYearTypeReference SchoolYearTypeReference { get; set; }

        /// <summary>
        /// Month, day, and year of the first day of the GradingPeriod.
        /// </summary>
        /// <value>Month, day, and year of the first day of the GradingPeriod.</value>
        [DataMember(Name = "beginDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// Month, day, and year of the last day of the GradingPeriod.
        /// </summary>
        /// <value>Month, day, and year of the last day of the GradingPeriod.</value>
        [DataMember(Name = "endDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Total days available for educational instruction during the GradingPeriod.
        /// </summary>
        /// <value>Total days available for educational instruction during the GradingPeriod.</value>
        [DataMember(Name = "totalInstructionalDays", IsRequired = true, EmitDefaultValue = false)]
        public int TotalInstructionalDays { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiGradingPeriodReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GradingPeriodDescriptor: ").Append(GradingPeriodDescriptor).Append("\n");
            sb.Append("  PeriodSequence: ").Append(PeriodSequence).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  SchoolYearTypeReference: ").Append(SchoolYearTypeReference).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  TotalInstructionalDays: ").Append(TotalInstructionalDays).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiGradingPeriodReadable);
        }

        /// <summary>
        /// Returns true if EdFiGradingPeriodReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiGradingPeriodReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiGradingPeriodReadable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.GradingPeriodDescriptor == input.GradingPeriodDescriptor ||
                    (this.GradingPeriodDescriptor != null &&
                    this.GradingPeriodDescriptor.Equals(input.GradingPeriodDescriptor))
                ) && 
                (
                    this.PeriodSequence == input.PeriodSequence ||
                    this.PeriodSequence.Equals(input.PeriodSequence)
                ) && 
                (
                    this.SchoolReference == input.SchoolReference ||
                    (this.SchoolReference != null &&
                    this.SchoolReference.Equals(input.SchoolReference))
                ) && 
                (
                    this.SchoolYearTypeReference == input.SchoolYearTypeReference ||
                    (this.SchoolYearTypeReference != null &&
                    this.SchoolYearTypeReference.Equals(input.SchoolYearTypeReference))
                ) && 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.TotalInstructionalDays == input.TotalInstructionalDays ||
                    this.TotalInstructionalDays.Equals(input.TotalInstructionalDays)
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
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.GradingPeriodDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.GradingPeriodDescriptor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PeriodSequence.GetHashCode();
                if (this.SchoolReference != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolReference.GetHashCode();
                }
                if (this.SchoolYearTypeReference != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolYearTypeReference.GetHashCode();
                }
                if (this.BeginDate != null)
                {
                    hashCode = (hashCode * 59) + this.BeginDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalInstructionalDays.GetHashCode();
                if (this.Etag != null)
                {
                    hashCode = (hashCode * 59) + this.Etag.GetHashCode();
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
            // GradingPeriodDescriptor (string) maxLength
            if (this.GradingPeriodDescriptor != null && this.GradingPeriodDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GradingPeriodDescriptor, length must be less than 306.", new [] { "GradingPeriodDescriptor" });
            }

            yield break;
        }
    }

}
