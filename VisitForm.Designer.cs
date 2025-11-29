namespace Hospital_management_system
{
    partial class VisitForm
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
            this.topPan1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.titleLabe1 = new System.Windows.Forms.Label();
            this.buttonPane1 = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VisiteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuurentMedication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textPatient = new System.Windows.Forms.TextBox();
            this.textLabal1 = new System.Windows.Forms.Label();
            this.textLabal2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textDoctor = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textVisitType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.topPan1.SuspendLayout();
            this.buttonPane1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPan1
            // 
            this.topPan1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.topPan1.Controls.Add(this.backButton);
            this.topPan1.Controls.Add(this.titleLabe1);
            this.topPan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPan1.Location = new System.Drawing.Point(0, 0);
            this.topPan1.Name = "topPan1";
            this.topPan1.Size = new System.Drawing.Size(1230, 80);
            this.topPan1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Navy;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(950, 29);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 40);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // titleLabe1
            // 
            this.titleLabe1.AutoSize = true;
            this.titleLabe1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabe1.ForeColor = System.Drawing.Color.White;
            this.titleLabe1.Location = new System.Drawing.Point(20, 20);
            this.titleLabe1.Name = "titleLabe1";
            this.titleLabe1.Size = new System.Drawing.Size(319, 45);
            this.titleLabe1.TabIndex = 0;
            this.titleLabe1.Text = "Visits Management";
            // 
            // buttonPane1
            // 
            this.buttonPane1.BackColor = System.Drawing.Color.Transparent;
            this.buttonPane1.Controls.Add(this.updateButton);
            this.buttonPane1.Controls.Add(this.deleteButton);
            this.buttonPane1.Controls.Add(this.editButton);
            this.buttonPane1.Controls.Add(this.addButton);
            this.buttonPane1.Location = new System.Drawing.Point(43, 534);
            this.buttonPane1.Name = "buttonPane1";
            this.buttonPane1.Size = new System.Drawing.Size(611, 52);
            this.buttonPane1.TabIndex = 1;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(471, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(131, 40);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Apdate Visit";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.YellowGreen;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(315, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 40);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Visit";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Tomato;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(159, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(150, 40);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit Visit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Purple;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 40);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add Visit";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.Color.MediumTurquoise;
            this.textSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.ForeColor = System.Drawing.Color.White;
            this.textSearch.Location = new System.Drawing.Point(480, 123);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(131, 40);
            this.textSearch.TabIndex = 5;
            this.textSearch.Text = "Search";
            this.textSearch.UseVisualStyleBackColor = false;
            this.textSearch.Click += new System.EventHandler(this.textSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VisiteID,
            this.Patient,
            this.Doctor,
            this.Data,
            this.Notes,
            this.VisitType,
            this.CuurentMedication});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(425, 180);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 268);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // VisiteID
            // 
            this.VisiteID.HeaderText = "VisiteID";
            this.VisiteID.MinimumWidth = 6;
            this.VisiteID.Name = "VisiteID";
            this.VisiteID.ReadOnly = true;
            // 
            // Patient
            // 
            this.Patient.HeaderText = "PatientID";
            this.Patient.MinimumWidth = 6;
            this.Patient.Name = "Patient";
            this.Patient.ReadOnly = true;
            // 
            // Doctor
            // 
            this.Doctor.HeaderText = "DoctorID";
            this.Doctor.MinimumWidth = 6;
            this.Doctor.Name = "Doctor";
            this.Doctor.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Date";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.MinimumWidth = 6;
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            // 
            // VisitType
            // 
            this.VisitType.HeaderText = "VisitType";
            this.VisitType.MinimumWidth = 6;
            this.VisitType.Name = "VisitType";
            this.VisitType.ReadOnly = true;
            // 
            // CuurentMedication
            // 
            this.CuurentMedication.HeaderText = "CuurentMedication";
            this.CuurentMedication.MinimumWidth = 6;
            this.CuurentMedication.Name = "CuurentMedication";
            this.CuurentMedication.ReadOnly = true;
            // 
            // textPatient
            // 
            this.textPatient.Location = new System.Drawing.Point(164, 134);
            this.textPatient.Name = "textPatient";
            this.textPatient.Size = new System.Drawing.Size(247, 24);
            this.textPatient.TabIndex = 11;
            // 
            // textLabal1
            // 
            this.textLabal1.AutoSize = true;
            this.textLabal1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabal1.Location = new System.Drawing.Point(14, 123);
            this.textLabal1.Name = "textLabal1";
            this.textLabal1.Size = new System.Drawing.Size(98, 21);
            this.textLabal1.TabIndex = 12;
            this.textLabal1.Text = "PatientID:";
            // 
            // textLabal2
            // 
            this.textLabal2.AutoSize = true;
            this.textLabal2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabal2.Location = new System.Drawing.Point(14, 160);
            this.textLabal2.Name = "textLabal2";
            this.textLabal2.Size = new System.Drawing.Size(95, 21);
            this.textLabal2.TabIndex = 13;
            this.textLabal2.Text = "DoctorID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Date:";
            // 
            // textDoctor
            // 
            this.textDoctor.Location = new System.Drawing.Point(163, 172);
            this.textDoctor.Name = "textDoctor";
            this.textDoctor.Size = new System.Drawing.Size(248, 24);
            this.textDoctor.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 217);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 24);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Notes:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(153, 348);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(266, 89);
            this.notesTextBox.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(617, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(473, 24);
            this.textBox1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "VisitType:";
            // 
            // textVisitType
            // 
            this.textVisitType.Location = new System.Drawing.Point(162, 262);
            this.textVisitType.Name = "textVisitType";
            this.textVisitType.Size = new System.Drawing.Size(249, 24);
            this.textVisitType.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "CurrentMedication";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 305);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 24);
            this.textBox2.TabIndex = 23;
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 595);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textVisitType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textDoctor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLabal2);
            this.Controls.Add(this.textLabal1);
            this.Controls.Add(this.textPatient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonPane1);
            this.Controls.Add(this.topPan1);
            this.Name = "VisitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisitsManagement";
            this.Load += new System.EventHandler(this.VisitForm_Load);
            this.topPan1.ResumeLayout(false);
            this.topPan1.PerformLayout();
            this.buttonPane1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPan1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label titleLabe1;
        private System.Windows.Forms.Panel buttonPane1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textPatient;
        private System.Windows.Forms.Label textLabal1;
        private System.Windows.Forms.Label textLabal2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDoctor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Button textSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisiteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuurentMedication;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textVisitType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}