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
    /// EdFiStudentHomelessProgramAssociationReadable
    /// </summary>
    [DataContract]
    public partial class EdFiStudentHomelessProgramAssociationReadable :  IEquatable<EdFiStudentHomelessProgramAssociationReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentHomelessProgramAssociationReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentHomelessProgramAssociationReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentHomelessProgramAssociationReadable" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="BeginDate">The month, day, and year on which the Student first received services. (required).</param>
        /// <param name="EducationOrganizationReference">EducationOrganizationReference (required).</param>
        /// <param name="ProgramReference">ProgramReference (required).</param>
        /// <param name="StudentReference">StudentReference (required).</param>
        /// <param name="EndDate">The month, day, and year on which the Student exited the Program or stopped receiving services..</param>
        /// <param name="HomelessPrimaryNighttimeResidenceDescriptor">The primary nighttime residence of the student at the time the student is identified as homeless..</param>
        /// <param name="HomelessUnaccompaniedYouth">A homeless unaccompanied youth is a youth who is not in the physical custody of a parent or guardian and who fits the McKinney-Vento definition of homeless. Students must be both unaccompanied and homeless to be included as an unaccompanied homeless youth..</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStudentHomelessProgramAssociationReadable(string Id = default(string), DateTime? BeginDate = default(DateTime?), EdFiEducationOrganizationReference EducationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiProgramReference ProgramReference = default(EdFiProgramReference), EdFiStudentReference StudentReference = default(EdFiStudentReference), DateTime? EndDate = default(DateTime?), string HomelessPrimaryNighttimeResidenceDescriptor = default(string), bool? HomelessUnaccompaniedYouth = default(bool?), string Etag = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiStudentHomelessProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "BeginDate" is required (not null)
            if (BeginDate == null)
            {
                throw new InvalidDataException("BeginDate is a required property for EdFiStudentHomelessProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.BeginDate = BeginDate;
            }
            // to ensure "EducationOrganizationReference" is required (not null)
            if (EducationOrganizationReference == null)
            {
                throw new InvalidDataException("EducationOrganizationReference is a required property for EdFiStudentHomelessProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = EducationOrganizationReference;
            }
            // to ensure "ProgramReference" is required (not null)
            if (ProgramReference == null)
            {
                throw new InvalidDataException("ProgramReference is a required property for EdFiStudentHomelessProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.ProgramReference = ProgramReference;
            }
            // to ensure "StudentReference" is required (not null)
            if (StudentReference == null)
            {
                throw new InvalidDataException("StudentReference is a required property for EdFiStudentHomelessProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.StudentReference = StudentReference;
            }
            this.EndDate = EndDate;
            this.HomelessPrimaryNighttimeResidenceDescriptor = HomelessPrimaryNighttimeResidenceDescriptor;
            this.HomelessUnaccompaniedYouth = HomelessUnaccompaniedYouth;
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
        /// The primary nighttime residence of the student at the time the student is identified as homeless.
        /// </summary>
        /// <value>The primary nighttime residence of the student at the time the student is identified as homeless.</value>
        [DataMember(Name="homelessPrimaryNighttimeResidenceDescriptor", EmitDefaultValue=false)]
        public string HomelessPrimaryNighttimeResidenceDescriptor { get; set; }

        /// <summary>
        /// A homeless unaccompanied youth is a youth who is not in the physical custody of a parent or guardian and who fits the McKinney-Vento definition of homeless. Students must be both unaccompanied and homeless to be included as an unaccompanied homeless youth.
        /// </summary>
        /// <value>A homeless unaccompanied youth is a youth who is not in the physical custody of a parent or guardian and who fits the McKinney-Vento definition of homeless. Students must be both unaccompanied and homeless to be included as an unaccompanied homeless youth.</value>
        [DataMember(Name="homelessUnaccompaniedYouth", EmitDefaultValue=false)]
        public bool? HomelessUnaccompaniedYouth { get; set; }

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
            sb.Append("class EdFiStudentHomelessProgramAssociationReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  ProgramReference: ").Append(ProgramReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  HomelessPrimaryNighttimeResidenceDescriptor: ").Append(HomelessPrimaryNighttimeResidenceDescriptor).Append("\n");
            sb.Append("  HomelessUnaccompaniedYouth: ").Append(HomelessUnaccompaniedYouth).Append("\n");
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
            return this.Equals(input as EdFiStudentHomelessProgramAssociationReadable);
        }

        /// <summary>
        /// Returns true if EdFiStudentHomelessProgramAssociationReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentHomelessProgramAssociationReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentHomelessProgramAssociationReadable input)
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
                    this.HomelessPrimaryNighttimeResidenceDescriptor == input.HomelessPrimaryNighttimeResidenceDescriptor ||
                    (this.HomelessPrimaryNighttimeResidenceDescriptor != null &&
                    this.HomelessPrimaryNighttimeResidenceDescriptor.Equals(input.HomelessPrimaryNighttimeResidenceDescriptor))
                ) && 
                (
                    this.HomelessUnaccompaniedYouth == input.HomelessUnaccompaniedYouth ||
                    (this.HomelessUnaccompaniedYouth != null &&
                    this.HomelessUnaccompaniedYouth.Equals(input.HomelessUnaccompaniedYouth))
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
                if (this.HomelessPrimaryNighttimeResidenceDescriptor != null)
                    hashCode = hashCode * 59 + this.HomelessPrimaryNighttimeResidenceDescriptor.GetHashCode();
                if (this.HomelessUnaccompaniedYouth != null)
                    hashCode = hashCode * 59 + this.HomelessUnaccompaniedYouth.GetHashCode();
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
            // HomelessPrimaryNighttimeResidenceDescriptor (string) maxLength
            if(this.HomelessPrimaryNighttimeResidenceDescriptor != null && this.HomelessPrimaryNighttimeResidenceDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HomelessPrimaryNighttimeResidenceDescriptor, length must be less than 306.", new [] { "HomelessPrimaryNighttimeResidenceDescriptor" });
            }

            yield break;
        }
    }

}
