namespace Hospital_management_system
{
    partial class Form1
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
            }             base.Dispose(disposing);
        }


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOpenVisits = new System.Windows.Forms.Button();
            this.btnEmployeeMangement = new System.Windows.Forms.Button();
            this.BtnOpenPatient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOpenVisits
            // 
            this.BtnOpenVisits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnOpenVisits.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpenVisits.Location = new System.Drawing.Point(40, 137);
            this.BtnOpenVisits.Name = "BtnOpenVisits";
            this.BtnOpenVisits.Size = new System.Drawing.Size(417, 67);
            this.BtnOpenVisits.TabIndex = 0;
            this.BtnOpenVisits.Text = "Visits Management";
            this.BtnOpenVisits.UseVisualStyleBackColor = false;
            this.BtnOpenVisits.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmployeeMangement
            // 
            this.btnEmployeeMangement.BackColor = System.Drawing.Color.Lime;
            this.btnEmployeeMangement.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeMangement.Location = new System.Drawing.Point(40, 237);
            this.btnEmployeeMangement.Name = "btnEmployeeMangement";
            this.btnEmployeeMangement.Size = new System.Drawing.Size(417, 67);
            this.btnEmployeeMangement.TabIndex = 1;
            this.btnEmployeeMangement.Text = "Employees Management";
            this.btnEmployeeMangement.UseVisualStyleBackColor = false;
            this.btnEmployeeMangement.Click += new System.EventHandler(this.btnEmployeeMangement_Click);
            // 
            // BtnOpenPatient
            // 
            this.BtnOpenPatient.BackColor = System.Drawing.Color.Yellow;
            this.BtnOpenPatient.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpenPatient.Location = new System.Drawing.Point(40, 34);
            this.BtnOpenPatient.Name = "BtnOpenPatient";
            this.BtnOpenPatient.Size = new System.Drawing.Size(417, 67);
            this.BtnOpenPatient.TabIndex = 2;
            this.BtnOpenPatient.Text = "Patients Management";
            this.BtnOpenPatient.UseVisualStyleBackColor = false;
            this.BtnOpenPatient.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.BtnOpenPatient);
            this.groupBox1.Controls.Add(this.btnEmployeeMangement);
            this.groupBox1.Controls.Add(this.BtnOpenVisits);
            this.groupBox1.Location = new System.Drawing.Point(42, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 324);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button BtnOpenVisits;
        private System.Windows.Forms.Button btnEmployeeMangement;
        private System.Windows.Forms.Button BtnOpenPatient;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

