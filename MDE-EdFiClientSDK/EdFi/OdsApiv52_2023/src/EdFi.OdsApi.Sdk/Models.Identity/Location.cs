/* 
 * Identity API Endpoints
 *
 * The identity management API is used to access a native identity system if one exists in the enterprise. The endpoints provide client applications with the ability to find and (optionally) create unique person identifiers that can be used with Student, Staff, and Parent resources. The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * OpenAPI spec version: 2
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
    /// Location
    /// </summary>
    [DataContract]
    public partial class Location :  IEquatable<Location>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location" /> class.
        /// </summary>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="internationalProvince">internationalProvince.</param>
        /// <param name="stateAbbreviation">stateAbbreviation.</param>
        public Location(string city = default(string), string country = default(string), string internationalProvince = default(string), string stateAbbreviation = default(string))
        {
            this.City = city;
            this.Country = country;
            this.InternationalProvince = internationalProvince;
            this.StateAbbreviation = stateAbbreviation;
        }
        
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="Country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets InternationalProvince
        /// </summary>
        [DataMember(Name="InternationalProvince", EmitDefaultValue=false)]
        public string InternationalProvince { get; set; }

        /// <summary>
        /// Gets or Sets StateAbbreviation
        /// </summary>
        [DataMember(Name="StateAbbreviation", EmitDefaultValue=false)]
        public string StateAbbreviation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Location {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  InternationalProvince: ").Append(InternationalProvince).Append("\n");
            sb.Append("  StateAbbreviation: ").Append(StateAbbreviation).Append("\n");
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
            return this.Equals(input as Location);
        }

        /// <summary>
        /// Returns true if Location instances are equal
        /// </summary>
        /// <param name="input">Instance of Location to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Location input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.InternationalProvince == input.InternationalProvince ||
                    (this.InternationalProvince != null &&
                    this.InternationalProvince.Equals(input.InternationalProvince))
                ) && 
                (
                    this.StateAbbreviation == input.StateAbbreviation ||
                    (this.StateAbbreviation != null &&
                    this.StateAbbreviation.Equals(input.StateAbbreviation))
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
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.InternationalProvince != null)
                    hashCode = hashCode * 59 + this.InternationalProvince.GetHashCode();
                if (this.StateAbbreviation != null)
                    hashCode = hashCode * 59 + this.StateAbbreviation.GetHashCode();
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
            yield break;
        }
    }

}
