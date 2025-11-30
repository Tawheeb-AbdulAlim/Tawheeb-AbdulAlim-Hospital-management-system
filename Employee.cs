using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_management_system
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNameEmpl.Text))
                {
                    MessageBox.Show("please enter employe name", "Error");
                    txtNameEmpl.Focus();
                    return;
                }
                int age = (int)numAgeEmpl.Value;

                if (string.IsNullOrWhiteSpace(txtEmailEmpl.Text) || !txtEmailEmpl.Text.Contains("@"))
                {
                    MessageBox.Show("please enert vilov email addres", "Error");
                    txtEmailEmpl.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPhoneEmpl.Text))
                {
                    MessageBox.Show("please enert Phone number", "Error");
                    txtPhoneEmpl.Focus();
                    return;
                }
                if (!decimal.TryParse(txtSalaryEmpl.Text, out decimal salary) || salary <= 0)
                {
                    MessageBox.Show(" please please enert vilov salary", "Error");
                    txtSalaryEmpl.Focus();
                    return;
                }
                AddEmployeeToGrid(txtNameEmpl.Text, age, txtEmailEmpl.Text, txtPhoneEmpl.Text, salary);
                ClearFields();
                MessageBox.Show("Employee Added successfully", "succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}", "Error");
            }
        }

        private void AddEmployeeToGrid(string name, int age, string email, string phone, decimal salary)
        {
            int newId = 1;
            if (dataGridView1.Rows.Count > 0)
            {
                newId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Id"].Value) + 1;
            }
            dataGridView1.Rows.Add(newId, name, age, email, phone, salary.ToString("C2"));
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

        private void Employee_Load(object sender, EventArgs e)
        {
            // إضافة بيانات تجريبية
            AddEmployeeToGrid("Ahmed Mohamed", 30, "ahmed@company.com", "0123456789", 5000);
            AddEmployeeToGrid("Fatima Ali", 25, "fatima@company.com", "0111222333", 4500);
        }

        private void backButtonEmp_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Employee_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // كود بسيط للحذف
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                MessageBox.Show("Employee deleted successfully!");
            }
        }

        private void btnEdite_Click(object sender, EventArgs e)
        {
            // كود بسيط للتعديل
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                txtNameEmpl.Text = row.Cells["Name"].Value.ToString();
                numAgeEmpl.Value = Convert.ToInt32(row.Cells["Age"].Value);
                txtEmailEmpl.Text = row.Cells["Email"].Value.ToString();
                txtPhoneEmpl.Text = row.Cells["Phone"].Value.ToString();
                txtSalaryEmpl.Text = row.Cells["Salary"].Value.ToString().Replace("$", "").Replace(",", "");
            }
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            // كود بسيط للبحث
            MessageBox.Show("Search button clicked - Add your search logic here");
        }
    }
}