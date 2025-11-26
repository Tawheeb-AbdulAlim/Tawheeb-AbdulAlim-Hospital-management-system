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
            this.BtnOpenVisits = new System.Windows.Forms.Button();
            this.btnEmployeeMangement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOpenVisits
            // 
            this.BtnOpenVisits.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpenVisits.Location = new System.Drawing.Point(165, 110);
            this.BtnOpenVisits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnOpenVisits.Name = "BtnOpenVisits";
            this.BtnOpenVisits.Size = new System.Drawing.Size(400, 80);
            this.BtnOpenVisits.TabIndex = 0;
            this.BtnOpenVisits.Text = "VisitsManagement";
            this.BtnOpenVisits.UseVisualStyleBackColor = true;
            this.BtnOpenVisits.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmployeeMangement
            // 
            this.btnEmployeeMangement.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeMangement.Location = new System.Drawing.Point(176, 227);
            this.btnEmployeeMangement.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployeeMangement.Name = "btnEmployeeMangement";
            this.btnEmployeeMangement.Size = new System.Drawing.Size(400, 80);
            this.btnEmployeeMangement.TabIndex = 1;
            this.btnEmployeeMangement.Text = "EmployeeManagement";
            this.btnEmployeeMangement.UseVisualStyleBackColor = true;
            this.btnEmployeeMangement.Click += new System.EventHandler(this.btnEmployeeMangement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(752, 534);
            this.Controls.Add(this.btnEmployeeMangement);
            this.Controls.Add(this.BtnOpenVisits);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOpenVisits;
        private System.Windows.Forms.Button btnEmployeeMangement;
    }
}

