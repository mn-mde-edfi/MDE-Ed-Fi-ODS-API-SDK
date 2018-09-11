using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.Resources 
{
    public class StudentSchoolAssociationStudentProgramParticipation 
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

        /// <summary>
        /// The person, organization, or department that designated the program association.
        /// </summary>
        public string designatedBy { get; set; }

        /// <summary>
        /// An unordered collection of studentSchoolAssociationStudentProgramParticipationProgramCharacteristics.  Reflects important characteristics of the Program, such as categories or particular indications.
        /// </summary>
        public List<StudentSchoolAssociationStudentProgramParticipationProgramCharacteristic> programCharacteristics { get; set; }

        }
}

