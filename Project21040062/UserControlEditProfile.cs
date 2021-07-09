using System;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class UserControlEditProfile : UserControl
    {

        #region Constructors
        public UserControlEditProfile()
        {
            InitializeComponent();
            SyncData();
        }
        #endregion

        #region Methods
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

            // Success
            if (!errorName && !errorPassword)
            {
                Program.user.name = textBoxName.Text;
                Program.user.password = textBoxPassword.Text;
                MessageBox.Show("User has been updated!", "Updated", MessageBoxButtons.OK);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            SyncData();
        }

        // Sync Data with the current User's Data
        private void SyncData()
        {
            textBoxName.Text = Program.user.name;
            textBoxEmail.Text = Program.user.email;
            textBoxPassword.Text = Program.user.password;
        }
        #endregion

    }
}
