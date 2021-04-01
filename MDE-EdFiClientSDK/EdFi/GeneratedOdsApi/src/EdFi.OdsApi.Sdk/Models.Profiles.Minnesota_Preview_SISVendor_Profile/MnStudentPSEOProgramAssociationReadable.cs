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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile
{
    /// <summary>
    /// MnStudentPSEOProgramAssociationReadable
    /// </summary>
    [DataContract]
    public partial class MnStudentPSEOProgramAssociationReadable :  IEquatable<MnStudentPSEOProgramAssociationReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentPSEOProgramAssociationReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentPSEOProgramAssociationReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentPSEOProgramAssociationReadable" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="BeginDate">The month, day, and year on which the Student first received services. (required).</param>
        /// <param name="EducationOrganizationReference">EducationOrganizationReference (required).</param>
        /// <param name="ProgramReference">ProgramReference (required).</param>
        /// <param name="StudentReference">StudentReference (required).</param>
        /// <param name="EndDate">The month, day, and year on which the Student exited the Program or stopped receiving services..</param>
        /// <param name="PseoHighSchoolHours">Indicates PSEO High School Hours..</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        public MnStudentPSEOProgramAssociationReadable(string Id = default(string), DateTime? BeginDate = default(DateTime?), MnEducationOrganizationReference EducationOrganizationReference = default(MnEducationOrganizationReference), MnProgramReference ProgramReference = default(MnProgramReference), MnStudentReference StudentReference = default(MnStudentReference), DateTime? EndDate = default(DateTime?), int? PseoHighSchoolHours = default(int?), string Etag = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for MnStudentPSEOProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "BeginDate" is required (not null)
            if (BeginDate == null)
            {
                throw new InvalidDataException("BeginDate is a required property for MnStudentPSEOProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.BeginDate = BeginDate;
            }
            // to ensure "EducationOrganizationReference" is required (not null)
            if (EducationOrganizationReference == null)
            {
                throw new InvalidDataException("EducationOrganizationReference is a required property for MnStudentPSEOProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = EducationOrganizationReference;
            }
            // to ensure "ProgramReference" is required (not null)
            if (ProgramReference == null)
            {
                throw new InvalidDataException("ProgramReference is a required property for MnStudentPSEOProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.ProgramReference = ProgramReference;
            }
            // to ensure "StudentReference" is required (not null)
            if (StudentReference == null)
            {
                throw new InvalidDataException("StudentReference is a required property for MnStudentPSEOProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.StudentReference = StudentReference;
            }
            this.EndDate = EndDate;
            this.PseoHighSchoolHours = PseoHighSchoolHours;
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
        public MnEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets ProgramReference
        /// </summary>
        [DataMember(Name="programReference", EmitDefaultValue=false)]
        public MnProgramReference ProgramReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name="studentReference", EmitDefaultValue=false)]
        public MnStudentReference StudentReference { get; set; }

        /// <summary>
        /// The month, day, and year on which the Student exited the Program or stopped receiving services.
        /// </summary>
        /// <value>The month, day, and year on which the Student exited the Program or stopped receiving services.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Indicates PSEO High School Hours.
        /// </summary>
        /// <value>Indicates PSEO High School Hours.</value>
        [DataMember(Name="pseoHighSchoolHours", EmitDefaultValue=false)]
        public int? PseoHighSchoolHours { get; set; }

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
            sb.Append("class MnStudentPSEOProgramAssociationReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  ProgramReference: ").Append(ProgramReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  PseoHighSchoolHours: ").Append(PseoHighSchoolHours).Append("\n");
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
            return this.Equals(input as MnStudentPSEOProgramAssociationReadable);
        }

        /// <summary>
        /// Returns true if MnStudentPSEOProgramAssociationReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentPSEOProgramAssociationReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentPSEOProgramAssociationReadable input)
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
                    this.PseoHighSchoolHours == input.PseoHighSchoolHours ||
                    (this.PseoHighSchoolHours != null &&
                    this.PseoHighSchoolHours.Equals(input.PseoHighSchoolHours))
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
                if (this.PseoHighSchoolHours != null)
                    hashCode = hashCode * 59 + this.PseoHighSchoolHours.GetHashCode();
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
