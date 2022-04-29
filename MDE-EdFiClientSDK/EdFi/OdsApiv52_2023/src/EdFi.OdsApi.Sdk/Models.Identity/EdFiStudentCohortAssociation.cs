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
    /// EdFiStudentCohortAssociation
    /// </summary>
    [DataContract]
    public partial class EdFiStudentCohortAssociation :  IEquatable<EdFiStudentCohortAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentCohortAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentCohortAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentCohortAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="beginDate">The month, day, and year on which the Student was first identified as part of the Cohort. (required).</param>
        /// <param name="cohortReference">cohortReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="endDate">The month, day, and year on which the Student was removed as part of the Cohort..</param>
        /// <param name="sections">An unordered collection of studentCohortAssociationSections. The Cohort representing the subdivision of students within one or more sections. For example, a group of students may be given additional instruction and tracked as a cohort..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStudentCohortAssociation(string id = default(string), DateTime? beginDate = default(DateTime?), EdFiCohortReference cohortReference = default(EdFiCohortReference), EdFiStudentReference studentReference = default(EdFiStudentReference), DateTime? endDate = default(DateTime?), List<EdFiStudentCohortAssociationSection> sections = default(List<EdFiStudentCohortAssociationSection>), string etag = default(string))
        {
            // to ensure "beginDate" is required (not null)
            if (beginDate == null)
            {
                throw new InvalidDataException("beginDate is a required property for EdFiStudentCohortAssociation and cannot be null");
            }
            else
            {
                this.BeginDate = beginDate;
            }
            // to ensure "cohortReference" is required (not null)
            if (cohortReference == null)
            {
                throw new InvalidDataException("cohortReference is a required property for EdFiStudentCohortAssociation and cannot be null");
            }
            else
            {
                this.CohortReference = cohortReference;
            }
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new InvalidDataException("studentReference is a required property for EdFiStudentCohortAssociation and cannot be null");
            }
            else
            {
                this.StudentReference = studentReference;
            }
            this.Id = id;
            this.EndDate = endDate;
            this.Sections = sections;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The month, day, and year on which the Student was first identified as part of the Cohort.
        /// </summary>
        /// <value>The month, day, and year on which the Student was first identified as part of the Cohort.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// Gets or Sets CohortReference
        /// </summary>
        [DataMember(Name="cohortReference", EmitDefaultValue=false)]
        public EdFiCohortReference CohortReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name="studentReference", EmitDefaultValue=false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// The month, day, and year on which the Student was removed as part of the Cohort.
        /// </summary>
        /// <value>The month, day, and year on which the Student was removed as part of the Cohort.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// An unordered collection of studentCohortAssociationSections. The Cohort representing the subdivision of students within one or more sections. For example, a group of students may be given additional instruction and tracked as a cohort.
        /// </summary>
        /// <value>An unordered collection of studentCohortAssociationSections. The Cohort representing the subdivision of students within one or more sections. For example, a group of students may be given additional instruction and tracked as a cohort.</value>
        [DataMember(Name="sections", EmitDefaultValue=false)]
        public List<EdFiStudentCohortAssociationSection> Sections { get; set; }

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
            sb.Append("class EdFiStudentCohortAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  CohortReference: ").Append(CohortReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Sections: ").Append(Sections).Append("\n");
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
            return this.Equals(input as EdFiStudentCohortAssociation);
        }

        /// <summary>
        /// Returns true if EdFiStudentCohortAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentCohortAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentCohortAssociation input)
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
                    this.CohortReference == input.CohortReference ||
                    (this.CohortReference != null &&
                    this.CohortReference.Equals(input.CohortReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Sections == input.Sections ||
                    this.Sections != null &&
                    this.Sections.SequenceEqual(input.Sections)
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
                if (this.CohortReference != null)
                    hashCode = hashCode * 59 + this.CohortReference.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Sections != null)
                    hashCode = hashCode * 59 + this.Sections.GetHashCode();
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
            yield break;
        }
    }

}
