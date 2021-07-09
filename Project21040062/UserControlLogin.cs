using System;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class UserControlLogin : UserControl
    {

        #region Constructors
        public UserControlLogin()
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
            else { errorEmail = false; }
            labelErrorEmail.Visible = errorEmail;

            // Validate Password
            bool errorPassword = true;
            string password = textBoxPassword.Text;
            if (password.Trim().Length == 0) { labelErrorPassword.Text = "Please fill the input"; }
            else if (password.Contains(" ")) { labelErrorPassword.Text = "Password can't contain space"; }
            else { errorPassword = false; }
            labelErrorPassword.Visible = errorPassword;

            // Login
            if (!errorEmail && !errorPassword && !FormMain.formMain.Login(email, password)) { labelErrorCredentials.Visible = true; }
            else { labelErrorCredentials.Visible = false; }

        }
        #endregion

    }
}
