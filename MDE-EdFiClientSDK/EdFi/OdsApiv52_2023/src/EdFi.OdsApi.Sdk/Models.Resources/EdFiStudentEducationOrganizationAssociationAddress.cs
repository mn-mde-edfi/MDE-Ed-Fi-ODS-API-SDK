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
    /// EdFiStudentEducationOrganizationAssociationAddress
    /// </summary>
    [DataContract]
    public partial class EdFiStudentEducationOrganizationAssociationAddress :  IEquatable<EdFiStudentEducationOrganizationAssociationAddress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentEducationOrganizationAssociationAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationAddress" /> class.
        /// </summary>
        /// <param name="addressTypeDescriptor">The type of address listed for an individual or organization.    For example:  Physical Address, Mailing Address, Home Address, etc.) (required).</param>
        /// <param name="stateAbbreviationDescriptor">The abbreviation for the state (within the United States) or outlying area in which an address is located. (required).</param>
        /// <param name="city">The name of the city in which an address is located. (required).</param>
        /// <param name="postalCode">The five or nine digit zip code or overseas postal code portion of an address. (required).</param>
        /// <param name="streetNumberName">The street number and street name or post office box number of an address. (required).</param>
        /// <param name="localeDescriptor">A general geographic indicator that categorizes U.S. territory (e.g., City, Suburban)..</param>
        /// <param name="apartmentRoomSuiteNumber">The apartment, room, or suite number of an address..</param>
        /// <param name="buildingSiteNumber">The number of the building on the site, if more than one building shares the same address..</param>
        /// <param name="congressionalDistrict">The congressional district in which an address is located..</param>
        /// <param name="countyFIPSCode">The Federal Information Processing Standards (FIPS) numeric code for the county issued by the National Institute of Standards and Technology (NIST). Counties are considered to be the \&quot;first-order subdivisions\&quot; of each State and statistically equivalent entity, regardless of their local designations (county, parish, borough, etc.) Counties in different States will have the same code. A unique county number is created when combined with the 2-digit FIPS State Code..</param>
        /// <param name="doNotPublishIndicator">An indication that the address should not be published..</param>
        /// <param name="latitude">The geographic latitude of the physical address..</param>
        /// <param name="longitude">The geographic longitude of the physical address..</param>
        /// <param name="nameOfCounty">The name of the county, parish, borough, or comparable unit (within a state) in                       &#39;which an address is located..</param>
        /// <param name="periods">An unordered collection of studentEducationOrganizationAssociationAddressPeriods. The time periods for which the address is valid. For physical addresses, the periods in which the person lived at that address..</param>
        public EdFiStudentEducationOrganizationAssociationAddress(string addressTypeDescriptor = default(string), string stateAbbreviationDescriptor = default(string), string city = default(string), string postalCode = default(string), string streetNumberName = default(string), string localeDescriptor = default(string), string apartmentRoomSuiteNumber = default(string), string buildingSiteNumber = default(string), string congressionalDistrict = default(string), string countyFIPSCode = default(string), bool? doNotPublishIndicator = default(bool?), string latitude = default(string), string longitude = default(string), string nameOfCounty = default(string), List<EdFiStudentEducationOrganizationAssociationAddressPeriod> periods = default(List<EdFiStudentEducationOrganizationAssociationAddressPeriod>))
        {
            // to ensure "addressTypeDescriptor" is required (not null)
            if (addressTypeDescriptor == null)
            {
                throw new InvalidDataException("addressTypeDescriptor is a required property for EdFiStudentEducationOrganizationAssociationAddress and cannot be null");
            }
            else
            {
                this.AddressTypeDescriptor = addressTypeDescriptor;
            }
            // to ensure "stateAbbreviationDescriptor" is required (not null)
            if (stateAbbreviationDescriptor == null)
            {
                throw new InvalidDataException("stateAbbreviationDescriptor is a required property for EdFiStudentEducationOrganizationAssociationAddress and cannot be null");
            }
            else
            {
                this.StateAbbreviationDescriptor = stateAbbreviationDescriptor;
            }
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new InvalidDataException("city is a required property for EdFiStudentEducationOrganizationAssociationAddress and cannot be null");
            }
            else
            {
                this.City = city;
            }
            // to ensure "postalCode" is required (not null)
            if (postalCode == null)
            {
                throw new InvalidDataException("postalCode is a required property for EdFiStudentEducationOrganizationAssociationAddress and cannot be null");
            }
            else
            {
                this.PostalCode = postalCode;
            }
            // to ensure "streetNumberName" is required (not null)
            if (streetNumberName == null)
            {
                throw new InvalidDataException("streetNumberName is a required property for EdFiStudentEducationOrganizationAssociationAddress and cannot be null");
            }
            else
            {
                this.StreetNumberName = streetNumberName;
            }
            this.LocaleDescriptor = localeDescriptor;
            this.ApartmentRoomSuiteNumber = apartmentRoomSuiteNumber;
            this.BuildingSiteNumber = buildingSiteNumber;
            this.CongressionalDistrict = congressionalDistrict;
            this.CountyFIPSCode = countyFIPSCode;
            this.DoNotPublishIndicator = doNotPublishIndicator;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.NameOfCounty = nameOfCounty;
            this.Periods = periods;
        }
        
        /// <summary>
        /// The type of address listed for an individual or organization.    For example:  Physical Address, Mailing Address, Home Address, etc.)
        /// </summary>
        /// <value>The type of address listed for an individual or organization.    For example:  Physical Address, Mailing Address, Home Address, etc.)</value>
        [DataMember(Name="addressTypeDescriptor", EmitDefaultValue=false)]
        public string AddressTypeDescriptor { get; set; }

        /// <summary>
        /// The abbreviation for the state (within the United States) or outlying area in which an address is located.
        /// </summary>
        /// <value>The abbreviation for the state (within the United States) or outlying area in which an address is located.</value>
        [DataMember(Name="stateAbbreviationDescriptor", EmitDefaultValue=false)]
        public string StateAbbreviationDescriptor { get; set; }

        /// <summary>
        /// The name of the city in which an address is located.
        /// </summary>
        /// <value>The name of the city in which an address is located.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The five or nine digit zip code or overseas postal code portion of an address.
        /// </summary>
        /// <value>The five or nine digit zip code or overseas postal code portion of an address.</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The street number and street name or post office box number of an address.
        /// </summary>
        /// <value>The street number and street name or post office box number of an address.</value>
        [DataMember(Name="streetNumberName", EmitDefaultValue=false)]
        public string StreetNumberName { get; set; }

        /// <summary>
        /// A general geographic indicator that categorizes U.S. territory (e.g., City, Suburban).
        /// </summary>
        /// <value>A general geographic indicator that categorizes U.S. territory (e.g., City, Suburban).</value>
        [DataMember(Name="localeDescriptor", EmitDefaultValue=false)]
        public string LocaleDescriptor { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        /// <value>The apartment, room, or suite number of an address.</value>
        [DataMember(Name="apartmentRoomSuiteNumber", EmitDefaultValue=false)]
        public string ApartmentRoomSuiteNumber { get; set; }

        /// <summary>
        /// The number of the building on the site, if more than one building shares the same address.
        /// </summary>
        /// <value>The number of the building on the site, if more than one building shares the same address.</value>
        [DataMember(Name="buildingSiteNumber", EmitDefaultValue=false)]
        public string BuildingSiteNumber { get; set; }

        /// <summary>
        /// The congressional district in which an address is located.
        /// </summary>
        /// <value>The congressional district in which an address is located.</value>
        [DataMember(Name="congressionalDistrict", EmitDefaultValue=false)]
        public string CongressionalDistrict { get; set; }

        /// <summary>
        /// The Federal Information Processing Standards (FIPS) numeric code for the county issued by the National Institute of Standards and Technology (NIST). Counties are considered to be the \&quot;first-order subdivisions\&quot; of each State and statistically equivalent entity, regardless of their local designations (county, parish, borough, etc.) Counties in different States will have the same code. A unique county number is created when combined with the 2-digit FIPS State Code.
        /// </summary>
        /// <value>The Federal Information Processing Standards (FIPS) numeric code for the county issued by the National Institute of Standards and Technology (NIST). Counties are considered to be the \&quot;first-order subdivisions\&quot; of each State and statistically equivalent entity, regardless of their local designations (county, parish, borough, etc.) Counties in different States will have the same code. A unique county number is created when combined with the 2-digit FIPS State Code.</value>
        [DataMember(Name="countyFIPSCode", EmitDefaultValue=false)]
        public string CountyFIPSCode { get; set; }

        /// <summary>
        /// An indication that the address should not be published.
        /// </summary>
        /// <value>An indication that the address should not be published.</value>
        [DataMember(Name="doNotPublishIndicator", EmitDefaultValue=false)]
        public bool? DoNotPublishIndicator { get; set; }

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
        /// The name of the county, parish, borough, or comparable unit (within a state) in                       &#39;which an address is located.
        /// </summary>
        /// <value>The name of the county, parish, borough, or comparable unit (within a state) in                       &#39;which an address is located.</value>
        [DataMember(Name="nameOfCounty", EmitDefaultValue=false)]
        public string NameOfCounty { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationAddressPeriods. The time periods for which the address is valid. For physical addresses, the periods in which the person lived at that address.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationAddressPeriods. The time periods for which the address is valid. For physical addresses, the periods in which the person lived at that address.</value>
        [DataMember(Name="periods", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationAddressPeriod> Periods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentEducationOrganizationAssociationAddress {\n");
            sb.Append("  AddressTypeDescriptor: ").Append(AddressTypeDescriptor).Append("\n");
            sb.Append("  StateAbbreviationDescriptor: ").Append(StateAbbreviationDescriptor).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StreetNumberName: ").Append(StreetNumberName).Append("\n");
            sb.Append("  LocaleDescriptor: ").Append(LocaleDescriptor).Append("\n");
            sb.Append("  ApartmentRoomSuiteNumber: ").Append(ApartmentRoomSuiteNumber).Append("\n");
            sb.Append("  BuildingSiteNumber: ").Append(BuildingSiteNumber).Append("\n");
            sb.Append("  CongressionalDistrict: ").Append(CongressionalDistrict).Append("\n");
            sb.Append("  CountyFIPSCode: ").Append(CountyFIPSCode).Append("\n");
            sb.Append("  DoNotPublishIndicator: ").Append(DoNotPublishIndicator).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  NameOfCounty: ").Append(NameOfCounty).Append("\n");
            sb.Append("  Periods: ").Append(Periods).Append("\n");
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
            return this.Equals(input as EdFiStudentEducationOrganizationAssociationAddress);
        }

        /// <summary>
        /// Returns true if EdFiStudentEducationOrganizationAssociationAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentEducationOrganizationAssociationAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentEducationOrganizationAssociationAddress input)
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
                    this.LocaleDescriptor == input.LocaleDescriptor ||
                    (this.LocaleDescriptor != null &&
                    this.LocaleDescriptor.Equals(input.LocaleDescriptor))
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
                ) && 
                (
                    this.CongressionalDistrict == input.CongressionalDistrict ||
                    (this.CongressionalDistrict != null &&
                    this.CongressionalDistrict.Equals(input.CongressionalDistrict))
                ) && 
                (
                    this.CountyFIPSCode == input.CountyFIPSCode ||
                    (this.CountyFIPSCode != null &&
                    this.CountyFIPSCode.Equals(input.CountyFIPSCode))
                ) && 
                (
                    this.DoNotPublishIndicator == input.DoNotPublishIndicator ||
                    (this.DoNotPublishIndicator != null &&
                    this.DoNotPublishIndicator.Equals(input.DoNotPublishIndicator))
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
                ) && 
                (
                    this.NameOfCounty == input.NameOfCounty ||
                    (this.NameOfCounty != null &&
                    this.NameOfCounty.Equals(input.NameOfCounty))
                ) && 
                (
                    this.Periods == input.Periods ||
                    this.Periods != null &&
                    this.Periods.SequenceEqual(input.Periods)
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
                if (this.StateAbbreviationDescriptor != null)
                    hashCode = hashCode * 59 + this.StateAbbreviationDescriptor.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.StreetNumberName != null)
                    hashCode = hashCode * 59 + this.StreetNumberName.GetHashCode();
                if (this.LocaleDescriptor != null)
                    hashCode = hashCode * 59 + this.LocaleDescriptor.GetHashCode();
                if (this.ApartmentRoomSuiteNumber != null)
                    hashCode = hashCode * 59 + this.ApartmentRoomSuiteNumber.GetHashCode();
                if (this.BuildingSiteNumber != null)
                    hashCode = hashCode * 59 + this.BuildingSiteNumber.GetHashCode();
                if (this.CongressionalDistrict != null)
                    hashCode = hashCode * 59 + this.CongressionalDistrict.GetHashCode();
                if (this.CountyFIPSCode != null)
                    hashCode = hashCode * 59 + this.CountyFIPSCode.GetHashCode();
                if (this.DoNotPublishIndicator != null)
                    hashCode = hashCode * 59 + this.DoNotPublishIndicator.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.NameOfCounty != null)
                    hashCode = hashCode * 59 + this.NameOfCounty.GetHashCode();
                if (this.Periods != null)
                    hashCode = hashCode * 59 + this.Periods.GetHashCode();
                return hashCode;
            }
        }
    }

}
