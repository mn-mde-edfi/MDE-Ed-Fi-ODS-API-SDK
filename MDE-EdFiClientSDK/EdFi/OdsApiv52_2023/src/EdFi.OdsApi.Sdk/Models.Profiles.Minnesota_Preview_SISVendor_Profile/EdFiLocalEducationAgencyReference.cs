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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile
{
    /// <summary>
    /// EdFiLocalEducationAgencyReference
    /// </summary>
    [DataContract]
    public partial class EdFiLocalEducationAgencyReference :  IEquatable<EdFiLocalEducationAgencyReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLocalEducationAgencyReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiLocalEducationAgencyReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLocalEducationAgencyReference" /> class.
        /// </summary>
        /// <param name="localEducationAgencyId">The identifier assigned to a local education agency. (required).</param>
        /// <param name="link">link.</param>
        public EdFiLocalEducationAgencyReference(int? localEducationAgencyId = default(int?), Link link = default(Link))
        {
            // to ensure "localEducationAgencyId" is required (not null)
            if (localEducationAgencyId == null)
            {
                throw new InvalidDataException("localEducationAgencyId is a required property for EdFiLocalEducationAgencyReference and cannot be null");
            }
            else
            {
                this.LocalEducationAgencyId = localEducationAgencyId;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// The identifier assigned to a local education agency.
        /// </summary>
        /// <value>The identifier assigned to a local education agency.</value>
        [DataMember(Name="localEducationAgencyId", EmitDefaultValue=false)]
        public int? LocalEducationAgencyId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiLocalEducationAgencyReference {\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiLocalEducationAgencyReference);
        }

        /// <summary>
        /// Returns true if EdFiLocalEducationAgencyReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiLocalEducationAgencyReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiLocalEducationAgencyReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LocalEducationAgencyId == input.LocalEducationAgencyId ||
                    (this.LocalEducationAgencyId != null &&
                    this.LocalEducationAgencyId.Equals(input.LocalEducationAgencyId))
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
                if (this.LocalEducationAgencyId != null)
                    hashCode = hashCode * 59 + this.LocalEducationAgencyId.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}
