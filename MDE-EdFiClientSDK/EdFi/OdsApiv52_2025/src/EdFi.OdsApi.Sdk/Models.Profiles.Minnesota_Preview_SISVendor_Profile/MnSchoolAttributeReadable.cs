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
    /// MnSchoolAttributeReadable
    /// </summary>
    [DataContract(Name = "mn_schoolAttribute_readable")]
    public partial class MnSchoolAttributeReadable : IEquatable<MnSchoolAttributeReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnSchoolAttributeReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnSchoolAttributeReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnSchoolAttributeReadable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="schoolReference">schoolReference (required).</param>
        /// <param name="educationOrganizationIndicators">An unordered collection of schoolAttributeEducationOrganizationIndicators. An indicator or metric of an Education Organization..</param>
        /// <param name="hasAntiBullyingPolicy">Indicator that the school enforces an anti-bullying policy..</param>
        /// <param name="hasAntiViolencePolicy">Indicator that the school enforces an anti-violence policy..</param>
        /// <param name="hasCrisisPlan">Indicator that the school has a crisis plan in place..</param>
        /// <param name="hasDrugEducation">Indicator that the school has a drug education program in place..</param>
        /// <param name="hasSafetyPlan">Indicator that the school has a safety plan in place..</param>
        /// <param name="hasZeroTolerancePolicy">Indicator that the school enforces a zero tolerance policy..</param>
        /// <param name="numberOfHabitualTruants">The number of students in the school who are habitual truants..</param>
        /// <param name="safetySpecialistEmail">The email address of the school safety specialist at the school..</param>
        /// <param name="titleIPartASchoolDesignationDescriptor">Denotes the Title I Part A designation for the school..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public MnSchoolAttributeReadable(string id = default(string), MnSchoolReference schoolReference = default(MnSchoolReference), List<MnSchoolAttributeEducationOrganizationIndicatorReadable> educationOrganizationIndicators = default(List<MnSchoolAttributeEducationOrganizationIndicatorReadable>), bool hasAntiBullyingPolicy = default(bool), bool hasAntiViolencePolicy = default(bool), bool hasCrisisPlan = default(bool), bool hasDrugEducation = default(bool), bool hasSafetyPlan = default(bool), bool hasZeroTolerancePolicy = default(bool), int numberOfHabitualTruants = default(int), string safetySpecialistEmail = default(string), string titleIPartASchoolDesignationDescriptor = default(string), string etag = default(string))
        {
            // to ensure "schoolReference" is required (not null)
            if (schoolReference == null)
            {
                throw new ArgumentNullException("schoolReference is a required property for MnSchoolAttributeReadable and cannot be null");
            }
            this.SchoolReference = schoolReference;
            this.Id = id;
            this.EducationOrganizationIndicators = educationOrganizationIndicators;
            this.HasAntiBullyingPolicy = hasAntiBullyingPolicy;
            this.HasAntiViolencePolicy = hasAntiViolencePolicy;
            this.HasCrisisPlan = hasCrisisPlan;
            this.HasDrugEducation = hasDrugEducation;
            this.HasSafetyPlan = hasSafetyPlan;
            this.HasZeroTolerancePolicy = hasZeroTolerancePolicy;
            this.NumberOfHabitualTruants = numberOfHabitualTruants;
            this.SafetySpecialistEmail = safetySpecialistEmail;
            this.TitleIPartASchoolDesignationDescriptor = titleIPartASchoolDesignationDescriptor;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name = "schoolReference", IsRequired = true, EmitDefaultValue = false)]
        public MnSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// An unordered collection of schoolAttributeEducationOrganizationIndicators. An indicator or metric of an Education Organization.
        /// </summary>
        /// <value>An unordered collection of schoolAttributeEducationOrganizationIndicators. An indicator or metric of an Education Organization.</value>
        [DataMember(Name = "educationOrganizationIndicators", EmitDefaultValue = false)]
        public List<MnSchoolAttributeEducationOrganizationIndicatorReadable> EducationOrganizationIndicators { get; set; }

        /// <summary>
        /// Indicator that the school enforces an anti-bullying policy.
        /// </summary>
        /// <value>Indicator that the school enforces an anti-bullying policy.</value>
        [DataMember(Name = "hasAntiBullyingPolicy", EmitDefaultValue = true)]
        public bool HasAntiBullyingPolicy { get; set; }

        /// <summary>
        /// Indicator that the school enforces an anti-violence policy.
        /// </summary>
        /// <value>Indicator that the school enforces an anti-violence policy.</value>
        [DataMember(Name = "hasAntiViolencePolicy", EmitDefaultValue = true)]
        public bool HasAntiViolencePolicy { get; set; }

        /// <summary>
        /// Indicator that the school has a crisis plan in place.
        /// </summary>
        /// <value>Indicator that the school has a crisis plan in place.</value>
        [DataMember(Name = "hasCrisisPlan", EmitDefaultValue = true)]
        public bool HasCrisisPlan { get; set; }

        /// <summary>
        /// Indicator that the school has a drug education program in place.
        /// </summary>
        /// <value>Indicator that the school has a drug education program in place.</value>
        [DataMember(Name = "hasDrugEducation", EmitDefaultValue = true)]
        public bool HasDrugEducation { get; set; }

        /// <summary>
        /// Indicator that the school has a safety plan in place.
        /// </summary>
        /// <value>Indicator that the school has a safety plan in place.</value>
        [DataMember(Name = "hasSafetyPlan", EmitDefaultValue = true)]
        public bool HasSafetyPlan { get; set; }

        /// <summary>
        /// Indicator that the school enforces a zero tolerance policy.
        /// </summary>
        /// <value>Indicator that the school enforces a zero tolerance policy.</value>
        [DataMember(Name = "hasZeroTolerancePolicy", EmitDefaultValue = true)]
        public bool HasZeroTolerancePolicy { get; set; }

        /// <summary>
        /// The number of students in the school who are habitual truants.
        /// </summary>
        /// <value>The number of students in the school who are habitual truants.</value>
        [DataMember(Name = "numberOfHabitualTruants", EmitDefaultValue = false)]
        public int NumberOfHabitualTruants { get; set; }

        /// <summary>
        /// The email address of the school safety specialist at the school.
        /// </summary>
        /// <value>The email address of the school safety specialist at the school.</value>
        [DataMember(Name = "safetySpecialistEmail", EmitDefaultValue = false)]
        public string SafetySpecialistEmail { get; set; }

        /// <summary>
        /// Denotes the Title I Part A designation for the school.
        /// </summary>
        /// <value>Denotes the Title I Part A designation for the school.</value>
        [DataMember(Name = "titleIPartASchoolDesignationDescriptor", EmitDefaultValue = false)]
        public string TitleIPartASchoolDesignationDescriptor { get; set; }

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
            sb.Append("class MnSchoolAttributeReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  EducationOrganizationIndicators: ").Append(EducationOrganizationIndicators).Append("\n");
            sb.Append("  HasAntiBullyingPolicy: ").Append(HasAntiBullyingPolicy).Append("\n");
            sb.Append("  HasAntiViolencePolicy: ").Append(HasAntiViolencePolicy).Append("\n");
            sb.Append("  HasCrisisPlan: ").Append(HasCrisisPlan).Append("\n");
            sb.Append("  HasDrugEducation: ").Append(HasDrugEducation).Append("\n");
            sb.Append("  HasSafetyPlan: ").Append(HasSafetyPlan).Append("\n");
            sb.Append("  HasZeroTolerancePolicy: ").Append(HasZeroTolerancePolicy).Append("\n");
            sb.Append("  NumberOfHabitualTruants: ").Append(NumberOfHabitualTruants).Append("\n");
            sb.Append("  SafetySpecialistEmail: ").Append(SafetySpecialistEmail).Append("\n");
            sb.Append("  TitleIPartASchoolDesignationDescriptor: ").Append(TitleIPartASchoolDesignationDescriptor).Append("\n");
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
            return this.Equals(input as MnSchoolAttributeReadable);
        }

        /// <summary>
        /// Returns true if MnSchoolAttributeReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnSchoolAttributeReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnSchoolAttributeReadable input)
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
                    this.SchoolReference == input.SchoolReference ||
                    (this.SchoolReference != null &&
                    this.SchoolReference.Equals(input.SchoolReference))
                ) && 
                (
                    this.EducationOrganizationIndicators == input.EducationOrganizationIndicators ||
                    this.EducationOrganizationIndicators != null &&
                    input.EducationOrganizationIndicators != null &&
                    this.EducationOrganizationIndicators.SequenceEqual(input.EducationOrganizationIndicators)
                ) && 
                (
                    this.HasAntiBullyingPolicy == input.HasAntiBullyingPolicy ||
                    this.HasAntiBullyingPolicy.Equals(input.HasAntiBullyingPolicy)
                ) && 
                (
                    this.HasAntiViolencePolicy == input.HasAntiViolencePolicy ||
                    this.HasAntiViolencePolicy.Equals(input.HasAntiViolencePolicy)
                ) && 
                (
                    this.HasCrisisPlan == input.HasCrisisPlan ||
                    this.HasCrisisPlan.Equals(input.HasCrisisPlan)
                ) && 
                (
                    this.HasDrugEducation == input.HasDrugEducation ||
                    this.HasDrugEducation.Equals(input.HasDrugEducation)
                ) && 
                (
                    this.HasSafetyPlan == input.HasSafetyPlan ||
                    this.HasSafetyPlan.Equals(input.HasSafetyPlan)
                ) && 
                (
                    this.HasZeroTolerancePolicy == input.HasZeroTolerancePolicy ||
                    this.HasZeroTolerancePolicy.Equals(input.HasZeroTolerancePolicy)
                ) && 
                (
                    this.NumberOfHabitualTruants == input.NumberOfHabitualTruants ||
                    this.NumberOfHabitualTruants.Equals(input.NumberOfHabitualTruants)
                ) && 
                (
                    this.SafetySpecialistEmail == input.SafetySpecialistEmail ||
                    (this.SafetySpecialistEmail != null &&
                    this.SafetySpecialistEmail.Equals(input.SafetySpecialistEmail))
                ) && 
                (
                    this.TitleIPartASchoolDesignationDescriptor == input.TitleIPartASchoolDesignationDescriptor ||
                    (this.TitleIPartASchoolDesignationDescriptor != null &&
                    this.TitleIPartASchoolDesignationDescriptor.Equals(input.TitleIPartASchoolDesignationDescriptor))
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
                if (this.SchoolReference != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolReference.GetHashCode();
                }
                if (this.EducationOrganizationIndicators != null)
                {
                    hashCode = (hashCode * 59) + this.EducationOrganizationIndicators.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasAntiBullyingPolicy.GetHashCode();
                hashCode = (hashCode * 59) + this.HasAntiViolencePolicy.GetHashCode();
                hashCode = (hashCode * 59) + this.HasCrisisPlan.GetHashCode();
                hashCode = (hashCode * 59) + this.HasDrugEducation.GetHashCode();
                hashCode = (hashCode * 59) + this.HasSafetyPlan.GetHashCode();
                hashCode = (hashCode * 59) + this.HasZeroTolerancePolicy.GetHashCode();
                hashCode = (hashCode * 59) + this.NumberOfHabitualTruants.GetHashCode();
                if (this.SafetySpecialistEmail != null)
                {
                    hashCode = (hashCode * 59) + this.SafetySpecialistEmail.GetHashCode();
                }
                if (this.TitleIPartASchoolDesignationDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.TitleIPartASchoolDesignationDescriptor.GetHashCode();
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
            // SafetySpecialistEmail (string) maxLength
            if (this.SafetySpecialistEmail != null && this.SafetySpecialistEmail.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SafetySpecialistEmail, length must be less than 75.", new [] { "SafetySpecialistEmail" });
            }

            // TitleIPartASchoolDesignationDescriptor (string) maxLength
            if (this.TitleIPartASchoolDesignationDescriptor != null && this.TitleIPartASchoolDesignationDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TitleIPartASchoolDesignationDescriptor, length must be less than 306.", new [] { "TitleIPartASchoolDesignationDescriptor" });
            }

            yield break;
        }
    }

}
