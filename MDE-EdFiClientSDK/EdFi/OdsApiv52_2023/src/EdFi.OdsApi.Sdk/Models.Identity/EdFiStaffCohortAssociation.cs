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
    /// EdFiStaffCohortAssociation
    /// </summary>
    [DataContract]
    public partial class EdFiStaffCohortAssociation :  IEquatable<EdFiStaffCohortAssociation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffCohortAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStaffCohortAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffCohortAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="beginDate">Start date for the association of staff to this cohort. (required).</param>
        /// <param name="cohortReference">cohortReference (required).</param>
        /// <param name="staffReference">staffReference (required).</param>
        /// <param name="endDate">End date for the association of staff to this cohort..</param>
        /// <param name="studentRecordAccess">Indicator of whether the staff has access to the student records of the cohort per district interpretation of FERPA and other privacy laws, regulations, and policies..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStaffCohortAssociation(string id = default(string), DateTime? beginDate = default(DateTime?), EdFiCohortReference cohortReference = default(EdFiCohortReference), EdFiStaffReference staffReference = default(EdFiStaffReference), DateTime? endDate = default(DateTime?), bool? studentRecordAccess = default(bool?), string etag = default(string))
        {
            // to ensure "beginDate" is required (not null)
            if (beginDate == null)
            {
                throw new InvalidDataException("beginDate is a required property for EdFiStaffCohortAssociation and cannot be null");
            }
            else
            {
                this.BeginDate = beginDate;
            }
            // to ensure "cohortReference" is required (not null)
            if (cohortReference == null)
            {
                throw new InvalidDataException("cohortReference is a required property for EdFiStaffCohortAssociation and cannot be null");
            }
            else
            {
                this.CohortReference = cohortReference;
            }
            // to ensure "staffReference" is required (not null)
            if (staffReference == null)
            {
                throw new InvalidDataException("staffReference is a required property for EdFiStaffCohortAssociation and cannot be null");
            }
            else
            {
                this.StaffReference = staffReference;
            }
            this.Id = id;
            this.EndDate = endDate;
            this.StudentRecordAccess = studentRecordAccess;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Start date for the association of staff to this cohort.
        /// </summary>
        /// <value>Start date for the association of staff to this cohort.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// Gets or Sets CohortReference
        /// </summary>
        [DataMember(Name="cohortReference", EmitDefaultValue=false)]
        public EdFiCohortReference CohortReference { get; set; }

        /// <summary>
        /// Gets or Sets StaffReference
        /// </summary>
        [DataMember(Name="staffReference", EmitDefaultValue=false)]
        public EdFiStaffReference StaffReference { get; set; }

        /// <summary>
        /// End date for the association of staff to this cohort.
        /// </summary>
        /// <value>End date for the association of staff to this cohort.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Indicator of whether the staff has access to the student records of the cohort per district interpretation of FERPA and other privacy laws, regulations, and policies.
        /// </summary>
        /// <value>Indicator of whether the staff has access to the student records of the cohort per district interpretation of FERPA and other privacy laws, regulations, and policies.</value>
        [DataMember(Name="studentRecordAccess", EmitDefaultValue=false)]
        public bool? StudentRecordAccess { get; set; }

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
            sb.Append("class EdFiStaffCohortAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  CohortReference: ").Append(CohortReference).Append("\n");
            sb.Append("  StaffReference: ").Append(StaffReference).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  StudentRecordAccess: ").Append(StudentRecordAccess).Append("\n");
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
            return this.Equals(input as EdFiStaffCohortAssociation);
        }

        /// <summary>
        /// Returns true if EdFiStaffCohortAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStaffCohortAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStaffCohortAssociation input)
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
                    this.CohortReference == input.CohortReference ||
                    (this.CohortReference != null &&
                    this.CohortReference.Equals(input.CohortReference))
                ) && 
                (
                    this.StaffReference == input.StaffReference ||
                    (this.StaffReference != null &&
                    this.StaffReference.Equals(input.StaffReference))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.StudentRecordAccess == input.StudentRecordAccess ||
                    (this.StudentRecordAccess != null &&
                    this.StudentRecordAccess.Equals(input.StudentRecordAccess))
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
                if (this.CohortReference != null)
                    hashCode = hashCode * 59 + this.CohortReference.GetHashCode();
                if (this.StaffReference != null)
                    hashCode = hashCode * 59 + this.StaffReference.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.StudentRecordAccess != null)
                    hashCode = hashCode * 59 + this.StudentRecordAccess.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
