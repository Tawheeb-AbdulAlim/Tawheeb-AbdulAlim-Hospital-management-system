using System;
using System.Windows.Forms;

namespace Hospital_management_system
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButtonEmp = new System.Windows.Forms.Button();
            this.lblTitleEmp = new System.Windows.Forms.Label();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnEdite = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblSalaryEmp = new System.Windows.Forms.Label();
            this.lblPhoneEmp = new System.Windows.Forms.Label();
            this.lblEmailEmp = new System.Windows.Forms.Label();
            this.lblAgeEmpl = new System.Windows.Forms.Label();
            this.lblNameEmp = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numAgeEmpl = new System.Windows.Forms.NumericUpDown();
            this.txtNameEmpl = new System.Windows.Forms.TextBox();
            this.txtEmailEmpl = new System.Windows.Forms.TextBox();
            this.txtPhoneEmpl = new System.Windows.Forms.TextBox();
            this.txtSalaryEmpl = new System.Windows.Forms.TextBox();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.txtsearchEmp = new System.Windows.Forms.TextBox();
            this.cmbSearchTypEmp = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgeEmpl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.backButtonEmp);
            this.panel1.Controls.Add(this.lblTitleEmp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 91);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // backButtonEmp
            // 
            this.backButtonEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.backButtonEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButtonEmp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButtonEmp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backButtonEmp.Location = new System.Drawing.Point(1044, 37);
            this.backButtonEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backButtonEmp.Name = "backButtonEmp";
            this.backButtonEmp.Size = new System.Drawing.Size(111, 40);
            this.backButtonEmp.TabIndex = 2;
            this.backButtonEmp.Text = "Back";
            this.backButtonEmp.UseVisualStyleBackColor = false;
            this.backButtonEmp.Click += new System.EventHandler(this.backButtonEmp_Click);
            // 
            // lblTitleEmp
            // 
            this.lblTitleEmp.AutoSize = true;
            this.lblTitleEmp.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTitleEmp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleEmp.Location = new System.Drawing.Point(12, 15);
            this.lblTitleEmp.Name = "lblTitleEmp";
            this.lblTitleEmp.Size = new System.Drawing.Size(373, 45);
            this.lblTitleEmp.TabIndex = 0;
            this.lblTitleEmp.Text = "Employee Management";
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddEmp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddEmp.Location = new System.Drawing.Point(203, 551);
            this.btnAddEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(182, 40);
            this.btnAddEmp.TabIndex = 5;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = false;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnEdite
            // 
            this.btnEdite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnEdite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdite.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdite.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEdite.Location = new System.Drawing.Point(440, 551);
            this.btnEdite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdite.Name = "btnEdite";
            this.btnEdite.Size = new System.Drawing.Size(184, 40);
            this.btnEdite.TabIndex = 6;
            this.btnEdite.Text = "Edit Employee";
            this.btnEdite.UseVisualStyleBackColor = false;
            this.btnEdite.Click += new System.EventHandler(this.btnEdite_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.Location = new System.Drawing.Point(666, 551);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(185, 40);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Employee";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRefresh.Location = new System.Drawing.Point(893, 551);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 40);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblSalaryEmp
            // 
            this.lblSalaryEmp.AutoSize = true;
            this.lblSalaryEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSalaryEmp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryEmp.Location = new System.Drawing.Point(34, 422);
            this.lblSalaryEmp.Name = "lblSalaryEmp";
            this.lblSalaryEmp.Size = new System.Drawing.Size(71, 28);
            this.lblSalaryEmp.TabIndex = 11;
            this.lblSalaryEmp.Text = "Salary";
            // 
            // lblPhoneEmp
            // 
            this.lblPhoneEmp.AutoSize = true;
            this.lblPhoneEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPhoneEmp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneEmp.Location = new System.Drawing.Point(34, 357);
            this.lblPhoneEmp.Name = "lblPhoneEmp";
            this.lblPhoneEmp.Size = new System.Drawing.Size(76, 28);
            this.lblPhoneEmp.TabIndex = 10;
            this.lblPhoneEmp.Text = "Phone:";
            // 
            // lblEmailEmp
            // 
            this.lblEmailEmp.AutoSize = true;
            this.lblEmailEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmailEmp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailEmp.Location = new System.Drawing.Point(34, 285);
            this.lblEmailEmp.Name = "lblEmailEmp";
            this.lblEmailEmp.Size = new System.Drawing.Size(64, 28);
            this.lblEmailEmp.TabIndex = 9;
            this.lblEmailEmp.Text = "Email";
            // 
            // lblAgeEmpl
            // 
            this.lblAgeEmpl.AutoSize = true;
            this.lblAgeEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAgeEmpl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeEmpl.Location = new System.Drawing.Point(34, 219);
            this.lblAgeEmpl.Name = "lblAgeEmpl";
            this.lblAgeEmpl.Size = new System.Drawing.Size(54, 28);
            this.lblAgeEmpl.TabIndex = 8;
            this.lblAgeEmpl.Text = "Age:";
            // 
            // lblNameEmp
            // 
            this.lblNameEmp.AutoSize = true;
            this.lblNameEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNameEmp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEmp.Location = new System.Drawing.Point(34, 176);
            this.lblNameEmp.Name = "lblNameEmp";
            this.lblNameEmp.Size = new System.Drawing.Size(73, 28);
            this.lblNameEmp.TabIndex = 7;
            this.lblNameEmp.Text = "Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameEmp,
            this.AgeEmp,
            this.EmailEmp,
            this.PhoneEmp,
            this.SalaryEmp});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(465, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(503, 226);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            // 
            // NameEmp
            // 
            this.NameEmp.HeaderText = "name";
            this.NameEmp.MinimumWidth = 8;
            this.NameEmp.Name = "NameEmp";
            // 
            // AgeEmp
            // 
            this.AgeEmp.HeaderText = "Age";
            this.AgeEmp.MinimumWidth = 8;
            this.AgeEmp.Name = "AgeEmp";
            // 
            // EmailEmp
            // 
            this.EmailEmp.HeaderText = "Email";
            this.EmailEmp.MinimumWidth = 8;
            this.EmailEmp.Name = "EmailEmp";
            // 
            // PhoneEmp
            // 
            this.PhoneEmp.HeaderText = "Phone";
            this.PhoneEmp.MinimumWidth = 8;
            this.PhoneEmp.Name = "PhoneEmp";
            // 
            // SalaryEmp
            // 
            this.SalaryEmp.HeaderText = "Salary";
            this.SalaryEmp.MinimumWidth = 8;
            this.SalaryEmp.Name = "SalaryEmp";
            // 
            // numAgeEmpl
            // 
            this.numAgeEmpl.Location = new System.Drawing.Point(113, 224);
            this.numAgeEmpl.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numAgeEmpl.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numAgeEmpl.Name = "numAgeEmpl";
            this.numAgeEmpl.Size = new System.Drawing.Size(272, 27);
            this.numAgeEmpl.TabIndex = 14;
            this.numAgeEmpl.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // txtNameEmpl
            // 
            this.txtNameEmpl.Location = new System.Drawing.Point(113, 180);
            this.txtNameEmpl.Name = "txtNameEmpl";
            this.txtNameEmpl.Size = new System.Drawing.Size(272, 27);
            this.txtNameEmpl.TabIndex = 13;
            // 
            // txtEmailEmpl
            // 
            this.txtEmailEmpl.Location = new System.Drawing.Point(113, 286);
            this.txtEmailEmpl.Name = "txtEmailEmpl";
            this.txtEmailEmpl.Size = new System.Drawing.Size(272, 27);
            this.txtEmailEmpl.TabIndex = 15;
            // 
            // txtPhoneEmpl
            // 
            this.txtPhoneEmpl.Location = new System.Drawing.Point(113, 358);
            this.txtPhoneEmpl.Name = "txtPhoneEmpl";
            this.txtPhoneEmpl.Size = new System.Drawing.Size(272, 27);
            this.txtPhoneEmpl.TabIndex = 16;
            // 
            // txtSalaryEmpl
            // 
            this.txtSalaryEmpl.Location = new System.Drawing.Point(113, 422);
            this.txtSalaryEmpl.Name = "txtSalaryEmpl";
            this.txtSalaryEmpl.Size = new System.Drawing.Size(272, 27);
            this.txtSalaryEmpl.TabIndex = 17;
            this.txtSalaryEmpl.TextChanged += new System.EventHandler(this.txtSalaryEmpl_TextChanged);
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.Location = new System.Drawing.Point(940, 168);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(75, 36);
            this.btnSearchEmp.TabIndex = 50;
            this.btnSearchEmp.Text = "Search";
            this.btnSearchEmp.UseVisualStyleBackColor = true;
            // 
            // txtsearchEmp
            // 
            this.txtsearchEmp.Location = new System.Drawing.Point(621, 174);
            this.txtsearchEmp.Name = "txtsearchEmp";
            this.txtsearchEmp.Size = new System.Drawing.Size(161, 27);
            this.txtsearchEmp.TabIndex = 49;
            // 
            // cmbSearchTypEmp
            // 
            this.cmbSearchTypEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchTypEmp.FormattingEnabled = true;
            this.cmbSearchTypEmp.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Phone"});
            this.cmbSearchTypEmp.Location = new System.Drawing.Point(535, 174);
            this.cmbSearchTypEmp.Name = "cmbSearchTypEmp";
            this.cmbSearchTypEmp.Size = new System.Drawing.Size(80, 27);
            this.cmbSearchTypEmp.TabIndex = 48;
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(446, 174);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(96, 27);
            this.lblSearch.TabIndex = 47;
            this.lblSearch.Text = "Search By";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1201, 660);
            this.Controls.Add(this.btnSearchEmp);
            this.Controls.Add(this.txtsearchEmp);
            this.Controls.Add(this.cmbSearchTypEmp);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.txtSalaryEmpl);
            this.Controls.Add(this.btnEdite);
            this.Controls.Add(this.txtPhoneEmpl);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtEmailEmpl);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.numAgeEmpl);
            this.Controls.Add(this.txtNameEmpl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSalaryEmp);
            this.Controls.Add(this.lblPhoneEmp);
            this.Controls.Add(this.lblEmailEmp);
            this.Controls.Add(this.lblAgeEmpl);
            this.Controls.Add(this.lblNameEmp);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgeEmpl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtSalaryEmpl_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnEdite;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTitleEmp;
        private System.Windows.Forms.Button backButtonEmp;
        private System.Windows.Forms.Label lblSalaryEmp;
        private System.Windows.Forms.Label lblPhoneEmp;
        private System.Windows.Forms.Label lblEmailEmp;
        private System.Windows.Forms.Label lblAgeEmpl;
        private System.Windows.Forms.Label lblNameEmp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryEmp;
        private System.Windows.Forms.NumericUpDown numAgeEmpl;
        private System.Windows.Forms.TextBox txtNameEmpl;
        private System.Windows.Forms.TextBox txtEmailEmpl;
        private System.Windows.Forms.TextBox txtPhoneEmpl;
        private System.Windows.Forms.TextBox txtSalaryEmpl;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.TextBox txtsearchEmp;
        private System.Windows.Forms.ComboBox cmbSearchTypEmp;
        private System.Windows.Forms.TextBox lblSearch;
    }
}