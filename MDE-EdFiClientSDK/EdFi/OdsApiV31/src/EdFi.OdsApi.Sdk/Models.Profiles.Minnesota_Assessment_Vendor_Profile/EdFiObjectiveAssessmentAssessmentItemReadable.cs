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
    /// EdFiObjectiveAssessmentAssessmentItemReadable
    /// </summary>
    [DataContract]
    public partial class EdFiObjectiveAssessmentAssessmentItemReadable :  IEquatable<EdFiObjectiveAssessmentAssessmentItemReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiObjectiveAssessmentAssessmentItemReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiObjectiveAssessmentAssessmentItemReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiObjectiveAssessmentAssessmentItemReadable" /> class.
        /// </summary>
        /// <param name="AssessmentItemReference">AssessmentItemReference (required).</param>
        public EdFiObjectiveAssessmentAssessmentItemReadable(EdFiAssessmentItemReference AssessmentItemReference = default(EdFiAssessmentItemReference))
        {
            // to ensure "AssessmentItemReference" is required (not null)
            if (AssessmentItemReference == null)
            {
                throw new InvalidDataException("AssessmentItemReference is a required property for EdFiObjectiveAssessmentAssessmentItemReadable and cannot be null");
            }
            else
            {
                this.AssessmentItemReference = AssessmentItemReference;
            }
        }
        
        /// <summary>
        /// Gets or Sets AssessmentItemReference
        /// </summary>
        [DataMember(Name="assessmentItemReference", EmitDefaultValue=false)]
        public EdFiAssessmentItemReference AssessmentItemReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiObjectiveAssessmentAssessmentItemReadable {\n");
            sb.Append("  AssessmentItemReference: ").Append(AssessmentItemReference).Append("\n");
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
            return this.Equals(input as EdFiObjectiveAssessmentAssessmentItemReadable);
        }

        /// <summary>
        /// Returns true if EdFiObjectiveAssessmentAssessmentItemReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiObjectiveAssessmentAssessmentItemReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiObjectiveAssessmentAssessmentItemReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssessmentItemReference == input.AssessmentItemReference ||
                    (this.AssessmentItemReference != null &&
                    this.AssessmentItemReference.Equals(input.AssessmentItemReference))
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
                if (this.AssessmentItemReference != null)
                    hashCode = hashCode * 59 + this.AssessmentItemReference.GetHashCode();
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
            yield break;
        }
    }

}
