using Hospital_management_system.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_management_system
{
    public partial class userform : Form
    {
        private hospitaldbcontext context;
        private User selectedUser;

        public userform()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            context = new hospitaldbcontext();
            LoadUsers();
            ClearFields();
        }

        private void LoadUsers()
        {
            try
            {
                var users = context.users.ToList();
                dataGridView1.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtUserId.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtRole.Clear();
            txtEmployeeId.Clear();
            selectedUser = null;
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter username", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter password", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRole.Text))
            {
                MessageBox.Show("Please enter role", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRole.Focus();
                return false;
            }

            if (!int.TryParse(txtEmployeeId.Text, out int employeeId))
            {
                MessageBox.Show("Please enter valid employee ID", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeId.Focus();
                return false;
            }

            return true;
        }


        //private void dataGridView_SelectionChanged(object sender, EventArgs e)
        //{
        //    MessageBox.Show("true anaaa");
        //    try
        //    {
        //        if (dataGridView1.SelectedRows.Count > 0)
        //        {
        //            DataGridViewRow row = dataGridView1.SelectedRows[0];

        //            if (row.Cells["ID"].Value != null &&
        //                !string.IsNullOrEmpty(row.Cells["ID"].Value.ToString()))
        //            {
        //                int userid = Convert.ToInt32(row.Cells["UserID"].Value);
        //                selectedUser = context.users.Where(u => u.UserId == userid).FirstOrDefault();

        //                if (selectedUser != null)
        //                {
        //                    //DisplayData(selectedUser);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        // تجاهل الأخطاء البسيطة في الاختيار
        //    }
        //}


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("true tawheeb");
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    MessageBox.Show("true tawheeb1");
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    MessageBox.Show("Row index: " + e.RowIndex.ToString());
                    MessageBox.Show("id"+row.Cells["UserId"].Value);
                    if (row.Cells["UserId"].Value != null && int.TryParse(row.Cells["UserId"].Value.ToString(), out int userid))
                    {
                        MessageBox.Show("trueeeeeeeeeeeeeee tawheeb2");
                        selectedUser = context.users.Where(u => u.UserId == userid).FirstOrDefault();
                        if (selectedUser != null)
                        {
                            MessageBox.Show("true tawheeb3");

                            txtUserId.Text = selectedUser.UserId.ToString();
                            txtUsername.Text = selectedUser.Username;
                            txtPassword.Text = selectedUser.PasswordHash;
                            txtRole.Text = selectedUser.Role;
                            txtEmployeeId.Text = selectedUser.EmployeeId.ToString();
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




        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
        //        selectedUser = row.DataBoundItem as User;

        //        if (selectedUser != null)
        //        {
        //            txtUserId.Text = selectedUser.UserId.ToString();
        //            txtUsername.Text = selectedUser.Username;
        //            txtPassword.Text = selectedUser.PasswordHash;
        //            txtRole.Text = selectedUser.Role;
        //            txtEmployeeId.Text = selectedUser.EmployeeId.ToString();
        //        }
        //    }
        //}

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    var newUser = new User
                    {
                        Username = txtUsername.Text,
                        PasswordHash = txtPassword.Text,
                        Role = txtRole.Text,
                        EmployeeId = int.Parse(txtEmployeeId.Text)
                    };

                    context.users.Add(newUser);
                    context.SaveChanges();


                    MessageBox.Show("User added successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadUsers();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding user: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user to edit", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateFields())
            {
                try
                {
                    selectedUser.Username = txtUsername.Text;
                    selectedUser.PasswordHash = txtPassword.Text;
                    selectedUser.Role = txtRole.Text;
                    selectedUser.EmployeeId = int.Parse(txtEmployeeId.Text);

                    context.SaveChanges();

                    MessageBox.Show("User updated successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadUsers();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating user: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user to delete", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this user?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    context.users.Remove(selectedUser);
                    context.SaveChanges();

                    MessageBox.Show("User deleted successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadUsers();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting user: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadUsers();
            ClearFields();
            txtSearchValue.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchValue.Text))
            {
                LoadUsers();
                return;
            }

            try
            {
                IQueryable<User> query = context.users;

                if (cmbSearchType.SelectedIndex == 0) // Search by Password
                {
                    query = query.Where(u => u.PasswordHash.Contains(txtSearchValue.Text));
                }
                else // Search by EmployeeID



                {
                    if (int.TryParse(txtSearchValue.Text, out int employeeId))
                    {
                        query = query.Where(u => u.EmployeeId == employeeId);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number for EmployeeID",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                var results = query.ToList();
                dataGridView1.DataSource = results;

                if (results.Count == 0)
                {
                    MessageBox.Show("No results found", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        
    }
    }
}



                
