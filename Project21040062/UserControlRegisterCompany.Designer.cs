
namespace Project21040062
{
    partial class UserControlRegisterCompany
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.panelForButton = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.panelForButton.SuspendLayout();
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
            this.labelHeader.TabIndex = 0;
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
            this.labelDescription.Size = new System.Drawing.Size(345, 30);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "To initialize the application, please register your Company";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(841, 425);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(105, 34);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Next";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(37, 12);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.PlaceholderText = "Enter company\'s name...";
            this.textBoxCompanyName.Size = new System.Drawing.Size(222, 23);
            this.textBoxCompanyName.TabIndex = 3;
            // 
            // panelForButton
            // 
            this.panelForButton.Controls.Add(this.textBoxCompanyName);
            this.panelForButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForButton.Location = new System.Drawing.Point(0, 110);
            this.panelForButton.Name = "panelForButton";
            this.panelForButton.Size = new System.Drawing.Size(968, 47);
            this.panelForButton.TabIndex = 4;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(0, 157);
            this.labelError.Name = "labelError";
            this.labelError.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.labelError.Size = new System.Drawing.Size(142, 15);
            this.labelError.TabIndex = 5;
            this.labelError.Text = "Please fill the input";
            this.labelError.Visible = false;
            // 
            // UserControlRegisterCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.panelForButton);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelHeader);
            this.Name = "UserControlRegisterCompany";
            this.Size = new System.Drawing.Size(968, 472);
            this.panelForButton.ResumeLayout(false);
            this.panelForButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Panel panelForButton;
        private System.Windows.Forms.Label labelError;
    }
}
