using Project21040062.Entity;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class UserControlAddRole : UserControl
    {

        #region Variables
        private FormSub formSub;
        #endregion

        #region Constructors
        public UserControlAddRole(FormSub formSub)
        {
            InitializeComponent();
            InitializeCheckBox();
            this.formSub = formSub;
        }
        #endregion

        #region Methods
        // Initialize Check Box Items with all Boolean from class Role
        private void InitializeCheckBox()
        {
            Role role = new Role();
            foreach (PropertyInfo prop in role.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(bool))
                {
                    string permission = "";
                    foreach (char c in prop.Name)
                    {
                        if (Char.IsUpper(c)) { permission += " "; }
                        permission += c;
                    }
                    permission = Char.ToUpper(permission[0]) + permission.Substring(1);
                    checkedListBox1.Items.Add(permission);
                }
            }
        }

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
                Role.Add(textBoxName.Text, checkedListBox1.CheckedIndices);
                formSub.Close();
            }

        }
        #endregion

    }
}
