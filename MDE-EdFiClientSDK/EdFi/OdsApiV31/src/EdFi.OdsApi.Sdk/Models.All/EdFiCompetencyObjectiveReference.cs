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

namespace EdFi.OdsApi.Sdk.Models.All
{
    /// <summary>
    /// EdFiCompetencyObjectiveReference
    /// </summary>
    [DataContract]
    public partial class EdFiCompetencyObjectiveReference :  IEquatable<EdFiCompetencyObjectiveReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCompetencyObjectiveReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCompetencyObjectiveReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCompetencyObjectiveReference" /> class.
        /// </summary>
        /// <param name="EducationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="Objective">The designated title of the CompetencyObjective. (required).</param>
        /// <param name="ObjectiveGradeLevelDescriptor">The grade level for which the CompetencyObjective is targeted. (required).</param>
        /// <param name="Link">Link.</param>
        public EdFiCompetencyObjectiveReference(int? EducationOrganizationId = default(int?), string Objective = default(string), string ObjectiveGradeLevelDescriptor = default(string), Link Link = default(Link))
        {
            // to ensure "EducationOrganizationId" is required (not null)
            if (EducationOrganizationId == null)
            {
                throw new InvalidDataException("EducationOrganizationId is a required property for EdFiCompetencyObjectiveReference and cannot be null");
            }
            else
            {
                this.EducationOrganizationId = EducationOrganizationId;
            }
            // to ensure "Objective" is required (not null)
            if (Objective == null)
            {
                throw new InvalidDataException("Objective is a required property for EdFiCompetencyObjectiveReference and cannot be null");
            }
            else
            {
                this.Objective = Objective;
            }
            // to ensure "ObjectiveGradeLevelDescriptor" is required (not null)
            if (ObjectiveGradeLevelDescriptor == null)
            {
                throw new InvalidDataException("ObjectiveGradeLevelDescriptor is a required property for EdFiCompetencyObjectiveReference and cannot be null");
            }
            else
            {
                this.ObjectiveGradeLevelDescriptor = ObjectiveGradeLevelDescriptor;
            }
            this.Link = Link;
        }
        
        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name="educationOrganizationId", EmitDefaultValue=false)]
        public int? EducationOrganizationId { get; set; }

        /// <summary>
        /// The designated title of the CompetencyObjective.
        /// </summary>
        /// <value>The designated title of the CompetencyObjective.</value>
        [DataMember(Name="objective", EmitDefaultValue=false)]
        public string Objective { get; set; }

        /// <summary>
        /// The grade level for which the CompetencyObjective is targeted.
        /// </summary>
        /// <value>The grade level for which the CompetencyObjective is targeted.</value>
        [DataMember(Name="objectiveGradeLevelDescriptor", EmitDefaultValue=false)]
        public string ObjectiveGradeLevelDescriptor { get; set; }

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
            sb.Append("class EdFiCompetencyObjectiveReference {\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  Objective: ").Append(Objective).Append("\n");
            sb.Append("  ObjectiveGradeLevelDescriptor: ").Append(ObjectiveGradeLevelDescriptor).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as EdFiCompetencyObjectiveReference);
        }

        /// <summary>
        /// Returns true if EdFiCompetencyObjectiveReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCompetencyObjectiveReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCompetencyObjectiveReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    (this.EducationOrganizationId != null &&
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId))
                ) && 
                (
                    this.Objective == input.Objective ||
                    (this.Objective != null &&
                    this.Objective.Equals(input.Objective))
                ) && 
                (
                    this.ObjectiveGradeLevelDescriptor == input.ObjectiveGradeLevelDescriptor ||
                    (this.ObjectiveGradeLevelDescriptor != null &&
                    this.ObjectiveGradeLevelDescriptor.Equals(input.ObjectiveGradeLevelDescriptor))
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
                if (this.EducationOrganizationId != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationId.GetHashCode();
                if (this.Objective != null)
                    hashCode = hashCode * 59 + this.Objective.GetHashCode();
                if (this.ObjectiveGradeLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.ObjectiveGradeLevelDescriptor.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
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
            // Objective (string) maxLength
            if(this.Objective != null && this.Objective.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Objective, length must be less than 60.", new [] { "Objective" });
            }

            // ObjectiveGradeLevelDescriptor (string) maxLength
            if(this.ObjectiveGradeLevelDescriptor != null && this.ObjectiveGradeLevelDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ObjectiveGradeLevelDescriptor, length must be less than 306.", new [] { "ObjectiveGradeLevelDescriptor" });
            }

            yield break;
        }
    }

}
