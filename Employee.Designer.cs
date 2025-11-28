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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButtonEmp = new System.Windows.Forms.Button();
            this.lblTitleEmp = new System.Windows.Forms.Label();
            this.flowLayoutPanelEmp = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnEdite = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.flowLayoutPanelEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.backButtonEmp);
            this.panel1.Controls.Add(this.lblTitleEmp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 77);
            this.panel1.TabIndex = 0;
            // 
            // backButtonEmp
            // 
            this.backButtonEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.backButtonEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButtonEmp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButtonEmp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backButtonEmp.Location = new System.Drawing.Point(796, 19);
            this.backButtonEmp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.backButtonEmp.Name = "backButtonEmp";
            this.backButtonEmp.Size = new System.Drawing.Size(86, 34);
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
            this.lblTitleEmp.Location = new System.Drawing.Point(9, 13);
            this.lblTitleEmp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleEmp.Name = "lblTitleEmp";
            this.lblTitleEmp.Size = new System.Drawing.Size(321, 37);
            this.lblTitleEmp.TabIndex = 0;
            this.lblTitleEmp.Text = "Employee Management";
            // 
            // flowLayoutPanelEmp
            // 
            this.flowLayoutPanelEmp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanelEmp.Controls.Add(this.btnAddEmp);
            this.flowLayoutPanelEmp.Controls.Add(this.btnEdite);
            this.flowLayoutPanelEmp.Controls.Add(this.btnDelete);
            this.flowLayoutPanelEmp.Controls.Add(this.btnRefresh);
            this.flowLayoutPanelEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelEmp.Location = new System.Drawing.Point(0, 77);
            this.flowLayoutPanelEmp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanelEmp.Name = "flowLayoutPanelEmp";
            this.flowLayoutPanelEmp.Size = new System.Drawing.Size(884, 51);
            this.flowLayoutPanelEmp.TabIndex = 1;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddEmp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddEmp.Location = new System.Drawing.Point(2, 3);
            this.btnAddEmp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(158, 34);
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
            this.btnEdite.Location = new System.Drawing.Point(164, 3);
            this.btnEdite.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEdite.Name = "btnEdite";
            this.btnEdite.Size = new System.Drawing.Size(143, 34);
            this.btnEdite.TabIndex = 6;
            this.btnEdite.Text = "Edit Employee";
            this.btnEdite.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.Location = new System.Drawing.Point(311, 3);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 34);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Employee";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRefresh.Location = new System.Drawing.Point(478, 3);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 34);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.fullNameColumn,
            this.ageColumn,
            this.genderColumn,
            this.phoneColumn,
            this.addressColumn});
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView.Location = new System.Drawing.Point(2, 133);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 35;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(873, 421);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // fullNameColumn
            // 
            this.fullNameColumn.HeaderText = "Full Name";
            this.fullNameColumn.MinimumWidth = 8;
            this.fullNameColumn.Name = "fullNameColumn";
            this.fullNameColumn.ReadOnly = true;
            // 
            // ageColumn
            // 
            this.ageColumn.HeaderText = "Age";
            this.ageColumn.MinimumWidth = 8;
            this.ageColumn.Name = "ageColumn";
            this.ageColumn.ReadOnly = true;
            // 
            // genderColumn
            // 
            this.genderColumn.HeaderText = "Gendre";
            this.genderColumn.MinimumWidth = 8;
            this.genderColumn.Name = "genderColumn";
            this.genderColumn.ReadOnly = true;
            // 
            // phoneColumn
            // 
            this.phoneColumn.HeaderText = "Phone";
            this.phoneColumn.MinimumWidth = 8;
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.ReadOnly = true;
            // 
            // addressColumn
            // 
            this.addressColumn.HeaderText = "Address";
            this.addressColumn.MinimumWidth = 8;
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.ReadOnly = true;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(884, 556);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.flowLayoutPanelEmp);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanelEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEmp;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnEdite;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTitleEmp;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.Button backButtonEmp;
    }
}