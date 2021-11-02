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
    /// EdFiStudentDisciplineIncidentBehaviorAssociationReference
    /// </summary>
    [DataContract]
    public partial class EdFiStudentDisciplineIncidentBehaviorAssociationReference :  IEquatable<EdFiStudentDisciplineIncidentBehaviorAssociationReference>
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
        public EdFiStudentDisciplineIncidentBehaviorAssociationReference(string behaviorDescriptor = default(string), string incidentIdentifier = default(string), int? schoolId = default(int?), string studentUniqueId = default(string), Link link = default(Link))
        {
            // to ensure "behaviorDescriptor" is required (not null)
            if (behaviorDescriptor == null)
            {
                throw new InvalidDataException("behaviorDescriptor is a required property for EdFiStudentDisciplineIncidentBehaviorAssociationReference and cannot be null");
            }
            else
            {
                this.BehaviorDescriptor = behaviorDescriptor;
            }
            // to ensure "incidentIdentifier" is required (not null)
            if (incidentIdentifier == null)
            {
                throw new InvalidDataException("incidentIdentifier is a required property for EdFiStudentDisciplineIncidentBehaviorAssociationReference and cannot be null");
            }
            else
            {
                this.IncidentIdentifier = incidentIdentifier;
            }
            // to ensure "schoolId" is required (not null)
            if (schoolId == null)
            {
                throw new InvalidDataException("schoolId is a required property for EdFiStudentDisciplineIncidentBehaviorAssociationReference and cannot be null");
            }
            else
            {
                this.SchoolId = schoolId;
            }
            // to ensure "studentUniqueId" is required (not null)
            if (studentUniqueId == null)
            {
                throw new InvalidDataException("studentUniqueId is a required property for EdFiStudentDisciplineIncidentBehaviorAssociationReference and cannot be null");
            }
            else
            {
                this.StudentUniqueId = studentUniqueId;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// Describes behavior by category.
        /// </summary>
        /// <value>Describes behavior by category.</value>
        [DataMember(Name="behaviorDescriptor", EmitDefaultValue=false)]
        public string BehaviorDescriptor { get; set; }

        /// <summary>
        /// A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders.
        /// </summary>
        /// <value>A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders.</value>
        [DataMember(Name="incidentIdentifier", EmitDefaultValue=false)]
        public string IncidentIdentifier { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name="schoolId", EmitDefaultValue=false)]
        public int? SchoolId { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [DataMember(Name="studentUniqueId", EmitDefaultValue=false)]
        public string StudentUniqueId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
                return false;

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
                    (this.SchoolId != null &&
                    this.SchoolId.Equals(input.SchoolId))
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
                    hashCode = hashCode * 59 + this.BehaviorDescriptor.GetHashCode();
                if (this.IncidentIdentifier != null)
                    hashCode = hashCode * 59 + this.IncidentIdentifier.GetHashCode();
                if (this.SchoolId != null)
                    hashCode = hashCode * 59 + this.SchoolId.GetHashCode();
                if (this.StudentUniqueId != null)
                    hashCode = hashCode * 59 + this.StudentUniqueId.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}
