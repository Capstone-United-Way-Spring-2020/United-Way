using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppDraft
{
    class Department
    {
        private string orgCode;
        private string uwCoordinator1;
        private string uwCoordinator2;
        private string division;
        private bool deptActive = true;

        public Department()
        {
        }
        //Main constructor based on how divisions are added
        public Department(string orgCode, string uWCoordinator1, string uWCoordinator2, string uWCoordinator3, string division)
        {
            this.OrgCode = orgCode;
            uwCoordinator1 = uWCoordinator1;
            uwCoordinator2 = uWCoordinator2;
            UWCoordinator3 = uWCoordinator3;
            this.division = division;
        }
        //Getters and Setters
        public string OrgCode
        {
            set
            {
                orgCode = value;
            }
            get
            {
                return orgCode;
            }
        }
        public string UWCoordinator1
        {
            set
            {
                uwCoordinator1 = value;
            }
            get
            {
                return uwCoordinator1;
            }
        }
        public string UWCoordinator2
        {
            set
            {
                uwCoordinator2 = value;
            }
            get
            {
                return uwCoordinator2
;
            }
        }
        public string UWCoordinator3 { set; get; }
        public string Division
        {
            set
            {
                division = value;
            }
            get
            {
                return division;
            }
        }
        public bool DeptActive
        {
            set
            {
                deptActive = value;
            }
            get
            {
                return deptActive;
            }
        }
        //Changes department status
        public void ChangeDeptStatus()
        {
            if (deptActive == true)
            {
                deptActive = false;
            }
            else
            {
                deptActive = true;
            }
        }

    }
}
