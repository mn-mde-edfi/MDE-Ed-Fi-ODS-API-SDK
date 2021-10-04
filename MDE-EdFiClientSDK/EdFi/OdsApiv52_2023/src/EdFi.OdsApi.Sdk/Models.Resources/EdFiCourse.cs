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

namespace EdFi.OdsApi.Sdk.Models.Resources
{
    /// <summary>
    /// EdFiCourse
    /// </summary>
    [DataContract]
    public partial class EdFiCourse :  IEquatable<EdFiCourse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCourse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourse" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="courseCode">A unique alphanumeric code assigned to a course. (required).</param>
        /// <param name="identificationCodes">An unordered collection of courseIdentificationCodes. The code that identifies the organization of subject matter and related learning experiences provided for the instruction of students. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="academicSubjectDescriptor">The intended major subject area of the course..</param>
        /// <param name="careerPathwayDescriptor">Indicates the career cluster or pathway the course is associated with as part of a CTE curriculum..</param>
        /// <param name="competencyLevels">An unordered collection of courseCompetencyLevels. The competency levels defined to rate the student for the course..</param>
        /// <param name="courseDefinedByDescriptor">Specifies whether the course was defined by the SEA, LEA, School, or national organization..</param>
        /// <param name="courseDescription">A description of the content standards and goals covered in the course. Reference may be made to state or national content standards..</param>
        /// <param name="courseGPAApplicabilityDescriptor">An indicator of whether or not the course being described is included in the computation of the student&#39;s Grade Point Average, and if so, if it is weighted differently from regular courses..</param>
        /// <param name="courseTitle">The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, and language arts). (required).</param>
        /// <param name="dateCourseAdopted">Date the course was adopted by the education agency..</param>
        /// <param name="highSchoolCourseRequirement">An indication that this course may satisfy high school graduation requirements in the course&#39;s subject area..</param>
        /// <param name="learningObjectives">An unordered collection of courseLearningObjectives. Learning Objectives to be mastered in the course..</param>
        /// <param name="learningStandards">An unordered collection of courseLearningStandards. Learning Standard(s) to be taught by the course..</param>
        /// <param name="levelCharacteristics">An unordered collection of courseLevelCharacteristics. The type of specific program or designation with which the course is associated (e.g., AP, IB, Dual Credit, CTE)..</param>
        /// <param name="maxCompletionsForCredit">Designates how many times the course may be taken with credit received by the student..</param>
        /// <param name="maximumAvailableCreditConversion">Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units..</param>
        /// <param name="maximumAvailableCredits">The value of credits or units of value awarded for the completion of a course..</param>
        /// <param name="maximumAvailableCreditTypeDescriptor">The type of credits or units of value awarded for the completion of a course..</param>
        /// <param name="minimumAvailableCreditConversion">Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units..</param>
        /// <param name="minimumAvailableCredits">The value of credits or units of value awarded for the completion of a course..</param>
        /// <param name="minimumAvailableCreditTypeDescriptor">The type of credits or units of value awarded for the completion of a course..</param>
        /// <param name="numberOfParts">The number of parts identified for a course. (required).</param>
        /// <param name="offeredGradeLevels">An unordered collection of courseOfferedGradeLevels. The grade levels in which the course is offered..</param>
        /// <param name="timeRequiredForCompletion">The actual or estimated number of clock minutes required for class completion.  This number is especially important for career and technical education classes and may represent (in minutes) the clock hour requirement of the class..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="ext">ext.</param>
        public EdFiCourse(string id = default(string), string courseCode = default(string), List<EdFiCourseIdentificationCode> identificationCodes = default(List<EdFiCourseIdentificationCode>), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), string academicSubjectDescriptor = default(string), string careerPathwayDescriptor = default(string), List<EdFiCourseCompetencyLevel> competencyLevels = default(List<EdFiCourseCompetencyLevel>), string courseDefinedByDescriptor = default(string), string courseDescription = default(string), string courseGPAApplicabilityDescriptor = default(string), string courseTitle = default(string), DateTime? dateCourseAdopted = default(DateTime?), bool? highSchoolCourseRequirement = default(bool?), List<EdFiCourseLearningObjective> learningObjectives = default(List<EdFiCourseLearningObjective>), List<EdFiCourseLearningStandard> learningStandards = default(List<EdFiCourseLearningStandard>), List<EdFiCourseLevelCharacteristic> levelCharacteristics = default(List<EdFiCourseLevelCharacteristic>), int? maxCompletionsForCredit = default(int?), double? maximumAvailableCreditConversion = default(double?), double? maximumAvailableCredits = default(double?), string maximumAvailableCreditTypeDescriptor = default(string), double? minimumAvailableCreditConversion = default(double?), double? minimumAvailableCredits = default(double?), string minimumAvailableCreditTypeDescriptor = default(string), int? numberOfParts = default(int?), List<EdFiCourseOfferedGradeLevel> offeredGradeLevels = default(List<EdFiCourseOfferedGradeLevel>), int? timeRequiredForCompletion = default(int?), string etag = default(string), CourseExtensions ext = default(CourseExtensions))
        {
            // to ensure "courseCode" is required (not null)
            if (courseCode == null)
            {
                throw new InvalidDataException("courseCode is a required property for EdFiCourse and cannot be null");
            }
            else
            {
                this.CourseCode = courseCode;
            }
            // to ensure "identificationCodes" is required (not null)
            if (identificationCodes == null)
            {
                throw new InvalidDataException("identificationCodes is a required property for EdFiCourse and cannot be null");
            }
            else
            {
                this.IdentificationCodes = identificationCodes;
            }
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new InvalidDataException("educationOrganizationReference is a required property for EdFiCourse and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = educationOrganizationReference;
            }
            // to ensure "courseTitle" is required (not null)
            if (courseTitle == null)
            {
                throw new InvalidDataException("courseTitle is a required property for EdFiCourse and cannot be null");
            }
            else
            {
                this.CourseTitle = courseTitle;
            }
            // to ensure "numberOfParts" is required (not null)
            if (numberOfParts == null)
            {
                throw new InvalidDataException("numberOfParts is a required property for EdFiCourse and cannot be null");
            }
            else
            {
                this.NumberOfParts = numberOfParts;
            }
            this.Id = id;
            this.AcademicSubjectDescriptor = academicSubjectDescriptor;
            this.CareerPathwayDescriptor = careerPathwayDescriptor;
            this.CompetencyLevels = competencyLevels;
            this.CourseDefinedByDescriptor = courseDefinedByDescriptor;
            this.CourseDescription = courseDescription;
            this.CourseGPAApplicabilityDescriptor = courseGPAApplicabilityDescriptor;
            this.DateCourseAdopted = dateCourseAdopted;
            this.HighSchoolCourseRequirement = highSchoolCourseRequirement;
            this.LearningObjectives = learningObjectives;
            this.LearningStandards = learningStandards;
            this.LevelCharacteristics = levelCharacteristics;
            this.MaxCompletionsForCredit = maxCompletionsForCredit;
            this.MaximumAvailableCreditConversion = maximumAvailableCreditConversion;
            this.MaximumAvailableCredits = maximumAvailableCredits;
            this.MaximumAvailableCreditTypeDescriptor = maximumAvailableCreditTypeDescriptor;
            this.MinimumAvailableCreditConversion = minimumAvailableCreditConversion;
            this.MinimumAvailableCredits = minimumAvailableCredits;
            this.MinimumAvailableCreditTypeDescriptor = minimumAvailableCreditTypeDescriptor;
            this.OfferedGradeLevels = offeredGradeLevels;
            this.TimeRequiredForCompletion = timeRequiredForCompletion;
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
        public List<EdFiCourseIdentificationCode> IdentificationCodes { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name="educationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// The intended major subject area of the course.
        /// </summary>
        /// <value>The intended major subject area of the course.</value>
        [DataMember(Name="academicSubjectDescriptor", EmitDefaultValue=false)]
        public string AcademicSubjectDescriptor { get; set; }

        /// <summary>
        /// Indicates the career cluster or pathway the course is associated with as part of a CTE curriculum.
        /// </summary>
        /// <value>Indicates the career cluster or pathway the course is associated with as part of a CTE curriculum.</value>
        [DataMember(Name="careerPathwayDescriptor", EmitDefaultValue=false)]
        public string CareerPathwayDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of courseCompetencyLevels. The competency levels defined to rate the student for the course.
        /// </summary>
        /// <value>An unordered collection of courseCompetencyLevels. The competency levels defined to rate the student for the course.</value>
        [DataMember(Name="competencyLevels", EmitDefaultValue=false)]
        public List<EdFiCourseCompetencyLevel> CompetencyLevels { get; set; }

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
        /// An indicator of whether or not the course being described is included in the computation of the student&#39;s Grade Point Average, and if so, if it is weighted differently from regular courses.
        /// </summary>
        /// <value>An indicator of whether or not the course being described is included in the computation of the student&#39;s Grade Point Average, and if so, if it is weighted differently from regular courses.</value>
        [DataMember(Name="courseGPAApplicabilityDescriptor", EmitDefaultValue=false)]
        public string CourseGPAApplicabilityDescriptor { get; set; }

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
        /// An unordered collection of courseLearningObjectives. Learning Objectives to be mastered in the course.
        /// </summary>
        /// <value>An unordered collection of courseLearningObjectives. Learning Objectives to be mastered in the course.</value>
        [DataMember(Name="learningObjectives", EmitDefaultValue=false)]
        public List<EdFiCourseLearningObjective> LearningObjectives { get; set; }

        /// <summary>
        /// An unordered collection of courseLearningStandards. Learning Standard(s) to be taught by the course.
        /// </summary>
        /// <value>An unordered collection of courseLearningStandards. Learning Standard(s) to be taught by the course.</value>
        [DataMember(Name="learningStandards", EmitDefaultValue=false)]
        public List<EdFiCourseLearningStandard> LearningStandards { get; set; }

        /// <summary>
        /// An unordered collection of courseLevelCharacteristics. The type of specific program or designation with which the course is associated (e.g., AP, IB, Dual Credit, CTE).
        /// </summary>
        /// <value>An unordered collection of courseLevelCharacteristics. The type of specific program or designation with which the course is associated (e.g., AP, IB, Dual Credit, CTE).</value>
        [DataMember(Name="levelCharacteristics", EmitDefaultValue=false)]
        public List<EdFiCourseLevelCharacteristic> LevelCharacteristics { get; set; }

        /// <summary>
        /// Designates how many times the course may be taken with credit received by the student.
        /// </summary>
        /// <value>Designates how many times the course may be taken with credit received by the student.</value>
        [DataMember(Name="maxCompletionsForCredit", EmitDefaultValue=false)]
        public int? MaxCompletionsForCredit { get; set; }

        /// <summary>
        /// Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.
        /// </summary>
        /// <value>Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.</value>
        [DataMember(Name="maximumAvailableCreditConversion", EmitDefaultValue=false)]
        public double? MaximumAvailableCreditConversion { get; set; }

        /// <summary>
        /// The value of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The value of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="maximumAvailableCredits", EmitDefaultValue=false)]
        public double? MaximumAvailableCredits { get; set; }

        /// <summary>
        /// The type of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The type of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="maximumAvailableCreditTypeDescriptor", EmitDefaultValue=false)]
        public string MaximumAvailableCreditTypeDescriptor { get; set; }

        /// <summary>
        /// Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.
        /// </summary>
        /// <value>Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units.</value>
        [DataMember(Name="minimumAvailableCreditConversion", EmitDefaultValue=false)]
        public double? MinimumAvailableCreditConversion { get; set; }

        /// <summary>
        /// The value of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The value of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="minimumAvailableCredits", EmitDefaultValue=false)]
        public double? MinimumAvailableCredits { get; set; }

        /// <summary>
        /// The type of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The type of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="minimumAvailableCreditTypeDescriptor", EmitDefaultValue=false)]
        public string MinimumAvailableCreditTypeDescriptor { get; set; }

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
        public List<EdFiCourseOfferedGradeLevel> OfferedGradeLevels { get; set; }

        /// <summary>
        /// The actual or estimated number of clock minutes required for class completion.  This number is especially important for career and technical education classes and may represent (in minutes) the clock hour requirement of the class.
        /// </summary>
        /// <value>The actual or estimated number of clock minutes required for class completion.  This number is especially important for career and technical education classes and may represent (in minutes) the clock hour requirement of the class.</value>
        [DataMember(Name="timeRequiredForCompletion", EmitDefaultValue=false)]
        public int? TimeRequiredForCompletion { get; set; }

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
        public CourseExtensions Ext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiCourse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CourseCode: ").Append(CourseCode).Append("\n");
            sb.Append("  IdentificationCodes: ").Append(IdentificationCodes).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  AcademicSubjectDescriptor: ").Append(AcademicSubjectDescriptor).Append("\n");
            sb.Append("  CareerPathwayDescriptor: ").Append(CareerPathwayDescriptor).Append("\n");
            sb.Append("  CompetencyLevels: ").Append(CompetencyLevels).Append("\n");
            sb.Append("  CourseDefinedByDescriptor: ").Append(CourseDefinedByDescriptor).Append("\n");
            sb.Append("  CourseDescription: ").Append(CourseDescription).Append("\n");
            sb.Append("  CourseGPAApplicabilityDescriptor: ").Append(CourseGPAApplicabilityDescriptor).Append("\n");
            sb.Append("  CourseTitle: ").Append(CourseTitle).Append("\n");
            sb.Append("  DateCourseAdopted: ").Append(DateCourseAdopted).Append("\n");
            sb.Append("  HighSchoolCourseRequirement: ").Append(HighSchoolCourseRequirement).Append("\n");
            sb.Append("  LearningObjectives: ").Append(LearningObjectives).Append("\n");
            sb.Append("  LearningStandards: ").Append(LearningStandards).Append("\n");
            sb.Append("  LevelCharacteristics: ").Append(LevelCharacteristics).Append("\n");
            sb.Append("  MaxCompletionsForCredit: ").Append(MaxCompletionsForCredit).Append("\n");
            sb.Append("  MaximumAvailableCreditConversion: ").Append(MaximumAvailableCreditConversion).Append("\n");
            sb.Append("  MaximumAvailableCredits: ").Append(MaximumAvailableCredits).Append("\n");
            sb.Append("  MaximumAvailableCreditTypeDescriptor: ").Append(MaximumAvailableCreditTypeDescriptor).Append("\n");
            sb.Append("  MinimumAvailableCreditConversion: ").Append(MinimumAvailableCreditConversion).Append("\n");
            sb.Append("  MinimumAvailableCredits: ").Append(MinimumAvailableCredits).Append("\n");
            sb.Append("  MinimumAvailableCreditTypeDescriptor: ").Append(MinimumAvailableCreditTypeDescriptor).Append("\n");
            sb.Append("  NumberOfParts: ").Append(NumberOfParts).Append("\n");
            sb.Append("  OfferedGradeLevels: ").Append(OfferedGradeLevels).Append("\n");
            sb.Append("  TimeRequiredForCompletion: ").Append(TimeRequiredForCompletion).Append("\n");
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
            return this.Equals(input as EdFiCourse);
        }

        /// <summary>
        /// Returns true if EdFiCourse instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCourse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCourse input)
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
                    this.AcademicSubjectDescriptor == input.AcademicSubjectDescriptor ||
                    (this.AcademicSubjectDescriptor != null &&
                    this.AcademicSubjectDescriptor.Equals(input.AcademicSubjectDescriptor))
                ) && 
                (
                    this.CareerPathwayDescriptor == input.CareerPathwayDescriptor ||
                    (this.CareerPathwayDescriptor != null &&
                    this.CareerPathwayDescriptor.Equals(input.CareerPathwayDescriptor))
                ) && 
                (
                    this.CompetencyLevels == input.CompetencyLevels ||
                    this.CompetencyLevels != null &&
                    this.CompetencyLevels.SequenceEqual(input.CompetencyLevels)
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
                    this.CourseGPAApplicabilityDescriptor == input.CourseGPAApplicabilityDescriptor ||
                    (this.CourseGPAApplicabilityDescriptor != null &&
                    this.CourseGPAApplicabilityDescriptor.Equals(input.CourseGPAApplicabilityDescriptor))
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
                    this.LearningObjectives == input.LearningObjectives ||
                    this.LearningObjectives != null &&
                    this.LearningObjectives.SequenceEqual(input.LearningObjectives)
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
                    this.MaxCompletionsForCredit == input.MaxCompletionsForCredit ||
                    (this.MaxCompletionsForCredit != null &&
                    this.MaxCompletionsForCredit.Equals(input.MaxCompletionsForCredit))
                ) && 
                (
                    this.MaximumAvailableCreditConversion == input.MaximumAvailableCreditConversion ||
                    (this.MaximumAvailableCreditConversion != null &&
                    this.MaximumAvailableCreditConversion.Equals(input.MaximumAvailableCreditConversion))
                ) && 
                (
                    this.MaximumAvailableCredits == input.MaximumAvailableCredits ||
                    (this.MaximumAvailableCredits != null &&
                    this.MaximumAvailableCredits.Equals(input.MaximumAvailableCredits))
                ) && 
                (
                    this.MaximumAvailableCreditTypeDescriptor == input.MaximumAvailableCreditTypeDescriptor ||
                    (this.MaximumAvailableCreditTypeDescriptor != null &&
                    this.MaximumAvailableCreditTypeDescriptor.Equals(input.MaximumAvailableCreditTypeDescriptor))
                ) && 
                (
                    this.MinimumAvailableCreditConversion == input.MinimumAvailableCreditConversion ||
                    (this.MinimumAvailableCreditConversion != null &&
                    this.MinimumAvailableCreditConversion.Equals(input.MinimumAvailableCreditConversion))
                ) && 
                (
                    this.MinimumAvailableCredits == input.MinimumAvailableCredits ||
                    (this.MinimumAvailableCredits != null &&
                    this.MinimumAvailableCredits.Equals(input.MinimumAvailableCredits))
                ) && 
                (
                    this.MinimumAvailableCreditTypeDescriptor == input.MinimumAvailableCreditTypeDescriptor ||
                    (this.MinimumAvailableCreditTypeDescriptor != null &&
                    this.MinimumAvailableCreditTypeDescriptor.Equals(input.MinimumAvailableCreditTypeDescriptor))
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
                    this.TimeRequiredForCompletion == input.TimeRequiredForCompletion ||
                    (this.TimeRequiredForCompletion != null &&
                    this.TimeRequiredForCompletion.Equals(input.TimeRequiredForCompletion))
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
                if (this.AcademicSubjectDescriptor != null)
                    hashCode = hashCode * 59 + this.AcademicSubjectDescriptor.GetHashCode();
                if (this.CareerPathwayDescriptor != null)
                    hashCode = hashCode * 59 + this.CareerPathwayDescriptor.GetHashCode();
                if (this.CompetencyLevels != null)
                    hashCode = hashCode * 59 + this.CompetencyLevels.GetHashCode();
                if (this.CourseDefinedByDescriptor != null)
                    hashCode = hashCode * 59 + this.CourseDefinedByDescriptor.GetHashCode();
                if (this.CourseDescription != null)
                    hashCode = hashCode * 59 + this.CourseDescription.GetHashCode();
                if (this.CourseGPAApplicabilityDescriptor != null)
                    hashCode = hashCode * 59 + this.CourseGPAApplicabilityDescriptor.GetHashCode();
                if (this.CourseTitle != null)
                    hashCode = hashCode * 59 + this.CourseTitle.GetHashCode();
                if (this.DateCourseAdopted != null)
                    hashCode = hashCode * 59 + this.DateCourseAdopted.GetHashCode();
                if (this.HighSchoolCourseRequirement != null)
                    hashCode = hashCode * 59 + this.HighSchoolCourseRequirement.GetHashCode();
                if (this.LearningObjectives != null)
                    hashCode = hashCode * 59 + this.LearningObjectives.GetHashCode();
                if (this.LearningStandards != null)
                    hashCode = hashCode * 59 + this.LearningStandards.GetHashCode();
                if (this.LevelCharacteristics != null)
                    hashCode = hashCode * 59 + this.LevelCharacteristics.GetHashCode();
                if (this.MaxCompletionsForCredit != null)
                    hashCode = hashCode * 59 + this.MaxCompletionsForCredit.GetHashCode();
                if (this.MaximumAvailableCreditConversion != null)
                    hashCode = hashCode * 59 + this.MaximumAvailableCreditConversion.GetHashCode();
                if (this.MaximumAvailableCredits != null)
                    hashCode = hashCode * 59 + this.MaximumAvailableCredits.GetHashCode();
                if (this.MaximumAvailableCreditTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.MaximumAvailableCreditTypeDescriptor.GetHashCode();
                if (this.MinimumAvailableCreditConversion != null)
                    hashCode = hashCode * 59 + this.MinimumAvailableCreditConversion.GetHashCode();
                if (this.MinimumAvailableCredits != null)
                    hashCode = hashCode * 59 + this.MinimumAvailableCredits.GetHashCode();
                if (this.MinimumAvailableCreditTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.MinimumAvailableCreditTypeDescriptor.GetHashCode();
                if (this.NumberOfParts != null)
                    hashCode = hashCode * 59 + this.NumberOfParts.GetHashCode();
                if (this.OfferedGradeLevels != null)
                    hashCode = hashCode * 59 + this.OfferedGradeLevels.GetHashCode();
                if (this.TimeRequiredForCompletion != null)
                    hashCode = hashCode * 59 + this.TimeRequiredForCompletion.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                if (this.Ext != null)
                    hashCode = hashCode * 59 + this.Ext.GetHashCode();
                return hashCode;
            }
        }
    }

}
