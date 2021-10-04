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
    /// EdFiInterventionPrescriptionLearningResourceMetadataURI
    /// </summary>
    [DataContract]
    public partial class EdFiInterventionPrescriptionLearningResourceMetadataURI :  IEquatable<EdFiInterventionPrescriptionLearningResourceMetadataURI>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionPrescriptionLearningResourceMetadataURI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiInterventionPrescriptionLearningResourceMetadataURI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionPrescriptionLearningResourceMetadataURI" /> class.
        /// </summary>
        /// <param name="learningResourceMetadataURI">The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item. (required).</param>
        public EdFiInterventionPrescriptionLearningResourceMetadataURI(string learningResourceMetadataURI = default(string))
        {
            // to ensure "learningResourceMetadataURI" is required (not null)
            if (learningResourceMetadataURI == null)
            {
                throw new InvalidDataException("learningResourceMetadataURI is a required property for EdFiInterventionPrescriptionLearningResourceMetadataURI and cannot be null");
            }
            else
            {
                this.LearningResourceMetadataURI = learningResourceMetadataURI;
            }
        }
        
        /// <summary>
        /// The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item.
        /// </summary>
        /// <value>The URI (typical a URL) pointing to the metadata entry in a LRMI metadata repository, which describes this content item.</value>
        [DataMember(Name="learningResourceMetadataURI", EmitDefaultValue=false)]
        public string LearningResourceMetadataURI { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiInterventionPrescriptionLearningResourceMetadataURI {\n");
            sb.Append("  LearningResourceMetadataURI: ").Append(LearningResourceMetadataURI).Append("\n");
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
            return this.Equals(input as EdFiInterventionPrescriptionLearningResourceMetadataURI);
        }

        /// <summary>
        /// Returns true if EdFiInterventionPrescriptionLearningResourceMetadataURI instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiInterventionPrescriptionLearningResourceMetadataURI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiInterventionPrescriptionLearningResourceMetadataURI input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LearningResourceMetadataURI == input.LearningResourceMetadataURI ||
                    (this.LearningResourceMetadataURI != null &&
                    this.LearningResourceMetadataURI.Equals(input.LearningResourceMetadataURI))
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
                if (this.LearningResourceMetadataURI != null)
                    hashCode = hashCode * 59 + this.LearningResourceMetadataURI.GetHashCode();
                return hashCode;
            }
        }
    }

}
