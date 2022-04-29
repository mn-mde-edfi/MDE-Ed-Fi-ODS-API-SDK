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
    /// EdFiStudentMigrantEducationProgramAssociation
    /// </summary>
    [DataContract]
    public partial class EdFiStudentMigrantEducationProgramAssociation :  IEquatable<EdFiStudentMigrantEducationProgramAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentMigrantEducationProgramAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentMigrantEducationProgramAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentMigrantEducationProgramAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="beginDate">The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="programReference">programReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="continuationOfServicesReasonDescriptor">The \&quot;continuation of services\&quot; provision found in Section 1304(e) of the statute provides that (1) a child who ceases to be a migratory child during a school term shall be eligible for services until the end of such term; (2) a child who is no longer a migratory child may continue to receive services for one additional school year, but only if comparable services are not available through other programs; and (3) secondary school students who were eligible for services in secondary school may continue to be served through credit accrual programs until graduation. Only students who received services at any time during their 36 month eligibility period may continue to receive services (not necessarily the same service)..</param>
        /// <param name="eligibilityExpirationDate">The Eligibility Expiration Date is used to determine end of eligibility and to account for a child&#39;s eligibility expiring earlier than 36 months from the child&#39;s QAD. A child&#39;s eligibility would end earlier than 36 months from the child&#39;s QAD, if the child is no longer entitled to a free public education (e.g., graduated with a high school diploma, obtained a high school equivalency diploma (HSED), or for other reasons as determined by States&#39; requirements), or if the child passes away..</param>
        /// <param name="endDate">The month, day, and year on which the Student exited the Program or stopped receiving services..</param>
        /// <param name="lastQualifyingMove">Date the last qualifying move occurred; used to compute MEP status. (required).</param>
        /// <param name="migrantEducationProgramServices">An unordered collection of studentMigrantEducationProgramAssociationMigrantEducationProgramServices. Indicates the Service(s) being provided to the Student by the Migrant Education Program..</param>
        /// <param name="participationStatus">participationStatus.</param>
        /// <param name="priorityForServices">Report migratory children who are classified as having \&quot;priority for services\&quot; because they are failing, or most at risk of failing to meet the State&#39;s challenging State academic content standards and challenging State student academic achievement standards, and their education has been interrupted during the regular school year. (required).</param>
        /// <param name="programParticipationStatuses">An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation..</param>
        /// <param name="qualifyingArrivalDate">The Qualifying Arrival Date (QAD) is the date the child joins the worker who has already moved, or the date when the worker joins the child who has already moved. The QAD is the date that the child&#39;s eligibility for the MEP begins. The QAD is not affected by subsequent non-qualifying moves..</param>
        /// <param name="reasonExitedDescriptor">The reason the child left the Program within a school or district..</param>
        /// <param name="servedOutsideOfRegularSession">Indicates whether the Student received services during the summer session or between sessions..</param>
        /// <param name="stateResidencyDate">The verified State residency for the student..</param>
        /// <param name="usInitialEntry">The month, day, and year on which the Student first entered the U.S..</param>
        /// <param name="usInitialSchoolEntry">The month, day, and year on which the Student first entered a U.S. school..</param>
        /// <param name="usMostRecentEntry">The month, day, and year of the Student&#39;s most recent entry into the U.S..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStudentMigrantEducationProgramAssociation(string id = default(string), DateTime? beginDate = default(DateTime?), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiProgramReference programReference = default(EdFiProgramReference), EdFiStudentReference studentReference = default(EdFiStudentReference), string continuationOfServicesReasonDescriptor = default(string), DateTime? eligibilityExpirationDate = default(DateTime?), DateTime? endDate = default(DateTime?), DateTime? lastQualifyingMove = default(DateTime?), List<EdFiStudentMigrantEducationProgramAssociationMigrantEducationProgramService> migrantEducationProgramServices = default(List<EdFiStudentMigrantEducationProgramAssociationMigrantEducationProgramService>), EdFiGeneralStudentProgramAssociationParticipationStatus participationStatus = default(EdFiGeneralStudentProgramAssociationParticipationStatus), bool? priorityForServices = default(bool?), List<EdFiGeneralStudentProgramAssociationProgramParticipationStatus> programParticipationStatuses = default(List<EdFiGeneralStudentProgramAssociationProgramParticipationStatus>), DateTime? qualifyingArrivalDate = default(DateTime?), string reasonExitedDescriptor = default(string), bool? servedOutsideOfRegularSession = default(bool?), DateTime? stateResidencyDate = default(DateTime?), DateTime? usInitialEntry = default(DateTime?), DateTime? usInitialSchoolEntry = default(DateTime?), DateTime? usMostRecentEntry = default(DateTime?), string etag = default(string))
        {
            // to ensure "beginDate" is required (not null)
            if (beginDate == null)
            {
                throw new InvalidDataException("beginDate is a required property for EdFiStudentMigrantEducationProgramAssociation and cannot be null");
            }
            else
            {
                this.BeginDate = beginDate;
            }
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new InvalidDataException("educationOrganizationReference is a required property for EdFiStudentMigrantEducationProgramAssociation and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = educationOrganizationReference;
            }
            // to ensure "programReference" is required (not null)
            if (programReference == null)
            {
                throw new InvalidDataException("programReference is a required property for EdFiStudentMigrantEducationProgramAssociation and cannot be null");
            }
            else
            {
                this.ProgramReference = programReference;
            }
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new InvalidDataException("studentReference is a required property for EdFiStudentMigrantEducationProgramAssociation and cannot be null");
            }
            else
            {
                this.StudentReference = studentReference;
            }
            // to ensure "lastQualifyingMove" is required (not null)
            if (lastQualifyingMove == null)
            {
                throw new InvalidDataException("lastQualifyingMove is a required property for EdFiStudentMigrantEducationProgramAssociation and cannot be null");
            }
            else
            {
                this.LastQualifyingMove = lastQualifyingMove;
            }
            // to ensure "priorityForServices" is required (not null)
            if (priorityForServices == null)
            {
                throw new InvalidDataException("priorityForServices is a required property for EdFiStudentMigrantEducationProgramAssociation and cannot be null");
            }
            else
            {
                this.PriorityForServices = priorityForServices;
            }
            this.Id = id;
            this.ContinuationOfServicesReasonDescriptor = continuationOfServicesReasonDescriptor;
            this.EligibilityExpirationDate = eligibilityExpirationDate;
            this.EndDate = endDate;
            this.MigrantEducationProgramServices = migrantEducationProgramServices;
            this.ParticipationStatus = participationStatus;
            this.ProgramParticipationStatuses = programParticipationStatuses;
            this.QualifyingArrivalDate = qualifyingArrivalDate;
            this.ReasonExitedDescriptor = reasonExitedDescriptor;
            this.ServedOutsideOfRegularSession = servedOutsideOfRegularSession;
            this.StateResidencyDate = stateResidencyDate;
            this.UsInitialEntry = usInitialEntry;
            this.UsInitialSchoolEntry = usInitialSchoolEntry;
            this.UsMostRecentEntry = usMostRecentEntry;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.
        /// </summary>
        /// <value>The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name="educationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets ProgramReference
        /// </summary>
        [DataMember(Name="programReference", EmitDefaultValue=false)]
        public EdFiProgramReference ProgramReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name="studentReference", EmitDefaultValue=false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// The \&quot;continuation of services\&quot; provision found in Section 1304(e) of the statute provides that (1) a child who ceases to be a migratory child during a school term shall be eligible for services until the end of such term; (2) a child who is no longer a migratory child may continue to receive services for one additional school year, but only if comparable services are not available through other programs; and (3) secondary school students who were eligible for services in secondary school may continue to be served through credit accrual programs until graduation. Only students who received services at any time during their 36 month eligibility period may continue to receive services (not necessarily the same service).
        /// </summary>
        /// <value>The \&quot;continuation of services\&quot; provision found in Section 1304(e) of the statute provides that (1) a child who ceases to be a migratory child during a school term shall be eligible for services until the end of such term; (2) a child who is no longer a migratory child may continue to receive services for one additional school year, but only if comparable services are not available through other programs; and (3) secondary school students who were eligible for services in secondary school may continue to be served through credit accrual programs until graduation. Only students who received services at any time during their 36 month eligibility period may continue to receive services (not necessarily the same service).</value>
        [DataMember(Name="continuationOfServicesReasonDescriptor", EmitDefaultValue=false)]
        public string ContinuationOfServicesReasonDescriptor { get; set; }

        /// <summary>
        /// The Eligibility Expiration Date is used to determine end of eligibility and to account for a child&#39;s eligibility expiring earlier than 36 months from the child&#39;s QAD. A child&#39;s eligibility would end earlier than 36 months from the child&#39;s QAD, if the child is no longer entitled to a free public education (e.g., graduated with a high school diploma, obtained a high school equivalency diploma (HSED), or for other reasons as determined by States&#39; requirements), or if the child passes away.
        /// </summary>
        /// <value>The Eligibility Expiration Date is used to determine end of eligibility and to account for a child&#39;s eligibility expiring earlier than 36 months from the child&#39;s QAD. A child&#39;s eligibility would end earlier than 36 months from the child&#39;s QAD, if the child is no longer entitled to a free public education (e.g., graduated with a high school diploma, obtained a high school equivalency diploma (HSED), or for other reasons as determined by States&#39; requirements), or if the child passes away.</value>
        [DataMember(Name="eligibilityExpirationDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EligibilityExpirationDate { get; set; }

        /// <summary>
        /// The month, day, and year on which the Student exited the Program or stopped receiving services.
        /// </summary>
        /// <value>The month, day, and year on which the Student exited the Program or stopped receiving services.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Date the last qualifying move occurred; used to compute MEP status.
        /// </summary>
        /// <value>Date the last qualifying move occurred; used to compute MEP status.</value>
        [DataMember(Name="lastQualifyingMove", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastQualifyingMove { get; set; }

        /// <summary>
        /// An unordered collection of studentMigrantEducationProgramAssociationMigrantEducationProgramServices. Indicates the Service(s) being provided to the Student by the Migrant Education Program.
        /// </summary>
        /// <value>An unordered collection of studentMigrantEducationProgramAssociationMigrantEducationProgramServices. Indicates the Service(s) being provided to the Student by the Migrant Education Program.</value>
        [DataMember(Name="migrantEducationProgramServices", EmitDefaultValue=false)]
        public List<EdFiStudentMigrantEducationProgramAssociationMigrantEducationProgramService> MigrantEducationProgramServices { get; set; }

        /// <summary>
        /// Gets or Sets ParticipationStatus
        /// </summary>
        [DataMember(Name="participationStatus", EmitDefaultValue=false)]
        public EdFiGeneralStudentProgramAssociationParticipationStatus ParticipationStatus { get; set; }

        /// <summary>
        /// Report migratory children who are classified as having \&quot;priority for services\&quot; because they are failing, or most at risk of failing to meet the State&#39;s challenging State academic content standards and challenging State student academic achievement standards, and their education has been interrupted during the regular school year.
        /// </summary>
        /// <value>Report migratory children who are classified as having \&quot;priority for services\&quot; because they are failing, or most at risk of failing to meet the State&#39;s challenging State academic content standards and challenging State student academic achievement standards, and their education has been interrupted during the regular school year.</value>
        [DataMember(Name="priorityForServices", EmitDefaultValue=false)]
        public bool? PriorityForServices { get; set; }

        /// <summary>
        /// An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation.
        /// </summary>
        /// <value>An unordered collection of generalStudentProgramAssociationProgramParticipationStatuses. The status of the student&#39;s program participation.</value>
        [DataMember(Name="programParticipationStatuses", EmitDefaultValue=false)]
        public List<EdFiGeneralStudentProgramAssociationProgramParticipationStatus> ProgramParticipationStatuses { get; set; }

        /// <summary>
        /// The Qualifying Arrival Date (QAD) is the date the child joins the worker who has already moved, or the date when the worker joins the child who has already moved. The QAD is the date that the child&#39;s eligibility for the MEP begins. The QAD is not affected by subsequent non-qualifying moves.
        /// </summary>
        /// <value>The Qualifying Arrival Date (QAD) is the date the child joins the worker who has already moved, or the date when the worker joins the child who has already moved. The QAD is the date that the child&#39;s eligibility for the MEP begins. The QAD is not affected by subsequent non-qualifying moves.</value>
        [DataMember(Name="qualifyingArrivalDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? QualifyingArrivalDate { get; set; }

        /// <summary>
        /// The reason the child left the Program within a school or district.
        /// </summary>
        /// <value>The reason the child left the Program within a school or district.</value>
        [DataMember(Name="reasonExitedDescriptor", EmitDefaultValue=false)]
        public string ReasonExitedDescriptor { get; set; }

        /// <summary>
        /// Indicates whether the Student received services during the summer session or between sessions.
        /// </summary>
        /// <value>Indicates whether the Student received services during the summer session or between sessions.</value>
        [DataMember(Name="servedOutsideOfRegularSession", EmitDefaultValue=false)]
        public bool? ServedOutsideOfRegularSession { get; set; }

        /// <summary>
        /// The verified State residency for the student.
        /// </summary>
        /// <value>The verified State residency for the student.</value>
        [DataMember(Name="stateResidencyDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? StateResidencyDate { get; set; }

        /// <summary>
        /// The month, day, and year on which the Student first entered the U.S.
        /// </summary>
        /// <value>The month, day, and year on which the Student first entered the U.S.</value>
        [DataMember(Name="usInitialEntry", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? UsInitialEntry { get; set; }

        /// <summary>
        /// The month, day, and year on which the Student first entered a U.S. school.
        /// </summary>
        /// <value>The month, day, and year on which the Student first entered a U.S. school.</value>
        [DataMember(Name="usInitialSchoolEntry", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? UsInitialSchoolEntry { get; set; }

        /// <summary>
        /// The month, day, and year of the Student&#39;s most recent entry into the U.S.
        /// </summary>
        /// <value>The month, day, and year of the Student&#39;s most recent entry into the U.S.</value>
        [DataMember(Name="usMostRecentEntry", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? UsMostRecentEntry { get; set; }

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
            sb.Append("class EdFiStudentMigrantEducationProgramAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  ProgramReference: ").Append(ProgramReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  ContinuationOfServicesReasonDescriptor: ").Append(ContinuationOfServicesReasonDescriptor).Append("\n");
            sb.Append("  EligibilityExpirationDate: ").Append(EligibilityExpirationDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  LastQualifyingMove: ").Append(LastQualifyingMove).Append("\n");
            sb.Append("  MigrantEducationProgramServices: ").Append(MigrantEducationProgramServices).Append("\n");
            sb.Append("  ParticipationStatus: ").Append(ParticipationStatus).Append("\n");
            sb.Append("  PriorityForServices: ").Append(PriorityForServices).Append("\n");
            sb.Append("  ProgramParticipationStatuses: ").Append(ProgramParticipationStatuses).Append("\n");
            sb.Append("  QualifyingArrivalDate: ").Append(QualifyingArrivalDate).Append("\n");
            sb.Append("  ReasonExitedDescriptor: ").Append(ReasonExitedDescriptor).Append("\n");
            sb.Append("  ServedOutsideOfRegularSession: ").Append(ServedOutsideOfRegularSession).Append("\n");
            sb.Append("  StateResidencyDate: ").Append(StateResidencyDate).Append("\n");
            sb.Append("  UsInitialEntry: ").Append(UsInitialEntry).Append("\n");
            sb.Append("  UsInitialSchoolEntry: ").Append(UsInitialSchoolEntry).Append("\n");
            sb.Append("  UsMostRecentEntry: ").Append(UsMostRecentEntry).Append("\n");
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
            return this.Equals(input as EdFiStudentMigrantEducationProgramAssociation);
        }

        /// <summary>
        /// Returns true if EdFiStudentMigrantEducationProgramAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentMigrantEducationProgramAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentMigrantEducationProgramAssociation input)
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
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.ProgramReference == input.ProgramReference ||
                    (this.ProgramReference != null &&
                    this.ProgramReference.Equals(input.ProgramReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.ContinuationOfServicesReasonDescriptor == input.ContinuationOfServicesReasonDescriptor ||
                    (this.ContinuationOfServicesReasonDescriptor != null &&
                    this.ContinuationOfServicesReasonDescriptor.Equals(input.ContinuationOfServicesReasonDescriptor))
                ) && 
                (
                    this.EligibilityExpirationDate == input.EligibilityExpirationDate ||
                    (this.EligibilityExpirationDate != null &&
                    this.EligibilityExpirationDate.Equals(input.EligibilityExpirationDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.LastQualifyingMove == input.LastQualifyingMove ||
                    (this.LastQualifyingMove != null &&
                    this.LastQualifyingMove.Equals(input.LastQualifyingMove))
                ) && 
                (
                    this.MigrantEducationProgramServices == input.MigrantEducationProgramServices ||
                    this.MigrantEducationProgramServices != null &&
                    this.MigrantEducationProgramServices.SequenceEqual(input.MigrantEducationProgramServices)
                ) && 
                (
                    this.ParticipationStatus == input.ParticipationStatus ||
                    (this.ParticipationStatus != null &&
                    this.ParticipationStatus.Equals(input.ParticipationStatus))
                ) && 
                (
                    this.PriorityForServices == input.PriorityForServices ||
                    (this.PriorityForServices != null &&
                    this.PriorityForServices.Equals(input.PriorityForServices))
                ) && 
                (
                    this.ProgramParticipationStatuses == input.ProgramParticipationStatuses ||
                    this.ProgramParticipationStatuses != null &&
                    this.ProgramParticipationStatuses.SequenceEqual(input.ProgramParticipationStatuses)
                ) && 
                (
                    this.QualifyingArrivalDate == input.QualifyingArrivalDate ||
                    (this.QualifyingArrivalDate != null &&
                    this.QualifyingArrivalDate.Equals(input.QualifyingArrivalDate))
                ) && 
                (
                    this.ReasonExitedDescriptor == input.ReasonExitedDescriptor ||
                    (this.ReasonExitedDescriptor != null &&
                    this.ReasonExitedDescriptor.Equals(input.ReasonExitedDescriptor))
                ) && 
                (
                    this.ServedOutsideOfRegularSession == input.ServedOutsideOfRegularSession ||
                    (this.ServedOutsideOfRegularSession != null &&
                    this.ServedOutsideOfRegularSession.Equals(input.ServedOutsideOfRegularSession))
                ) && 
                (
                    this.StateResidencyDate == input.StateResidencyDate ||
                    (this.StateResidencyDate != null &&
                    this.StateResidencyDate.Equals(input.StateResidencyDate))
                ) && 
                (
                    this.UsInitialEntry == input.UsInitialEntry ||
                    (this.UsInitialEntry != null &&
                    this.UsInitialEntry.Equals(input.UsInitialEntry))
                ) && 
                (
                    this.UsInitialSchoolEntry == input.UsInitialSchoolEntry ||
                    (this.UsInitialSchoolEntry != null &&
                    this.UsInitialSchoolEntry.Equals(input.UsInitialSchoolEntry))
                ) && 
                (
                    this.UsMostRecentEntry == input.UsMostRecentEntry ||
                    (this.UsMostRecentEntry != null &&
                    this.UsMostRecentEntry.Equals(input.UsMostRecentEntry))
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
                if (this.BeginDate != null)
                    hashCode = hashCode * 59 + this.BeginDate.GetHashCode();
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.ProgramReference != null)
                    hashCode = hashCode * 59 + this.ProgramReference.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.ContinuationOfServicesReasonDescriptor != null)
                    hashCode = hashCode * 59 + this.ContinuationOfServicesReasonDescriptor.GetHashCode();
                if (this.EligibilityExpirationDate != null)
                    hashCode = hashCode * 59 + this.EligibilityExpirationDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.LastQualifyingMove != null)
                    hashCode = hashCode * 59 + this.LastQualifyingMove.GetHashCode();
                if (this.MigrantEducationProgramServices != null)
                    hashCode = hashCode * 59 + this.MigrantEducationProgramServices.GetHashCode();
                if (this.ParticipationStatus != null)
                    hashCode = hashCode * 59 + this.ParticipationStatus.GetHashCode();
                if (this.PriorityForServices != null)
                    hashCode = hashCode * 59 + this.PriorityForServices.GetHashCode();
                if (this.ProgramParticipationStatuses != null)
                    hashCode = hashCode * 59 + this.ProgramParticipationStatuses.GetHashCode();
                if (this.QualifyingArrivalDate != null)
                    hashCode = hashCode * 59 + this.QualifyingArrivalDate.GetHashCode();
                if (this.ReasonExitedDescriptor != null)
                    hashCode = hashCode * 59 + this.ReasonExitedDescriptor.GetHashCode();
                if (this.ServedOutsideOfRegularSession != null)
                    hashCode = hashCode * 59 + this.ServedOutsideOfRegularSession.GetHashCode();
                if (this.StateResidencyDate != null)
                    hashCode = hashCode * 59 + this.StateResidencyDate.GetHashCode();
                if (this.UsInitialEntry != null)
                    hashCode = hashCode * 59 + this.UsInitialEntry.GetHashCode();
                if (this.UsInitialSchoolEntry != null)
                    hashCode = hashCode * 59 + this.UsInitialSchoolEntry.GetHashCode();
                if (this.UsMostRecentEntry != null)
                    hashCode = hashCode * 59 + this.UsMostRecentEntry.GetHashCode();
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
            // ContinuationOfServicesReasonDescriptor (string) maxLength
            if(this.ContinuationOfServicesReasonDescriptor != null && this.ContinuationOfServicesReasonDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContinuationOfServicesReasonDescriptor, length must be less than 306.", new [] { "ContinuationOfServicesReasonDescriptor" });
            }

            // ReasonExitedDescriptor (string) maxLength
            if(this.ReasonExitedDescriptor != null && this.ReasonExitedDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReasonExitedDescriptor, length must be less than 306.", new [] { "ReasonExitedDescriptor" });
            }

            yield break;
        }
    }

}
