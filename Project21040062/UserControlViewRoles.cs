using Project21040062.Entity;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class UserControlViewRoles : UserControl
    {

        #region Constructors
        public UserControlViewRoles()
        {
            InitializeComponent();
            InitializeCheckBox();
            LoadData();
        }
        #endregion

        #region Methods
        // Get Data for the Table
        private string[] GetData(Role role)
        {
            string[] data = { role.id.ToString(), role.name };
            return data;
        } 

        // Load Role data to the table
        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            foreach (Role role in Role.list)
            {
                dataGridView1.Rows.Add(GetData(role));
            }
            SyncData(Role.list[0]);
        }

        // Initialize CheckBox with Roles boolean
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

        // Sync Input with the selected Role data
        private void SyncData(Role role)
        {
            bool isEssential = (role.id == 1 || role.id == 2);
            textBoxName.ReadOnly = isEssential;
            checkedListBox1.SelectionMode = (isEssential ? SelectionMode.None : SelectionMode.One);
            textBoxName.Text = role.name;

            int count = 0;
            foreach (PropertyInfo prop in role.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(bool))
                {
                    checkedListBox1.SetItemChecked(count++, (bool) prop.GetValue(role));
                }
            }
        }

        // Get selected cell's Role
        private Role SelectedRole()
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            return Role.FindById(Convert.ToUInt32(row.Cells[0].Value));
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SyncData(SelectedRole());
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Role role = SelectedRole();
            if (role.id == 1 || role.id == 2)
            {
                MessageBox.Show("Can\'t update essential roles!", "Error", MessageBoxButtons.OK);
                return;
            }

            int count = 0;
            int index = 0;
            foreach (PropertyInfo prop in role.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(bool))
                {
                    bool isChecked = (index < checkedListBox1.CheckedIndices.Count && count++ == checkedListBox1.CheckedIndices[index]);
                    if (isChecked)
                    {
                        prop.SetValue(role, true);
                        ++index;
                    } else
                    {
                        prop.SetValue(role, false);
                    }
                }
            }

            role.name = textBoxName.Text;
            dataGridView1.SelectedCells[0].OwningRow.SetValues(GetData(role));
            UserControlApplication.userControlApplication.MenuVisibility();
            MessageBox.Show("Role has been updated!", "Updated", MessageBoxButtons.OK);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0) { return; }

            HashSet<int> rowIndex = new HashSet<int>();
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                rowIndex.Add(cell.RowIndex);
            }

            if (MessageBox.Show($"Are you sure you want to delete {rowIndex.Count} role{(rowIndex.Count > 1 ? "s" : "")}?", $"Delete Role{(rowIndex.Count > 1 ? "s" : "")}", MessageBoxButtons.YesNo) == DialogResult.No) { return; }

            foreach (int index in rowIndex)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                uint id = Convert.ToUInt32(row.Cells[0].Value);
                Role.RemoveById(id);
            }

            LoadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormMain.formMain.GetAddRole();
            LoadData();
        }
        #endregion

    }
}
