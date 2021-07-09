
namespace Project21040062
{
    partial class UserControlEditItem
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
            this.labelErrorPrice = new System.Windows.Forms.Label();
            this.panelSalary = new System.Windows.Forms.Panel();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelErrorCategory = new System.Windows.Forms.Label();
            this.panelRole = new System.Windows.Forms.Panel();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelErrorName = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelErrorStock = new System.Windows.Forms.Label();
            this.panelSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.panelRole.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).BeginInit();
            this.SuspendLayout();
            // 
            // labelErrorPrice
            // 
            this.labelErrorPrice.AutoSize = true;
            this.labelErrorPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelErrorPrice.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPrice.Location = new System.Drawing.Point(0, 371);
            this.labelErrorPrice.Name = "labelErrorPrice";
            this.labelErrorPrice.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.labelErrorPrice.Size = new System.Drawing.Size(67, 15);
            this.labelErrorPrice.TabIndex = 50;
            this.labelErrorPrice.Text = "Error";
            this.labelErrorPrice.Visible = false;
            // 
            // panelSalary
            // 
            this.panelSalary.Controls.Add(this.numericUpDownPrice);
            this.panelSalary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSalary.Location = new System.Drawing.Point(0, 324);
            this.panelSalary.Name = "panelSalary";
            this.panelSalary.Size = new System.Drawing.Size(373, 47);
            this.panelSalary.TabIndex = 49;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPrice.Location = new System.Drawing.Point(37, 12);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(222, 23);
            this.numericUpDownPrice.TabIndex = 0;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelPrice.Location = new System.Drawing.Point(0, 294);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Padding = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.labelPrice.Size = new System.Drawing.Size(70, 30);
            this.labelPrice.TabIndex = 48;
            this.labelPrice.Text = "Price";
            // 
            // labelErrorCategory
            // 
            this.labelErrorCategory.AutoSize = true;
            this.labelErrorCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelErrorCategory.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCategory.Location = new System.Drawing.Point(0, 279);
            this.labelErrorCategory.Name = "labelErrorCategory";
            this.labelErrorCategory.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.labelErrorCategory.Size = new System.Drawing.Size(67, 15);
            this.labelErrorCategory.TabIndex = 47;
            this.labelErrorCategory.Text = "Error";
            this.labelErrorCategory.Visible = false;
            // 
            // panelRole
            // 
            this.panelRole.Controls.Add(this.comboBoxCategory);
            this.panelRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRole.Location = new System.Drawing.Point(0, 232);
            this.panelRole.Name = "panelRole";
            this.panelRole.Size = new System.Drawing.Size(373, 47);
            this.panelRole.TabIndex = 46;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(37, 12);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(222, 23);
            this.comboBoxCategory.TabIndex = 0;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelCategory.Location = new System.Drawing.Point(0, 202);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Padding = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.labelCategory.Size = new System.Drawing.Size(92, 30);
            this.labelCategory.TabIndex = 45;
            this.labelCategory.Text = "Category";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonReset);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.buttonSubmit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 478);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(373, 54);
            this.panel3.TabIndex = 44;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.buttonReset.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(130, 10);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(105, 34);
            this.buttonReset.TabIndex = 20;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(235, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 34);
            this.panel1.TabIndex = 19;
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
            this.buttonSubmit.Location = new System.Drawing.Point(258, 10);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(105, 34);
            this.buttonSubmit.TabIndex = 16;
            this.buttonSubmit.Text = "Update";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
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
            this.labelErrorName.TabIndex = 43;
            this.labelErrorName.Text = "Error";
            this.labelErrorName.Visible = false;
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.textBoxName);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(0, 140);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(373, 47);
            this.panelName.TabIndex = 42;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(37, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Enter item\'s name...";
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
            this.labelName.TabIndex = 41;
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
            this.labelDescription.Size = new System.Drawing.Size(286, 30);
            this.labelDescription.TabIndex = 40;
            this.labelDescription.Text = "To edit this employee, please change the value";
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
            this.labelHeader.Size = new System.Drawing.Size(241, 80);
            this.labelHeader.TabIndex = 39;
            this.labelHeader.Text = "Edit Item";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDownStock);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 47);
            this.panel2.TabIndex = 52;
            // 
            // numericUpDownStock
            // 
            this.numericUpDownStock.Location = new System.Drawing.Point(37, 12);
            this.numericUpDownStock.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownStock.Name = "numericUpDownStock";
            this.numericUpDownStock.Size = new System.Drawing.Size(222, 23);
            this.numericUpDownStock.TabIndex = 0;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.labelStock.Location = new System.Drawing.Point(0, 386);
            this.labelStock.Name = "labelStock";
            this.labelStock.Padding = new System.Windows.Forms.Padding(35, 15, 0, 0);
            this.labelStock.Size = new System.Drawing.Size(74, 30);
            this.labelStock.TabIndex = 51;
            this.labelStock.Text = "Stock";
            // 
            // labelErrorStock
            // 
            this.labelErrorStock.AutoSize = true;
            this.labelErrorStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelErrorStock.ForeColor = System.Drawing.Color.Red;
            this.labelErrorStock.Location = new System.Drawing.Point(0, 463);
            this.labelErrorStock.Name = "labelErrorStock";
            this.labelErrorStock.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.labelErrorStock.Size = new System.Drawing.Size(67, 15);
            this.labelErrorStock.TabIndex = 53;
            this.labelErrorStock.Text = "Error";
            this.labelErrorStock.Visible = false;
            // 
            // UserControlEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelErrorStock);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelErrorPrice);
            this.Controls.Add(this.panelSalary);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelErrorCategory);
            this.Controls.Add(this.panelRole);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelErrorName);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelHeader);
            this.Name = "UserControlEditItem";
            this.Size = new System.Drawing.Size(373, 428);
            this.panelSalary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.panelRole.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelErrorPrice;
        private System.Windows.Forms.Panel panelSalary;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelErrorCategory;
        private System.Windows.Forms.Panel panelRole;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelErrorName;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDownStock;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelErrorStock;
    }
}
