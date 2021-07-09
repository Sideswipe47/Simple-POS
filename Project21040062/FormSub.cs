using System;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class FormSub : Form
    {

        #region Constructors
        public FormSub(string title)
        {
            InitializeComponent();
            labelTitle.Text = title;
        }
        #endregion

        #region Methods
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Switching control to display
        public void ShowControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            if (this.panelMain.Controls.Count != 0) { this.panelMain.Controls.Remove(this.panelMain.Controls[0]); }
            this.panelMain.Controls.Add(control);
        }
        #endregion

    }
}
