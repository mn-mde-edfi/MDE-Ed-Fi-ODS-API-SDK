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

namespace EdFi.OdsApi.Sdk.Models.Identity
{
    /// <summary>
    /// EdFiStudentEducationOrganizationAssociationStudentIdentificationCode
    /// </summary>
    [DataContract]
    public partial class EdFiStudentEducationOrganizationAssociationStudentIdentificationCode :  IEquatable<EdFiStudentEducationOrganizationAssociationStudentIdentificationCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationStudentIdentificationCode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentEducationOrganizationAssociationStudentIdentificationCode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationStudentIdentificationCode" /> class.
        /// </summary>
        /// <param name="studentIdentificationSystemDescriptor">A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student. (required).</param>
        /// <param name="assigningOrganizationIdentificationCode">The organization code or name assigning the StudentIdentificationCode. (required).</param>
        /// <param name="identificationCode">A unique number or alphanumeric code assigned to a student by a school, school system, a state, or other agency or entity. (required).</param>
        public EdFiStudentEducationOrganizationAssociationStudentIdentificationCode(string studentIdentificationSystemDescriptor = default(string), string assigningOrganizationIdentificationCode = default(string), string identificationCode = default(string))
        {
            // to ensure "studentIdentificationSystemDescriptor" is required (not null)
            if (studentIdentificationSystemDescriptor == null)
            {
                throw new InvalidDataException("studentIdentificationSystemDescriptor is a required property for EdFiStudentEducationOrganizationAssociationStudentIdentificationCode and cannot be null");
            }
            else
            {
                this.StudentIdentificationSystemDescriptor = studentIdentificationSystemDescriptor;
            }
            // to ensure "assigningOrganizationIdentificationCode" is required (not null)
            if (assigningOrganizationIdentificationCode == null)
            {
                throw new InvalidDataException("assigningOrganizationIdentificationCode is a required property for EdFiStudentEducationOrganizationAssociationStudentIdentificationCode and cannot be null");
            }
            else
            {
                this.AssigningOrganizationIdentificationCode = assigningOrganizationIdentificationCode;
            }
            // to ensure "identificationCode" is required (not null)
            if (identificationCode == null)
            {
                throw new InvalidDataException("identificationCode is a required property for EdFiStudentEducationOrganizationAssociationStudentIdentificationCode and cannot be null");
            }
            else
            {
                this.IdentificationCode = identificationCode;
            }
        }
        
        /// <summary>
        /// A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student.
        /// </summary>
        /// <value>A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student.</value>
        [DataMember(Name="studentIdentificationSystemDescriptor", EmitDefaultValue=false)]
        public string StudentIdentificationSystemDescriptor { get; set; }

        /// <summary>
        /// The organization code or name assigning the StudentIdentificationCode.
        /// </summary>
        /// <value>The organization code or name assigning the StudentIdentificationCode.</value>
        [DataMember(Name="assigningOrganizationIdentificationCode", EmitDefaultValue=false)]
        public string AssigningOrganizationIdentificationCode { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a student by a school, school system, a state, or other agency or entity.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to a student by a school, school system, a state, or other agency or entity.</value>
        [DataMember(Name="identificationCode", EmitDefaultValue=false)]
        public string IdentificationCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentEducationOrganizationAssociationStudentIdentificationCode {\n");
            sb.Append("  StudentIdentificationSystemDescriptor: ").Append(StudentIdentificationSystemDescriptor).Append("\n");
            sb.Append("  AssigningOrganizationIdentificationCode: ").Append(AssigningOrganizationIdentificationCode).Append("\n");
            sb.Append("  IdentificationCode: ").Append(IdentificationCode).Append("\n");
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
            return this.Equals(input as EdFiStudentEducationOrganizationAssociationStudentIdentificationCode);
        }

        /// <summary>
        /// Returns true if EdFiStudentEducationOrganizationAssociationStudentIdentificationCode instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentEducationOrganizationAssociationStudentIdentificationCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentEducationOrganizationAssociationStudentIdentificationCode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StudentIdentificationSystemDescriptor == input.StudentIdentificationSystemDescriptor ||
                    (this.StudentIdentificationSystemDescriptor != null &&
                    this.StudentIdentificationSystemDescriptor.Equals(input.StudentIdentificationSystemDescriptor))
                ) && 
                (
                    this.AssigningOrganizationIdentificationCode == input.AssigningOrganizationIdentificationCode ||
                    (this.AssigningOrganizationIdentificationCode != null &&
                    this.AssigningOrganizationIdentificationCode.Equals(input.AssigningOrganizationIdentificationCode))
                ) && 
                (
                    this.IdentificationCode == input.IdentificationCode ||
                    (this.IdentificationCode != null &&
                    this.IdentificationCode.Equals(input.IdentificationCode))
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
                if (this.StudentIdentificationSystemDescriptor != null)
                    hashCode = hashCode * 59 + this.StudentIdentificationSystemDescriptor.GetHashCode();
                if (this.AssigningOrganizationIdentificationCode != null)
                    hashCode = hashCode * 59 + this.AssigningOrganizationIdentificationCode.GetHashCode();
                if (this.IdentificationCode != null)
                    hashCode = hashCode * 59 + this.IdentificationCode.GetHashCode();
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
            // StudentIdentificationSystemDescriptor (string) maxLength
            if(this.StudentIdentificationSystemDescriptor != null && this.StudentIdentificationSystemDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentIdentificationSystemDescriptor, length must be less than 306.", new [] { "StudentIdentificationSystemDescriptor" });
            }

            // AssigningOrganizationIdentificationCode (string) maxLength
            if(this.AssigningOrganizationIdentificationCode != null && this.AssigningOrganizationIdentificationCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssigningOrganizationIdentificationCode, length must be less than 60.", new [] { "AssigningOrganizationIdentificationCode" });
            }

            // IdentificationCode (string) maxLength
            if(this.IdentificationCode != null && this.IdentificationCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdentificationCode, length must be less than 60.", new [] { "IdentificationCode" });
            }

            yield break;
        }
    }

}
