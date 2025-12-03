using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations;
namespace Hospital_management_system.Models
{
    public class Visit
    {
       //[Key]
   public int VisitId { get; set; }


        //[Required]
        //[Foreignkey("Patient")]
        public int PatientId { get; set; }

        //[Required]
        //[Foreignkey("Employee")]
        public int DoctorId { get; set; }

        //[Required]
        public DateTime VisitDate { get; set; }

        // [StringLength(50)]
        public string VisitType { get; set; }

        // [StringLength(50)]
        //الادوية الحالية
        public string CurrentMedication { get; set; }
        public string Notes { get; set; }


    }
}
