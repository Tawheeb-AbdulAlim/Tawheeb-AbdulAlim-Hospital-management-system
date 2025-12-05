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
using System.IO;

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


               /* db.users.Add(new User { Username = "admin", PasswordHash = "admin" });
                db.users.Add(new User { Username = "tawheeb", PasswordHash = "tawheeb" });
                db.users.Add(new User { Username = "sadeg", PasswordHash = "sadeg" });
                db.users.Add(new User { Username = "akram", PasswordHash = "akram" });
                db.users.Add(new User { Username = "hamsa", PasswordHash = "hamsa" });
                db.SaveChanges();*/


            //////////////using (hospitaldbcontext db = new hospitaldbcontext())
            //////////////{
            //////////////    User user = new User();

            //////////////    string Username = "admin  ";
            //////////////   string PasswordHash = "admin  ";
            //////////////    user= db.users.Where(u => u.Username == Username).FirstOrDefault();
            /////////////    .users.Remove);
            //////////////    db.SaveChanges();
            //////////////}
        }

        private void button1_Click(object sender, EventArgs e)

        {

            string usermane=username1.Text;
            string password=password1.Text;
            Role role = new Role();
            
           
           
            // تحقق من أن الحقول ليست فارغة

            if (string.IsNullOrEmpty(usermane) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("⚠️ الرجاء ملء كل الحقول!", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            


            
            hospitaldbcontext db = new hospitaldbcontext();
             
            User u1= db.users.Where(u => u.Username == usermane && u.PasswordHash == password).FirstOrDefault();
            if (u1!=null)
            {
                if (u1.Role == null) 
                    MessageBox.Show("error: user role is null ");
                if (Enum.TryParse<Role>(u1.Role, out role))
                {
                    
                    Form1 form = new Form1(role);
                    form.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("error of concert text to enum");
                
            }
            else
            {
                MessageBox.Show("خطاء في اسم المستخدم او كلمة المرور");
            }
        }

                            

        private async void password1_TextChanged(object sender, EventArgs e)
        {

            // نخلي الحروف تظهر مؤقتاً
            password1.UseSystemPasswordChar = false;

            // ننتظر 700 مللي ثانية (0.7 ثانية)
            await Task.Delay(500);

            // نخفي النص بالنجوم
            password1.UseSystemPasswordChar = true;

            // نحافظ على النص والمؤشر في النهاية
            password1.SelectionStart = password1.Text.Length;

        }
    }
}
