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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Two_Twenty_Three_SISVendor_Profile
{
    /// <summary>
    /// MnStudentSAAPProgramAssociationWritable
    /// </summary>
    [DataContract(Name = "mn_studentSAAPProgramAssociation_writable")]
    public partial class MnStudentSAAPProgramAssociationWritable : IEquatable<MnStudentSAAPProgramAssociationWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentSAAPProgramAssociationWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MnStudentSAAPProgramAssociationWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MnStudentSAAPProgramAssociationWritable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="beginDate">The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="programReference">programReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="endDate">The month, day, and year on which the Student exited the Program or stopped receiving services..</param>
        /// <param name="independentStudyIndicator">State-approved alternative programs (SAAP) that also have a state-approved Independent Study(IS) component use this flag to identify independent study participants. (required).</param>
        /// <param name="saapConcurrentIndicator">An indicator representing a Student who is enrolled less than full-time at a traditional school and who is also enrolled at a State Approved Alternative Program (SAAP). (required).</param>
        /// <param name="saapCredits">SAAP Credits. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public MnStudentSAAPProgramAssociationWritable(string id = default(string), DateTime beginDate = default(DateTime), MnEducationOrganizationReference educationOrganizationReference = default(MnEducationOrganizationReference), MnProgramReference programReference = default(MnProgramReference), MnStudentReference studentReference = default(MnStudentReference), DateTime endDate = default(DateTime), bool independentStudyIndicator = default(bool), bool saapConcurrentIndicator = default(bool), double saapCredits = default(double), string etag = default(string))
        {
            this.BeginDate = beginDate;
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new ArgumentNullException("educationOrganizationReference is a required property for MnStudentSAAPProgramAssociationWritable and cannot be null");
            }
            this.EducationOrganizationReference = educationOrganizationReference;
            // to ensure "programReference" is required (not null)
            if (programReference == null)
            {
                throw new ArgumentNullException("programReference is a required property for MnStudentSAAPProgramAssociationWritable and cannot be null");
            }
            this.ProgramReference = programReference;
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new ArgumentNullException("studentReference is a required property for MnStudentSAAPProgramAssociationWritable and cannot be null");
            }
            this.StudentReference = studentReference;
            this.IndependentStudyIndicator = independentStudyIndicator;
            this.SaapConcurrentIndicator = saapConcurrentIndicator;
            this.SaapCredits = saapCredits;
            this.Id = id;
            this.EndDate = endDate;
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
        /// State-approved alternative programs (SAAP) that also have a state-approved Independent Study(IS) component use this flag to identify independent study participants.
        /// </summary>
        /// <value>State-approved alternative programs (SAAP) that also have a state-approved Independent Study(IS) component use this flag to identify independent study participants.</value>
        [DataMember(Name = "independentStudyIndicator", IsRequired = true, EmitDefaultValue = true)]
        public bool IndependentStudyIndicator { get; set; }

        /// <summary>
        /// An indicator representing a Student who is enrolled less than full-time at a traditional school and who is also enrolled at a State Approved Alternative Program (SAAP).
        /// </summary>
        /// <value>An indicator representing a Student who is enrolled less than full-time at a traditional school and who is also enrolled at a State Approved Alternative Program (SAAP).</value>
        [DataMember(Name = "saapConcurrentIndicator", IsRequired = true, EmitDefaultValue = true)]
        public bool SaapConcurrentIndicator { get; set; }

        /// <summary>
        /// SAAP Credits.
        /// </summary>
        /// <value>SAAP Credits.</value>
        [DataMember(Name = "saapCredits", IsRequired = true, EmitDefaultValue = false)]
        public double SaapCredits { get; set; }

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
            sb.Append("class MnStudentSAAPProgramAssociationWritable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  ProgramReference: ").Append(ProgramReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  IndependentStudyIndicator: ").Append(IndependentStudyIndicator).Append("\n");
            sb.Append("  SaapConcurrentIndicator: ").Append(SaapConcurrentIndicator).Append("\n");
            sb.Append("  SaapCredits: ").Append(SaapCredits).Append("\n");
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
            return this.Equals(input as MnStudentSAAPProgramAssociationWritable);
        }

        /// <summary>
        /// Returns true if MnStudentSAAPProgramAssociationWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of MnStudentSAAPProgramAssociationWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MnStudentSAAPProgramAssociationWritable input)
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
                    this.IndependentStudyIndicator == input.IndependentStudyIndicator ||
                    this.IndependentStudyIndicator.Equals(input.IndependentStudyIndicator)
                ) && 
                (
                    this.SaapConcurrentIndicator == input.SaapConcurrentIndicator ||
                    this.SaapConcurrentIndicator.Equals(input.SaapConcurrentIndicator)
                ) && 
                (
                    this.SaapCredits == input.SaapCredits ||
                    this.SaapCredits.Equals(input.SaapCredits)
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
                hashCode = (hashCode * 59) + this.IndependentStudyIndicator.GetHashCode();
                hashCode = (hashCode * 59) + this.SaapConcurrentIndicator.GetHashCode();
                hashCode = (hashCode * 59) + this.SaapCredits.GetHashCode();
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
            yield break;
        }
    }

}
