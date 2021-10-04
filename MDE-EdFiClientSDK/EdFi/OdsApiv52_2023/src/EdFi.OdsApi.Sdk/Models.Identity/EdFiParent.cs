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

namespace EdFi.OdsApi.Sdk.Models.Identity
{
    /// <summary>
    /// EdFiParent
    /// </summary>
    [DataContract]
    public partial class EdFiParent :  IEquatable<EdFiParent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiParent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiParent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiParent" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="parentUniqueId">A unique alphanumeric code assigned to a parent. (required).</param>
        /// <param name="personReference">personReference.</param>
        /// <param name="addresses">An unordered collection of parentAddresses. Parent&#39;s address, if different from the student address..</param>
        /// <param name="electronicMails">An unordered collection of parentElectronicMails. The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the individual or organization belongs..</param>
        /// <param name="firstName">A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. (required).</param>
        /// <param name="generationCodeSuffix">An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III)..</param>
        /// <param name="highestCompletedLevelOfEducationDescriptor">The extent of formal instruction an individual has received (e.g., the highest grade in school completed or its equivalent or the highest degree received)..</param>
        /// <param name="internationalAddresses">An unordered collection of parentInternationalAddresses. The set of elements that describes an international address..</param>
        /// <param name="languages">An unordered collection of parentLanguages. The language(s) the individual uses to communicate. It is strongly recommended that entries use only ISO 639-2 language codes..</param>
        /// <param name="lastSurname">The name borne in common by members of a family. (required).</param>
        /// <param name="loginId">The login ID for the user; used for security access control interface..</param>
        /// <param name="maidenName">The person&#39;s maiden name..</param>
        /// <param name="middleName">A secondary name given to an individual at birth, baptism, or during another naming ceremony..</param>
        /// <param name="otherNames">An unordered collection of parentOtherNames. Other names (e.g., alias, nickname, previous legal name) associated with a person..</param>
        /// <param name="personalIdentificationDocuments">An unordered collection of parentPersonalIdentificationDocuments. The documents presented as evident to verify one&#39;s personal identity; for example: drivers license, passport, birth certificate, etc..</param>
        /// <param name="personalTitlePrefix">A prefix used to denote the title, degree, position, or seniority of the person..</param>
        /// <param name="sexDescriptor">A person&#39;s gender..</param>
        /// <param name="telephones">An unordered collection of parentTelephones. The 10-digit telephone number, including the area code, for the person..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">ext.</param>
        public EdFiParent(string id = default(string), string parentUniqueId = default(string), EdFiPersonReference personReference = default(EdFiPersonReference), List<EdFiParentAddress> addresses = default(List<EdFiParentAddress>), List<EdFiParentElectronicMail> electronicMails = default(List<EdFiParentElectronicMail>), string firstName = default(string), string generationCodeSuffix = default(string), string highestCompletedLevelOfEducationDescriptor = default(string), List<EdFiParentInternationalAddress> internationalAddresses = default(List<EdFiParentInternationalAddress>), List<EdFiParentLanguage> languages = default(List<EdFiParentLanguage>), string lastSurname = default(string), string loginId = default(string), string maidenName = default(string), string middleName = default(string), List<EdFiParentOtherName> otherNames = default(List<EdFiParentOtherName>), List<EdFiParentPersonalIdentificationDocument> personalIdentificationDocuments = default(List<EdFiParentPersonalIdentificationDocument>), string personalTitlePrefix = default(string), string sexDescriptor = default(string), List<EdFiParentTelephone> telephones = default(List<EdFiParentTelephone>), string etag = default(string), ParentExtensions ext = default(ParentExtensions))
        {
            // to ensure "parentUniqueId" is required (not null)
            if (parentUniqueId == null)
            {
                throw new InvalidDataException("parentUniqueId is a required property for EdFiParent and cannot be null");
            }
            else
            {
                this.ParentUniqueId = parentUniqueId;
            }
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for EdFiParent and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }
            // to ensure "lastSurname" is required (not null)
            if (lastSurname == null)
            {
                throw new InvalidDataException("lastSurname is a required property for EdFiParent and cannot be null");
            }
            else
            {
                this.LastSurname = lastSurname;
            }
            this.Id = id;
            this.PersonReference = personReference;
            this.Addresses = addresses;
            this.ElectronicMails = electronicMails;
            this.GenerationCodeSuffix = generationCodeSuffix;
            this.HighestCompletedLevelOfEducationDescriptor = highestCompletedLevelOfEducationDescriptor;
            this.InternationalAddresses = internationalAddresses;
            this.Languages = languages;
            this.LoginId = loginId;
            this.MaidenName = maidenName;
            this.MiddleName = middleName;
            this.OtherNames = otherNames;
            this.PersonalIdentificationDocuments = personalIdentificationDocuments;
            this.PersonalTitlePrefix = personalTitlePrefix;
            this.SexDescriptor = sexDescriptor;
            this.Telephones = telephones;
            this.Etag = etag;
            this.Ext = ext;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a parent.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a parent.</value>
        [DataMember(Name="parentUniqueId", EmitDefaultValue=false)]
        public string ParentUniqueId { get; set; }

        /// <summary>
        /// Gets or Sets PersonReference
        /// </summary>
        [DataMember(Name="personReference", EmitDefaultValue=false)]
        public EdFiPersonReference PersonReference { get; set; }

        /// <summary>
        /// An unordered collection of parentAddresses. Parent&#39;s address, if different from the student address.
        /// </summary>
        /// <value>An unordered collection of parentAddresses. Parent&#39;s address, if different from the student address.</value>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<EdFiParentAddress> Addresses { get; set; }

        /// <summary>
        /// An unordered collection of parentElectronicMails. The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the individual or organization belongs.
        /// </summary>
        /// <value>An unordered collection of parentElectronicMails. The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the individual or organization belongs.</value>
        [DataMember(Name="electronicMails", EmitDefaultValue=false)]
        public List<EdFiParentElectronicMail> ElectronicMails { get; set; }

        /// <summary>
        /// A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.
        /// </summary>
        /// <value>A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III).
        /// </summary>
        /// <value>An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III).</value>
        [DataMember(Name="generationCodeSuffix", EmitDefaultValue=false)]
        public string GenerationCodeSuffix { get; set; }

        /// <summary>
        /// The extent of formal instruction an individual has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        /// <value>The extent of formal instruction an individual has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).</value>
        [DataMember(Name="highestCompletedLevelOfEducationDescriptor", EmitDefaultValue=false)]
        public string HighestCompletedLevelOfEducationDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of parentInternationalAddresses. The set of elements that describes an international address.
        /// </summary>
        /// <value>An unordered collection of parentInternationalAddresses. The set of elements that describes an international address.</value>
        [DataMember(Name="internationalAddresses", EmitDefaultValue=false)]
        public List<EdFiParentInternationalAddress> InternationalAddresses { get; set; }

        /// <summary>
        /// An unordered collection of parentLanguages. The language(s) the individual uses to communicate. It is strongly recommended that entries use only ISO 639-2 language codes.
        /// </summary>
        /// <value>An unordered collection of parentLanguages. The language(s) the individual uses to communicate. It is strongly recommended that entries use only ISO 639-2 language codes.</value>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<EdFiParentLanguage> Languages { get; set; }

        /// <summary>
        /// The name borne in common by members of a family.
        /// </summary>
        /// <value>The name borne in common by members of a family.</value>
        [DataMember(Name="lastSurname", EmitDefaultValue=false)]
        public string LastSurname { get; set; }

        /// <summary>
        /// The login ID for the user; used for security access control interface.
        /// </summary>
        /// <value>The login ID for the user; used for security access control interface.</value>
        [DataMember(Name="loginId", EmitDefaultValue=false)]
        public string LoginId { get; set; }

        /// <summary>
        /// The person&#39;s maiden name.
        /// </summary>
        /// <value>The person&#39;s maiden name.</value>
        [DataMember(Name="maidenName", EmitDefaultValue=false)]
        public string MaidenName { get; set; }

        /// <summary>
        /// A secondary name given to an individual at birth, baptism, or during another naming ceremony.
        /// </summary>
        /// <value>A secondary name given to an individual at birth, baptism, or during another naming ceremony.</value>
        [DataMember(Name="middleName", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// An unordered collection of parentOtherNames. Other names (e.g., alias, nickname, previous legal name) associated with a person.
        /// </summary>
        /// <value>An unordered collection of parentOtherNames. Other names (e.g., alias, nickname, previous legal name) associated with a person.</value>
        [DataMember(Name="otherNames", EmitDefaultValue=false)]
        public List<EdFiParentOtherName> OtherNames { get; set; }

        /// <summary>
        /// An unordered collection of parentPersonalIdentificationDocuments. The documents presented as evident to verify one&#39;s personal identity; for example: drivers license, passport, birth certificate, etc.
        /// </summary>
        /// <value>An unordered collection of parentPersonalIdentificationDocuments. The documents presented as evident to verify one&#39;s personal identity; for example: drivers license, passport, birth certificate, etc.</value>
        [DataMember(Name="personalIdentificationDocuments", EmitDefaultValue=false)]
        public List<EdFiParentPersonalIdentificationDocument> PersonalIdentificationDocuments { get; set; }

        /// <summary>
        /// A prefix used to denote the title, degree, position, or seniority of the person.
        /// </summary>
        /// <value>A prefix used to denote the title, degree, position, or seniority of the person.</value>
        [DataMember(Name="personalTitlePrefix", EmitDefaultValue=false)]
        public string PersonalTitlePrefix { get; set; }

        /// <summary>
        /// A person&#39;s gender.
        /// </summary>
        /// <value>A person&#39;s gender.</value>
        [DataMember(Name="sexDescriptor", EmitDefaultValue=false)]
        public string SexDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of parentTelephones. The 10-digit telephone number, including the area code, for the person.
        /// </summary>
        /// <value>An unordered collection of parentTelephones. The 10-digit telephone number, including the area code, for the person.</value>
        [DataMember(Name="telephones", EmitDefaultValue=false)]
        public List<EdFiParentTelephone> Telephones { get; set; }

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
        public ParentExtensions Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiParent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ParentUniqueId: ").Append(ParentUniqueId).Append("\n");
            sb.Append("  PersonReference: ").Append(PersonReference).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  ElectronicMails: ").Append(ElectronicMails).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  GenerationCodeSuffix: ").Append(GenerationCodeSuffix).Append("\n");
            sb.Append("  HighestCompletedLevelOfEducationDescriptor: ").Append(HighestCompletedLevelOfEducationDescriptor).Append("\n");
            sb.Append("  InternationalAddresses: ").Append(InternationalAddresses).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  LastSurname: ").Append(LastSurname).Append("\n");
            sb.Append("  LoginId: ").Append(LoginId).Append("\n");
            sb.Append("  MaidenName: ").Append(MaidenName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  OtherNames: ").Append(OtherNames).Append("\n");
            sb.Append("  PersonalIdentificationDocuments: ").Append(PersonalIdentificationDocuments).Append("\n");
            sb.Append("  PersonalTitlePrefix: ").Append(PersonalTitlePrefix).Append("\n");
            sb.Append("  SexDescriptor: ").Append(SexDescriptor).Append("\n");
            sb.Append("  Telephones: ").Append(Telephones).Append("\n");
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
            return this.Equals(input as EdFiParent);
        }

        /// <summary>
        /// Returns true if EdFiParent instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiParent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiParent input)
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
                    this.ParentUniqueId == input.ParentUniqueId ||
                    (this.ParentUniqueId != null &&
                    this.ParentUniqueId.Equals(input.ParentUniqueId))
                ) && 
                (
                    this.PersonReference == input.PersonReference ||
                    (this.PersonReference != null &&
                    this.PersonReference.Equals(input.PersonReference))
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.ElectronicMails == input.ElectronicMails ||
                    this.ElectronicMails != null &&
                    this.ElectronicMails.SequenceEqual(input.ElectronicMails)
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.GenerationCodeSuffix == input.GenerationCodeSuffix ||
                    (this.GenerationCodeSuffix != null &&
                    this.GenerationCodeSuffix.Equals(input.GenerationCodeSuffix))
                ) && 
                (
                    this.HighestCompletedLevelOfEducationDescriptor == input.HighestCompletedLevelOfEducationDescriptor ||
                    (this.HighestCompletedLevelOfEducationDescriptor != null &&
                    this.HighestCompletedLevelOfEducationDescriptor.Equals(input.HighestCompletedLevelOfEducationDescriptor))
                ) && 
                (
                    this.InternationalAddresses == input.InternationalAddresses ||
                    this.InternationalAddresses != null &&
                    this.InternationalAddresses.SequenceEqual(input.InternationalAddresses)
                ) && 
                (
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                ) && 
                (
                    this.LastSurname == input.LastSurname ||
                    (this.LastSurname != null &&
                    this.LastSurname.Equals(input.LastSurname))
                ) && 
                (
                    this.LoginId == input.LoginId ||
                    (this.LoginId != null &&
                    this.LoginId.Equals(input.LoginId))
                ) && 
                (
                    this.MaidenName == input.MaidenName ||
                    (this.MaidenName != null &&
                    this.MaidenName.Equals(input.MaidenName))
                ) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && 
                (
                    this.OtherNames == input.OtherNames ||
                    this.OtherNames != null &&
                    this.OtherNames.SequenceEqual(input.OtherNames)
                ) && 
                (
                    this.PersonalIdentificationDocuments == input.PersonalIdentificationDocuments ||
                    this.PersonalIdentificationDocuments != null &&
                    this.PersonalIdentificationDocuments.SequenceEqual(input.PersonalIdentificationDocuments)
                ) && 
                (
                    this.PersonalTitlePrefix == input.PersonalTitlePrefix ||
                    (this.PersonalTitlePrefix != null &&
                    this.PersonalTitlePrefix.Equals(input.PersonalTitlePrefix))
                ) && 
                (
                    this.SexDescriptor == input.SexDescriptor ||
                    (this.SexDescriptor != null &&
                    this.SexDescriptor.Equals(input.SexDescriptor))
                ) && 
                (
                    this.Telephones == input.Telephones ||
                    this.Telephones != null &&
                    this.Telephones.SequenceEqual(input.Telephones)
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
                if (this.ParentUniqueId != null)
                    hashCode = hashCode * 59 + this.ParentUniqueId.GetHashCode();
                if (this.PersonReference != null)
                    hashCode = hashCode * 59 + this.PersonReference.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.ElectronicMails != null)
                    hashCode = hashCode * 59 + this.ElectronicMails.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.GenerationCodeSuffix != null)
                    hashCode = hashCode * 59 + this.GenerationCodeSuffix.GetHashCode();
                if (this.HighestCompletedLevelOfEducationDescriptor != null)
                    hashCode = hashCode * 59 + this.HighestCompletedLevelOfEducationDescriptor.GetHashCode();
                if (this.InternationalAddresses != null)
                    hashCode = hashCode * 59 + this.InternationalAddresses.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
                if (this.LastSurname != null)
                    hashCode = hashCode * 59 + this.LastSurname.GetHashCode();
                if (this.LoginId != null)
                    hashCode = hashCode * 59 + this.LoginId.GetHashCode();
                if (this.MaidenName != null)
                    hashCode = hashCode * 59 + this.MaidenName.GetHashCode();
                if (this.MiddleName != null)
                    hashCode = hashCode * 59 + this.MiddleName.GetHashCode();
                if (this.OtherNames != null)
                    hashCode = hashCode * 59 + this.OtherNames.GetHashCode();
                if (this.PersonalIdentificationDocuments != null)
                    hashCode = hashCode * 59 + this.PersonalIdentificationDocuments.GetHashCode();
                if (this.PersonalTitlePrefix != null)
                    hashCode = hashCode * 59 + this.PersonalTitlePrefix.GetHashCode();
                if (this.SexDescriptor != null)
                    hashCode = hashCode * 59 + this.SexDescriptor.GetHashCode();
                if (this.Telephones != null)
                    hashCode = hashCode * 59 + this.Telephones.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
                return hashCode;
            }
        }
    }

}
