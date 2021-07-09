using Project21040062.Entity;
using System;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class UserControlAddEmployee : UserControl
    {

        #region Variables
        private FormSub formSub;
        #endregion

        #region Constructors
        public UserControlAddEmployee(FormSub formSub)
        {
            InitializeComponent();
            InitializeComboBox();
            this.formSub = formSub;
        }
        #endregion

        #region Methods
        // Initialize Combo Box Item with Roles
        private void InitializeComboBox()
        {
            foreach (Role role in Role.list)
            {
                this.comboBoxRole.Items.Add(role.name);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            // Validate Name
            bool errorName = true;
            if (textBoxName.Text.Trim().Length == 0) { labelErrorName.Text = "Please fill this field"; }
            else { errorName = false; }
            labelErrorName.Visible = errorName;

            // Validate Email
            bool errorEmail = true;
            string email = textBoxEmail.Text.Trim();
            if (email.Length == 0) { labelErrorEmail.Text = "Please fill the input"; }
            else if (!email.Contains("@")) { labelErrorEmail.Text = "\"@\" is missing"; }
            else if (!email.Contains(".")) { labelErrorEmail.Text = "\".\" is missing"; }
            else if (email.StartsWith("@")) { labelErrorEmail.Text = "Account name is missing"; }
            else if (email.IndexOf(".") - email.IndexOf("@") == 1) { labelErrorEmail.Text = "Domain name is missing"; }
            else if (email.EndsWith(".")) { labelErrorEmail.Text = "TLD is missing"; }
            else if (Employee.FindByEmail(email) != null) { labelErrorEmail.Text = "Email is already used"; }
            else { errorEmail = false; }
            labelErrorEmail.Visible = errorEmail;

            // Validate Password
            bool errorPassword = true;
            string password = textBoxPassword.Text;
            if (password.Trim().Length == 0) { labelErrorPassword.Text = "Please fill the input"; }
            else if (password.Contains(" ")) { labelErrorPassword.Text = "Password can't contain space"; }
            else { errorPassword = false; }
            labelErrorPassword.Visible = errorPassword;

            // Validate Role
            bool errorRole = true;
            if (comboBoxRole.SelectedIndex == -1) { labelErrorRole.Text = "Please select an item"; }
            else { errorRole = false; }
            labelErrorRole.Visible = errorRole;

            // Validate Salary
            bool errorSalary = true;
            if (numericUpDownSalary.Value < 0) { labelErrorSalary.Text = "Please check the value again"; }
            else { errorSalary = false; }
            labelErrorSalary.Visible = errorSalary;

            // Success
            if (!errorName && !errorEmail && !errorPassword && !errorRole && !errorSalary)
            {
                uint roleId = Role.list[comboBoxRole.SelectedIndex].id;
                Employee.Add(roleId, textBoxName.Text, textBoxEmail.Text, textBoxPassword.Text, numericUpDownSalary.Value);
                formSub.Close();
            }

        }
        #endregion

    }
}
