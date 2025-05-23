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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Five_Twenty_Six_SISVendor_Profile
{
    /// <summary>
    /// TrackedChangesEdFiStaffSectionAssociationReadableDelete
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_staffSectionAssociation_readableDelete")]
    public partial class TrackedChangesEdFiStaffSectionAssociationReadableDelete : IEquatable<TrackedChangesEdFiStaffSectionAssociationReadableDelete>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiStaffSectionAssociationReadableDelete" /> class.
        /// </summary>
        /// <param name="id">Resource identifier.</param>
        /// <param name="changeVersion">Change version.</param>
        /// <param name="keyValues">keyValues.</param>
        public TrackedChangesEdFiStaffSectionAssociationReadableDelete(string id = default(string), decimal changeVersion = default(decimal), TrackedChangesEdFiStaffSectionAssociationReadableKey keyValues = default(TrackedChangesEdFiStaffSectionAssociationReadableKey))
        {
            this.Id = id;
            this.ChangeVersion = changeVersion;
            this.KeyValues = keyValues;
        }

        /// <summary>
        /// Resource identifier
        /// </summary>
        /// <value>Resource identifier</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Change version
        /// </summary>
        /// <value>Change version</value>
        [DataMember(Name = "changeVersion", EmitDefaultValue = false)]
        public decimal ChangeVersion { get; set; }

        /// <summary>
        /// Gets or Sets KeyValues
        /// </summary>
        [DataMember(Name = "keyValues", EmitDefaultValue = false)]
        public TrackedChangesEdFiStaffSectionAssociationReadableKey KeyValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiStaffSectionAssociationReadableDelete {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ChangeVersion: ").Append(ChangeVersion).Append("\n");
            sb.Append("  KeyValues: ").Append(KeyValues).Append("\n");
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
            return this.Equals(input as TrackedChangesEdFiStaffSectionAssociationReadableDelete);
        }

        /// <summary>
        /// Returns true if TrackedChangesEdFiStaffSectionAssociationReadableDelete instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedChangesEdFiStaffSectionAssociationReadableDelete to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedChangesEdFiStaffSectionAssociationReadableDelete input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ChangeVersion == input.ChangeVersion ||
                    this.ChangeVersion.Equals(input.ChangeVersion)
                ) && 
                (
                    this.KeyValues == input.KeyValues ||
                    (this.KeyValues != null &&
                    this.KeyValues.Equals(input.KeyValues))
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
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ChangeVersion.GetHashCode();
                if (this.KeyValues != null)
                {
                    hashCode = (hashCode * 59) + this.KeyValues.GetHashCode();
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
