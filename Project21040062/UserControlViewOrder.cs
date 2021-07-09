using Project21040062.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class UserControlViewOrder : UserControl
    {

        #region Variables
        private List<TransactionItem> items; // Cart
        private List<uint> itemIds; // Cart Item IDs
        #endregion

        #region Constructors
        public UserControlViewOrder()
        {
            InitializeComponent();
            items = new List<TransactionItem>();
            itemIds = new List<uint>();
            LoadData();
            LoadItems();
            SyncData();
            SyncItemData();
        }
        #endregion

        #region Methods
        // Get Item data
        private string[] GetData(Item item)
        {
            string[] data = { item.GetCategory().name, item.id.ToString(), item.name, item.price.ToString(), item.stock.ToString() };
            return data;
        }

        // Load Item data to the table
        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            foreach (Item item in Item.list)
            {
                dataGridView1.Rows.Add(GetData(item));
            }
        }

        // Get Transaction Item data
        private string[] GetItem(uint id, TransactionItem item)
        {
            string[] data = { id.ToString(), item.itemName, item.price.ToString(), item.quantity.ToString(), item.SubTotal().ToString() };
            return data;
        }

        // Load Transaction Item data to the table
        private void LoadItems()
        {
            dataGridView2.Rows.Clear();
            decimal total = 0;
            for (int i = 0; i < items.Count; ++i)
            {
                TransactionItem item = items[i];
                uint id = itemIds[i];
                dataGridView2.Rows.Add(GetItem(id, item));
                total += item.SubTotal();
            }

            string[] totalData = { "", "", "", "Total", total.ToString() };
            dataGridView2.Rows.Add(totalData);
        }

        // Sync Data with Inputs
        private void SyncData()
        {
            if (dataGridView1.SelectedCells.Count == 0) { return; }
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            
            uint max = Convert.ToUInt32(row.Cells[4].Value);

            uint id = Convert.ToUInt32(row.Cells[1].Value);
            int index = itemIds.FindIndex(itemId => itemId == id);
            if (index != -1)
            {
                max -= items[index].quantity;
            }

            numericUpDownAddQuantity.Maximum = max;
        }

        // Sync Item Data with inputs
        private void SyncItemData()
        {
            if (dataGridView2.SelectedCells.Count == 0 || dataGridView2.RowCount == 1) { return; }
            int rowIndex = dataGridView2.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridView2.Rows[rowIndex];
            int quantity = Convert.ToInt32(row.Cells[3].Value);
            numericUpDownUpdateQuantity.Value = quantity;

            uint id = Convert.ToUInt32(row.Cells[0].Value);
            numericUpDownUpdateQuantity.Maximum = Item.FindById(id).stock;
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (items.Count == 0) { return; }

            Transaction.Add(textBoxNote.Text, items);
            for (int i = 0; i < items.Count; ++i)
            {
                TransactionItem transactionItem = items[i];
                Item item = Item.FindById(itemIds[i]);
                item.stock -= transactionItem.quantity;
            }

            items.Clear();
            itemIds.Clear();
            LoadData();
            LoadItems();
            SyncData();
            SyncItemData();
            MessageBox.Show("Orders received!", "Success", MessageBoxButtons.OK);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count == 0 || dataGridView2.RowCount == 1) { return; }
            int rowIndex = dataGridView2.SelectedCells[0].RowIndex;
            items.RemoveAt(rowIndex);
            itemIds.RemoveAt(rowIndex);
            LoadItems();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0) { return; }
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            uint id = Convert.ToUInt32(row.Cells[1].Value);
            int index = itemIds.FindIndex(itemId => itemId == id);
            uint quantity = Convert.ToUInt32(numericUpDownAddQuantity.Value);

            uint max = Convert.ToUInt32(row.Cells[4].Value);
            if (index != -1)
            {
                max -= items[index].quantity;
            }

            if (quantity < 1 || quantity > max) { return; }

            if (index == -1)
            {
                TransactionItem transactionItem = new TransactionItem(row.Cells[2].Value.ToString(), quantity, Convert.ToDecimal(row.Cells[3].Value));
                items.Add(transactionItem);
                itemIds.Add(id);
            } else
            {
                items[index].quantity += quantity;
            }

            SyncData();
            LoadItems();
        }

        // Update the Quantity instantly
        private void numericUpDownUpdateQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count == 0 || dataGridView2.RowCount == 1) { return; }
            int rowIndex = dataGridView2.SelectedCells[0].RowIndex;
            
            DataGridViewRow row = dataGridView2.Rows[rowIndex];
            decimal previousSubTotal = Convert.ToDecimal(row.Cells[4].Value);

            TransactionItem item = items[rowIndex];
            uint id = itemIds[rowIndex];
            item.quantity = Convert.ToUInt32(numericUpDownUpdateQuantity.Value);
            row.SetValues(GetItem(id, item));

            decimal total = Convert.ToDecimal(dataGridView2.Rows[^1].Cells[4].Value);
            total += (item.SubTotal() - previousSubTotal);
            dataGridView2.Rows[^1].Cells[4].Value = total.ToString();
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SyncItemData();
        }
        #endregion

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SyncData();
        }
    }
}
