using System;
using System.Windows.Forms;
using Hospital_management_system.Models;
using Hospital_management_system.Services;

namespace Hospital_management_system
{
    public partial class Employeemanagement : Form
    {
        private EmployeeManagementServices service = new EmployeeManagementServices();

        public Employeemanagement()
        {
            InitializeComponent();
            LoadAllEmployees();
            FillSearchType();
        }

        // ====================== تحميل البيانات ======================
        private void LoadAllEmployees()
        {
            dataGridView1.Rows.Clear();

            if (searchrole.SelectedItem == null || searchrole.SelectedItem.ToString() == "Doctor")
            {
                foreach (var d in service.getAllDoctor())
                {
                    dataGridView1.Rows.Add(d.DoctorId, d.FullName, d.Age, d.Email, d.Phone, d.Salary);
                }
            }

            if (searchrole.SelectedItem?.ToString() == "Receptionist")
            {
                foreach (var r in service.getAllreseptionist())
                {
                    dataGridView1.Rows.Add(r.ReseptionistId, r.FullName, r.Age, r.Email, r.Phone, r.Salary);
                }
            }
        }

        private void FillSearchType()
        {
            cmbSearchTypEmp.Items.Add("ID");
            cmbSearchTypEmp.Items.Add("Name");
            cmbSearchTypEmp.Items.Add("Phone");

            searchrole.Items.Add("Doctor");
            searchrole.Items.Add("Receptionist");
        }

        // ====================== زر الإضافة ======================
        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            if (cmRole.SelectedItem == null)
            {
                MessageBox.Show("Please select Role");
                return;
            }

            string role = cmRole.SelectedItem.ToString();
            Employee emp = null;

            if (role == "Doctor")
            {
                emp = new Doctor()
                {
                    FullName = txtNameEmpl.Text,
                    Age = (int)numAgeEmpl.Value,
                    Phone = txtPhoneEmpl.Text,
                    Email = txtEmailEmpl.Text,
                    Salary = int.Parse(txtSalaryEmpl.Text),
                    Role = Role.DOCTOR,
                    Specialization = "General"
                };
            }
            else if (role == "Receptionist")
            {
                emp = new reseptionist()
                {
                    FullName = txtNameEmpl.Text,
                    Age = (int)numAgeEmpl.Value,
                    Phone = txtPhoneEmpl.Text,
                    Email = txtEmailEmpl.Text,
                    Salary = int.Parse(txtSalaryEmpl.Text),
                    Role = Role.RESEPTIONIST
                };
            }

            bool added = service.addemployee(emp);

            if (added)
            {
                MessageBox.Show("Employee Added!");
                LoadAllEmployees();
            }
            else
            {
                MessageBox.Show("Adding Failed");
            }
        }

        // ====================== زر التعديل ======================
        private void btnEdite_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an employee!");
                return;
            }

            int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string role = searchrole.SelectedItem.ToString();

            Employee emp = null;

            if (role == "Doctor")
            {
                emp = new Doctor()
                {
                    DoctorId = id,
                    FullName = txtNameEmpl.Text,
                    Age = (int)numAgeEmpl.Value,
                    Phone = txtPhoneEmpl.Text,
                    Email = txtEmailEmpl.Text,
                    Salary = int.Parse(txtSalaryEmpl.Text),
                    Role = Role.DOCTOR,
                    Specialization = "General"
                };
            }
            else
            {
                emp = new reseptionist()
                {
                    ReseptionistId = id,
                    FullName = txtNameEmpl.Text,
                    Age = (int)numAgeEmpl.Value,
                    Phone = txtPhoneEmpl.Text,
                    Email = txtEmailEmpl.Text,
                    Salary = int.Parse(txtSalaryEmpl.Text),
                    Role = Role.RESEPTIONIST
                };
            }

            bool updated = service.updateEmployee(emp);

            if (updated)
            {
                MessageBox.Show("Employee Updated!");
                LoadAllEmployees();
            }
            else
            {
                MessageBox.Show("Update Failed!");
            }
        }

        // ====================== زر الحذف ======================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select row");
                return;
            }

            int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string r = searchrole.SelectedItem.ToString();

            Role role = r == "Doctor" ? Role.DOCTOR : Role.RESEPTIONIST;

            bool deleted = service.deletemployee(id, role);

            if (deleted)
            {
                MessageBox.Show("Deleted!");
                LoadAllEmployees();
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }

        // ====================== زر إعادة التحميل ======================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllEmployees();
        }

        // ====================== زر البحث ======================
        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            string type = cmbSearchTypEmp.SelectedItem?.ToString();
            string value = txtsearchEmp.Text;

            if (searchrole.SelectedItem.ToString() == "Doctor")
            {
                dataGridView1.Rows.Clear();
                foreach (var d in service.Searchdoctors(type, value))
                {
                    dataGridView1.Rows.Add(d.DoctorId, d.FullName, d.Age, d.Email, d.Phone, d.Salary);
                }
            }
            else
            {
                dataGridView1.Rows.Clear();
                foreach (var r in service.searchreseptionisr(type, value))
                {
                    dataGridView1.Rows.Add(r.ReseptionistId, r.FullName, r.Age, r.Email, r.Phone, r.Salary);
                }
            }
        }

        // ====================== اختيار صف من الجدول ======================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtNameEmpl.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            numAgeEmpl.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtEmailEmpl.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPhoneEmpl.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSalaryEmpl.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void backButtonEmp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}