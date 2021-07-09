using Project21040062.Entity;
using System;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class UserControlAddCategory : UserControl
    {

        #region Variables
        private FormSub formSub;
        #endregion

        #region Constructors
        public UserControlAddCategory(FormSub formSub)
        {
            InitializeComponent();
            this.formSub = formSub;
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

            // Success
            if (!errorName)
            {
                Category.Add(textBoxName.Text);
                formSub.Close();
            }
        }
        #endregion

    }
}
