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
    /// EdFiStaffTribalAffiliation
    /// </summary>
    [DataContract]
    public partial class EdFiStaffTribalAffiliation :  IEquatable<EdFiStaffTribalAffiliation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffTribalAffiliation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStaffTribalAffiliation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffTribalAffiliation" /> class.
        /// </summary>
        /// <param name="tribalAffiliationDescriptor">An American Indian tribe with which the staff member is affiliated. (required).</param>
        public EdFiStaffTribalAffiliation(string tribalAffiliationDescriptor = default(string))
        {
            // to ensure "tribalAffiliationDescriptor" is required (not null)
            if (tribalAffiliationDescriptor == null)
            {
                throw new InvalidDataException("tribalAffiliationDescriptor is a required property for EdFiStaffTribalAffiliation and cannot be null");
            }
            else
            {
                this.TribalAffiliationDescriptor = tribalAffiliationDescriptor;
            }
        }
        
        /// <summary>
        /// An American Indian tribe with which the staff member is affiliated.
        /// </summary>
        /// <value>An American Indian tribe with which the staff member is affiliated.</value>
        [DataMember(Name="tribalAffiliationDescriptor", EmitDefaultValue=false)]
        public string TribalAffiliationDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStaffTribalAffiliation {\n");
            sb.Append("  TribalAffiliationDescriptor: ").Append(TribalAffiliationDescriptor).Append("\n");
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
            return this.Equals(input as EdFiStaffTribalAffiliation);
        }

        /// <summary>
        /// Returns true if EdFiStaffTribalAffiliation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStaffTribalAffiliation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStaffTribalAffiliation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TribalAffiliationDescriptor == input.TribalAffiliationDescriptor ||
                    (this.TribalAffiliationDescriptor != null &&
                    this.TribalAffiliationDescriptor.Equals(input.TribalAffiliationDescriptor))
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
                if (this.TribalAffiliationDescriptor != null)
                    hashCode = hashCode * 59 + this.TribalAffiliationDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
