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
    /// EdFiSurveyResponseReference
    /// </summary>
    [DataContract]
    public partial class EdFiSurveyResponseReference :  IEquatable<EdFiSurveyResponseReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSurveyResponseReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSurveyResponseReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSurveyResponseReference" /> class.
        /// </summary>
        /// <param name="_namespace">Namespace for the Survey. (required).</param>
        /// <param name="surveyIdentifier">The unique survey identifier from the survey tool. (required).</param>
        /// <param name="surveyResponseIdentifier">The identifier of the survey typically from the survey application. (required).</param>
        /// <param name="link">link.</param>
        public EdFiSurveyResponseReference(string _namespace = default(string), string surveyIdentifier = default(string), string surveyResponseIdentifier = default(string), Link link = default(Link))
        {
            // to ensure "_namespace" is required (not null)
            if (_namespace == null)
            {
                throw new InvalidDataException("_namespace is a required property for EdFiSurveyResponseReference and cannot be null");
            }
            else
            {
                this.Namespace = _namespace;
            }
            // to ensure "surveyIdentifier" is required (not null)
            if (surveyIdentifier == null)
            {
                throw new InvalidDataException("surveyIdentifier is a required property for EdFiSurveyResponseReference and cannot be null");
            }
            else
            {
                this.SurveyIdentifier = surveyIdentifier;
            }
            // to ensure "surveyResponseIdentifier" is required (not null)
            if (surveyResponseIdentifier == null)
            {
                throw new InvalidDataException("surveyResponseIdentifier is a required property for EdFiSurveyResponseReference and cannot be null");
            }
            else
            {
                this.SurveyResponseIdentifier = surveyResponseIdentifier;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// Namespace for the Survey.
        /// </summary>
        /// <value>Namespace for the Survey.</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The unique survey identifier from the survey tool.
        /// </summary>
        /// <value>The unique survey identifier from the survey tool.</value>
        [DataMember(Name="surveyIdentifier", EmitDefaultValue=false)]
        public string SurveyIdentifier { get; set; }

        /// <summary>
        /// The identifier of the survey typically from the survey application.
        /// </summary>
        /// <value>The identifier of the survey typically from the survey application.</value>
        [DataMember(Name="surveyResponseIdentifier", EmitDefaultValue=false)]
        public string SurveyResponseIdentifier { get; set; }

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
            sb.Append("class EdFiSurveyResponseReference {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  SurveyIdentifier: ").Append(SurveyIdentifier).Append("\n");
            sb.Append("  SurveyResponseIdentifier: ").Append(SurveyResponseIdentifier).Append("\n");
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
            return this.Equals(input as EdFiSurveyResponseReference);
        }

        /// <summary>
        /// Returns true if EdFiSurveyResponseReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSurveyResponseReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSurveyResponseReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.SurveyIdentifier == input.SurveyIdentifier ||
                    (this.SurveyIdentifier != null &&
                    this.SurveyIdentifier.Equals(input.SurveyIdentifier))
                ) && 
                (
                    this.SurveyResponseIdentifier == input.SurveyResponseIdentifier ||
                    (this.SurveyResponseIdentifier != null &&
                    this.SurveyResponseIdentifier.Equals(input.SurveyResponseIdentifier))
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
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.SurveyIdentifier != null)
                    hashCode = hashCode * 59 + this.SurveyIdentifier.GetHashCode();
                if (this.SurveyResponseIdentifier != null)
                    hashCode = hashCode * 59 + this.SurveyResponseIdentifier.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}
