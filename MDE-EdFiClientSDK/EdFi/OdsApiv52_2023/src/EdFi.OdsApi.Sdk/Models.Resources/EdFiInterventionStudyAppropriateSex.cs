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
    /// EdFiInterventionStudyAppropriateSex
    /// </summary>
    [DataContract]
    public partial class EdFiInterventionStudyAppropriateSex :  IEquatable<EdFiInterventionStudyAppropriateSex>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionStudyAppropriateSex" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiInterventionStudyAppropriateSex() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiInterventionStudyAppropriateSex" /> class.
        /// </summary>
        /// <param name="sexDescriptor">Sexes participating in this study. If omitted, considered generally applicable. (required).</param>
        public EdFiInterventionStudyAppropriateSex(string sexDescriptor = default(string))
        {
            // to ensure "sexDescriptor" is required (not null)
            if (sexDescriptor == null)
            {
                throw new InvalidDataException("sexDescriptor is a required property for EdFiInterventionStudyAppropriateSex and cannot be null");
            }
            else
            {
                this.SexDescriptor = sexDescriptor;
            }
        }
        
        /// <summary>
        /// Sexes participating in this study. If omitted, considered generally applicable.
        /// </summary>
        /// <value>Sexes participating in this study. If omitted, considered generally applicable.</value>
        [DataMember(Name="sexDescriptor", EmitDefaultValue=false)]
        public string SexDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiInterventionStudyAppropriateSex {\n");
            sb.Append("  SexDescriptor: ").Append(SexDescriptor).Append("\n");
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
            return this.Equals(input as EdFiInterventionStudyAppropriateSex);
        }

        /// <summary>
        /// Returns true if EdFiInterventionStudyAppropriateSex instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiInterventionStudyAppropriateSex to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiInterventionStudyAppropriateSex input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SexDescriptor == input.SexDescriptor ||
                    (this.SexDescriptor != null &&
                    this.SexDescriptor.Equals(input.SexDescriptor))
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
                if (this.SexDescriptor != null)
                    hashCode = hashCode * 59 + this.SexDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
