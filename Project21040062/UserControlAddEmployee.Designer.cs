
namespace Project21040062
{
    partial class UserControlAddEmployee
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelErrorName = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelErrorEmail = new System.Windows.Forms.Label();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelErrorPassword = new System.Windows.Forms.Label();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelErrorRole = new System.Windows.Forms.Label();
            this.panelRole = new System.Windows.Forms.Panel();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelErrorSalary = new System.Windows.Forms.Label();
            this.panelSalary = new System.Windows.Forms.Panel();
            this.numericUpDownSalary = new System.Windows.Forms.NumericUpDown();
            this.labelSalary = new System.Windows.Forms.Label();
            this.panelName.SuspendLayout();
            this.panelEmail.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelRole.SuspendLayout();
            this.panelSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).BeginInit();
            this.SuspendLayout();
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
            this.buttonSubmit.Location = new System.Drawing.Point(377, 10);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(105, 34);
            this.buttonSubmit.TabIndex = 16;
            this.buttonSubmit.Text = "Add";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelDescription.Location = new System.Drawing.Point(0, 80);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Padding = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.labelDescription.Size = new System.Drawing.Size(272, 30);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "To add a new employee, please fill this form";
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
            this.labelHeader.Size = new System.Drawing.Size(359, 80);
            this.labelHeader.TabIndex = 10;
            this.labelHeader.Text = "Add Employee";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelName.Location = new System.Drawing.Point(0, 110);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.labelName.Size = new System.Drawing.Size(75, 30);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "Name";
            // 
            // labelErrorName
            // 
            this.labelErrorName.AutoSize = true;
            this.labelErrorName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelErrorName.ForeColor = System.Drawing.Color.Red;
            this.labelErrorName.Location = new System.Drawing.Point(0, 187);
            this.labelErrorName.Name = "labelErrorName";
            this.labelErrorName.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.labelErrorName.Size = new System.Drawing.Size(67, 15);
            this.labelErrorName.TabIndex = 25;
            this.labelErrorName.Text = "Error";
            this.labelErrorName.Visible = false;
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.textBoxName);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(0, 140);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(492, 47);
            this.panelName.TabIndex = 24;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(37, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Enter employee\'s name...";
            this.textBoxName.Size = new System.Drawing.Size(222, 23);
            this.textBoxName.TabIndex = 3;
            // 
            // labelErrorEmail
            // 
            this.labelErrorEmail.AutoSize = true;
            this.labelErrorEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.labelErrorEmail.Location = new System.Drawing.Point(0, 279);
            this.labelErrorEmail.Name = "labelErrorEmail";
            this.labelErrorEmail.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.labelErrorEmail.Size = new System.Drawing.Size(67, 15);
            this.labelErrorEmail.TabIndex = 28;
            this.labelErrorEmail.Text = "Error";
            this.labelErrorEmail.Visible = false;
            // 
            // panelEmail
            // 
            this.panelEmail.Controls.Add(this.textBoxEmail);
            this.panelEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmail.Location = new System.Drawing.Point(0, 232);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(492, 47);
            this.panelEmail.TabIndex = 27;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(37, 12);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PlaceholderText = "Enter employee\'s email...";
            this.textBoxEmail.Size = new System.Drawing.Size(222, 23);
            this.textBoxEmail.TabIndex = 3;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelEmail.Location = new System.Drawing.Point(0, 202);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Padding = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.labelEmail.Size = new System.Drawing.Size(71, 30);
            this.labelEmail.TabIndex = 26;
            this.labelEmail.Text = "Email";
            // 
            // labelErrorPassword
            // 
            this.labelErrorPassword.AutoSize = true;
            this.labelErrorPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPassword.Location = new System.Drawing.Point(0, 371);
            this.labelErrorPassword.Name = "labelErrorPassword";
            this.labelErrorPassword.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.labelErrorPassword.Size = new System.Drawing.Size(67, 15);
            this.labelErrorPassword.TabIndex = 31;
            this.labelErrorPassword.Text = "Error";
            this.labelErrorPassword.Visible = false;
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.textBoxPassword);
            this.panelPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPassword.Location = new System.Drawing.Point(0, 324);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(492, 47);
            this.panelPassword.TabIndex = 30;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(37, 12);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PlaceholderText = "Enter employee\'s password";
            this.textBoxPassword.Size = new System.Drawing.Size(222, 23);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelPassword.Location = new System.Drawing.Point(0, 294);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Padding = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.labelPassword.Size = new System.Drawing.Size(94, 30);
            this.labelPassword.TabIndex = 29;
            this.labelPassword.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Error";
            this.label8.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(968, 47);
            this.panel4.TabIndex = 36;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(37, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Enter email...";
            this.textBox4.Size = new System.Drawing.Size(222, 23);
            this.textBox4.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.label9.Size = new System.Drawing.Size(75, 30);
            this.label9.TabIndex = 35;
            this.label9.Text = "Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonSubmit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 570);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(492, 54);
            this.panel3.TabIndex = 32;
            // 
            // labelErrorRole
            // 
            this.labelErrorRole.AutoSize = true;
            this.labelErrorRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelErrorRole.ForeColor = System.Drawing.Color.Red;
            this.labelErrorRole.Location = new System.Drawing.Point(0, 463);
            this.labelErrorRole.Name = "labelErrorRole";
            this.labelErrorRole.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.labelErrorRole.Size = new System.Drawing.Size(67, 15);
            this.labelErrorRole.TabIndex = 35;
            this.labelErrorRole.Text = "Error";
            this.labelErrorRole.Visible = false;
            // 
            // panelRole
            // 
            this.panelRole.Controls.Add(this.comboBoxRole);
            this.panelRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRole.Location = new System.Drawing.Point(0, 416);
            this.panelRole.Name = "panelRole";
            this.panelRole.Size = new System.Drawing.Size(492, 47);
            this.panelRole.TabIndex = 34;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(37, 12);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(222, 23);
            this.comboBoxRole.TabIndex = 0;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelRole.Location = new System.Drawing.Point(0, 386);
            this.labelRole.Name = "labelRole";
            this.labelRole.Padding = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.labelRole.Size = new System.Drawing.Size(67, 30);
            this.labelRole.TabIndex = 33;
            this.labelRole.Text = "Role";
            // 
            // labelErrorSalary
            // 
            this.labelErrorSalary.AutoSize = true;
            this.labelErrorSalary.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelErrorSalary.ForeColor = System.Drawing.Color.Red;
            this.labelErrorSalary.Location = new System.Drawing.Point(0, 555);
            this.labelErrorSalary.Name = "labelErrorSalary";
            this.labelErrorSalary.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.labelErrorSalary.Size = new System.Drawing.Size(67, 15);
            this.labelErrorSalary.TabIndex = 38;
            this.labelErrorSalary.Text = "Error";
            this.labelErrorSalary.Visible = false;
            // 
            // panelSalary
            // 
            this.panelSalary.Controls.Add(this.numericUpDownSalary);
            this.panelSalary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSalary.Location = new System.Drawing.Point(0, 508);
            this.panelSalary.Name = "panelSalary";
            this.panelSalary.Size = new System.Drawing.Size(492, 47);
            this.panelSalary.TabIndex = 37;
            // 
            // numericUpDownSalary
            // 
            this.numericUpDownSalary.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSalary.Location = new System.Drawing.Point(37, 12);
            this.numericUpDownSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownSalary.Name = "numericUpDownSalary";
            this.numericUpDownSalary.Size = new System.Drawing.Size(222, 23);
            this.numericUpDownSalary.TabIndex = 0;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelSalary.Location = new System.Drawing.Point(0, 478);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Padding = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.labelSalary.Size = new System.Drawing.Size(75, 30);
            this.labelSalary.TabIndex = 36;
            this.labelSalary.Text = "Salary";
            // 
            // UserControlAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelErrorSalary);
            this.Controls.Add(this.panelSalary);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelErrorRole);
            this.Controls.Add(this.panelRole);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelErrorPassword);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelErrorEmail);
            this.Controls.Add(this.panelEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelErrorName);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelHeader);
            this.Name = "UserControlAddEmployee";
            this.Size = new System.Drawing.Size(492, 428);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelRole.ResumeLayout(false);
            this.panelSalary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelErrorName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelErrorEmail;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelErrorPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelErrorRole;
        private System.Windows.Forms.Panel panelRole;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Label labelErrorSalary;
        private System.Windows.Forms.Panel panelSalary;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.NumericUpDown numericUpDownSalary;
    }
}
