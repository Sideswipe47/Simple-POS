using Project21040062.Entity;
using System;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class UserControlRegisterAdmin : UserControl
    {

        #region Constructors
        public UserControlRegisterAdmin()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void buttonSubmit_Click(object sender, EventArgs e)
        {

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

            // Create Admin
            if (!errorEmail && !errorPassword) { FormMain.formMain.RegisterAdmin(email, password); }

        }
        #endregion

    }
}
