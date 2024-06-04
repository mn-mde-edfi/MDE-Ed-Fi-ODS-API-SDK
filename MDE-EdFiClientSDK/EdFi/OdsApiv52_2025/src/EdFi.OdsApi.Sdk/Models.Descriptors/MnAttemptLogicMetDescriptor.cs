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

namespace EdFi.OdsApi.Sdk.Models.Descriptors
{
    /// <summary>
    /// MnAttemptLogicMetDescriptor
    /// </summary>
    [DataContract(Name = "mn_attemptLogicMetDescriptor")]
    public partial class MnAttemptLogicMetDescriptor : IEquatable<MnAttemptLogicMetDescriptor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnAttemptLogicMetDescriptor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnAttemptLogicMetDescriptor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnAttemptLogicMetDescriptor" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="attemptLogicMetDescriptorId">A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table..</param>
        /// <param name="codeValue">A code or abbreviation that is used to refer to the descriptor. (required).</param>
        /// <param name="description">The description of the descriptor..</param>
        /// <param name="effectiveBeginDate">The beginning date of the period when the descriptor is in effect. If omitted, the default is immediate effectiveness..</param>
        /// <param name="effectiveEndDate">The end date of the period when the descriptor is in effect..</param>
        /// <param name="_namespace">A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary. (required).</param>
        /// <param name="priorDescriptorId">A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table..</param>
        /// <param name="shortDescription">A shortened description for the descriptor. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public MnAttemptLogicMetDescriptor(string id = default(string), int attemptLogicMetDescriptorId = default(int), string codeValue = default(string), string description = default(string), DateTime effectiveBeginDate = default(DateTime), DateTime effectiveEndDate = default(DateTime), string _namespace = default(string), int priorDescriptorId = default(int), string shortDescription = default(string), string etag = default(string))
        {
            // to ensure "codeValue" is required (not null)
            if (codeValue == null)
            {
                throw new ArgumentNullException("codeValue is a required property for MnAttemptLogicMetDescriptor and cannot be null");
            }
            this.CodeValue = codeValue;
            // to ensure "_namespace" is required (not null)
            if (_namespace == null)
            {
                throw new ArgumentNullException("_namespace is a required property for MnAttemptLogicMetDescriptor and cannot be null");
            }
            this.Namespace = _namespace;
            // to ensure "shortDescription" is required (not null)
            if (shortDescription == null)
            {
                throw new ArgumentNullException("shortDescription is a required property for MnAttemptLogicMetDescriptor and cannot be null");
            }
            this.ShortDescription = shortDescription;
            this.Id = id;
            this.AttemptLogicMetDescriptorId = attemptLogicMetDescriptorId;
            this.Description = description;
            this.EffectiveBeginDate = effectiveBeginDate;
            this.EffectiveEndDate = effectiveEndDate;
            this.PriorDescriptorId = priorDescriptorId;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        /// <value>A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.</value>
        [DataMember(Name = "attemptLogicMetDescriptorId", EmitDefaultValue = false)]
        public int AttemptLogicMetDescriptorId { get; set; }

        /// <summary>
        /// A code or abbreviation that is used to refer to the descriptor.
        /// </summary>
        /// <value>A code or abbreviation that is used to refer to the descriptor.</value>
        [DataMember(Name = "codeValue", IsRequired = true, EmitDefaultValue = false)]
        public string CodeValue { get; set; }

        /// <summary>
        /// The description of the descriptor.
        /// </summary>
        /// <value>The description of the descriptor.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The beginning date of the period when the descriptor is in effect. If omitted, the default is immediate effectiveness.
        /// </summary>
        /// <value>The beginning date of the period when the descriptor is in effect. If omitted, the default is immediate effectiveness.</value>
        [DataMember(Name = "effectiveBeginDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EffectiveBeginDate { get; set; }

        /// <summary>
        /// The end date of the period when the descriptor is in effect.
        /// </summary>
        /// <value>The end date of the period when the descriptor is in effect.</value>
        [DataMember(Name = "effectiveEndDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EffectiveEndDate { get; set; }

        /// <summary>
        /// A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary.
        /// </summary>
        /// <value>A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary.</value>
        [DataMember(Name = "namespace", IsRequired = true, EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        /// <value>A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.</value>
        [DataMember(Name = "priorDescriptorId", EmitDefaultValue = false)]
        public int PriorDescriptorId { get; set; }

        /// <summary>
        /// A shortened description for the descriptor.
        /// </summary>
        /// <value>A shortened description for the descriptor.</value>
        [DataMember(Name = "shortDescription", IsRequired = true, EmitDefaultValue = false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MnAttemptLogicMetDescriptor {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AttemptLogicMetDescriptorId: ").Append(AttemptLogicMetDescriptorId).Append("\n");
            sb.Append("  CodeValue: ").Append(CodeValue).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EffectiveBeginDate: ").Append(EffectiveBeginDate).Append("\n");
            sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
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
            return this.Equals(input as MnAttemptLogicMetDescriptor);
        }

        /// <summary>
        /// Returns true if MnAttemptLogicMetDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of MnAttemptLogicMetDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnAttemptLogicMetDescriptor input)
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
                    this.AttemptLogicMetDescriptorId == input.AttemptLogicMetDescriptorId ||
                    this.AttemptLogicMetDescriptorId.Equals(input.AttemptLogicMetDescriptorId)
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
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.PriorDescriptorId == input.PriorDescriptorId ||
                    this.PriorDescriptorId.Equals(input.PriorDescriptorId)
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
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AttemptLogicMetDescriptorId.GetHashCode();
                if (this.CodeValue != null)
                {
                    hashCode = (hashCode * 59) + this.CodeValue.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.EffectiveBeginDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveBeginDate.GetHashCode();
                }
                if (this.EffectiveEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveEndDate.GetHashCode();
                }
                if (this.Namespace != null)
                {
                    hashCode = (hashCode * 59) + this.Namespace.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PriorDescriptorId.GetHashCode();
                if (this.ShortDescription != null)
                {
                    hashCode = (hashCode * 59) + this.ShortDescription.GetHashCode();
                }
                if (this.Etag != null)
                {
                    hashCode = (hashCode * 59) + this.Etag.GetHashCode();
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
            // CodeValue (string) maxLength
            if (this.CodeValue != null && this.CodeValue.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CodeValue, length must be less than 50.", new [] { "CodeValue" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 1024.", new [] { "Description" });
            }

            // Namespace (string) maxLength
            if (this.Namespace != null && this.Namespace.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Namespace, length must be less than 255.", new [] { "Namespace" });
            }

            // ShortDescription (string) maxLength
            if (this.ShortDescription != null && this.ShortDescription.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShortDescription, length must be less than 75.", new [] { "ShortDescription" });
            }

            yield break;
        }
    }

}
