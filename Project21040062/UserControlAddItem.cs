using Project21040062.Entity;
using System;
using System.Windows.Forms;

namespace Project21040062
{
    public partial class UserControlAddItem : UserControl
    {

        #region Variables
        private FormSub formSub;
        #endregion

        #region Constructors
        public UserControlAddItem(FormSub formSub)
        {
            InitializeComponent();
            InitializeComboBox();
            this.formSub = formSub;
        }
        #endregion

        #region Methods
        // Initialze Combo Box Item with Categories
        private void InitializeComboBox()
        {
            foreach (Category category in Category.list)
            {
                this.comboBoxCategory.Items.Add(category.name);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Validate Name
            bool errorName = true;
            if (textBoxName.Text.Trim().Length == 0) { labelErrorName.Text = "Please fill this field"; }
            else { errorName = false; }
            labelErrorName.Visible = errorName;

            // Validate Category
            bool errorCategory = true;
            if (comboBoxCategory.SelectedIndex == -1) { labelErrorCategory.Text = "Please select an item"; }
            else { errorCategory = false; }
            labelErrorCategory.Visible = errorCategory;

            // Validate Price
            bool errorPrice = true;
            if (numericUpDownPrice.Value < 0) { labelErrorPrice.Text = "Please check the value again"; }
            else { errorPrice = false; }
            labelErrorPrice.Visible = errorPrice;

            // Validate Stock
            bool errorStock = true;
            if (numericUpDownStock.Value < 0) { labelErrorStock.Text = "Please check the value again"; }
            else { errorStock = false; }
            labelErrorStock.Visible = errorStock;

            // Success
            if (!errorName && !errorCategory && !errorPrice && !errorStock)
            {
                uint categoryId = Category.list[comboBoxCategory.SelectedIndex].id;
                uint stock = Convert.ToUInt32(numericUpDownStock.Value);
                Item.Add(categoryId, textBoxName.Text, numericUpDownPrice.Value, stock);
                formSub.Close();
            }

        }
        #endregion

    }
}
