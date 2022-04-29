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

namespace EdFi.OdsApi.Sdk.Models.Identity
{
    /// <summary>
    /// EdFiCalendar
    /// </summary>
    [DataContract]
    public partial class EdFiCalendar :  IEquatable<EdFiCalendar>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCalendar" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCalendar() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCalendar" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="calendarCode">The identifier for the Calendar. (required).</param>
        /// <param name="schoolReference">schoolReference (required).</param>
        /// <param name="schoolYearTypeReference">schoolYearTypeReference (required).</param>
        /// <param name="calendarTypeDescriptor">Indicates the type of Calendar. (required).</param>
        /// <param name="gradeLevels">An unordered collection of calendarGradeLevels. Indicates the GradeLevel associated with the Calendar..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">ext.</param>
        public EdFiCalendar(string id = default(string), string calendarCode = default(string), EdFiSchoolReference schoolReference = default(EdFiSchoolReference), EdFiSchoolYearTypeReference schoolYearTypeReference = default(EdFiSchoolYearTypeReference), string calendarTypeDescriptor = default(string), List<EdFiCalendarGradeLevel> gradeLevels = default(List<EdFiCalendarGradeLevel>), string etag = default(string), CalendarExtensions ext = default(CalendarExtensions))
        {
            // to ensure "calendarCode" is required (not null)
            if (calendarCode == null)
            {
                throw new InvalidDataException("calendarCode is a required property for EdFiCalendar and cannot be null");
            }
            else
            {
                this.CalendarCode = calendarCode;
            }
            // to ensure "schoolReference" is required (not null)
            if (schoolReference == null)
            {
                throw new InvalidDataException("schoolReference is a required property for EdFiCalendar and cannot be null");
            }
            else
            {
                this.SchoolReference = schoolReference;
            }
            // to ensure "schoolYearTypeReference" is required (not null)
            if (schoolYearTypeReference == null)
            {
                throw new InvalidDataException("schoolYearTypeReference is a required property for EdFiCalendar and cannot be null");
            }
            else
            {
                this.SchoolYearTypeReference = schoolYearTypeReference;
            }
            // to ensure "calendarTypeDescriptor" is required (not null)
            if (calendarTypeDescriptor == null)
            {
                throw new InvalidDataException("calendarTypeDescriptor is a required property for EdFiCalendar and cannot be null");
            }
            else
            {
                this.CalendarTypeDescriptor = calendarTypeDescriptor;
            }
            this.Id = id;
            this.GradeLevels = gradeLevels;
            this.Etag = etag;
            this.Ext = ext;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The identifier for the Calendar.
        /// </summary>
        /// <value>The identifier for the Calendar.</value>
        [DataMember(Name="calendarCode", EmitDefaultValue=false)]
        public string CalendarCode { get; set; }

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
        /// Indicates the type of Calendar.
        /// </summary>
        /// <value>Indicates the type of Calendar.</value>
        [DataMember(Name="calendarTypeDescriptor", EmitDefaultValue=false)]
        public string CalendarTypeDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of calendarGradeLevels. Indicates the GradeLevel associated with the Calendar.
        /// </summary>
        /// <value>An unordered collection of calendarGradeLevels. Indicates the GradeLevel associated with the Calendar.</value>
        [DataMember(Name="gradeLevels", EmitDefaultValue=false)]
        public List<EdFiCalendarGradeLevel> GradeLevels { get; set; }

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
        public CalendarExtensions Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiCalendar {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CalendarCode: ").Append(CalendarCode).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  SchoolYearTypeReference: ").Append(SchoolYearTypeReference).Append("\n");
            sb.Append("  CalendarTypeDescriptor: ").Append(CalendarTypeDescriptor).Append("\n");
            sb.Append("  GradeLevels: ").Append(GradeLevels).Append("\n");
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
            return this.Equals(input as EdFiCalendar);
        }

        /// <summary>
        /// Returns true if EdFiCalendar instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCalendar to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCalendar input)
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
                    this.CalendarCode == input.CalendarCode ||
                    (this.CalendarCode != null &&
                    this.CalendarCode.Equals(input.CalendarCode))
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
                    this.CalendarTypeDescriptor == input.CalendarTypeDescriptor ||
                    (this.CalendarTypeDescriptor != null &&
                    this.CalendarTypeDescriptor.Equals(input.CalendarTypeDescriptor))
                ) && 
                (
                    this.GradeLevels == input.GradeLevels ||
                    this.GradeLevels != null &&
                    this.GradeLevels.SequenceEqual(input.GradeLevels)
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
                if (this.CalendarCode != null)
                    hashCode = hashCode * 59 + this.CalendarCode.GetHashCode();
                if (this.SchoolReference != null)
                    hashCode = hashCode * 59 + this.SchoolReference.GetHashCode();
                if (this.SchoolYearTypeReference != null)
                    hashCode = hashCode * 59 + this.SchoolYearTypeReference.GetHashCode();
                if (this.CalendarTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.CalendarTypeDescriptor.GetHashCode();
                if (this.GradeLevels != null)
                    hashCode = hashCode * 59 + this.GradeLevels.GetHashCode();
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
            // CalendarCode (string) maxLength
            if(this.CalendarCode != null && this.CalendarCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CalendarCode, length must be less than 60.", new [] { "CalendarCode" });
            }

            // CalendarTypeDescriptor (string) maxLength
            if(this.CalendarTypeDescriptor != null && this.CalendarTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CalendarTypeDescriptor, length must be less than 306.", new [] { "CalendarTypeDescriptor" });
            }

            yield break;
        }
    }

}
