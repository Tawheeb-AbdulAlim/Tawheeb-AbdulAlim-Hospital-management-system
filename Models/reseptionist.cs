using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_system.Models
{
    public class reseptionist:Employee
    {
        public int ReseptionistId { get; set; }      // Primary Key
       
       public virtual List<Patient>Patients { get; set; } // Navigation property
        

    }
}
