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
    /// EdFiStaffOtherName
    /// </summary>
    [DataContract]
    public partial class EdFiStaffOtherName :  IEquatable<EdFiStaffOtherName>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffOtherName" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStaffOtherName() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffOtherName" /> class.
        /// </summary>
        /// <param name="otherNameTypeDescriptor">The types of alternate names for a person. (required).</param>
        /// <param name="firstName">A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. (required).</param>
        /// <param name="generationCodeSuffix">An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III)..</param>
        /// <param name="lastSurname">The name borne in common by members of a family. (required).</param>
        /// <param name="middleName">A secondary name given to an individual at birth, baptism, or during another naming ceremony..</param>
        /// <param name="personalTitlePrefix">A prefix used to denote the title, degree, position, or seniority of the person..</param>
        public EdFiStaffOtherName(string otherNameTypeDescriptor = default(string), string firstName = default(string), string generationCodeSuffix = default(string), string lastSurname = default(string), string middleName = default(string), string personalTitlePrefix = default(string))
        {
            // to ensure "otherNameTypeDescriptor" is required (not null)
            if (otherNameTypeDescriptor == null)
            {
                throw new InvalidDataException("otherNameTypeDescriptor is a required property for EdFiStaffOtherName and cannot be null");
            }
            else
            {
                this.OtherNameTypeDescriptor = otherNameTypeDescriptor;
            }
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for EdFiStaffOtherName and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }
            // to ensure "lastSurname" is required (not null)
            if (lastSurname == null)
            {
                throw new InvalidDataException("lastSurname is a required property for EdFiStaffOtherName and cannot be null");
            }
            else
            {
                this.LastSurname = lastSurname;
            }
            this.GenerationCodeSuffix = generationCodeSuffix;
            this.MiddleName = middleName;
            this.PersonalTitlePrefix = personalTitlePrefix;
        }
        
        /// <summary>
        /// The types of alternate names for a person.
        /// </summary>
        /// <value>The types of alternate names for a person.</value>
        [DataMember(Name="otherNameTypeDescriptor", EmitDefaultValue=false)]
        public string OtherNameTypeDescriptor { get; set; }

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
        /// The name borne in common by members of a family.
        /// </summary>
        /// <value>The name borne in common by members of a family.</value>
        [DataMember(Name="lastSurname", EmitDefaultValue=false)]
        public string LastSurname { get; set; }

        /// <summary>
        /// A secondary name given to an individual at birth, baptism, or during another naming ceremony.
        /// </summary>
        /// <value>A secondary name given to an individual at birth, baptism, or during another naming ceremony.</value>
        [DataMember(Name="middleName", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// A prefix used to denote the title, degree, position, or seniority of the person.
        /// </summary>
        /// <value>A prefix used to denote the title, degree, position, or seniority of the person.</value>
        [DataMember(Name="personalTitlePrefix", EmitDefaultValue=false)]
        public string PersonalTitlePrefix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStaffOtherName {\n");
            sb.Append("  OtherNameTypeDescriptor: ").Append(OtherNameTypeDescriptor).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  GenerationCodeSuffix: ").Append(GenerationCodeSuffix).Append("\n");
            sb.Append("  LastSurname: ").Append(LastSurname).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  PersonalTitlePrefix: ").Append(PersonalTitlePrefix).Append("\n");
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
            return this.Equals(input as EdFiStaffOtherName);
        }

        /// <summary>
        /// Returns true if EdFiStaffOtherName instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStaffOtherName to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStaffOtherName input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OtherNameTypeDescriptor == input.OtherNameTypeDescriptor ||
                    (this.OtherNameTypeDescriptor != null &&
                    this.OtherNameTypeDescriptor.Equals(input.OtherNameTypeDescriptor))
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
                    this.LastSurname == input.LastSurname ||
                    (this.LastSurname != null &&
                    this.LastSurname.Equals(input.LastSurname))
                ) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && 
                (
                    this.PersonalTitlePrefix == input.PersonalTitlePrefix ||
                    (this.PersonalTitlePrefix != null &&
                    this.PersonalTitlePrefix.Equals(input.PersonalTitlePrefix))
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
                if (this.OtherNameTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.OtherNameTypeDescriptor.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.GenerationCodeSuffix != null)
                    hashCode = hashCode * 59 + this.GenerationCodeSuffix.GetHashCode();
                if (this.LastSurname != null)
                    hashCode = hashCode * 59 + this.LastSurname.GetHashCode();
                if (this.MiddleName != null)
                    hashCode = hashCode * 59 + this.MiddleName.GetHashCode();
                if (this.PersonalTitlePrefix != null)
                    hashCode = hashCode * 59 + this.PersonalTitlePrefix.GetHashCode();
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
            // OtherNameTypeDescriptor (string) maxLength
            if(this.OtherNameTypeDescriptor != null && this.OtherNameTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OtherNameTypeDescriptor, length must be less than 306.", new [] { "OtherNameTypeDescriptor" });
            }

            // FirstName (string) maxLength
            if(this.FirstName != null && this.FirstName.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 75.", new [] { "FirstName" });
            }

            // GenerationCodeSuffix (string) maxLength
            if(this.GenerationCodeSuffix != null && this.GenerationCodeSuffix.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GenerationCodeSuffix, length must be less than 10.", new [] { "GenerationCodeSuffix" });
            }

            // LastSurname (string) maxLength
            if(this.LastSurname != null && this.LastSurname.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastSurname, length must be less than 75.", new [] { "LastSurname" });
            }

            // MiddleName (string) maxLength
            if(this.MiddleName != null && this.MiddleName.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MiddleName, length must be less than 75.", new [] { "MiddleName" });
            }

            // PersonalTitlePrefix (string) maxLength
            if(this.PersonalTitlePrefix != null && this.PersonalTitlePrefix.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PersonalTitlePrefix, length must be less than 30.", new [] { "PersonalTitlePrefix" });
            }

            yield break;
        }
    }

}
