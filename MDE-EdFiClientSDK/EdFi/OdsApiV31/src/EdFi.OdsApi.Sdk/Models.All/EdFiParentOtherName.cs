/* 
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface. The Ed-Fi ODS / API supports both transactional and bulk modes of operation.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
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

namespace EdFi.OdsApi.Sdk.Models.All
{
    /// <summary>
    /// EdFiParentOtherName
    /// </summary>
    [DataContract]
    public partial class EdFiParentOtherName :  IEquatable<EdFiParentOtherName>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiParentOtherName" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiParentOtherName() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiParentOtherName" /> class.
        /// </summary>
        /// <param name="OtherNameTypeDescriptor">The types of alternate names for a person. (required).</param>
        /// <param name="FirstName">A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. (required).</param>
        /// <param name="GenerationCodeSuffix">An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III)..</param>
        /// <param name="LastSurname">The name borne in common by members of a family. (required).</param>
        /// <param name="MiddleName">A secondary name given to an individual at birth, baptism, or during another naming ceremony..</param>
        /// <param name="PersonalTitlePrefix">A prefix used to denote the title, degree, position, or seniority of the person..</param>
        public EdFiParentOtherName(string OtherNameTypeDescriptor = default(string), string FirstName = default(string), string GenerationCodeSuffix = default(string), string LastSurname = default(string), string MiddleName = default(string), string PersonalTitlePrefix = default(string))
        {
            // to ensure "OtherNameTypeDescriptor" is required (not null)
            if (OtherNameTypeDescriptor == null)
            {
                throw new InvalidDataException("OtherNameTypeDescriptor is a required property for EdFiParentOtherName and cannot be null");
            }
            else
            {
                this.OtherNameTypeDescriptor = OtherNameTypeDescriptor;
            }
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for EdFiParentOtherName and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "LastSurname" is required (not null)
            if (LastSurname == null)
            {
                throw new InvalidDataException("LastSurname is a required property for EdFiParentOtherName and cannot be null");
            }
            else
            {
                this.LastSurname = LastSurname;
            }
            this.GenerationCodeSuffix = GenerationCodeSuffix;
            this.MiddleName = MiddleName;
            this.PersonalTitlePrefix = PersonalTitlePrefix;
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
            sb.Append("class EdFiParentOtherName {\n");
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
        public string ToJson()
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
            return this.Equals(input as EdFiParentOtherName);
        }

        /// <summary>
        /// Returns true if EdFiParentOtherName instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiParentOtherName to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiParentOtherName input)
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
