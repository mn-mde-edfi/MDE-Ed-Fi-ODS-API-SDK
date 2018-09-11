using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.MinnesotaSISVendorProfile 
{
    public class Student_Writable 
    {
        /// <summary>
        /// The unique identifier of the resource.
        /// </summary>
        public string id { get; set; }

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
        /// A secondary name given to an individual at birth, baptism, or during another naming ceremony.
        /// </summary>
        public string middleName { get; set; }

        /// <summary>
        /// A person''s gender.
        /// </summary>
        public string sexType { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        public string studentUniqueId { get; set; }

        /// <summary>
        /// An unordered collection of studentIdentificationCodes.  A coding scheme that is used for identification and record-keeping purposes by schools, social services or other agencies to refer to a student.
        /// </summary>
        public List<StudentIdentificationCode_Writable> identificationCodes { get; set; }

        /// <summary>
        /// An unordered collection of studentRaces.  The general racial category which most clearly reflects the individual's recognition of his or her community or with which the individual most identifies. The data model allows for multiple entries so that each individual can specify all appropriate races.
        /// </summary>
        public List<StudentRace_Writable> races { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        public string _etag { get; set; }

        }
}

