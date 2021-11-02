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
    /// EdFiStaffLeave
    /// </summary>
    [DataContract]
    public partial class EdFiStaffLeave :  IEquatable<EdFiStaffLeave>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffLeave" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStaffLeave() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffLeave" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="beginDate">The begin date of the staff leave. (required).</param>
        /// <param name="staffLeaveEventCategoryDescriptor">The code describing the type of leave taken, for example: Sick, Personal, Vacation. (required).</param>
        /// <param name="staffReference">staffReference (required).</param>
        /// <param name="endDate">The end date of the staff leave..</param>
        /// <param name="reason">Expanded reason for the staff leave..</param>
        /// <param name="substituteAssigned">Indicator of whether a substitute was assigned during the period of staff leave..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStaffLeave(string id = default(string), DateTime? beginDate = default(DateTime?), string staffLeaveEventCategoryDescriptor = default(string), EdFiStaffReference staffReference = default(EdFiStaffReference), DateTime? endDate = default(DateTime?), string reason = default(string), bool? substituteAssigned = default(bool?), string etag = default(string))
        {
            // to ensure "beginDate" is required (not null)
            if (beginDate == null)
            {
                throw new InvalidDataException("beginDate is a required property for EdFiStaffLeave and cannot be null");
            }
            else
            {
                this.BeginDate = beginDate;
            }
            // to ensure "staffLeaveEventCategoryDescriptor" is required (not null)
            if (staffLeaveEventCategoryDescriptor == null)
            {
                throw new InvalidDataException("staffLeaveEventCategoryDescriptor is a required property for EdFiStaffLeave and cannot be null");
            }
            else
            {
                this.StaffLeaveEventCategoryDescriptor = staffLeaveEventCategoryDescriptor;
            }
            // to ensure "staffReference" is required (not null)
            if (staffReference == null)
            {
                throw new InvalidDataException("staffReference is a required property for EdFiStaffLeave and cannot be null");
            }
            else
            {
                this.StaffReference = staffReference;
            }
            this.Id = id;
            this.EndDate = endDate;
            this.Reason = reason;
            this.SubstituteAssigned = substituteAssigned;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The begin date of the staff leave.
        /// </summary>
        /// <value>The begin date of the staff leave.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// The code describing the type of leave taken, for example: Sick, Personal, Vacation.
        /// </summary>
        /// <value>The code describing the type of leave taken, for example: Sick, Personal, Vacation.</value>
        [DataMember(Name="staffLeaveEventCategoryDescriptor", EmitDefaultValue=false)]
        public string StaffLeaveEventCategoryDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets StaffReference
        /// </summary>
        [DataMember(Name="staffReference", EmitDefaultValue=false)]
        public EdFiStaffReference StaffReference { get; set; }

        /// <summary>
        /// The end date of the staff leave.
        /// </summary>
        /// <value>The end date of the staff leave.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Expanded reason for the staff leave.
        /// </summary>
        /// <value>Expanded reason for the staff leave.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Indicator of whether a substitute was assigned during the period of staff leave.
        /// </summary>
        /// <value>Indicator of whether a substitute was assigned during the period of staff leave.</value>
        [DataMember(Name="substituteAssigned", EmitDefaultValue=false)]
        public bool? SubstituteAssigned { get; set; }

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
            sb.Append("class EdFiStaffLeave {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  StaffLeaveEventCategoryDescriptor: ").Append(StaffLeaveEventCategoryDescriptor).Append("\n");
            sb.Append("  StaffReference: ").Append(StaffReference).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  SubstituteAssigned: ").Append(SubstituteAssigned).Append("\n");
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
            return this.Equals(input as EdFiStaffLeave);
        }

        /// <summary>
        /// Returns true if EdFiStaffLeave instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStaffLeave to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStaffLeave input)
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
                    this.StaffLeaveEventCategoryDescriptor == input.StaffLeaveEventCategoryDescriptor ||
                    (this.StaffLeaveEventCategoryDescriptor != null &&
                    this.StaffLeaveEventCategoryDescriptor.Equals(input.StaffLeaveEventCategoryDescriptor))
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
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.SubstituteAssigned == input.SubstituteAssigned ||
                    (this.SubstituteAssigned != null &&
                    this.SubstituteAssigned.Equals(input.SubstituteAssigned))
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
                if (this.StaffLeaveEventCategoryDescriptor != null)
                    hashCode = hashCode * 59 + this.StaffLeaveEventCategoryDescriptor.GetHashCode();
                if (this.StaffReference != null)
                    hashCode = hashCode * 59 + this.StaffReference.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.SubstituteAssigned != null)
                    hashCode = hashCode * 59 + this.SubstituteAssigned.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
