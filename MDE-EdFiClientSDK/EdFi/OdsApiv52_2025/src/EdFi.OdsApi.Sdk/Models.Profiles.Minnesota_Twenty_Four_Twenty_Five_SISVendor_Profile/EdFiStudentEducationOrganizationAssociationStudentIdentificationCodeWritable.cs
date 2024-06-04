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
    /// EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeWritable
    /// </summary>
    [DataContract(Name = "edFi_studentEducationOrganizationAssociationStudentIdentificationCode_writable")]
    public partial class EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeWritable : IEquatable<EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeWritable" /> class.
        /// </summary>
        /// <param name="studentIdentificationSystemDescriptor">A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student. (required).</param>
        /// <param name="assigningOrganizationIdentificationCode">The organization code or name assigning the StudentIdentificationCode. (required).</param>
        /// <param name="identificationCode">A unique number or alphanumeric code assigned to a student by a school, school system, a state, or other agency or entity. (required).</param>
        public EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeWritable(string studentIdentificationSystemDescriptor = default(string), string assigningOrganizationIdentificationCode = default(string), string identificationCode = default(string))
        {
            // to ensure "studentIdentificationSystemDescriptor" is required (not null)
            if (studentIdentificationSystemDescriptor == null)
            {
                throw new ArgumentNullException("studentIdentificationSystemDescriptor is a required property for EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeWritable and cannot be null");
            }
            this.StudentIdentificationSystemDescriptor = studentIdentificationSystemDescriptor;
            // to ensure "assigningOrganizationIdentificationCode" is required (not null)
            if (assigningOrganizationIdentificationCode == null)
            {
                throw new ArgumentNullException("assigningOrganizationIdentificationCode is a required property for EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeWritable and cannot be null");
            }
            this.AssigningOrganizationIdentificationCode = assigningOrganizationIdentificationCode;
            // to ensure "identificationCode" is required (not null)
            if (identificationCode == null)
            {
                throw new ArgumentNullException("identificationCode is a required property for EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeWritable and cannot be null");
            }
            this.IdentificationCode = identificationCode;
        }

        /// <summary>
        /// A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student.
        /// </summary>
        /// <value>A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student.</value>
        [DataMember(Name = "studentIdentificationSystemDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string StudentIdentificationSystemDescriptor { get; set; }

        /// <summary>
        /// The organization code or name assigning the StudentIdentificationCode.
        /// </summary>
        /// <value>The organization code or name assigning the StudentIdentificationCode.</value>
        [DataMember(Name = "assigningOrganizationIdentificationCode", IsRequired = true, EmitDefaultValue = false)]
        public string AssigningOrganizationIdentificationCode { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a student by a school, school system, a state, or other agency or entity.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to a student by a school, school system, a state, or other agency or entity.</value>
        [DataMember(Name = "identificationCode", IsRequired = true, EmitDefaultValue = false)]
        public string IdentificationCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeWritable {\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeWritable);
        }

        /// <summary>
        /// Returns true if EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeWritable input)
        {
            if (input == null)
            {
                return false;
            }
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
                {
                    hashCode = (hashCode * 59) + this.StudentIdentificationSystemDescriptor.GetHashCode();
                }
                if (this.AssigningOrganizationIdentificationCode != null)
                {
                    hashCode = (hashCode * 59) + this.AssigningOrganizationIdentificationCode.GetHashCode();
                }
                if (this.IdentificationCode != null)
                {
                    hashCode = (hashCode * 59) + this.IdentificationCode.GetHashCode();
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
            // StudentIdentificationSystemDescriptor (string) maxLength
            if (this.StudentIdentificationSystemDescriptor != null && this.StudentIdentificationSystemDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentIdentificationSystemDescriptor, length must be less than 306.", new [] { "StudentIdentificationSystemDescriptor" });
            }

            // AssigningOrganizationIdentificationCode (string) maxLength
            if (this.AssigningOrganizationIdentificationCode != null && this.AssigningOrganizationIdentificationCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssigningOrganizationIdentificationCode, length must be less than 60.", new [] { "AssigningOrganizationIdentificationCode" });
            }

            // IdentificationCode (string) maxLength
            if (this.IdentificationCode != null && this.IdentificationCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdentificationCode, length must be less than 60.", new [] { "IdentificationCode" });
            }

            yield break;
        }
    }

}
