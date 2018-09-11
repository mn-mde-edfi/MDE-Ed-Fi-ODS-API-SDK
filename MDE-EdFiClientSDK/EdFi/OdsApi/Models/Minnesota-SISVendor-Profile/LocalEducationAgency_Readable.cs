using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.MinnesotaSISVendorProfile 
{
    public class LocalEducationAgency_Readable 
    {
        /// <summary>
        /// The unique identifier of the resource.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// A reference to the related StateEducationAgency resource.
        /// </summary>
        public StateEducationAgencyReference stateEducationAgencyReference { get; set; }

        /// <summary>
        /// The two digit numeric code representing the MARSS district type.
        /// </summary>
        public string districtTypeDescriptor { get; set; }

        /// <summary>
        /// Key for LEACategory
        /// </summary>
        public string categoryType { get; set; }

        /// <summary>
        /// The identifier assigned to a local education agency by the State Education Agency (SEA).
        /// </summary>
        public int? localEducationAgencyId { get; set; }

        /// <summary>
        /// The full, legally accepted name of the institution.  NEDM: Name of Institution
        /// </summary>
        public string nameOfInstitution { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationAddresses.  The set of elements that describes an address, including the street address, city, state and ZIP code.
        /// </summary>
        public List<EducationOrganizationAddress_LocalEducationAgency_Readable> addresses { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationCategories.  The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state.
        /// </summary>
        public List<EducationOrganizationCategory_LocalEducationAgency_Readable> educationOrganizationCategories { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationIdentificationCodes.  A unique number or alphanumeric code that is assigned to an education organization by a school, school system, state, or other agency or entity.
        /// </summary>
        public List<EducationOrganizationIdentificationCode_LocalEducationAgency_Readable> identificationCodes { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        public string _etag { get; set; }

        }
}

