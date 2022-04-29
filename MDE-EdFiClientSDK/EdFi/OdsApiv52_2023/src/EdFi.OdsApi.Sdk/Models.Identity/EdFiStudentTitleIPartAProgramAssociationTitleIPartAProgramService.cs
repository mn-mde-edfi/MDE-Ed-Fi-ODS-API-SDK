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
    /// EdFiStudentTitleIPartAProgramAssociationTitleIPartAProgramService
    /// </summary>
    [DataContract]
    public partial class EdFiStudentTitleIPartAProgramAssociationTitleIPartAProgramService :  IEquatable<EdFiStudentTitleIPartAProgramAssociationTitleIPartAProgramService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentTitleIPartAProgramAssociationTitleIPartAProgramService" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentTitleIPartAProgramAssociationTitleIPartAProgramService() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentTitleIPartAProgramAssociationTitleIPartAProgramService" /> class.
        /// </summary>
        /// <param name="titleIPartAProgramServiceDescriptor">Indicates the service being provided to the student by the Title I Part A Program. (required).</param>
        /// <param name="primaryIndicator">True if service is a primary service..</param>
        /// <param name="serviceBeginDate">First date the Student was in this option for the current school year..</param>
        /// <param name="serviceEndDate">Last date the Student was in this option for the current school year..</param>
        public EdFiStudentTitleIPartAProgramAssociationTitleIPartAProgramService(string titleIPartAProgramServiceDescriptor = default(string), bool? primaryIndicator = default(bool?), DateTime? serviceBeginDate = default(DateTime?), DateTime? serviceEndDate = default(DateTime?))
        {
            // to ensure "titleIPartAProgramServiceDescriptor" is required (not null)
            if (titleIPartAProgramServiceDescriptor == null)
            {
                throw new InvalidDataException("titleIPartAProgramServiceDescriptor is a required property for EdFiStudentTitleIPartAProgramAssociationTitleIPartAProgramService and cannot be null");
            }
            else
            {
                this.TitleIPartAProgramServiceDescriptor = titleIPartAProgramServiceDescriptor;
            }
            this.PrimaryIndicator = primaryIndicator;
            this.ServiceBeginDate = serviceBeginDate;
            this.ServiceEndDate = serviceEndDate;
        }
        
        /// <summary>
        /// Indicates the service being provided to the student by the Title I Part A Program.
        /// </summary>
        /// <value>Indicates the service being provided to the student by the Title I Part A Program.</value>
        [DataMember(Name="titleIPartAProgramServiceDescriptor", EmitDefaultValue=false)]
        public string TitleIPartAProgramServiceDescriptor { get; set; }

        /// <summary>
        /// True if service is a primary service.
        /// </summary>
        /// <value>True if service is a primary service.</value>
        [DataMember(Name="primaryIndicator", EmitDefaultValue=false)]
        public bool? PrimaryIndicator { get; set; }

        /// <summary>
        /// First date the Student was in this option for the current school year.
        /// </summary>
        /// <value>First date the Student was in this option for the current school year.</value>
        [DataMember(Name="serviceBeginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ServiceBeginDate { get; set; }

        /// <summary>
        /// Last date the Student was in this option for the current school year.
        /// </summary>
        /// <value>Last date the Student was in this option for the current school year.</value>
        [DataMember(Name="serviceEndDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ServiceEndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentTitleIPartAProgramAssociationTitleIPartAProgramService {\n");
            sb.Append("  TitleIPartAProgramServiceDescriptor: ").Append(TitleIPartAProgramServiceDescriptor).Append("\n");
            sb.Append("  PrimaryIndicator: ").Append(PrimaryIndicator).Append("\n");
            sb.Append("  ServiceBeginDate: ").Append(ServiceBeginDate).Append("\n");
            sb.Append("  ServiceEndDate: ").Append(ServiceEndDate).Append("\n");
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
            return this.Equals(input as EdFiStudentTitleIPartAProgramAssociationTitleIPartAProgramService);
        }

        /// <summary>
        /// Returns true if EdFiStudentTitleIPartAProgramAssociationTitleIPartAProgramService instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentTitleIPartAProgramAssociationTitleIPartAProgramService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentTitleIPartAProgramAssociationTitleIPartAProgramService input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TitleIPartAProgramServiceDescriptor == input.TitleIPartAProgramServiceDescriptor ||
                    (this.TitleIPartAProgramServiceDescriptor != null &&
                    this.TitleIPartAProgramServiceDescriptor.Equals(input.TitleIPartAProgramServiceDescriptor))
                ) && 
                (
                    this.PrimaryIndicator == input.PrimaryIndicator ||
                    (this.PrimaryIndicator != null &&
                    this.PrimaryIndicator.Equals(input.PrimaryIndicator))
                ) && 
                (
                    this.ServiceBeginDate == input.ServiceBeginDate ||
                    (this.ServiceBeginDate != null &&
                    this.ServiceBeginDate.Equals(input.ServiceBeginDate))
                ) && 
                (
                    this.ServiceEndDate == input.ServiceEndDate ||
                    (this.ServiceEndDate != null &&
                    this.ServiceEndDate.Equals(input.ServiceEndDate))
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
                if (this.TitleIPartAProgramServiceDescriptor != null)
                    hashCode = hashCode * 59 + this.TitleIPartAProgramServiceDescriptor.GetHashCode();
                if (this.PrimaryIndicator != null)
                    hashCode = hashCode * 59 + this.PrimaryIndicator.GetHashCode();
                if (this.ServiceBeginDate != null)
                    hashCode = hashCode * 59 + this.ServiceBeginDate.GetHashCode();
                if (this.ServiceEndDate != null)
                    hashCode = hashCode * 59 + this.ServiceEndDate.GetHashCode();
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
            // TitleIPartAProgramServiceDescriptor (string) maxLength
            if(this.TitleIPartAProgramServiceDescriptor != null && this.TitleIPartAProgramServiceDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TitleIPartAProgramServiceDescriptor, length must be less than 306.", new [] { "TitleIPartAProgramServiceDescriptor" });
            }

            yield break;
        }
    }

}
