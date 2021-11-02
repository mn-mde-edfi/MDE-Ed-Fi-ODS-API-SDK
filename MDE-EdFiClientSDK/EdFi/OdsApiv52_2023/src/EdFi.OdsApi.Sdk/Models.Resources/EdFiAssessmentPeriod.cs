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

namespace EdFi.OdsApi.Sdk.Models.Resources
{
    /// <summary>
    /// EdFiAssessmentPeriod
    /// </summary>
    [DataContract]
    public partial class EdFiAssessmentPeriod :  IEquatable<EdFiAssessmentPeriod>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentPeriod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiAssessmentPeriod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentPeriod" /> class.
        /// </summary>
        /// <param name="assessmentPeriodDescriptor">The period of time in which an assessment is supposed to be administered (e.g., Beginning of Year, Middle of Year, End of Year). (required).</param>
        /// <param name="beginDate">The first date the assessment is to be administered..</param>
        /// <param name="endDate">The last date the assessment is to be administered..</param>
        public EdFiAssessmentPeriod(string assessmentPeriodDescriptor = default(string), DateTime? beginDate = default(DateTime?), DateTime? endDate = default(DateTime?))
        {
            // to ensure "assessmentPeriodDescriptor" is required (not null)
            if (assessmentPeriodDescriptor == null)
            {
                throw new InvalidDataException("assessmentPeriodDescriptor is a required property for EdFiAssessmentPeriod and cannot be null");
            }
            else
            {
                this.AssessmentPeriodDescriptor = assessmentPeriodDescriptor;
            }
            this.BeginDate = beginDate;
            this.EndDate = endDate;
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
            sb.Append("class EdFiAssessmentPeriod {\n");
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
            return this.Equals(input as EdFiAssessmentPeriod);
        }

        /// <summary>
        /// Returns true if EdFiAssessmentPeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiAssessmentPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiAssessmentPeriod input)
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
    }

}
