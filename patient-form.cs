
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_management_system.Models;
using Hospital_management_system.Services;

namespace Hospital_management_system
{
    public partial class lblSearchBy : Form
    {
        // ============ المتغيرات الأساسية ============
        private PatientManagement patientService = new PatientManagement();
        private Patient selectedPatient = null;

        Role curentuserRole;
        public lblSearchBy(Role role)


        
        

        {
            InitializeComponent();
            this.curentuserRole = role;
            privilleges();
            
            
        }




        private void privilleges() {
            if (this.curentuserRole == Role.DOCTOR)
            {
                deleteButton.Enabled = false;
                //deleteButton.BackColor = Color.Gray;
                //deleteButton.ForeColor = Color.White;
            }
            if (this.curentuserRole == Role.ADMIN || this.curentuserRole == Role.DOCTOR) { 
                addButton.Enabled = false;
                //addButton.BackColor = Color.Gray;
                //addButton.ForeColor = Color.White;

                editButton.Enabled = false;
                //editButton.BackColor = Color.Gray;
                //editButton.ForeColor = Color.White;
          
            }
            
            
   

        }

        // ============ دوال التحميل والتهيئة ============

        /// <summary>
        /// تحميل النموذج - يتم استدعاؤها عند فتح الشاشة
        /// </summary>
        private void patient_form_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }

        /// <summary>
        /// تحميل قائمة المرضى وعرضها في الجدول
        /// </summary>

        private void LoadPatients()
        {
            try
            {
                // مسح الجدول أولاً
                dataGridView.Rows.Clear();

                // جلب جميع المرضى من قاعدة البيانات
                var patients = patientService.GetAllPatients();

                // إضافة كل مريض إلى الجدول
                foreach (var patient in patients)
                {
                    dataGridView.Rows.Add(
                        patient.PatientId,
                        patient.FullName,
                        patient.Age,
                        patient.Gender,
                        patient.Phone,
                        patient.BloodType
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل البيانات: {ex.Message}", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============ دوال إدارة الحقول ============

        /// <summary>
        /// تفريغ جميع حقول إدخال البيانات
        /// </summary>
        private void ClearFields()
        {
            fullName.Clear();
            numAge.Value = 0;
            cmbGender.SelectedIndex = -1;
            txtPhone.Clear();
            cmbBloodType.SelectedIndex = -1;
            txtPatientId.Clear();
            selectedPatient = null;
        }

        /// <summary>
        /// تفريغ حقول البحث
        /// </summary>
        private void ClearSearch()
        {
            txtSearchValue.Clear();
            cmbSearchType.SelectedIndex = -1;
        }

        /// <summary>
        /// عرض بيانات مريض محدد في الحقول
        /// </summary>
        /// <param name="patient">كائن المريض المراد عرض بياناته</param>
       
        // دالة عرض بيانات المريض في الحقول - نسخة واحدة فقط
        private void DisplayPatientData(Patient patient)
        {
            if (patient != null)
            {
                txtPatientId.Text = patient.PatientId.ToString();
                fullName.Text = patient.FullName;
                numAge.Value = patient.Age;
                cmbGender.Text = patient.Gender;
                txtPhone.Text = patient.Phone;
                cmbBloodType.Text = patient.BloodType;
                selectedPatient = patient;
            }
        }

        // دالة تفريغ البحث
      

        // ============ دوال التحقق من الصحة ============

        /// <summary>
        /// التحقق من صحة البيانات المدخلة قبل الحفظ
        /// </summary>
        /// <returns>صحيح إذا كانت البيانات صحيحة، خطأ إذا كانت غير صالحة</returns>
        private bool ValidatePatientData()
        {
            // التحقق من الاسم
            if (string.IsNullOrWhiteSpace(fullName.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم المريض", "خطأ في التحقق",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fullName.Focus();
                return false;
            }

            // التحقق من رقم الهاتف
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("الرجاء إدخال رقم الهاتف", "خطأ في التحقق",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }


            if (numAge.Value <= 0 || numAge.Value >120)

            {
                MessageBox.Show("الرجاء إدخال عمر صحيح (1-120)", "خطأ في التحقق",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numAge.Focus();
                return false;
            }

            return true;
        }

        // ============ معالجة أحداث الجدول ============

        /// <summary>
        /// تحديث الحقول عند اختيار مريض من الجدول
        /// </summary>
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView.SelectedRows[0];

                    if (row.Cells["ID"].Value != null &&
                        !string.IsNullOrEmpty(row.Cells["ID"].Value.ToString()))
                    {
                        int patientId = Convert.ToInt32(row.Cells["ID"].Value);
                        selectedPatient = patientService.GetPatientById(patientId);

                        if (selectedPatient != null)
                        {
                            DisplayPatientData(selectedPatient);
                        }
                    }
                }
            }
            catch (Exception)
            {
                // تجاهل الأخطاء البسيطة في الاختيار
            }
        }

        // ============ أحداث الأزرار الرئيسية ============

        /// <summary>
        /// إضافة مريض جديد - زر الإضافة
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                // التحقق من صحة البيانات
                if (!ValidatePatientData())
                    return;

                // إنشاء كائن المريض الجديد
                Patient newPatient = new Patient
                {
                    FullName = fullName.Text.Trim(),
                    Age = (int)numAge.Value,
                    Gender = cmbGender.SelectedItem?.ToString() ?? "Male",
                    Phone = txtPhone.Text.Trim(),
                    BloodType = cmbBloodType.SelectedItem?.ToString() ?? "A+",
                    reseptionId = 1  // افتراضياً موظف الاستقبال رقم 1
                };

                // محاولة الحفظ في قاعدة البيانات
                bool success = patientService.AddPatient(newPatient);

                if (success)
                {
                    MessageBox.Show($"تم إضافة المريض {newPatient.FullName} بنجاح",
                        "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // تحديث العرض
                    LoadPatients();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("فشل في إضافة المريض. الرجاء المحاولة مرة أخرى",
                        "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في إضافة المريض: {ex.Message}",
                    "خطأ في قاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// تعديل بيانات مريض - زر التعديل
        /// </summary>
 
        private void editButton_Click(object sender,EventArgs e)
        {
            try
            {
                // التحقق من وجود مريض محدد
                if (dataGridView.SelectedRows.Count > 0 || selectedPatient != null)
                {
                    // التحقق من صحة البيانات
                    if (!ValidatePatientData())
                        return;

                    // تحديد المريض المراد تعديله
                    Patient patientToUpdate = selectedPatient;

                    if (patientToUpdate == null && dataGridView.SelectedRows.Count > 0)
                    {
                        DataGridViewRow row = dataGridView.SelectedRows[0];
                        if (row.Cells["ID"].Value != null)
                        {
                            int patientId = Convert.ToInt32(row.Cells["ID"].Value);
                            patientToUpdate = patientService.GetPatientById(patientId);
                        }
                    }

                    if (patientToUpdate != null)
                    {
                        // تحديث بيانات المريض
                        patientToUpdate.FullName = fullName.Text.Trim();
                        patientToUpdate.Age = (int)numAge.Value;
                        patientToUpdate.Gender = cmbGender.SelectedItem?.ToString() ?? "Male";
                        patientToUpdate.Phone = txtPhone.Text.Trim();
                        patientToUpdate.BloodType = cmbBloodType.SelectedItem?.ToString() ?? "A+";

                        // حفظ التعديلات
                        bool success = patientService.UpdatePatient(patientToUpdate);

                        if (success)
                        {
                            MessageBox.Show($"تم تحديث بيانات المريض {patientToUpdate.FullName} بنجاح",
                                "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // تحديث العرض
                            LoadPatients();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("فشل في تحديث بيانات المريض. الرجاء المحاولة مرة أخرى",
                                "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("الرجاء اختيار مريض للتعديل",
                        "اختيار مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحديث المريض: {ex.Message}",
                    "خطأ في قاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// حذف مريض - زر الحذف
        /// </summary>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView.SelectedRows[0];

                    if (row.Cells["ID"].Value != null)
                    {
                        int patientId = Convert.ToInt32(row.Cells["ID"].Value);
                        string patientName = row.Cells["fullNameColumn"].Value?.ToString() ?? "غير معروف";

                        // طلب تأكيد الحذف
                        var result = MessageBox.Show(
                            $"هل أنت متأكد من حذف المريض: {patientName}؟",
                            "تأكيد الحذف",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            bool success = patientService.DeletePatient(patientId);

                            if (success)
                            {
                                MessageBox.Show($"تم حذف المريض {patientName} بنجاح",
                                    "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // تحديث العرض
                                LoadPatients();
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("فشل في حذف المريض. الرجاء المحاولة مرة أخرى",
                                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("الرجاء اختيار مريض للحذف",
                        "اختيار مطلوب", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في حذف المريض: {ex.Message}",
                    "خطأ في قاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// تحديث البيانات وعرضها من جديد - زر التحديث
        /// </summary>
        private void refreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPatients();
                ClearFields();
                ClearSearch();

                MessageBox.Show("تم تحديث البيانات بنجاح",
                    "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحديث البيانات: {ex.Message}",
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============ دوال البحث ============

        /// <summary>
        /// البحث عن مرضى - زر البحث
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchType = cmbSearchType.SelectedItem?.ToString();
                string searchValue = txtSearchValue.Text.Trim();

                // التحقق من إدخال نوع البحث
                if (string.IsNullOrEmpty(searchType))
                {
                    MessageBox.Show("الرجاء اختيار نوع البحث", "بحث",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbSearchType.Focus();
                    return;
                }

                // التحقق من إدخال قيمة البحث
                if (string.IsNullOrEmpty(searchValue))
                {
                    MessageBox.Show("الرجاء إدخال قيمة البحث", "بحث",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSearchValue.Focus();
                    return;
                }

                // تنفيذ البحث
                var patients = patientService.SearchPatients(searchType, searchValue);

                // عرض النتائج
                dataGridView.Rows.Clear();
                foreach (var patient in patients)
                {
                    dataGridView.Rows.Add(
                        patient.PatientId,
                        patient.FullName,
                        patient.Age,
                        patient.Gender,
                        patient.Phone,
                        patient.BloodType
                    );
                }

                // عرض رسالة إذا لم توجد نتائج
                if (patients.Count == 0)
                {
                    MessageBox.Show("لم يتم العثور على مرضى مطابقين لمعايير البحث",
                        "نتيجة البحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء البحث: {ex.Message}",
                    "خطأ في البحث", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// تفعيل البحث بالضغط على زر Enter في حقل البحث
        /// </summary>
        private void txtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // عند النقر على صف في الجدول - معدل
       private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView.Rows.Count)
                {
                    DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                    // استخراج ID المريض من العمود الأول
                    if (row.Cells["ID"].Value != null && int.TryParse(row.Cells["ID"].Value.ToString(), out int patientId))
                    {
                        selectedPatient = patientService.GetPatientById(patientId);
                        if (selectedPatient != null)
                        {
                            DisplayPatientData(selectedPatient);
                        }
                        else
                        {
                            MessageBox.Show("Patient not found in database!", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting patient: {ex.Message}",
                               "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ⚡ إضافة حدث CellClick بدلاً من CellContentClick للاختيار الأفضل
      private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView.Rows.Count)
                {
                    DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                    if (row.Cells["ID"].Value != null && int.TryParse(row.Cells["ID"].Value.ToString(), out int patientId))
                    {
                        selectedPatient = patientService.GetPatientById(patientId);
                        if (selectedPatient != null)
                        {
                            DisplayPatientData(selectedPatient);

                            // ✅ تأكيد الاختيار بصرياً
                            dataGridView.ClearSelection();
                            row.Selected = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting patient: {ex.Message}");
            }
        }

        
        // عند تحميل الفورم
        //private void patient_form_Load(object sender, EventArgs e)
       // {
       //     LoadPatients();
          
       // }

        // ============ دوال التنقل ============

        /// <summary>
        /// العودة إلى الشاشة الرئيسية - زر الرجوع
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(curentuserRole);
            f.Show();
            this.Hide();
        }

        // هذه الدوال يمكن حذفها إذا لم تستخدم
        private void button2_Click(object sender, EventArgs e)
        {
            // لا شيء - يمكن حذفها
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // لا شيء - يمكن حذفها
        }
        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // لا شيء - يمكن حذفها (مكررة)
        }


        private void lblSearch_TextChanged(object sender, EventArgs e)
        {

        }


        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numAge_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
