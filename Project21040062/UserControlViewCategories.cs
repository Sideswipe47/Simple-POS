using Project21040062.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class UserControlViewCategories : UserControl
    {

        #region Constructors
        public UserControlViewCategories()
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
            textBoxName.ReadOnly = !role.manageCategories;
            panel2.Visible = role.manageCategories;
        }


        // Load Categories for Table
        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            foreach (Category category in Category.list)
            {
                string[] data = { category.id.ToString(), category.name };
                dataGridView1.Rows.Add(data);
            }
            SyncData(Category.list[0]);
        }

        // Sync Input with Category's Data
        private void SyncData(Category category)
        {
            textBoxName.Text = category.name;
        }

        // Get Selected Category from the Table
        private Category SelectedCategory()
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            return Category.FindById(Convert.ToUInt32(row.Cells[0].Value));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormMain.formMain.GetAddCategory();
            LoadData();
        }

        // Update Category except for No Category
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Category category = SelectedCategory();
            if (category.id == 1) {
                MessageBox.Show("Can\'t edit essential category", "Error", MessageBoxButtons.OK);
                return;
            }
            bool differentName = category.name != textBoxName.Text;
            category.name = textBoxName.Text;
            if (differentName) { dataGridView1.SelectedCells[0].OwningRow.Cells[1].Value = category.name; }
            MessageBox.Show("Category has been updated!", "Updated", MessageBoxButtons.OK);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0) { return; }

            // Making sure no duplicate row index
            HashSet<int> rowIndex = new HashSet<int>();
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                rowIndex.Add(cell.RowIndex);
            }

            if (MessageBox.Show($"Are you sure you want to delete {rowIndex.Count} category{(rowIndex.Count > 1 ? "s" : "")}?", $"Delete Category{(rowIndex.Count > 1 ? "s" : "")}", MessageBoxButtons.YesNo) == DialogResult.No) { return; }

            // Remove based on ID except for No Category
            foreach (int index in rowIndex)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                uint id = Convert.ToUInt32(row.Cells[0].Value);
                Category.RemoveById(id);
            }

            LoadData();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SyncData(SelectedCategory());
        }
        #endregion

    }
}