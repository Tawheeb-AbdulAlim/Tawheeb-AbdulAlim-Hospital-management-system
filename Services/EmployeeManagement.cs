using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Hospital_management_system.Models;
using System.Collections.Generic;




namespace Hospital_management_system.Services
{
    public class EmployeeManagementServices
    {

       private hospitaldbcontext db = new hospitaldbcontext();
        public bool addemployee(Employee employee)
        {
            try
            {
                if (employee == null) {
                    MessageBox.Show("null");
                     return false; }

                if (employee.Role == Role.DOCTOR)
                {

                    Doctor doctor1 = (Doctor)employee;
                    doctor1.DoctorId = 255;
                    
                    doctor1.Specialization = "doctor";
                    


                    db.doctors.Add(doctor1);
                    db.SaveChanges();
                    return true;
                }





                if (employee.Role == Role.RESEPTIONIST)
                {
                    MessageBox.Show("reseptionist");

                    reseptionist reseptionist = (reseptionist)employee;
                    reseptionist.EmployeeId = 255;
                    
                    
                    

                    db.Reseptionists.Add(reseptionist);
                    db.SaveChanges();
                    return true;




                }
                MessageBox.Show("none");
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("exeption ");
                MessageBox.Show( ex.Message);
                return false;
            }
        }





      public bool updateEmployee(Employee employee)
        {
            return false;
            try
            {
                if (employee.Role == Role.DOCTOR)
                {
                    Doctor newdoctor = (Doctor)employee;
                    var olddoctor = db.doctors.Find(newdoctor.DoctorId);
                    if (olddoctor != null)
                    {
                        olddoctor.FullName = newdoctor.FullName;
                        olddoctor.Salary = newdoctor.Salary;
                        olddoctor.Phone = newdoctor.Phone;
                        olddoctor.Email = newdoctor.Email;
                        olddoctor.Specialization = newdoctor.Specialization;
                        db.SaveChanges();
                        return true;
                    }
                }
                if (employee.Role == Role.RESEPTIONIST)
                {
                    reseptionist newreseptionist = (reseptionist)employee;
                    var oldreseptionist = db.Reseptionists.Find(newreseptionist.ReseptionistId);
                    if (oldreseptionist != null)
                    {
                        oldreseptionist.FullName = newreseptionist.FullName;
                        oldreseptionist.Salary = newreseptionist.Salary;
                        oldreseptionist.Phone = newreseptionist.Phone;
                        oldreseptionist.Email = newreseptionist.Email;

                        db.SaveChanges();
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                return false;
            }

        }
        
        


        public bool deletemployee(int employeeid, Role role)
        {
            try
            {
                if (role == Role.DOCTOR)
                {
                    Doctor doctor = db.doctors.Find(employeeid);
                    if (doctor != null)
                    {
                        db.doctors.Remove(doctor);
                        db.SaveChanges();
                        return true;
                    }
                }
                if (role == Role.RESEPTIONIST)
                {
                    reseptionist reseptionist = db.Reseptionists.Find(employeeid);
                    if (reseptionist != null)
                    {
                        db.Reseptionists.Remove(reseptionist);
                        db.SaveChanges();
                        return true;
                    }

                }
            }
            catch (Exception ex) { return false; }


            return false;

        }
        public List<Doctor> getAllDoctor()
        {
            return db.doctors.ToList();


        }
        public List<reseptionist> getAllreseptionist()
        {
            return db.Reseptionists.ToList();
        }

        public List<Doctor> Searchdoctors(string searchType, string searchValue)
        {
            if (string.IsNullOrEmpty(searchValue))
                return getAllDoctor();

            switch (searchType.ToLower())
            {
                case "id":
                    if (int.TryParse(searchValue, out int id))
                        return db.doctors.Where(p => p.DoctorId == id).ToList();
                    break;
                case "name":
                    return db.doctors.Where(p => p.FullName.Contains(searchValue)).ToList();
                case "phone":
                    return db.doctors.Where(p => p.Phone.Contains(searchValue)).ToList();

            }
            return new List<Doctor>();
        }



        public List<reseptionist> searchreseptionisr(string searchType, string searchValue)
        {
            if (string.IsNullOrEmpty(searchValue))
                return getAllreseptionist();

            switch (searchType.ToLower())
            {
                case "id":
                    if (int.TryParse(searchValue, out int id))
                        return db.Reseptionists.Where(p => p.ReseptionistId == id).ToList();
                    break;
                case "name":
                    return db.Reseptionists.Where(p => p.FullName.Contains(searchValue)).ToList();
                case "phone":
                    return db.Reseptionists.Where(p => p.Phone.Contains(searchValue)).ToList();

            }
            return new List<reseptionist>();
        }

        public Doctor GetdoctorById(int doctorid)
        {
            return db.doctors.Find(doctorid);
        }
        public reseptionist GetPatientById(int reseptionistid)
        {
            return db.Reseptionists.Find(reseptionistid);
        }
    }
}