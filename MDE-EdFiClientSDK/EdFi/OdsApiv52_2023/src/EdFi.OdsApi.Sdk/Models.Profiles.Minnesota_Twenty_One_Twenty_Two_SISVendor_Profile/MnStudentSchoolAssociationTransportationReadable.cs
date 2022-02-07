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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_One_Twenty_Two_SISVendor_Profile
{
    /// <summary>
    /// MnStudentSchoolAssociationTransportationReadable
    /// </summary>
    [DataContract]
    public partial class MnStudentSchoolAssociationTransportationReadable :  IEquatable<MnStudentSchoolAssociationTransportationReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentSchoolAssociationTransportationReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentSchoolAssociationTransportationReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentSchoolAssociationTransportationReadable" /> class.
        /// </summary>
        /// <param name="transportationCategoryDescriptor">Student&#39;s to and from Transportation Category for the regular school term. (required).</param>
        /// <param name="transportingLocalEducationAgencyReference">transportingLocalEducationAgencyReference.</param>
        public MnStudentSchoolAssociationTransportationReadable(string transportationCategoryDescriptor = default(string), EdFiLocalEducationAgencyReference transportingLocalEducationAgencyReference = default(EdFiLocalEducationAgencyReference))
        {
            // to ensure "transportationCategoryDescriptor" is required (not null)
            if (transportationCategoryDescriptor == null)
            {
                throw new InvalidDataException("transportationCategoryDescriptor is a required property for MnStudentSchoolAssociationTransportationReadable and cannot be null");
            }
            else
            {
                this.TransportationCategoryDescriptor = transportationCategoryDescriptor;
            }
            this.TransportingLocalEducationAgencyReference = transportingLocalEducationAgencyReference;
        }
        
        /// <summary>
        /// Student&#39;s to and from Transportation Category for the regular school term.
        /// </summary>
        /// <value>Student&#39;s to and from Transportation Category for the regular school term.</value>
        [DataMember(Name="transportationCategoryDescriptor", EmitDefaultValue=false)]
        public string TransportationCategoryDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets TransportingLocalEducationAgencyReference
        /// </summary>
        [DataMember(Name="transportingLocalEducationAgencyReference", EmitDefaultValue=false)]
        public EdFiLocalEducationAgencyReference TransportingLocalEducationAgencyReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnStudentSchoolAssociationTransportationReadable {\n");
            sb.Append("  TransportationCategoryDescriptor: ").Append(TransportationCategoryDescriptor).Append("\n");
            sb.Append("  TransportingLocalEducationAgencyReference: ").Append(TransportingLocalEducationAgencyReference).Append("\n");
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
            return this.Equals(input as MnStudentSchoolAssociationTransportationReadable);
        }

        /// <summary>
        /// Returns true if MnStudentSchoolAssociationTransportationReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentSchoolAssociationTransportationReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentSchoolAssociationTransportationReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransportationCategoryDescriptor == input.TransportationCategoryDescriptor ||
                    (this.TransportationCategoryDescriptor != null &&
                    this.TransportationCategoryDescriptor.Equals(input.TransportationCategoryDescriptor))
                ) && 
                (
                    this.TransportingLocalEducationAgencyReference == input.TransportingLocalEducationAgencyReference ||
                    (this.TransportingLocalEducationAgencyReference != null &&
                    this.TransportingLocalEducationAgencyReference.Equals(input.TransportingLocalEducationAgencyReference))
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
                if (this.TransportationCategoryDescriptor != null)
                    hashCode = hashCode * 59 + this.TransportationCategoryDescriptor.GetHashCode();
                if (this.TransportingLocalEducationAgencyReference != null)
                    hashCode = hashCode * 59 + this.TransportingLocalEducationAgencyReference.GetHashCode();
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
            // TransportationCategoryDescriptor (string) maxLength
            if(this.TransportationCategoryDescriptor != null && this.TransportationCategoryDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransportationCategoryDescriptor, length must be less than 306.", new [] { "TransportationCategoryDescriptor" });
            }

            yield break;
        }
    }

}
