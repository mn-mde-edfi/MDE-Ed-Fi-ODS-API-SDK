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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Two_Twenty_Three_Baseline_SIS_Vendor_Profile
{
    /// <summary>
    /// EdFiStudentSpecialEducationProgramAssociationWritable
    /// </summary>
    [DataContract]
    public partial class EdFiStudentSpecialEducationProgramAssociationWritable :  IEquatable<EdFiStudentSpecialEducationProgramAssociationWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSpecialEducationProgramAssociationWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentSpecialEducationProgramAssociationWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentSpecialEducationProgramAssociationWritable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="beginDate">The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="programReference">programReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="disabilities">An unordered collection of studentSpecialEducationProgramAssociationDisabilities. The disability condition(s) that best describes an individual&#39;s impairment, as related to special education services received..</param>
        /// <param name="endDate">The month, day, and year on which the Student exited the Program or stopped receiving services..</param>
        /// <param name="specialEducationSettingDescriptor">The major instructional setting (more than 50 percent of a student&#39;s special education program)..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">ext.</param>
        public EdFiStudentSpecialEducationProgramAssociationWritable(string id = default(string), DateTime? beginDate = default(DateTime?), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiProgramReference programReference = default(EdFiProgramReference), EdFiStudentReference studentReference = default(EdFiStudentReference), List<EdFiStudentSpecialEducationProgramAssociationDisabilityWritable> disabilities = default(List<EdFiStudentSpecialEducationProgramAssociationDisabilityWritable>), DateTime? endDate = default(DateTime?), string specialEducationSettingDescriptor = default(string), string etag = default(string), StudentSpecialEducationProgramAssociationExtensionsWritable ext = default(StudentSpecialEducationProgramAssociationExtensionsWritable))
        {
            // to ensure "beginDate" is required (not null)
            if (beginDate == null)
            {
                throw new InvalidDataException("beginDate is a required property for EdFiStudentSpecialEducationProgramAssociationWritable and cannot be null");
            }
            else
            {
                this.BeginDate = beginDate;
            }
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new InvalidDataException("educationOrganizationReference is a required property for EdFiStudentSpecialEducationProgramAssociationWritable and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = educationOrganizationReference;
            }
            // to ensure "programReference" is required (not null)
            if (programReference == null)
            {
                throw new InvalidDataException("programReference is a required property for EdFiStudentSpecialEducationProgramAssociationWritable and cannot be null");
            }
            else
            {
                this.ProgramReference = programReference;
            }
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new InvalidDataException("studentReference is a required property for EdFiStudentSpecialEducationProgramAssociationWritable and cannot be null");
            }
            else
            {
                this.StudentReference = studentReference;
            }
            this.Id = id;
            this.Disabilities = disabilities;
            this.EndDate = endDate;
            this.SpecialEducationSettingDescriptor = specialEducationSettingDescriptor;
            this.Etag = etag;
            this.Ext = ext;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.
        /// </summary>
        /// <value>The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.</value>
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
        /// An unordered collection of studentSpecialEducationProgramAssociationDisabilities. The disability condition(s) that best describes an individual&#39;s impairment, as related to special education services received.
        /// </summary>
        /// <value>An unordered collection of studentSpecialEducationProgramAssociationDisabilities. The disability condition(s) that best describes an individual&#39;s impairment, as related to special education services received.</value>
        [DataMember(Name="disabilities", EmitDefaultValue=false)]
        public List<EdFiStudentSpecialEducationProgramAssociationDisabilityWritable> Disabilities { get; set; }

        /// <summary>
        /// The month, day, and year on which the Student exited the Program or stopped receiving services.
        /// </summary>
        /// <value>The month, day, and year on which the Student exited the Program or stopped receiving services.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The major instructional setting (more than 50 percent of a student&#39;s special education program).
        /// </summary>
        /// <value>The major instructional setting (more than 50 percent of a student&#39;s special education program).</value>
        [DataMember(Name="specialEducationSettingDescriptor", EmitDefaultValue=false)]
        public string SpecialEducationSettingDescriptor { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or Sets Ext
        /// </summary>
        [DataMember(Name="_ext", EmitDefaultValue=false)]
        public StudentSpecialEducationProgramAssociationExtensionsWritable Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentSpecialEducationProgramAssociationWritable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  ProgramReference: ").Append(ProgramReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  Disabilities: ").Append(Disabilities).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  SpecialEducationSettingDescriptor: ").Append(SpecialEducationSettingDescriptor).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
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
            return this.Equals(input as EdFiStudentSpecialEducationProgramAssociationWritable);
        }

        /// <summary>
        /// Returns true if EdFiStudentSpecialEducationProgramAssociationWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentSpecialEducationProgramAssociationWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentSpecialEducationProgramAssociationWritable input)
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
                    this.Disabilities == input.Disabilities ||
                    this.Disabilities != null &&
                    this.Disabilities.SequenceEqual(input.Disabilities)
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.SpecialEducationSettingDescriptor == input.SpecialEducationSettingDescriptor ||
                    (this.SpecialEducationSettingDescriptor != null &&
                    this.SpecialEducationSettingDescriptor.Equals(input.SpecialEducationSettingDescriptor))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.Ext == input.Ext ||
                    (this.Ext != null &&
                    this.Ext.Equals(input.Ext))
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
                if (this.Disabilities != null)
                    hashCode = hashCode * 59 + this.Disabilities.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.SpecialEducationSettingDescriptor != null)
                    hashCode = hashCode * 59 + this.SpecialEducationSettingDescriptor.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
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
            // SpecialEducationSettingDescriptor (string) maxLength
            if(this.SpecialEducationSettingDescriptor != null && this.SpecialEducationSettingDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SpecialEducationSettingDescriptor, length must be less than 306.", new [] { "SpecialEducationSettingDescriptor" });
            }

            yield break;
        }
    }

}
