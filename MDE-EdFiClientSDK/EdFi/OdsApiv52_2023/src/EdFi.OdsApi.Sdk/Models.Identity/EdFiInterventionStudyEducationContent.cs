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
    /// EdFiInterventionStudyEducationContent
    /// </summary>
    [DataContract]
    public partial class EdFiInterventionStudyEducationContent :  IEquatable<EdFiInterventionStudyEducationContent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionStudyEducationContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiInterventionStudyEducationContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionStudyEducationContent" /> class.
        /// </summary>
        /// <param name="educationContentReference">educationContentReference (required).</param>
        public EdFiInterventionStudyEducationContent(EdFiEducationContentReference educationContentReference = default(EdFiEducationContentReference))
        {
            // to ensure "educationContentReference" is required (not null)
            if (educationContentReference == null)
            {
                throw new InvalidDataException("educationContentReference is a required property for EdFiInterventionStudyEducationContent and cannot be null");
            }
            else
            {
                this.EducationContentReference = educationContentReference;
            }
        }
        
        /// <summary>
        /// Gets or Sets EducationContentReference
        /// </summary>
        [DataMember(Name="educationContentReference", EmitDefaultValue=false)]
        public EdFiEducationContentReference EducationContentReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiInterventionStudyEducationContent {\n");
            sb.Append("  EducationContentReference: ").Append(EducationContentReference).Append("\n");
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
            return this.Equals(input as EdFiInterventionStudyEducationContent);
        }

        /// <summary>
        /// Returns true if EdFiInterventionStudyEducationContent instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiInterventionStudyEducationContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiInterventionStudyEducationContent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EducationContentReference == input.EducationContentReference ||
                    (this.EducationContentReference != null &&
                    this.EducationContentReference.Equals(input.EducationContentReference))
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
                if (this.EducationContentReference != null)
                    hashCode = hashCode * 59 + this.EducationContentReference.GetHashCode();
                return hashCode;
            }
        }
    }

}
