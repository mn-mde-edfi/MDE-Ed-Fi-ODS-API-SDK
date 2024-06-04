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
    /// EdFiDisciplineActionReadable
    /// </summary>
    [DataContract(Name = "edFi_disciplineAction_readable")]
    public partial class EdFiDisciplineActionReadable : IEquatable<EdFiDisciplineActionReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiDisciplineActionReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiDisciplineActionReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiDisciplineActionReadable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="disciplineActionIdentifier">Identifier assigned by the education organization to the DisciplineAction. (required).</param>
        /// <param name="disciplineDate">The date of the DisciplineAction. (required).</param>
        /// <param name="disciplines">An unordered collection of disciplineActionDisciplines. Type of action, such as removal from the classroom, used to discipline the student involved as a perpetrator in a discipline incident. (required).</param>
        /// <param name="responsibilitySchoolReference">responsibilitySchoolReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="actualDisciplineActionLength">Indicates the actual length in school days of a student&#39;s disciplinary assignment..</param>
        /// <param name="disciplineActionLength">The length of time in school days for the DisciplineAction (e.g. removal, detention), if applicable..</param>
        /// <param name="studentDisciplineIncidentBehaviorAssociations">An unordered collection of disciplineActionStudentDisciplineIncidentBehaviorAssociations. A reference to the behavior(s) by the student that led or contributed to this specific action..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">ext.</param>
        public EdFiDisciplineActionReadable(string id = default(string), string disciplineActionIdentifier = default(string), DateTime disciplineDate = default(DateTime), List<EdFiDisciplineActionDisciplineReadable> disciplines = default(List<EdFiDisciplineActionDisciplineReadable>), EdFiSchoolReference responsibilitySchoolReference = default(EdFiSchoolReference), EdFiStudentReference studentReference = default(EdFiStudentReference), double actualDisciplineActionLength = default(double), double disciplineActionLength = default(double), List<EdFiDisciplineActionStudentDisciplineIncidentBehaviorAssociationReadable> studentDisciplineIncidentBehaviorAssociations = default(List<EdFiDisciplineActionStudentDisciplineIncidentBehaviorAssociationReadable>), string etag = default(string), DisciplineActionExtensionsReadable ext = default(DisciplineActionExtensionsReadable))
        {
            // to ensure "disciplineActionIdentifier" is required (not null)
            if (disciplineActionIdentifier == null)
            {
                throw new ArgumentNullException("disciplineActionIdentifier is a required property for EdFiDisciplineActionReadable and cannot be null");
            }
            this.DisciplineActionIdentifier = disciplineActionIdentifier;
            this.DisciplineDate = disciplineDate;
            // to ensure "disciplines" is required (not null)
            if (disciplines == null)
            {
                throw new ArgumentNullException("disciplines is a required property for EdFiDisciplineActionReadable and cannot be null");
            }
            this.Disciplines = disciplines;
            // to ensure "responsibilitySchoolReference" is required (not null)
            if (responsibilitySchoolReference == null)
            {
                throw new ArgumentNullException("responsibilitySchoolReference is a required property for EdFiDisciplineActionReadable and cannot be null");
            }
            this.ResponsibilitySchoolReference = responsibilitySchoolReference;
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new ArgumentNullException("studentReference is a required property for EdFiDisciplineActionReadable and cannot be null");
            }
            this.StudentReference = studentReference;
            this.Id = id;
            this.ActualDisciplineActionLength = actualDisciplineActionLength;
            this.DisciplineActionLength = disciplineActionLength;
            this.StudentDisciplineIncidentBehaviorAssociations = studentDisciplineIncidentBehaviorAssociations;
            this.Etag = etag;
            this.Ext = ext;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Identifier assigned by the education organization to the DisciplineAction.
        /// </summary>
        /// <value>Identifier assigned by the education organization to the DisciplineAction.</value>
        [DataMember(Name = "disciplineActionIdentifier", IsRequired = true, EmitDefaultValue = false)]
        public string DisciplineActionIdentifier { get; set; }

        /// <summary>
        /// The date of the DisciplineAction.
        /// </summary>
        /// <value>The date of the DisciplineAction.</value>
        [DataMember(Name = "disciplineDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime DisciplineDate { get; set; }

        /// <summary>
        /// An unordered collection of disciplineActionDisciplines. Type of action, such as removal from the classroom, used to discipline the student involved as a perpetrator in a discipline incident.
        /// </summary>
        /// <value>An unordered collection of disciplineActionDisciplines. Type of action, such as removal from the classroom, used to discipline the student involved as a perpetrator in a discipline incident.</value>
        [DataMember(Name = "disciplines", IsRequired = true, EmitDefaultValue = false)]
        public List<EdFiDisciplineActionDisciplineReadable> Disciplines { get; set; }

        /// <summary>
        /// Gets or Sets ResponsibilitySchoolReference
        /// </summary>
        [DataMember(Name = "responsibilitySchoolReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiSchoolReference ResponsibilitySchoolReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name = "studentReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// Indicates the actual length in school days of a student&#39;s disciplinary assignment.
        /// </summary>
        /// <value>Indicates the actual length in school days of a student&#39;s disciplinary assignment.</value>
        [DataMember(Name = "actualDisciplineActionLength", EmitDefaultValue = false)]
        public double ActualDisciplineActionLength { get; set; }

        /// <summary>
        /// The length of time in school days for the DisciplineAction (e.g. removal, detention), if applicable.
        /// </summary>
        /// <value>The length of time in school days for the DisciplineAction (e.g. removal, detention), if applicable.</value>
        [DataMember(Name = "disciplineActionLength", EmitDefaultValue = false)]
        public double DisciplineActionLength { get; set; }

        /// <summary>
        /// An unordered collection of disciplineActionStudentDisciplineIncidentBehaviorAssociations. A reference to the behavior(s) by the student that led or contributed to this specific action.
        /// </summary>
        /// <value>An unordered collection of disciplineActionStudentDisciplineIncidentBehaviorAssociations. A reference to the behavior(s) by the student that led or contributed to this specific action.</value>
        [DataMember(Name = "studentDisciplineIncidentBehaviorAssociations", EmitDefaultValue = false)]
        public List<EdFiDisciplineActionStudentDisciplineIncidentBehaviorAssociationReadable> StudentDisciplineIncidentBehaviorAssociations { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or Sets Ext
        /// </summary>
        [DataMember(Name = "_ext", EmitDefaultValue = false)]
        public DisciplineActionExtensionsReadable Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiDisciplineActionReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisciplineActionIdentifier: ").Append(DisciplineActionIdentifier).Append("\n");
            sb.Append("  DisciplineDate: ").Append(DisciplineDate).Append("\n");
            sb.Append("  Disciplines: ").Append(Disciplines).Append("\n");
            sb.Append("  ResponsibilitySchoolReference: ").Append(ResponsibilitySchoolReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  ActualDisciplineActionLength: ").Append(ActualDisciplineActionLength).Append("\n");
            sb.Append("  DisciplineActionLength: ").Append(DisciplineActionLength).Append("\n");
            sb.Append("  StudentDisciplineIncidentBehaviorAssociations: ").Append(StudentDisciplineIncidentBehaviorAssociations).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiDisciplineActionReadable);
        }

        /// <summary>
        /// Returns true if EdFiDisciplineActionReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiDisciplineActionReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiDisciplineActionReadable input)
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
                    this.DisciplineActionIdentifier == input.DisciplineActionIdentifier ||
                    (this.DisciplineActionIdentifier != null &&
                    this.DisciplineActionIdentifier.Equals(input.DisciplineActionIdentifier))
                ) && 
                (
                    this.DisciplineDate == input.DisciplineDate ||
                    (this.DisciplineDate != null &&
                    this.DisciplineDate.Equals(input.DisciplineDate))
                ) && 
                (
                    this.Disciplines == input.Disciplines ||
                    this.Disciplines != null &&
                    input.Disciplines != null &&
                    this.Disciplines.SequenceEqual(input.Disciplines)
                ) && 
                (
                    this.ResponsibilitySchoolReference == input.ResponsibilitySchoolReference ||
                    (this.ResponsibilitySchoolReference != null &&
                    this.ResponsibilitySchoolReference.Equals(input.ResponsibilitySchoolReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.ActualDisciplineActionLength == input.ActualDisciplineActionLength ||
                    this.ActualDisciplineActionLength.Equals(input.ActualDisciplineActionLength)
                ) && 
                (
                    this.DisciplineActionLength == input.DisciplineActionLength ||
                    this.DisciplineActionLength.Equals(input.DisciplineActionLength)
                ) && 
                (
                    this.StudentDisciplineIncidentBehaviorAssociations == input.StudentDisciplineIncidentBehaviorAssociations ||
                    this.StudentDisciplineIncidentBehaviorAssociations != null &&
                    input.StudentDisciplineIncidentBehaviorAssociations != null &&
                    this.StudentDisciplineIncidentBehaviorAssociations.SequenceEqual(input.StudentDisciplineIncidentBehaviorAssociations)
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
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.DisciplineActionIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.DisciplineActionIdentifier.GetHashCode();
                }
                if (this.DisciplineDate != null)
                {
                    hashCode = (hashCode * 59) + this.DisciplineDate.GetHashCode();
                }
                if (this.Disciplines != null)
                {
                    hashCode = (hashCode * 59) + this.Disciplines.GetHashCode();
                }
                if (this.ResponsibilitySchoolReference != null)
                {
                    hashCode = (hashCode * 59) + this.ResponsibilitySchoolReference.GetHashCode();
                }
                if (this.StudentReference != null)
                {
                    hashCode = (hashCode * 59) + this.StudentReference.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ActualDisciplineActionLength.GetHashCode();
                hashCode = (hashCode * 59) + this.DisciplineActionLength.GetHashCode();
                if (this.StudentDisciplineIncidentBehaviorAssociations != null)
                {
                    hashCode = (hashCode * 59) + this.StudentDisciplineIncidentBehaviorAssociations.GetHashCode();
                }
                if (this.Etag != null)
                {
                    hashCode = (hashCode * 59) + this.Etag.GetHashCode();
                }
                if (this.Ext != null)
                {
                    hashCode = (hashCode * 59) + this.Ext.GetHashCode();
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
            // DisciplineActionIdentifier (string) maxLength
            if (this.DisciplineActionIdentifier != null && this.DisciplineActionIdentifier.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisciplineActionIdentifier, length must be less than 20.", new [] { "DisciplineActionIdentifier" });
            }

            yield break;
        }
    }

}