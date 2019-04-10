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
    /// EdFiAchievementCategoryDescriptor
    /// </summary>
    [DataContract]
    public partial class EdFiAchievementCategoryDescriptor :  IEquatable<EdFiAchievementCategoryDescriptor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAchievementCategoryDescriptor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiAchievementCategoryDescriptor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAchievementCategoryDescriptor" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="AchievementCategoryDescriptorId">A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table..</param>
        /// <param name="CodeValue">A code or abbreviation that is used to refer to the descriptor. (required).</param>
        /// <param name="Description">The description of the descriptor..</param>
        /// <param name="EffectiveBeginDate">The beginning date of the period when the descriptor is in effect. If omitted, the default is immediate effectiveness..</param>
        /// <param name="EffectiveEndDate">The end date of the period when the descriptor is in effect..</param>
        /// <param name="_Namespace">A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary. (required).</param>
        /// <param name="PriorDescriptorId">A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table..</param>
        /// <param name="ShortDescription">A shortened description for the descriptor. (required).</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiAchievementCategoryDescriptor(string Id = default(string), int? AchievementCategoryDescriptorId = default(int?), string CodeValue = default(string), string Description = default(string), DateTime? EffectiveBeginDate = default(DateTime?), DateTime? EffectiveEndDate = default(DateTime?), string _Namespace = default(string), int? PriorDescriptorId = default(int?), string ShortDescription = default(string), string Etag = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiAchievementCategoryDescriptor and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "CodeValue" is required (not null)
            if (CodeValue == null)
            {
                throw new InvalidDataException("CodeValue is a required property for EdFiAchievementCategoryDescriptor and cannot be null");
            }
            else
            {
                this.CodeValue = CodeValue;
            }
            // to ensure "_Namespace" is required (not null)
            if (_Namespace == null)
            {
                throw new InvalidDataException("_Namespace is a required property for EdFiAchievementCategoryDescriptor and cannot be null");
            }
            else
            {
                this._Namespace = _Namespace;
            }
            // to ensure "ShortDescription" is required (not null)
            if (ShortDescription == null)
            {
                throw new InvalidDataException("ShortDescription is a required property for EdFiAchievementCategoryDescriptor and cannot be null");
            }
            else
            {
                this.ShortDescription = ShortDescription;
            }
            this.AchievementCategoryDescriptorId = AchievementCategoryDescriptorId;
            this.Description = Description;
            this.EffectiveBeginDate = EffectiveBeginDate;
            this.EffectiveEndDate = EffectiveEndDate;
            this.PriorDescriptorId = PriorDescriptorId;
            this.Etag = Etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        /// <value>A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.</value>
        [DataMember(Name="achievementCategoryDescriptorId", EmitDefaultValue=false)]
        public int? AchievementCategoryDescriptorId { get; set; }

        /// <summary>
        /// A code or abbreviation that is used to refer to the descriptor.
        /// </summary>
        /// <value>A code or abbreviation that is used to refer to the descriptor.</value>
        [DataMember(Name="codeValue", EmitDefaultValue=false)]
        public string CodeValue { get; set; }

        /// <summary>
        /// The description of the descriptor.
        /// </summary>
        /// <value>The description of the descriptor.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The beginning date of the period when the descriptor is in effect. If omitted, the default is immediate effectiveness.
        /// </summary>
        /// <value>The beginning date of the period when the descriptor is in effect. If omitted, the default is immediate effectiveness.</value>
        [DataMember(Name="effectiveBeginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EffectiveBeginDate { get; set; }

        /// <summary>
        /// The end date of the period when the descriptor is in effect.
        /// </summary>
        /// <value>The end date of the period when the descriptor is in effect.</value>
        [DataMember(Name="effectiveEndDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EffectiveEndDate { get; set; }

        /// <summary>
        /// A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary.
        /// </summary>
        /// <value>A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary.</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string _Namespace { get; set; }

        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        /// <value>A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.</value>
        [DataMember(Name="priorDescriptorId", EmitDefaultValue=false)]
        public int? PriorDescriptorId { get; set; }

        /// <summary>
        /// A shortened description for the descriptor.
        /// </summary>
        /// <value>A shortened description for the descriptor.</value>
        [DataMember(Name="shortDescription", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }

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
            sb.Append("class EdFiAchievementCategoryDescriptor {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AchievementCategoryDescriptorId: ").Append(AchievementCategoryDescriptorId).Append("\n");
            sb.Append("  CodeValue: ").Append(CodeValue).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EffectiveBeginDate: ").Append(EffectiveBeginDate).Append("\n");
            sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
            sb.Append("  _Namespace: ").Append(_Namespace).Append("\n");
            sb.Append("  PriorDescriptorId: ").Append(PriorDescriptorId).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            return this.Equals(input as EdFiAchievementCategoryDescriptor);
        }

        /// <summary>
        /// Returns true if EdFiAchievementCategoryDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiAchievementCategoryDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiAchievementCategoryDescriptor input)
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
                    this.AchievementCategoryDescriptorId == input.AchievementCategoryDescriptorId ||
                    (this.AchievementCategoryDescriptorId != null &&
                    this.AchievementCategoryDescriptorId.Equals(input.AchievementCategoryDescriptorId))
                ) && 
                (
                    this.CodeValue == input.CodeValue ||
                    (this.CodeValue != null &&
                    this.CodeValue.Equals(input.CodeValue))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EffectiveBeginDate == input.EffectiveBeginDate ||
                    (this.EffectiveBeginDate != null &&
                    this.EffectiveBeginDate.Equals(input.EffectiveBeginDate))
                ) && 
                (
                    this.EffectiveEndDate == input.EffectiveEndDate ||
                    (this.EffectiveEndDate != null &&
                    this.EffectiveEndDate.Equals(input.EffectiveEndDate))
                ) && 
                (
                    this._Namespace == input._Namespace ||
                    (this._Namespace != null &&
                    this._Namespace.Equals(input._Namespace))
                ) && 
                (
                    this.PriorDescriptorId == input.PriorDescriptorId ||
                    (this.PriorDescriptorId != null &&
                    this.PriorDescriptorId.Equals(input.PriorDescriptorId))
                ) && 
                (
                    this.ShortDescription == input.ShortDescription ||
                    (this.ShortDescription != null &&
                    this.ShortDescription.Equals(input.ShortDescription))
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
                if (this.AchievementCategoryDescriptorId != null)
                    hashCode = hashCode * 59 + this.AchievementCategoryDescriptorId.GetHashCode();
                if (this.CodeValue != null)
                    hashCode = hashCode * 59 + this.CodeValue.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EffectiveBeginDate != null)
                    hashCode = hashCode * 59 + this.EffectiveBeginDate.GetHashCode();
                if (this.EffectiveEndDate != null)
                    hashCode = hashCode * 59 + this.EffectiveEndDate.GetHashCode();
                if (this._Namespace != null)
                    hashCode = hashCode * 59 + this._Namespace.GetHashCode();
                if (this.PriorDescriptorId != null)
                    hashCode = hashCode * 59 + this.PriorDescriptorId.GetHashCode();
                if (this.ShortDescription != null)
                    hashCode = hashCode * 59 + this.ShortDescription.GetHashCode();
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
            // CodeValue (string) maxLength
            if(this.CodeValue != null && this.CodeValue.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CodeValue, length must be less than 50.", new [] { "CodeValue" });
            }

            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 1024.", new [] { "Description" });
            }

            // _Namespace (string) maxLength
            if(this._Namespace != null && this._Namespace.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for _Namespace, length must be less than 255.", new [] { "_Namespace" });
            }

            // ShortDescription (string) maxLength
            if(this.ShortDescription != null && this.ShortDescription.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShortDescription, length must be less than 75.", new [] { "ShortDescription" });
            }

            yield break;
        }
    }

}