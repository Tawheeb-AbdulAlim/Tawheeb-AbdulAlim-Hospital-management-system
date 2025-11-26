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
            AddEmployee f = new AddEmployee();
            f.Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            dataGridView.Rows.Add("1", "Akram ", "35", "Male", "555-0101", "123 Main St");
            dataGridView.Rows.Add("2", "tawheeb", "28", "male", "555-0102", "456 Oak Ave");
            dataGridView.Rows.Add("3", " sadeq", "45", "Male", "555-0103", "789 Oak Street");
            dataGridView.Rows.Add("4", " hamzah", "25", "Male", "555-0103", "669 Oak Street");
        }
    }
    
}
