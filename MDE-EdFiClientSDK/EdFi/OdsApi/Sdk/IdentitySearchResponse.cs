using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace EdFi.OdsApi.Models 
{
    public class IdentitySearchResponse 
    {
        public string Status { get; set; }

        public List<IdentitySearchResponses> SearchResponses { get; set; }

        }
}

