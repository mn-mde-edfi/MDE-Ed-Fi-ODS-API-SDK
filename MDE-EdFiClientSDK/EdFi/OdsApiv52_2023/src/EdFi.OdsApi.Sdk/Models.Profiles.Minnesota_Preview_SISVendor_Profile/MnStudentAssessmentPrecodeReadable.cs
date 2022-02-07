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
    /// MnStudentAssessmentPrecodeReadable
    /// </summary>
    [DataContract]
    public partial class MnStudentAssessmentPrecodeReadable :  IEquatable<MnStudentAssessmentPrecodeReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentAssessmentPrecodeReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentAssessmentPrecodeReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentAssessmentPrecodeReadable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="precodeTypeDescriptor">Type of pre-code record. For example, MCA/MTAS, ACCESS/ALT-ACCESS (required).</param>
        /// <param name="siteStudentAssessmentPrecodeSiteReference">siteStudentAssessmentPrecodeSiteReference.</param>
        /// <param name="studentEducationOrganizationAssociationReference">studentEducationOrganizationAssociationReference (required).</param>
        /// <param name="academicSubjects">An unordered collection of studentAssessmentPrecodeAcademicSubjects. The description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language) of an assessment..</param>
        /// <param name="accommodations">An unordered collection of studentAssessmentPrecodeAccommodations. The specific type of special variation used in how an examination is presented, how it is administered, or how the test taker is allowed to respond. This generally refers to changes that do not substantially alter what the examination measures. The proper use of accommodations does not substantially change academic level or performance criteria. For example:        Braille        Enlarged monitor view        Extra time        Large Print        Setting        Oral Administration        ....</param>
        /// <param name="assessedGradeLevelDescriptor">The grade level tested for student when assessed..</param>
        /// <param name="assessmentTitle">Refers to the test name of the assessment taken by the student..</param>
        /// <param name="customGroup">District use special sort order.</param>
        /// <param name="enrolledGradeLevelDescriptor">The grade level for which student is enrolled..</param>
        /// <param name="generalEnrollmentDescriptor">Student enrollment at the time of assessment pre-coding. For example H-Homeschool, N-Nonpublic, R-Regular.</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public MnStudentAssessmentPrecodeReadable(string id = default(string), string precodeTypeDescriptor = default(string), MnStudentAssessmentPrecodeSiteReference siteStudentAssessmentPrecodeSiteReference = default(MnStudentAssessmentPrecodeSiteReference), MnStudentEducationOrganizationAssociationReference studentEducationOrganizationAssociationReference = default(MnStudentEducationOrganizationAssociationReference), List<MnStudentAssessmentPrecodeAcademicSubjectReadable> academicSubjects = default(List<MnStudentAssessmentPrecodeAcademicSubjectReadable>), List<MnStudentAssessmentPrecodeAccommodationReadable> accommodations = default(List<MnStudentAssessmentPrecodeAccommodationReadable>), string assessedGradeLevelDescriptor = default(string), string assessmentTitle = default(string), string customGroup = default(string), string enrolledGradeLevelDescriptor = default(string), string generalEnrollmentDescriptor = default(string), string etag = default(string))
        {
            // to ensure "precodeTypeDescriptor" is required (not null)
            if (precodeTypeDescriptor == null)
            {
                throw new InvalidDataException("precodeTypeDescriptor is a required property for MnStudentAssessmentPrecodeReadable and cannot be null");
            }
            else
            {
                this.PrecodeTypeDescriptor = precodeTypeDescriptor;
            }
            // to ensure "studentEducationOrganizationAssociationReference" is required (not null)
            if (studentEducationOrganizationAssociationReference == null)
            {
                throw new InvalidDataException("studentEducationOrganizationAssociationReference is a required property for MnStudentAssessmentPrecodeReadable and cannot be null");
            }
            else
            {
                this.StudentEducationOrganizationAssociationReference = studentEducationOrganizationAssociationReference;
            }
            this.Id = id;
            this.SiteStudentAssessmentPrecodeSiteReference = siteStudentAssessmentPrecodeSiteReference;
            this.AcademicSubjects = academicSubjects;
            this.Accommodations = accommodations;
            this.AssessedGradeLevelDescriptor = assessedGradeLevelDescriptor;
            this.AssessmentTitle = assessmentTitle;
            this.CustomGroup = customGroup;
            this.EnrolledGradeLevelDescriptor = enrolledGradeLevelDescriptor;
            this.GeneralEnrollmentDescriptor = generalEnrollmentDescriptor;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Type of pre-code record. For example, MCA/MTAS, ACCESS/ALT-ACCESS
        /// </summary>
        /// <value>Type of pre-code record. For example, MCA/MTAS, ACCESS/ALT-ACCESS</value>
        [DataMember(Name="precodeTypeDescriptor", EmitDefaultValue=false)]
        public string PrecodeTypeDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets SiteStudentAssessmentPrecodeSiteReference
        /// </summary>
        [DataMember(Name="siteStudentAssessmentPrecodeSiteReference", EmitDefaultValue=false)]
        public MnStudentAssessmentPrecodeSiteReference SiteStudentAssessmentPrecodeSiteReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentEducationOrganizationAssociationReference
        /// </summary>
        [DataMember(Name="studentEducationOrganizationAssociationReference", EmitDefaultValue=false)]
        public MnStudentEducationOrganizationAssociationReference StudentEducationOrganizationAssociationReference { get; set; }

        /// <summary>
        /// An unordered collection of studentAssessmentPrecodeAcademicSubjects. The description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language) of an assessment.
        /// </summary>
        /// <value>An unordered collection of studentAssessmentPrecodeAcademicSubjects. The description of the content or subject area (e.g., arts, mathematics, reading, stenography, or a foreign language) of an assessment.</value>
        [DataMember(Name="academicSubjects", EmitDefaultValue=false)]
        public List<MnStudentAssessmentPrecodeAcademicSubjectReadable> AcademicSubjects { get; set; }

        /// <summary>
        /// An unordered collection of studentAssessmentPrecodeAccommodations. The specific type of special variation used in how an examination is presented, how it is administered, or how the test taker is allowed to respond. This generally refers to changes that do not substantially alter what the examination measures. The proper use of accommodations does not substantially change academic level or performance criteria. For example:        Braille        Enlarged monitor view        Extra time        Large Print        Setting        Oral Administration        ...
        /// </summary>
        /// <value>An unordered collection of studentAssessmentPrecodeAccommodations. The specific type of special variation used in how an examination is presented, how it is administered, or how the test taker is allowed to respond. This generally refers to changes that do not substantially alter what the examination measures. The proper use of accommodations does not substantially change academic level or performance criteria. For example:        Braille        Enlarged monitor view        Extra time        Large Print        Setting        Oral Administration        ...</value>
        [DataMember(Name="accommodations", EmitDefaultValue=false)]
        public List<MnStudentAssessmentPrecodeAccommodationReadable> Accommodations { get; set; }

        /// <summary>
        /// The grade level tested for student when assessed.
        /// </summary>
        /// <value>The grade level tested for student when assessed.</value>
        [DataMember(Name="assessedGradeLevelDescriptor", EmitDefaultValue=false)]
        public string AssessedGradeLevelDescriptor { get; set; }

        /// <summary>
        /// Refers to the test name of the assessment taken by the student.
        /// </summary>
        /// <value>Refers to the test name of the assessment taken by the student.</value>
        [DataMember(Name="assessmentTitle", EmitDefaultValue=false)]
        public string AssessmentTitle { get; set; }

        /// <summary>
        /// District use special sort order
        /// </summary>
        /// <value>District use special sort order</value>
        [DataMember(Name="customGroup", EmitDefaultValue=false)]
        public string CustomGroup { get; set; }

        /// <summary>
        /// The grade level for which student is enrolled.
        /// </summary>
        /// <value>The grade level for which student is enrolled.</value>
        [DataMember(Name="enrolledGradeLevelDescriptor", EmitDefaultValue=false)]
        public string EnrolledGradeLevelDescriptor { get; set; }

        /// <summary>
        /// Student enrollment at the time of assessment pre-coding. For example H-Homeschool, N-Nonpublic, R-Regular
        /// </summary>
        /// <value>Student enrollment at the time of assessment pre-coding. For example H-Homeschool, N-Nonpublic, R-Regular</value>
        [DataMember(Name="generalEnrollmentDescriptor", EmitDefaultValue=false)]
        public string GeneralEnrollmentDescriptor { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MnStudentAssessmentPrecodeReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PrecodeTypeDescriptor: ").Append(PrecodeTypeDescriptor).Append("\n");
            sb.Append("  SiteStudentAssessmentPrecodeSiteReference: ").Append(SiteStudentAssessmentPrecodeSiteReference).Append("\n");
            sb.Append("  StudentEducationOrganizationAssociationReference: ").Append(StudentEducationOrganizationAssociationReference).Append("\n");
            sb.Append("  AcademicSubjects: ").Append(AcademicSubjects).Append("\n");
            sb.Append("  Accommodations: ").Append(Accommodations).Append("\n");
            sb.Append("  AssessedGradeLevelDescriptor: ").Append(AssessedGradeLevelDescriptor).Append("\n");
            sb.Append("  AssessmentTitle: ").Append(AssessmentTitle).Append("\n");
            sb.Append("  CustomGroup: ").Append(CustomGroup).Append("\n");
            sb.Append("  EnrolledGradeLevelDescriptor: ").Append(EnrolledGradeLevelDescriptor).Append("\n");
            sb.Append("  GeneralEnrollmentDescriptor: ").Append(GeneralEnrollmentDescriptor).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MnStudentAssessmentPrecodeReadable);
        }

        /// <summary>
        /// Returns true if MnStudentAssessmentPrecodeReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentAssessmentPrecodeReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentAssessmentPrecodeReadable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PrecodeTypeDescriptor == input.PrecodeTypeDescriptor ||
                    (this.PrecodeTypeDescriptor != null &&
                    this.PrecodeTypeDescriptor.Equals(input.PrecodeTypeDescriptor))
                ) && 
                (
                    this.SiteStudentAssessmentPrecodeSiteReference == input.SiteStudentAssessmentPrecodeSiteReference ||
                    (this.SiteStudentAssessmentPrecodeSiteReference != null &&
                    this.SiteStudentAssessmentPrecodeSiteReference.Equals(input.SiteStudentAssessmentPrecodeSiteReference))
                ) && 
                (
                    this.StudentEducationOrganizationAssociationReference == input.StudentEducationOrganizationAssociationReference ||
                    (this.StudentEducationOrganizationAssociationReference != null &&
                    this.StudentEducationOrganizationAssociationReference.Equals(input.StudentEducationOrganizationAssociationReference))
                ) && 
                (
                    this.AcademicSubjects == input.AcademicSubjects ||
                    this.AcademicSubjects != null &&
                    this.AcademicSubjects.SequenceEqual(input.AcademicSubjects)
                ) && 
                (
                    this.Accommodations == input.Accommodations ||
                    this.Accommodations != null &&
                    this.Accommodations.SequenceEqual(input.Accommodations)
                ) && 
                (
                    this.AssessedGradeLevelDescriptor == input.AssessedGradeLevelDescriptor ||
                    (this.AssessedGradeLevelDescriptor != null &&
                    this.AssessedGradeLevelDescriptor.Equals(input.AssessedGradeLevelDescriptor))
                ) && 
                (
                    this.AssessmentTitle == input.AssessmentTitle ||
                    (this.AssessmentTitle != null &&
                    this.AssessmentTitle.Equals(input.AssessmentTitle))
                ) && 
                (
                    this.CustomGroup == input.CustomGroup ||
                    (this.CustomGroup != null &&
                    this.CustomGroup.Equals(input.CustomGroup))
                ) && 
                (
                    this.EnrolledGradeLevelDescriptor == input.EnrolledGradeLevelDescriptor ||
                    (this.EnrolledGradeLevelDescriptor != null &&
                    this.EnrolledGradeLevelDescriptor.Equals(input.EnrolledGradeLevelDescriptor))
                ) && 
                (
                    this.GeneralEnrollmentDescriptor == input.GeneralEnrollmentDescriptor ||
                    (this.GeneralEnrollmentDescriptor != null &&
                    this.GeneralEnrollmentDescriptor.Equals(input.GeneralEnrollmentDescriptor))
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PrecodeTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.PrecodeTypeDescriptor.GetHashCode();
                if (this.SiteStudentAssessmentPrecodeSiteReference != null)
                    hashCode = hashCode * 59 + this.SiteStudentAssessmentPrecodeSiteReference.GetHashCode();
                if (this.StudentEducationOrganizationAssociationReference != null)
                    hashCode = hashCode * 59 + this.StudentEducationOrganizationAssociationReference.GetHashCode();
                if (this.AcademicSubjects != null)
                    hashCode = hashCode * 59 + this.AcademicSubjects.GetHashCode();
                if (this.Accommodations != null)
                    hashCode = hashCode * 59 + this.Accommodations.GetHashCode();
                if (this.AssessedGradeLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.AssessedGradeLevelDescriptor.GetHashCode();
                if (this.AssessmentTitle != null)
                    hashCode = hashCode * 59 + this.AssessmentTitle.GetHashCode();
                if (this.CustomGroup != null)
                    hashCode = hashCode * 59 + this.CustomGroup.GetHashCode();
                if (this.EnrolledGradeLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.EnrolledGradeLevelDescriptor.GetHashCode();
                if (this.GeneralEnrollmentDescriptor != null)
                    hashCode = hashCode * 59 + this.GeneralEnrollmentDescriptor.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
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
            // PrecodeTypeDescriptor (string) maxLength
            if(this.PrecodeTypeDescriptor != null && this.PrecodeTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PrecodeTypeDescriptor, length must be less than 306.", new [] { "PrecodeTypeDescriptor" });
            }

            // AssessedGradeLevelDescriptor (string) maxLength
            if(this.AssessedGradeLevelDescriptor != null && this.AssessedGradeLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessedGradeLevelDescriptor, length must be less than 306.", new [] { "AssessedGradeLevelDescriptor" });
            }

            // AssessmentTitle (string) maxLength
            if(this.AssessmentTitle != null && this.AssessmentTitle.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssessmentTitle, length must be less than 100.", new [] { "AssessmentTitle" });
            }

            // CustomGroup (string) maxLength
            if(this.CustomGroup != null && this.CustomGroup.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomGroup, length must be less than 100.", new [] { "CustomGroup" });
            }

            // EnrolledGradeLevelDescriptor (string) maxLength
            if(this.EnrolledGradeLevelDescriptor != null && this.EnrolledGradeLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EnrolledGradeLevelDescriptor, length must be less than 306.", new [] { "EnrolledGradeLevelDescriptor" });
            }

            // GeneralEnrollmentDescriptor (string) maxLength
            if(this.GeneralEnrollmentDescriptor != null && this.GeneralEnrollmentDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GeneralEnrollmentDescriptor, length must be less than 306.", new [] { "GeneralEnrollmentDescriptor" });
            }

            yield break;
        }
    }

}