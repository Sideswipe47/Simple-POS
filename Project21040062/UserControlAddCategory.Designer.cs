
namespace Project21040062
{
    partial class UserControlAddCategory
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
            this.labelErrorName = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.panelName.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.labelErrorName.TabIndex = 35;
            this.labelErrorName.Text = "Error";
            this.labelErrorName.Visible = false;
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.textBoxName);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(0, 140);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(713, 47);
            this.panelName.TabIndex = 34;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(37, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Enter category\'s name...";
            this.textBoxName.Size = new System.Drawing.Size(222, 23);
            this.textBoxName.TabIndex = 3;
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
            this.labelName.TabIndex = 33;
            this.labelName.Text = "Name";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelDescription.Location = new System.Drawing.Point(0, 80);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Padding = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.labelDescription.Size = new System.Drawing.Size(266, 30);
            this.labelDescription.TabIndex = 32;
            this.labelDescription.Text = "To add a new category, please fill this form";
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
            this.labelHeader.Size = new System.Drawing.Size(344, 80);
            this.labelHeader.TabIndex = 31;
            this.labelHeader.Text = "Add Category";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonSubmit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 374);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(713, 54);
            this.panel3.TabIndex = 36;
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
            this.buttonSubmit.Location = new System.Drawing.Point(598, 10);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(105, 34);
            this.buttonSubmit.TabIndex = 16;
            this.buttonSubmit.Text = "Add";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // UserControlAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelErrorName);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelHeader);
            this.Name = "UserControlAddCategory";
            this.Size = new System.Drawing.Size(713, 428);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelErrorName;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSubmit;
    }
}
