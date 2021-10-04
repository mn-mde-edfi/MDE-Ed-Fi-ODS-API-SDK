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
    /// EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable
    /// </summary>
    [DataContract]
    public partial class EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable :  IEquatable<EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable" /> class.
        /// </summary>
        /// <param name="languageInstructionProgramServiceDescriptor">Indicates the service being provided to the student by the Language Instruction Program. (required).</param>
        public EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable(string languageInstructionProgramServiceDescriptor = default(string))
        {
            // to ensure "languageInstructionProgramServiceDescriptor" is required (not null)
            if (languageInstructionProgramServiceDescriptor == null)
            {
                throw new InvalidDataException("languageInstructionProgramServiceDescriptor is a required property for EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable and cannot be null");
            }
            else
            {
                this.LanguageInstructionProgramServiceDescriptor = languageInstructionProgramServiceDescriptor;
            }
        }
        
        /// <summary>
        /// Indicates the service being provided to the student by the Language Instruction Program.
        /// </summary>
        /// <value>Indicates the service being provided to the student by the Language Instruction Program.</value>
        [DataMember(Name="languageInstructionProgramServiceDescriptor", EmitDefaultValue=false)]
        public string LanguageInstructionProgramServiceDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable {\n");
            sb.Append("  LanguageInstructionProgramServiceDescriptor: ").Append(LanguageInstructionProgramServiceDescriptor).Append("\n");
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
            return this.Equals(input as EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable);
        }

        /// <summary>
        /// Returns true if EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LanguageInstructionProgramServiceDescriptor == input.LanguageInstructionProgramServiceDescriptor ||
                    (this.LanguageInstructionProgramServiceDescriptor != null &&
                    this.LanguageInstructionProgramServiceDescriptor.Equals(input.LanguageInstructionProgramServiceDescriptor))
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
                if (this.LanguageInstructionProgramServiceDescriptor != null)
                    hashCode = hashCode * 59 + this.LanguageInstructionProgramServiceDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
