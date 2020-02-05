using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppDraft
{
    class Employee
    {
        private string empFirstName;
        private string empLastName;
        private string midInit;
        private string empCwid;
        private string deptID;
        private string empUserID;
        private string streetAddr;
        private string city;
        private string state;
        private string zip;
        private string payrollType;
        private double salary;
        private string poBoxNum;
        private string poBoxCity;
        private string poBoxState;
        private string org;
        private bool empActive = true;
        private DateTime empStatusDate;

        public Employee()
        {
        }

        public Employee(string empFirstName, string empLastName)
        {
            this.empFirstName = empFirstName;
            this.empLastName = empLastName;
        }
        //Main constructors based on how employee info is added (without middle init)
        public Employee(string empFirstName, string empLastName, string midInit, string empCwid) : this(empFirstName, empLastName)
        {
            this.midInit = midInit;
            this.empCwid = empCwid;
        }
        //Main constructors based on how employee info is added (with middle init)
        public Employee(string empFirstName, string empLastName, string midInit, string empCwid, string deptID, string streetAddr, string city, string state, string zip, string payrollType, double salary, string poBoxNum, string poBoxCity, string poBoxState, string org) : this(empFirstName, empLastName, midInit, empCwid)
        {
            this.deptID = deptID;
            this.streetAddr = streetAddr;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.payrollType = payrollType;
            this.salary = salary;
            this.poBoxNum = poBoxNum;
            this.poBoxCity = poBoxCity;
            this.poBoxState = poBoxState;
            this.org = org;
        }
        //Main constructors based on how employee info is added (without middle init)
        public Employee(string empFirstName, string empLastName, string empCwid, string deptID, string streetAddr, string city, string state, string zip, string payrollType, double salary, string poBoxNum, string poBoxCity, string poBoxState, string org) : this(empFirstName, empLastName, empCwid, deptID)
        {
            this.streetAddr = streetAddr;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.payrollType = payrollType;
            this.salary = salary;
            this.poBoxNum = poBoxNum;
            this.poBoxCity = poBoxCity;
            this.poBoxState = poBoxState;
            this.org = org;
        }
        //Getters and Setters
        public string EmpFirstName
        {
            set
            {
                empFirstName = value;
            }
            get
            {
                return empFirstName;
            }
        }
        public string EmpLastName
        {
            set
            {
                empLastName = value;
            }
            get
            {
                return empLastName;
            }
        }
        public string MidInit
        {
            set
            {
                midInit = value;
            }
            get
            {
                return midInit;
            }
        }
        public string EmpCwid
        {
            set
            {
                empCwid = value;
            }
            get
            {
                return empCwid;
            }
        }
        public string DeptID
        {
            set
            {
                deptID = value;
            }
            get
            {
                return deptID;
            }
        }
        public string EmpUserID
        {
            set
            {
                empUserID = value;
            }
            get
            {
                return empUserID
;
            }
        }
        public string StreetAddr
        {
            set
            {
                streetAddr = value;
            }
            get
            {
                return streetAddr;
            }
        }
        public string City
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }
        }
        public string State
        {
            set
            {
                state = value;
            }
            get
            {
                return state;
            }
        }
        public string Zip
        {
            set
            {
                zip = value;
            }
            get
            {
                return zip
;
            }
        }
        public string PayrollType
        {
            set
            {
                payrollType = value;
            }
            get
            {
                return payrollType
;
            }
        }
        public double Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary
;
            }
        }
        public string PoBoxNum
        {
            set
            {
                poBoxNum = value;
            }
            get
            {
                return poBoxNum;
            }
        }
        public string PoBoxCity
        {
            set
            {
                poBoxCity = value;
            }
            get
            {
                return poBoxCity;
            }
        }
        public string PoBoxState
        {
            set
            {
                poBoxState = value;
            }
            get
            {
                return poBoxState
;
            }
        }
        public string Org
        {
            set
            {
                org = value;
            }
            get
            {
                return org;
            }
        }
        public bool EmpActiveStatus
        {
            set
            {
                empActive = value;
            }
            get
            {
                return empActive;
;
            }
        }
        public DateTime EmpStatusDate
        {
            set
            {
                empStatusDate = value;
            }
            get
            {
                return empStatusDate;
            }
        }

 

        //Returns a string with a space between first and last names
        public override string ToString()
        {
            return empFirstName + " " + empLastName;
        }
        //Changes employee active status
        public void ChangeEmpStatus()
        {
            if (empActive == true)
            {
                empActive = false;
            }
            else
            {
                empActive = true;
            }
        }
    }
}
