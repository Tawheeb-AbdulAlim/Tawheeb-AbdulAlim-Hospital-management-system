using System;
using System.Collections.Generic;
using System.Linq;
using Hospital_management_system.Models;

namespace Hospital_management_system.Services
{
    /// <summary>
    /// خدمة مسؤولة عن جميع عمليات إدارة المرضى في قاعدة البيانات
    /// </summary>
    public class PatientManagement
    {
        private hospitaldbcontext db = new hospitaldbcontext();

        // ============ العمليات الأساسية (CRUD) ============

        /// <summary>
        /// إضافة مريض جديد إلى قاعدة البيانات
        /// </summary>
        /// <param name="patient">كائن المريض المراد إضافته</param>
        /// <returns>صحيح إذا نجحت العملية، خطأ إذا فشلت</returns>
        public bool AddPatient(Patient patient)
        {
            try
            {
                db.patients.Add(patient);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// تحديث بيانات مريض موجود في قاعدة البيانات
        /// </summary>
        /// <param name="patient">كائن المريض بعد التعديل</param>
        /// <returns>صحيح إذا نجحت العملية، خطأ إذا فشلت</returns>
        public bool UpdatePatient(Patient patient)
        {
            try
            {
                var existingPatient = db.patients.Find(patient.PatientId);
                if (existingPatient != null)
                {
                    // تحديث جميع الحقول
                    existingPatient.FullName = patient.FullName;
                    existingPatient.Age = patient.Age;
                    existingPatient.Gender = patient.Gender;
                    existingPatient.Phone = patient.Phone;
                    existingPatient.BloodType = patient.BloodType;

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

        /// <summary>
        /// حذف مريض من قاعدة البيانات باستخدام الرقم التعريفي
        /// </summary>
        /// <param name="patientId">رقم المريض المراد حذفه</param>
        /// <returns>صحيح إذا نجحت العملية، خطأ إذا فشلت</returns>
        public bool DeletePatient(int patientId)
        {
            try
            {
                var patient = db.patients.Find(patientId);
                if (patient != null)
                {
                    db.patients.Remove(patient);
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

        // ============ عمليات الاستعلام والبحث ============

        /// <summary>
        /// جلب قائمة بجميع المرضى المسجلين في النظام
        /// </summary>
        /// <returns>قائمة تحتوي على جميع المرضى</returns>
        public List<Patient> GetAllPatients()
        {
            return db.patients.ToList();
        }

        /// <summary>
        /// البحث عن مرضى باستخدام معايير محددة
        /// </summary>
        /// <param name="searchType">نوع البحث (id, name, phone)</param>
        /// <param name="searchValue">القيمة المراد البحث عنها</param>
        /// <returns>قائمة المرضى الذين يطابقون معايير البحث</returns>
        public List<Patient> SearchPatients(string searchType, string searchValue)
        {
            if (string.IsNullOrEmpty(searchValue))
                return GetAllPatients();

            switch (searchType.ToLower())
            {
                case "id":
                    if (int.TryParse(searchValue, out int id))
                        return db.patients.Where(p => p.PatientId == id).ToList();
                    break;
                case "name":
                    return db.patients.Where(p => p.FullName.Contains(searchValue)).ToList();
                case "phone":
                    return db.patients.Where(p => p.Phone.Contains(searchValue)).ToList();
                default:
                    return GetAllPatients();
            }
            return new List<Patient>();
        }
        /// <summary>
        /// جلب بيانات مريض محدد باستخدام الرقم التعريفي
        /// </summary>
        /// <param name="patientId">رقم المريض المطلوب</param>
        /// <returns>كائن المريض إذا وجد، أو null إذا لم يوجد</returns>
        public Patient GetPatientById(int patientId)
        {
            return db.patients.Find(patientId);
        }
    }

}
