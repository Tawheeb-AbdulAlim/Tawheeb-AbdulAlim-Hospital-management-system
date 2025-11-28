using Hospital_management_system.Models;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (hospitaldbcontext db = new hospitaldbcontext())
            {

                db.users.Add(new User { Username = "admin", PasswordHash = "admin" });
                db.users.Add(new User { Username = "tawheeb", PasswordHash = "tawheeb" });
                db.users.Add(new User { Username = "sadeg", PasswordHash = "sadeg" });
                db.users.Add(new User { Username = "akram", PasswordHash = "akram" });
                db.users.Add(new User { Username = "hamsa", PasswordHash = "hamsa" });
                db.SaveChanges();

            }
        }

        private void button1_Click(object sender, EventArgs e)

        {
            string usermane=username1.Text;
            string password=password1.Text;

            hospitaldbcontext db = new hospitaldbcontext();
            User u1= db.users.Where(u => u.Username == usermane && u.PasswordHash == password).FirstOrDefault();
            if (u1!=null)
            {
                
               Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid enterd");
            }
        }
    }
}
