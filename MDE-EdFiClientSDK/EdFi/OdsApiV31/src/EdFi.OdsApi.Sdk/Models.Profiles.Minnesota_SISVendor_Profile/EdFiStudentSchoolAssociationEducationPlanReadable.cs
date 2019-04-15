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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile
{
    /// <summary>
    /// EdFiStudentSchoolAssociationEducationPlanReadable
    /// </summary>
    [DataContract]
    public partial class EdFiStudentSchoolAssociationEducationPlanReadable :  IEquatable<EdFiStudentSchoolAssociationEducationPlanReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSchoolAssociationEducationPlanReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentSchoolAssociationEducationPlanReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSchoolAssociationEducationPlanReadable" /> class.
        /// </summary>
        /// <param name="EducationPlanDescriptor">The type of education plan(s) the student is following, if appropriate. (required).</param>
        public EdFiStudentSchoolAssociationEducationPlanReadable(string EducationPlanDescriptor = default(string))
        {
            // to ensure "EducationPlanDescriptor" is required (not null)
            if (EducationPlanDescriptor == null)
            {
                throw new InvalidDataException("EducationPlanDescriptor is a required property for EdFiStudentSchoolAssociationEducationPlanReadable and cannot be null");
            }
            else
            {
                this.EducationPlanDescriptor = EducationPlanDescriptor;
            }
        }
        
        /// <summary>
        /// The type of education plan(s) the student is following, if appropriate.
        /// </summary>
        /// <value>The type of education plan(s) the student is following, if appropriate.</value>
        [DataMember(Name="educationPlanDescriptor", EmitDefaultValue=false)]
        public string EducationPlanDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentSchoolAssociationEducationPlanReadable {\n");
            sb.Append("  EducationPlanDescriptor: ").Append(EducationPlanDescriptor).Append("\n");
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
            return this.Equals(input as EdFiStudentSchoolAssociationEducationPlanReadable);
        }

        /// <summary>
        /// Returns true if EdFiStudentSchoolAssociationEducationPlanReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentSchoolAssociationEducationPlanReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentSchoolAssociationEducationPlanReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EducationPlanDescriptor == input.EducationPlanDescriptor ||
                    (this.EducationPlanDescriptor != null &&
                    this.EducationPlanDescriptor.Equals(input.EducationPlanDescriptor))
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
                if (this.EducationPlanDescriptor != null)
                    hashCode = hashCode * 59 + this.EducationPlanDescriptor.GetHashCode();
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
            // EducationPlanDescriptor (string) maxLength
            if(this.EducationPlanDescriptor != null && this.EducationPlanDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EducationPlanDescriptor, length must be less than 306.", new [] { "EducationPlanDescriptor" });
            }

            yield break;
        }
    }

}
