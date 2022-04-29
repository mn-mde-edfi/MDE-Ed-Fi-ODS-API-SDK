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
    /// EdFiEducationContentDerivativeSourceEducationContent
    /// </summary>
    [DataContract]
    public partial class EdFiEducationContentDerivativeSourceEducationContent :  IEquatable<EdFiEducationContentDerivativeSourceEducationContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationContentDerivativeSourceEducationContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiEducationContentDerivativeSourceEducationContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiEducationContentDerivativeSourceEducationContent" /> class.
        /// </summary>
        /// <param name="derivativeSourceEducationContentReference">derivativeSourceEducationContentReference (required).</param>
        public EdFiEducationContentDerivativeSourceEducationContent(EdFiEducationContentReference derivativeSourceEducationContentReference = default(EdFiEducationContentReference))
        {
            // to ensure "derivativeSourceEducationContentReference" is required (not null)
            if (derivativeSourceEducationContentReference == null)
            {
                throw new InvalidDataException("derivativeSourceEducationContentReference is a required property for EdFiEducationContentDerivativeSourceEducationContent and cannot be null");
            }
            else
            {
                this.DerivativeSourceEducationContentReference = derivativeSourceEducationContentReference;
            }
        }
        
        /// <summary>
        /// Gets or Sets DerivativeSourceEducationContentReference
        /// </summary>
        [DataMember(Name="derivativeSourceEducationContentReference", EmitDefaultValue=false)]
        public EdFiEducationContentReference DerivativeSourceEducationContentReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiEducationContentDerivativeSourceEducationContent {\n");
            sb.Append("  DerivativeSourceEducationContentReference: ").Append(DerivativeSourceEducationContentReference).Append("\n");
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
            return this.Equals(input as EdFiEducationContentDerivativeSourceEducationContent);
        }

        /// <summary>
        /// Returns true if EdFiEducationContentDerivativeSourceEducationContent instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiEducationContentDerivativeSourceEducationContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiEducationContentDerivativeSourceEducationContent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DerivativeSourceEducationContentReference == input.DerivativeSourceEducationContentReference ||
                    (this.DerivativeSourceEducationContentReference != null &&
                    this.DerivativeSourceEducationContentReference.Equals(input.DerivativeSourceEducationContentReference))
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
                if (this.DerivativeSourceEducationContentReference != null)
                    hashCode = hashCode * 59 + this.DerivativeSourceEducationContentReference.GetHashCode();
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
