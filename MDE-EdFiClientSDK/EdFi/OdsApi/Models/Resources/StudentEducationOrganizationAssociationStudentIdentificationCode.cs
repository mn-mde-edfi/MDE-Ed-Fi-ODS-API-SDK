using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.Resources 
{
    public class StudentEducationOrganizationAssociationStudentIdentificationCode 
    {
        /// <summary>
        /// A coding scheme that is used for identification and record-keeping purposes by schools, social services, or other agencies to refer to a student.
        /// </summary>
        public string studentIdentificationSystemDescriptor { get; set; }

        /// <summary>
        /// The organization code or name assigning the StudentIdentificationCode.
        /// </summary>
        public string assigningOrganizationIdentificationCode { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a student by a school, school system, a state, or other agency or entity.
        /// </summary>
        public string identificationCode { get; set; }

        }
}

