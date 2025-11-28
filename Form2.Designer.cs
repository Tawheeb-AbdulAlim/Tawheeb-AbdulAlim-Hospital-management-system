namespace Hospital_management_system
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.LogIn = new System.Windows.Forms.GroupBox();
            this.password1 = new System.Windows.Forms.TextBox();
            this.username1 = new System.Windows.Forms.TextBox();
            this.LogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(30, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Tahoma", 11F);
            this.username.Location = new System.Drawing.Point(35, 61);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 23);
            this.username.TabIndex = 1;
            this.username.Text = "User name";
            this.username.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Tahoma", 11F);
            this.password.Location = new System.Drawing.Point(35, 142);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(88, 23);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.label2_Click);
            // 
            // LogIn
            // 
            this.LogIn.Controls.Add(this.password1);
            this.LogIn.Controls.Add(this.username1);
            this.LogIn.Controls.Add(this.password);
            this.LogIn.Controls.Add(this.username);
            this.LogIn.Controls.Add(this.button1);
            this.LogIn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.LogIn.Location = new System.Drawing.Point(212, 87);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(315, 314);
            this.LogIn.TabIndex = 3;
            this.LogIn.TabStop = false;
            this.LogIn.Text = "LogIn";
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(30, 168);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(251, 30);
            this.password1.TabIndex = 4;
            // 
            // username1
            // 
            this.username1.Location = new System.Drawing.Point(30, 87);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(251, 30);
            this.username1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogIn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.LogIn.ResumeLayout(false);
            this.LogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.GroupBox LogIn;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.TextBox username1;
    }
}