using Project21040062.Entity;
using System;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class UserControlViewTransactions : UserControl
    {

        #region Constructors
        public UserControlViewTransactions()
        {
            InitializeComponent();
            LoadData();
        }
        #endregion

        #region Methods
        // Get Transaction data
        private string[] GetData(Transaction transaction)
        {
            Employee employee = transaction.GetEmployee();
            string[] data = { transaction.id.ToString(), transaction.time.ToString(), employee != null ? employee.name : "Missing Data", transaction.GetTotal().ToString(), transaction.note };
            return data;
        }

        // Load Transaction to the Table
        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            foreach (Transaction transaction in Transaction.list)
            {
                
                dataGridView1.Rows.Add(GetData(transaction));
            }
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0) { return; }
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            uint id = Convert.ToUInt32(row.Cells[0].Value);

            Transaction transaction = Transaction.FindById(id);
            FormMain.formMain.GetTransactionDetail(transaction);
        }
        #endregion
    }
}
