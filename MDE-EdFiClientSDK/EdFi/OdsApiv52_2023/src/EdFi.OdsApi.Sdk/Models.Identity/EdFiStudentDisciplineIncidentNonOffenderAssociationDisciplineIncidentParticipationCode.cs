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
    /// EdFiStudentDisciplineIncidentNonOffenderAssociationDisciplineIncidentParticipationCode
    /// </summary>
    [DataContract]
    public partial class EdFiStudentDisciplineIncidentNonOffenderAssociationDisciplineIncidentParticipationCode :  IEquatable<EdFiStudentDisciplineIncidentNonOffenderAssociationDisciplineIncidentParticipationCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentDisciplineIncidentNonOffenderAssociationDisciplineIncidentParticipationCode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentDisciplineIncidentNonOffenderAssociationDisciplineIncidentParticipationCode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentDisciplineIncidentNonOffenderAssociationDisciplineIncidentParticipationCode" /> class.
        /// </summary>
        /// <param name="disciplineIncidentParticipationCodeDescriptor">The role or type of participation of a student in a discipline incident. (required).</param>
        public EdFiStudentDisciplineIncidentNonOffenderAssociationDisciplineIncidentParticipationCode(string disciplineIncidentParticipationCodeDescriptor = default(string))
        {
            // to ensure "disciplineIncidentParticipationCodeDescriptor" is required (not null)
            if (disciplineIncidentParticipationCodeDescriptor == null)
            {
                throw new InvalidDataException("disciplineIncidentParticipationCodeDescriptor is a required property for EdFiStudentDisciplineIncidentNonOffenderAssociationDisciplineIncidentParticipationCode and cannot be null");
            }
            else
            {
                this.DisciplineIncidentParticipationCodeDescriptor = disciplineIncidentParticipationCodeDescriptor;
            }
        }
        
        /// <summary>
        /// The role or type of participation of a student in a discipline incident.
        /// </summary>
        /// <value>The role or type of participation of a student in a discipline incident.</value>
        [DataMember(Name="disciplineIncidentParticipationCodeDescriptor", EmitDefaultValue=false)]
        public string DisciplineIncidentParticipationCodeDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentDisciplineIncidentNonOffenderAssociationDisciplineIncidentParticipationCode {\n");
            sb.Append("  DisciplineIncidentParticipationCodeDescriptor: ").Append(DisciplineIncidentParticipationCodeDescriptor).Append("\n");
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
            return this.Equals(input as EdFiStudentDisciplineIncidentNonOffenderAssociationDisciplineIncidentParticipationCode);
        }

        /// <summary>
        /// Returns true if EdFiStudentDisciplineIncidentNonOffenderAssociationDisciplineIncidentParticipationCode instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentDisciplineIncidentNonOffenderAssociationDisciplineIncidentParticipationCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentDisciplineIncidentNonOffenderAssociationDisciplineIncidentParticipationCode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisciplineIncidentParticipationCodeDescriptor == input.DisciplineIncidentParticipationCodeDescriptor ||
                    (this.DisciplineIncidentParticipationCodeDescriptor != null &&
                    this.DisciplineIncidentParticipationCodeDescriptor.Equals(input.DisciplineIncidentParticipationCodeDescriptor))
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
                if (this.DisciplineIncidentParticipationCodeDescriptor != null)
                    hashCode = hashCode * 59 + this.DisciplineIncidentParticipationCodeDescriptor.GetHashCode();
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
            // DisciplineIncidentParticipationCodeDescriptor (string) maxLength
            if(this.DisciplineIncidentParticipationCodeDescriptor != null && this.DisciplineIncidentParticipationCodeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisciplineIncidentParticipationCodeDescriptor, length must be less than 306.", new [] { "DisciplineIncidentParticipationCodeDescriptor" });
            }

            yield break;
        }
    }

}
