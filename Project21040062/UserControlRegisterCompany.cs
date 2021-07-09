using System;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class UserControlRegisterCompany : UserControl
    {

        #region Constructors
        public UserControlRegisterCompany()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string companyName = textBoxCompanyName.Text;
            if (companyName.Trim().Length == 0) { labelError.Visible = true; }
            else { FormMain.formMain.RegisterCompany(companyName); }
        }
        #endregion

    }
}
