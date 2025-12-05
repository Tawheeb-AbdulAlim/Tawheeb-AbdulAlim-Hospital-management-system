using Hospital_management_system.Models;
using Hospital_management_system.Services;
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
        Role CurentUserRole;
        public Form1(Role role)
        {
            InitializeComponent();
            CurentUserRole = role;
            SetPrivilaged();
            

        }
        private void SetPrivilaged()
        {
            if (CurentUserRole == Role.RESEPTIONIST)
            {
                BtnOpenVisits.Enabled = false;
                usermanagementbutton.Enabled = false;
                // BtnOpenVisits.BackColor = Color.Gray;
                //BtnOpenVisits.ForeColor = Color.White;
            }

            else if (CurentUserRole == Role.DOCTOR)
            {
                
                usermanagementbutton.Enabled = false;
                //btnEmployeeMangement.BackColor = Color.Gray;
                //btnEmployeeMangement.ForeColor = Color.White;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisitForm vs = new VisitForm(CurentUserRole);
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
            lblSearchBy p=new lblSearchBy(CurentUserRole);
            p.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userbon_Click(object sender, EventArgs e)
        {
            
            if (CurentUserRole != Role.ADMIN)
            {
                MessageBox.Show("Access Denied! You do not have permission to access User Management.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            userform uf = new userform(CurentUserRole);
            uf.Show();
            this.Hide();
        }
    }
}