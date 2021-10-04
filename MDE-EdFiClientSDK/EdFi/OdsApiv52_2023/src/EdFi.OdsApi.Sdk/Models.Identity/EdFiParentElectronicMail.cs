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

namespace EdFi.OdsApi.Sdk.Models.Identity
{
    /// <summary>
    /// EdFiParentElectronicMail
    /// </summary>
    [DataContract]
    public partial class EdFiParentElectronicMail :  IEquatable<EdFiParentElectronicMail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiParentElectronicMail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiParentElectronicMail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiParentElectronicMail" /> class.
        /// </summary>
        /// <param name="electronicMailTypeDescriptor">The type of email listed for an individual or organization. For example: Home/Personal, Work, etc.) (required).</param>
        /// <param name="electronicMailAddress">The electronic mail (e-mail) address listed for an individual or organization. (required).</param>
        /// <param name="doNotPublishIndicator">An indication that the electronic email address should not be published..</param>
        /// <param name="primaryEmailAddressIndicator">An indication that the electronic mail address should be used as the principal electronic mail address for an individual or organization..</param>
        public EdFiParentElectronicMail(string electronicMailTypeDescriptor = default(string), string electronicMailAddress = default(string), bool? doNotPublishIndicator = default(bool?), bool? primaryEmailAddressIndicator = default(bool?))
        {
            // to ensure "electronicMailTypeDescriptor" is required (not null)
            if (electronicMailTypeDescriptor == null)
            {
                throw new InvalidDataException("electronicMailTypeDescriptor is a required property for EdFiParentElectronicMail and cannot be null");
            }
            else
            {
                this.ElectronicMailTypeDescriptor = electronicMailTypeDescriptor;
            }
            // to ensure "electronicMailAddress" is required (not null)
            if (electronicMailAddress == null)
            {
                throw new InvalidDataException("electronicMailAddress is a required property for EdFiParentElectronicMail and cannot be null");
            }
            else
            {
                this.ElectronicMailAddress = electronicMailAddress;
            }
            this.DoNotPublishIndicator = doNotPublishIndicator;
            this.PrimaryEmailAddressIndicator = primaryEmailAddressIndicator;
        }
        
        /// <summary>
        /// The type of email listed for an individual or organization. For example: Home/Personal, Work, etc.)
        /// </summary>
        /// <value>The type of email listed for an individual or organization. For example: Home/Personal, Work, etc.)</value>
        [DataMember(Name="electronicMailTypeDescriptor", EmitDefaultValue=false)]
        public string ElectronicMailTypeDescriptor { get; set; }

        /// <summary>
        /// The electronic mail (e-mail) address listed for an individual or organization.
        /// </summary>
        /// <value>The electronic mail (e-mail) address listed for an individual or organization.</value>
        [DataMember(Name="electronicMailAddress", EmitDefaultValue=false)]
        public string ElectronicMailAddress { get; set; }

        /// <summary>
        /// An indication that the electronic email address should not be published.
        /// </summary>
        /// <value>An indication that the electronic email address should not be published.</value>
        [DataMember(Name="doNotPublishIndicator", EmitDefaultValue=false)]
        public bool? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// An indication that the electronic mail address should be used as the principal electronic mail address for an individual or organization.
        /// </summary>
        /// <value>An indication that the electronic mail address should be used as the principal electronic mail address for an individual or organization.</value>
        [DataMember(Name="primaryEmailAddressIndicator", EmitDefaultValue=false)]
        public bool? PrimaryEmailAddressIndicator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiParentElectronicMail {\n");
            sb.Append("  ElectronicMailTypeDescriptor: ").Append(ElectronicMailTypeDescriptor).Append("\n");
            sb.Append("  ElectronicMailAddress: ").Append(ElectronicMailAddress).Append("\n");
            sb.Append("  DoNotPublishIndicator: ").Append(DoNotPublishIndicator).Append("\n");
            sb.Append("  PrimaryEmailAddressIndicator: ").Append(PrimaryEmailAddressIndicator).Append("\n");
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
            return this.Equals(input as EdFiParentElectronicMail);
        }

        /// <summary>
        /// Returns true if EdFiParentElectronicMail instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiParentElectronicMail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiParentElectronicMail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ElectronicMailTypeDescriptor == input.ElectronicMailTypeDescriptor ||
                    (this.ElectronicMailTypeDescriptor != null &&
                    this.ElectronicMailTypeDescriptor.Equals(input.ElectronicMailTypeDescriptor))
                ) && 
                (
                    this.ElectronicMailAddress == input.ElectronicMailAddress ||
                    (this.ElectronicMailAddress != null &&
                    this.ElectronicMailAddress.Equals(input.ElectronicMailAddress))
                ) && 
                (
                    this.DoNotPublishIndicator == input.DoNotPublishIndicator ||
                    (this.DoNotPublishIndicator != null &&
                    this.DoNotPublishIndicator.Equals(input.DoNotPublishIndicator))
                ) && 
                (
                    this.PrimaryEmailAddressIndicator == input.PrimaryEmailAddressIndicator ||
                    (this.PrimaryEmailAddressIndicator != null &&
                    this.PrimaryEmailAddressIndicator.Equals(input.PrimaryEmailAddressIndicator))
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
                if (this.ElectronicMailTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.ElectronicMailTypeDescriptor.GetHashCode();
                if (this.ElectronicMailAddress != null)
                    hashCode = hashCode * 59 + this.ElectronicMailAddress.GetHashCode();
                if (this.DoNotPublishIndicator != null)
                    hashCode = hashCode * 59 + this.DoNotPublishIndicator.GetHashCode();
                if (this.PrimaryEmailAddressIndicator != null)
                    hashCode = hashCode * 59 + this.PrimaryEmailAddressIndicator.GetHashCode();
                return hashCode;
            }
        }
    }

}
