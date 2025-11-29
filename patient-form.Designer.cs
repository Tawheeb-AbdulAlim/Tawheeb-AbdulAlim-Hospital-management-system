namespace Hospital_management_system
{
    partial class lblSearchBy
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.fullName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textLabal2 = new System.Windows.Forms.Label();
            this.textLabal1 = new System.Windows.Forms.Label();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.cmbBloodType = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.TextBox();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(136)))), ((int)(((byte)(219)))));
            this.topPanel.Controls.Add(this.backButton);
            this.topPanel.Controls.Add(this.titleLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.topPanel.Size = new System.Drawing.Size(1309, 79);
            this.topPanel.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backButton.Location = new System.Drawing.Point(1153, 29);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(111, 40);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.Honeydew;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(363, 70);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "patients management";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addButton.Location = new System.Drawing.Point(266, 574);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 40);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Patient";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.editButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.editButton.Location = new System.Drawing.Point(457, 574);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(150, 40);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit Patient";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.deleteButton.Location = new System.Drawing.Point(646, 574);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(160, 40);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Patient";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.refreshButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.refreshButton.Location = new System.Drawing.Point(845, 574);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(150, 40);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(217, 352);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(269, 27);
            this.cmbGender.TabIndex = 35;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(217, 291);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(269, 27);
            this.numAge.TabIndex = 34;
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(217, 229);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(269, 27);
            this.fullName.TabIndex = 33;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(59, 411);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(91, 25);
            this.lblPhone.TabIndex = 29;
            this.lblPhone.Text = "Phone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Gender :";
            // 
            // textLabal2
            // 
            this.textLabal2.AutoSize = true;
            this.textLabal2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabal2.Location = new System.Drawing.Point(59, 293);
            this.textLabal2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textLabal2.Name = "textLabal2";
            this.textLabal2.Size = new System.Drawing.Size(65, 25);
            this.textLabal2.TabIndex = 27;
            this.textLabal2.Text = "Age :";
            // 
            // textLabal1
            // 
            this.textLabal1.AutoSize = true;
            this.textLabal1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabal1.Location = new System.Drawing.Point(59, 231);
            this.textLabal1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textLabal1.Name = "textLabal1";
            this.textLabal1.Size = new System.Drawing.Size(116, 25);
            this.textLabal1.TabIndex = 26;
            this.textLabal1.Text = "Full Name";
            // 
            // lblPatientId
            // 
            this.lblPatientId.AutoSize = true;
            this.lblPatientId.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientId.Location = new System.Drawing.Point(59, 165);
            this.lblPatientId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientId.Name = "lblPatientId";
            this.lblPatientId.Size = new System.Drawing.Size(120, 25);
            this.lblPatientId.TabIndex = 37;
            this.lblPatientId.Text = "Patient ID";
            // 
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(217, 165);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(269, 27);
            this.txtPatientId.TabIndex = 38;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(217, 412);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(269, 27);
            this.txtPhone.TabIndex = 40;
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodType.Location = new System.Drawing.Point(59, 471);
            this.lblBloodType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(141, 25);
            this.lblBloodType.TabIndex = 41;
            this.lblBloodType.Text = "Blood Type :";
            // 
            // cmbBloodType
            // 
            this.cmbBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloodType.FormattingEnabled = true;
            this.cmbBloodType.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O"});
            this.cmbBloodType.Location = new System.Drawing.Point(217, 472);
            this.cmbBloodType.Name = "cmbBloodType";
            this.cmbBloodType.Size = new System.Drawing.Size(269, 27);
            this.cmbBloodType.TabIndex = 42;
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(557, 171);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(96, 27);
            this.lblSearch.TabIndex = 39;
            this.lblSearch.Text = "Search By";
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Phone"});
            this.cmbSearchType.Location = new System.Drawing.Point(646, 171);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(80, 27);
            this.cmbSearchType.TabIndex = 44;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(732, 171);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(161, 27);
            this.txtSearchValue.TabIndex = 45;
            this.txtSearchValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchValue_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1051, 165);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 36);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.BloodTypeColumn});
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
            this.dataGridView.Location = new System.Drawing.Point(557, 227);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 35;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(569, 269);
            this.dataGridView.TabIndex = 47;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick_1);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
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
            // BloodTypeColumn
            // 
            this.BloodTypeColumn.HeaderText = "Blood Type";
            this.BloodTypeColumn.MinimumWidth = 8;
            this.BloodTypeColumn.Name = "BloodTypeColumn";
            this.BloodTypeColumn.ReadOnly = true;
            // 
            // lblSearchBy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1309, 717);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchValue);
            this.Controls.Add(this.cmbSearchType);
            this.Controls.Add(this.cmbBloodType);
            this.Controls.Add(this.lblBloodType);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtPatientId);
            this.Controls.Add(this.lblPatientId);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textLabal2);
            this.Controls.Add(this.textLabal1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Name = "lblSearchBy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.patient_form_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textLabal2;
        private System.Windows.Forms.Label textLabal1;
        private System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.ComboBox cmbBloodType;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.TextBox lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodTypeColumn;
    }
}