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
    /// EdFiStaffSectionAssociationReadable
    /// </summary>
    [DataContract]
    public partial class EdFiStaffSectionAssociationReadable :  IEquatable<EdFiStaffSectionAssociationReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffSectionAssociationReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStaffSectionAssociationReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffSectionAssociationReadable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="sectionReference">sectionReference (required).</param>
        /// <param name="staffReference">staffReference (required).</param>
        /// <param name="classroomPositionDescriptor">The type of position the Staff member holds in the specific class/section; for example:         Teacher of Record, Assistant Teacher, Support Teacher, Substitute Teacher... (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStaffSectionAssociationReadable(string id = default(string), EdFiSectionReference sectionReference = default(EdFiSectionReference), EdFiStaffReference staffReference = default(EdFiStaffReference), string classroomPositionDescriptor = default(string), string etag = default(string))
        {
            // to ensure "sectionReference" is required (not null)
            if (sectionReference == null)
            {
                throw new InvalidDataException("sectionReference is a required property for EdFiStaffSectionAssociationReadable and cannot be null");
            }
            else
            {
                this.SectionReference = sectionReference;
            }
            // to ensure "staffReference" is required (not null)
            if (staffReference == null)
            {
                throw new InvalidDataException("staffReference is a required property for EdFiStaffSectionAssociationReadable and cannot be null");
            }
            else
            {
                this.StaffReference = staffReference;
            }
            // to ensure "classroomPositionDescriptor" is required (not null)
            if (classroomPositionDescriptor == null)
            {
                throw new InvalidDataException("classroomPositionDescriptor is a required property for EdFiStaffSectionAssociationReadable and cannot be null");
            }
            else
            {
                this.ClassroomPositionDescriptor = classroomPositionDescriptor;
            }
            this.Id = id;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets SectionReference
        /// </summary>
        [DataMember(Name="sectionReference", EmitDefaultValue=false)]
        public EdFiSectionReference SectionReference { get; set; }

        /// <summary>
        /// Gets or Sets StaffReference
        /// </summary>
        [DataMember(Name="staffReference", EmitDefaultValue=false)]
        public EdFiStaffReference StaffReference { get; set; }

        /// <summary>
        /// The type of position the Staff member holds in the specific class/section; for example:         Teacher of Record, Assistant Teacher, Support Teacher, Substitute Teacher...
        /// </summary>
        /// <value>The type of position the Staff member holds in the specific class/section; for example:         Teacher of Record, Assistant Teacher, Support Teacher, Substitute Teacher...</value>
        [DataMember(Name="classroomPositionDescriptor", EmitDefaultValue=false)]
        public string ClassroomPositionDescriptor { get; set; }

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
            sb.Append("class EdFiStaffSectionAssociationReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SectionReference: ").Append(SectionReference).Append("\n");
            sb.Append("  StaffReference: ").Append(StaffReference).Append("\n");
            sb.Append("  ClassroomPositionDescriptor: ").Append(ClassroomPositionDescriptor).Append("\n");
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
            return this.Equals(input as EdFiStaffSectionAssociationReadable);
        }

        /// <summary>
        /// Returns true if EdFiStaffSectionAssociationReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStaffSectionAssociationReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStaffSectionAssociationReadable input)
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
                    this.SectionReference == input.SectionReference ||
                    (this.SectionReference != null &&
                    this.SectionReference.Equals(input.SectionReference))
                ) && 
                (
                    this.StaffReference == input.StaffReference ||
                    (this.StaffReference != null &&
                    this.StaffReference.Equals(input.StaffReference))
                ) && 
                (
                    this.ClassroomPositionDescriptor == input.ClassroomPositionDescriptor ||
                    (this.ClassroomPositionDescriptor != null &&
                    this.ClassroomPositionDescriptor.Equals(input.ClassroomPositionDescriptor))
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
                if (this.SectionReference != null)
                    hashCode = hashCode * 59 + this.SectionReference.GetHashCode();
                if (this.StaffReference != null)
                    hashCode = hashCode * 59 + this.StaffReference.GetHashCode();
                if (this.ClassroomPositionDescriptor != null)
                    hashCode = hashCode * 59 + this.ClassroomPositionDescriptor.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
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
            // ClassroomPositionDescriptor (string) maxLength
            if(this.ClassroomPositionDescriptor != null && this.ClassroomPositionDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClassroomPositionDescriptor, length must be less than 306.", new [] { "ClassroomPositionDescriptor" });
            }

            yield break;
        }
    }

}
