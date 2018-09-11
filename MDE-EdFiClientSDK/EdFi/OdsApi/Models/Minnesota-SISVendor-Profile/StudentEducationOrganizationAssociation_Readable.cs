using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.MinnesotaSISVendorProfile 
{
    public class StudentEducationOrganizationAssociation_Readable 
    {
        /// <summary>
        /// The unique identifier of the resource.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// A reference to the related EducationOrganization resource.
        /// </summary>
        public EducationOrganizationReference educationOrganizationReference { get; set; }

        /// <summary>
        /// A reference to the related Student resource.
        /// </summary>
        public StudentReference studentReference { get; set; }

        /// <summary>
        /// The month, day, and year on which an individual was born.
        /// </summary>
        public DateTime? birthDate { get; set; }

        /// <summary>
        /// A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        /// An appendage, if any, used to denote an individual's generation in his family (e.g., Jr., Sr., III).
        /// </summary>
        public string generationCodeSuffix { get; set; }

        /// <summary>
        /// An indication that the individual traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central, and South America, and other Spanish cultures, regardless of race. The term, "Spanish origin," can be used in addition to "Hispanic or Latino."
        /// </summary>
        public bool? hispanicLatinoEthnicity { get; set; }

        /// <summary>
        /// The name borne in common by members of a family.
        /// </summary>
        public string lastSurname { get; set; }

        /// <summary>
        /// An indication that the student has been identified as limited English proficient by the Language Proficiency Assessment Committee (LPAC), or English proficient.
        /// </summary>
        public string limitedEnglishProficiencyDescriptor { get; set; }

        /// <summary>
        /// A secondary name given to an individual at birth, baptism, or during another naming ceremony.
        /// </summary>
        public string middleName { get; set; }

        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        public string responsibilityDescriptor { get; set; }

        /// <summary>
        /// A person's gender.
        /// </summary>
        public string sexType { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationAncestryEthnicOrigins.  The ancestry ethnic origins that pertain to the general racial categories with which the individual identifies.
        /// </summary>
        public List<StudentEducationOrganizationAssociationAncestryEthnicOrigin_Readable> ancestryEthnicOrigins { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationLanguages.  The language(s) the individual uses to communicate.
        /// </summary>
        public List<StudentEducationOrganizationAssociationLanguage_Readable> languages { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationRaces.  The general racial category which most clearly reflects the individual's recognition of his or her community or with which the individual most identifies.
        /// </summary>
        public List<StudentEducationOrganizationAssociationRace_Readable> races { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationStudentCharacteristics.  Reflects important characteristics of the student's home situation:          Displaced Homemaker, Immigrant, Migratory, Military Parent, Pregnant Teen, Single Parent, and Unaccompanied Youth.
        /// </summary>
        public List<StudentEducationOrganizationAssociationStudentCharacteristic_Readable> studentCharacteristics { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationStudentIdentificationCodes.  A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student.
        /// </summary>
        public List<StudentEducationOrganizationAssociationStudentIdentificationCode_Readable> studentIdentificationCodes { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        public string _etag { get; set; }

        }
}

