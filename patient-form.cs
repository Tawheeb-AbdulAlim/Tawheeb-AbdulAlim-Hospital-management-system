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
        private PatientManagement patientService = new PatientManagement();
        private Patient selectedPatient = null;

        public lblSearchBy()
        {
            InitializeComponent();
        }

        private void LoadPatients()
        {
            try
            {
                // ⚡️ مسح الصفوف فقط مع الحفاظ على الأعمدة
                dataGridView.Rows.Clear();

                // ⚡️ جلب البيانات
                var patients = patientService.GetAllPatients();

                // ⚡️ إضافة البيانات مباشرة للجدول
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
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // دالة تفريغ الحقول
        private void ClearFields()
        {
            fullName.Clear();
            numAge.Value = 0;
            cmbGender.SelectedIndex = -1;
            txtPhone.Clear();
            cmbBloodType.SelectedIndex = -1;
            txtPatientId.Clear();
            selectedPatient = null;

            // تحديث حالة الأزرار بعد التفريغ
            
        }

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

                // تحديث حالة الأزرار
                
            }
        }

        // دالة تفريغ البحث
        private void ClearSearch()
        {
            txtSearchValue.Clear();
            cmbSearchType.SelectedIndex = -1;
        }

        // دالة التحقق من صحة البيانات
        private bool ValidatePatientData()
        {
            if (string.IsNullOrWhiteSpace(fullName.Text))
            {
                MessageBox.Show("Please enter patient name", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter phone number", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            if (numAge.Value <= 0 || numAge.Value > 120)
            {
                MessageBox.Show("Please enter valid age (1-120)", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numAge.Focus();
                return false;
            }

            return true;
        }
        // ⚡️ حدث عند تغيير الاختيار في الجدول
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView.SelectedRows[0];
                    if (row.Cells["ID"].Value != null && !string.IsNullOrEmpty(row.Cells["ID"].Value.ToString()))
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
            catch (Exception ex)
            {
                // تجاهل الأخطاء البسيطة في الاختيار
            }
        }


        // زر الإضافة
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidatePatientData())
                    return;
                Patient newPatient = new Patient
                {
                    FullName = fullName.Text.Trim(),
                    Age = (int)numAge.Value,
                    Gender = cmbGender.SelectedItem?.ToString() ?? "Male",
                    Phone = txtPhone.Text.Trim(),
                    BloodType = cmbBloodType.SelectedItem?.ToString() ?? "A+",
                    reseptionId = 1
                };

                bool success = patientService.AddPatient(newPatient);

                if (success)
                {
                    MessageBox.Show($"Patient {newPatient.FullName} added successfully!",
                                   "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPatients();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to add patient. Please try again.",
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding patient: {ex.Message}",
                               "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editButton_Click(object sender,EventArgs e)
        {
            try
            {
                // ⚡️ تحديث مباشرة من البيانات في الحقول
                if (dataGridView.SelectedRows.Count > 0 || selectedPatient != null)
                {
                    if (!ValidatePatientData())
                        return;

                    // إذا كان هناك مريض محدد، استخدمه. وإلا خذ من الجدول
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
                        // تحديث البيانات من الحقول
                        patientToUpdate.FullName = fullName.Text.Trim();
                        patientToUpdate.Age = (int)numAge.Value;
                        patientToUpdate.Gender = cmbGender.SelectedItem?.ToString() ?? "Male";
                        patientToUpdate.Phone = txtPhone.Text.Trim();
                        patientToUpdate.BloodType = cmbBloodType.SelectedItem?.ToString() ?? "A+";

                        bool success = patientService.UpdatePatient(patientToUpdate);

                        if (success)
                        {
                            MessageBox.Show($"Patient {patientToUpdate.FullName} updated successfully!",
                                           "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPatients();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update patient. Please try again.",
                                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a patient to update",
                                      "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a patient to update",
                                  "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating patient: {ex.Message}",
                               "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // ⚡️ احذف مباشرة من الصف المحدد
                if (dataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView.SelectedRows[0];
                    if (row.Cells["ID"].Value != null)
                    {
                        int patientId = Convert.ToInt32(row.Cells["ID"].Value);
                        string patientName = row.Cells["fullNameColumn"].Value?.ToString() ?? "Unknown";

                        var result = MessageBox.Show($"Are you sure you want to delete patient: {patientName}?",
                                                   "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            bool success = patientService.DeletePatient(patientId);

                            if (success)
                            {
                                MessageBox.Show($"Patient {patientName} deleted successfully!",
                                               "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadPatients();
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete patient. Please try again.",
                                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a patient row to delete",
                                  "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting patient: {ex.Message}",
                               "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // زر التحديث
        private void refreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPatients();
                ClearFields();
                ClearSearch();
                MessageBox.Show("Data refreshed successfully!",
                               "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing data: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // زر البحث - معدل
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchType = cmbSearchType.SelectedItem?.ToString();
                string searchValue = txtSearchValue.Text.Trim();

                if (string.IsNullOrEmpty(searchType))
                {
                    MessageBox.Show("Please select search type", "Search",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbSearchType.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(searchValue))
                {
                    MessageBox.Show("Please enter search value", "Search",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSearchValue.Focus();
                    return;
                }

                // البحث باستخدام الخدمة
                var patients = patientService.SearchPatients(searchType, searchValue);

                // عرض النتائج بنفس طريقة التحميل العادية
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

                if (patients.Count == 0)
                {
                    MessageBox.Show("No patients found with the specified criteria",
                                  "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during search: {ex.Message}",
                               "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // البحث عند الضغط على Enter
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
        private void patient_form_Load(object sender, EventArgs e)
        {
            LoadPatients();
          
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            // لا شيء - يمكن حذفها
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
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
    }
}