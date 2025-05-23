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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile
{
    /// <summary>
    /// EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable
    /// </summary>
    [DataContract(Name = "edFi_studentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramService_readable")]
    public partial class EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable : IEquatable<EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable" /> class.
        /// </summary>
        /// <param name="schoolFoodServiceProgramServiceDescriptor">Indicates the service being provided to the student by the School Food Service Program. (required).</param>
        public EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable(string schoolFoodServiceProgramServiceDescriptor = default(string))
        {
            // to ensure "schoolFoodServiceProgramServiceDescriptor" is required (not null)
            if (schoolFoodServiceProgramServiceDescriptor == null)
            {
                throw new ArgumentNullException("schoolFoodServiceProgramServiceDescriptor is a required property for EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable and cannot be null");
            }
            this.SchoolFoodServiceProgramServiceDescriptor = schoolFoodServiceProgramServiceDescriptor;
        }

        /// <summary>
        /// Indicates the service being provided to the student by the School Food Service Program.
        /// </summary>
        /// <value>Indicates the service being provided to the student by the School Food Service Program.</value>
        [DataMember(Name = "schoolFoodServiceProgramServiceDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string SchoolFoodServiceProgramServiceDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable {\n");
            sb.Append("  SchoolFoodServiceProgramServiceDescriptor: ").Append(SchoolFoodServiceProgramServiceDescriptor).Append("\n");
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
            return this.Equals(input as EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable);
        }

        /// <summary>
        /// Returns true if EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SchoolFoodServiceProgramServiceDescriptor == input.SchoolFoodServiceProgramServiceDescriptor ||
                    (this.SchoolFoodServiceProgramServiceDescriptor != null &&
                    this.SchoolFoodServiceProgramServiceDescriptor.Equals(input.SchoolFoodServiceProgramServiceDescriptor))
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
                if (this.SchoolFoodServiceProgramServiceDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolFoodServiceProgramServiceDescriptor.GetHashCode();
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
            // SchoolFoodServiceProgramServiceDescriptor (string) maxLength
            if (this.SchoolFoodServiceProgramServiceDescriptor != null && this.SchoolFoodServiceProgramServiceDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SchoolFoodServiceProgramServiceDescriptor, length must be less than 306.", new [] { "SchoolFoodServiceProgramServiceDescriptor" });
            }

            yield break;
        }
    }

}
