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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_SISVendor_Profile
{
    /// <summary>
    /// EdFiStudentLanguageInstructionProgramAssociationReadable
    /// </summary>
    [DataContract]
    public partial class EdFiStudentLanguageInstructionProgramAssociationReadable :  IEquatable<EdFiStudentLanguageInstructionProgramAssociationReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentLanguageInstructionProgramAssociationReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentLanguageInstructionProgramAssociationReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentLanguageInstructionProgramAssociationReadable" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="BeginDate">The month, day, and year on which the Student first received services. (required).</param>
        /// <param name="EducationOrganizationReference">EducationOrganizationReference (required).</param>
        /// <param name="ProgramReference">ProgramReference (required).</param>
        /// <param name="StudentReference">StudentReference (required).</param>
        /// <param name="EndDate">The month, day, and year on which the Student exited the Program or stopped receiving services..</param>
        /// <param name="EnglishLearnerParticipation">An indication that an English Learner student is served by an English language instruction educational program supported with Title III of ESEA funds..</param>
        /// <param name="LanguageInstructionProgramServices">An unordered collection of studentLanguageInstructionProgramAssociationLanguageInstructionProgramServices. Indicates the service(s) being provided to the Student by the Language Instruction Program..</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStudentLanguageInstructionProgramAssociationReadable(string Id = default(string), DateTime? BeginDate = default(DateTime?), EdFiEducationOrganizationReference EducationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiProgramReference ProgramReference = default(EdFiProgramReference), EdFiStudentReference StudentReference = default(EdFiStudentReference), DateTime? EndDate = default(DateTime?), bool? EnglishLearnerParticipation = default(bool?), List<EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable> LanguageInstructionProgramServices = default(List<EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable>), string Etag = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiStudentLanguageInstructionProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "BeginDate" is required (not null)
            if (BeginDate == null)
            {
                throw new InvalidDataException("BeginDate is a required property for EdFiStudentLanguageInstructionProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.BeginDate = BeginDate;
            }
            // to ensure "EducationOrganizationReference" is required (not null)
            if (EducationOrganizationReference == null)
            {
                throw new InvalidDataException("EducationOrganizationReference is a required property for EdFiStudentLanguageInstructionProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = EducationOrganizationReference;
            }
            // to ensure "ProgramReference" is required (not null)
            if (ProgramReference == null)
            {
                throw new InvalidDataException("ProgramReference is a required property for EdFiStudentLanguageInstructionProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.ProgramReference = ProgramReference;
            }
            // to ensure "StudentReference" is required (not null)
            if (StudentReference == null)
            {
                throw new InvalidDataException("StudentReference is a required property for EdFiStudentLanguageInstructionProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.StudentReference = StudentReference;
            }
            this.EndDate = EndDate;
            this.EnglishLearnerParticipation = EnglishLearnerParticipation;
            this.LanguageInstructionProgramServices = LanguageInstructionProgramServices;
            this.Etag = Etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The month, day, and year on which the Student first received services.
        /// </summary>
        /// <value>The month, day, and year on which the Student first received services.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name="educationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets ProgramReference
        /// </summary>
        [DataMember(Name="programReference", EmitDefaultValue=false)]
        public EdFiProgramReference ProgramReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name="studentReference", EmitDefaultValue=false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// The month, day, and year on which the Student exited the Program or stopped receiving services.
        /// </summary>
        /// <value>The month, day, and year on which the Student exited the Program or stopped receiving services.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// An indication that an English Learner student is served by an English language instruction educational program supported with Title III of ESEA funds.
        /// </summary>
        /// <value>An indication that an English Learner student is served by an English language instruction educational program supported with Title III of ESEA funds.</value>
        [DataMember(Name="englishLearnerParticipation", EmitDefaultValue=false)]
        public bool? EnglishLearnerParticipation { get; set; }

        /// <summary>
        /// An unordered collection of studentLanguageInstructionProgramAssociationLanguageInstructionProgramServices. Indicates the service(s) being provided to the Student by the Language Instruction Program.
        /// </summary>
        /// <value>An unordered collection of studentLanguageInstructionProgramAssociationLanguageInstructionProgramServices. Indicates the service(s) being provided to the Student by the Language Instruction Program.</value>
        [DataMember(Name="languageInstructionProgramServices", EmitDefaultValue=false)]
        public List<EdFiStudentLanguageInstructionProgramAssociationLanguageInstructionProgramServiceReadable> LanguageInstructionProgramServices { get; set; }

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
            sb.Append("class EdFiStudentLanguageInstructionProgramAssociationReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  ProgramReference: ").Append(ProgramReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  EnglishLearnerParticipation: ").Append(EnglishLearnerParticipation).Append("\n");
            sb.Append("  LanguageInstructionProgramServices: ").Append(LanguageInstructionProgramServices).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            return this.Equals(input as EdFiStudentLanguageInstructionProgramAssociationReadable);
        }

        /// <summary>
        /// Returns true if EdFiStudentLanguageInstructionProgramAssociationReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentLanguageInstructionProgramAssociationReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentLanguageInstructionProgramAssociationReadable input)
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
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.ProgramReference == input.ProgramReference ||
                    (this.ProgramReference != null &&
                    this.ProgramReference.Equals(input.ProgramReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.EnglishLearnerParticipation == input.EnglishLearnerParticipation ||
                    (this.EnglishLearnerParticipation != null &&
                    this.EnglishLearnerParticipation.Equals(input.EnglishLearnerParticipation))
                ) && 
                (
                    this.LanguageInstructionProgramServices == input.LanguageInstructionProgramServices ||
                    this.LanguageInstructionProgramServices != null &&
                    this.LanguageInstructionProgramServices.SequenceEqual(input.LanguageInstructionProgramServices)
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
                if (this.BeginDate != null)
                    hashCode = hashCode * 59 + this.BeginDate.GetHashCode();
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.ProgramReference != null)
                    hashCode = hashCode * 59 + this.ProgramReference.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.EnglishLearnerParticipation != null)
                    hashCode = hashCode * 59 + this.EnglishLearnerParticipation.GetHashCode();
                if (this.LanguageInstructionProgramServices != null)
                    hashCode = hashCode * 59 + this.LanguageInstructionProgramServices.GetHashCode();
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
            yield break;
        }
    }

}
