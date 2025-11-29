using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_system.Models
{
    public class Doctor:Employee
    {
        public int DoctorId { get; set; }      // Primary Key
       
        public string Specialization { get; set; }
        
        public virtual List<Patient>Patients { get; set; } // Navigation property

        public Doctor() { }
        
        }
    
}
