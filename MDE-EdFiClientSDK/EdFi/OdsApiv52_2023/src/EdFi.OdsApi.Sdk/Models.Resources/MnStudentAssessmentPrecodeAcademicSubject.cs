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
    /// MnStudentAssessmentPrecodeAcademicSubject
    /// </summary>
    [DataContract]
    public partial class MnStudentAssessmentPrecodeAcademicSubject :  IEquatable<MnStudentAssessmentPrecodeAcademicSubject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentAssessmentPrecodeAcademicSubject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentAssessmentPrecodeAcademicSubject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentAssessmentPrecodeAcademicSubject" /> class.
        /// </summary>
        /// <param name="academicSubjectDescriptor">The description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language) of an assessment. (required).</param>
        public MnStudentAssessmentPrecodeAcademicSubject(string academicSubjectDescriptor = default(string))
        {
            // to ensure "academicSubjectDescriptor" is required (not null)
            if (academicSubjectDescriptor == null)
            {
                throw new InvalidDataException("academicSubjectDescriptor is a required property for MnStudentAssessmentPrecodeAcademicSubject and cannot be null");
            }
            else
            {
                this.AcademicSubjectDescriptor = academicSubjectDescriptor;
            }
        }
        
        /// <summary>
        /// The description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language) of an assessment.
        /// </summary>
        /// <value>The description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language) of an assessment.</value>
        [DataMember(Name="academicSubjectDescriptor", EmitDefaultValue=false)]
        public string AcademicSubjectDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnStudentAssessmentPrecodeAcademicSubject {\n");
            sb.Append("  AcademicSubjectDescriptor: ").Append(AcademicSubjectDescriptor).Append("\n");
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
            return this.Equals(input as MnStudentAssessmentPrecodeAcademicSubject);
        }

        /// <summary>
        /// Returns true if MnStudentAssessmentPrecodeAcademicSubject instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentAssessmentPrecodeAcademicSubject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentAssessmentPrecodeAcademicSubject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcademicSubjectDescriptor == input.AcademicSubjectDescriptor ||
                    (this.AcademicSubjectDescriptor != null &&
                    this.AcademicSubjectDescriptor.Equals(input.AcademicSubjectDescriptor))
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
                if (this.AcademicSubjectDescriptor != null)
                    hashCode = hashCode * 59 + this.AcademicSubjectDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
