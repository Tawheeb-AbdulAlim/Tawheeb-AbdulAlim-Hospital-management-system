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
    public partial class VisitForm : Form
    {
        public VisitForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void VisitForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("1", "Akram ", "GFHNJ",  "555-0101", "123 Main St");
            dataGridView1.Rows.Add("2", "tawheeb", "KKLF",  "555-0102", "456 Oak Ave");
            dataGridView1.Rows.Add("3", " sadeq", "FLM",  "555-0103", "789 Oak Street");
            dataGridView1.Rows.Add("4", " hamzah", "FKDL", "555-0103", "669 Oak Street");


        }

        private void addButton_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void textSearch_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
