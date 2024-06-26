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
    /// EdFiDisciplineIncidentWritable
    /// </summary>
    [DataContract(Name = "edFi_disciplineIncident_writable")]
    public partial class EdFiDisciplineIncidentWritable : IEquatable<EdFiDisciplineIncidentWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiDisciplineIncidentWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiDisciplineIncidentWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiDisciplineIncidentWritable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="incidentIdentifier">A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders. (required).</param>
        /// <param name="locations">An unordered collection of disciplineIncidentLocations. Identifies where the DisciplineIncident occurred and whether or not it occurred on school, for example:        On school        Administrative offices area        Cafeteria area        Classroom        Hallway or stairs        ... (required).</param>
        /// <param name="schoolReference">schoolReference (required).</param>
        /// <param name="incidentDate">The month, day, and year on which the DisciplineIncident occurred. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">ext.</param>
        public EdFiDisciplineIncidentWritable(string id = default(string), string incidentIdentifier = default(string), List<EdFiDisciplineIncidentLocationWritable> locations = default(List<EdFiDisciplineIncidentLocationWritable>), EdFiSchoolReference schoolReference = default(EdFiSchoolReference), DateTime incidentDate = default(DateTime), string etag = default(string), DisciplineIncidentExtensionsWritable ext = default(DisciplineIncidentExtensionsWritable))
        {
            // to ensure "incidentIdentifier" is required (not null)
            if (incidentIdentifier == null)
            {
                throw new ArgumentNullException("incidentIdentifier is a required property for EdFiDisciplineIncidentWritable and cannot be null");
            }
            this.IncidentIdentifier = incidentIdentifier;
            // to ensure "locations" is required (not null)
            if (locations == null)
            {
                throw new ArgumentNullException("locations is a required property for EdFiDisciplineIncidentWritable and cannot be null");
            }
            this.Locations = locations;
            // to ensure "schoolReference" is required (not null)
            if (schoolReference == null)
            {
                throw new ArgumentNullException("schoolReference is a required property for EdFiDisciplineIncidentWritable and cannot be null");
            }
            this.SchoolReference = schoolReference;
            this.IncidentDate = incidentDate;
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
        /// A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders.
        /// </summary>
        /// <value>A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire DisciplineIncident even if it included multiple offenses and multiple offenders.</value>
        [DataMember(Name = "incidentIdentifier", IsRequired = true, EmitDefaultValue = false)]
        public string IncidentIdentifier { get; set; }

        /// <summary>
        /// An unordered collection of disciplineIncidentLocations. Identifies where the DisciplineIncident occurred and whether or not it occurred on school, for example:        On school        Administrative offices area        Cafeteria area        Classroom        Hallway or stairs        ...
        /// </summary>
        /// <value>An unordered collection of disciplineIncidentLocations. Identifies where the DisciplineIncident occurred and whether or not it occurred on school, for example:        On school        Administrative offices area        Cafeteria area        Classroom        Hallway or stairs        ...</value>
        [DataMember(Name = "locations", IsRequired = true, EmitDefaultValue = false)]
        public List<EdFiDisciplineIncidentLocationWritable> Locations { get; set; }

        /// <summary>
        /// Gets or Sets SchoolReference
        /// </summary>
        [DataMember(Name = "schoolReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiSchoolReference SchoolReference { get; set; }

        /// <summary>
        /// The month, day, and year on which the DisciplineIncident occurred.
        /// </summary>
        /// <value>The month, day, and year on which the DisciplineIncident occurred.</value>
        [DataMember(Name = "incidentDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime IncidentDate { get; set; }

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
        public DisciplineIncidentExtensionsWritable Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiDisciplineIncidentWritable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IncidentIdentifier: ").Append(IncidentIdentifier).Append("\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
            sb.Append("  SchoolReference: ").Append(SchoolReference).Append("\n");
            sb.Append("  IncidentDate: ").Append(IncidentDate).Append("\n");
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
            return this.Equals(input as EdFiDisciplineIncidentWritable);
        }

        /// <summary>
        /// Returns true if EdFiDisciplineIncidentWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiDisciplineIncidentWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiDisciplineIncidentWritable input)
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
                    this.IncidentIdentifier == input.IncidentIdentifier ||
                    (this.IncidentIdentifier != null &&
                    this.IncidentIdentifier.Equals(input.IncidentIdentifier))
                ) && 
                (
                    this.Locations == input.Locations ||
                    this.Locations != null &&
                    input.Locations != null &&
                    this.Locations.SequenceEqual(input.Locations)
                ) && 
                (
                    this.SchoolReference == input.SchoolReference ||
                    (this.SchoolReference != null &&
                    this.SchoolReference.Equals(input.SchoolReference))
                ) && 
                (
                    this.IncidentDate == input.IncidentDate ||
                    (this.IncidentDate != null &&
                    this.IncidentDate.Equals(input.IncidentDate))
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
                if (this.IncidentIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.IncidentIdentifier.GetHashCode();
                }
                if (this.Locations != null)
                {
                    hashCode = (hashCode * 59) + this.Locations.GetHashCode();
                }
                if (this.SchoolReference != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolReference.GetHashCode();
                }
                if (this.IncidentDate != null)
                {
                    hashCode = (hashCode * 59) + this.IncidentDate.GetHashCode();
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
            // IncidentIdentifier (string) maxLength
            if (this.IncidentIdentifier != null && this.IncidentIdentifier.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IncidentIdentifier, length must be less than 20.", new [] { "IncidentIdentifier" });
            }

            yield break;
        }
    }

}
