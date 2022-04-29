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
    /// EdFiCommunityOrganization
    /// </summary>
    [DataContract]
    public partial class EdFiCommunityOrganization :  IEquatable<EdFiCommunityOrganization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCommunityOrganization" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCommunityOrganization() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCommunityOrganization" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="categories">An unordered collection of educationOrganizationCategories. The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state. (required).</param>
        /// <param name="communityOrganizationId">The identifier assigned to a CommunityOrganization. (required).</param>
        /// <param name="addresses">An unordered collection of educationOrganizationAddresses. The set of elements that describes an address for the education entity, including the street address, city, state, ZIP code, and ZIP code + 4..</param>
        /// <param name="identificationCodes">An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity..</param>
        /// <param name="indicators">An unordered collection of educationOrganizationIndicators. An indicator or metric of an Education Organization..</param>
        /// <param name="institutionTelephones">An unordered collection of educationOrganizationInstitutionTelephones. The 10-digit telephone number, including the area code, for the education entity..</param>
        /// <param name="internationalAddresses">An unordered collection of educationOrganizationInternationalAddresses. The set of elements that describes the international physical location of the education entity..</param>
        /// <param name="nameOfInstitution">The full, legally accepted name of the institution. (required).</param>
        /// <param name="operationalStatusDescriptor">The current operational status of the EducationOrganization (e.g., active, inactive)..</param>
        /// <param name="shortNameOfInstitution">A short name for the institution..</param>
        /// <param name="webSite">The public web site address (URL) for the EducationOrganization..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiCommunityOrganization(string id = default(string), List<EdFiEducationOrganizationCategory> categories = default(List<EdFiEducationOrganizationCategory>), int? communityOrganizationId = default(int?), List<EdFiEducationOrganizationAddress> addresses = default(List<EdFiEducationOrganizationAddress>), List<EdFiEducationOrganizationIdentificationCode> identificationCodes = default(List<EdFiEducationOrganizationIdentificationCode>), List<EdFiEducationOrganizationIndicator> indicators = default(List<EdFiEducationOrganizationIndicator>), List<EdFiEducationOrganizationInstitutionTelephone> institutionTelephones = default(List<EdFiEducationOrganizationInstitutionTelephone>), List<EdFiEducationOrganizationInternationalAddress> internationalAddresses = default(List<EdFiEducationOrganizationInternationalAddress>), string nameOfInstitution = default(string), string operationalStatusDescriptor = default(string), string shortNameOfInstitution = default(string), string webSite = default(string), string etag = default(string))
        {
            // to ensure "categories" is required (not null)
            if (categories == null)
            {
                throw new InvalidDataException("categories is a required property for EdFiCommunityOrganization and cannot be null");
            }
            else
            {
                this.Categories = categories;
            }
            // to ensure "communityOrganizationId" is required (not null)
            if (communityOrganizationId == null)
            {
                throw new InvalidDataException("communityOrganizationId is a required property for EdFiCommunityOrganization and cannot be null");
            }
            else
            {
                this.CommunityOrganizationId = communityOrganizationId;
            }
            // to ensure "nameOfInstitution" is required (not null)
            if (nameOfInstitution == null)
            {
                throw new InvalidDataException("nameOfInstitution is a required property for EdFiCommunityOrganization and cannot be null");
            }
            else
            {
                this.NameOfInstitution = nameOfInstitution;
            }
            this.Id = id;
            this.Addresses = addresses;
            this.IdentificationCodes = identificationCodes;
            this.Indicators = indicators;
            this.InstitutionTelephones = institutionTelephones;
            this.InternationalAddresses = internationalAddresses;
            this.OperationalStatusDescriptor = operationalStatusDescriptor;
            this.ShortNameOfInstitution = shortNameOfInstitution;
            this.WebSite = webSite;
            this.Etag = etag;
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
        public List<EdFiEducationOrganizationCategory> Categories { get; set; }

        /// <summary>
        /// The identifier assigned to a CommunityOrganization.
        /// </summary>
        /// <value>The identifier assigned to a CommunityOrganization.</value>
        [DataMember(Name="communityOrganizationId", EmitDefaultValue=false)]
        public int? CommunityOrganizationId { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationAddresses. The set of elements that describes an address for the education entity, including the street address, city, state, ZIP code, and ZIP code + 4.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationAddresses. The set of elements that describes an address for the education entity, including the street address, city, state, ZIP code, and ZIP code + 4.</value>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationAddress> Addresses { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity.</value>
        [DataMember(Name="identificationCodes", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationIdentificationCode> IdentificationCodes { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationIndicators. An indicator or metric of an Education Organization.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationIndicators. An indicator or metric of an Education Organization.</value>
        [DataMember(Name="indicators", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationIndicator> Indicators { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationInstitutionTelephones. The 10-digit telephone number, including the area code, for the education entity.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationInstitutionTelephones. The 10-digit telephone number, including the area code, for the education entity.</value>
        [DataMember(Name="institutionTelephones", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationInstitutionTelephone> InstitutionTelephones { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationInternationalAddresses. The set of elements that describes the international physical location of the education entity.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationInternationalAddresses. The set of elements that describes the international physical location of the education entity.</value>
        [DataMember(Name="internationalAddresses", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationInternationalAddress> InternationalAddresses { get; set; }

        /// <summary>
        /// The full, legally accepted name of the institution.
        /// </summary>
        /// <value>The full, legally accepted name of the institution.</value>
        [DataMember(Name="nameOfInstitution", EmitDefaultValue=false)]
        public string NameOfInstitution { get; set; }

        /// <summary>
        /// The current operational status of the EducationOrganization (e.g., active, inactive).
        /// </summary>
        /// <value>The current operational status of the EducationOrganization (e.g., active, inactive).</value>
        [DataMember(Name="operationalStatusDescriptor", EmitDefaultValue=false)]
        public string OperationalStatusDescriptor { get; set; }

        /// <summary>
        /// A short name for the institution.
        /// </summary>
        /// <value>A short name for the institution.</value>
        [DataMember(Name="shortNameOfInstitution", EmitDefaultValue=false)]
        public string ShortNameOfInstitution { get; set; }

        /// <summary>
        /// The public web site address (URL) for the EducationOrganization.
        /// </summary>
        /// <value>The public web site address (URL) for the EducationOrganization.</value>
        [DataMember(Name="webSite", EmitDefaultValue=false)]
        public string WebSite { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiCommunityOrganization {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  CommunityOrganizationId: ").Append(CommunityOrganizationId).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  IdentificationCodes: ").Append(IdentificationCodes).Append("\n");
            sb.Append("  Indicators: ").Append(Indicators).Append("\n");
            sb.Append("  InstitutionTelephones: ").Append(InstitutionTelephones).Append("\n");
            sb.Append("  InternationalAddresses: ").Append(InternationalAddresses).Append("\n");
            sb.Append("  NameOfInstitution: ").Append(NameOfInstitution).Append("\n");
            sb.Append("  OperationalStatusDescriptor: ").Append(OperationalStatusDescriptor).Append("\n");
            sb.Append("  ShortNameOfInstitution: ").Append(ShortNameOfInstitution).Append("\n");
            sb.Append("  WebSite: ").Append(WebSite).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            return this.Equals(input as EdFiCommunityOrganization);
        }

        /// <summary>
        /// Returns true if EdFiCommunityOrganization instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCommunityOrganization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCommunityOrganization input)
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
                    this.CommunityOrganizationId == input.CommunityOrganizationId ||
                    (this.CommunityOrganizationId != null &&
                    this.CommunityOrganizationId.Equals(input.CommunityOrganizationId))
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
                    this.Indicators == input.Indicators ||
                    this.Indicators != null &&
                    this.Indicators.SequenceEqual(input.Indicators)
                ) && 
                (
                    this.InstitutionTelephones == input.InstitutionTelephones ||
                    this.InstitutionTelephones != null &&
                    this.InstitutionTelephones.SequenceEqual(input.InstitutionTelephones)
                ) && 
                (
                    this.InternationalAddresses == input.InternationalAddresses ||
                    this.InternationalAddresses != null &&
                    this.InternationalAddresses.SequenceEqual(input.InternationalAddresses)
                ) && 
                (
                    this.NameOfInstitution == input.NameOfInstitution ||
                    (this.NameOfInstitution != null &&
                    this.NameOfInstitution.Equals(input.NameOfInstitution))
                ) && 
                (
                    this.OperationalStatusDescriptor == input.OperationalStatusDescriptor ||
                    (this.OperationalStatusDescriptor != null &&
                    this.OperationalStatusDescriptor.Equals(input.OperationalStatusDescriptor))
                ) && 
                (
                    this.ShortNameOfInstitution == input.ShortNameOfInstitution ||
                    (this.ShortNameOfInstitution != null &&
                    this.ShortNameOfInstitution.Equals(input.ShortNameOfInstitution))
                ) && 
                (
                    this.WebSite == input.WebSite ||
                    (this.WebSite != null &&
                    this.WebSite.Equals(input.WebSite))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
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
                if (this.CommunityOrganizationId != null)
                    hashCode = hashCode * 59 + this.CommunityOrganizationId.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.IdentificationCodes != null)
                    hashCode = hashCode * 59 + this.IdentificationCodes.GetHashCode();
                if (this.Indicators != null)
                    hashCode = hashCode * 59 + this.Indicators.GetHashCode();
                if (this.InstitutionTelephones != null)
                    hashCode = hashCode * 59 + this.InstitutionTelephones.GetHashCode();
                if (this.InternationalAddresses != null)
                    hashCode = hashCode * 59 + this.InternationalAddresses.GetHashCode();
                if (this.NameOfInstitution != null)
                    hashCode = hashCode * 59 + this.NameOfInstitution.GetHashCode();
                if (this.OperationalStatusDescriptor != null)
                    hashCode = hashCode * 59 + this.OperationalStatusDescriptor.GetHashCode();
                if (this.ShortNameOfInstitution != null)
                    hashCode = hashCode * 59 + this.ShortNameOfInstitution.GetHashCode();
                if (this.WebSite != null)
                    hashCode = hashCode * 59 + this.WebSite.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
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

            // OperationalStatusDescriptor (string) maxLength
            if(this.OperationalStatusDescriptor != null && this.OperationalStatusDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OperationalStatusDescriptor, length must be less than 306.", new [] { "OperationalStatusDescriptor" });
            }

            // ShortNameOfInstitution (string) maxLength
            if(this.ShortNameOfInstitution != null && this.ShortNameOfInstitution.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShortNameOfInstitution, length must be less than 75.", new [] { "ShortNameOfInstitution" });
            }

            // WebSite (string) maxLength
            if(this.WebSite != null && this.WebSite.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WebSite, length must be less than 255.", new [] { "WebSite" });
            }

            yield break;
        }
    }

}
