using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.Resources 
{
    public class StudentEducationOrganizationAssociationStudentCharacteristic 
    {
        /// <summary>
        /// The characteristic designated for the Student.
        /// </summary>
        public string studentCharacteristicDescriptor { get; set; }

        /// <summary>
        /// The date the characteristic was designated.
        /// </summary>
        public DateTime? beginDate { get; set; }

        /// <summary>
        /// The date the characteristic was removed.
        /// </summary>
        public DateTime? endDate { get; set; }

        /// <summary>
        /// The person, organization, or department that designated the characteristic.
        /// </summary>
        public string designatedBy { get; set; }

        }
}

