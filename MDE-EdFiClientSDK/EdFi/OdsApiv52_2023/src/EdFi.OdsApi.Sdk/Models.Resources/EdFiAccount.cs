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
    /// EdFiAccount
    /// </summary>
    [DataContract]
    public partial class EdFiAccount :  IEquatable<EdFiAccount>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiAccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAccount" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="accountCodes">An unordered collection of accountAccountCodes. The set of account codes defined for the education accounting system organized by account code type (e.g., fund, function, object) that map to the account. (required).</param>
        /// <param name="accountIdentifier">The alphanumeric string that identifies the account. (required).</param>
        /// <param name="fiscalYear">The financial accounting year. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="accountName">A descriptive name for the account..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiAccount(string id = default(string), List<EdFiAccountAccountCode> accountCodes = default(List<EdFiAccountAccountCode>), string accountIdentifier = default(string), int? fiscalYear = default(int?), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), string accountName = default(string), string etag = default(string))
        {
            // to ensure "accountCodes" is required (not null)
            if (accountCodes == null)
            {
                throw new InvalidDataException("accountCodes is a required property for EdFiAccount and cannot be null");
            }
            else
            {
                this.AccountCodes = accountCodes;
            }
            // to ensure "accountIdentifier" is required (not null)
            if (accountIdentifier == null)
            {
                throw new InvalidDataException("accountIdentifier is a required property for EdFiAccount and cannot be null");
            }
            else
            {
                this.AccountIdentifier = accountIdentifier;
            }
            // to ensure "fiscalYear" is required (not null)
            if (fiscalYear == null)
            {
                throw new InvalidDataException("fiscalYear is a required property for EdFiAccount and cannot be null");
            }
            else
            {
                this.FiscalYear = fiscalYear;
            }
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new InvalidDataException("educationOrganizationReference is a required property for EdFiAccount and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = educationOrganizationReference;
            }
            this.Id = id;
            this.AccountName = accountName;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// An unordered collection of accountAccountCodes. The set of account codes defined for the education accounting system organized by account code type (e.g., fund, function, object) that map to the account.
        /// </summary>
        /// <value>An unordered collection of accountAccountCodes. The set of account codes defined for the education accounting system organized by account code type (e.g., fund, function, object) that map to the account.</value>
        [DataMember(Name="accountCodes", EmitDefaultValue=false)]
        public List<EdFiAccountAccountCode> AccountCodes { get; set; }

        /// <summary>
        /// The alphanumeric string that identifies the account.
        /// </summary>
        /// <value>The alphanumeric string that identifies the account.</value>
        [DataMember(Name="accountIdentifier", EmitDefaultValue=false)]
        public string AccountIdentifier { get; set; }

        /// <summary>
        /// The financial accounting year.
        /// </summary>
        /// <value>The financial accounting year.</value>
        [DataMember(Name="fiscalYear", EmitDefaultValue=false)]
        public int? FiscalYear { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name="educationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// A descriptive name for the account.
        /// </summary>
        /// <value>A descriptive name for the account.</value>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiAccount {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountCodes: ").Append(AccountCodes).Append("\n");
            sb.Append("  AccountIdentifier: ").Append(AccountIdentifier).Append("\n");
            sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            return this.Equals(input as EdFiAccount);
        }

        /// <summary>
        /// Returns true if EdFiAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AccountCodes == input.AccountCodes ||
                    this.AccountCodes != null &&
                    this.AccountCodes.SequenceEqual(input.AccountCodes)
                ) && 
                (
                    this.AccountIdentifier == input.AccountIdentifier ||
                    (this.AccountIdentifier != null &&
                    this.AccountIdentifier.Equals(input.AccountIdentifier))
                ) && 
                (
                    this.FiscalYear == input.FiscalYear ||
                    (this.FiscalYear != null &&
                    this.FiscalYear.Equals(input.FiscalYear))
                ) && 
                (
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AccountCodes != null)
                    hashCode = hashCode * 59 + this.AccountCodes.GetHashCode();
                if (this.AccountIdentifier != null)
                    hashCode = hashCode * 59 + this.AccountIdentifier.GetHashCode();
                if (this.FiscalYear != null)
                    hashCode = hashCode * 59 + this.FiscalYear.GetHashCode();
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
