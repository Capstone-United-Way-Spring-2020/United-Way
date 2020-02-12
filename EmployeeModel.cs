using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{

    public class EmployeeModel
    {

        [Display(Name = "Employee ID")]
        [Range(10000000, 99999999, ErrorMessage = "You need to enter a valid CWID")]
        public int CWID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You must enter a first name.")]
        public string EmployeeFirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You must enter a last name.")]
        public string EmployeeLastName { get; set; }

        [Display(Name = "Middle Initial")]
        public string EmployeeMI { get; set; }

        [Display(Name = "Street Address")]
        [Required(ErrorMessage = "You must enter a street address.")]
        public string StreetAddress { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "You must enter a city.")]
        public string EmployeeCity { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "You must enter a state.")]
        public string EmployeeState { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip Code")]
        [Range(10000,99999, ErrorMessage = "You must enter a valid Zip Code.")]
        [Required(ErrorMessage = "You must enter a zip code.")]
        public int EmployeeZip { get; set; }

        [Display(Name = "Payroll")]
        public string Payroll { get; set; }

        [Display(Name = "PO Box")]
        public string POBox { get; set; }

        [Display(Name = "PO Box City")]
        public string POBoxCity { get; set; }

        [Display(Name = "Giving Year")]
        [Range(2000,3000, ErrorMessage ="You must enter a valid giving year")]
        public int GivingYear { get; set; }

        [Display(Name = "Employee Active")]
        [Required(ErrorMessage = "You must enter an employee status.")] 
        public bool EmployeeStatus { get; set; } = true;

        public DateTime EmployeeStatusDate { get; set; } = DateTime.Now;

    }
}