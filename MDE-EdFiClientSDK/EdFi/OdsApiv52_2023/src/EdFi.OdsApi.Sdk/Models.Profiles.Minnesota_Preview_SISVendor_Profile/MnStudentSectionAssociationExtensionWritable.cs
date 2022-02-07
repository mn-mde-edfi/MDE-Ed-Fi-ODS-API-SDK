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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile
{
    /// <summary>
    /// MnStudentSectionAssociationExtensionWritable
    /// </summary>
    [DataContract]
    public partial class MnStudentSectionAssociationExtensionWritable :  IEquatable<MnStudentSectionAssociationExtensionWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentSectionAssociationExtensionWritable" /> class.
        /// </summary>
        /// <param name="sectionEnrollmentTypeDescriptor">Section enrollment type..</param>
        /// <param name="collegeCourseReference">collegeCourseReference.</param>
        /// <param name="instructionalApproaches">An unordered collection of studentSectionAssociationInstructionalApproaches. Instructional approach as implemented for the student section association. General purpose but intially implemented for Early Education..</param>
        /// <param name="siteBasedInitiatives">An unordered collection of studentSectionAssociationSiteBasedInitiatives. Site-based initiative as implemented for the student section association. General purpose but intially implemented for Early Education..</param>
        public MnStudentSectionAssociationExtensionWritable(string sectionEnrollmentTypeDescriptor = default(string), EdFiCourseReference collegeCourseReference = default(EdFiCourseReference), List<MnStudentSectionAssociationInstructionalApproachWritable> instructionalApproaches = default(List<MnStudentSectionAssociationInstructionalApproachWritable>), List<MnStudentSectionAssociationSiteBasedInitiativeWritable> siteBasedInitiatives = default(List<MnStudentSectionAssociationSiteBasedInitiativeWritable>))
        {
            this.SectionEnrollmentTypeDescriptor = sectionEnrollmentTypeDescriptor;
            this.CollegeCourseReference = collegeCourseReference;
            this.InstructionalApproaches = instructionalApproaches;
            this.SiteBasedInitiatives = siteBasedInitiatives;
        }
        
        /// <summary>
        /// Section enrollment type.
        /// </summary>
        /// <value>Section enrollment type.</value>
        [DataMember(Name="sectionEnrollmentTypeDescriptor", EmitDefaultValue=false)]
        public string SectionEnrollmentTypeDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets CollegeCourseReference
        /// </summary>
        [DataMember(Name="collegeCourseReference", EmitDefaultValue=false)]
        public EdFiCourseReference CollegeCourseReference { get; set; }

        /// <summary>
        /// An unordered collection of studentSectionAssociationInstructionalApproaches. Instructional approach as implemented for the student section association. General purpose but intially implemented for Early Education.
        /// </summary>
        /// <value>An unordered collection of studentSectionAssociationInstructionalApproaches. Instructional approach as implemented for the student section association. General purpose but intially implemented for Early Education.</value>
        [DataMember(Name="instructionalApproaches", EmitDefaultValue=false)]
        public List<MnStudentSectionAssociationInstructionalApproachWritable> InstructionalApproaches { get; set; }

        /// <summary>
        /// An unordered collection of studentSectionAssociationSiteBasedInitiatives. Site-based initiative as implemented for the student section association. General purpose but intially implemented for Early Education.
        /// </summary>
        /// <value>An unordered collection of studentSectionAssociationSiteBasedInitiatives. Site-based initiative as implemented for the student section association. General purpose but intially implemented for Early Education.</value>
        [DataMember(Name="siteBasedInitiatives", EmitDefaultValue=false)]
        public List<MnStudentSectionAssociationSiteBasedInitiativeWritable> SiteBasedInitiatives { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnStudentSectionAssociationExtensionWritable {\n");
            sb.Append("  SectionEnrollmentTypeDescriptor: ").Append(SectionEnrollmentTypeDescriptor).Append("\n");
            sb.Append("  CollegeCourseReference: ").Append(CollegeCourseReference).Append("\n");
            sb.Append("  InstructionalApproaches: ").Append(InstructionalApproaches).Append("\n");
            sb.Append("  SiteBasedInitiatives: ").Append(SiteBasedInitiatives).Append("\n");
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
            return this.Equals(input as MnStudentSectionAssociationExtensionWritable);
        }

        /// <summary>
        /// Returns true if MnStudentSectionAssociationExtensionWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentSectionAssociationExtensionWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentSectionAssociationExtensionWritable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SectionEnrollmentTypeDescriptor == input.SectionEnrollmentTypeDescriptor ||
                    (this.SectionEnrollmentTypeDescriptor != null &&
                    this.SectionEnrollmentTypeDescriptor.Equals(input.SectionEnrollmentTypeDescriptor))
                ) && 
                (
                    this.CollegeCourseReference == input.CollegeCourseReference ||
                    (this.CollegeCourseReference != null &&
                    this.CollegeCourseReference.Equals(input.CollegeCourseReference))
                ) && 
                (
                    this.InstructionalApproaches == input.InstructionalApproaches ||
                    this.InstructionalApproaches != null &&
                    this.InstructionalApproaches.SequenceEqual(input.InstructionalApproaches)
                ) && 
                (
                    this.SiteBasedInitiatives == input.SiteBasedInitiatives ||
                    this.SiteBasedInitiatives != null &&
                    this.SiteBasedInitiatives.SequenceEqual(input.SiteBasedInitiatives)
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
                if (this.SectionEnrollmentTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.SectionEnrollmentTypeDescriptor.GetHashCode();
                if (this.CollegeCourseReference != null)
                    hashCode = hashCode * 59 + this.CollegeCourseReference.GetHashCode();
                if (this.InstructionalApproaches != null)
                    hashCode = hashCode * 59 + this.InstructionalApproaches.GetHashCode();
                if (this.SiteBasedInitiatives != null)
                    hashCode = hashCode * 59 + this.SiteBasedInitiatives.GetHashCode();
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
            // SectionEnrollmentTypeDescriptor (string) maxLength
            if(this.SectionEnrollmentTypeDescriptor != null && this.SectionEnrollmentTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionEnrollmentTypeDescriptor, length must be less than 306.", new [] { "SectionEnrollmentTypeDescriptor" });
            }

            yield break;
        }
    }

}