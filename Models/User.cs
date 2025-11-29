using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations;

namespace Hospital_management_system.Models
{
    public class User
    {
        //[Key]
        public int UserId { get; set; }

        //[Required]
        //[Foreignkey("Eemployee")]
        public int EmployeeId { get; set; }

        //[Required]
       // [StringLength(50)]
        public string Username{ get; set; }

        //[Required]
       // [StringLength(50)]
        public Role Role { get; set; }


        //[Required]
        //[StringLength(30)]
        public string PasswordHash { get; set; }

    }



}
