using Project21040062.Entity;
using System;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class FormMain : Form
    {

        #region Variables
        public static FormMain formMain; // Variables
        #endregion

        #region Constructors
        public FormMain()
        {
            InitializeComponent();
            formMain = this;

            // If no data was found about the application, then register first
            if (ApplicationData.appData == null) { ShowControl(new UserControlRegisterCompany()); }
            else {
                ChangeFormTitle();
                CheckLogin();
            }
        }
        #endregion

        #region Methods
        // Method for changing Form Title
        private void ChangeFormTitle()
        {
            this.Text += $" => {ApplicationData.appData.companyName}";
            labelTitle.Text += $" => {ApplicationData.appData.companyName}";
        }

        // Method for changing control (Showing different page)
        private void ShowControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            if (this.panelMain.Controls.Count != 0) { this.panelMain.Controls.Remove(this.panelMain.Controls[0]); }
            this.panelMain.Controls.Add(control);
        }
        
        // Register company name, then go to admin if there is no employee yet
        public void RegisterCompany(string companyName)
        {
            ApplicationData.appData = new ApplicationData(companyName);
            ChangeFormTitle();
            if (Employee.list.Count == 0) { ShowControl(new UserControlRegisterAdmin()); }
            else { CheckLogin(); }
        }

        // Register admin, then login using admin
        public void RegisterAdmin(string email, string password)
        {
            Employee admin = new Employee(email)
            {
                name = "Admin",
                roleId = 1,
                password = password
            };

            Employee.list.Add(admin);
            Program.user = admin;
            CheckLogin();
        }

        // Login with email and password
        public bool Login(string email, string password)
        {
            Program.user = Employee.FindByEmailAndPassword(email, password);
            if (Program.user != null)
            {
                CheckLogin();
                return true;
            } else
            {
                return false;
            }
        }

        // Logout of the application
        public void Logout()
        {
            Program.user = null;
            CheckLogin();
        }

        // Check whether is the user login or not
        private void CheckLogin()
        {
            if (Employee.FindById(1) == null) { ShowControl(new UserControlRegisterAdmin()); }
            else if (Program.user == null) { ShowControl(new UserControlLogin()); }
            else { ShowControl(new UserControlApplication()); }
        }

        // Get form for adding Employee
        public void GetAddEmployee()
        {
            FormSub formSub = new FormSub("Add Employee");
            formSub.ShowControl(new UserControlAddEmployee(formSub));
            formSub.ShowDialog();
        }

        // Get form for editing Employee
        public void GetEditEmployee(Employee employee)
        {
            FormSub formSub = new FormSub("Edit Employee");
            formSub.ShowControl(new UserControlEditEmployee(formSub, employee));
            formSub.ShowDialog();
        }

        // Get form for adding Role
        public void GetAddRole()
        {
            FormSub formSub = new FormSub("Add Role");
            formSub.ShowControl(new UserControlAddRole(formSub));
            formSub.ShowDialog();
        }

        // Get form for adding category
        public void GetAddCategory()
        {
            FormSub formSub = new FormSub("Add Category");
            formSub.ShowControl(new UserControlAddCategory(formSub));
            formSub.ShowDialog();
        }

        // Get form for adding item
        public void GetAddItem()
        {
            FormSub formSub = new FormSub("Add Item");
            formSub.ShowControl(new UserControlAddItem(formSub));
            formSub.ShowDialog();
        }

        // Get form for editing item
        public void GetEditItem(Item item)
        {
            FormSub formSub = new FormSub("Edit Item");
            formSub.ShowControl(new UserControlEditItem(formSub, item));
            formSub.ShowDialog();
        }

        // Get form for seeing Transaction detail
        public void GetTransactionDetail(Transaction transaction)
        {
            FormSub formSub = new FormSub("Transaction Detail");
            formSub.ShowControl(new UserControlViewTransactionDetail(formSub, transaction));
            formSub.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized);
        }
        #endregion
    }
}
