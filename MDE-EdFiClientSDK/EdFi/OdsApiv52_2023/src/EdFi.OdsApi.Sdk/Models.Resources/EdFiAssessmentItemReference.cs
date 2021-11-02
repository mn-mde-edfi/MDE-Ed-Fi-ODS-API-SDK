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

namespace EdFi.OdsApi.Sdk.Models.Resources
{
    /// <summary>
    /// EdFiAssessmentItemReference
    /// </summary>
    [DataContract]
    public partial class EdFiAssessmentItemReference :  IEquatable<EdFiAssessmentItemReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentItemReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiAssessmentItemReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentItemReference" /> class.
        /// </summary>
        /// <param name="assessmentIdentifier">A unique number or alphanumeric code assigned to an assessment. (required).</param>
        /// <param name="identificationCode">A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, state, or other agency or entity. (required).</param>
        /// <param name="_namespace">Namespace for the Assessment. (required).</param>
        /// <param name="link">link.</param>
        public EdFiAssessmentItemReference(string assessmentIdentifier = default(string), string identificationCode = default(string), string _namespace = default(string), Link link = default(Link))
        {
            // to ensure "assessmentIdentifier" is required (not null)
            if (assessmentIdentifier == null)
            {
                throw new InvalidDataException("assessmentIdentifier is a required property for EdFiAssessmentItemReference and cannot be null");
            }
            else
            {
                this.AssessmentIdentifier = assessmentIdentifier;
            }
            // to ensure "identificationCode" is required (not null)
            if (identificationCode == null)
            {
                throw new InvalidDataException("identificationCode is a required property for EdFiAssessmentItemReference and cannot be null");
            }
            else
            {
                this.IdentificationCode = identificationCode;
            }
            // to ensure "_namespace" is required (not null)
            if (_namespace == null)
            {
                throw new InvalidDataException("_namespace is a required property for EdFiAssessmentItemReference and cannot be null");
            }
            else
            {
                this.Namespace = _namespace;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// A unique number or alphanumeric code assigned to an assessment.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to an assessment.</value>
        [DataMember(Name="assessmentIdentifier", EmitDefaultValue=false)]
        public string AssessmentIdentifier { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, state, or other agency or entity.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, state, or other agency or entity.</value>
        [DataMember(Name="identificationCode", EmitDefaultValue=false)]
        public string IdentificationCode { get; set; }

        /// <summary>
        /// Namespace for the Assessment.
        /// </summary>
        /// <value>Namespace for the Assessment.</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }

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
            sb.Append("class EdFiAssessmentItemReference {\n");
            sb.Append("  AssessmentIdentifier: ").Append(AssessmentIdentifier).Append("\n");
            sb.Append("  IdentificationCode: ").Append(IdentificationCode).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as EdFiAssessmentItemReference);
        }

        /// <summary>
        /// Returns true if EdFiAssessmentItemReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiAssessmentItemReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiAssessmentItemReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssessmentIdentifier == input.AssessmentIdentifier ||
                    (this.AssessmentIdentifier != null &&
                    this.AssessmentIdentifier.Equals(input.AssessmentIdentifier))
                ) && 
                (
                    this.IdentificationCode == input.IdentificationCode ||
                    (this.IdentificationCode != null &&
                    this.IdentificationCode.Equals(input.IdentificationCode))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
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
                if (this.AssessmentIdentifier != null)
                    hashCode = hashCode * 59 + this.AssessmentIdentifier.GetHashCode();
                if (this.IdentificationCode != null)
                    hashCode = hashCode * 59 + this.IdentificationCode.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}
