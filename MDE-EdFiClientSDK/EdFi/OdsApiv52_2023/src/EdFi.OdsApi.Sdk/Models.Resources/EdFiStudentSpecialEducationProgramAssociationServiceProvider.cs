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
    /// EdFiStudentSpecialEducationProgramAssociationServiceProvider
    /// </summary>
    [DataContract]
    public partial class EdFiStudentSpecialEducationProgramAssociationServiceProvider :  IEquatable<EdFiStudentSpecialEducationProgramAssociationServiceProvider>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSpecialEducationProgramAssociationServiceProvider" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentSpecialEducationProgramAssociationServiceProvider() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSpecialEducationProgramAssociationServiceProvider" /> class.
        /// </summary>
        /// <param name="primaryProvider">Primary ServiceProvider..</param>
        /// <param name="staffReference">staffReference (required).</param>
        public EdFiStudentSpecialEducationProgramAssociationServiceProvider(bool? primaryProvider = default(bool?), EdFiStaffReference staffReference = default(EdFiStaffReference))
        {
            // to ensure "staffReference" is required (not null)
            if (staffReference == null)
            {
                throw new InvalidDataException("staffReference is a required property for EdFiStudentSpecialEducationProgramAssociationServiceProvider and cannot be null");
            }
            else
            {
                this.StaffReference = staffReference;
            }
            this.PrimaryProvider = primaryProvider;
        }
        
        /// <summary>
        /// Primary ServiceProvider.
        /// </summary>
        /// <value>Primary ServiceProvider.</value>
        [DataMember(Name="primaryProvider", EmitDefaultValue=false)]
        public bool? PrimaryProvider { get; set; }

        /// <summary>
        /// Gets or Sets StaffReference
        /// </summary>
        [DataMember(Name="staffReference", EmitDefaultValue=false)]
        public EdFiStaffReference StaffReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentSpecialEducationProgramAssociationServiceProvider {\n");
            sb.Append("  PrimaryProvider: ").Append(PrimaryProvider).Append("\n");
            sb.Append("  StaffReference: ").Append(StaffReference).Append("\n");
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
            return this.Equals(input as EdFiStudentSpecialEducationProgramAssociationServiceProvider);
        }

        /// <summary>
        /// Returns true if EdFiStudentSpecialEducationProgramAssociationServiceProvider instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentSpecialEducationProgramAssociationServiceProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentSpecialEducationProgramAssociationServiceProvider input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrimaryProvider == input.PrimaryProvider ||
                    (this.PrimaryProvider != null &&
                    this.PrimaryProvider.Equals(input.PrimaryProvider))
                ) && 
                (
                    this.StaffReference == input.StaffReference ||
                    (this.StaffReference != null &&
                    this.StaffReference.Equals(input.StaffReference))
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
                if (this.PrimaryProvider != null)
                    hashCode = hashCode * 59 + this.PrimaryProvider.GetHashCode();
                if (this.StaffReference != null)
                    hashCode = hashCode * 59 + this.StaffReference.GetHashCode();
                return hashCode;
            }
        }
    }

}
