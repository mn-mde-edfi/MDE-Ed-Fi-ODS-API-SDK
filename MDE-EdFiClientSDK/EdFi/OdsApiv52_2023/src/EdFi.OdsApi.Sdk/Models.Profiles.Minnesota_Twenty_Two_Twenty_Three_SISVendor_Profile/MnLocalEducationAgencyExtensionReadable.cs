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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Two_Twenty_Three_SISVendor_Profile
{
    /// <summary>
    /// MnLocalEducationAgencyExtensionReadable
    /// </summary>
    [DataContract]
    public partial class MnLocalEducationAgencyExtensionReadable :  IEquatable<MnLocalEducationAgencyExtensionReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnLocalEducationAgencyExtensionReadable" /> class.
        /// </summary>
        /// <param name="districtTypeDescriptor">The two digit numeric code representing the MARSS district type..</param>
        public MnLocalEducationAgencyExtensionReadable(string districtTypeDescriptor = default(string))
        {
            this.DistrictTypeDescriptor = districtTypeDescriptor;
        }
        
        /// <summary>
        /// The two digit numeric code representing the MARSS district type.
        /// </summary>
        /// <value>The two digit numeric code representing the MARSS district type.</value>
        [DataMember(Name="districtTypeDescriptor", EmitDefaultValue=false)]
        public string DistrictTypeDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnLocalEducationAgencyExtensionReadable {\n");
            sb.Append("  DistrictTypeDescriptor: ").Append(DistrictTypeDescriptor).Append("\n");
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
            return this.Equals(input as MnLocalEducationAgencyExtensionReadable);
        }

        /// <summary>
        /// Returns true if MnLocalEducationAgencyExtensionReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnLocalEducationAgencyExtensionReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnLocalEducationAgencyExtensionReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DistrictTypeDescriptor == input.DistrictTypeDescriptor ||
                    (this.DistrictTypeDescriptor != null &&
                    this.DistrictTypeDescriptor.Equals(input.DistrictTypeDescriptor))
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
                if (this.DistrictTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.DistrictTypeDescriptor.GetHashCode();
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
            // DistrictTypeDescriptor (string) maxLength
            if(this.DistrictTypeDescriptor != null && this.DistrictTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DistrictTypeDescriptor, length must be less than 306.", new [] { "DistrictTypeDescriptor" });
            }

            yield break;
        }
    }

}
