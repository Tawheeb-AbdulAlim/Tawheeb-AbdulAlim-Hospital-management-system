using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_management_system.Models
{
    public class Patient
    {
        // الخصائص الأساسية الأساسية
        public int PatientId { get; set; }           // رقم المريض
        public string FullName { get; set; }         // الاسم الكامل
        public int Age { get; set; }                 // العمر
        public string Gender { get; set; }           // الجنس
        public string Phone { get; set; }            // الهاتف

        // الخصائص الطبية الأساسية فقط
        public string BloodType { get; set; }        // فصيلة الدم
        public string MedicalCondition { get; set; } // الحالة المرضية

        // الطبيب المعالج
        public string AssignedDoctor { get; set; }   // الطبيب المعالج
    }
}