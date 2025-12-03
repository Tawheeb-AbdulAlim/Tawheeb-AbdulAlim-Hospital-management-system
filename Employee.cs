
using Hospital_management_system.Models;
using Hospital_management_system.Services;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Hospital_management_system
{
    public partial class Employeemanagement : Form
    {
        public Employeemanagement()
        {
            InitializeComponent();
        }

        private EmployeeManagementServices employeeManagementServices = new EmployeeManagementServices();
        private Employee selectedemployee = null;

        //public lblSearchBy()
        //{
        //    InitializeComponent();
        //}

        private void Loademployee()
        {
            try
            {
                // ⚡️ مسح الصفوف فقط مع الحفاظ على الأعمدة
                dataGridView1.Rows.Clear();

                // ⚡️ جلب البيانات
                var doctors = employeeManagementServices.getAllDoctor();

                // ⚡️ إضافة البيانات مباشرة للجدول
                foreach (var doctor in doctors)
                {
                    dataGridView1.Rows.Add(
                        doctor.DoctorId,
                        doctor.FullName,
                        doctor.Age,
                        //doctor.gender,
                        doctor.Phone,
                        doctor.Salary,
                        doctor.Specialization
                    );
                }


                var reseptionists = employeeManagementServices.getAllDoctor();

                // ⚡️ إضافة البيانات مباشرة للجدول
                foreach (var reseption in reseptionists)
                {
                    dataGridView1.Rows.Add(
                        reseption.DoctorId,
                        reseption.FullName,
                        reseption.Age,
                        //doctor.gender,
                        reseption.Phone,
                        reseption.Salary,
                        reseption.Specialization
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // دالة تفريغ الحقول
        //private void ClearFields()
        //{
        //    txtNameEmpl.Clear();
        //    numAgeEmpl.Value = 0;
        //    gender.SelectedIndex = -1;
        //    txtPhoneEmpl.Clear();

        //    txtEmailEmpl.Clear();
        //    selectedemployee = null;

        //    تحديث حالة الأزرار بعد التفريغ

        //}


        private bool ValidateemployeeData()
        {
            if (string.IsNullOrWhiteSpace(txtNameEmpl.Text))
            {
                MessageBox.Show("Please enter patient name", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameEmpl.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneEmpl.Text))
            {
                MessageBox.Show("Please enter phone number", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneEmpl.Focus();
                return false;
            }

            if (numAgeEmpl.Value <= 0 || numAgeEmpl.Value > 120)
            {
                MessageBox.Show("Please enter valid age (1-120)", "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numAgeEmpl.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmailEmpl.Text) || !txtEmailEmpl.Text.Contains("@"))
            {
                MessageBox.Show("please enert vilov email addres", "Error");
                txtEmailEmpl.Focus();
                return false;
            }
            if (!decimal.TryParse(txtSalaryEmpl.Text, out decimal salary) || salary <= 0)
            {
                MessageBox.Show(" please please enert vilov salary", "Error");
                txtSalaryEmpl.Focus();
                return false;
            }
            return true;
        }
        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try

            {

                if (!ValidateemployeeData())
                    return;
                Employee newemployee;
                string role = cmRole.SelectedItem.ToString();
                if (role == Role.DOCTOR.ToString()) {
                    newemployee = new Doctor();
                    newemployee.Role =Role.DOCTOR;
                }
                   

                else {
                    newemployee = new reseptionist();
                    newemployee.Role = Role.RESEPTIONIST;
                }
                    


                newemployee.FullName = txtNameEmpl.Text.Trim();
                newemployee.Age = (int)numAgeEmpl.Value;
                //Gender = cmbGender.SelectedItem?.ToString() ?? "Male",
                newemployee.Phone = txtPhoneEmpl.Text.Trim();

                
                newemployee.Salary = Convert.ToInt32(txtSalaryEmpl.Text);
                newemployee.Email = txtEmailEmpl.Text.Trim();

                 bool success;

                
                    
                    success = employeeManagementServices.addemployee(newemployee);

                    if (success)
                    {
                        MessageBox.Show($"employee {newemployee.FullName} added successfully!",
                                       "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Loademployee();
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

     

        

        private void ClearFields()
        {
            txtNameEmpl.Text = "";
            numAgeEmpl.Value = 25;
            txtEmailEmpl.Text = "";
            txtPhoneEmpl.Text = "";
            txtSalaryEmpl.Text = "";
            txtNameEmpl.Focus();
        }

        

        private void backButtonEmp_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Loademployee();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // كود بسيط للحذف
            try
            {
                // ⚡️ احذف مباشرة من الصف المحدد
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    if (row.Cells["ID"].Value != null)
                    {
                        int employeeid = Convert.ToInt32(row.Cells["ID"].Value);
                        string employeeName = row.Cells["fullNameColumn"].Value?.ToString() ?? "Unknown";

                        var result = MessageBox.Show($"Are you sure you want to delete employee: {employeeName}?",
                                                   "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            Role role;
                            if (cmRole.SelectedItem.ToString() == Role.DOCTOR.ToString())
                                role = Role.DOCTOR;
                            else
                                role = Role.RESEPTIONIST;
                                bool success = employeeManagementServices.deletemployee(employeeid,role);

                            if (success)
                            {
                                MessageBox.Show($"Patient {employeeName} deleted successfully!",
                                               "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Loademployee ();
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

        

        private void btnEdite_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            // كود بسيط للبحث
            MessageBox.Show("Search button clicked - Add your search logic here");
        }

        private void Employeemanagement_Load(object sender, EventArgs e)
        {

        }
    }
}