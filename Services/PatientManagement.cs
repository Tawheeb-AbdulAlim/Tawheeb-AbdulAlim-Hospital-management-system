using System;
using System.Collections.Generic;
using System.Linq;
using Hospital_management_system.Models;

namespace Hospital_management_system.Services
{
    public class PatientManagement
    {
        private hospitaldbcontext db = new hospitaldbcontext();

        // إضافة مريض جديد
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

        // تحديث بيانات مريض

        public bool add(Patient e) {
            
            return true;
        }
        public bool UpdatePatient(Patient patient)
        {
            try
            {
                var existingPatient = db.patients.Find(patient.PatientId);
                if (existingPatient != null)
                {
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

        // حذف مريض
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

        // جلب جميع المرضى
        public List<Patient> GetAllPatients()
        {
            return db.patients.ToList();
        }

        // البحث عن مرضى
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

        // جلب مريض بواسطة ID
        public Patient GetPatientById(int patientId)
        {
            return db.patients.Find(patientId);
        }
    }
}