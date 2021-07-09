using Project21040062.Entity;
using System;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class UserControlViewTransactionDetail : UserControl
    {

        #region Variables
        private FormSub formSub;
        private Transaction transaction;
        #endregion

        #region Constructors
        public UserControlViewTransactionDetail(FormSub formSub, Transaction transaction)
        {
            InitializeComponent();
            this.formSub = formSub;
            this.transaction = transaction;
            SyncData();
        }
        #endregion

        #region Methods
        // Sync Input with Transaction Data
        private void SyncData()
        {
            Employee employee = transaction.GetEmployee();
            this.labelHeader.Text = $"Transaction #{transaction.id}";
            this.textBoxEmployeeName.Text = employee != null ? employee.name : "Missing Data";
            this.textBoxTime.Text = transaction.time.ToString();
            this.textBoxTotal.Text = transaction.GetTotal().ToString();

            dataGridView1.Rows.Clear();
            foreach (TransactionItem item in transaction.items)
            {
                string[] data = { item.itemName, item.price.ToString(), item.quantity.ToString(), item.SubTotal().ToString() };
                dataGridView1.Rows.Add(data);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            formSub.Close();
        }
        #endregion
    }
}
