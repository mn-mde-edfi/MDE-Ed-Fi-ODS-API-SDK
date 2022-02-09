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
    /// EdFiSchoolReadable
    /// </summary>
    [DataContract]
    public partial class EdFiSchoolReadable :  IEquatable<EdFiSchoolReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSchoolReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSchoolReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSchoolReadable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="educationOrganizationCategories">An unordered collection of educationOrganizationCategories. The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state. (required).</param>
        /// <param name="gradeLevels">An unordered collection of schoolGradeLevels. The grade levels served at the school. (required).</param>
        /// <param name="schoolId">The identifier assigned to a school. (required).</param>
        /// <param name="localEducationAgencyReference">localEducationAgencyReference.</param>
        /// <param name="addresses">An unordered collection of educationOrganizationAddresses. The set of elements that describes an address for the education entity, including the street address, city, state, ZIP code, and ZIP code + 4..</param>
        /// <param name="identificationCodes">An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity..</param>
        /// <param name="institutionTelephones">An unordered collection of educationOrganizationInstitutionTelephones. The 10-digit telephone number, including the area code, for the education entity..</param>
        /// <param name="nameOfInstitution">The full, legally accepted name of the institution. (required).</param>
        /// <param name="schoolCategories">An unordered collection of schoolCategories. The one or more categories of school. For example: High School, Middle School, and/or Elementary School..</param>
        /// <param name="titleIPartASchoolDesignationDescriptor">Denotes the Title I Part A designation for the school..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">ext.</param>
        public EdFiSchoolReadable(string id = default(string), List<EdFiEducationOrganizationCategorySchoolReadable> educationOrganizationCategories = default(List<EdFiEducationOrganizationCategorySchoolReadable>), List<EdFiSchoolGradeLevelReadable> gradeLevels = default(List<EdFiSchoolGradeLevelReadable>), int? schoolId = default(int?), EdFiLocalEducationAgencyReference localEducationAgencyReference = default(EdFiLocalEducationAgencyReference), List<EdFiEducationOrganizationAddressSchoolReadable> addresses = default(List<EdFiEducationOrganizationAddressSchoolReadable>), List<EdFiEducationOrganizationIdentificationCodeSchoolReadable> identificationCodes = default(List<EdFiEducationOrganizationIdentificationCodeSchoolReadable>), List<EdFiEducationOrganizationInstitutionTelephoneSchoolReadable> institutionTelephones = default(List<EdFiEducationOrganizationInstitutionTelephoneSchoolReadable>), string nameOfInstitution = default(string), List<EdFiSchoolCategoryReadable> schoolCategories = default(List<EdFiSchoolCategoryReadable>), string titleIPartASchoolDesignationDescriptor = default(string), string etag = default(string), SchoolExtensionsReadable ext = default(SchoolExtensionsReadable))
        {
            // to ensure "educationOrganizationCategories" is required (not null)
            if (educationOrganizationCategories == null)
            {
                throw new InvalidDataException("educationOrganizationCategories is a required property for EdFiSchoolReadable and cannot be null");
            }
            else
            {
                this.EducationOrganizationCategories = educationOrganizationCategories;
            }
            // to ensure "gradeLevels" is required (not null)
            if (gradeLevels == null)
            {
                throw new InvalidDataException("gradeLevels is a required property for EdFiSchoolReadable and cannot be null");
            }
            else
            {
                this.GradeLevels = gradeLevels;
            }
            // to ensure "schoolId" is required (not null)
            if (schoolId == null)
            {
                throw new InvalidDataException("schoolId is a required property for EdFiSchoolReadable and cannot be null");
            }
            else
            {
                this.SchoolId = schoolId;
            }
            // to ensure "nameOfInstitution" is required (not null)
            if (nameOfInstitution == null)
            {
                throw new InvalidDataException("nameOfInstitution is a required property for EdFiSchoolReadable and cannot be null");
            }
            else
            {
                this.NameOfInstitution = nameOfInstitution;
            }
            this.Id = id;
            this.LocalEducationAgencyReference = localEducationAgencyReference;
            this.Addresses = addresses;
            this.IdentificationCodes = identificationCodes;
            this.InstitutionTelephones = institutionTelephones;
            this.SchoolCategories = schoolCategories;
            this.TitleIPartASchoolDesignationDescriptor = titleIPartASchoolDesignationDescriptor;
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
        [DataMember(Name="educationOrganizationCategories", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationCategorySchoolReadable> EducationOrganizationCategories { get; set; }

        /// <summary>
        /// An unordered collection of schoolGradeLevels. The grade levels served at the school.
        /// </summary>
        /// <value>An unordered collection of schoolGradeLevels. The grade levels served at the school.</value>
        [DataMember(Name="gradeLevels", EmitDefaultValue=false)]
        public List<EdFiSchoolGradeLevelReadable> GradeLevels { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name="schoolId", EmitDefaultValue=false)]
        public int? SchoolId { get; set; }

        /// <summary>
        /// Gets or Sets LocalEducationAgencyReference
        /// </summary>
        [DataMember(Name="localEducationAgencyReference", EmitDefaultValue=false)]
        public EdFiLocalEducationAgencyReference LocalEducationAgencyReference { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationAddresses. The set of elements that describes an address for the education entity, including the street address, city, state, ZIP code, and ZIP code + 4.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationAddresses. The set of elements that describes an address for the education entity, including the street address, city, state, ZIP code, and ZIP code + 4.</value>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationAddressSchoolReadable> Addresses { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity.</value>
        [DataMember(Name="identificationCodes", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationIdentificationCodeSchoolReadable> IdentificationCodes { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationInstitutionTelephones. The 10-digit telephone number, including the area code, for the education entity.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationInstitutionTelephones. The 10-digit telephone number, including the area code, for the education entity.</value>
        [DataMember(Name="institutionTelephones", EmitDefaultValue=false)]
        public List<EdFiEducationOrganizationInstitutionTelephoneSchoolReadable> InstitutionTelephones { get; set; }

        /// <summary>
        /// The full, legally accepted name of the institution.
        /// </summary>
        /// <value>The full, legally accepted name of the institution.</value>
        [DataMember(Name="nameOfInstitution", EmitDefaultValue=false)]
        public string NameOfInstitution { get; set; }

        /// <summary>
        /// An unordered collection of schoolCategories. The one or more categories of school. For example: High School, Middle School, and/or Elementary School.
        /// </summary>
        /// <value>An unordered collection of schoolCategories. The one or more categories of school. For example: High School, Middle School, and/or Elementary School.</value>
        [DataMember(Name="schoolCategories", EmitDefaultValue=false)]
        public List<EdFiSchoolCategoryReadable> SchoolCategories { get; set; }

        /// <summary>
        /// Denotes the Title I Part A designation for the school.
        /// </summary>
        /// <value>Denotes the Title I Part A designation for the school.</value>
        [DataMember(Name="titleIPartASchoolDesignationDescriptor", EmitDefaultValue=false)]
        public string TitleIPartASchoolDesignationDescriptor { get; set; }

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
        public SchoolExtensionsReadable Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiSchoolReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EducationOrganizationCategories: ").Append(EducationOrganizationCategories).Append("\n");
            sb.Append("  GradeLevels: ").Append(GradeLevels).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  LocalEducationAgencyReference: ").Append(LocalEducationAgencyReference).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  IdentificationCodes: ").Append(IdentificationCodes).Append("\n");
            sb.Append("  InstitutionTelephones: ").Append(InstitutionTelephones).Append("\n");
            sb.Append("  NameOfInstitution: ").Append(NameOfInstitution).Append("\n");
            sb.Append("  SchoolCategories: ").Append(SchoolCategories).Append("\n");
            sb.Append("  TitleIPartASchoolDesignationDescriptor: ").Append(TitleIPartASchoolDesignationDescriptor).Append("\n");
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
            return this.Equals(input as EdFiSchoolReadable);
        }

        /// <summary>
        /// Returns true if EdFiSchoolReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSchoolReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSchoolReadable input)
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
                    this.EducationOrganizationCategories == input.EducationOrganizationCategories ||
                    this.EducationOrganizationCategories != null &&
                    this.EducationOrganizationCategories.SequenceEqual(input.EducationOrganizationCategories)
                ) && 
                (
                    this.GradeLevels == input.GradeLevels ||
                    this.GradeLevels != null &&
                    this.GradeLevels.SequenceEqual(input.GradeLevels)
                ) && 
                (
                    this.SchoolId == input.SchoolId ||
                    (this.SchoolId != null &&
                    this.SchoolId.Equals(input.SchoolId))
                ) && 
                (
                    this.LocalEducationAgencyReference == input.LocalEducationAgencyReference ||
                    (this.LocalEducationAgencyReference != null &&
                    this.LocalEducationAgencyReference.Equals(input.LocalEducationAgencyReference))
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
                    this.InstitutionTelephones == input.InstitutionTelephones ||
                    this.InstitutionTelephones != null &&
                    this.InstitutionTelephones.SequenceEqual(input.InstitutionTelephones)
                ) && 
                (
                    this.NameOfInstitution == input.NameOfInstitution ||
                    (this.NameOfInstitution != null &&
                    this.NameOfInstitution.Equals(input.NameOfInstitution))
                ) && 
                (
                    this.SchoolCategories == input.SchoolCategories ||
                    this.SchoolCategories != null &&
                    this.SchoolCategories.SequenceEqual(input.SchoolCategories)
                ) && 
                (
                    this.TitleIPartASchoolDesignationDescriptor == input.TitleIPartASchoolDesignationDescriptor ||
                    (this.TitleIPartASchoolDesignationDescriptor != null &&
                    this.TitleIPartASchoolDesignationDescriptor.Equals(input.TitleIPartASchoolDesignationDescriptor))
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
                if (this.EducationOrganizationCategories != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationCategories.GetHashCode();
                if (this.GradeLevels != null)
                    hashCode = hashCode * 59 + this.GradeLevels.GetHashCode();
                if (this.SchoolId != null)
                    hashCode = hashCode * 59 + this.SchoolId.GetHashCode();
                if (this.LocalEducationAgencyReference != null)
                    hashCode = hashCode * 59 + this.LocalEducationAgencyReference.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.IdentificationCodes != null)
                    hashCode = hashCode * 59 + this.IdentificationCodes.GetHashCode();
                if (this.InstitutionTelephones != null)
                    hashCode = hashCode * 59 + this.InstitutionTelephones.GetHashCode();
                if (this.NameOfInstitution != null)
                    hashCode = hashCode * 59 + this.NameOfInstitution.GetHashCode();
                if (this.SchoolCategories != null)
                    hashCode = hashCode * 59 + this.SchoolCategories.GetHashCode();
                if (this.TitleIPartASchoolDesignationDescriptor != null)
                    hashCode = hashCode * 59 + this.TitleIPartASchoolDesignationDescriptor.GetHashCode();
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

            // TitleIPartASchoolDesignationDescriptor (string) maxLength
            if(this.TitleIPartASchoolDesignationDescriptor != null && this.TitleIPartASchoolDesignationDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TitleIPartASchoolDesignationDescriptor, length must be less than 306.", new [] { "TitleIPartASchoolDesignationDescriptor" });
            }

            yield break;
        }
    }

}
