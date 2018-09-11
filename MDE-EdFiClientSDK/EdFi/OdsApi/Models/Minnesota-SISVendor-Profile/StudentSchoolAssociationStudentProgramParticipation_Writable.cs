using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.MinnesotaSISVendorProfile 
{
    public class StudentSchoolAssociationStudentProgramParticipation_Writable 
    {
        /// <summary>
        /// The category of program.
        /// </summary>
        public string programCategoryDescriptor { get; set; }

        /// <summary>
        /// The date the Student was associated with the Program or service.
        /// </summary>
        public DateTime? beginDate { get; set; }

        /// <summary>
        /// The date the Program participation ended.
        /// </summary>
        public DateTime? endDate { get; set; }

        }
}

