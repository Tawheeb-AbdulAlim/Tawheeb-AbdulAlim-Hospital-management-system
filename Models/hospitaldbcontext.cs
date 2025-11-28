using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Hospital_management_system.Models
{
    public class hospitaldbcontext: DbContext
    {
        public DbSet<Patient> patients { get; set; }
       
       public DbSet<User> users { get; set; }
        public DbSet<Visit> visits { get; set; }
        public DbSet<Doctor>doctors { get; set; }
        public DbSet<reseptionist> Reseptionists { get; set; }

    }
}
