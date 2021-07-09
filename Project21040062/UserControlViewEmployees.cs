using Project21040062.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class UserControlViewEmployees : UserControl
    {

        #region Constructors
        public UserControlViewEmployees()
        {
            InitializeComponent();
            LoadData();
        }
        #endregion

        #region Methods
        // Get Employee Data
        private string[] GetData(Employee employee)
        {
            string[] data = { employee.id.ToString(), employee.name, employee.email, employee.createdAt.ToString(), employee.GetRole().name, employee.salary.ToString() };
            return data;
        }

        // Load Employees to the Table
        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            foreach (Employee employee in Employee.list)
            {
                dataGridView1.Rows.Add(GetData(employee));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormMain.formMain.GetAddEmployee();
            LoadData();
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
            
            if (MessageBox.Show($"Are you sure you want to delete {rowIndex.Count} employee{(rowIndex.Count > 1 ? "s" : "")}?", $"Delete Employee{(rowIndex.Count > 1 ? "s" : "")}", MessageBoxButtons.YesNo) == DialogResult.No) { return; }

            // Delete Employee except for Admin
            foreach (int index in rowIndex)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                uint id = Convert.ToUInt32(row.Cells[0].Value);
                Employee.RemoveById(id);
            }

            LoadData();
        }

        // Edit Employee except for Admin
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0) { return; }

            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            uint id = Convert.ToUInt32(row.Cells[0].Value);
            if (id == 1) {
                MessageBox.Show("Can\'t edit essential employees", "Error", MessageBoxButtons.OK);
                return;
            }

            Employee employee = Employee.FindById(id);
            FormMain.formMain.GetEditEmployee(employee);
            dataGridView1.SelectedCells[0].OwningRow.SetValues(GetData(employee));
        }
        #endregion

    }
}
