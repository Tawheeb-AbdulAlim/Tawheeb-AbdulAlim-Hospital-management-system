using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_system.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }     // Primary Key
        public string FullName { get; set; }
        public string Role { get; set; }        // مثل: Receptionist, Admin, Accountant
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
    }
}
