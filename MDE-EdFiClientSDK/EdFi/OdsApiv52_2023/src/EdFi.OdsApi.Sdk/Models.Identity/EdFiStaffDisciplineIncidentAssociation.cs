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
    /// EdFiStaffDisciplineIncidentAssociation
    /// </summary>
    [DataContract]
    public partial class EdFiStaffDisciplineIncidentAssociation :  IEquatable<EdFiStaffDisciplineIncidentAssociation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffDisciplineIncidentAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStaffDisciplineIncidentAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStaffDisciplineIncidentAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="disciplineIncidentParticipationCodes">An unordered collection of staffDisciplineIncidentAssociationDisciplineIncidentParticipationCodes. The role or type of participation of a student in a discipline incident (e.g., Victim, Perpetrator, Witness, Reporter). (required).</param>
        /// <param name="disciplineIncidentReference">disciplineIncidentReference (required).</param>
        /// <param name="staffReference">staffReference (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStaffDisciplineIncidentAssociation(string id = default(string), List<EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode> disciplineIncidentParticipationCodes = default(List<EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode>), EdFiDisciplineIncidentReference disciplineIncidentReference = default(EdFiDisciplineIncidentReference), EdFiStaffReference staffReference = default(EdFiStaffReference), string etag = default(string))
        {
            // to ensure "disciplineIncidentParticipationCodes" is required (not null)
            if (disciplineIncidentParticipationCodes == null)
            {
                throw new InvalidDataException("disciplineIncidentParticipationCodes is a required property for EdFiStaffDisciplineIncidentAssociation and cannot be null");
            }
            else
            {
                this.DisciplineIncidentParticipationCodes = disciplineIncidentParticipationCodes;
            }
            // to ensure "disciplineIncidentReference" is required (not null)
            if (disciplineIncidentReference == null)
            {
                throw new InvalidDataException("disciplineIncidentReference is a required property for EdFiStaffDisciplineIncidentAssociation and cannot be null");
            }
            else
            {
                this.DisciplineIncidentReference = disciplineIncidentReference;
            }
            // to ensure "staffReference" is required (not null)
            if (staffReference == null)
            {
                throw new InvalidDataException("staffReference is a required property for EdFiStaffDisciplineIncidentAssociation and cannot be null");
            }
            else
            {
                this.StaffReference = staffReference;
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
        /// An unordered collection of staffDisciplineIncidentAssociationDisciplineIncidentParticipationCodes. The role or type of participation of a student in a discipline incident (e.g., Victim, Perpetrator, Witness, Reporter).
        /// </summary>
        /// <value>An unordered collection of staffDisciplineIncidentAssociationDisciplineIncidentParticipationCodes. The role or type of participation of a student in a discipline incident (e.g., Victim, Perpetrator, Witness, Reporter).</value>
        [DataMember(Name="disciplineIncidentParticipationCodes", EmitDefaultValue=false)]
        public List<EdFiStaffDisciplineIncidentAssociationDisciplineIncidentParticipationCode> DisciplineIncidentParticipationCodes { get; set; }

        /// <summary>
        /// Gets or Sets DisciplineIncidentReference
        /// </summary>
        [DataMember(Name="disciplineIncidentReference", EmitDefaultValue=false)]
        public EdFiDisciplineIncidentReference DisciplineIncidentReference { get; set; }

        /// <summary>
        /// Gets or Sets StaffReference
        /// </summary>
        [DataMember(Name="staffReference", EmitDefaultValue=false)]
        public EdFiStaffReference StaffReference { get; set; }

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
            sb.Append("class EdFiStaffDisciplineIncidentAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisciplineIncidentParticipationCodes: ").Append(DisciplineIncidentParticipationCodes).Append("\n");
            sb.Append("  DisciplineIncidentReference: ").Append(DisciplineIncidentReference).Append("\n");
            sb.Append("  StaffReference: ").Append(StaffReference).Append("\n");
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
            return this.Equals(input as EdFiStaffDisciplineIncidentAssociation);
        }

        /// <summary>
        /// Returns true if EdFiStaffDisciplineIncidentAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStaffDisciplineIncidentAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStaffDisciplineIncidentAssociation input)
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
                    this.DisciplineIncidentParticipationCodes == input.DisciplineIncidentParticipationCodes ||
                    this.DisciplineIncidentParticipationCodes != null &&
                    this.DisciplineIncidentParticipationCodes.SequenceEqual(input.DisciplineIncidentParticipationCodes)
                ) && 
                (
                    this.DisciplineIncidentReference == input.DisciplineIncidentReference ||
                    (this.DisciplineIncidentReference != null &&
                    this.DisciplineIncidentReference.Equals(input.DisciplineIncidentReference))
                ) && 
                (
                    this.StaffReference == input.StaffReference ||
                    (this.StaffReference != null &&
                    this.StaffReference.Equals(input.StaffReference))
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
                if (this.DisciplineIncidentParticipationCodes != null)
                    hashCode = hashCode * 59 + this.DisciplineIncidentParticipationCodes.GetHashCode();
                if (this.DisciplineIncidentReference != null)
                    hashCode = hashCode * 59 + this.DisciplineIncidentReference.GetHashCode();
                if (this.StaffReference != null)
                    hashCode = hashCode * 59 + this.StaffReference.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
