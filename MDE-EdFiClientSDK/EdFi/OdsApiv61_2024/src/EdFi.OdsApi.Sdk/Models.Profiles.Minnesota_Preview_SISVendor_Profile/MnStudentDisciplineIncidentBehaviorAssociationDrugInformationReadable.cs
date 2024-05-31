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
    /// MnStudentDisciplineIncidentBehaviorAssociationDrugInformationReadable
    /// </summary>
    [DataContract(Name = "mn_studentDisciplineIncidentBehaviorAssociationDrugInformation_readable")]
    public partial class MnStudentDisciplineIncidentBehaviorAssociationDrugInformationReadable : IEquatable<MnStudentDisciplineIncidentBehaviorAssociationDrugInformationReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentDisciplineIncidentBehaviorAssociationDrugInformationReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentDisciplineIncidentBehaviorAssociationDrugInformationReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentDisciplineIncidentBehaviorAssociationDrugInformationReadable" /> class.
        /// </summary>
        /// <param name="drugTypeDescriptor">Indicates the drug type associated with an incident. (required).</param>
        /// <param name="drugTypeOtherDescription">Description for other drug type not found in DrugType..</param>
        public MnStudentDisciplineIncidentBehaviorAssociationDrugInformationReadable(string drugTypeDescriptor = default(string), string drugTypeOtherDescription = default(string))
        {
            // to ensure "drugTypeDescriptor" is required (not null)
            if (drugTypeDescriptor == null)
            {
                throw new ArgumentNullException("drugTypeDescriptor is a required property for MnStudentDisciplineIncidentBehaviorAssociationDrugInformationReadable and cannot be null");
            }
            this.DrugTypeDescriptor = drugTypeDescriptor;
            this.DrugTypeOtherDescription = drugTypeOtherDescription;
        }

        /// <summary>
        /// Indicates the drug type associated with an incident.
        /// </summary>
        /// <value>Indicates the drug type associated with an incident.</value>
        [DataMember(Name = "drugTypeDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string DrugTypeDescriptor { get; set; }

        /// <summary>
        /// Description for other drug type not found in DrugType.
        /// </summary>
        /// <value>Description for other drug type not found in DrugType.</value>
        [DataMember(Name = "drugTypeOtherDescription", EmitDefaultValue = false)]
        public string DrugTypeOtherDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MnStudentDisciplineIncidentBehaviorAssociationDrugInformationReadable {\n");
            sb.Append("  DrugTypeDescriptor: ").Append(DrugTypeDescriptor).Append("\n");
            sb.Append("  DrugTypeOtherDescription: ").Append(DrugTypeOtherDescription).Append("\n");
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
            return this.Equals(input as MnStudentDisciplineIncidentBehaviorAssociationDrugInformationReadable);
        }

        /// <summary>
        /// Returns true if MnStudentDisciplineIncidentBehaviorAssociationDrugInformationReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentDisciplineIncidentBehaviorAssociationDrugInformationReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentDisciplineIncidentBehaviorAssociationDrugInformationReadable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DrugTypeDescriptor == input.DrugTypeDescriptor ||
                    (this.DrugTypeDescriptor != null &&
                    this.DrugTypeDescriptor.Equals(input.DrugTypeDescriptor))
                ) && 
                (
                    this.DrugTypeOtherDescription == input.DrugTypeOtherDescription ||
                    (this.DrugTypeOtherDescription != null &&
                    this.DrugTypeOtherDescription.Equals(input.DrugTypeOtherDescription))
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
                if (this.DrugTypeDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.DrugTypeDescriptor.GetHashCode();
                }
                if (this.DrugTypeOtherDescription != null)
                {
                    hashCode = (hashCode * 59) + this.DrugTypeOtherDescription.GetHashCode();
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
            // DrugTypeDescriptor (string) maxLength
            if (this.DrugTypeDescriptor != null && this.DrugTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DrugTypeDescriptor, length must be less than 306.", new [] { "DrugTypeDescriptor" });
            }

            // DrugTypeOtherDescription (string) maxLength
            if (this.DrugTypeOtherDescription != null && this.DrugTypeOtherDescription.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DrugTypeOtherDescription, length must be less than 1024.", new [] { "DrugTypeOtherDescription" });
            }

            yield break;
        }
    }

}
