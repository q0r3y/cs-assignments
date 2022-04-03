using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearTotals()
        {
            txtOrderTotal.Clear();
            txtSalesTax.Clear();
            txtSubtotal.Clear();
        }

        private void ClearAddOns()
        {
            cboAddOn1.Checked = false;
            cboAddOn2.Checked = false;
            cboAddOn3.Checked = false;
        }

        private void rdoHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHamburger.Checked)
            {
                ClearAddOns();
                ClearTotals();
                gbxAddOns.Text = "Add-on Items ($.75/each)";
                cboAddOn1.Text = "Lettuce, Tomator, and Onions";
                cboAddOn2.Text = "Ketchup, Mustard, and Mayo";
                cboAddOn3.Text = "French Fries";
            }
        }

        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPizza.Checked)
            {
                ClearAddOns();
                ClearTotals();
                gbxAddOns.Text = "Add-on Items ($.50/each)";
                cboAddOn1.Text = "Pepperoni";
                cboAddOn2.Text = "Sausage";
                cboAddOn3.Text = "Olives";
            }
        }

        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSalad.Checked)
            {
                ClearAddOns();
                ClearTotals();
                gbxAddOns.Text = "Add-on Items ($.25/each)";
                cboAddOn1.Text = "Croutons";
                cboAddOn2.Text = "Bacon Bits";
                cboAddOn3.Text = "Bread Sticks";
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0m, salesTax = 0.0775m;
            decimal hamburgerCost = 6.95m, hamburgerExtra = 0.75m;
            decimal pizzaCost = 5.95m, pizzaExtra = 0.50m;
            decimal saladCost = 4.95m, saladExtra = 0.25m;

            decimal getExtraTotal(decimal extraCost)
            {
                decimal sum = 0m;
                if (cboAddOn1.Checked)
                    sum += extraCost;
                if (cboAddOn2.Checked)
                    sum += extraCost;
                if (cboAddOn3.Checked)
                    sum += extraCost;
                return sum;
            }

            if (rdoHamburger.Checked)
                subtotal = hamburgerCost + getExtraTotal(hamburgerExtra);
            if (rdoPizza.Checked)
                subtotal = pizzaCost + getExtraTotal(pizzaExtra);
            if (rdoSalad.Checked)
                subtotal = saladCost + getExtraTotal(saladExtra);

            decimal total = (subtotal * (salesTax + 1));

            txtSubtotal.Text = subtotal.ToString("C");
            txtSalesTax.Text = (subtotal * salesTax).ToString("C");
            txtOrderTotal.Text = total.ToString("C");
        }

        private void cboAddOn1_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }

        private void cboAddOn2_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }

        private void cboAddOn3_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }
    }
}
