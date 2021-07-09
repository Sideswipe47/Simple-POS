using Project21040062.Entity;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class UserControlApplication : UserControl
    {

        #region Variables
        public static UserControlApplication userControlApplication; // Singleton
        private Button lastButton; // Get Reference to the last Button
        #endregion

        #region Constructors
        public UserControlApplication()
        {
            InitializeComponent();
            userControlApplication = this;
            MenuVisibility();
        }
        #endregion

        #region Methods
        // Set Menu Visibility for the current User
        public void MenuVisibility()
        {
            Role currentRole = Program.user.GetRole();
            this.buttonOrder.Visible = currentRole.manageOrder;
            this.buttonRole.Visible = currentRole.manageRoles;
            this.buttonEmployee.Visible = currentRole.manageEmployees;
            this.buttonCategory.Visible = currentRole.viewCategories || currentRole.manageCategories;
            this.buttonItem.Visible = currentRole.viewItems || currentRole.manageItems;
            this.buttonTransaction.Visible = currentRole.viewTransactions;
        }

        // Show control to display
        private void ShowControl(Button currentButton, UserControl control)
        {

            // Set Last Button to look normal
            if (lastButton != null)
            {
                Font currentFont = this.lastButton.Font;
                this.lastButton.Font = new Font(currentFont.Name, currentFont.Size, FontStyle.Regular);
                this.lastButton.BackColor = Color.FromArgb(33, 33, 34);
                this.lastButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 29, 30);
                this.lastButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 122, 204);
            }

            // Set Current Button to look highlighted
            if (currentButton != null)
            {
                this.lastButton = currentButton;
                Font currentFont = currentButton.Font;
                currentButton.Font = new Font(currentFont.Name, currentFont.Size, FontStyle.Bold);
                currentButton.BackColor = Color.FromArgb(0, 122, 204);
                currentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 115, 197);
                currentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 108, 190);
            }
            
            control.Dock = DockStyle.Fill;
            if (this.panelContent.Controls.Count != 0) { this.panelContent.Controls[0].Dispose(); }
            this.panelContent.Controls.Add(control);
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            ShowControl((Button)sender, new UserControlViewOrder());
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            ShowControl((Button)sender, new UserControlViewEmployees());
        }

        private void buttonRole_Click(object sender, EventArgs e)
        {
            ShowControl((Button)sender, new UserControlViewRoles());
        }

        private void buttonItem_Click(object sender, EventArgs e)
        {
            ShowControl((Button)sender, new UserControlViewItems());
        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            ShowControl((Button)sender, new UserControlViewTransactions());
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            ShowControl((Button)sender, new UserControlEditProfile());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure you want to logout from the current session?", "Logout", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes) { FormMain.formMain.Logout(); }
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            ShowControl((Button)sender, new UserControlViewCategories());
        }
        #endregion

    }
}
