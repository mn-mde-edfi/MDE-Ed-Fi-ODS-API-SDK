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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_TwentyOne_TwentyTwo_SISVendor_Profile
{
    /// <summary>
    /// MnStaffReference
    /// </summary>
    [DataContract]
    public partial class MnStaffReference :  IEquatable<MnStaffReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStaffReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStaffReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStaffReference" /> class.
        /// </summary>
        /// <param name="staffUniqueId">A unique alphanumeric code assigned to a staff. (required).</param>
        /// <param name="link">link.</param>
        public MnStaffReference(string staffUniqueId = default(string), Link link = default(Link))
        {
            // to ensure "staffUniqueId" is required (not null)
            if (staffUniqueId == null)
            {
                throw new InvalidDataException("staffUniqueId is a required property for MnStaffReference and cannot be null");
            }
            else
            {
                this.StaffUniqueId = staffUniqueId;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// A unique alphanumeric code assigned to a staff.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a staff.</value>
        [DataMember(Name="staffUniqueId", EmitDefaultValue=false)]
        public string StaffUniqueId { get; set; }

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
            sb.Append("class MnStaffReference {\n");
            sb.Append("  StaffUniqueId: ").Append(StaffUniqueId).Append("\n");
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
            return this.Equals(input as MnStaffReference);
        }

        /// <summary>
        /// Returns true if MnStaffReference instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStaffReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStaffReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StaffUniqueId == input.StaffUniqueId ||
                    (this.StaffUniqueId != null &&
                    this.StaffUniqueId.Equals(input.StaffUniqueId))
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
                if (this.StaffUniqueId != null)
                    hashCode = hashCode * 59 + this.StaffUniqueId.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}
