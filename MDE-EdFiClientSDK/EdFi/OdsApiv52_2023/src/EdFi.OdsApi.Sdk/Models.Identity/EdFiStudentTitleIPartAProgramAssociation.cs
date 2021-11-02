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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = EdFi.OdsApi.Sdk.Client.SwaggerDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Identity
{
    /// <summary>
    /// EdFiStudentTitleIPartAProgramAssociation
    /// </summary>
    [DataContract]
    public partial class EdFiStudentTitleIPartAProgramAssociation :  IEquatable<EdFiStudentTitleIPartAProgramAssociation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentTitleIPartAProgramAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentTitleIPartAProgramAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentTitleIPartAProgramAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="beginDate">The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="programReference">programReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="endDate">The month, day, and year on which the Student exited the Program or stopped receiving services..</param>
        /// <param name="participationStatus">participationStatus.</param>
        /// <param name="programParticipationStatuses">An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation..</param>
        /// <param name="reasonExitedDescriptor">The reason the child left the Program within a school or district..</param>
        /// <param name="servedOutsideOfRegularSession">Indicates whether the Student received services during the summer session or between sessions..</param>
        /// <param name="services">An unordered collection of studentTitleIPartAProgramAssociationServices. Indicates the Service(s) being provided to the Student by the Program..</param>
        /// <param name="titleIPartAParticipantDescriptor">An indication of the type of Title I program, if any, in which the student is participating and by which the student is served:         Public Targeted Assistance Program         Public Schoolwide Program         Private School Students Participating         Local Neglected Program. (required).</param>
        /// <param name="titleIPartAProgramServices">An unordered collection of studentTitleIPartAProgramAssociationTitleIPartAProgramServices. Indicates the service(s) being provided to the Student by the Title I Part A Program..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStudentTitleIPartAProgramAssociation(string id = default(string), DateTime? beginDate = default(DateTime?), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiProgramReference programReference = default(EdFiProgramReference), EdFiStudentReference studentReference = default(EdFiStudentReference), DateTime? endDate = default(DateTime?), EdFiGeneralStudentProgramAssociationParticipationStatus participationStatus = default(EdFiGeneralStudentProgramAssociationParticipationStatus), List<EdFiGeneralStudentProgramAssociationProgramParticipationStatus> programParticipationStatuses = default(List<EdFiGeneralStudentProgramAssociationProgramParticipationStatus>), string reasonExitedDescriptor = default(string), bool? servedOutsideOfRegularSession = default(bool?), List<EdFiStudentTitleIPartAProgramAssociationService> services = default(List<EdFiStudentTitleIPartAProgramAssociationService>), string titleIPartAParticipantDescriptor = default(string), List<EdFiStudentTitleIPartAProgramAssociationTitleIPartAProgramService> titleIPartAProgramServices = default(List<EdFiStudentTitleIPartAProgramAssociationTitleIPartAProgramService>), string etag = default(string))
        {
            // to ensure "beginDate" is required (not null)
            if (beginDate == null)
            {
                throw new InvalidDataException("beginDate is a required property for EdFiStudentTitleIPartAProgramAssociation and cannot be null");
            }
            else
            {
                this.BeginDate = beginDate;
            }
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new InvalidDataException("educationOrganizationReference is a required property for EdFiStudentTitleIPartAProgramAssociation and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = educationOrganizationReference;
            }
            // to ensure "programReference" is required (not null)
            if (programReference == null)
            {
                throw new InvalidDataException("programReference is a required property for EdFiStudentTitleIPartAProgramAssociation and cannot be null");
            }
            else
            {
                this.ProgramReference = programReference;
            }
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new InvalidDataException("studentReference is a required property for EdFiStudentTitleIPartAProgramAssociation and cannot be null");
            }
            else
            {
                this.StudentReference = studentReference;
            }
            // to ensure "titleIPartAParticipantDescriptor" is required (not null)
            if (titleIPartAParticipantDescriptor == null)
            {
                throw new InvalidDataException("titleIPartAParticipantDescriptor is a required property for EdFiStudentTitleIPartAProgramAssociation and cannot be null");
            }
            else
            {
                this.TitleIPartAParticipantDescriptor = titleIPartAParticipantDescriptor;
            }
            this.Id = id;
            this.EndDate = endDate;
            this.ParticipationStatus = participationStatus;
            this.ProgramParticipationStatuses = programParticipationStatuses;
            this.ReasonExitedDescriptor = reasonExitedDescriptor;
            this.ServedOutsideOfRegularSession = servedOutsideOfRegularSession;
            this.Services = services;
            this.TitleIPartAProgramServices = titleIPartAProgramServices;
            this.Etag = etag;
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
        /// The month, day, and year on which the Student exited the Program or stopped receiving services.
        /// </summary>
        /// <value>The month, day, and year on which the Student exited the Program or stopped receiving services.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets ParticipationStatus
        /// </summary>
        [DataMember(Name="participationStatus", EmitDefaultValue=false)]
        public EdFiGeneralStudentProgramAssociationParticipationStatus ParticipationStatus { get; set; }

        /// <summary>
        /// An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation.
        /// </summary>
        /// <value>An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation.</value>
        [DataMember(Name="programParticipationStatuses", EmitDefaultValue=false)]
        public List<EdFiGeneralStudentProgramAssociationProgramParticipationStatus> ProgramParticipationStatuses { get; set; }

        /// <summary>
        /// The reason the child left the Program within a school or district.
        /// </summary>
        /// <value>The reason the child left the Program within a school or district.</value>
        [DataMember(Name="reasonExitedDescriptor", EmitDefaultValue=false)]
        public string ReasonExitedDescriptor { get; set; }

        /// <summary>
        /// Indicates whether the Student received services during the summer session or between sessions.
        /// </summary>
        /// <value>Indicates whether the Student received services during the summer session or between sessions.</value>
        [DataMember(Name="servedOutsideOfRegularSession", EmitDefaultValue=false)]
        public bool? ServedOutsideOfRegularSession { get; set; }

        /// <summary>
        /// An unordered collection of studentTitleIPartAProgramAssociationServices. Indicates the Service(s) being provided to the Student by the Program.
        /// </summary>
        /// <value>An unordered collection of studentTitleIPartAProgramAssociationServices. Indicates the Service(s) being provided to the Student by the Program.</value>
        [DataMember(Name="services", EmitDefaultValue=false)]
        public List<EdFiStudentTitleIPartAProgramAssociationService> Services { get; set; }

        /// <summary>
        /// An indication of the type of Title I program, if any, in which the student is participating and by which the student is served:         Public Targeted Assistance Program         Public Schoolwide Program         Private School Students Participating         Local Neglected Program.
        /// </summary>
        /// <value>An indication of the type of Title I program, if any, in which the student is participating and by which the student is served:         Public Targeted Assistance Program         Public Schoolwide Program         Private School Students Participating         Local Neglected Program.</value>
        [DataMember(Name="titleIPartAParticipantDescriptor", EmitDefaultValue=false)]
        public string TitleIPartAParticipantDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of studentTitleIPartAProgramAssociationTitleIPartAProgramServices. Indicates the service(s) being provided to the Student by the Title I Part A Program.
        /// </summary>
        /// <value>An unordered collection of studentTitleIPartAProgramAssociationTitleIPartAProgramServices. Indicates the service(s) being provided to the Student by the Title I Part A Program.</value>
        [DataMember(Name="titleIPartAProgramServices", EmitDefaultValue=false)]
        public List<EdFiStudentTitleIPartAProgramAssociationTitleIPartAProgramService> TitleIPartAProgramServices { get; set; }

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
            sb.Append("class EdFiStudentTitleIPartAProgramAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  ProgramReference: ").Append(ProgramReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ParticipationStatus: ").Append(ParticipationStatus).Append("\n");
            sb.Append("  ProgramParticipationStatuses: ").Append(ProgramParticipationStatuses).Append("\n");
            sb.Append("  ReasonExitedDescriptor: ").Append(ReasonExitedDescriptor).Append("\n");
            sb.Append("  ServedOutsideOfRegularSession: ").Append(ServedOutsideOfRegularSession).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  TitleIPartAParticipantDescriptor: ").Append(TitleIPartAParticipantDescriptor).Append("\n");
            sb.Append("  TitleIPartAProgramServices: ").Append(TitleIPartAProgramServices).Append("\n");
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
            return this.Equals(input as EdFiStudentTitleIPartAProgramAssociation);
        }

        /// <summary>
        /// Returns true if EdFiStudentTitleIPartAProgramAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentTitleIPartAProgramAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentTitleIPartAProgramAssociation input)
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
                    this.ParticipationStatus == input.ParticipationStatus ||
                    (this.ParticipationStatus != null &&
                    this.ParticipationStatus.Equals(input.ParticipationStatus))
                ) && 
                (
                    this.ProgramParticipationStatuses == input.ProgramParticipationStatuses ||
                    this.ProgramParticipationStatuses != null &&
                    this.ProgramParticipationStatuses.SequenceEqual(input.ProgramParticipationStatuses)
                ) && 
                (
                    this.ReasonExitedDescriptor == input.ReasonExitedDescriptor ||
                    (this.ReasonExitedDescriptor != null &&
                    this.ReasonExitedDescriptor.Equals(input.ReasonExitedDescriptor))
                ) && 
                (
                    this.ServedOutsideOfRegularSession == input.ServedOutsideOfRegularSession ||
                    (this.ServedOutsideOfRegularSession != null &&
                    this.ServedOutsideOfRegularSession.Equals(input.ServedOutsideOfRegularSession))
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    this.Services.SequenceEqual(input.Services)
                ) && 
                (
                    this.TitleIPartAParticipantDescriptor == input.TitleIPartAParticipantDescriptor ||
                    (this.TitleIPartAParticipantDescriptor != null &&
                    this.TitleIPartAParticipantDescriptor.Equals(input.TitleIPartAParticipantDescriptor))
                ) && 
                (
                    this.TitleIPartAProgramServices == input.TitleIPartAProgramServices ||
                    this.TitleIPartAProgramServices != null &&
                    this.TitleIPartAProgramServices.SequenceEqual(input.TitleIPartAProgramServices)
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
                if (this.ParticipationStatus != null)
                    hashCode = hashCode * 59 + this.ParticipationStatus.GetHashCode();
                if (this.ProgramParticipationStatuses != null)
                    hashCode = hashCode * 59 + this.ProgramParticipationStatuses.GetHashCode();
                if (this.ReasonExitedDescriptor != null)
                    hashCode = hashCode * 59 + this.ReasonExitedDescriptor.GetHashCode();
                if (this.ServedOutsideOfRegularSession != null)
                    hashCode = hashCode * 59 + this.ServedOutsideOfRegularSession.GetHashCode();
                if (this.Services != null)
                    hashCode = hashCode * 59 + this.Services.GetHashCode();
                if (this.TitleIPartAParticipantDescriptor != null)
                    hashCode = hashCode * 59 + this.TitleIPartAParticipantDescriptor.GetHashCode();
                if (this.TitleIPartAProgramServices != null)
                    hashCode = hashCode * 59 + this.TitleIPartAProgramServices.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
