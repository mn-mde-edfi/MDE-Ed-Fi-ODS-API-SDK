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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Two_Twenty_Three_Baseline_SIS_Vendor_Profile
{
    /// <summary>
    /// EdFiLocalEducationAgencyReadable
    /// </summary>
    [DataContract]
    public partial class EdFiLocalEducationAgencyReadable :  IEquatable<EdFiLocalEducationAgencyReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLocalEducationAgencyReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiLocalEducationAgencyReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLocalEducationAgencyReadable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="categories">An unordered collection of educationOrganizationCategories. The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state. (required).</param>
        /// <param name="localEducationAgencyId">The identifier assigned to a local education agency. (required).</param>
        /// <param name="stateEducationAgencyReference">stateEducationAgencyReference.</param>
        /// <param name="addresses">An unordered collection of educationOrganizationAddresses. The set of elements that describes an address for the education entity, including the street address, city, state, ZIP code, and ZIP code + 4..</param>
        /// <param name="identificationCodes">An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity..</param>
        /// <param name="nameOfInstitution">The full, legally accepted name of the institution. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">ext.</param>
        public EdFiLocalEducationAgencyReadable(string id = default(string), List<EdFiEducationOrganizationCategoryLocalEducationAgencyReadable> categories = default(List<EdFiEducationOrganizationCategoryLocalEducationAgencyReadable>), int? localEducationAgencyId = default(int?), EdFiStateEducationAgencyReference stateEducationAgencyReference = default(EdFiStateEducationAgencyReference), List<EdFiEducationOrganizationAddressLocalEducationAgencyReadable> addresses = default(List<EdFiEducationOrganizationAddressLocalEducationAgencyReadable>), List<EdFiEducationOrganizationIdentificationCodeLocalEducationAgencyReadable> identificationCodes = default(List<EdFiEducationOrganizationIdentificationCodeLocalEducationAgencyReadable>), string nameOfInstitution = default(string), string etag = default(string), LocalEducationAgencyExtensionsReadable ext = default(LocalEducationAgencyExtensionsReadable))
        {
            // to ensure "categories" is required (not null)
            if (categories == null)
            {
                throw new InvalidDataException("categories is a required property for EdFiLocalEducationAgencyReadable and cannot be null");
            }
            else
            {
                this.Categories = categories;
            }
            // to ensure "localEducationAgencyId" is required (not null)
            if (localEducationAgencyId == null)
            {
                throw new InvalidDataException("localEducationAgencyId is a required property for EdFiLocalEducationAgencyReadable and cannot be null");
            }
            else
            {
                this.LocalEducationAgencyId = localEducationAgencyId;
            }
            // to ensure "nameOfInstitution" is required (not null)
            if (nameOfInstitution == null)
            {
                throw new InvalidDataException("nameOfInstitution is a required property for EdFiLocalEducationAgencyReadable and cannot be null");
            }
            else
            {
                this.NameOfInstitution = nameOfInstitution;
            }
            this.Id = id;
            this.StateEducationAgencyReference = stateEducationAgencyReference;
            this.Addresses = addresses;
            this.IdentificationCodes = identificationCodes;
            this.Etag = etag;
            this.Ext = ext;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationCategories. The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationCategories. The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state.</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationCategoryLocalEducationAgencyReadable> Categories { get; set; }

        /// <summary>
        /// The identifier assigned to a local education agency.
        /// </summary>
        /// <value>The identifier assigned to a local education agency.</value>
        [DataMember(Name="localEducationAgencyId", EmitDefaultValue=false)]
        public int? LocalEducationAgencyId { get; set; }

        /// <summary>
        /// Gets or Sets StateEducationAgencyReference
        /// </summary>
        [DataMember(Name="stateEducationAgencyReference", EmitDefaultValue=false)]
        public EdFiStateEducationAgencyReference StateEducationAgencyReference { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationAddresses. The set of elements that describes an address for the education entity, including the street address, city, state, ZIP code, and ZIP code + 4.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationAddresses. The set of elements that describes an address for the education entity, including the street address, city, state, ZIP code, and ZIP code + 4.</value>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationAddressLocalEducationAgencyReadable> Addresses { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity.</value>
        [DataMember(Name="identificationCodes", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationIdentificationCodeLocalEducationAgencyReadable> IdentificationCodes { get; set; }

        /// <summary>
        /// The full, legally accepted name of the institution.
        /// </summary>
        /// <value>The full, legally accepted name of the institution.</value>
        [DataMember(Name="nameOfInstitution", EmitDefaultValue=false)]
        public string NameOfInstitution { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or Sets Ext
        /// </summary>
        [DataMember(Name="_ext", EmitDefaultValue=false)]
        public LocalEducationAgencyExtensionsReadable Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiLocalEducationAgencyReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  LocalEducationAgencyId: ").Append(LocalEducationAgencyId).Append("\n");
            sb.Append("  StateEducationAgencyReference: ").Append(StateEducationAgencyReference).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  IdentificationCodes: ").Append(IdentificationCodes).Append("\n");
            sb.Append("  NameOfInstitution: ").Append(NameOfInstitution).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
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
            return this.Equals(input as EdFiLocalEducationAgencyReadable);
        }

        /// <summary>
        /// Returns true if EdFiLocalEducationAgencyReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiLocalEducationAgencyReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiLocalEducationAgencyReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.LocalEducationAgencyId == input.LocalEducationAgencyId ||
                    (this.LocalEducationAgencyId != null &&
                    this.LocalEducationAgencyId.Equals(input.LocalEducationAgencyId))
                ) && 
                (
                    this.StateEducationAgencyReference == input.StateEducationAgencyReference ||
                    (this.StateEducationAgencyReference != null &&
                    this.StateEducationAgencyReference.Equals(input.StateEducationAgencyReference))
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.IdentificationCodes == input.IdentificationCodes ||
                    this.IdentificationCodes != null &&
                    this.IdentificationCodes.SequenceEqual(input.IdentificationCodes)
                ) && 
                (
                    this.NameOfInstitution == input.NameOfInstitution ||
                    (this.NameOfInstitution != null &&
                    this.NameOfInstitution.Equals(input.NameOfInstitution))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.Ext == input.Ext ||
                    (this.Ext != null &&
                    this.Ext.Equals(input.Ext))
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.LocalEducationAgencyId != null)
                    hashCode = hashCode * 59 + this.LocalEducationAgencyId.GetHashCode();
                if (this.StateEducationAgencyReference != null)
                    hashCode = hashCode * 59 + this.StateEducationAgencyReference.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.IdentificationCodes != null)
                    hashCode = hashCode * 59 + this.IdentificationCodes.GetHashCode();
                if (this.NameOfInstitution != null)
                    hashCode = hashCode * 59 + this.NameOfInstitution.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
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
            // NameOfInstitution (string) maxLength
            if(this.NameOfInstitution != null && this.NameOfInstitution.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NameOfInstitution, length must be less than 75.", new [] { "NameOfInstitution" });
            }

            yield break;
        }
    }

}
