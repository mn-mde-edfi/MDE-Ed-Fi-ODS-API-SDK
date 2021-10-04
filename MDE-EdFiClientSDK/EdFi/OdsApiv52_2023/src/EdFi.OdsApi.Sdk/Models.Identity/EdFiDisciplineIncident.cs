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
    /// EdFiDisciplineIncident
    /// </summary>
    [DataContract]
    public partial class EdFiDisciplineIncident :  IEquatable<EdFiDisciplineIncident>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiDisciplineIncident" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiDisciplineIncident() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiDisciplineIncident" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="incidentIdentifier">A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders. (required).</param>
        /// <param name="schoolReference">schoolReference (required).</param>
        /// <param name="staffReference">staffReference.</param>
        /// <param name="behaviors">An unordered collection of disciplineIncidentBehaviors. Describes behavior by category and provides a detailed description..</param>
        /// <param name="caseNumber">The case number assigned to the DisciplineIncident by law enforcement or other organization..</param>
        /// <param name="externalParticipants">An unordered collection of disciplineIncidentExternalParticipants. Information on an individual involved in the Discipline Incident..</param>
        /// <param name="incidentCost">The value of any quantifiable monetary loss directly resulting from the DisciplineIncident. Examples include the value of repairs necessitated by vandalism of a school facility, or the value of personnel resources used for repairs or consumed by the incident..</param>
        /// <param name="incidentDate">The month, day, and year on which the DisciplineIncident occurred. (required).</param>
        /// <param name="incidentDescription">The description for an incident..</param>
        /// <param name="incidentLocationDescriptor">Identifies where the DisciplineIncident occurred and whether or not it occurred on school, for example:         On school         Administrative offices area         Cafeteria area         Classroom         Hallway or stairs         ....</param>
        /// <param name="incidentTime">An indication of the time of day the incident took place..</param>
        /// <param name="reportedToLawEnforcement">Indicator of whether the incident was reported to law enforcement..</param>
        /// <param name="reporterDescriptionDescriptor">Information on the type of individual who reported the DisciplineIncident. When known and/or if useful, use a more specific option code (e.g., \&quot;Counselor\&quot; rather than \&quot;Professional Staff\&quot;); for example:         Student         Parent/guardian         Law enforcement officer         Nonschool personnel         Representative of visiting school         ....</param>
        /// <param name="reporterName">Identifies the reporter of the DisciplineIncident by name..</param>
        /// <param name="weapons">An unordered collection of disciplineIncidentWeapons. Identifies the type of weapon used during an incident. The Federal Gun-Free Schools Act requires states to report the number of students expelled for bringing firearms to school by type of firearm..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiDisciplineIncident(string id = default(string), string incidentIdentifier = default(string), EdFiSchoolReference schoolReference = default(EdFiSchoolReference), EdFiStaffReference staffReference = default(EdFiStaffReference), List<EdFiDisciplineIncidentBehavior> behaviors = default(List<EdFiDisciplineIncidentBehavior>), string caseNumber = default(string), List<EdFiDisciplineIncidentExternalParticipant> externalParticipants = default(List<EdFiDisciplineIncidentExternalParticipant>), double? incidentCost = default(double?), DateTime? incidentDate = default(DateTime?), string incidentDescription = default(string), string incidentLocationDescriptor = default(string), string incidentTime = default(string), bool? reportedToLawEnforcement = default(bool?), string reporterDescriptionDescriptor = default(string), string reporterName = default(string), List<EdFiDisciplineIncidentWeapon> weapons = default(List<EdFiDisciplineIncidentWeapon>), string etag = default(string))
        {
            // to ensure "incidentIdentifier" is required (not null)
            if (incidentIdentifier == null)
            {
                throw new InvalidDataException("incidentIdentifier is a required property for EdFiDisciplineIncident and cannot be null");
            }
            else
            {
                this.IncidentIdentifier = incidentIdentifier;
            }
            // to ensure "schoolReference" is required (not null)
            if (schoolReference == null)
            {
                throw new InvalidDataException("schoolReference is a required property for EdFiDisciplineIncident and cannot be null");
            }
            else
            {
                this.SchoolReference = schoolReference;
            }
            // to ensure "incidentDate" is required (not null)
            if (incidentDate == null)
            {
                throw new InvalidDataException("incidentDate is a required property for EdFiDisciplineIncident and cannot be null");
            }
            else
            {
                this.IncidentDate = incidentDate;
            }
            this.Id = id;
            this.StaffReference = staffReference;
            this.Behaviors = behaviors;
            this.CaseNumber = caseNumber;
            this.ExternalParticipants = externalParticipants;
            this.IncidentCost = incidentCost;
            this.IncidentDescription = incidentDescription;
            this.IncidentLocationDescriptor = incidentLocationDescriptor;
            this.IncidentTime = incidentTime;
            this.ReportedToLawEnforcement = reportedToLawEnforcement;
            this.ReporterDescriptionDescriptor = reporterDescriptionDescriptor;
            this.ReporterName = reporterName;
            this.Weapons = weapons;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders.
        /// </summary>
        /// <value>A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders.</value>
        [DataMember(Name="incidentIdentifier", EmitDefaultValue=false)]
        public string IncidentIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name="schoolReference", EmitDefaultValue=false)]
        public EdFiSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// Gets or Sets StaffReference
        /// </summary>
        [DataMember(Name="staffReference", EmitDefaultValue=false)]
        public EdFiStaffReference StaffReference { get; set; }

        /// <summary>
        /// An unordered collection of disciplineIncidentBehaviors. Describes behavior by category and provides a detailed description.
        /// </summary>
        /// <value>An unordered collection of disciplineIncidentBehaviors. Describes behavior by category and provides a detailed description.</value>
        [DataMember(Name="behaviors", EmitDefaultValue=false)]
        public List<EdFiDisciplineIncidentBehavior> Behaviors { get; set; }

        /// <summary>
        /// The case number assigned to the DisciplineIncident by law enforcement or other organization.
        /// </summary>
        /// <value>The case number assigned to the DisciplineIncident by law enforcement or other organization.</value>
        [DataMember(Name="caseNumber", EmitDefaultValue=false)]
        public string CaseNumber { get; set; }

        /// <summary>
        /// An unordered collection of disciplineIncidentExternalParticipants. Information on an individual involved in the Discipline Incident.
        /// </summary>
        /// <value>An unordered collection of disciplineIncidentExternalParticipants. Information on an individual involved in the Discipline Incident.</value>
        [DataMember(Name="externalParticipants", EmitDefaultValue=false)]
        public List<EdFiDisciplineIncidentExternalParticipant> ExternalParticipants { get; set; }

        /// <summary>
        /// The value of any quantifiable monetary loss directly resulting from the DisciplineIncident. Examples include the value of repairs necessitated by vandalism of a school facility, or the value of personnel resources used for repairs or consumed by the incident.
        /// </summary>
        /// <value>The value of any quantifiable monetary loss directly resulting from the DisciplineIncident. Examples include the value of repairs necessitated by vandalism of a school facility, or the value of personnel resources used for repairs or consumed by the incident.</value>
        [DataMember(Name="incidentCost", EmitDefaultValue=false)]
        public double? IncidentCost { get; set; }

        /// <summary>
        /// The month, day, and year on which the DisciplineIncident occurred.
        /// </summary>
        /// <value>The month, day, and year on which the DisciplineIncident occurred.</value>
        [DataMember(Name="incidentDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? IncidentDate { get; set; }

        /// <summary>
        /// The description for an incident.
        /// </summary>
        /// <value>The description for an incident.</value>
        [DataMember(Name="incidentDescription", EmitDefaultValue=false)]
        public string IncidentDescription { get; set; }

        /// <summary>
        /// Identifies where the DisciplineIncident occurred and whether or not it occurred on school, for example:         On school         Administrative offices area         Cafeteria area         Classroom         Hallway or stairs         ...
        /// </summary>
        /// <value>Identifies where the DisciplineIncident occurred and whether or not it occurred on school, for example:         On school         Administrative offices area         Cafeteria area         Classroom         Hallway or stairs         ...</value>
        [DataMember(Name="incidentLocationDescriptor", EmitDefaultValue=false)]
        public string IncidentLocationDescriptor { get; set; }

        /// <summary>
        /// An indication of the time of day the incident took place.
        /// </summary>
        /// <value>An indication of the time of day the incident took place.</value>
        [DataMember(Name="incidentTime", EmitDefaultValue=false)]
        public string IncidentTime { get; set; }

        /// <summary>
        /// Indicator of whether the incident was reported to law enforcement.
        /// </summary>
        /// <value>Indicator of whether the incident was reported to law enforcement.</value>
        [DataMember(Name="reportedToLawEnforcement", EmitDefaultValue=false)]
        public bool? ReportedToLawEnforcement { get; set; }

        /// <summary>
        /// Information on the type of individual who reported the DisciplineIncident. When known and/or if useful, use a more specific option code (e.g., \&quot;Counselor\&quot; rather than \&quot;Professional Staff\&quot;); for example:         Student         Parent/guardian         Law enforcement officer         Nonschool personnel         Representative of visiting school         ...
        /// </summary>
        /// <value>Information on the type of individual who reported the DisciplineIncident. When known and/or if useful, use a more specific option code (e.g., \&quot;Counselor\&quot; rather than \&quot;Professional Staff\&quot;); for example:         Student         Parent/guardian         Law enforcement officer         Nonschool personnel         Representative of visiting school         ...</value>
        [DataMember(Name="reporterDescriptionDescriptor", EmitDefaultValue=false)]
        public string ReporterDescriptionDescriptor { get; set; }

        /// <summary>
        /// Identifies the reporter of the DisciplineIncident by name.
        /// </summary>
        /// <value>Identifies the reporter of the DisciplineIncident by name.</value>
        [DataMember(Name="reporterName", EmitDefaultValue=false)]
        public string ReporterName { get; set; }

        /// <summary>
        /// An unordered collection of disciplineIncidentWeapons. Identifies the type of weapon used during an incident. The Federal Gun-Free Schools Act requires states to report the number of students expelled for bringing firearms to school by type of firearm.
        /// </summary>
        /// <value>An unordered collection of disciplineIncidentWeapons. Identifies the type of weapon used during an incident. The Federal Gun-Free Schools Act requires states to report the number of students expelled for bringing firearms to school by type of firearm.</value>
        [DataMember(Name="weapons", EmitDefaultValue=false)]
        public List<EdFiDisciplineIncidentWeapon> Weapons { get; set; }

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
            sb.Append("class EdFiDisciplineIncident {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IncidentIdentifier: ").Append(IncidentIdentifier).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  StaffReference: ").Append(StaffReference).Append("\n");
            sb.Append("  Behaviors: ").Append(Behaviors).Append("\n");
            sb.Append("  CaseNumber: ").Append(CaseNumber).Append("\n");
            sb.Append("  ExternalParticipants: ").Append(ExternalParticipants).Append("\n");
            sb.Append("  IncidentCost: ").Append(IncidentCost).Append("\n");
            sb.Append("  IncidentDate: ").Append(IncidentDate).Append("\n");
            sb.Append("  IncidentDescription: ").Append(IncidentDescription).Append("\n");
            sb.Append("  IncidentLocationDescriptor: ").Append(IncidentLocationDescriptor).Append("\n");
            sb.Append("  IncidentTime: ").Append(IncidentTime).Append("\n");
            sb.Append("  ReportedToLawEnforcement: ").Append(ReportedToLawEnforcement).Append("\n");
            sb.Append("  ReporterDescriptionDescriptor: ").Append(ReporterDescriptionDescriptor).Append("\n");
            sb.Append("  ReporterName: ").Append(ReporterName).Append("\n");
            sb.Append("  Weapons: ").Append(Weapons).Append("\n");
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
            return this.Equals(input as EdFiDisciplineIncident);
        }

        /// <summary>
        /// Returns true if EdFiDisciplineIncident instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiDisciplineIncident to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiDisciplineIncident input)
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
                    this.IncidentIdentifier == input.IncidentIdentifier ||
                    (this.IncidentIdentifier != null &&
                    this.IncidentIdentifier.Equals(input.IncidentIdentifier))
                ) && 
                (
                    this.SchoolReference == input.SchoolReference ||
                    (this.SchoolReference != null &&
                    this.SchoolReference.Equals(input.SchoolReference))
                ) && 
                (
                    this.StaffReference == input.StaffReference ||
                    (this.StaffReference != null &&
                    this.StaffReference.Equals(input.StaffReference))
                ) && 
                (
                    this.Behaviors == input.Behaviors ||
                    this.Behaviors != null &&
                    this.Behaviors.SequenceEqual(input.Behaviors)
                ) && 
                (
                    this.CaseNumber == input.CaseNumber ||
                    (this.CaseNumber != null &&
                    this.CaseNumber.Equals(input.CaseNumber))
                ) && 
                (
                    this.ExternalParticipants == input.ExternalParticipants ||
                    this.ExternalParticipants != null &&
                    this.ExternalParticipants.SequenceEqual(input.ExternalParticipants)
                ) && 
                (
                    this.IncidentCost == input.IncidentCost ||
                    (this.IncidentCost != null &&
                    this.IncidentCost.Equals(input.IncidentCost))
                ) && 
                (
                    this.IncidentDate == input.IncidentDate ||
                    (this.IncidentDate != null &&
                    this.IncidentDate.Equals(input.IncidentDate))
                ) && 
                (
                    this.IncidentDescription == input.IncidentDescription ||
                    (this.IncidentDescription != null &&
                    this.IncidentDescription.Equals(input.IncidentDescription))
                ) && 
                (
                    this.IncidentLocationDescriptor == input.IncidentLocationDescriptor ||
                    (this.IncidentLocationDescriptor != null &&
                    this.IncidentLocationDescriptor.Equals(input.IncidentLocationDescriptor))
                ) && 
                (
                    this.IncidentTime == input.IncidentTime ||
                    (this.IncidentTime != null &&
                    this.IncidentTime.Equals(input.IncidentTime))
                ) && 
                (
                    this.ReportedToLawEnforcement == input.ReportedToLawEnforcement ||
                    (this.ReportedToLawEnforcement != null &&
                    this.ReportedToLawEnforcement.Equals(input.ReportedToLawEnforcement))
                ) && 
                (
                    this.ReporterDescriptionDescriptor == input.ReporterDescriptionDescriptor ||
                    (this.ReporterDescriptionDescriptor != null &&
                    this.ReporterDescriptionDescriptor.Equals(input.ReporterDescriptionDescriptor))
                ) && 
                (
                    this.ReporterName == input.ReporterName ||
                    (this.ReporterName != null &&
                    this.ReporterName.Equals(input.ReporterName))
                ) && 
                (
                    this.Weapons == input.Weapons ||
                    this.Weapons != null &&
                    this.Weapons.SequenceEqual(input.Weapons)
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
                if (this.IncidentIdentifier != null)
                    hashCode = hashCode * 59 + this.IncidentIdentifier.GetHashCode();
                if (this.SchoolReference != null)
                    hashCode = hashCode * 59 + this.SchoolReference.GetHashCode();
                if (this.StaffReference != null)
                    hashCode = hashCode * 59 + this.StaffReference.GetHashCode();
                if (this.Behaviors != null)
                    hashCode = hashCode * 59 + this.Behaviors.GetHashCode();
                if (this.CaseNumber != null)
                    hashCode = hashCode * 59 + this.CaseNumber.GetHashCode();
                if (this.ExternalParticipants != null)
                    hashCode = hashCode * 59 + this.ExternalParticipants.GetHashCode();
                if (this.IncidentCost != null)
                    hashCode = hashCode * 59 + this.IncidentCost.GetHashCode();
                if (this.IncidentDate != null)
                    hashCode = hashCode * 59 + this.IncidentDate.GetHashCode();
                if (this.IncidentDescription != null)
                    hashCode = hashCode * 59 + this.IncidentDescription.GetHashCode();
                if (this.IncidentLocationDescriptor != null)
                    hashCode = hashCode * 59 + this.IncidentLocationDescriptor.GetHashCode();
                if (this.IncidentTime != null)
                    hashCode = hashCode * 59 + this.IncidentTime.GetHashCode();
                if (this.ReportedToLawEnforcement != null)
                    hashCode = hashCode * 59 + this.ReportedToLawEnforcement.GetHashCode();
                if (this.ReporterDescriptionDescriptor != null)
                    hashCode = hashCode * 59 + this.ReporterDescriptionDescriptor.GetHashCode();
                if (this.ReporterName != null)
                    hashCode = hashCode * 59 + this.ReporterName.GetHashCode();
                if (this.Weapons != null)
                    hashCode = hashCode * 59 + this.Weapons.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}
