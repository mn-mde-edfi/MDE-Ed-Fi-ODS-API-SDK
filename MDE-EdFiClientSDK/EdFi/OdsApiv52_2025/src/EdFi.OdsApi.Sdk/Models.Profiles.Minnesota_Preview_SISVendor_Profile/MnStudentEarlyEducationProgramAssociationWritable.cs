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
    /// MnStudentEarlyEducationProgramAssociationWritable
    /// </summary>
    [DataContract(Name = "mn_studentEarlyEducationProgramAssociation_writable")]
    public partial class MnStudentEarlyEducationProgramAssociationWritable : IEquatable<MnStudentEarlyEducationProgramAssociationWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentEarlyEducationProgramAssociationWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentEarlyEducationProgramAssociationWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentEarlyEducationProgramAssociationWritable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="beginDate">The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="programReference">programReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="endDate">The month, day, and year on which the Student exited the Program or stopped receiving services..</param>
        /// <param name="fundingSources">An unordered collection of studentEarlyEducationProgramAssociationFundingSources. Funding source..</param>
        /// <param name="memberships">An unordered collection of studentEarlyEducationProgramAssociationMemberships. Entity containing Attendance Days or Hours, Membership Days or Hours, Percent Enrolled and flag indicated whether reported Membership and Attendance includes Days or Hours..</param>
        /// <param name="programSectionDescriptor">Descriptor of the program section..</param>
        /// <param name="reasonExitedDescriptor">The reason the child left the Program within a school or district..</param>
        /// <param name="servedOutsideOfRegularSession">Indicates whether the Student received services during the summer session or between sessions..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public MnStudentEarlyEducationProgramAssociationWritable(string id = default(string), DateTime beginDate = default(DateTime), MnEducationOrganizationReference educationOrganizationReference = default(MnEducationOrganizationReference), MnProgramReference programReference = default(MnProgramReference), MnStudentReference studentReference = default(MnStudentReference), DateTime endDate = default(DateTime), List<MnStudentEarlyEducationProgramAssociationFundingSourceWritable> fundingSources = default(List<MnStudentEarlyEducationProgramAssociationFundingSourceWritable>), List<MnStudentEarlyEducationProgramAssociationMembershipWritable> memberships = default(List<MnStudentEarlyEducationProgramAssociationMembershipWritable>), string programSectionDescriptor = default(string), string reasonExitedDescriptor = default(string), bool servedOutsideOfRegularSession = default(bool), string etag = default(string))
        {
            this.BeginDate = beginDate;
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new ArgumentNullException("educationOrganizationReference is a required property for MnStudentEarlyEducationProgramAssociationWritable and cannot be null");
            }
            this.EducationOrganizationReference = educationOrganizationReference;
            // to ensure "programReference" is required (not null)
            if (programReference == null)
            {
                throw new ArgumentNullException("programReference is a required property for MnStudentEarlyEducationProgramAssociationWritable and cannot be null");
            }
            this.ProgramReference = programReference;
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new ArgumentNullException("studentReference is a required property for MnStudentEarlyEducationProgramAssociationWritable and cannot be null");
            }
            this.StudentReference = studentReference;
            this.Id = id;
            this.EndDate = endDate;
            this.FundingSources = fundingSources;
            this.Memberships = memberships;
            this.ProgramSectionDescriptor = programSectionDescriptor;
            this.ReasonExitedDescriptor = reasonExitedDescriptor;
            this.ServedOutsideOfRegularSession = servedOutsideOfRegularSession;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.
        /// </summary>
        /// <value>The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.</value>
        [DataMember(Name = "beginDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name = "educationOrganizationReference", IsRequired = true, EmitDefaultValue = false)]
        public MnEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets ProgramReference
        /// </summary>
        [DataMember(Name = "programReference", IsRequired = true, EmitDefaultValue = false)]
        public MnProgramReference ProgramReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name = "studentReference", IsRequired = true, EmitDefaultValue = false)]
        public MnStudentReference StudentReference { get; set; }

        /// <summary>
        /// The month, day, and year on which the Student exited the Program or stopped receiving services.
        /// </summary>
        /// <value>The month, day, and year on which the Student exited the Program or stopped receiving services.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// An unordered collection of studentEarlyEducationProgramAssociationFundingSources. Funding source.
        /// </summary>
        /// <value>An unordered collection of studentEarlyEducationProgramAssociationFundingSources. Funding source.</value>
        [DataMember(Name = "fundingSources", EmitDefaultValue = false)]
        public List<MnStudentEarlyEducationProgramAssociationFundingSourceWritable> FundingSources { get; set; }

        /// <summary>
        /// An unordered collection of studentEarlyEducationProgramAssociationMemberships. Entity containing Attendance Days or Hours, Membership Days or Hours, Percent Enrolled and flag indicated whether reported Membership and Attendance includes Days or Hours.
        /// </summary>
        /// <value>An unordered collection of studentEarlyEducationProgramAssociationMemberships. Entity containing Attendance Days or Hours, Membership Days or Hours, Percent Enrolled and flag indicated whether reported Membership and Attendance includes Days or Hours.</value>
        [DataMember(Name = "memberships", EmitDefaultValue = false)]
        public List<MnStudentEarlyEducationProgramAssociationMembershipWritable> Memberships { get; set; }

        /// <summary>
        /// Descriptor of the program section.
        /// </summary>
        /// <value>Descriptor of the program section.</value>
        [DataMember(Name = "programSectionDescriptor", EmitDefaultValue = false)]
        public string ProgramSectionDescriptor { get; set; }

        /// <summary>
        /// The reason the child left the Program within a school or district.
        /// </summary>
        /// <value>The reason the child left the Program within a school or district.</value>
        [DataMember(Name = "reasonExitedDescriptor", EmitDefaultValue = false)]
        public string ReasonExitedDescriptor { get; set; }

        /// <summary>
        /// Indicates whether the Student received services during the summer session or between sessions.
        /// </summary>
        /// <value>Indicates whether the Student received services during the summer session or between sessions.</value>
        [DataMember(Name = "servedOutsideOfRegularSession", EmitDefaultValue = true)]
        public bool ServedOutsideOfRegularSession { get; set; }

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
            sb.Append("class MnStudentEarlyEducationProgramAssociationWritable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  ProgramReference: ").Append(ProgramReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  FundingSources: ").Append(FundingSources).Append("\n");
            sb.Append("  Memberships: ").Append(Memberships).Append("\n");
            sb.Append("  ProgramSectionDescriptor: ").Append(ProgramSectionDescriptor).Append("\n");
            sb.Append("  ReasonExitedDescriptor: ").Append(ReasonExitedDescriptor).Append("\n");
            sb.Append("  ServedOutsideOfRegularSession: ").Append(ServedOutsideOfRegularSession).Append("\n");
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
            return this.Equals(input as MnStudentEarlyEducationProgramAssociationWritable);
        }

        /// <summary>
        /// Returns true if MnStudentEarlyEducationProgramAssociationWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentEarlyEducationProgramAssociationWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentEarlyEducationProgramAssociationWritable input)
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
                    this.FundingSources == input.FundingSources ||
                    this.FundingSources != null &&
                    input.FundingSources != null &&
                    this.FundingSources.SequenceEqual(input.FundingSources)
                ) && 
                (
                    this.Memberships == input.Memberships ||
                    this.Memberships != null &&
                    input.Memberships != null &&
                    this.Memberships.SequenceEqual(input.Memberships)
                ) && 
                (
                    this.ProgramSectionDescriptor == input.ProgramSectionDescriptor ||
                    (this.ProgramSectionDescriptor != null &&
                    this.ProgramSectionDescriptor.Equals(input.ProgramSectionDescriptor))
                ) && 
                (
                    this.ReasonExitedDescriptor == input.ReasonExitedDescriptor ||
                    (this.ReasonExitedDescriptor != null &&
                    this.ReasonExitedDescriptor.Equals(input.ReasonExitedDescriptor))
                ) && 
                (
                    this.ServedOutsideOfRegularSession == input.ServedOutsideOfRegularSession ||
                    this.ServedOutsideOfRegularSession.Equals(input.ServedOutsideOfRegularSession)
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
                if (this.BeginDate != null)
                {
                    hashCode = (hashCode * 59) + this.BeginDate.GetHashCode();
                }
                if (this.EducationOrganizationReference != null)
                {
                    hashCode = (hashCode * 59) + this.EducationOrganizationReference.GetHashCode();
                }
                if (this.ProgramReference != null)
                {
                    hashCode = (hashCode * 59) + this.ProgramReference.GetHashCode();
                }
                if (this.StudentReference != null)
                {
                    hashCode = (hashCode * 59) + this.StudentReference.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.FundingSources != null)
                {
                    hashCode = (hashCode * 59) + this.FundingSources.GetHashCode();
                }
                if (this.Memberships != null)
                {
                    hashCode = (hashCode * 59) + this.Memberships.GetHashCode();
                }
                if (this.ProgramSectionDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.ProgramSectionDescriptor.GetHashCode();
                }
                if (this.ReasonExitedDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.ReasonExitedDescriptor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ServedOutsideOfRegularSession.GetHashCode();
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
            // ProgramSectionDescriptor (string) maxLength
            if (this.ProgramSectionDescriptor != null && this.ProgramSectionDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramSectionDescriptor, length must be less than 306.", new [] { "ProgramSectionDescriptor" });
            }

            // ReasonExitedDescriptor (string) maxLength
            if (this.ReasonExitedDescriptor != null && this.ReasonExitedDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReasonExitedDescriptor, length must be less than 306.", new [] { "ReasonExitedDescriptor" });
            }

            yield break;
        }
    }

}
