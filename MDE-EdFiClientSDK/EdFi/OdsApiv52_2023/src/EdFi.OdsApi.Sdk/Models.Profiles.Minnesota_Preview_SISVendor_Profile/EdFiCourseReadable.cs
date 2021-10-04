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
    /// EdFiCourseReadable
    /// </summary>
    [DataContract]
    public partial class EdFiCourseReadable :  IEquatable<EdFiCourseReadable>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseReadable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCourseReadable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseReadable" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="courseCode">A unique alphanumeric code assigned to a course. (required).</param>
        /// <param name="identificationCodes">An unordered collection of courseIdentificationCodes. The code that identifies the organization of subject matter and related learning experiences provided for the instruction of students. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="courseDefinedByDescriptor">Specifies whether the course was defined by the SEA, LEA, School, or national organization..</param>
        /// <param name="courseDescription">A description of the content standards and goals covered in the course. Reference may be made to state or national content standards..</param>
        /// <param name="courseTitle">The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, and language arts). (required).</param>
        /// <param name="dateCourseAdopted">Date the course was adopted by the education agency..</param>
        /// <param name="highSchoolCourseRequirement">An indication that this course may satisfy high school graduation requirements in the course&#39;s subject area..</param>
        /// <param name="learningStandards">An unordered collection of courseLearningStandards. Learning Standard(s) to be taught by the course..</param>
        /// <param name="levelCharacteristics">An unordered collection of courseLevelCharacteristics. The type of specific program or designation with which the course is associated (e.g., AP, IB, Dual Credit, CTE)..</param>
        /// <param name="maximumAvailableCredits">The value of credits or units of value awarded for the completion of a course..</param>
        /// <param name="numberOfParts">The number of parts identified for a course. (required).</param>
        /// <param name="offeredGradeLevels">An unordered collection of courseOfferedGradeLevels. The grade levels in which the course is offered..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">ext.</param>
        public EdFiCourseReadable(string id = default(string), string courseCode = default(string), List<EdFiCourseIdentificationCodeReadable> identificationCodes = default(List<EdFiCourseIdentificationCodeReadable>), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), string courseDefinedByDescriptor = default(string), string courseDescription = default(string), string courseTitle = default(string), DateTime? dateCourseAdopted = default(DateTime?), bool? highSchoolCourseRequirement = default(bool?), List<EdFiCourseLearningStandardReadable> learningStandards = default(List<EdFiCourseLearningStandardReadable>), List<EdFiCourseLevelCharacteristicReadable> levelCharacteristics = default(List<EdFiCourseLevelCharacteristicReadable>), double? maximumAvailableCredits = default(double?), int? numberOfParts = default(int?), List<EdFiCourseOfferedGradeLevelReadable> offeredGradeLevels = default(List<EdFiCourseOfferedGradeLevelReadable>), string etag = default(string), CourseExtensionsReadable ext = default(CourseExtensionsReadable))
        {
            // to ensure "courseCode" is required (not null)
            if (courseCode == null)
            {
                throw new InvalidDataException("courseCode is a required property for EdFiCourseReadable and cannot be null");
            }
            else
            {
                this.CourseCode = courseCode;
            }
            // to ensure "identificationCodes" is required (not null)
            if (identificationCodes == null)
            {
                throw new InvalidDataException("identificationCodes is a required property for EdFiCourseReadable and cannot be null");
            }
            else
            {
                this.IdentificationCodes = identificationCodes;
            }
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new InvalidDataException("educationOrganizationReference is a required property for EdFiCourseReadable and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = educationOrganizationReference;
            }
            // to ensure "courseTitle" is required (not null)
            if (courseTitle == null)
            {
                throw new InvalidDataException("courseTitle is a required property for EdFiCourseReadable and cannot be null");
            }
            else
            {
                this.CourseTitle = courseTitle;
            }
            // to ensure "numberOfParts" is required (not null)
            if (numberOfParts == null)
            {
                throw new InvalidDataException("numberOfParts is a required property for EdFiCourseReadable and cannot be null");
            }
            else
            {
                this.NumberOfParts = numberOfParts;
            }
            this.Id = id;
            this.CourseDefinedByDescriptor = courseDefinedByDescriptor;
            this.CourseDescription = courseDescription;
            this.DateCourseAdopted = dateCourseAdopted;
            this.HighSchoolCourseRequirement = highSchoolCourseRequirement;
            this.LearningStandards = learningStandards;
            this.LevelCharacteristics = levelCharacteristics;
            this.MaximumAvailableCredits = maximumAvailableCredits;
            this.OfferedGradeLevels = offeredGradeLevels;
            this.Etag = etag;
            this.Ext = ext;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a course.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a course.</value>
        [DataMember(Name="courseCode", EmitDefaultValue=false)]
        public string CourseCode { get; set; }

        /// <summary>
        /// An unordered collection of courseIdentificationCodes. The code that identifies the organization of subject matter and related learning experiences provided for the instruction of students.
        /// </summary>
        /// <value>An unordered collection of courseIdentificationCodes. The code that identifies the organization of subject matter and related learning experiences provided for the instruction of students.</value>
        [DataMember(Name="identificationCodes", EmitDefaultValue=false)]
        public List<EdFiCourseIdentificationCodeReadable> IdentificationCodes { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name="educationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// Specifies whether the course was defined by the SEA, LEA, School, or national organization.
        /// </summary>
        /// <value>Specifies whether the course was defined by the SEA, LEA, School, or national organization.</value>
        [DataMember(Name="courseDefinedByDescriptor", EmitDefaultValue=false)]
        public string CourseDefinedByDescriptor { get; set; }

        /// <summary>
        /// A description of the content standards and goals covered in the course. Reference may be made to state or national content standards.
        /// </summary>
        /// <value>A description of the content standards and goals covered in the course. Reference may be made to state or national content standards.</value>
        [DataMember(Name="courseDescription", EmitDefaultValue=false)]
        public string CourseDescription { get; set; }

        /// <summary>
        /// The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, and language arts).
        /// </summary>
        /// <value>The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, and language arts).</value>
        [DataMember(Name="courseTitle", EmitDefaultValue=false)]
        public string CourseTitle { get; set; }

        /// <summary>
        /// Date the course was adopted by the education agency.
        /// </summary>
        /// <value>Date the course was adopted by the education agency.</value>
        [DataMember(Name="dateCourseAdopted", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DateCourseAdopted { get; set; }

        /// <summary>
        /// An indication that this course may satisfy high school graduation requirements in the course&#39;s subject area.
        /// </summary>
        /// <value>An indication that this course may satisfy high school graduation requirements in the course&#39;s subject area.</value>
        [DataMember(Name="highSchoolCourseRequirement", EmitDefaultValue=false)]
        public bool? HighSchoolCourseRequirement { get; set; }

        /// <summary>
        /// An unordered collection of courseLearningStandards. Learning Standard(s) to be taught by the course.
        /// </summary>
        /// <value>An unordered collection of courseLearningStandards. Learning Standard(s) to be taught by the course.</value>
        [DataMember(Name="learningStandards", EmitDefaultValue=false)]
        public List<EdFiCourseLearningStandardReadable> LearningStandards { get; set; }

        /// <summary>
        /// An unordered collection of courseLevelCharacteristics. The type of specific program or designation with which the course is associated (e.g., AP, IB, Dual Credit, CTE).
        /// </summary>
        /// <value>An unordered collection of courseLevelCharacteristics. The type of specific program or designation with which the course is associated (e.g., AP, IB, Dual Credit, CTE).</value>
        [DataMember(Name="levelCharacteristics", EmitDefaultValue=false)]
        public List<EdFiCourseLevelCharacteristicReadable> LevelCharacteristics { get; set; }

        /// <summary>
        /// The value of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The value of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="maximumAvailableCredits", EmitDefaultValue=false)]
        public double? MaximumAvailableCredits { get; set; }

        /// <summary>
        /// The number of parts identified for a course.
        /// </summary>
        /// <value>The number of parts identified for a course.</value>
        [DataMember(Name="numberOfParts", EmitDefaultValue=false)]
        public int? NumberOfParts { get; set; }

        /// <summary>
        /// An unordered collection of courseOfferedGradeLevels. The grade levels in which the course is offered.
        /// </summary>
        /// <value>An unordered collection of courseOfferedGradeLevels. The grade levels in which the course is offered.</value>
        [DataMember(Name="offeredGradeLevels", EmitDefaultValue=false)]
        public List<EdFiCourseOfferedGradeLevelReadable> OfferedGradeLevels { get; set; }

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
        public CourseExtensionsReadable Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiCourseReadable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CourseCode: ").Append(CourseCode).Append("\n");
            sb.Append("  IdentificationCodes: ").Append(IdentificationCodes).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  CourseDefinedByDescriptor: ").Append(CourseDefinedByDescriptor).Append("\n");
            sb.Append("  CourseDescription: ").Append(CourseDescription).Append("\n");
            sb.Append("  CourseTitle: ").Append(CourseTitle).Append("\n");
            sb.Append("  DateCourseAdopted: ").Append(DateCourseAdopted).Append("\n");
            sb.Append("  HighSchoolCourseRequirement: ").Append(HighSchoolCourseRequirement).Append("\n");
            sb.Append("  LearningStandards: ").Append(LearningStandards).Append("\n");
            sb.Append("  LevelCharacteristics: ").Append(LevelCharacteristics).Append("\n");
            sb.Append("  MaximumAvailableCredits: ").Append(MaximumAvailableCredits).Append("\n");
            sb.Append("  NumberOfParts: ").Append(NumberOfParts).Append("\n");
            sb.Append("  OfferedGradeLevels: ").Append(OfferedGradeLevels).Append("\n");
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
            return this.Equals(input as EdFiCourseReadable);
        }

        /// <summary>
        /// Returns true if EdFiCourseReadable instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCourseReadable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCourseReadable input)
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
                    this.CourseCode == input.CourseCode ||
                    (this.CourseCode != null &&
                    this.CourseCode.Equals(input.CourseCode))
                ) && 
                (
                    this.IdentificationCodes == input.IdentificationCodes ||
                    this.IdentificationCodes != null &&
                    this.IdentificationCodes.SequenceEqual(input.IdentificationCodes)
                ) && 
                (
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.CourseDefinedByDescriptor == input.CourseDefinedByDescriptor ||
                    (this.CourseDefinedByDescriptor != null &&
                    this.CourseDefinedByDescriptor.Equals(input.CourseDefinedByDescriptor))
                ) && 
                (
                    this.CourseDescription == input.CourseDescription ||
                    (this.CourseDescription != null &&
                    this.CourseDescription.Equals(input.CourseDescription))
                ) && 
                (
                    this.CourseTitle == input.CourseTitle ||
                    (this.CourseTitle != null &&
                    this.CourseTitle.Equals(input.CourseTitle))
                ) && 
                (
                    this.DateCourseAdopted == input.DateCourseAdopted ||
                    (this.DateCourseAdopted != null &&
                    this.DateCourseAdopted.Equals(input.DateCourseAdopted))
                ) && 
                (
                    this.HighSchoolCourseRequirement == input.HighSchoolCourseRequirement ||
                    (this.HighSchoolCourseRequirement != null &&
                    this.HighSchoolCourseRequirement.Equals(input.HighSchoolCourseRequirement))
                ) && 
                (
                    this.LearningStandards == input.LearningStandards ||
                    this.LearningStandards != null &&
                    this.LearningStandards.SequenceEqual(input.LearningStandards)
                ) && 
                (
                    this.LevelCharacteristics == input.LevelCharacteristics ||
                    this.LevelCharacteristics != null &&
                    this.LevelCharacteristics.SequenceEqual(input.LevelCharacteristics)
                ) && 
                (
                    this.MaximumAvailableCredits == input.MaximumAvailableCredits ||
                    (this.MaximumAvailableCredits != null &&
                    this.MaximumAvailableCredits.Equals(input.MaximumAvailableCredits))
                ) && 
                (
                    this.NumberOfParts == input.NumberOfParts ||
                    (this.NumberOfParts != null &&
                    this.NumberOfParts.Equals(input.NumberOfParts))
                ) && 
                (
                    this.OfferedGradeLevels == input.OfferedGradeLevels ||
                    this.OfferedGradeLevels != null &&
                    this.OfferedGradeLevels.SequenceEqual(input.OfferedGradeLevels)
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
                if (this.CourseCode != null)
                    hashCode = hashCode * 59 + this.CourseCode.GetHashCode();
                if (this.IdentificationCodes != null)
                    hashCode = hashCode * 59 + this.IdentificationCodes.GetHashCode();
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.CourseDefinedByDescriptor != null)
                    hashCode = hashCode * 59 + this.CourseDefinedByDescriptor.GetHashCode();
                if (this.CourseDescription != null)
                    hashCode = hashCode * 59 + this.CourseDescription.GetHashCode();
                if (this.CourseTitle != null)
                    hashCode = hashCode * 59 + this.CourseTitle.GetHashCode();
                if (this.DateCourseAdopted != null)
                    hashCode = hashCode * 59 + this.DateCourseAdopted.GetHashCode();
                if (this.HighSchoolCourseRequirement != null)
                    hashCode = hashCode * 59 + this.HighSchoolCourseRequirement.GetHashCode();
                if (this.LearningStandards != null)
                    hashCode = hashCode * 59 + this.LearningStandards.GetHashCode();
                if (this.LevelCharacteristics != null)
                    hashCode = hashCode * 59 + this.LevelCharacteristics.GetHashCode();
                if (this.MaximumAvailableCredits != null)
                    hashCode = hashCode * 59 + this.MaximumAvailableCredits.GetHashCode();
                if (this.NumberOfParts != null)
                    hashCode = hashCode * 59 + this.NumberOfParts.GetHashCode();
                if (this.OfferedGradeLevels != null)
                    hashCode = hashCode * 59 + this.OfferedGradeLevels.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
                return hashCode;
            }
        }
    }

}
