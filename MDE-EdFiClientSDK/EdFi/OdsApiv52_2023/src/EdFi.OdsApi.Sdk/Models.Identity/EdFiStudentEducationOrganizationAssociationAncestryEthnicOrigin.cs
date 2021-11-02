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
    /// EdFiStudentEducationOrganizationAssociationAncestryEthnicOrigin
    /// </summary>
    [DataContract]
    public partial class EdFiStudentEducationOrganizationAssociationAncestryEthnicOrigin :  IEquatable<EdFiStudentEducationOrganizationAssociationAncestryEthnicOrigin>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationAncestryEthnicOrigin" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentEducationOrganizationAssociationAncestryEthnicOrigin() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationAncestryEthnicOrigin" /> class.
        /// </summary>
        /// <param name="ancestryEthnicOriginDescriptor">The original peoples or cultures with which the individual identifies. (required).</param>
        public EdFiStudentEducationOrganizationAssociationAncestryEthnicOrigin(string ancestryEthnicOriginDescriptor = default(string))
        {
            // to ensure "ancestryEthnicOriginDescriptor" is required (not null)
            if (ancestryEthnicOriginDescriptor == null)
            {
                throw new InvalidDataException("ancestryEthnicOriginDescriptor is a required property for EdFiStudentEducationOrganizationAssociationAncestryEthnicOrigin and cannot be null");
            }
            else
            {
                this.AncestryEthnicOriginDescriptor = ancestryEthnicOriginDescriptor;
            }
        }
        
        /// <summary>
        /// The original peoples or cultures with which the individual identifies.
        /// </summary>
        /// <value>The original peoples or cultures with which the individual identifies.</value>
        [DataMember(Name="ancestryEthnicOriginDescriptor", EmitDefaultValue=false)]
        public string AncestryEthnicOriginDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentEducationOrganizationAssociationAncestryEthnicOrigin {\n");
            sb.Append("  AncestryEthnicOriginDescriptor: ").Append(AncestryEthnicOriginDescriptor).Append("\n");
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
            return this.Equals(input as EdFiStudentEducationOrganizationAssociationAncestryEthnicOrigin);
        }

        /// <summary>
        /// Returns true if EdFiStudentEducationOrganizationAssociationAncestryEthnicOrigin instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentEducationOrganizationAssociationAncestryEthnicOrigin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentEducationOrganizationAssociationAncestryEthnicOrigin input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AncestryEthnicOriginDescriptor == input.AncestryEthnicOriginDescriptor ||
                    (this.AncestryEthnicOriginDescriptor != null &&
                    this.AncestryEthnicOriginDescriptor.Equals(input.AncestryEthnicOriginDescriptor))
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
                if (this.AncestryEthnicOriginDescriptor != null)
                    hashCode = hashCode * 59 + this.AncestryEthnicOriginDescriptor.GetHashCode();
                return hashCode;
            }
        }
    }

}
