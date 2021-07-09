using Project21040062.Entity;
using System;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class UserControlEditEmployee : UserControl
    {

        #region Variables
        private FormSub formSub;
        private Employee employee;
        #endregion

        #region Constructors
        public UserControlEditEmployee(FormSub formSub, Employee employee)
        {
            InitializeComponent();
            InitializeComboBox();

            this.employee = employee;
            this.formSub = formSub;

            SyncData();
        }
        #endregion

        #region Methods
        // Sync Inputs with the Employee Data
        private void SyncData()
        {
            textBoxName.Text = employee.name;
            textBoxEmail.Text = employee.email;
            textBoxPassword.Text = employee.password;
            comboBoxRole.SelectedIndex = Role.list.IndexOf(employee.GetRole());
            numericUpDownSalary.Value = employee.salary;
        }

        // Initialize ComboBox with Roles
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
            if (!errorName && !errorPassword && !errorRole && !errorSalary)
            {
                uint roleId = Role.list[comboBoxRole.SelectedIndex].id;
                Employee.Edit(employee.id, roleId, textBoxName.Text, textBoxPassword.Text, numericUpDownSalary.Value);
                formSub.Close();
            }
        }

        // Reset Input with the Employee's Data
        private void buttonReset_Click(object sender, EventArgs e)
        {
            SyncData();
        }
        #endregion

    }
}
