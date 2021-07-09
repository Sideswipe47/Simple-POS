
namespace Project21040062
{
    partial class UserControlRegisterAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.panelForButton = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelErrorEmail = new System.Windows.Forms.Label();
            this.labelErrorPassword = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.panelForButton.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Padding = new System.Windows.Forms.Padding(25, 15, 0, 0);
            this.labelHeader.Size = new System.Drawing.Size(150, 80);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Start";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelDescription.Location = new System.Drawing.Point(0, 80);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Padding = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.labelDescription.Size = new System.Drawing.Size(327, 30);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "To manage the application, please register your admin";
            // 
            // panelForButton
            // 
            this.panelForButton.Controls.Add(this.textBoxEmail);
            this.panelForButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForButton.Location = new System.Drawing.Point(0, 140);
            this.panelForButton.Name = "panelForButton";
            this.panelForButton.Size = new System.Drawing.Size(968, 47);
            this.panelForButton.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(37, 12);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PlaceholderText = "Enter email...";
            this.textBoxEmail.Size = new System.Drawing.Size(222, 23);
            this.textBoxEmail.TabIndex = 3;
            // 
            // labelErrorEmail
            // 
            this.labelErrorEmail.AutoSize = true;
            this.labelErrorEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.labelErrorEmail.Location = new System.Drawing.Point(0, 187);
            this.labelErrorEmail.Name = "labelErrorEmail";
            this.labelErrorEmail.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.labelErrorEmail.Size = new System.Drawing.Size(67, 15);
            this.labelErrorEmail.TabIndex = 6;
            this.labelErrorEmail.Text = "Error";
            this.labelErrorEmail.Visible = false;
            // 
            // labelErrorPassword
            // 
            this.labelErrorPassword.AutoSize = true;
            this.labelErrorPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPassword.Location = new System.Drawing.Point(0, 279);
            this.labelErrorPassword.Name = "labelErrorPassword";
            this.labelErrorPassword.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.labelErrorPassword.Size = new System.Drawing.Size(67, 15);
            this.labelErrorPassword.TabIndex = 8;
            this.labelErrorPassword.Text = "Error";
            this.labelErrorPassword.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 47);
            this.panel1.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(37, 12);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PlaceholderText = "Enter password...";
            this.textBoxPassword.Size = new System.Drawing.Size(222, 23);
            this.textBoxPassword.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonSubmit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 418);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(968, 54);
            this.panel3.TabIndex = 51;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.buttonSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(853, 10);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(105, 34);
            this.buttonSubmit.TabIndex = 16;
            this.buttonSubmit.Text = "Finish";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelEmail.Location = new System.Drawing.Point(0, 110);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Padding = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.labelEmail.Size = new System.Drawing.Size(71, 30);
            this.labelEmail.TabIndex = 52;
            this.labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelPassword.Location = new System.Drawing.Point(0, 202);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Padding = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.labelPassword.Size = new System.Drawing.Size(94, 30);
            this.labelPassword.TabIndex = 53;
            this.labelPassword.Text = "Password";
            // 
            // UserControlRegisterAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelErrorPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelErrorEmail);
            this.Controls.Add(this.panelForButton);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelHeader);
            this.Name = "UserControlRegisterAdmin";
            this.Size = new System.Drawing.Size(968, 472);
            this.panelForButton.ResumeLayout(false);
            this.panelForButton.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Panel panelForButton;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelErrorEmail;
        private System.Windows.Forms.Label labelErrorPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
    }
}
