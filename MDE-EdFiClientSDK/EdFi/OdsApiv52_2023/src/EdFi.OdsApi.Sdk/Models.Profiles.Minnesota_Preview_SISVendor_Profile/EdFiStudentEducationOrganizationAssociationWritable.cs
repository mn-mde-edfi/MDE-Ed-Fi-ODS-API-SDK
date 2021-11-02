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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile
{
    /// <summary>
    /// EdFiStudentEducationOrganizationAssociationWritable
    /// </summary>
    [DataContract]
    public partial class EdFiStudentEducationOrganizationAssociationWritable :  IEquatable<EdFiStudentEducationOrganizationAssociationWritable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentEducationOrganizationAssociationWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationWritable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="ancestryEthnicOrigins">An unordered collection of studentEducationOrganizationAssociationAncestryEthnicOrigins. The original peoples or cultures with which the individual identifies..</param>
        /// <param name="hispanicLatinoEthnicity">An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race, as last reported to the education organization. The term, \&quot;Spanish origin,\&quot; can be used in addition to \&quot;Hispanic or Latino.\&quot;.</param>
        /// <param name="languages">An unordered collection of studentEducationOrganizationAssociationLanguages. The language(s) the individual uses to communicate. It is strongly recommended that entries use only ISO 639-3 language codes..</param>
        /// <param name="races">An unordered collection of studentEducationOrganizationAssociationRaces. The general racial category which most clearly reflects the individual&#39;s recognition of his or her community or with which the individual most identifies as last reported to the education organization. The data model allows for multiple entries so that each individual can specify all appropriate races..</param>
        /// <param name="sexDescriptor">The student&#39;s gender as last reported to the education organization. (required).</param>
        /// <param name="studentCharacteristics">An unordered collection of studentEducationOrganizationAssociationStudentCharacteristics. Reflects important characteristics of a student. If a student has a characteristic present, that characteristic is considered true or active for that student. If a characteristic is not present, no assumption is made as to the applicability of the characteristic, but local policy may dictate otherwise..</param>
        /// <param name="studentIdentificationCodes">An unordered collection of studentEducationOrganizationAssociationStudentIdentificationCodes. A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student..</param>
        /// <param name="studentIndicators">An unordered collection of studentEducationOrganizationAssociationStudentIndicators. An indicator or metric computed for the student (e.g., at risk)..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">ext.</param>
        public EdFiStudentEducationOrganizationAssociationWritable(string id = default(string), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiStudentReference studentReference = default(EdFiStudentReference), List<EdFiStudentEducationOrganizationAssociationAncestryEthnicOriginWritable> ancestryEthnicOrigins = default(List<EdFiStudentEducationOrganizationAssociationAncestryEthnicOriginWritable>), bool? hispanicLatinoEthnicity = default(bool?), List<EdFiStudentEducationOrganizationAssociationLanguageWritable> languages = default(List<EdFiStudentEducationOrganizationAssociationLanguageWritable>), List<EdFiStudentEducationOrganizationAssociationRaceWritable> races = default(List<EdFiStudentEducationOrganizationAssociationRaceWritable>), string sexDescriptor = default(string), List<EdFiStudentEducationOrganizationAssociationStudentCharacteristicWritable> studentCharacteristics = default(List<EdFiStudentEducationOrganizationAssociationStudentCharacteristicWritable>), List<EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeWritable> studentIdentificationCodes = default(List<EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeWritable>), List<EdFiStudentEducationOrganizationAssociationStudentIndicatorWritable> studentIndicators = default(List<EdFiStudentEducationOrganizationAssociationStudentIndicatorWritable>), string etag = default(string), StudentEducationOrganizationAssociationExtensionsWritable ext = default(StudentEducationOrganizationAssociationExtensionsWritable))
        {
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new InvalidDataException("educationOrganizationReference is a required property for EdFiStudentEducationOrganizationAssociationWritable and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = educationOrganizationReference;
            }
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new InvalidDataException("studentReference is a required property for EdFiStudentEducationOrganizationAssociationWritable and cannot be null");
            }
            else
            {
                this.StudentReference = studentReference;
            }
            // to ensure "sexDescriptor" is required (not null)
            if (sexDescriptor == null)
            {
                throw new InvalidDataException("sexDescriptor is a required property for EdFiStudentEducationOrganizationAssociationWritable and cannot be null");
            }
            else
            {
                this.SexDescriptor = sexDescriptor;
            }
            this.Id = id;
            this.AncestryEthnicOrigins = ancestryEthnicOrigins;
            this.HispanicLatinoEthnicity = hispanicLatinoEthnicity;
            this.Languages = languages;
            this.Races = races;
            this.StudentCharacteristics = studentCharacteristics;
            this.StudentIdentificationCodes = studentIdentificationCodes;
            this.StudentIndicators = studentIndicators;
            this.Etag = etag;
            this.Ext = ext;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name="educationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name="studentReference", EmitDefaultValue=false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationAncestryEthnicOrigins. The original peoples or cultures with which the individual identifies.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationAncestryEthnicOrigins. The original peoples or cultures with which the individual identifies.</value>
        [DataMember(Name="ancestryEthnicOrigins", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationAncestryEthnicOriginWritable> AncestryEthnicOrigins { get; set; }

        /// <summary>
        /// An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race, as last reported to the education organization. The term, \&quot;Spanish origin,\&quot; can be used in addition to \&quot;Hispanic or Latino.\&quot;
        /// </summary>
        /// <value>An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race, as last reported to the education organization. The term, \&quot;Spanish origin,\&quot; can be used in addition to \&quot;Hispanic or Latino.\&quot;</value>
        [DataMember(Name="hispanicLatinoEthnicity", EmitDefaultValue=false)]
        public bool? HispanicLatinoEthnicity { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationLanguages. The language(s) the individual uses to communicate. It is strongly recommended that entries use only ISO 639-3 language codes.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationLanguages. The language(s) the individual uses to communicate. It is strongly recommended that entries use only ISO 639-3 language codes.</value>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationLanguageWritable> Languages { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationRaces. The general racial category which most clearly reflects the individual&#39;s recognition of his or her community or with which the individual most identifies as last reported to the education organization. The data model allows for multiple entries so that each individual can specify all appropriate races.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationRaces. The general racial category which most clearly reflects the individual&#39;s recognition of his or her community or with which the individual most identifies as last reported to the education organization. The data model allows for multiple entries so that each individual can specify all appropriate races.</value>
        [DataMember(Name="races", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationRaceWritable> Races { get; set; }

        /// <summary>
        /// The student&#39;s gender as last reported to the education organization.
        /// </summary>
        /// <value>The student&#39;s gender as last reported to the education organization.</value>
        [DataMember(Name="sexDescriptor", EmitDefaultValue=false)]
        public string SexDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationStudentCharacteristics. Reflects important characteristics of a student. If a student has a characteristic present, that characteristic is considered true or active for that student. If a characteristic is not present, no assumption is made as to the applicability of the characteristic, but local policy may dictate otherwise.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationStudentCharacteristics. Reflects important characteristics of a student. If a student has a characteristic present, that characteristic is considered true or active for that student. If a characteristic is not present, no assumption is made as to the applicability of the characteristic, but local policy may dictate otherwise.</value>
        [DataMember(Name="studentCharacteristics", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationStudentCharacteristicWritable> StudentCharacteristics { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationStudentIdentificationCodes. A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationStudentIdentificationCodes. A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student.</value>
        [DataMember(Name="studentIdentificationCodes", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeWritable> StudentIdentificationCodes { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationStudentIndicators. An indicator or metric computed for the student (e.g., at risk).
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationStudentIndicators. An indicator or metric computed for the student (e.g., at risk).</value>
        [DataMember(Name="studentIndicators", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationStudentIndicatorWritable> StudentIndicators { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or Sets Ext
        /// </summary>
        [DataMember(Name="_ext", EmitDefaultValue=false)]
        public StudentEducationOrganizationAssociationExtensionsWritable Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentEducationOrganizationAssociationWritable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  AncestryEthnicOrigins: ").Append(AncestryEthnicOrigins).Append("\n");
            sb.Append("  HispanicLatinoEthnicity: ").Append(HispanicLatinoEthnicity).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  Races: ").Append(Races).Append("\n");
            sb.Append("  SexDescriptor: ").Append(SexDescriptor).Append("\n");
            sb.Append("  StudentCharacteristics: ").Append(StudentCharacteristics).Append("\n");
            sb.Append("  StudentIdentificationCodes: ").Append(StudentIdentificationCodes).Append("\n");
            sb.Append("  StudentIndicators: ").Append(StudentIndicators).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiStudentEducationOrganizationAssociationWritable);
        }

        /// <summary>
        /// Returns true if EdFiStudentEducationOrganizationAssociationWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentEducationOrganizationAssociationWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentEducationOrganizationAssociationWritable input)
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
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) && 
                (
                    this.AncestryEthnicOrigins == input.AncestryEthnicOrigins ||
                    this.AncestryEthnicOrigins != null &&
                    this.AncestryEthnicOrigins.SequenceEqual(input.AncestryEthnicOrigins)
                ) && 
                (
                    this.HispanicLatinoEthnicity == input.HispanicLatinoEthnicity ||
                    (this.HispanicLatinoEthnicity != null &&
                    this.HispanicLatinoEthnicity.Equals(input.HispanicLatinoEthnicity))
                ) && 
                (
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                ) && 
                (
                    this.Races == input.Races ||
                    this.Races != null &&
                    this.Races.SequenceEqual(input.Races)
                ) && 
                (
                    this.SexDescriptor == input.SexDescriptor ||
                    (this.SexDescriptor != null &&
                    this.SexDescriptor.Equals(input.SexDescriptor))
                ) && 
                (
                    this.StudentCharacteristics == input.StudentCharacteristics ||
                    this.StudentCharacteristics != null &&
                    this.StudentCharacteristics.SequenceEqual(input.StudentCharacteristics)
                ) && 
                (
                    this.StudentIdentificationCodes == input.StudentIdentificationCodes ||
                    this.StudentIdentificationCodes != null &&
                    this.StudentIdentificationCodes.SequenceEqual(input.StudentIdentificationCodes)
                ) && 
                (
                    this.StudentIndicators == input.StudentIndicators ||
                    this.StudentIndicators != null &&
                    this.StudentIndicators.SequenceEqual(input.StudentIndicators)
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.StudentReference != null)
                    hashCode = hashCode * 59 + this.StudentReference.GetHashCode();
                if (this.AncestryEthnicOrigins != null)
                    hashCode = hashCode * 59 + this.AncestryEthnicOrigins.GetHashCode();
                if (this.HispanicLatinoEthnicity != null)
                    hashCode = hashCode * 59 + this.HispanicLatinoEthnicity.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
                if (this.Races != null)
                    hashCode = hashCode * 59 + this.Races.GetHashCode();
                if (this.SexDescriptor != null)
                    hashCode = hashCode * 59 + this.SexDescriptor.GetHashCode();
                if (this.StudentCharacteristics != null)
                    hashCode = hashCode * 59 + this.StudentCharacteristics.GetHashCode();
                if (this.StudentIdentificationCodes != null)
                    hashCode = hashCode * 59 + this.StudentIdentificationCodes.GetHashCode();
                if (this.StudentIndicators != null)
                    hashCode = hashCode * 59 + this.StudentIndicators.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
                return hashCode;
            }
        }
    }

}
