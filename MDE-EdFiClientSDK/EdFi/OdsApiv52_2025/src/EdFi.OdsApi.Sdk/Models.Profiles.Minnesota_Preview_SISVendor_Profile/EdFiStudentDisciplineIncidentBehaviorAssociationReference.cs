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
    /// EdFiStudentDisciplineIncidentBehaviorAssociationReference
    /// </summary>
    [DataContract(Name = "edFi_studentDisciplineIncidentBehaviorAssociationReference")]
    public partial class EdFiStudentDisciplineIncidentBehaviorAssociationReference : IEquatable<EdFiStudentDisciplineIncidentBehaviorAssociationReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentDisciplineIncidentBehaviorAssociationReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentDisciplineIncidentBehaviorAssociationReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentDisciplineIncidentBehaviorAssociationReference" /> class.
        /// </summary>
        /// <param name="behaviorDescriptor">Describes behavior by category. (required).</param>
        /// <param name="incidentIdentifier">A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders. (required).</param>
        /// <param name="schoolId">The identifier assigned to a school. (required).</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student. (required).</param>
        /// <param name="link">link.</param>
        public EdFiStudentDisciplineIncidentBehaviorAssociationReference(string behaviorDescriptor = default(string), string incidentIdentifier = default(string), int schoolId = default(int), string studentUniqueId = default(string), Link link = default(Link))
        {
            // to ensure "behaviorDescriptor" is required (not null)
            if (behaviorDescriptor == null)
            {
                throw new ArgumentNullException("behaviorDescriptor is a required property for EdFiStudentDisciplineIncidentBehaviorAssociationReference and cannot be null");
            }
            this.BehaviorDescriptor = behaviorDescriptor;
            // to ensure "incidentIdentifier" is required (not null)
            if (incidentIdentifier == null)
            {
                throw new ArgumentNullException("incidentIdentifier is a required property for EdFiStudentDisciplineIncidentBehaviorAssociationReference and cannot be null");
            }
            this.IncidentIdentifier = incidentIdentifier;
            this.SchoolId = schoolId;
            // to ensure "studentUniqueId" is required (not null)
            if (studentUniqueId == null)
            {
                throw new ArgumentNullException("studentUniqueId is a required property for EdFiStudentDisciplineIncidentBehaviorAssociationReference and cannot be null");
            }
            this.StudentUniqueId = studentUniqueId;
            this.Link = link;
        }

        /// <summary>
        /// Describes behavior by category.
        /// </summary>
        /// <value>Describes behavior by category.</value>
        [DataMember(Name = "behaviorDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string BehaviorDescriptor { get; set; }

        /// <summary>
        /// A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders.
        /// </summary>
        /// <value>A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders.</value>
        [DataMember(Name = "incidentIdentifier", IsRequired = true, EmitDefaultValue = false)]
        public string IncidentIdentifier { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name = "schoolId", IsRequired = true, EmitDefaultValue = false)]
        public int SchoolId { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [DataMember(Name = "studentUniqueId", IsRequired = true, EmitDefaultValue = false)]
        public string StudentUniqueId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentDisciplineIncidentBehaviorAssociationReference {\n");
            sb.Append("  BehaviorDescriptor: ").Append(BehaviorDescriptor).Append("\n");
            sb.Append("  IncidentIdentifier: ").Append(IncidentIdentifier).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  StudentUniqueId: ").Append(StudentUniqueId).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as EdFiStudentDisciplineIncidentBehaviorAssociationReference);
        }

        /// <summary>
        /// Returns true if EdFiStudentDisciplineIncidentBehaviorAssociationReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentDisciplineIncidentBehaviorAssociationReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentDisciplineIncidentBehaviorAssociationReference input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BehaviorDescriptor == input.BehaviorDescriptor ||
                    (this.BehaviorDescriptor != null &&
                    this.BehaviorDescriptor.Equals(input.BehaviorDescriptor))
                ) && 
                (
                    this.IncidentIdentifier == input.IncidentIdentifier ||
                    (this.IncidentIdentifier != null &&
                    this.IncidentIdentifier.Equals(input.IncidentIdentifier))
                ) && 
                (
                    this.SchoolId == input.SchoolId ||
                    this.SchoolId.Equals(input.SchoolId)
                ) && 
                (
                    this.StudentUniqueId == input.StudentUniqueId ||
                    (this.StudentUniqueId != null &&
                    this.StudentUniqueId.Equals(input.StudentUniqueId))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                if (this.BehaviorDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.BehaviorDescriptor.GetHashCode();
                }
                if (this.IncidentIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.IncidentIdentifier.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SchoolId.GetHashCode();
                if (this.StudentUniqueId != null)
                {
                    hashCode = (hashCode * 59) + this.StudentUniqueId.GetHashCode();
                }
                if (this.Link != null)
                {
                    hashCode = (hashCode * 59) + this.Link.GetHashCode();
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
            // BehaviorDescriptor (string) maxLength
            if (this.BehaviorDescriptor != null && this.BehaviorDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BehaviorDescriptor, length must be less than 306.", new [] { "BehaviorDescriptor" });
            }

            // IncidentIdentifier (string) maxLength
            if (this.IncidentIdentifier != null && this.IncidentIdentifier.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IncidentIdentifier, length must be less than 20.", new [] { "IncidentIdentifier" });
            }

            // StudentUniqueId (string) maxLength
            if (this.StudentUniqueId != null && this.StudentUniqueId.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentUniqueId, length must be less than 32.", new [] { "StudentUniqueId" });
            }

            yield break;
        }
    }

}
