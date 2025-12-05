using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_management_system.Models;
namespace Hospital_management_system.Services
{
    class VisitsManagement
    {
        
        private hospitaldbcontext db = new hospitaldbcontext();
        // إضافة زيارة جديدة
        public bool AddVisit(Visit visit)
        {
            try
            {
                db.visits.Add(visit);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        


        // تحديث بيانات زيارة
        public bool UpdateVisit(Visit visit)
        {
            try
            {
                var existingVisit = db.visits.Find(visit.VisitId);
                if (existingVisit != null)
                {
                    existingVisit.PatientId = visit.PatientId;
                    existingVisit.DoctorId = visit.DoctorId;
                    existingVisit.VisitDate = visit.VisitDate;
                    existingVisit.VisitType = visit.VisitType;
                    existingVisit.CurrentMedication = visit.CurrentMedication;
                    existingVisit.Notes = visit.Notes;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // حذف زيارة
        public bool DeleteVisit(int visitId)
        {
            try
            {
                var visit = db.visits.Find(visitId);
                if (visit != null)
                {
                    db.visits.Remove(visit);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // جلب جميع الزيارات
        public List<Visit> GetAllVisits()
        {
            return db.visits.ToList();
        }


        // البحث عن زيارات
        public List<Visit> SearchVisits(string searchType, string searchValue)
        {
            if (string.IsNullOrEmpty(searchValue))
                return GetAllVisits();

            switch (searchType.ToLower())
            {
                case "visitid":
                    if (int.TryParse(searchValue, out int visitId))
                        return db.visits.Where(v => v.VisitId == visitId).ToList();
                    break;
                case "patientid":
                    if (int.TryParse(searchValue, out int patientId))
                        return db.visits.Where(v => v.PatientId == patientId).ToList();
                    break;
                case "doctorid":
                    if (int.TryParse(searchValue, out int doctorId))
                        return db.visits.Where(v => v.DoctorId == doctorId).ToList();
                    break;
                case "visittype":
                    return db.visits.Where(v => v.VisitType.Contains(searchValue)).ToList();
                case "currentmedication":
                    return db.visits.Where(v => v.CurrentMedication.Contains(searchValue)).ToList();
                case "notes":
                    return db.visits.Where(v => v.Notes.Contains(searchValue)).ToList();
                default:
                    return GetAllVisits();
            }

            return new List<Visit>();
        }

        // جلب زيارة بواسطة ID
        public Visit GetVisitById(int visitId)
        {

            
               /* try
                {
                    var visit = db.visits.Find(visitId);
                    if (visit == null)
                    {
                        MessageBox.Show($"Visit with ID {visitId} not found in database!"); // 🔥 للتجربة
                    }
                    return visit;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error getting visit: {ex.Message}"); // 🔥 للتجربة
                    return null;
                }
            */


            return db.visits.Find(visitId);
        }

        // التحقق من وجود Patient ID
        public bool PatientExists(int patientId)
        {
            return db.patients.Any(p => p.PatientId == patientId);
        }

        // التحقق من وجود Doctor ID
        public bool DoctorExists(int doctorId)
        {
            return db.doctors.Any(d => d.DoctorId == doctorId);
        }







        // ========== ⚡ الدوال الجديدة المضافة ==========

        // 🔹 دالة جلب جميع المرضى لعرضهم في المساعدة
        public List<Patient> GetAllPatients()
        {
            try
            {
                return db.patients.OrderBy(p => p.PatientId).ToList();
            }
            catch (Exception)
            {
                return new List<Patient>();
            }
        }

        // 🔹 دالة جلب جميع الأطباء لعرضهم في المساعدة
        public List<Doctor> GetAllDoctors()
        {
            try
            {
                return db.doctors.OrderBy(d => d.DoctorId).ToList();
            }
            catch (Exception)
            {
                return new List<Doctor>();
            }
        }


        // 🔹 دالة الحصول على اسم المريض باستخدام الـ ID
        public string GetPatientName(int patientId)
        {
            try
            {
                var patient = db.patients.Find(patientId);
                return patient?.FullName ?? "Unknown Patient";
            }
            catch (Exception)
            {
                return "Unknown";
            }
        }

        // 🔹 دالة الحصول على اسم الطبيب باستخدام الـ ID
        public string GetDoctorName(int doctorId)
        {
            try
            {
                var doctor = db.doctors.Find(doctorId);
                return doctor?.FullName ?? "Unknown Doctor";
            }
            catch (Exception)
            {
                return "Unknown";
            }
        }



        // 🔹 دالة جلب أنواع الزيارات الأكثر شيوعاً
        public List<string> GetCommonVisitTypes()
        {
            return db.visits
                .GroupBy(v => v.VisitType)
                .OrderByDescending(g => g.Count())
                .Take(10)
                .Select(g => g.Key)
                .ToList();
        }



        // 🔹 دالة جلب إحصائيات الزيارات
        public int GetTotalVisits()
        {
            return db.visits.Count();
        }

        public int GetVisitsByPatient(int patientId)
        {
            return db.visits.Count(v => v.PatientId == patientId);
        }

        public int GetVisitsByDoctor(int doctorId)
        {
            return db.visits.Count(v => v.DoctorId == doctorId);
        }

        // 🔹 دالة الحصول على تخصص الطبيب
        public string GetDoctorSpecialization(int doctorId)
        {
            try
            {
                var doctor = db.doctors.Find(doctorId);
                return doctor?.Specialization ?? "Not Specified";
            }
            catch (Exception)
            {
                return "Not Specified";
            }
        }








    }
}
