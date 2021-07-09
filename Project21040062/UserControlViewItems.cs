using Project21040062.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class UserControlViewItems : UserControl
    {

        #region Constructors
        public UserControlViewItems()
        {
            InitializeComponent();
            LoadData();
            CheckPermission();
        }
        #endregion

        #region Methods
        // Change inputs based on permission
        private void CheckPermission()
        {
            Role role = Program.user.GetRole();
            tableLayoutPanel1.Visible = role.manageItems;
        }

        // Get Item Data
        private string[] GetData(Item item)
        {
            string[] data = { item.id.ToString(), item.name, item.GetCategory().name, item.price.ToString(), item.stock.ToString() };
            return data;
        }

        // Load Items to the Table
        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            foreach (Item item in Item.list)
            {
                dataGridView1.Rows.Add(GetData(item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormMain.formMain.GetAddItem();
            LoadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0) { return; }
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            uint id = Convert.ToUInt32(row.Cells[0].Value);

            Item item = Item.FindById(id);
            FormMain.formMain.GetEditItem(item);
            dataGridView1.SelectedCells[0].OwningRow.SetValues(GetData(item));
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0) { return; }

            HashSet<int> rowIndex = new HashSet<int>();
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                rowIndex.Add(cell.RowIndex);
            }

            if (MessageBox.Show($"Are you sure you want to delete {rowIndex.Count} item{(rowIndex.Count > 1 ? "s" : "")}?", $"Delete Item{(rowIndex.Count > 1 ? "s" : "")}", MessageBoxButtons.YesNo) == DialogResult.No) { return; }

            foreach (int index in rowIndex)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                uint id = Convert.ToUInt32(row.Cells[0].Value);
                Item.RemoveById(id);
            }

            LoadData();
        }
        #endregion

    }
}
