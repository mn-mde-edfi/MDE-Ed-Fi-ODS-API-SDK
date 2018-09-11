using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.MinnesotaSISVendorProfile 
{
    public class School_Readable 
    {
        /// <summary>
        /// The unique identifier of the resource.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// A reference to the related LocalEducationAgency resource.
        /// </summary>
        public LocalEducationAgencyReference localEducationAgencyReference { get; set; }

        /// <summary>
        /// The full, legally accepted name of the institution.  NEDM: Name of Institution
        /// </summary>
        public string nameOfInstitution { get; set; }

        /// <summary>
        /// The numeric code representing the MARSS school classification.
        /// </summary>
        public string classificationDescriptor { get; set; }

        /// <summary>
        /// The identifier assigned to a school by the State Education Agency (SEA).
        /// </summary>
        public int? schoolId { get; set; }

        /// <summary>
        /// The identifier assigned to an education agency by the State Education Agency (SEA).  Also known as the State LEP ID.  NEDM: IdentificationCode, LEA Identifier (State)
        /// </summary>
        public string stateOrganizationId { get; set; }

        /// <summary>
        /// An unordered collection of schoolGradeLevels.  The grade levels served at the school.
        /// </summary>
        public List<SchoolGradeLevel_Readable> gradeLevels { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationAddresses.  The set of elements that describes an address, including the street address, city, state and ZIP code.
        /// </summary>
        public List<EducationOrganizationAddress_School_Readable> addresses { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationCategories.  The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state.
        /// </summary>
        public List<EducationOrganizationCategory_School_Readable> educationOrganizationCategories { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationIdentificationCodes.  A unique number or alphanumeric code that is assigned to an education organization by a school, school system, state, or other agency or entity.
        /// </summary>
        public List<EducationOrganizationIdentificationCode_School_Readable> identificationCodes { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        public string _etag { get; set; }

        }
}

