using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.MinnesotaSISVendorProfile 
{
    public class StudentIdentificationCode_Writable 
    {
        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        public string studentIdentificationSystemDescriptor { get; set; }

        /// <summary>
        /// The organization code or name assigning the StudentIdentificationCode.
        /// </summary>
        public string assigningOrganizationIdentificationCode { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a space, room, site, building, individual, organization, program, or institution by a school, school system, a state, or other agency or entity.
        /// </summary>
        public string identificationCode { get; set; }

        }
}

