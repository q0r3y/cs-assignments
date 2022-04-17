using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
        }

        List<InvItem> invItems = null;

        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            invItems = InvItemDB.GetItems();
            FillItemListBox();
        }

        private void FillItemListBox()
        {
            lstItems.Items.Clear();
            foreach (InvItem item in invItems)
            {
                lstItems.Items.Add(item.GetDisplayText);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewItem newItemForm = new frmNewItem();
            InvItem newItem = newItemForm.GetNewItem();

            if (newItem != null)
            {
                invItems.Add(newItem);
                InvItemDB.SaveItems(invItems);
                FillItemListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                invItems.RemoveAt(i);
                InvItemDB.SaveItems(invItems);
                FillItemListBox();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
