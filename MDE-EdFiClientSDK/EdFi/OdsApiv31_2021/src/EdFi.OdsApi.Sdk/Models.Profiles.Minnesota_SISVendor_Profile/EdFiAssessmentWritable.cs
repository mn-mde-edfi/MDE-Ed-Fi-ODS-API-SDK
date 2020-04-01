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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile
{
    /// <summary>
    /// EdFiAssessmentWritable
    /// </summary>
    [DataContract]
    public partial class EdFiAssessmentWritable :  IEquatable<EdFiAssessmentWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiAssessmentWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentWritable" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="AssessmentIdentifier">A unique number or alphanumeric code assigned to an assessment. (required).</param>
        /// <param name="_Namespace">Namespace for the Assessment. (required).</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiAssessmentWritable(string Id = default(string), string AssessmentIdentifier = default(string), string _Namespace = default(string), string Etag = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiAssessmentWritable and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "AssessmentIdentifier" is required (not null)
            if (AssessmentIdentifier == null)
            {
                throw new InvalidDataException("AssessmentIdentifier is a required property for EdFiAssessmentWritable and cannot be null");
            }
            else
            {
                this.AssessmentIdentifier = AssessmentIdentifier;
            }
            // to ensure "_Namespace" is required (not null)
            if (_Namespace == null)
            {
                throw new InvalidDataException("_Namespace is a required property for EdFiAssessmentWritable and cannot be null");
            }
            else
            {
                this._Namespace = _Namespace;
            }
            this.Etag = Etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to an assessment.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to an assessment.</value>
        [DataMember(Name="assessmentIdentifier", EmitDefaultValue=false)]
        public string AssessmentIdentifier { get; set; }

        /// <summary>
        /// Namespace for the Assessment.
        /// </summary>
        /// <value>Namespace for the Assessment.</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string _Namespace { get; set; }

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
            sb.Append("class EdFiAssessmentWritable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AssessmentIdentifier: ").Append(AssessmentIdentifier).Append("\n");
            sb.Append("  _Namespace: ").Append(_Namespace).Append("\n");
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
            return this.Equals(input as EdFiAssessmentWritable);
        }

        /// <summary>
        /// Returns true if EdFiAssessmentWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiAssessmentWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiAssessmentWritable input)
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
                    this.AssessmentIdentifier == input.AssessmentIdentifier ||
                    (this.AssessmentIdentifier != null &&
                    this.AssessmentIdentifier.Equals(input.AssessmentIdentifier))
                ) && 
                (
                    this._Namespace == input._Namespace ||
                    (this._Namespace != null &&
                    this._Namespace.Equals(input._Namespace))
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
                if (this.AssessmentIdentifier != null)
                    hashCode = hashCode * 59 + this.AssessmentIdentifier.GetHashCode();
                if (this._Namespace != null)
                    hashCode = hashCode * 59 + this._Namespace.GetHashCode();
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
            // AssessmentIdentifier (string) maxLength
            if(this.AssessmentIdentifier != null && this.AssessmentIdentifier.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentIdentifier, length must be less than 60.", new [] { "AssessmentIdentifier" });
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