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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Assessment_Vendor_Profile
{
    /// <summary>
    /// EdFiAssessmentPeriodWritable
    /// </summary>
    [DataContract]
    public partial class EdFiAssessmentPeriodWritable :  IEquatable<EdFiAssessmentPeriodWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentPeriodWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiAssessmentPeriodWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentPeriodWritable" /> class.
        /// </summary>
        /// <param name="AssessmentPeriodDescriptor">The period of time in which an assessment is supposed to be administered (e.g., Beginning of Year, Middle of Year, End of Year). (required).</param>
        /// <param name="BeginDate">The first date the assessment is to be administered..</param>
        /// <param name="EndDate">The last date the assessment is to be administered..</param>
        public EdFiAssessmentPeriodWritable(string AssessmentPeriodDescriptor = default(string), DateTime? BeginDate = default(DateTime?), DateTime? EndDate = default(DateTime?))
        {
            // to ensure "AssessmentPeriodDescriptor" is required (not null)
            if (AssessmentPeriodDescriptor == null)
            {
                throw new InvalidDataException("AssessmentPeriodDescriptor is a required property for EdFiAssessmentPeriodWritable and cannot be null");
            }
            else
            {
                this.AssessmentPeriodDescriptor = AssessmentPeriodDescriptor;
            }
            this.BeginDate = BeginDate;
            this.EndDate = EndDate;
        }
        
        /// <summary>
        /// The period of time in which an assessment is supposed to be administered (e.g., Beginning of Year, Middle of Year, End of Year).
        /// </summary>
        /// <value>The period of time in which an assessment is supposed to be administered (e.g., Beginning of Year, Middle of Year, End of Year).</value>
        [DataMember(Name="assessmentPeriodDescriptor", EmitDefaultValue=false)]
        public string AssessmentPeriodDescriptor { get; set; }

        /// <summary>
        /// The first date the assessment is to be administered.
        /// </summary>
        /// <value>The first date the assessment is to be administered.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// The last date the assessment is to be administered.
        /// </summary>
        /// <value>The last date the assessment is to be administered.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiAssessmentPeriodWritable {\n");
            sb.Append("  AssessmentPeriodDescriptor: ").Append(AssessmentPeriodDescriptor).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(input as EdFiAssessmentPeriodWritable);
        }

        /// <summary>
        /// Returns true if EdFiAssessmentPeriodWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiAssessmentPeriodWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiAssessmentPeriodWritable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssessmentPeriodDescriptor == input.AssessmentPeriodDescriptor ||
                    (this.AssessmentPeriodDescriptor != null &&
                    this.AssessmentPeriodDescriptor.Equals(input.AssessmentPeriodDescriptor))
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
                if (this.AssessmentPeriodDescriptor != null)
                    hashCode = hashCode * 59 + this.AssessmentPeriodDescriptor.GetHashCode();
                if (this.BeginDate != null)
                    hashCode = hashCode * 59 + this.BeginDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
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
            // AssessmentPeriodDescriptor (string) maxLength
            if(this.AssessmentPeriodDescriptor != null && this.AssessmentPeriodDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentPeriodDescriptor, length must be less than 306.", new [] { "AssessmentPeriodDescriptor" });
            }

            yield break;
        }
    }

}
