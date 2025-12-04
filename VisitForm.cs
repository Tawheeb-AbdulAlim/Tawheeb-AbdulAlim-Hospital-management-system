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
    public partial class VisitForm : Form
    {

        private VisitsManagement visitService = new VisitsManagement();
        private Visit selectedVisit = null;
        Role curentuserRole;
        public VisitForm(Role curentuserRole)
        {
            InitializeComponent();
            this.curentuserRole = curentuserRole;
            privilleges();
            
           
        }


        private void privilleges()
        {
            if (this.curentuserRole == Role.ADMIN || this.curentuserRole == Role.RESEPTIONIST)
            {
                addButton.Enabled = false;
                //addButton.BackColor = Color.DarkGray;
                //addButton.ForeColor = Color.White;
                editButton.Enabled = false;
                //editButton.BackColor= Color.DarkGray;
                //editButton.ForeColor = Color.White;
                deleteButton.Enabled = false;
                //deleteButton.BackColor = Color.DarkGray;
                //deleteButton.ForeColor = Color.White;
            }
            
        }

        // عند تحميل الفورم
        private void VisitForm_Load(object sender, EventArgs e)
        {


            LoadVisits();
            InitiializeSearchCombox();


        }


        // دالة تفريغ البحث
        private void InitiializeSearchCombox()
        {
            cmbSearchType.Items.Clear();
           // txtSearchValue.Clear();

            // تعبئة ComboBox البحث
            cmbSearchType.Items.AddRange(new string[] {
                "VisitID", "PatientID", "DoctorID", "VisitType", "CurrentMedication", "Notes"
            });
            cmbSearchType.SelectedIndex = 0;
        }



        private void LoadVisits()
        {
            try
            {
                
                // ⚡️ مسح الصفوف فقط مع الحفاظ على الأعمدة
                dataGridView1.Rows.Clear();

                // ⚡️ جلب البيانات
                var visits = visitService.GetAllVisits();

                // ⚡️ إضافة البيانات مباشرة للجدول
                foreach (var visit in visits)
                {
                    dataGridView1.Rows.Add(
                        visit.VisitId,
                        visit.PatientId,
                        visit.DoctorId,
                        visit.VisitDate.ToString("yyyy/MM/dd HH:mm"),
                        visit.VisitType,
                        visit.CurrentMedication,
                        visit.Notes
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
            txtVisitId.Clear();
            txtPatientId.Clear();
            txtDoctorId.Clear();
            dateTimePicker.Value = DateTime.Now;
            txtVisitType.Clear();
            txtCurrentMedication.Clear();
            txtNotes.Clear();
            
            selectedVisit = null;

        }

        // دالة عرض بيانات الزيارة في الحقول - نسخة واحدة فقط
        private void DisplayVisitData(Visit visit)
        {
            if (visit != null)
            {
                txtVisitId.Text = visit.VisitId.ToString();
                txtPatientId.Text = visit.PatientId.ToString();
                txtDoctorId.Text = visit.DoctorId.ToString();
                dateTimePicker.Value = visit.VisitDate;
               
                txtVisitType.Text = visit.VisitType;
                txtCurrentMedication.Text = visit.CurrentMedication;
                txtNotes.Text = visit.Notes;
                selectedVisit = visit;
            }
        }

      





        // دالة التحقق من صحة البيانات
        private bool ValidateVisitData()
        {
            if (!int.TryParse(txtPatientId.Text, out int patientId) || !visitService.PatientExists(patientId))
            {
                MessageBox.Show("Please enter valid Patient ID", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPatientId.Focus();
                return false;
            }

            if (!int.TryParse(txtDoctorId.Text, out int doctorId) || !visitService.DoctorExists(doctorId))
            {
                MessageBox.Show("Please enter valid Doctor ID", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDoctorId.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtVisitType.Text))
            {
                MessageBox.Show("Please enter visit type", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVisitType.Focus();
                return false;
            }

            return true;
        }

        
        // زر الإضافة
        private void addButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (!ValidateVisitData())
                    return;

                Visit newVisit = new Visit
                {
                    PatientId = int.Parse(txtPatientId.Text),
                    DoctorId = int.Parse(txtDoctorId.Text),
                    VisitDate = dateTimePicker.Value,
                    VisitType = txtVisitType.Text.Trim(),
                    CurrentMedication = txtCurrentMedication.Text.Trim(),
                    Notes = txtNotes.Text.Trim()

                };

                bool success = visitService.AddVisit(newVisit);

                if (success)
                {
                    MessageBox.Show($"Visit added successfully!",
                                   "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVisits();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to add visit. Please try again.",
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding visit: {ex.Message}",
                               "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





        private void editButton_Click(object sender, EventArgs e)
        {
            try
             {
                 // ⚡️ تحديث مباشرة من البيانات في الحقول
                 if (dataGridView1.SelectedRows.Count > 0 || selectedVisit != null)
                 {
                     if (!ValidateVisitData())
                         return;

                     // إذا كان هناك زيارة محددة، استخدمها. وإلا خذ من الجدول
                     Visit visitToUpdate = selectedVisit;

                     if (visitToUpdate == null && dataGridView1.SelectedRows.Count > 0)
                     {
                         DataGridViewRow row = dataGridView1.SelectedRows[0];
                         if (row.Cells["VisitID"].Value != null)
                         {
                             int visitId = Convert.ToInt32(row.Cells["VisitID"].Value);
                             visitToUpdate = visitService.GetVisitById(visitId);
                         }
                     }

                     if (visitToUpdate != null)
                     {
                         // تحديث البيانات من الحقول
                         visitToUpdate.PatientId = int.Parse(txtPatientId.Text);
                         visitToUpdate.DoctorId = int.Parse(txtDoctorId.Text);
                         visitToUpdate.VisitDate = dateTimePicker.Value;

                         visitToUpdate.VisitType = txtVisitType.Text.Trim();
                         visitToUpdate.CurrentMedication = txtCurrentMedication.Text.Trim();
                         visitToUpdate.Notes = txtNotes.Text.Trim();

                         bool success = visitService.UpdateVisit(visitToUpdate);

                         if (success)
                         {
                             MessageBox.Show($"Visit updated successfully!",
                                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             LoadVisits();
                             ClearFields();
                         }
                         else
                         {
                             MessageBox.Show("Failed to update visit. Please try again.",
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                     }
                     else
                     {
                         MessageBox.Show("Please select a visit to update",
                                       "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }
                 }
                 else
                 {
                     MessageBox.Show("Please select a visit to update",
                                   "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Error updating visit: {ex.Message}",
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

             


        }



        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // ⚡️ احذف مباشرة من الصف المحدد
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    if (row.Cells["VisitID"].Value != null)
                    {
                        int visitId = Convert.ToInt32(row.Cells["VisitID"].Value);
                        string visitInfo = $"Visit #{visitId} - {row.Cells["VisitType"].Value?.ToString() ?? "Unknown"}";

                        var result = MessageBox.Show($"Are you sure you want to delete: {visitInfo}?",
                                                   "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            bool success = visitService.DeleteVisit(visitId);

                            if (success)
                            {
                                MessageBox.Show($"Visit deleted successfully!",
                                               "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadVisits();
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete visit. Please try again.",
                                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a visit row to delete",
                                  "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting visit: {ex.Message}",
                               "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // زر التحديث
       
        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                LoadVisits();
                ClearFields();
                txtSearchValue.Clear();
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
              //  هنا يتم التحقيق من الحقول 
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
                var visits = visitService.SearchVisits(searchType, searchValue);

                // عرض النتائج بنفس طريقة التحميل العادية

                //هنا يتم تنظيف الصفوف كامل 
                dataGridView1.Rows.Clear();
               //هنا يتم عرض الصفوف الراجعه من البحث
                foreach (var visit in visits)
                {
                    dataGridView1.Rows.Add(
                        visit.VisitId,
                        visit.PatientId,
                        visit.DoctorId,
                        visit.VisitDate.ToString("yyyy/MM/dd HH:mm"),
                        visit.VisitType,
                        visit.CurrentMedication,
                        visit.Notes
                    );
                }

                if (visits.Count == 0)
                {
                    MessageBox.Show("No visits found with the specified criteria",
                                  "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during search: {ex.Message}",
                               "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        

        // ⚡ إضافة حدث CellClick بدلاً من CellContentClick للاختيار الأفضل
       private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    if (row.Cells["VisitID"].Value != null && int.TryParse(row.Cells["VisitID"].Value.ToString(), out int VisitId))
                    {
                        selectedVisit = visitService.GetVisitById(VisitId);
                        if (selectedVisit != null)
                        {
                            DisplayVisitData(selectedVisit);

                            // ✅ تأكيد الاختيار بصرياً
                            dataGridView1.ClearSelection();
                            row.Selected = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting visit: {ex.Message}");
            }
        }
        


        




        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(curentuserRole);
            f.Show();
            this.Hide();
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }











             





            private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void topPan1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void topPan1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
