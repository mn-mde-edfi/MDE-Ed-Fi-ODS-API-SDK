/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdFi.OdsApi.Sdk.Client.OpenAPIDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile
{
    /// <summary>
    /// MnStudentEducationOrganizationAssociationOptOutIndicatorsReadable
    /// </summary>
    [DataContract(Name = "mn_studentEducationOrganizationAssociationOptOutIndicators_readable")]
    public partial class MnStudentEducationOrganizationAssociationOptOutIndicatorsReadable : IEquatable<MnStudentEducationOrganizationAssociationOptOutIndicatorsReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentEducationOrganizationAssociationOptOutIndicatorsReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentEducationOrganizationAssociationOptOutIndicatorsReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentEducationOrganizationAssociationOptOutIndicatorsReadable" /> class.
        /// </summary>
        /// <param name="optOutIndicatorsDescriptor">Opt Out Indicators. (required).</param>
        public MnStudentEducationOrganizationAssociationOptOutIndicatorsReadable(string optOutIndicatorsDescriptor = default(string))
        {
            // to ensure "optOutIndicatorsDescriptor" is required (not null)
            if (optOutIndicatorsDescriptor == null)
            {
                throw new ArgumentNullException("optOutIndicatorsDescriptor is a required property for MnStudentEducationOrganizationAssociationOptOutIndicatorsReadable and cannot be null");
            }
            this.OptOutIndicatorsDescriptor = optOutIndicatorsDescriptor;
        }

        /// <summary>
        /// Opt Out Indicators.
        /// </summary>
        /// <value>Opt Out Indicators.</value>
        [DataMember(Name = "optOutIndicatorsDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string OptOutIndicatorsDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MnStudentEducationOrganizationAssociationOptOutIndicatorsReadable {\n");
            sb.Append("  OptOutIndicatorsDescriptor: ").Append(OptOutIndicatorsDescriptor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MnStudentEducationOrganizationAssociationOptOutIndicatorsReadable);
        }

        /// <summary>
        /// Returns true if MnStudentEducationOrganizationAssociationOptOutIndicatorsReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentEducationOrganizationAssociationOptOutIndicatorsReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentEducationOrganizationAssociationOptOutIndicatorsReadable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OptOutIndicatorsDescriptor == input.OptOutIndicatorsDescriptor ||
                    (this.OptOutIndicatorsDescriptor != null &&
                    this.OptOutIndicatorsDescriptor.Equals(input.OptOutIndicatorsDescriptor))
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
                if (this.OptOutIndicatorsDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.OptOutIndicatorsDescriptor.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // OptOutIndicatorsDescriptor (string) maxLength
            if (this.OptOutIndicatorsDescriptor != null && this.OptOutIndicatorsDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OptOutIndicatorsDescriptor, length must be less than 306.", new [] { "OptOutIndicatorsDescriptor" });
            }

            yield break;
        }
    }

}
