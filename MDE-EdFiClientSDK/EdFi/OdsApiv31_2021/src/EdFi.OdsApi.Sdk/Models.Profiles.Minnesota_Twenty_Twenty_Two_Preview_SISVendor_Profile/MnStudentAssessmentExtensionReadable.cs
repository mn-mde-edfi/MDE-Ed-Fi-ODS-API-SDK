/* 
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface. The Ed-Fi ODS / API supports both transactional and bulk modes of operation.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile
{
    /// <summary>
    /// MnStudentAssessmentExtensionReadable
    /// </summary>
    [DataContract]
    public partial class MnStudentAssessmentExtensionReadable :  IEquatable<MnStudentAssessmentExtensionReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentAssessmentExtensionReadable" /> class.
        /// </summary>
        /// <param name="AssessmentFormatDescriptor">Format for which an assessment was administered. E.g., Online or Paper.</param>
        /// <param name="AssessmentTierDescriptor">Tier descriptor for Assessment. E.g., Listening, Reading, Speaking, Writing.</param>
        /// <param name="GeneralEnrollmentDescriptor">General type of enrollment for a student. E.g., R-Regular, N-Nonpublic, H-Homeschool.</param>
        /// <param name="CatStudentTestId">CAT Student Test ID.</param>
        /// <param name="LearningLocatorCode">Learning locator code.</param>
        /// <param name="TimeOnTest">Total recorded time duration in seconds.</param>
        /// <param name="SiteEducationOrganizationReference">SiteEducationOrganizationReference.</param>
        /// <param name="Characteristics">An unordered collection of studentAssessmentCharacteristics. Generic characteristics about an Assessment other than Accommodations..</param>
        public MnStudentAssessmentExtensionReadable(string AssessmentFormatDescriptor = default(string), string AssessmentTierDescriptor = default(string), string GeneralEnrollmentDescriptor = default(string), string CatStudentTestId = default(string), string LearningLocatorCode = default(string), int? TimeOnTest = default(int?), EdFiEducationOrganizationReference SiteEducationOrganizationReference = default(EdFiEducationOrganizationReference), List<MnStudentAssessmentCharacteristicReadable> Characteristics = default(List<MnStudentAssessmentCharacteristicReadable>))
        {
            this.AssessmentFormatDescriptor = AssessmentFormatDescriptor;
            this.AssessmentTierDescriptor = AssessmentTierDescriptor;
            this.GeneralEnrollmentDescriptor = GeneralEnrollmentDescriptor;
            this.CatStudentTestId = CatStudentTestId;
            this.LearningLocatorCode = LearningLocatorCode;
            this.TimeOnTest = TimeOnTest;
            this.SiteEducationOrganizationReference = SiteEducationOrganizationReference;
            this.Characteristics = Characteristics;
        }
        
        /// <summary>
        /// Format for which an assessment was administered. E.g., Online or Paper
        /// </summary>
        /// <value>Format for which an assessment was administered. E.g., Online or Paper</value>
        [DataMember(Name="assessmentFormatDescriptor", EmitDefaultValue=false)]
        public string AssessmentFormatDescriptor { get; set; }

        /// <summary>
        /// Tier descriptor for Assessment. E.g., Listening, Reading, Speaking, Writing
        /// </summary>
        /// <value>Tier descriptor for Assessment. E.g., Listening, Reading, Speaking, Writing</value>
        [DataMember(Name="assessmentTierDescriptor", EmitDefaultValue=false)]
        public string AssessmentTierDescriptor { get; set; }

        /// <summary>
        /// General type of enrollment for a student. E.g., R-Regular, N-Nonpublic, H-Homeschool
        /// </summary>
        /// <value>General type of enrollment for a student. E.g., R-Regular, N-Nonpublic, H-Homeschool</value>
        [DataMember(Name="generalEnrollmentDescriptor", EmitDefaultValue=false)]
        public string GeneralEnrollmentDescriptor { get; set; }

        /// <summary>
        /// CAT Student Test ID
        /// </summary>
        /// <value>CAT Student Test ID</value>
        [DataMember(Name="catStudentTestId", EmitDefaultValue=false)]
        public string CatStudentTestId { get; set; }

        /// <summary>
        /// Learning locator code
        /// </summary>
        /// <value>Learning locator code</value>
        [DataMember(Name="learningLocatorCode", EmitDefaultValue=false)]
        public string LearningLocatorCode { get; set; }

        /// <summary>
        /// Total recorded time duration in seconds
        /// </summary>
        /// <value>Total recorded time duration in seconds</value>
        [DataMember(Name="timeOnTest", EmitDefaultValue=false)]
        public int? TimeOnTest { get; set; }

        /// <summary>
        /// Gets or Sets SiteEducationOrganizationReference
        /// </summary>
        [DataMember(Name="siteEducationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference SiteEducationOrganizationReference { get; set; }

        /// <summary>
        /// An unordered collection of studentAssessmentCharacteristics. Generic characteristics about an Assessment other than Accommodations.
        /// </summary>
        /// <value>An unordered collection of studentAssessmentCharacteristics. Generic characteristics about an Assessment other than Accommodations.</value>
        [DataMember(Name="characteristics", EmitDefaultValue=false)]
        public List<MnStudentAssessmentCharacteristicReadable> Characteristics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnStudentAssessmentExtensionReadable {\n");
            sb.Append("  AssessmentFormatDescriptor: ").Append(AssessmentFormatDescriptor).Append("\n");
            sb.Append("  AssessmentTierDescriptor: ").Append(AssessmentTierDescriptor).Append("\n");
            sb.Append("  GeneralEnrollmentDescriptor: ").Append(GeneralEnrollmentDescriptor).Append("\n");
            sb.Append("  CatStudentTestId: ").Append(CatStudentTestId).Append("\n");
            sb.Append("  LearningLocatorCode: ").Append(LearningLocatorCode).Append("\n");
            sb.Append("  TimeOnTest: ").Append(TimeOnTest).Append("\n");
            sb.Append("  SiteEducationOrganizationReference: ").Append(SiteEducationOrganizationReference).Append("\n");
            sb.Append("  Characteristics: ").Append(Characteristics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as MnStudentAssessmentExtensionReadable);
        }

        /// <summary>
        /// Returns true if MnStudentAssessmentExtensionReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentAssessmentExtensionReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentAssessmentExtensionReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssessmentFormatDescriptor == input.AssessmentFormatDescriptor ||
                    (this.AssessmentFormatDescriptor != null &&
                    this.AssessmentFormatDescriptor.Equals(input.AssessmentFormatDescriptor))
                ) && 
                (
                    this.AssessmentTierDescriptor == input.AssessmentTierDescriptor ||
                    (this.AssessmentTierDescriptor != null &&
                    this.AssessmentTierDescriptor.Equals(input.AssessmentTierDescriptor))
                ) && 
                (
                    this.GeneralEnrollmentDescriptor == input.GeneralEnrollmentDescriptor ||
                    (this.GeneralEnrollmentDescriptor != null &&
                    this.GeneralEnrollmentDescriptor.Equals(input.GeneralEnrollmentDescriptor))
                ) && 
                (
                    this.CatStudentTestId == input.CatStudentTestId ||
                    (this.CatStudentTestId != null &&
                    this.CatStudentTestId.Equals(input.CatStudentTestId))
                ) && 
                (
                    this.LearningLocatorCode == input.LearningLocatorCode ||
                    (this.LearningLocatorCode != null &&
                    this.LearningLocatorCode.Equals(input.LearningLocatorCode))
                ) && 
                (
                    this.TimeOnTest == input.TimeOnTest ||
                    (this.TimeOnTest != null &&
                    this.TimeOnTest.Equals(input.TimeOnTest))
                ) && 
                (
                    this.SiteEducationOrganizationReference == input.SiteEducationOrganizationReference ||
                    (this.SiteEducationOrganizationReference != null &&
                    this.SiteEducationOrganizationReference.Equals(input.SiteEducationOrganizationReference))
                ) && 
                (
                    this.Characteristics == input.Characteristics ||
                    this.Characteristics != null &&
                    this.Characteristics.SequenceEqual(input.Characteristics)
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
                if (this.AssessmentFormatDescriptor != null)
                    hashCode = hashCode * 59 + this.AssessmentFormatDescriptor.GetHashCode();
                if (this.AssessmentTierDescriptor != null)
                    hashCode = hashCode * 59 + this.AssessmentTierDescriptor.GetHashCode();
                if (this.GeneralEnrollmentDescriptor != null)
                    hashCode = hashCode * 59 + this.GeneralEnrollmentDescriptor.GetHashCode();
                if (this.CatStudentTestId != null)
                    hashCode = hashCode * 59 + this.CatStudentTestId.GetHashCode();
                if (this.LearningLocatorCode != null)
                    hashCode = hashCode * 59 + this.LearningLocatorCode.GetHashCode();
                if (this.TimeOnTest != null)
                    hashCode = hashCode * 59 + this.TimeOnTest.GetHashCode();
                if (this.SiteEducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.SiteEducationOrganizationReference.GetHashCode();
                if (this.Characteristics != null)
                    hashCode = hashCode * 59 + this.Characteristics.GetHashCode();
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
            // AssessmentFormatDescriptor (string) maxLength
            if(this.AssessmentFormatDescriptor != null && this.AssessmentFormatDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentFormatDescriptor, length must be less than 306.", new [] { "AssessmentFormatDescriptor" });
            }

            // AssessmentTierDescriptor (string) maxLength
            if(this.AssessmentTierDescriptor != null && this.AssessmentTierDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentTierDescriptor, length must be less than 306.", new [] { "AssessmentTierDescriptor" });
            }

            // GeneralEnrollmentDescriptor (string) maxLength
            if(this.GeneralEnrollmentDescriptor != null && this.GeneralEnrollmentDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GeneralEnrollmentDescriptor, length must be less than 306.", new [] { "GeneralEnrollmentDescriptor" });
            }

            // CatStudentTestId (string) maxLength
            if(this.CatStudentTestId != null && this.CatStudentTestId.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CatStudentTestId, length must be less than 100.", new [] { "CatStudentTestId" });
            }

            // LearningLocatorCode (string) maxLength
            if(this.LearningLocatorCode != null && this.LearningLocatorCode.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LearningLocatorCode, length must be less than 100.", new [] { "LearningLocatorCode" });
            }

            yield break;
        }
    }

}
