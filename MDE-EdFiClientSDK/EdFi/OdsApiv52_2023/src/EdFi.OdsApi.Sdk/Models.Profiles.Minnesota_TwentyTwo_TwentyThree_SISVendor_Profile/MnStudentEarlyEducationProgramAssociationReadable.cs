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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_TwentyTwo_TwentyThree_SISVendor_Profile
{
    /// <summary>
    /// MnStudentEarlyEducationProgramAssociationReadable
    /// </summary>
    [DataContract]
    public partial class MnStudentEarlyEducationProgramAssociationReadable :  IEquatable<MnStudentEarlyEducationProgramAssociationReadable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentEarlyEducationProgramAssociationReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentEarlyEducationProgramAssociationReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentEarlyEducationProgramAssociationReadable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="beginDate">The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="programReference">programReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="fundingSources">An unordered collection of studentEarlyEducationProgramAssociationFundingSources. Funding source..</param>
        /// <param name="reasonExitedDescriptor">The reason the child left the Program within a school or district..</param>
        /// <param name="servedOutsideOfRegularSession">Indicates whether the Student received services during the summer session or between sessions..</param>
        /// <param name="serviceAttendanceHours">Indicates a student&#39;s service attendance hours..</param>
        /// <param name="serviceMembershipHours">Indicates a student&#39;s service membership hours..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public MnStudentEarlyEducationProgramAssociationReadable(string id = default(string), DateTime? beginDate = default(DateTime?), MnEducationOrganizationReference educationOrganizationReference = default(MnEducationOrganizationReference), MnProgramReference programReference = default(MnProgramReference), MnStudentReference studentReference = default(MnStudentReference), List<MnStudentEarlyEducationProgramAssociationFundingSourceReadable> fundingSources = default(List<MnStudentEarlyEducationProgramAssociationFundingSourceReadable>), string reasonExitedDescriptor = default(string), bool? servedOutsideOfRegularSession = default(bool?), int? serviceAttendanceHours = default(int?), int? serviceMembershipHours = default(int?), string etag = default(string))
        {
            // to ensure "beginDate" is required (not null)
            if (beginDate == null)
            {
                throw new InvalidDataException("beginDate is a required property for MnStudentEarlyEducationProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.BeginDate = beginDate;
            }
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new InvalidDataException("educationOrganizationReference is a required property for MnStudentEarlyEducationProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = educationOrganizationReference;
            }
            // to ensure "programReference" is required (not null)
            if (programReference == null)
            {
                throw new InvalidDataException("programReference is a required property for MnStudentEarlyEducationProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.ProgramReference = programReference;
            }
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new InvalidDataException("studentReference is a required property for MnStudentEarlyEducationProgramAssociationReadable and cannot be null");
            }
            else
            {
                this.StudentReference = studentReference;
            }
            this.Id = id;
            this.FundingSources = fundingSources;
            this.ReasonExitedDescriptor = reasonExitedDescriptor;
            this.ServedOutsideOfRegularSession = servedOutsideOfRegularSession;
            this.ServiceAttendanceHours = serviceAttendanceHours;
            this.ServiceMembershipHours = serviceMembershipHours;
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
        /// An unordered collection of studentEarlyEducationProgramAssociationFundingSources. Funding source.
        /// </summary>
        /// <value>An unordered collection of studentEarlyEducationProgramAssociationFundingSources. Funding source.</value>
        [DataMember(Name="fundingSources", EmitDefaultValue=false)]
        public List<MnStudentEarlyEducationProgramAssociationFundingSourceReadable> FundingSources { get; set; }

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
        /// Indicates a student&#39;s service attendance hours.
        /// </summary>
        /// <value>Indicates a student&#39;s service attendance hours.</value>
        [DataMember(Name="serviceAttendanceHours", EmitDefaultValue=false)]
        public int? ServiceAttendanceHours { get; set; }

        /// <summary>
        /// Indicates a student&#39;s service membership hours.
        /// </summary>
        /// <value>Indicates a student&#39;s service membership hours.</value>
        [DataMember(Name="serviceMembershipHours", EmitDefaultValue=false)]
        public int? ServiceMembershipHours { get; set; }

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
            sb.Append("class MnStudentEarlyEducationProgramAssociationReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  ProgramReference: ").Append(ProgramReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  FundingSources: ").Append(FundingSources).Append("\n");
            sb.Append("  ReasonExitedDescriptor: ").Append(ReasonExitedDescriptor).Append("\n");
            sb.Append("  ServedOutsideOfRegularSession: ").Append(ServedOutsideOfRegularSession).Append("\n");
            sb.Append("  ServiceAttendanceHours: ").Append(ServiceAttendanceHours).Append("\n");
            sb.Append("  ServiceMembershipHours: ").Append(ServiceMembershipHours).Append("\n");
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
            return this.Equals(input as MnStudentEarlyEducationProgramAssociationReadable);
        }

        /// <summary>
        /// Returns true if MnStudentEarlyEducationProgramAssociationReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentEarlyEducationProgramAssociationReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentEarlyEducationProgramAssociationReadable input)
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
                    this.FundingSources == input.FundingSources ||
                    this.FundingSources != null &&
                    this.FundingSources.SequenceEqual(input.FundingSources)
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
                    this.ServiceAttendanceHours == input.ServiceAttendanceHours ||
                    (this.ServiceAttendanceHours != null &&
                    this.ServiceAttendanceHours.Equals(input.ServiceAttendanceHours))
                ) && 
                (
                    this.ServiceMembershipHours == input.ServiceMembershipHours ||
                    (this.ServiceMembershipHours != null &&
                    this.ServiceMembershipHours.Equals(input.ServiceMembershipHours))
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
                if (this.FundingSources != null)
                    hashCode = hashCode * 59 + this.FundingSources.GetHashCode();
                if (this.ReasonExitedDescriptor != null)
                    hashCode = hashCode * 59 + this.ReasonExitedDescriptor.GetHashCode();
                if (this.ServedOutsideOfRegularSession != null)
                    hashCode = hashCode * 59 + this.ServedOutsideOfRegularSession.GetHashCode();
                if (this.ServiceAttendanceHours != null)
                    hashCode = hashCode * 59 + this.ServiceAttendanceHours.GetHashCode();
                if (this.ServiceMembershipHours != null)
                    hashCode = hashCode * 59 + this.ServiceMembershipHours.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
