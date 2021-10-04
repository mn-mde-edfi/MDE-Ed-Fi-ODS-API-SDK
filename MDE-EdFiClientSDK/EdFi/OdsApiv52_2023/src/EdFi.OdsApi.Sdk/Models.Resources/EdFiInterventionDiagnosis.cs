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
    /// EdFiInterventionDiagnosis
    /// </summary>
    [DataContract]
    public partial class EdFiInterventionDiagnosis :  IEquatable<EdFiInterventionDiagnosis>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionDiagnosis" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiInterventionDiagnosis() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionDiagnosis" /> class.
        /// </summary>
        /// <param name="diagnosisDescriptor">Targeted purpose of the Intervention (e.g., attendance issue, dropout risk). (required).</param>
        public EdFiInterventionDiagnosis(string diagnosisDescriptor = default(string))
        {
            // to ensure "diagnosisDescriptor" is required (not null)
            if (diagnosisDescriptor == null)
            {
                throw new InvalidDataException("diagnosisDescriptor is a required property for EdFiInterventionDiagnosis and cannot be null");
            }
            else
            {
                this.DiagnosisDescriptor = diagnosisDescriptor;
            }
        }
        
        /// <summary>
        /// Targeted purpose of the Intervention (e.g., attendance issue, dropout risk).
        /// </summary>
        /// <value>Targeted purpose of the Intervention (e.g., attendance issue, dropout risk).</value>
        [DataMember(Name="diagnosisDescriptor", EmitDefaultValue=false)]
        public string DiagnosisDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiInterventionDiagnosis {\n");
            sb.Append("  DiagnosisDescriptor: ").Append(DiagnosisDescriptor).Append("\n");
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
            return this.Equals(input as EdFiInterventionDiagnosis);
        }

        /// <summary>
        /// Returns true if EdFiInterventionDiagnosis instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiInterventionDiagnosis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiInterventionDiagnosis input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiagnosisDescriptor == input.DiagnosisDescriptor ||
                    (this.DiagnosisDescriptor != null &&
                    this.DiagnosisDescriptor.Equals(input.DiagnosisDescriptor))
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
                if (this.DiagnosisDescriptor != null)
                    hashCode = hashCode * 59 + this.DiagnosisDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
