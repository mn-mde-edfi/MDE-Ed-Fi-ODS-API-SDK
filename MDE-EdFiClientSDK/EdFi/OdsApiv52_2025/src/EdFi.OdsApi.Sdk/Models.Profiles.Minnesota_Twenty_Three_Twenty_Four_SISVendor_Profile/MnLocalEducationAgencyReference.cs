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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Three_Twenty_Four_SISVendor_Profile
{
    /// <summary>
    /// MnLocalEducationAgencyReference
    /// </summary>
    [DataContract(Name = "mn_localEducationAgencyReference")]
    public partial class MnLocalEducationAgencyReference : IEquatable<MnLocalEducationAgencyReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnLocalEducationAgencyReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnLocalEducationAgencyReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnLocalEducationAgencyReference" /> class.
        /// </summary>
        /// <param name="localEducationAgencyId">The identifier assigned to a local education agency. (required).</param>
        /// <param name="link">link.</param>
        public MnLocalEducationAgencyReference(int localEducationAgencyId = default(int), Link link = default(Link))
        {
            this.LocalEducationAgencyId = localEducationAgencyId;
            this.Link = link;
        }

        /// <summary>
        /// The identifier assigned to a local education agency.
        /// </summary>
        /// <value>The identifier assigned to a local education agency.</value>
        [DataMember(Name = "localEducationAgencyId", IsRequired = true, EmitDefaultValue = false)]
        public int LocalEducationAgencyId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MnLocalEducationAgencyReference {\n");
            sb.Append("  LocalEducationAgencyId: ").Append(LocalEducationAgencyId).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as MnLocalEducationAgencyReference);
        }

        /// <summary>
        /// Returns true if MnLocalEducationAgencyReference instances are equal
        /// </summary>
        /// <param name="input">Instance of MnLocalEducationAgencyReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnLocalEducationAgencyReference input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LocalEducationAgencyId == input.LocalEducationAgencyId ||
                    this.LocalEducationAgencyId.Equals(input.LocalEducationAgencyId)
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                hashCode = (hashCode * 59) + this.LocalEducationAgencyId.GetHashCode();
                if (this.Link != null)
                {
                    hashCode = (hashCode * 59) + this.Link.GetHashCode();
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
            yield break;
        }
    }

}
