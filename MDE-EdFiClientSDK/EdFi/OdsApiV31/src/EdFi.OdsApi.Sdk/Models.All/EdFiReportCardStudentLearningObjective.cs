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
    /// EdFiReportCardStudentLearningObjective
    /// </summary>
    [DataContract]
    public partial class EdFiReportCardStudentLearningObjective :  IEquatable<EdFiReportCardStudentLearningObjective>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiReportCardStudentLearningObjective" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiReportCardStudentLearningObjective() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiReportCardStudentLearningObjective" /> class.
        /// </summary>
        /// <param name="StudentLearningObjectiveReference">StudentLearningObjectiveReference (required).</param>
        public EdFiReportCardStudentLearningObjective(EdFiStudentLearningObjectiveReference StudentLearningObjectiveReference = default(EdFiStudentLearningObjectiveReference))
        {
            // to ensure "StudentLearningObjectiveReference" is required (not null)
            if (StudentLearningObjectiveReference == null)
            {
                throw new InvalidDataException("StudentLearningObjectiveReference is a required property for EdFiReportCardStudentLearningObjective and cannot be null");
            }
            else
            {
                this.StudentLearningObjectiveReference = StudentLearningObjectiveReference;
            }
        }
        
        /// <summary>
        /// Gets or Sets StudentLearningObjectiveReference
        /// </summary>
        [DataMember(Name="studentLearningObjectiveReference", EmitDefaultValue=false)]
        public EdFiStudentLearningObjectiveReference StudentLearningObjectiveReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiReportCardStudentLearningObjective {\n");
            sb.Append("  StudentLearningObjectiveReference: ").Append(StudentLearningObjectiveReference).Append("\n");
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
            return this.Equals(input as EdFiReportCardStudentLearningObjective);
        }

        /// <summary>
        /// Returns true if EdFiReportCardStudentLearningObjective instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiReportCardStudentLearningObjective to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiReportCardStudentLearningObjective input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StudentLearningObjectiveReference == input.StudentLearningObjectiveReference ||
                    (this.StudentLearningObjectiveReference != null &&
                    this.StudentLearningObjectiveReference.Equals(input.StudentLearningObjectiveReference))
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
                if (this.StudentLearningObjectiveReference != null)
                    hashCode = hashCode * 59 + this.StudentLearningObjectiveReference.GetHashCode();
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