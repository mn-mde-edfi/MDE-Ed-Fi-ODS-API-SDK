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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile
{
    /// <summary>
    /// EdFiSectionCharacteristicReadable
    /// </summary>
    [DataContract]
    public partial class EdFiSectionCharacteristicReadable :  IEquatable<EdFiSectionCharacteristicReadable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSectionCharacteristicReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSectionCharacteristicReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSectionCharacteristicReadable" /> class.
        /// </summary>
        /// <param name="sectionCharacteristicDescriptor">Reflects important characteristics of the Section, such as whether or not attendance is taken and the Section is graded. (required).</param>
        public EdFiSectionCharacteristicReadable(string sectionCharacteristicDescriptor = default(string))
        {
            // to ensure "sectionCharacteristicDescriptor" is required (not null)
            if (sectionCharacteristicDescriptor == null)
            {
                throw new InvalidDataException("sectionCharacteristicDescriptor is a required property for EdFiSectionCharacteristicReadable and cannot be null");
            }
            else
            {
                this.SectionCharacteristicDescriptor = sectionCharacteristicDescriptor;
            }
        }
        
        /// <summary>
        /// Reflects important characteristics of the Section, such as whether or not attendance is taken and the Section is graded.
        /// </summary>
        /// <value>Reflects important characteristics of the Section, such as whether or not attendance is taken and the Section is graded.</value>
        [DataMember(Name="sectionCharacteristicDescriptor", EmitDefaultValue=false)]
        public string SectionCharacteristicDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiSectionCharacteristicReadable {\n");
            sb.Append("  SectionCharacteristicDescriptor: ").Append(SectionCharacteristicDescriptor).Append("\n");
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
            return this.Equals(input as EdFiSectionCharacteristicReadable);
        }

        /// <summary>
        /// Returns true if EdFiSectionCharacteristicReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSectionCharacteristicReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSectionCharacteristicReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SectionCharacteristicDescriptor == input.SectionCharacteristicDescriptor ||
                    (this.SectionCharacteristicDescriptor != null &&
                    this.SectionCharacteristicDescriptor.Equals(input.SectionCharacteristicDescriptor))
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
                if (this.SectionCharacteristicDescriptor != null)
                    hashCode = hashCode * 59 + this.SectionCharacteristicDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
