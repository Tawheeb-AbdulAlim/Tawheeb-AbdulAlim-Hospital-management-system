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
            this.BtnOpenPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOpenVisits
            // 
            this.BtnOpenVisits.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpenVisits.Location = new System.Drawing.Point(147, 273);
            this.BtnOpenVisits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnOpenVisits.Name = "BtnOpenVisits";
            this.BtnOpenVisits.Size = new System.Drawing.Size(459, 80);
            this.BtnOpenVisits.TabIndex = 0;
            this.BtnOpenVisits.Text = "VisitsManagement";
            this.BtnOpenVisits.UseVisualStyleBackColor = true;
            this.BtnOpenVisits.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnOpenPatient
            // 
            this.BtnOpenPatient.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpenPatient.Location = new System.Drawing.Point(147, 143);
            this.BtnOpenPatient.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOpenPatient.Name = "BtnOpenPatient";
            this.BtnOpenPatient.Size = new System.Drawing.Size(459, 80);
            this.BtnOpenPatient.TabIndex = 1;
            this.BtnOpenPatient.Text = "Patient Management";
            this.BtnOpenPatient.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(752, 534);
            this.Controls.Add(this.BtnOpenPatient);
            this.Controls.Add(this.BtnOpenVisits);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOpenVisits;
        private System.Windows.Forms.Button BtnOpenPatient;
    }
}

