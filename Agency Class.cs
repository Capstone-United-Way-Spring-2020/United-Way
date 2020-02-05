using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppDraft
{
    class Agency
    {
        private string agencyId;
        private string agencyName;
        private bool agencyActive = true;

        public Agency()
        {
        }

        public Agency(string agencyId, string agencyName)
        {
            this.agencyId = agencyId;
            this.agencyName = agencyName;
        }
        //Getters and Setters
        public string AgencyId { get => agencyId; set => agencyId = value; }
        public string AgencyName { get => agencyName; set => agencyName = value; }
        public bool AgencyActive { get => agencyActive; set => agencyActive = value; }

        //Changes employee active status
        public void ChangeAgencyStatus()
        {
            if (agencyActive == true)
            {
                agencyActive = false;
            }
            else
            {
                agencyActive = true;
            }
        }
    }
}
