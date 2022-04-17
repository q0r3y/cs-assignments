using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmNewItem : Form
    {
        public frmNewItem()
        {
            InitializeComponent();
        }

        InvItem item = null;

        public InvItem GetNewItem()
        {
            this.ShowDialog();
            return item;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                int itemNo = int.Parse(txtItemNo.Text);
                decimal price = decimal.Parse(txtPrice.Text);
                item = new InvItem(itemNo, txtDescription.Text, price);
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtItemNo) &&
                   Validator.IsInt32(txtItemNo) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtPrice) &&
                   Validator.IsDecimal(txtPrice);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
