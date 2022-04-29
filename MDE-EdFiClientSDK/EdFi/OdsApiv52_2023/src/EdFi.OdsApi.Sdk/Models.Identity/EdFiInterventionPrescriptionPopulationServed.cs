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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = EdFi.OdsApi.Sdk.Client.SwaggerDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Identity
{
    /// <summary>
    /// EdFiInterventionPrescriptionPopulationServed
    /// </summary>
    [DataContract]
    public partial class EdFiInterventionPrescriptionPopulationServed :  IEquatable<EdFiInterventionPrescriptionPopulationServed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionPrescriptionPopulationServed" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiInterventionPrescriptionPopulationServed() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionPrescriptionPopulationServed" /> class.
        /// </summary>
        /// <param name="populationServedDescriptor">A subset of students that are the focus of the InterventionPrescription. (required).</param>
        public EdFiInterventionPrescriptionPopulationServed(string populationServedDescriptor = default(string))
        {
            // to ensure "populationServedDescriptor" is required (not null)
            if (populationServedDescriptor == null)
            {
                throw new InvalidDataException("populationServedDescriptor is a required property for EdFiInterventionPrescriptionPopulationServed and cannot be null");
            }
            else
            {
                this.PopulationServedDescriptor = populationServedDescriptor;
            }
        }
        
        /// <summary>
        /// A subset of students that are the focus of the InterventionPrescription.
        /// </summary>
        /// <value>A subset of students that are the focus of the InterventionPrescription.</value>
        [DataMember(Name="populationServedDescriptor", EmitDefaultValue=false)]
        public string PopulationServedDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiInterventionPrescriptionPopulationServed {\n");
            sb.Append("  PopulationServedDescriptor: ").Append(PopulationServedDescriptor).Append("\n");
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
            return this.Equals(input as EdFiInterventionPrescriptionPopulationServed);
        }

        /// <summary>
        /// Returns true if EdFiInterventionPrescriptionPopulationServed instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiInterventionPrescriptionPopulationServed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiInterventionPrescriptionPopulationServed input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PopulationServedDescriptor == input.PopulationServedDescriptor ||
                    (this.PopulationServedDescriptor != null &&
                    this.PopulationServedDescriptor.Equals(input.PopulationServedDescriptor))
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
                if (this.PopulationServedDescriptor != null)
                    hashCode = hashCode * 59 + this.PopulationServedDescriptor.GetHashCode();
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
            // PopulationServedDescriptor (string) maxLength
            if(this.PopulationServedDescriptor != null && this.PopulationServedDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PopulationServedDescriptor, length must be less than 306.", new [] { "PopulationServedDescriptor" });
            }

            yield break;
        }
    }

}
