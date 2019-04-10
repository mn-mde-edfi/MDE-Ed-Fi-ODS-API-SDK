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
    /// EdFiStaffPersonalIdentificationDocument
    /// </summary>
    [DataContract]
    public partial class EdFiStaffPersonalIdentificationDocument :  IEquatable<EdFiStaffPersonalIdentificationDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffPersonalIdentificationDocument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStaffPersonalIdentificationDocument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffPersonalIdentificationDocument" /> class.
        /// </summary>
        /// <param name="IdentificationDocumentUseDescriptor">The primary function of the document used for establishing identity. (required).</param>
        /// <param name="PersonalInformationVerificationDescriptor">The category of the document relative to its purpose. (required).</param>
        /// <param name="IssuerCountryDescriptor">Country of origin of the document. It is strongly recommended that entries use only ISO 3166 2-letter country codes..</param>
        /// <param name="DocumentExpirationDate">The day when the document  expires, if null then never expires..</param>
        /// <param name="DocumentTitle">The title of the document given by the issuer..</param>
        /// <param name="IssuerDocumentIdentificationCode">The unique identifier on the issuer&#39;s identification system..</param>
        /// <param name="IssuerName">Name of the entity or institution that issued the document..</param>
        public EdFiStaffPersonalIdentificationDocument(string IdentificationDocumentUseDescriptor = default(string), string PersonalInformationVerificationDescriptor = default(string), string IssuerCountryDescriptor = default(string), DateTime? DocumentExpirationDate = default(DateTime?), string DocumentTitle = default(string), string IssuerDocumentIdentificationCode = default(string), string IssuerName = default(string))
        {
            // to ensure "IdentificationDocumentUseDescriptor" is required (not null)
            if (IdentificationDocumentUseDescriptor == null)
            {
                throw new InvalidDataException("IdentificationDocumentUseDescriptor is a required property for EdFiStaffPersonalIdentificationDocument and cannot be null");
            }
            else
            {
                this.IdentificationDocumentUseDescriptor = IdentificationDocumentUseDescriptor;
            }
            // to ensure "PersonalInformationVerificationDescriptor" is required (not null)
            if (PersonalInformationVerificationDescriptor == null)
            {
                throw new InvalidDataException("PersonalInformationVerificationDescriptor is a required property for EdFiStaffPersonalIdentificationDocument and cannot be null");
            }
            else
            {
                this.PersonalInformationVerificationDescriptor = PersonalInformationVerificationDescriptor;
            }
            this.IssuerCountryDescriptor = IssuerCountryDescriptor;
            this.DocumentExpirationDate = DocumentExpirationDate;
            this.DocumentTitle = DocumentTitle;
            this.IssuerDocumentIdentificationCode = IssuerDocumentIdentificationCode;
            this.IssuerName = IssuerName;
        }
        
        /// <summary>
        /// The primary function of the document used for establishing identity.
        /// </summary>
        /// <value>The primary function of the document used for establishing identity.</value>
        [DataMember(Name="identificationDocumentUseDescriptor", EmitDefaultValue=false)]
        public string IdentificationDocumentUseDescriptor { get; set; }

        /// <summary>
        /// The category of the document relative to its purpose.
        /// </summary>
        /// <value>The category of the document relative to its purpose.</value>
        [DataMember(Name="personalInformationVerificationDescriptor", EmitDefaultValue=false)]
        public string PersonalInformationVerificationDescriptor { get; set; }

        /// <summary>
        /// Country of origin of the document. It is strongly recommended that entries use only ISO 3166 2-letter country codes.
        /// </summary>
        /// <value>Country of origin of the document. It is strongly recommended that entries use only ISO 3166 2-letter country codes.</value>
        [DataMember(Name="issuerCountryDescriptor", EmitDefaultValue=false)]
        public string IssuerCountryDescriptor { get; set; }

        /// <summary>
        /// The day when the document  expires, if null then never expires.
        /// </summary>
        /// <value>The day when the document  expires, if null then never expires.</value>
        [DataMember(Name="documentExpirationDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DocumentExpirationDate { get; set; }

        /// <summary>
        /// The title of the document given by the issuer.
        /// </summary>
        /// <value>The title of the document given by the issuer.</value>
        [DataMember(Name="documentTitle", EmitDefaultValue=false)]
        public string DocumentTitle { get; set; }

        /// <summary>
        /// The unique identifier on the issuer&#39;s identification system.
        /// </summary>
        /// <value>The unique identifier on the issuer&#39;s identification system.</value>
        [DataMember(Name="issuerDocumentIdentificationCode", EmitDefaultValue=false)]
        public string IssuerDocumentIdentificationCode { get; set; }

        /// <summary>
        /// Name of the entity or institution that issued the document.
        /// </summary>
        /// <value>Name of the entity or institution that issued the document.</value>
        [DataMember(Name="issuerName", EmitDefaultValue=false)]
        public string IssuerName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStaffPersonalIdentificationDocument {\n");
            sb.Append("  IdentificationDocumentUseDescriptor: ").Append(IdentificationDocumentUseDescriptor).Append("\n");
            sb.Append("  PersonalInformationVerificationDescriptor: ").Append(PersonalInformationVerificationDescriptor).Append("\n");
            sb.Append("  IssuerCountryDescriptor: ").Append(IssuerCountryDescriptor).Append("\n");
            sb.Append("  DocumentExpirationDate: ").Append(DocumentExpirationDate).Append("\n");
            sb.Append("  DocumentTitle: ").Append(DocumentTitle).Append("\n");
            sb.Append("  IssuerDocumentIdentificationCode: ").Append(IssuerDocumentIdentificationCode).Append("\n");
            sb.Append("  IssuerName: ").Append(IssuerName).Append("\n");
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
            return this.Equals(input as EdFiStaffPersonalIdentificationDocument);
        }

        /// <summary>
        /// Returns true if EdFiStaffPersonalIdentificationDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStaffPersonalIdentificationDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStaffPersonalIdentificationDocument input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdentificationDocumentUseDescriptor == input.IdentificationDocumentUseDescriptor ||
                    (this.IdentificationDocumentUseDescriptor != null &&
                    this.IdentificationDocumentUseDescriptor.Equals(input.IdentificationDocumentUseDescriptor))
                ) && 
                (
                    this.PersonalInformationVerificationDescriptor == input.PersonalInformationVerificationDescriptor ||
                    (this.PersonalInformationVerificationDescriptor != null &&
                    this.PersonalInformationVerificationDescriptor.Equals(input.PersonalInformationVerificationDescriptor))
                ) && 
                (
                    this.IssuerCountryDescriptor == input.IssuerCountryDescriptor ||
                    (this.IssuerCountryDescriptor != null &&
                    this.IssuerCountryDescriptor.Equals(input.IssuerCountryDescriptor))
                ) && 
                (
                    this.DocumentExpirationDate == input.DocumentExpirationDate ||
                    (this.DocumentExpirationDate != null &&
                    this.DocumentExpirationDate.Equals(input.DocumentExpirationDate))
                ) && 
                (
                    this.DocumentTitle == input.DocumentTitle ||
                    (this.DocumentTitle != null &&
                    this.DocumentTitle.Equals(input.DocumentTitle))
                ) && 
                (
                    this.IssuerDocumentIdentificationCode == input.IssuerDocumentIdentificationCode ||
                    (this.IssuerDocumentIdentificationCode != null &&
                    this.IssuerDocumentIdentificationCode.Equals(input.IssuerDocumentIdentificationCode))
                ) && 
                (
                    this.IssuerName == input.IssuerName ||
                    (this.IssuerName != null &&
                    this.IssuerName.Equals(input.IssuerName))
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
                if (this.IdentificationDocumentUseDescriptor != null)
                    hashCode = hashCode * 59 + this.IdentificationDocumentUseDescriptor.GetHashCode();
                if (this.PersonalInformationVerificationDescriptor != null)
                    hashCode = hashCode * 59 + this.PersonalInformationVerificationDescriptor.GetHashCode();
                if (this.IssuerCountryDescriptor != null)
                    hashCode = hashCode * 59 + this.IssuerCountryDescriptor.GetHashCode();
                if (this.DocumentExpirationDate != null)
                    hashCode = hashCode * 59 + this.DocumentExpirationDate.GetHashCode();
                if (this.DocumentTitle != null)
                    hashCode = hashCode * 59 + this.DocumentTitle.GetHashCode();
                if (this.IssuerDocumentIdentificationCode != null)
                    hashCode = hashCode * 59 + this.IssuerDocumentIdentificationCode.GetHashCode();
                if (this.IssuerName != null)
                    hashCode = hashCode * 59 + this.IssuerName.GetHashCode();
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
            // IdentificationDocumentUseDescriptor (string) maxLength
            if(this.IdentificationDocumentUseDescriptor != null && this.IdentificationDocumentUseDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdentificationDocumentUseDescriptor, length must be less than 306.", new [] { "IdentificationDocumentUseDescriptor" });
            }

            // PersonalInformationVerificationDescriptor (string) maxLength
            if(this.PersonalInformationVerificationDescriptor != null && this.PersonalInformationVerificationDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PersonalInformationVerificationDescriptor, length must be less than 306.", new [] { "PersonalInformationVerificationDescriptor" });
            }

            // IssuerCountryDescriptor (string) maxLength
            if(this.IssuerCountryDescriptor != null && this.IssuerCountryDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssuerCountryDescriptor, length must be less than 306.", new [] { "IssuerCountryDescriptor" });
            }

            // DocumentTitle (string) maxLength
            if(this.DocumentTitle != null && this.DocumentTitle.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocumentTitle, length must be less than 60.", new [] { "DocumentTitle" });
            }

            // IssuerDocumentIdentificationCode (string) maxLength
            if(this.IssuerDocumentIdentificationCode != null && this.IssuerDocumentIdentificationCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssuerDocumentIdentificationCode, length must be less than 60.", new [] { "IssuerDocumentIdentificationCode" });
            }

            // IssuerName (string) maxLength
            if(this.IssuerName != null && this.IssuerName.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssuerName, length must be less than 150.", new [] { "IssuerName" });
            }

            yield break;
        }
    }

}
