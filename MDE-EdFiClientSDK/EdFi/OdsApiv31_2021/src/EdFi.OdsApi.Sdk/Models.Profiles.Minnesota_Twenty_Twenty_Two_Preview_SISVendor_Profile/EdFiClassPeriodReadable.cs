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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile
{
    /// <summary>
    /// EdFiClassPeriodReadable
    /// </summary>
    [DataContract]
    public partial class EdFiClassPeriodReadable :  IEquatable<EdFiClassPeriodReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiClassPeriodReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiClassPeriodReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiClassPeriodReadable" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="ClassPeriodName">An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules). (required).</param>
        /// <param name="SchoolReference">SchoolReference (required).</param>
        /// <param name="MeetingTimes">An unordered collection of classPeriodMeetingTimes. The meeting time(s) for a class period..</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="Ext">Ext.</param>
        public EdFiClassPeriodReadable(string Id = default(string), string ClassPeriodName = default(string), EdFiSchoolReference SchoolReference = default(EdFiSchoolReference), List<EdFiClassPeriodMeetingTimeReadable> MeetingTimes = default(List<EdFiClassPeriodMeetingTimeReadable>), string Etag = default(string), ClassPeriodExtensionsReadable Ext = default(ClassPeriodExtensionsReadable))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiClassPeriodReadable and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "ClassPeriodName" is required (not null)
            if (ClassPeriodName == null)
            {
                throw new InvalidDataException("ClassPeriodName is a required property for EdFiClassPeriodReadable and cannot be null");
            }
            else
            {
                this.ClassPeriodName = ClassPeriodName;
            }
            // to ensure "SchoolReference" is required (not null)
            if (SchoolReference == null)
            {
                throw new InvalidDataException("SchoolReference is a required property for EdFiClassPeriodReadable and cannot be null");
            }
            else
            {
                this.SchoolReference = SchoolReference;
            }
            this.MeetingTimes = MeetingTimes;
            this.Etag = Etag;
            this.Ext = Ext;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).
        /// </summary>
        /// <value>An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).</value>
        [DataMember(Name="classPeriodName", EmitDefaultValue=false)]
        public string ClassPeriodName { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name="schoolReference", EmitDefaultValue=false)]
        public EdFiSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// An unordered collection of classPeriodMeetingTimes. The meeting time(s) for a class period.
        /// </summary>
        /// <value>An unordered collection of classPeriodMeetingTimes. The meeting time(s) for a class period.</value>
        [DataMember(Name="meetingTimes", EmitDefaultValue=false)]
        public List<EdFiClassPeriodMeetingTimeReadable> MeetingTimes { get; set; }

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
        public ClassPeriodExtensionsReadable Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiClassPeriodReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ClassPeriodName: ").Append(ClassPeriodName).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  MeetingTimes: ").Append(MeetingTimes).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
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
            return this.Equals(input as EdFiClassPeriodReadable);
        }

        /// <summary>
        /// Returns true if EdFiClassPeriodReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiClassPeriodReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiClassPeriodReadable input)
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
                    this.ClassPeriodName == input.ClassPeriodName ||
                    (this.ClassPeriodName != null &&
                    this.ClassPeriodName.Equals(input.ClassPeriodName))
                ) && 
                (
                    this.SchoolReference == input.SchoolReference ||
                    (this.SchoolReference != null &&
                    this.SchoolReference.Equals(input.SchoolReference))
                ) && 
                (
                    this.MeetingTimes == input.MeetingTimes ||
                    this.MeetingTimes != null &&
                    this.MeetingTimes.SequenceEqual(input.MeetingTimes)
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
                if (this.ClassPeriodName != null)
                    hashCode = hashCode * 59 + this.ClassPeriodName.GetHashCode();
                if (this.SchoolReference != null)
                    hashCode = hashCode * 59 + this.SchoolReference.GetHashCode();
                if (this.MeetingTimes != null)
                    hashCode = hashCode * 59 + this.MeetingTimes.GetHashCode();
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
            // ClassPeriodName (string) maxLength
            if(this.ClassPeriodName != null && this.ClassPeriodName.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClassPeriodName, length must be less than 60.", new [] { "ClassPeriodName" });
            }

            yield break;
        }
    }

}
