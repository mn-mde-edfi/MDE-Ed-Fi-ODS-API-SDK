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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Assessment_Vendor_Profile
{
    /// <summary>
    /// MnLearningObjectiveReference
    /// </summary>
    [DataContract]
    public partial class MnLearningObjectiveReference :  IEquatable<MnLearningObjectiveReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnLearningObjectiveReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnLearningObjectiveReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnLearningObjectiveReference" /> class.
        /// </summary>
        /// <param name="LearningObjectiveId">The identifier for the specific learning objective in the context of a standard (e.g., 111.15.3.1.A). (required).</param>
        /// <param name="_Namespace">Namespace for the LearningObjective. (required).</param>
        /// <param name="Link">Link.</param>
        public MnLearningObjectiveReference(string LearningObjectiveId = default(string), string _Namespace = default(string), Link Link = default(Link))
        {
            // to ensure "LearningObjectiveId" is required (not null)
            if (LearningObjectiveId == null)
            {
                throw new InvalidDataException("LearningObjectiveId is a required property for MnLearningObjectiveReference and cannot be null");
            }
            else
            {
                this.LearningObjectiveId = LearningObjectiveId;
            }
            // to ensure "_Namespace" is required (not null)
            if (_Namespace == null)
            {
                throw new InvalidDataException("_Namespace is a required property for MnLearningObjectiveReference and cannot be null");
            }
            else
            {
                this._Namespace = _Namespace;
            }
            this.Link = Link;
        }
        
        /// <summary>
        /// The identifier for the specific learning objective in the context of a standard (e.g., 111.15.3.1.A).
        /// </summary>
        /// <value>The identifier for the specific learning objective in the context of a standard (e.g., 111.15.3.1.A).</value>
        [DataMember(Name="learningObjectiveId", EmitDefaultValue=false)]
        public string LearningObjectiveId { get; set; }

        /// <summary>
        /// Namespace for the LearningObjective.
        /// </summary>
        /// <value>Namespace for the LearningObjective.</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string _Namespace { get; set; }

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
            sb.Append("class MnLearningObjectiveReference {\n");
            sb.Append("  LearningObjectiveId: ").Append(LearningObjectiveId).Append("\n");
            sb.Append("  _Namespace: ").Append(_Namespace).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as MnLearningObjectiveReference);
        }

        /// <summary>
        /// Returns true if MnLearningObjectiveReference instances are equal
        /// </summary>
        /// <param name="input">Instance of MnLearningObjectiveReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnLearningObjectiveReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LearningObjectiveId == input.LearningObjectiveId ||
                    (this.LearningObjectiveId != null &&
                    this.LearningObjectiveId.Equals(input.LearningObjectiveId))
                ) && 
                (
                    this._Namespace == input._Namespace ||
                    (this._Namespace != null &&
                    this._Namespace.Equals(input._Namespace))
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
                if (this.LearningObjectiveId != null)
                    hashCode = hashCode * 59 + this.LearningObjectiveId.GetHashCode();
                if (this._Namespace != null)
                    hashCode = hashCode * 59 + this._Namespace.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
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
            // LearningObjectiveId (string) maxLength
            if(this.LearningObjectiveId != null && this.LearningObjectiveId.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LearningObjectiveId, length must be less than 60.", new [] { "LearningObjectiveId" });
            }

            // _Namespace (string) maxLength
            if(this._Namespace != null && this._Namespace.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for _Namespace, length must be less than 255.", new [] { "_Namespace" });
            }

            yield break;
        }
    }

}
