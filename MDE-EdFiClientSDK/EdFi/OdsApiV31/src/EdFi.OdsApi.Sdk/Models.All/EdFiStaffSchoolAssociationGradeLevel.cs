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
    /// EdFiStaffSchoolAssociationGradeLevel
    /// </summary>
    [DataContract]
    public partial class EdFiStaffSchoolAssociationGradeLevel :  IEquatable<EdFiStaffSchoolAssociationGradeLevel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffSchoolAssociationGradeLevel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStaffSchoolAssociationGradeLevel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffSchoolAssociationGradeLevel" /> class.
        /// </summary>
        /// <param name="GradeLevelDescriptor">The set of grade levels for which the individual&#39;s assignment is responsible. (required).</param>
        public EdFiStaffSchoolAssociationGradeLevel(string GradeLevelDescriptor = default(string))
        {
            // to ensure "GradeLevelDescriptor" is required (not null)
            if (GradeLevelDescriptor == null)
            {
                throw new InvalidDataException("GradeLevelDescriptor is a required property for EdFiStaffSchoolAssociationGradeLevel and cannot be null");
            }
            else
            {
                this.GradeLevelDescriptor = GradeLevelDescriptor;
            }
        }
        
        /// <summary>
        /// The set of grade levels for which the individual&#39;s assignment is responsible.
        /// </summary>
        /// <value>The set of grade levels for which the individual&#39;s assignment is responsible.</value>
        [DataMember(Name="gradeLevelDescriptor", EmitDefaultValue=false)]
        public string GradeLevelDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStaffSchoolAssociationGradeLevel {\n");
            sb.Append("  GradeLevelDescriptor: ").Append(GradeLevelDescriptor).Append("\n");
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
            return this.Equals(input as EdFiStaffSchoolAssociationGradeLevel);
        }

        /// <summary>
        /// Returns true if EdFiStaffSchoolAssociationGradeLevel instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStaffSchoolAssociationGradeLevel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStaffSchoolAssociationGradeLevel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GradeLevelDescriptor == input.GradeLevelDescriptor ||
                    (this.GradeLevelDescriptor != null &&
                    this.GradeLevelDescriptor.Equals(input.GradeLevelDescriptor))
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
                if (this.GradeLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.GradeLevelDescriptor.GetHashCode();
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
            // GradeLevelDescriptor (string) maxLength
            if(this.GradeLevelDescriptor != null && this.GradeLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GradeLevelDescriptor, length must be less than 306.", new [] { "GradeLevelDescriptor" });
            }

            yield break;
        }
    }

}