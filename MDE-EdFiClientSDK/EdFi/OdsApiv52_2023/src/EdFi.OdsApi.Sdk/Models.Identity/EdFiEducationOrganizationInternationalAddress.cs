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
    /// EdFiEducationOrganizationInternationalAddress
    /// </summary>
    [DataContract]
    public partial class EdFiEducationOrganizationInternationalAddress :  IEquatable<EdFiEducationOrganizationInternationalAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationOrganizationInternationalAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiEducationOrganizationInternationalAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationOrganizationInternationalAddress" /> class.
        /// </summary>
        /// <param name="addressTypeDescriptor">The type of address listed for an individual or organization. For example:  Physical Address, Mailing Address, Home Address, etc.) (required).</param>
        /// <param name="countryDescriptor">The name of the country. It is strongly recommended that entries use only ISO 3166 2-letter country codes. (required).</param>
        /// <param name="addressLine1">The first line of the address. (required).</param>
        /// <param name="addressLine2">The second line of the address..</param>
        /// <param name="addressLine3">The third line of the address..</param>
        /// <param name="addressLine4">The fourth line of the address..</param>
        /// <param name="beginDate">The first date the address is valid. For physical addresses, the date the person moved to that address..</param>
        /// <param name="endDate">The last date the address is valid. For physical addresses, this would be the date the person moved from that address..</param>
        /// <param name="latitude">The geographic latitude of the physical address..</param>
        /// <param name="longitude">The geographic longitude of the physical address..</param>
        public EdFiEducationOrganizationInternationalAddress(string addressTypeDescriptor = default(string), string countryDescriptor = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string addressLine4 = default(string), DateTime? beginDate = default(DateTime?), DateTime? endDate = default(DateTime?), string latitude = default(string), string longitude = default(string))
        {
            // to ensure "addressTypeDescriptor" is required (not null)
            if (addressTypeDescriptor == null)
            {
                throw new InvalidDataException("addressTypeDescriptor is a required property for EdFiEducationOrganizationInternationalAddress and cannot be null");
            }
            else
            {
                this.AddressTypeDescriptor = addressTypeDescriptor;
            }
            // to ensure "countryDescriptor" is required (not null)
            if (countryDescriptor == null)
            {
                throw new InvalidDataException("countryDescriptor is a required property for EdFiEducationOrganizationInternationalAddress and cannot be null");
            }
            else
            {
                this.CountryDescriptor = countryDescriptor;
            }
            // to ensure "addressLine1" is required (not null)
            if (addressLine1 == null)
            {
                throw new InvalidDataException("addressLine1 is a required property for EdFiEducationOrganizationInternationalAddress and cannot be null");
            }
            else
            {
                this.AddressLine1 = addressLine1;
            }
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.AddressLine4 = addressLine4;
            this.BeginDate = beginDate;
            this.EndDate = endDate;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
        
        /// <summary>
        /// The type of address listed for an individual or organization. For example:  Physical Address, Mailing Address, Home Address, etc.)
        /// </summary>
        /// <value>The type of address listed for an individual or organization. For example:  Physical Address, Mailing Address, Home Address, etc.)</value>
        [DataMember(Name="addressTypeDescriptor", EmitDefaultValue=false)]
        public string AddressTypeDescriptor { get; set; }

        /// <summary>
        /// The name of the country. It is strongly recommended that entries use only ISO 3166 2-letter country codes.
        /// </summary>
        /// <value>The name of the country. It is strongly recommended that entries use only ISO 3166 2-letter country codes.</value>
        [DataMember(Name="countryDescriptor", EmitDefaultValue=false)]
        public string CountryDescriptor { get; set; }

        /// <summary>
        /// The first line of the address.
        /// </summary>
        /// <value>The first line of the address.</value>
        [DataMember(Name="addressLine1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// The second line of the address.
        /// </summary>
        /// <value>The second line of the address.</value>
        [DataMember(Name="addressLine2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// The third line of the address.
        /// </summary>
        /// <value>The third line of the address.</value>
        [DataMember(Name="addressLine3", EmitDefaultValue=false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// The fourth line of the address.
        /// </summary>
        /// <value>The fourth line of the address.</value>
        [DataMember(Name="addressLine4", EmitDefaultValue=false)]
        public string AddressLine4 { get; set; }

        /// <summary>
        /// The first date the address is valid. For physical addresses, the date the person moved to that address.
        /// </summary>
        /// <value>The first date the address is valid. For physical addresses, the date the person moved to that address.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// The last date the address is valid. For physical addresses, this would be the date the person moved from that address.
        /// </summary>
        /// <value>The last date the address is valid. For physical addresses, this would be the date the person moved from that address.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The geographic latitude of the physical address.
        /// </summary>
        /// <value>The geographic latitude of the physical address.</value>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public string Latitude { get; set; }

        /// <summary>
        /// The geographic longitude of the physical address.
        /// </summary>
        /// <value>The geographic longitude of the physical address.</value>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public string Longitude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiEducationOrganizationInternationalAddress {\n");
            sb.Append("  AddressTypeDescriptor: ").Append(AddressTypeDescriptor).Append("\n");
            sb.Append("  CountryDescriptor: ").Append(CountryDescriptor).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  AddressLine4: ").Append(AddressLine4).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
            return this.Equals(input as EdFiEducationOrganizationInternationalAddress);
        }

        /// <summary>
        /// Returns true if EdFiEducationOrganizationInternationalAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiEducationOrganizationInternationalAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiEducationOrganizationInternationalAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressTypeDescriptor == input.AddressTypeDescriptor ||
                    (this.AddressTypeDescriptor != null &&
                    this.AddressTypeDescriptor.Equals(input.AddressTypeDescriptor))
                ) && 
                (
                    this.CountryDescriptor == input.CountryDescriptor ||
                    (this.CountryDescriptor != null &&
                    this.CountryDescriptor.Equals(input.CountryDescriptor))
                ) && 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.AddressLine3 == input.AddressLine3 ||
                    (this.AddressLine3 != null &&
                    this.AddressLine3.Equals(input.AddressLine3))
                ) && 
                (
                    this.AddressLine4 == input.AddressLine4 ||
                    (this.AddressLine4 != null &&
                    this.AddressLine4.Equals(input.AddressLine4))
                ) && 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
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
                if (this.AddressTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.AddressTypeDescriptor.GetHashCode();
                if (this.CountryDescriptor != null)
                    hashCode = hashCode * 59 + this.CountryDescriptor.GetHashCode();
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.AddressLine3 != null)
                    hashCode = hashCode * 59 + this.AddressLine3.GetHashCode();
                if (this.AddressLine4 != null)
                    hashCode = hashCode * 59 + this.AddressLine4.GetHashCode();
                if (this.BeginDate != null)
                    hashCode = hashCode * 59 + this.BeginDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
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
            // AddressTypeDescriptor (string) maxLength
            if(this.AddressTypeDescriptor != null && this.AddressTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressTypeDescriptor, length must be less than 306.", new [] { "AddressTypeDescriptor" });
            }

            // CountryDescriptor (string) maxLength
            if(this.CountryDescriptor != null && this.CountryDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryDescriptor, length must be less than 306.", new [] { "CountryDescriptor" });
            }

            // AddressLine1 (string) maxLength
            if(this.AddressLine1 != null && this.AddressLine1.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine1, length must be less than 150.", new [] { "AddressLine1" });
            }

            // AddressLine2 (string) maxLength
            if(this.AddressLine2 != null && this.AddressLine2.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine2, length must be less than 150.", new [] { "AddressLine2" });
            }

            // AddressLine3 (string) maxLength
            if(this.AddressLine3 != null && this.AddressLine3.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine3, length must be less than 150.", new [] { "AddressLine3" });
            }

            // AddressLine4 (string) maxLength
            if(this.AddressLine4 != null && this.AddressLine4.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine4, length must be less than 150.", new [] { "AddressLine4" });
            }

            // Latitude (string) maxLength
            if(this.Latitude != null && this.Latitude.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Latitude, length must be less than 20.", new [] { "Latitude" });
            }

            // Longitude (string) maxLength
            if(this.Longitude != null && this.Longitude.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Longitude, length must be less than 20.", new [] { "Longitude" });
            }

            yield break;
        }
    }

}
