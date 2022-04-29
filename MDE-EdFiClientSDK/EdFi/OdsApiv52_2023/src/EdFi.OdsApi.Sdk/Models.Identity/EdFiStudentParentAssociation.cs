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
    /// EdFiStudentParentAssociation
    /// </summary>
    [DataContract]
    public partial class EdFiStudentParentAssociation :  IEquatable<EdFiStudentParentAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentParentAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentParentAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentParentAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="parentReference">parentReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="contactPriority">The numeric order of the preferred sequence or priority of contact..</param>
        /// <param name="contactRestrictions">Restrictions for student and/or teacher contact with the individual (e.g., the student may not be picked up by the individual)..</param>
        /// <param name="emergencyContactStatus">Indicator of whether the person is a designated emergency contact for the Student..</param>
        /// <param name="legalGuardian">Indicator of whether the person is a legal guardian for the Student..</param>
        /// <param name="livesWith">Indicator of whether the Student lives with the associated parent..</param>
        /// <param name="primaryContactStatus">Indicator of whether the person is a primary parental contact for the Student..</param>
        /// <param name="relationDescriptor">The nature of an individual&#39;s relationship to a student, primarily used to capture family relationships..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStudentParentAssociation(string id = default(string), EdFiParentReference parentReference = default(EdFiParentReference), EdFiStudentReference studentReference = default(EdFiStudentReference), int? contactPriority = default(int?), string contactRestrictions = default(string), bool? emergencyContactStatus = default(bool?), bool? legalGuardian = default(bool?), bool? livesWith = default(bool?), bool? primaryContactStatus = default(bool?), string relationDescriptor = default(string), string etag = default(string))
        {
            // to ensure "parentReference" is required (not null)
            if (parentReference == null)
            {
                throw new InvalidDataException("parentReference is a required property for EdFiStudentParentAssociation and cannot be null");
            }
            else
            {
                this.ParentReference = parentReference;
            }
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new InvalidDataException("studentReference is a required property for EdFiStudentParentAssociation and cannot be null");
            }
            else
            {
                this.StudentReference = studentReference;
            }
            this.Id = id;
            this.ContactPriority = contactPriority;
            this.ContactRestrictions = contactRestrictions;
            this.EmergencyContactStatus = emergencyContactStatus;
            this.LegalGuardian = legalGuardian;
            this.LivesWith = livesWith;
            this.PrimaryContactStatus = primaryContactStatus;
            this.RelationDescriptor = relationDescriptor;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ParentReference
        /// </summary>
        [DataMember(Name="parentReference", EmitDefaultValue=false)]
        public EdFiParentReference ParentReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name="studentReference", EmitDefaultValue=false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// The numeric order of the preferred sequence or priority of contact.
        /// </summary>
        /// <value>The numeric order of the preferred sequence or priority of contact.</value>
        [DataMember(Name="contactPriority", EmitDefaultValue=false)]
        public int? ContactPriority { get; set; }

        /// <summary>
        /// Restrictions for student and/or teacher contact with the individual (e.g., the student may not be picked up by the individual).
        /// </summary>
        /// <value>Restrictions for student and/or teacher contact with the individual (e.g., the student may not be picked up by the individual).</value>
        [DataMember(Name="contactRestrictions", EmitDefaultValue=false)]
        public string ContactRestrictions { get; set; }

        /// <summary>
        /// Indicator of whether the person is a designated emergency contact for the Student.
        /// </summary>
        /// <value>Indicator of whether the person is a designated emergency contact for the Student.</value>
        [DataMember(Name="emergencyContactStatus", EmitDefaultValue=false)]
        public bool? EmergencyContactStatus { get; set; }

        /// <summary>
        /// Indicator of whether the person is a legal guardian for the Student.
        /// </summary>
        /// <value>Indicator of whether the person is a legal guardian for the Student.</value>
        [DataMember(Name="legalGuardian", EmitDefaultValue=false)]
        public bool? LegalGuardian { get; set; }

        /// <summary>
        /// Indicator of whether the Student lives with the associated parent.
        /// </summary>
        /// <value>Indicator of whether the Student lives with the associated parent.</value>
        [DataMember(Name="livesWith", EmitDefaultValue=false)]
        public bool? LivesWith { get; set; }

        /// <summary>
        /// Indicator of whether the person is a primary parental contact for the Student.
        /// </summary>
        /// <value>Indicator of whether the person is a primary parental contact for the Student.</value>
        [DataMember(Name="primaryContactStatus", EmitDefaultValue=false)]
        public bool? PrimaryContactStatus { get; set; }

        /// <summary>
        /// The nature of an individual&#39;s relationship to a student, primarily used to capture family relationships.
        /// </summary>
        /// <value>The nature of an individual&#39;s relationship to a student, primarily used to capture family relationships.</value>
        [DataMember(Name="relationDescriptor", EmitDefaultValue=false)]
        public string RelationDescriptor { get; set; }

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
            sb.Append("class EdFiStudentParentAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ParentReference: ").Append(ParentReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  ContactPriority: ").Append(ContactPriority).Append("\n");
            sb.Append("  ContactRestrictions: ").Append(ContactRestrictions).Append("\n");
            sb.Append("  EmergencyContactStatus: ").Append(EmergencyContactStatus).Append("\n");
            sb.Append("  LegalGuardian: ").Append(LegalGuardian).Append("\n");
            sb.Append("  LivesWith: ").Append(LivesWith).Append("\n");
            sb.Append("  PrimaryContactStatus: ").Append(PrimaryContactStatus).Append("\n");
            sb.Append("  RelationDescriptor: ").Append(RelationDescriptor).Append("\n");
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
            return this.Equals(input as EdFiStudentParentAssociation);
        }

        /// <summary>
        /// Returns true if EdFiStudentParentAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentParentAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentParentAssociation input)
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
                    this.ParentReference == input.ParentReference ||
                    (this.ParentReference != null &&
                    this.ParentReference.Equals(input.ParentReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.ContactPriority == input.ContactPriority ||
                    (this.ContactPriority != null &&
                    this.ContactPriority.Equals(input.ContactPriority))
                ) && 
                (
                    this.ContactRestrictions == input.ContactRestrictions ||
                    (this.ContactRestrictions != null &&
                    this.ContactRestrictions.Equals(input.ContactRestrictions))
                ) && 
                (
                    this.EmergencyContactStatus == input.EmergencyContactStatus ||
                    (this.EmergencyContactStatus != null &&
                    this.EmergencyContactStatus.Equals(input.EmergencyContactStatus))
                ) && 
                (
                    this.LegalGuardian == input.LegalGuardian ||
                    (this.LegalGuardian != null &&
                    this.LegalGuardian.Equals(input.LegalGuardian))
                ) && 
                (
                    this.LivesWith == input.LivesWith ||
                    (this.LivesWith != null &&
                    this.LivesWith.Equals(input.LivesWith))
                ) && 
                (
                    this.PrimaryContactStatus == input.PrimaryContactStatus ||
                    (this.PrimaryContactStatus != null &&
                    this.PrimaryContactStatus.Equals(input.PrimaryContactStatus))
                ) && 
                (
                    this.RelationDescriptor == input.RelationDescriptor ||
                    (this.RelationDescriptor != null &&
                    this.RelationDescriptor.Equals(input.RelationDescriptor))
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
                if (this.ParentReference != null)
                    hashCode = hashCode * 59 + this.ParentReference.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.ContactPriority != null)
                    hashCode = hashCode * 59 + this.ContactPriority.GetHashCode();
                if (this.ContactRestrictions != null)
                    hashCode = hashCode * 59 + this.ContactRestrictions.GetHashCode();
                if (this.EmergencyContactStatus != null)
                    hashCode = hashCode * 59 + this.EmergencyContactStatus.GetHashCode();
                if (this.LegalGuardian != null)
                    hashCode = hashCode * 59 + this.LegalGuardian.GetHashCode();
                if (this.LivesWith != null)
                    hashCode = hashCode * 59 + this.LivesWith.GetHashCode();
                if (this.PrimaryContactStatus != null)
                    hashCode = hashCode * 59 + this.PrimaryContactStatus.GetHashCode();
                if (this.RelationDescriptor != null)
                    hashCode = hashCode * 59 + this.RelationDescriptor.GetHashCode();
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
            // ContactRestrictions (string) maxLength
            if(this.ContactRestrictions != null && this.ContactRestrictions.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContactRestrictions, length must be less than 250.", new [] { "ContactRestrictions" });
            }

            // RelationDescriptor (string) maxLength
            if(this.RelationDescriptor != null && this.RelationDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RelationDescriptor, length must be less than 306.", new [] { "RelationDescriptor" });
            }

            yield break;
        }
    }

}
