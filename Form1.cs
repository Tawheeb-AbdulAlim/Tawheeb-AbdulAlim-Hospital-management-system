using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_management_system
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisitForm vs = new VisitForm();
            vs.Show();
            this.Hide();

        }

        private void btnEmployeeMangement_Click(object sender, EventArgs e)
        {
            EmployeeForm f = new EmployeeForm();
            f.Show();
            this.Hide();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblSearchBy p=new lblSearchBy();
            p.Show();
            this.Hide();
        }
    }
}