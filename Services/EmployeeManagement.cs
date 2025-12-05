

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Hospital_management_system.Models;

namespace Hospital_management_system.Services
{
    public class EmployeeManagement
    {
        private hospitaldbcontext db = new hospitaldbcontext();

        public bool addemployee(Employee employee)
        {
            try
            {
                if (employee == null)
                {
                    MessageBox.Show("Employee is null");
                    return false;
                }

                if (employee.Role == Role.DOCTOR)
                {
                    Doctor doctor = (Doctor)employee;
                    db.doctors.Add(doctor);
                    db.SaveChanges();
                    return true;
                }

                if (employee.Role == Role.RESEPTIONIST)
                {
                    reseptionist reseptionist = (reseptionist)employee;
                    db.Reseptionists.Add(reseptionist);
                    db.SaveChanges();
                    return true;
                }

                MessageBox.Show("Invalid role");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message);
                return false;
            }
        }

        public bool updateEmployee(Employee employee)
        {
            try
            {
                if (employee == null)
                {
                    MessageBox.Show("erorr", "employee empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
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
                        olddoctor.Age = newdoctor.Age;

                        // ✅ إضافة: تحديث التخصص إذا كان موجوداً
                        if (!string.IsNullOrEmpty(newdoctor.Specialization))
                            olddoctor.Specialization = newdoctor.Specialization;

                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("لم يتم العثور على الطبيب", "خطأ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
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
                        oldreseptionist.Age = newreseptionist.Age;
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("لم يتم العثور على موظف الاستقبال", "خطأ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                MessageBox.Show("الدور غير معروف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message);
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
                    {
                        MessageBox.Show("لم يتم العثور على الطبيب", "خطأ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
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
                    else
                    {
                        MessageBox.Show("لم يتم العثور على موظف الاستقبال", "خطأ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    }
                MessageBox.Show("الدور غير معروف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting employee: " + ex.Message);
                return false;
            }
        }

        public List<Doctor> getAllDoctor()
        {

            try
            {
                return db.doctors.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في جلب الأطباء: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Doctor>();
            }
        }
            
        

        public List<reseptionist> getAllreseptionist()
        {
            try
            {
                return db.Reseptionists.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في جلب موظفي الاستقبال: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<reseptionist>();
            }
        }

        public List<Employee> GetAllEmployees()
        {
            try
            {
                var employees = new List<Employee>();

                var doctors = getAllDoctor();
                foreach (var doctor in doctors)
                {
                    doctor.Role = Role.DOCTOR;
                    employees.Add(doctor);
                }

                var receptionists = getAllreseptionist();
                foreach (var receptionist in receptionists)
                {
                    receptionist.Role = Role.RESEPTIONIST;
                    employees.Add(receptionist);
                }

                return employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في جلب جميع الموظفين: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Employee>();
            }

        }




        public Doctor GetdoctorById(int doctorid)
        {
            try
            {
                return db.doctors.Find(doctorid);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في جلب الطبيب بالرقم: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public reseptionist GetReceptionistById(int reseptionistid)
        {
            try
            {
                return db.Reseptionists.Find(reseptionistid);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في جلب موظف الاستقبال بالرقم: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // دالة البحث العامة - تم التصحيح
        public List<Employee> SearchEmployees(string searchType, string searchValue)
        {
            var result = new List<Employee>();

            switch (searchType.ToLower())
            {
                case "id":
                    if (int.TryParse(searchValue, out int id))
                    {
                        var doctor = GetdoctorById(id);
                        if (doctor != null)
                        {
                            doctor.Role = Role.DOCTOR;
                            result.Add(doctor);
                        }

                        var receptionist = GetReceptionistById(id);
                        if (receptionist != null)
                        {
                            receptionist.Role = Role.RESEPTIONIST;
                            result.Add(receptionist);
                        }
                    }
                    break;

                case "name":
                    // 🔥 التصحيح: استخدم ToUpper() بدلاً من StringComparison
                    string searchName = searchValue.ToUpper();

                    var doctors = getAllDoctor()
                        .Where(d => d.FullName.ToUpper().Contains(searchName))
                        .ToList();
                    foreach (var doctor in doctors)
                    {
                        doctor.Role = Role.DOCTOR;
                        result.Add(doctor);
                    }

                    var receptionists = getAllreseptionist()
                        .Where(r => r.FullName.ToUpper().Contains(searchName))
                        .ToList();
                    foreach (var receptionist in receptionists)
                    {
                        receptionist.Role = Role.RESEPTIONIST;
                        result.Add(receptionist);
                    }
                    break;

                case "phone":
                    var doctorsByPhone = getAllDoctor()
                        .Where(d => d.Phone.Contains(searchValue))
                        .ToList();
                    foreach (var doctor in doctorsByPhone)
                    {
                        doctor.Role = Role.DOCTOR;
                        result.Add(doctor);
                    }

                    var receptionistsByPhone = getAllreseptionist()
                        .Where(r => r.Phone.Contains(searchValue))
                        .ToList();
                    foreach (var receptionist in receptionistsByPhone)
                    {
                        receptionist.Role = Role.RESEPTIONIST;
                        result.Add(receptionist);
                    }
                    break;

                case "role":
                    if (searchValue.ToUpper() == "DOCTOR")
                    {
                        var allDoctors = getAllDoctor();
                        foreach (var doctor in allDoctors)
                        {
                            doctor.Role = Role.DOCTOR;
                            result.Add(doctor);
                        }
                    }
                    else if (searchValue.ToUpper() == "RECEPTIONIST")
                    {
                        var allReceptionists = getAllreseptionist();
                        foreach (var receptionist in allReceptionists)
                        {
                            receptionist.Role = Role.RESEPTIONIST;
                            result.Add(receptionist);
                        }
                    }
                    break;
            }

            return result;
        }

        // دالة مساعدة للبحث في Form (اختيارية)
        public List<Employee> SimpleSearch(string searchType, string searchValue)
        {
            return SearchEmployees(searchType, searchValue);
        }

        // ✅ إضافة: دالة للحصول على موظف بالرقم والدور
        public Employee GetEmployeeByIdAndRole(int id, Role role)
        {
            try
            {
                if (role == Role.DOCTOR)
                {
                    var doctor = GetdoctorById(id);
                    if (doctor != null)
                        doctor.Role = Role.DOCTOR;
                    return doctor;
                }
                else if (role == Role.RESEPTIONIST)
                {
                    var receptionist = GetReceptionistById(id);
                    if (receptionist != null)
                        receptionist.Role = Role.RESEPTIONIST;
                    return receptionist;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في جلب الموظف: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // ✅ إضافة: دالة للتحقق من وجود موظف
        public bool EmployeeExists(int id, Role role)
        {
            try
            {
                if (role == Role.DOCTOR)
                {
                    return db.doctors.Any(d => d.DoctorId == id);
                }
                else if (role == Role.RESEPTIONIST)
                {
                    return db.Reseptionists.Any(r => r.ReseptionistId == id);
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في التحقق من وجود الموظف: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }




    }
}




































/*using System;
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

*/