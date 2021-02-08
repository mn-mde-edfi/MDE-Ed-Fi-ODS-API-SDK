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

namespace EdFi.OdsApi.Sdk.Models.Profiles.Minnesota_Twenty_Twenty_Two_Preview_SISVendor_Profile
{
    /// <summary>
    /// EdFiSectionWritable
    /// </summary>
    [DataContract]
    public partial class EdFiSectionWritable :  IEquatable<EdFiSectionWritable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSectionWritable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiSectionWritable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiSectionWritable" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="SectionIdentifier">The local identifier assigned to a section. (required).</param>
        /// <param name="CourseOfferingReference">CourseOfferingReference (required).</param>
        /// <param name="Characteristics">An unordered collection of sectionCharacteristics. Reflects important characteristics of the Section, such as whether or not attendance is taken and the Section is graded..</param>
        /// <param name="InstructionLanguageDescriptor">The primary language of instruction, if omitted English is assumed..</param>
        /// <param name="MediumOfInstructionDescriptor">The media through which teachers provide instruction to students and students and teachers communicate about instructional matters; for example:          Technology-based instruction in classroom          Correspondence instruction          Face-to-face instruction          Virtual/On-line Distance learning          Center-based instruction          ....</param>
        /// <param name="SequenceOfCourse">When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1..</param>
        /// <param name="Etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiSectionWritable(string Id = default(string), string SectionIdentifier = default(string), EdFiCourseOfferingReference CourseOfferingReference = default(EdFiCourseOfferingReference), List<EdFiSectionCharacteristicWritable> Characteristics = default(List<EdFiSectionCharacteristicWritable>), string InstructionLanguageDescriptor = default(string), string MediumOfInstructionDescriptor = default(string), int? SequenceOfCourse = default(int?), string Etag = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for EdFiSectionWritable and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "SectionIdentifier" is required (not null)
            if (SectionIdentifier == null)
            {
                throw new InvalidDataException("SectionIdentifier is a required property for EdFiSectionWritable and cannot be null");
            }
            else
            {
                this.SectionIdentifier = SectionIdentifier;
            }
            // to ensure "CourseOfferingReference" is required (not null)
            if (CourseOfferingReference == null)
            {
                throw new InvalidDataException("CourseOfferingReference is a required property for EdFiSectionWritable and cannot be null");
            }
            else
            {
                this.CourseOfferingReference = CourseOfferingReference;
            }
            this.Characteristics = Characteristics;
            this.InstructionLanguageDescriptor = InstructionLanguageDescriptor;
            this.MediumOfInstructionDescriptor = MediumOfInstructionDescriptor;
            this.SequenceOfCourse = SequenceOfCourse;
            this.Etag = Etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The local identifier assigned to a section.
        /// </summary>
        /// <value>The local identifier assigned to a section.</value>
        [DataMember(Name="sectionIdentifier", EmitDefaultValue=false)]
        public string SectionIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets CourseOfferingReference
        /// </summary>
        [DataMember(Name="courseOfferingReference", EmitDefaultValue=false)]
        public EdFiCourseOfferingReference CourseOfferingReference { get; set; }

        /// <summary>
        /// An unordered collection of sectionCharacteristics. Reflects important characteristics of the Section, such as whether or not attendance is taken and the Section is graded.
        /// </summary>
        /// <value>An unordered collection of sectionCharacteristics. Reflects important characteristics of the Section, such as whether or not attendance is taken and the Section is graded.</value>
        [DataMember(Name="characteristics", EmitDefaultValue=false)]
        public List<EdFiSectionCharacteristicWritable> Characteristics { get; set; }

        /// <summary>
        /// The primary language of instruction, if omitted English is assumed.
        /// </summary>
        /// <value>The primary language of instruction, if omitted English is assumed.</value>
        [DataMember(Name="instructionLanguageDescriptor", EmitDefaultValue=false)]
        public string InstructionLanguageDescriptor { get; set; }

        /// <summary>
        /// The media through which teachers provide instruction to students and students and teachers communicate about instructional matters; for example:          Technology-based instruction in classroom          Correspondence instruction          Face-to-face instruction          Virtual/On-line Distance learning          Center-based instruction          ...
        /// </summary>
        /// <value>The media through which teachers provide instruction to students and students and teachers communicate about instructional matters; for example:          Technology-based instruction in classroom          Correspondence instruction          Face-to-face instruction          Virtual/On-line Distance learning          Center-based instruction          ...</value>
        [DataMember(Name="mediumOfInstructionDescriptor", EmitDefaultValue=false)]
        public string MediumOfInstructionDescriptor { get; set; }

        /// <summary>
        /// When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1.
        /// </summary>
        /// <value>When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1.</value>
        [DataMember(Name="sequenceOfCourse", EmitDefaultValue=false)]
        public int? SequenceOfCourse { get; set; }

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
            sb.Append("class EdFiSectionWritable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SectionIdentifier: ").Append(SectionIdentifier).Append("\n");
            sb.Append("  CourseOfferingReference: ").Append(CourseOfferingReference).Append("\n");
            sb.Append("  Characteristics: ").Append(Characteristics).Append("\n");
            sb.Append("  InstructionLanguageDescriptor: ").Append(InstructionLanguageDescriptor).Append("\n");
            sb.Append("  MediumOfInstructionDescriptor: ").Append(MediumOfInstructionDescriptor).Append("\n");
            sb.Append("  SequenceOfCourse: ").Append(SequenceOfCourse).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            return this.Equals(input as EdFiSectionWritable);
        }

        /// <summary>
        /// Returns true if EdFiSectionWritable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiSectionWritable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiSectionWritable input)
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
                    this.SectionIdentifier == input.SectionIdentifier ||
                    (this.SectionIdentifier != null &&
                    this.SectionIdentifier.Equals(input.SectionIdentifier))
                ) && 
                (
                    this.CourseOfferingReference == input.CourseOfferingReference ||
                    (this.CourseOfferingReference != null &&
                    this.CourseOfferingReference.Equals(input.CourseOfferingReference))
                ) && 
                (
                    this.Characteristics == input.Characteristics ||
                    this.Characteristics != null &&
                    this.Characteristics.SequenceEqual(input.Characteristics)
                ) && 
                (
                    this.InstructionLanguageDescriptor == input.InstructionLanguageDescriptor ||
                    (this.InstructionLanguageDescriptor != null &&
                    this.InstructionLanguageDescriptor.Equals(input.InstructionLanguageDescriptor))
                ) && 
                (
                    this.MediumOfInstructionDescriptor == input.MediumOfInstructionDescriptor ||
                    (this.MediumOfInstructionDescriptor != null &&
                    this.MediumOfInstructionDescriptor.Equals(input.MediumOfInstructionDescriptor))
                ) && 
                (
                    this.SequenceOfCourse == input.SequenceOfCourse ||
                    (this.SequenceOfCourse != null &&
                    this.SequenceOfCourse.Equals(input.SequenceOfCourse))
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
                if (this.SectionIdentifier != null)
                    hashCode = hashCode * 59 + this.SectionIdentifier.GetHashCode();
                if (this.CourseOfferingReference != null)
                    hashCode = hashCode * 59 + this.CourseOfferingReference.GetHashCode();
                if (this.Characteristics != null)
                    hashCode = hashCode * 59 + this.Characteristics.GetHashCode();
                if (this.InstructionLanguageDescriptor != null)
                    hashCode = hashCode * 59 + this.InstructionLanguageDescriptor.GetHashCode();
                if (this.MediumOfInstructionDescriptor != null)
                    hashCode = hashCode * 59 + this.MediumOfInstructionDescriptor.GetHashCode();
                if (this.SequenceOfCourse != null)
                    hashCode = hashCode * 59 + this.SequenceOfCourse.GetHashCode();
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
            // SectionIdentifier (string) maxLength
            if(this.SectionIdentifier != null && this.SectionIdentifier.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionIdentifier, length must be less than 255.", new [] { "SectionIdentifier" });
            }

            // InstructionLanguageDescriptor (string) maxLength
            if(this.InstructionLanguageDescriptor != null && this.InstructionLanguageDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstructionLanguageDescriptor, length must be less than 306.", new [] { "InstructionLanguageDescriptor" });
            }

            // MediumOfInstructionDescriptor (string) maxLength
            if(this.MediumOfInstructionDescriptor != null && this.MediumOfInstructionDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MediumOfInstructionDescriptor, length must be less than 306.", new [] { "MediumOfInstructionDescriptor" });
            }

            yield break;
        }
    }

}
