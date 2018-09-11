using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models.MinnesotaSISVendorProfile 
{
    public class StudentReference 
    {
        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        public string studentUniqueId { get; set; }

        /// <summary>
        /// Represents a hyperlink to the related student resource.
        /// </summary>
        public Link link { get; set; }

        }
}

