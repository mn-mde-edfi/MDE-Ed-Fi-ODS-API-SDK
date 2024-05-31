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
    /// EdFiStudentDisciplineIncidentNonOffenderAssociationWritable
    /// </summary>
    [DataContract(Name = "edFi_studentDisciplineIncidentNonOffenderAssociation_writable")]
    public partial class EdFiStudentDisciplineIncidentNonOffenderAssociationWritable : IEquatable<EdFiStudentDisciplineIncidentNonOffenderAssociationWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentDisciplineIncidentNonOffenderAssociationWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentDisciplineIncidentNonOffenderAssociationWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentDisciplineIncidentNonOffenderAssociationWritable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="disciplineIncidentReference">disciplineIncidentReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">ext.</param>
        public EdFiStudentDisciplineIncidentNonOffenderAssociationWritable(string id = default(string), EdFiDisciplineIncidentReference disciplineIncidentReference = default(EdFiDisciplineIncidentReference), EdFiStudentReference studentReference = default(EdFiStudentReference), string etag = default(string), StudentDisciplineIncidentNonOffenderAssociationExtensionsWritable ext = default(StudentDisciplineIncidentNonOffenderAssociationExtensionsWritable))
        {
            // to ensure "disciplineIncidentReference" is required (not null)
            if (disciplineIncidentReference == null)
            {
                throw new ArgumentNullException("disciplineIncidentReference is a required property for EdFiStudentDisciplineIncidentNonOffenderAssociationWritable and cannot be null");
            }
            this.DisciplineIncidentReference = disciplineIncidentReference;
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new ArgumentNullException("studentReference is a required property for EdFiStudentDisciplineIncidentNonOffenderAssociationWritable and cannot be null");
            }
            this.StudentReference = studentReference;
            this.Id = id;
            this.Etag = etag;
            this.Ext = ext;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets DisciplineIncidentReference
        /// </summary>
        [DataMember(Name = "disciplineIncidentReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiDisciplineIncidentReference DisciplineIncidentReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name = "studentReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiStudentReference StudentReference { get; set; }

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
        public StudentDisciplineIncidentNonOffenderAssociationExtensionsWritable Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentDisciplineIncidentNonOffenderAssociationWritable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisciplineIncidentReference: ").Append(DisciplineIncidentReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
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
            return this.Equals(input as EdFiStudentDisciplineIncidentNonOffenderAssociationWritable);
        }

        /// <summary>
        /// Returns true if EdFiStudentDisciplineIncidentNonOffenderAssociationWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentDisciplineIncidentNonOffenderAssociationWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentDisciplineIncidentNonOffenderAssociationWritable input)
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
                    this.DisciplineIncidentReference == input.DisciplineIncidentReference ||
                    (this.DisciplineIncidentReference != null &&
                    this.DisciplineIncidentReference.Equals(input.DisciplineIncidentReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
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
                if (this.DisciplineIncidentReference != null)
                {
                    hashCode = (hashCode * 59) + this.DisciplineIncidentReference.GetHashCode();
                }
                if (this.StudentReference != null)
                {
                    hashCode = (hashCode * 59) + this.StudentReference.GetHashCode();
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
            yield break;
        }
    }

}
