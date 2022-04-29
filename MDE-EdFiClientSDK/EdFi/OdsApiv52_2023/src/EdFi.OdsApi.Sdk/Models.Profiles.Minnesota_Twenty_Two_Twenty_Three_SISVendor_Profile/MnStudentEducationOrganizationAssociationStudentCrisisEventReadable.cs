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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Two_Twenty_Three_SISVendor_Profile
{
    /// <summary>
    /// MnStudentEducationOrganizationAssociationStudentCrisisEventReadable
    /// </summary>
    [DataContract]
    public partial class MnStudentEducationOrganizationAssociationStudentCrisisEventReadable :  IEquatable<MnStudentEducationOrganizationAssociationStudentCrisisEventReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentEducationOrganizationAssociationStudentCrisisEventReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentEducationOrganizationAssociationStudentCrisisEventReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentEducationOrganizationAssociationStudentCrisisEventReadable" /> class.
        /// </summary>
        /// <param name="crisisEventDescriptor">The specific event that affected the student (required).</param>
        /// <param name="displacedStudentIndicator">An indication that the student was displaced from their home due to the crisis. The student may or may not be considered homeless due to the displacement. (required).</param>
        public MnStudentEducationOrganizationAssociationStudentCrisisEventReadable(string crisisEventDescriptor = default(string), bool? displacedStudentIndicator = default(bool?))
        {
            // to ensure "crisisEventDescriptor" is required (not null)
            if (crisisEventDescriptor == null)
            {
                throw new InvalidDataException("crisisEventDescriptor is a required property for MnStudentEducationOrganizationAssociationStudentCrisisEventReadable and cannot be null");
            }
            else
            {
                this.CrisisEventDescriptor = crisisEventDescriptor;
            }
            // to ensure "displacedStudentIndicator" is required (not null)
            if (displacedStudentIndicator == null)
            {
                throw new InvalidDataException("displacedStudentIndicator is a required property for MnStudentEducationOrganizationAssociationStudentCrisisEventReadable and cannot be null");
            }
            else
            {
                this.DisplacedStudentIndicator = displacedStudentIndicator;
            }
        }
        
        /// <summary>
        /// The specific event that affected the student
        /// </summary>
        /// <value>The specific event that affected the student</value>
        [DataMember(Name="crisisEventDescriptor", EmitDefaultValue=false)]
        public string CrisisEventDescriptor { get; set; }

        /// <summary>
        /// An indication that the student was displaced from their home due to the crisis. The student may or may not be considered homeless due to the displacement.
        /// </summary>
        /// <value>An indication that the student was displaced from their home due to the crisis. The student may or may not be considered homeless due to the displacement.</value>
        [DataMember(Name="displacedStudentIndicator", EmitDefaultValue=false)]
        public bool? DisplacedStudentIndicator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnStudentEducationOrganizationAssociationStudentCrisisEventReadable {\n");
            sb.Append("  CrisisEventDescriptor: ").Append(CrisisEventDescriptor).Append("\n");
            sb.Append("  DisplacedStudentIndicator: ").Append(DisplacedStudentIndicator).Append("\n");
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
            return this.Equals(input as MnStudentEducationOrganizationAssociationStudentCrisisEventReadable);
        }

        /// <summary>
        /// Returns true if MnStudentEducationOrganizationAssociationStudentCrisisEventReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentEducationOrganizationAssociationStudentCrisisEventReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentEducationOrganizationAssociationStudentCrisisEventReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CrisisEventDescriptor == input.CrisisEventDescriptor ||
                    (this.CrisisEventDescriptor != null &&
                    this.CrisisEventDescriptor.Equals(input.CrisisEventDescriptor))
                ) && 
                (
                    this.DisplacedStudentIndicator == input.DisplacedStudentIndicator ||
                    (this.DisplacedStudentIndicator != null &&
                    this.DisplacedStudentIndicator.Equals(input.DisplacedStudentIndicator))
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
                if (this.CrisisEventDescriptor != null)
                    hashCode = hashCode * 59 + this.CrisisEventDescriptor.GetHashCode();
                if (this.DisplacedStudentIndicator != null)
                    hashCode = hashCode * 59 + this.DisplacedStudentIndicator.GetHashCode();
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
            // CrisisEventDescriptor (string) maxLength
            if(this.CrisisEventDescriptor != null && this.CrisisEventDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CrisisEventDescriptor, length must be less than 306.", new [] { "CrisisEventDescriptor" });
            }

            yield break;
        }
    }

}
