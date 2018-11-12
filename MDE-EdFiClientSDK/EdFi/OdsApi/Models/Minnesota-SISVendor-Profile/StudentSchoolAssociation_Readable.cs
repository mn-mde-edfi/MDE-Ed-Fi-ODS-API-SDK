using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.MinnesotaSISVendorProfile 
{
    public class StudentSchoolAssociation_Readable 
    {
        /// <summary>
        /// The unique identifier of the resource.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// A reference to the related School resource.
        /// </summary>
        public SchoolReference schoolReference { get; set; }

        /// <summary>
        /// A reference to the related SchoolYearType resource.
        /// </summary>
        public SchoolYearTypeReference schoolYearTypeReference { get; set; }

        /// <summary>
        /// A reference to the related Student resource.
        /// </summary>
        public StudentReference studentReference { get; set; }

        /// <summary>
        /// A reference to the related LocalEducationAgency resource.
        /// </summary>
        public LocalEducationAgencyReference residentLocalEducationAgencyReference { get; set; }

        /// <summary>
        /// The month, day, and year on which an individual enters and begins to receive instructional services in a school.
        /// </summary>
        public DateTime? entryDate { get; set; }

        /// <summary>
        /// The grade level or primary instructional level at which a student enters and receives services in a school or an educational institution during a given academic session.
        /// </summary>
        public string entryGradeLevelDescriptor { get; set; }

        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        public string entryTypeDescriptor { get; set; }

        /// <summary>
        /// The month, day, and year of the first day after the date of an individual's last attendance at a school (if known), the day on which an individual graduated, or the date on which it becomes known officially that an individual left school.
        /// </summary>
        public DateTime? exitWithdrawDate { get; set; }

        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        public string exitWithdrawTypeDescriptor { get; set; }

        /// <summary>
        /// The Homebound Service Indicator is used to validate Membership Days for students who have no Attendance Days. It is an indication of whether students were medically confined to their home and received instruction in the home during the enrollment period.
        /// </summary>
        public bool? homeboundServiceIndicator { get; set; }

        /// <summary>
        /// An indication of a student's level of eligibility for breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public string schoolFoodServicesEligibilityDescriptor { get; set; }

        /// <summary>
        /// An indicator of the students' need for and participation in special education programs during this enrollment period.
        /// </summary>
        public string specialEducationEvaluationStatusDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of studentSchoolAssociationStudentProgramParticipations.  Key programs the student is participating in or receives services from.
        /// </summary>
        public List<StudentSchoolAssociationStudentProgramParticipation_Readable> studentProgramParticipations { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        public string _etag { get; set; }

        }
}

