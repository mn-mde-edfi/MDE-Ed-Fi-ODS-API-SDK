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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile
{
    /// <summary>
    /// EdFiStudentEducationOrganizationAssociationStudentCharacteristicWritable
    /// </summary>
    [DataContract]
    public partial class EdFiStudentEducationOrganizationAssociationStudentCharacteristicWritable :  IEquatable<EdFiStudentEducationOrganizationAssociationStudentCharacteristicWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationStudentCharacteristicWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentEducationOrganizationAssociationStudentCharacteristicWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationStudentCharacteristicWritable" /> class.
        /// </summary>
        /// <param name="StudentCharacteristicDescriptor">The characteristic designated for the Student. (required).</param>
        public EdFiStudentEducationOrganizationAssociationStudentCharacteristicWritable(string StudentCharacteristicDescriptor = default(string))
        {
            // to ensure "StudentCharacteristicDescriptor" is required (not null)
            if (StudentCharacteristicDescriptor == null)
            {
                throw new InvalidDataException("StudentCharacteristicDescriptor is a required property for EdFiStudentEducationOrganizationAssociationStudentCharacteristicWritable and cannot be null");
            }
            else
            {
                this.StudentCharacteristicDescriptor = StudentCharacteristicDescriptor;
            }
        }
        
        /// <summary>
        /// The characteristic designated for the Student.
        /// </summary>
        /// <value>The characteristic designated for the Student.</value>
        [DataMember(Name="studentCharacteristicDescriptor", EmitDefaultValue=false)]
        public string StudentCharacteristicDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentEducationOrganizationAssociationStudentCharacteristicWritable {\n");
            sb.Append("  StudentCharacteristicDescriptor: ").Append(StudentCharacteristicDescriptor).Append("\n");
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
            return this.Equals(input as EdFiStudentEducationOrganizationAssociationStudentCharacteristicWritable);
        }

        /// <summary>
        /// Returns true if EdFiStudentEducationOrganizationAssociationStudentCharacteristicWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentEducationOrganizationAssociationStudentCharacteristicWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentEducationOrganizationAssociationStudentCharacteristicWritable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StudentCharacteristicDescriptor == input.StudentCharacteristicDescriptor ||
                    (this.StudentCharacteristicDescriptor != null &&
                    this.StudentCharacteristicDescriptor.Equals(input.StudentCharacteristicDescriptor))
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
                if (this.StudentCharacteristicDescriptor != null)
                    hashCode = hashCode * 59 + this.StudentCharacteristicDescriptor.GetHashCode();
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
            // StudentCharacteristicDescriptor (string) maxLength
            if(this.StudentCharacteristicDescriptor != null && this.StudentCharacteristicDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentCharacteristicDescriptor, length must be less than 306.", new [] { "StudentCharacteristicDescriptor" });
            }

            yield break;
        }
    }

}
