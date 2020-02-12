using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelCreations.Models
{
    public class AgencyModel
    {
        public string AgencyId { get; set; }

        public string AgencyName { get; set; }

        public bool AgencyStatus { get; set; } = true;

        public DateTime AgencyDateCreated { get; set; } = DateTime.Now;

        public DateTime AgencyLastEdited { get; set; } = DateTime.Now;
    }
}