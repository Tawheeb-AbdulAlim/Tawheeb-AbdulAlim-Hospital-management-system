using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_system.Models
{
    public class Employee
    {
               // Primary Key
        public string FullName { get; set; }
             
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public  Role role { get; set; }
        public Employee() { }
    }
}
