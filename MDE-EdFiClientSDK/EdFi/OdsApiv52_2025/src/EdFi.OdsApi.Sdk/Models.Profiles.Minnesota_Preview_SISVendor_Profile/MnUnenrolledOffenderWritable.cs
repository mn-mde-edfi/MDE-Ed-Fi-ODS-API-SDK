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
    /// MnUnenrolledOffenderWritable
    /// </summary>
    [DataContract(Name = "mn_unenrolledOffender_writable")]
    public partial class MnUnenrolledOffenderWritable : IEquatable<MnUnenrolledOffenderWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnUnenrolledOffenderWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnUnenrolledOffenderWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnUnenrolledOffenderWritable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="disciplineIncidentReference">disciplineIncidentReference (required).</param>
        /// <param name="behaviorDescriptor">Describes the behavior in the discipline incident..</param>
        /// <param name="secondaryBehaviorDescriptor">This describes the type of offense committed..</param>
        /// <param name="unenrolledStudentCount">Number of unenrolled student offender. (required).</param>
        /// <param name="weaponAttribute">weaponAttribute.</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public MnUnenrolledOffenderWritable(string id = default(string), MnDisciplineIncidentReference disciplineIncidentReference = default(MnDisciplineIncidentReference), string behaviorDescriptor = default(string), string secondaryBehaviorDescriptor = default(string), int unenrolledStudentCount = default(int), MnUnenrolledOffenderWeaponAttributeWritable weaponAttribute = default(MnUnenrolledOffenderWeaponAttributeWritable), string etag = default(string))
        {
            // to ensure "disciplineIncidentReference" is required (not null)
            if (disciplineIncidentReference == null)
            {
                throw new ArgumentNullException("disciplineIncidentReference is a required property for MnUnenrolledOffenderWritable and cannot be null");
            }
            this.DisciplineIncidentReference = disciplineIncidentReference;
            this.UnenrolledStudentCount = unenrolledStudentCount;
            this.Id = id;
            this.BehaviorDescriptor = behaviorDescriptor;
            this.SecondaryBehaviorDescriptor = secondaryBehaviorDescriptor;
            this.WeaponAttribute = weaponAttribute;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets DisciplineIncidentReference
        /// </summary>
        [DataMember(Name = "disciplineIncidentReference", IsRequired = true, EmitDefaultValue = false)]
        public MnDisciplineIncidentReference DisciplineIncidentReference { get; set; }

        /// <summary>
        /// Describes the behavior in the discipline incident.
        /// </summary>
        /// <value>Describes the behavior in the discipline incident.</value>
        [DataMember(Name = "behaviorDescriptor", EmitDefaultValue = false)]
        public string BehaviorDescriptor { get; set; }

        /// <summary>
        /// This describes the type of offense committed.
        /// </summary>
        /// <value>This describes the type of offense committed.</value>
        [DataMember(Name = "secondaryBehaviorDescriptor", EmitDefaultValue = false)]
        public string SecondaryBehaviorDescriptor { get; set; }

        /// <summary>
        /// Number of unenrolled student offender.
        /// </summary>
        /// <value>Number of unenrolled student offender.</value>
        [DataMember(Name = "unenrolledStudentCount", IsRequired = true, EmitDefaultValue = false)]
        public int UnenrolledStudentCount { get; set; }

        /// <summary>
        /// Gets or Sets WeaponAttribute
        /// </summary>
        [DataMember(Name = "weaponAttribute", EmitDefaultValue = false)]
        public MnUnenrolledOffenderWeaponAttributeWritable WeaponAttribute { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MnUnenrolledOffenderWritable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisciplineIncidentReference: ").Append(DisciplineIncidentReference).Append("\n");
            sb.Append("  BehaviorDescriptor: ").Append(BehaviorDescriptor).Append("\n");
            sb.Append("  SecondaryBehaviorDescriptor: ").Append(SecondaryBehaviorDescriptor).Append("\n");
            sb.Append("  UnenrolledStudentCount: ").Append(UnenrolledStudentCount).Append("\n");
            sb.Append("  WeaponAttribute: ").Append(WeaponAttribute).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            return this.Equals(input as MnUnenrolledOffenderWritable);
        }

        /// <summary>
        /// Returns true if MnUnenrolledOffenderWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnUnenrolledOffenderWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnUnenrolledOffenderWritable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DisciplineIncidentReference == input.DisciplineIncidentReference ||
                    (this.DisciplineIncidentReference != null &&
                    this.DisciplineIncidentReference.Equals(input.DisciplineIncidentReference))
                ) && 
                (
                    this.BehaviorDescriptor == input.BehaviorDescriptor ||
                    (this.BehaviorDescriptor != null &&
                    this.BehaviorDescriptor.Equals(input.BehaviorDescriptor))
                ) && 
                (
                    this.SecondaryBehaviorDescriptor == input.SecondaryBehaviorDescriptor ||
                    (this.SecondaryBehaviorDescriptor != null &&
                    this.SecondaryBehaviorDescriptor.Equals(input.SecondaryBehaviorDescriptor))
                ) && 
                (
                    this.UnenrolledStudentCount == input.UnenrolledStudentCount ||
                    this.UnenrolledStudentCount.Equals(input.UnenrolledStudentCount)
                ) && 
                (
                    this.WeaponAttribute == input.WeaponAttribute ||
                    (this.WeaponAttribute != null &&
                    this.WeaponAttribute.Equals(input.WeaponAttribute))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.DisciplineIncidentReference != null)
                {
                    hashCode = (hashCode * 59) + this.DisciplineIncidentReference.GetHashCode();
                }
                if (this.BehaviorDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.BehaviorDescriptor.GetHashCode();
                }
                if (this.SecondaryBehaviorDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.SecondaryBehaviorDescriptor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnenrolledStudentCount.GetHashCode();
                if (this.WeaponAttribute != null)
                {
                    hashCode = (hashCode * 59) + this.WeaponAttribute.GetHashCode();
                }
                if (this.Etag != null)
                {
                    hashCode = (hashCode * 59) + this.Etag.GetHashCode();
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
            // BehaviorDescriptor (string) maxLength
            if (this.BehaviorDescriptor != null && this.BehaviorDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BehaviorDescriptor, length must be less than 306.", new [] { "BehaviorDescriptor" });
            }

            // SecondaryBehaviorDescriptor (string) maxLength
            if (this.SecondaryBehaviorDescriptor != null && this.SecondaryBehaviorDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecondaryBehaviorDescriptor, length must be less than 306.", new [] { "SecondaryBehaviorDescriptor" });
            }

            yield break;
        }
    }

}