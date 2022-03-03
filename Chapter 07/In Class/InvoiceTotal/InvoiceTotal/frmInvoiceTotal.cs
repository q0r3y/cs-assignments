using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
	public partial class frmInvoiceTotal : Form
	{
        public frmInvoiceTotal()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			try
            {
				if (txtSubtotal.Text != "")
                {
					decimal subtotal = Decimal.Parse(txtSubtotal.Text);
					if (subtotal > 0 && subtotal < 10000)
                    {
						decimal discountPercent = .25m;
						decimal discountAmount = subtotal * discountPercent;
						decimal invoiceTotal = subtotal - discountAmount;

						discountAmount = Math.Round(discountAmount, 2);
						invoiceTotal = Math.Round(invoiceTotal, 2);

						txtDiscountPercent.Text = discountPercent.ToString("p1");
						txtDiscountAmount.Text = discountAmount.ToString();
						txtTotal.Text = invoiceTotal.ToString();

						txtSubtotal.Focus();
					}
					else
                    {
						MessageBox.Show("Subtotal should be in between 0 and 10,000");
					}

				} 
				else
                {
					MessageBox.Show("Subtotal is a required field. Please enter a value.");
				}

			}
			catch (Exception)
            {
				MessageBox.Show("Please enter a valid number for the Subtotal field.");
            }

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}