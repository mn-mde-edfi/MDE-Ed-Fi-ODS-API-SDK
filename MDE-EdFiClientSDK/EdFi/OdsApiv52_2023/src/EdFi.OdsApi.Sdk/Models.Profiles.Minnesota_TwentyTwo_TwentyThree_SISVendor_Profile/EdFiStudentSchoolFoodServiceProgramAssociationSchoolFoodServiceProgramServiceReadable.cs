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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile
{
    /// <summary>
    /// EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable
    /// </summary>
    [DataContract]
    public partial class EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable :  IEquatable<EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable>
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
                throw new InvalidDataException("schoolFoodServiceProgramServiceDescriptor is a required property for EdFiStudentSchoolFoodServiceProgramAssociationSchoolFoodServiceProgramServiceReadable and cannot be null");
            }
            else
            {
                this.SchoolFoodServiceProgramServiceDescriptor = schoolFoodServiceProgramServiceDescriptor;
            }
        }
        
        /// <summary>
        /// Indicates the service being provided to the student by the School Food Service Program.
        /// </summary>
        /// <value>Indicates the service being provided to the student by the School Food Service Program.</value>
        [DataMember(Name="schoolFoodServiceProgramServiceDescriptor", EmitDefaultValue=false)]
        public string SchoolFoodServiceProgramServiceDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
                return false;

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
                    hashCode = hashCode * 59 + this.SchoolFoodServiceProgramServiceDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
