using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models 
{
    public class IdentityCreateRequest 
    {
        public string StateStudentId { get; set; }

        public string EducationOrganizationId { get; set; }

        public string LastSurname { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string GenerationCodeSuffix { get; set; }

        public string SexType { get; set; }

        public DateTime? BirthDate { get; set; }

        public int? BirthOrder { get; set; }

        public Location BirthLocation { get; set; }

        }
}

