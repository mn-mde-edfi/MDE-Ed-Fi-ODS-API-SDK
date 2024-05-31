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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Four_Twenty_Five_SISVendor_Profile
{
    /// <summary>
    /// EdFiEducationOrganizationAddressSchoolReadable
    /// </summary>
    [DataContract(Name = "edFi_educationOrganizationAddress_school_readable")]
    public partial class EdFiEducationOrganizationAddressSchoolReadable : IEquatable<EdFiEducationOrganizationAddressSchoolReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationOrganizationAddressSchoolReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiEducationOrganizationAddressSchoolReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationOrganizationAddressSchoolReadable" /> class.
        /// </summary>
        /// <param name="addressTypeDescriptor">The type of address listed for an individual or organization.    For example:  Physical Address, Mailing Address, Home Address, etc.) (required).</param>
        /// <param name="stateAbbreviationDescriptor">The abbreviation for the state (within the United States) or outlying area in which an address is located. (required).</param>
        /// <param name="city">The name of the city in which an address is located. (required).</param>
        /// <param name="postalCode">The five or nine digit zip code or overseas postal code portion of an address. (required).</param>
        /// <param name="streetNumberName">The street number and street name or post office box number of an address. (required).</param>
        /// <param name="apartmentRoomSuiteNumber">The apartment, room, or suite number of an address..</param>
        /// <param name="buildingSiteNumber">The number of the building on the site, if more than one building shares the same address..</param>
        public EdFiEducationOrganizationAddressSchoolReadable(string addressTypeDescriptor = default(string), string stateAbbreviationDescriptor = default(string), string city = default(string), string postalCode = default(string), string streetNumberName = default(string), string apartmentRoomSuiteNumber = default(string), string buildingSiteNumber = default(string))
        {
            // to ensure "addressTypeDescriptor" is required (not null)
            if (addressTypeDescriptor == null)
            {
                throw new ArgumentNullException("addressTypeDescriptor is a required property for EdFiEducationOrganizationAddressSchoolReadable and cannot be null");
            }
            this.AddressTypeDescriptor = addressTypeDescriptor;
            // to ensure "stateAbbreviationDescriptor" is required (not null)
            if (stateAbbreviationDescriptor == null)
            {
                throw new ArgumentNullException("stateAbbreviationDescriptor is a required property for EdFiEducationOrganizationAddressSchoolReadable and cannot be null");
            }
            this.StateAbbreviationDescriptor = stateAbbreviationDescriptor;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for EdFiEducationOrganizationAddressSchoolReadable and cannot be null");
            }
            this.City = city;
            // to ensure "postalCode" is required (not null)
            if (postalCode == null)
            {
                throw new ArgumentNullException("postalCode is a required property for EdFiEducationOrganizationAddressSchoolReadable and cannot be null");
            }
            this.PostalCode = postalCode;
            // to ensure "streetNumberName" is required (not null)
            if (streetNumberName == null)
            {
                throw new ArgumentNullException("streetNumberName is a required property for EdFiEducationOrganizationAddressSchoolReadable and cannot be null");
            }
            this.StreetNumberName = streetNumberName;
            this.ApartmentRoomSuiteNumber = apartmentRoomSuiteNumber;
            this.BuildingSiteNumber = buildingSiteNumber;
        }

        /// <summary>
        /// The type of address listed for an individual or organization.    For example:  Physical Address, Mailing Address, Home Address, etc.)
        /// </summary>
        /// <value>The type of address listed for an individual or organization.    For example:  Physical Address, Mailing Address, Home Address, etc.)</value>
        [DataMember(Name = "addressTypeDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string AddressTypeDescriptor { get; set; }

        /// <summary>
        /// The abbreviation for the state (within the United States) or outlying area in which an address is located.
        /// </summary>
        /// <value>The abbreviation for the state (within the United States) or outlying area in which an address is located.</value>
        [DataMember(Name = "stateAbbreviationDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string StateAbbreviationDescriptor { get; set; }

        /// <summary>
        /// The name of the city in which an address is located.
        /// </summary>
        /// <value>The name of the city in which an address is located.</value>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The five or nine digit zip code or overseas postal code portion of an address.
        /// </summary>
        /// <value>The five or nine digit zip code or overseas postal code portion of an address.</value>
        [DataMember(Name = "postalCode", IsRequired = true, EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The street number and street name or post office box number of an address.
        /// </summary>
        /// <value>The street number and street name or post office box number of an address.</value>
        [DataMember(Name = "streetNumberName", IsRequired = true, EmitDefaultValue = false)]
        public string StreetNumberName { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        /// <value>The apartment, room, or suite number of an address.</value>
        [DataMember(Name = "apartmentRoomSuiteNumber", EmitDefaultValue = false)]
        public string ApartmentRoomSuiteNumber { get; set; }

        /// <summary>
        /// The number of the building on the site, if more than one building shares the same address.
        /// </summary>
        /// <value>The number of the building on the site, if more than one building shares the same address.</value>
        [DataMember(Name = "buildingSiteNumber", EmitDefaultValue = false)]
        public string BuildingSiteNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiEducationOrganizationAddressSchoolReadable {\n");
            sb.Append("  AddressTypeDescriptor: ").Append(AddressTypeDescriptor).Append("\n");
            sb.Append("  StateAbbreviationDescriptor: ").Append(StateAbbreviationDescriptor).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StreetNumberName: ").Append(StreetNumberName).Append("\n");
            sb.Append("  ApartmentRoomSuiteNumber: ").Append(ApartmentRoomSuiteNumber).Append("\n");
            sb.Append("  BuildingSiteNumber: ").Append(BuildingSiteNumber).Append("\n");
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
            return this.Equals(input as EdFiEducationOrganizationAddressSchoolReadable);
        }

        /// <summary>
        /// Returns true if EdFiEducationOrganizationAddressSchoolReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiEducationOrganizationAddressSchoolReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiEducationOrganizationAddressSchoolReadable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AddressTypeDescriptor == input.AddressTypeDescriptor ||
                    (this.AddressTypeDescriptor != null &&
                    this.AddressTypeDescriptor.Equals(input.AddressTypeDescriptor))
                ) && 
                (
                    this.StateAbbreviationDescriptor == input.StateAbbreviationDescriptor ||
                    (this.StateAbbreviationDescriptor != null &&
                    this.StateAbbreviationDescriptor.Equals(input.StateAbbreviationDescriptor))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.StreetNumberName == input.StreetNumberName ||
                    (this.StreetNumberName != null &&
                    this.StreetNumberName.Equals(input.StreetNumberName))
                ) && 
                (
                    this.ApartmentRoomSuiteNumber == input.ApartmentRoomSuiteNumber ||
                    (this.ApartmentRoomSuiteNumber != null &&
                    this.ApartmentRoomSuiteNumber.Equals(input.ApartmentRoomSuiteNumber))
                ) && 
                (
                    this.BuildingSiteNumber == input.BuildingSiteNumber ||
                    (this.BuildingSiteNumber != null &&
                    this.BuildingSiteNumber.Equals(input.BuildingSiteNumber))
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
                {
                    hashCode = (hashCode * 59) + this.AddressTypeDescriptor.GetHashCode();
                }
                if (this.StateAbbreviationDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.StateAbbreviationDescriptor.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }
                if (this.StreetNumberName != null)
                {
                    hashCode = (hashCode * 59) + this.StreetNumberName.GetHashCode();
                }
                if (this.ApartmentRoomSuiteNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ApartmentRoomSuiteNumber.GetHashCode();
                }
                if (this.BuildingSiteNumber != null)
                {
                    hashCode = (hashCode * 59) + this.BuildingSiteNumber.GetHashCode();
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
            // AddressTypeDescriptor (string) maxLength
            if (this.AddressTypeDescriptor != null && this.AddressTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressTypeDescriptor, length must be less than 306.", new [] { "AddressTypeDescriptor" });
            }

            // StateAbbreviationDescriptor (string) maxLength
            if (this.StateAbbreviationDescriptor != null && this.StateAbbreviationDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StateAbbreviationDescriptor, length must be less than 306.", new [] { "StateAbbreviationDescriptor" });
            }

            // City (string) maxLength
            if (this.City != null && this.City.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 30.", new [] { "City" });
            }

            // PostalCode (string) maxLength
            if (this.PostalCode != null && this.PostalCode.Length > 17)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 17.", new [] { "PostalCode" });
            }

            // StreetNumberName (string) maxLength
            if (this.StreetNumberName != null && this.StreetNumberName.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StreetNumberName, length must be less than 150.", new [] { "StreetNumberName" });
            }

            // ApartmentRoomSuiteNumber (string) maxLength
            if (this.ApartmentRoomSuiteNumber != null && this.ApartmentRoomSuiteNumber.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApartmentRoomSuiteNumber, length must be less than 50.", new [] { "ApartmentRoomSuiteNumber" });
            }

            // BuildingSiteNumber (string) maxLength
            if (this.BuildingSiteNumber != null && this.BuildingSiteNumber.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BuildingSiteNumber, length must be less than 20.", new [] { "BuildingSiteNumber" });
            }

            yield break;
        }
    }

}
