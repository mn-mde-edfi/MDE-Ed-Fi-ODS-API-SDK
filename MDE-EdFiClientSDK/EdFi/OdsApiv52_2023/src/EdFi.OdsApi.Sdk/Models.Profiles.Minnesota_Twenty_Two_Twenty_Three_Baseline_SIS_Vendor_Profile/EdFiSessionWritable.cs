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
    /// EdFiSessionWritable
    /// </summary>
    [DataContract]
    public partial class EdFiSessionWritable :  IEquatable<EdFiSessionWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSessionWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSessionWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSessionWritable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="sessionName">The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer). (required).</param>
        /// <param name="schoolReference">schoolReference (required).</param>
        /// <param name="schoolYearTypeReference">schoolYearTypeReference (required).</param>
        /// <param name="beginDate">Month, day, and year of the first day of the Session. (required).</param>
        /// <param name="endDate">Month, day and year of the last day of the Session. (required).</param>
        /// <param name="termDescriptor">An descriptor value indicating the term (e.g. &#39;Semester&#39;, &#39;Quarter&#39;, etc.). (required).</param>
        /// <param name="totalInstructionalDays">The total number of instructional days in the school calendar. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">ext.</param>
        public EdFiSessionWritable(string id = default(string), string sessionName = default(string), EdFiSchoolReference schoolReference = default(EdFiSchoolReference), EdFiSchoolYearTypeReference schoolYearTypeReference = default(EdFiSchoolYearTypeReference), DateTime? beginDate = default(DateTime?), DateTime? endDate = default(DateTime?), string termDescriptor = default(string), int? totalInstructionalDays = default(int?), string etag = default(string), SessionExtensionsWritable ext = default(SessionExtensionsWritable))
        {
            // to ensure "sessionName" is required (not null)
            if (sessionName == null)
            {
                throw new InvalidDataException("sessionName is a required property for EdFiSessionWritable and cannot be null");
            }
            else
            {
                this.SessionName = sessionName;
            }
            // to ensure "schoolReference" is required (not null)
            if (schoolReference == null)
            {
                throw new InvalidDataException("schoolReference is a required property for EdFiSessionWritable and cannot be null");
            }
            else
            {
                this.SchoolReference = schoolReference;
            }
            // to ensure "schoolYearTypeReference" is required (not null)
            if (schoolYearTypeReference == null)
            {
                throw new InvalidDataException("schoolYearTypeReference is a required property for EdFiSessionWritable and cannot be null");
            }
            else
            {
                this.SchoolYearTypeReference = schoolYearTypeReference;
            }
            // to ensure "beginDate" is required (not null)
            if (beginDate == null)
            {
                throw new InvalidDataException("beginDate is a required property for EdFiSessionWritable and cannot be null");
            }
            else
            {
                this.BeginDate = beginDate;
            }
            // to ensure "endDate" is required (not null)
            if (endDate == null)
            {
                throw new InvalidDataException("endDate is a required property for EdFiSessionWritable and cannot be null");
            }
            else
            {
                this.EndDate = endDate;
            }
            // to ensure "termDescriptor" is required (not null)
            if (termDescriptor == null)
            {
                throw new InvalidDataException("termDescriptor is a required property for EdFiSessionWritable and cannot be null");
            }
            else
            {
                this.TermDescriptor = termDescriptor;
            }
            // to ensure "totalInstructionalDays" is required (not null)
            if (totalInstructionalDays == null)
            {
                throw new InvalidDataException("totalInstructionalDays is a required property for EdFiSessionWritable and cannot be null");
            }
            else
            {
                this.TotalInstructionalDays = totalInstructionalDays;
            }
            this.Id = id;
            this.Etag = etag;
            this.Ext = ext;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer).
        /// </summary>
        /// <value>The identifier for the calendar for the academic session (e.g., 2010/11, 2011 Summer).</value>
        [DataMember(Name="sessionName", EmitDefaultValue=false)]
        public string SessionName { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name="schoolReference", EmitDefaultValue=false)]
        public EdFiSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// Gets or Sets SchoolYearTypeReference
        /// </summary>
        [DataMember(Name="schoolYearTypeReference", EmitDefaultValue=false)]
        public EdFiSchoolYearTypeReference SchoolYearTypeReference { get; set; }

        /// <summary>
        /// Month, day, and year of the first day of the Session.
        /// </summary>
        /// <value>Month, day, and year of the first day of the Session.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// Month, day and year of the last day of the Session.
        /// </summary>
        /// <value>Month, day and year of the last day of the Session.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// An descriptor value indicating the term (e.g. &#39;Semester&#39;, &#39;Quarter&#39;, etc.).
        /// </summary>
        /// <value>An descriptor value indicating the term (e.g. &#39;Semester&#39;, &#39;Quarter&#39;, etc.).</value>
        [DataMember(Name="termDescriptor", EmitDefaultValue=false)]
        public string TermDescriptor { get; set; }

        /// <summary>
        /// The total number of instructional days in the school calendar.
        /// </summary>
        /// <value>The total number of instructional days in the school calendar.</value>
        [DataMember(Name="totalInstructionalDays", EmitDefaultValue=false)]
        public int? TotalInstructionalDays { get; set; }

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
        public SessionExtensionsWritable Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiSessionWritable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SessionName: ").Append(SessionName).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  SchoolYearTypeReference: ").Append(SchoolYearTypeReference).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  TermDescriptor: ").Append(TermDescriptor).Append("\n");
            sb.Append("  TotalInstructionalDays: ").Append(TotalInstructionalDays).Append("\n");
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
            return this.Equals(input as EdFiSessionWritable);
        }

        /// <summary>
        /// Returns true if EdFiSessionWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSessionWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSessionWritable input)
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
                    this.SessionName == input.SessionName ||
                    (this.SessionName != null &&
                    this.SessionName.Equals(input.SessionName))
                ) && 
                (
                    this.SchoolReference == input.SchoolReference ||
                    (this.SchoolReference != null &&
                    this.SchoolReference.Equals(input.SchoolReference))
                ) && 
                (
                    this.SchoolYearTypeReference == input.SchoolYearTypeReference ||
                    (this.SchoolYearTypeReference != null &&
                    this.SchoolYearTypeReference.Equals(input.SchoolYearTypeReference))
                ) && 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.TermDescriptor == input.TermDescriptor ||
                    (this.TermDescriptor != null &&
                    this.TermDescriptor.Equals(input.TermDescriptor))
                ) && 
                (
                    this.TotalInstructionalDays == input.TotalInstructionalDays ||
                    (this.TotalInstructionalDays != null &&
                    this.TotalInstructionalDays.Equals(input.TotalInstructionalDays))
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
                if (this.SessionName != null)
                    hashCode = hashCode * 59 + this.SessionName.GetHashCode();
                if (this.SchoolReference != null)
                    hashCode = hashCode * 59 + this.SchoolReference.GetHashCode();
                if (this.SchoolYearTypeReference != null)
                    hashCode = hashCode * 59 + this.SchoolYearTypeReference.GetHashCode();
                if (this.BeginDate != null)
                    hashCode = hashCode * 59 + this.BeginDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.TermDescriptor != null)
                    hashCode = hashCode * 59 + this.TermDescriptor.GetHashCode();
                if (this.TotalInstructionalDays != null)
                    hashCode = hashCode * 59 + this.TotalInstructionalDays.GetHashCode();
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
            // SessionName (string) maxLength
            if(this.SessionName != null && this.SessionName.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SessionName, length must be less than 60.", new [] { "SessionName" });
            }

            // TermDescriptor (string) maxLength
            if(this.TermDescriptor != null && this.TermDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TermDescriptor, length must be less than 306.", new [] { "TermDescriptor" });
            }

            yield break;
        }
    }

}
