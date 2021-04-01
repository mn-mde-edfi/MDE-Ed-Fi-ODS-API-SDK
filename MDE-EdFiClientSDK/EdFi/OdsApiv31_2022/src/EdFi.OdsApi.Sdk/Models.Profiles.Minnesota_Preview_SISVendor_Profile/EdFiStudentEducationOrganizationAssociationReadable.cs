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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Preview_SISVendor_Profile
{
    /// <summary>
    /// EdFiStudentEducationOrganizationAssociationReadable
    /// </summary>
    [DataContract]
    public partial class EdFiStudentEducationOrganizationAssociationReadable :  IEquatable<EdFiStudentEducationOrganizationAssociationReadable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentEducationOrganizationAssociationReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentEducationOrganizationAssociationReadable" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="EducationOrganizationReference">EducationOrganizationReference (required).</param>
        /// <param name="StudentReference">StudentReference (required).</param>
        /// <param name="HispanicLatinoEthnicity">An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race. The term, \&quot;Spanish origin,\&quot; can be used in addition to \&quot;Hispanic or Latino.\&quot;.</param>
        /// <param name="Languages">An unordered collection of studentEducationOrganizationAssociationLanguages. The language(s) the individual uses to communicate. It is strongly recommended that entries use only ISO 639-3 language codes..</param>
        /// <param name="Races">An unordered collection of studentEducationOrganizationAssociationRaces. The general racial category which most clearly reflects the individual&#39;s recognition of his or her community or with which the individual most identifies. The data model allows for multiple entries so that each individual can specify all appropriate races..</param>
        /// <param name="SexDescriptor">A person&#39;s gender. (required).</param>
        /// <param name="StudentCharacteristics">An unordered collection of studentEducationOrganizationAssociationStudentCharacteristics. Reflects important characteristics of the student&#39;s home situation:          Displaced Homemaker, Immigrant, Migratory, Military Parent, Pregnant Teen, Single Parent, and Unaccompanied Youth..</param>
        /// <param name="StudentIdentificationCodes">An unordered collection of studentEducationOrganizationAssociationStudentIdentificationCodes. A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student..</param>
        /// <param name="StudentIndicators">An unordered collection of studentEducationOrganizationAssociationStudentIndicators. Indicator(s) or metric(s) computed for the student (e.g., at risk) to influence more effective education or direct specific interventions..</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="Ext">Ext.</param>
        public EdFiStudentEducationOrganizationAssociationReadable(string Id = default(string), EdFiEducationOrganizationReference EducationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiStudentReference StudentReference = default(EdFiStudentReference), bool? HispanicLatinoEthnicity = default(bool?), List<EdFiStudentEducationOrganizationAssociationLanguageReadable> Languages = default(List<EdFiStudentEducationOrganizationAssociationLanguageReadable>), List<EdFiStudentEducationOrganizationAssociationRaceReadable> Races = default(List<EdFiStudentEducationOrganizationAssociationRaceReadable>), string SexDescriptor = default(string), List<EdFiStudentEducationOrganizationAssociationStudentCharacteristicReadable> StudentCharacteristics = default(List<EdFiStudentEducationOrganizationAssociationStudentCharacteristicReadable>), List<EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeReadable> StudentIdentificationCodes = default(List<EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeReadable>), List<EdFiStudentEducationOrganizationAssociationStudentIndicatorReadable> StudentIndicators = default(List<EdFiStudentEducationOrganizationAssociationStudentIndicatorReadable>), string Etag = default(string), StudentEducationOrganizationAssociationExtensionsReadable Ext = default(StudentEducationOrganizationAssociationExtensionsReadable))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiStudentEducationOrganizationAssociationReadable and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "EducationOrganizationReference" is required (not null)
            if (EducationOrganizationReference == null)
            {
                throw new InvalidDataException("EducationOrganizationReference is a required property for EdFiStudentEducationOrganizationAssociationReadable and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = EducationOrganizationReference;
            }
            // to ensure "StudentReference" is required (not null)
            if (StudentReference == null)
            {
                throw new InvalidDataException("StudentReference is a required property for EdFiStudentEducationOrganizationAssociationReadable and cannot be null");
            }
            else
            {
                this.StudentReference = StudentReference;
            }
            // to ensure "SexDescriptor" is required (not null)
            if (SexDescriptor == null)
            {
                throw new InvalidDataException("SexDescriptor is a required property for EdFiStudentEducationOrganizationAssociationReadable and cannot be null");
            }
            else
            {
                this.SexDescriptor = SexDescriptor;
            }
            this.HispanicLatinoEthnicity = HispanicLatinoEthnicity;
            this.Languages = Languages;
            this.Races = Races;
            this.StudentCharacteristics = StudentCharacteristics;
            this.StudentIdentificationCodes = StudentIdentificationCodes;
            this.StudentIndicators = StudentIndicators;
            this.Etag = Etag;
            this.Ext = Ext;
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
        /// An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race. The term, \&quot;Spanish origin,\&quot; can be used in addition to \&quot;Hispanic or Latino.\&quot;
        /// </summary>
        /// <value>An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race. The term, \&quot;Spanish origin,\&quot; can be used in addition to \&quot;Hispanic or Latino.\&quot;</value>
        [DataMember(Name="hispanicLatinoEthnicity", EmitDefaultValue=false)]
        public bool? HispanicLatinoEthnicity { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationLanguages. The language(s) the individual uses to communicate. It is strongly recommended that entries use only ISO 639-3 language codes.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationLanguages. The language(s) the individual uses to communicate. It is strongly recommended that entries use only ISO 639-3 language codes.</value>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationLanguageReadable> Languages { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationRaces. The general racial category which most clearly reflects the individual&#39;s recognition of his or her community or with which the individual most identifies. The data model allows for multiple entries so that each individual can specify all appropriate races.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationRaces. The general racial category which most clearly reflects the individual&#39;s recognition of his or her community or with which the individual most identifies. The data model allows for multiple entries so that each individual can specify all appropriate races.</value>
        [DataMember(Name="races", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationRaceReadable> Races { get; set; }

        /// <summary>
        /// A person&#39;s gender.
        /// </summary>
        /// <value>A person&#39;s gender.</value>
        [DataMember(Name="sexDescriptor", EmitDefaultValue=false)]
        public string SexDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationStudentCharacteristics. Reflects important characteristics of the student&#39;s home situation:          Displaced Homemaker, Immigrant, Migratory, Military Parent, Pregnant Teen, Single Parent, and Unaccompanied Youth.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationStudentCharacteristics. Reflects important characteristics of the student&#39;s home situation:          Displaced Homemaker, Immigrant, Migratory, Military Parent, Pregnant Teen, Single Parent, and Unaccompanied Youth.</value>
        [DataMember(Name="studentCharacteristics", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationStudentCharacteristicReadable> StudentCharacteristics { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationStudentIdentificationCodes. A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationStudentIdentificationCodes. A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student.</value>
        [DataMember(Name="studentIdentificationCodes", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationStudentIdentificationCodeReadable> StudentIdentificationCodes { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationStudentIndicators. Indicator(s) or metric(s) computed for the student (e.g., at risk) to influence more effective education or direct specific interventions.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationStudentIndicators. Indicator(s) or metric(s) computed for the student (e.g., at risk) to influence more effective education or direct specific interventions.</value>
        [DataMember(Name="studentIndicators", EmitDefaultValue=false)]
        public List<EdFiStudentEducationOrganizationAssociationStudentIndicatorReadable> StudentIndicators { get; set; }

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
        public StudentEducationOrganizationAssociationExtensionsReadable Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentEducationOrganizationAssociationReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
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
            return this.Equals(input as EdFiStudentEducationOrganizationAssociationReadable);
        }

        /// <summary>
        /// Returns true if EdFiStudentEducationOrganizationAssociationReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentEducationOrganizationAssociationReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentEducationOrganizationAssociationReadable input)
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

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // SexDescriptor (string) maxLength
            if(this.SexDescriptor != null && this.SexDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SexDescriptor, length must be less than 306.", new [] { "SexDescriptor" });
            }

            yield break;
        }
    }

}
