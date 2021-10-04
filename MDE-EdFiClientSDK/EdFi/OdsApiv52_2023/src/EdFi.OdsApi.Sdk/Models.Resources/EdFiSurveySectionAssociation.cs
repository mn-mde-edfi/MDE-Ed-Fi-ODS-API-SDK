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
    /// EdFiSurveySectionAssociation
    /// </summary>
    [DataContract]
    public partial class EdFiSurveySectionAssociation :  IEquatable<EdFiSurveySectionAssociation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSurveySectionAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSurveySectionAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSurveySectionAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="sectionReference">sectionReference (required).</param>
        /// <param name="surveyReference">surveyReference (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiSurveySectionAssociation(string id = default(string), EdFiSectionReference sectionReference = default(EdFiSectionReference), EdFiSurveyReference surveyReference = default(EdFiSurveyReference), string etag = default(string))
        {
            // to ensure "sectionReference" is required (not null)
            if (sectionReference == null)
            {
                throw new InvalidDataException("sectionReference is a required property for EdFiSurveySectionAssociation and cannot be null");
            }
            else
            {
                this.SectionReference = sectionReference;
            }
            // to ensure "surveyReference" is required (not null)
            if (surveyReference == null)
            {
                throw new InvalidDataException("surveyReference is a required property for EdFiSurveySectionAssociation and cannot be null");
            }
            else
            {
                this.SurveyReference = surveyReference;
            }
            this.Id = id;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets SectionReference
        /// </summary>
        [DataMember(Name="sectionReference", EmitDefaultValue=false)]
        public EdFiSectionReference SectionReference { get; set; }

        /// <summary>
        /// Gets or Sets SurveyReference
        /// </summary>
        [DataMember(Name="surveyReference", EmitDefaultValue=false)]
        public EdFiSurveyReference SurveyReference { get; set; }

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
            sb.Append("class EdFiSurveySectionAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SectionReference: ").Append(SectionReference).Append("\n");
            sb.Append("  SurveyReference: ").Append(SurveyReference).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiSurveySectionAssociation);
        }

        /// <summary>
        /// Returns true if EdFiSurveySectionAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSurveySectionAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSurveySectionAssociation input)
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
                    this.SectionReference == input.SectionReference ||
                    (this.SectionReference != null &&
                    this.SectionReference.Equals(input.SectionReference))
                ) && 
                (
                    this.SurveyReference == input.SurveyReference ||
                    (this.SurveyReference != null &&
                    this.SurveyReference.Equals(input.SurveyReference))
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
                if (this.SectionReference != null)
                    hashCode = hashCode * 59 + this.SectionReference.GetHashCode();
                if (this.SurveyReference != null)
                    hashCode = hashCode * 59 + this.SurveyReference.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
