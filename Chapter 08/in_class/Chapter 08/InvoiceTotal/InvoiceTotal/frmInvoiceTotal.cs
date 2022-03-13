﻿using System;
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

        int index = 0;
        decimal[] totalsArr = new decimal[5];

        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtSubtotal.Text == "")
                {
                    MessageBox.Show(
                        "Subtotal is a required field.", "Entry Error");
                }
                else
                {
                    decimal subtotal = Decimal.Parse(txtSubtotal.Text);
                    if (subtotal > 0 && subtotal < 10000)
                    {
                        decimal discountPercent = 0m;
                        if (subtotal >= 500)
                            discountPercent = .2m;
                        else if (subtotal >= 250 & subtotal < 500)
                            discountPercent = .15m;
                        else if (subtotal >= 100 & subtotal < 250)
                            discountPercent = .1m;
                        decimal discountAmount = subtotal * discountPercent;
                        decimal invoiceTotal = subtotal - discountAmount;

                        discountAmount = Math.Round(discountAmount, 2);
                        invoiceTotal = Math.Round(invoiceTotal, 2);

                        txtDiscountPercent.Text = discountPercent.ToString("p1");
                        txtDiscountAmount.Text = discountAmount.ToString();
                        txtTotal.Text = invoiceTotal.ToString();

                        totalsArr[index] = invoiceTotal;
                        index++;
                    }
                    else
                    {
                        MessageBox.Show(
                            "Subtotal must be greater than 0 and less than 10,000.",
                            "Entry Error");
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show ("The total's index is full.", "Entry Error");
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter a valid number for the Subtotal field.",
                    "Entry Error");
            }
            txtSubtotal.Focus();
        }

        private void showTotals()
        {
            string totalsString = "";

            Array.Sort(totalsArr);

            foreach (decimal total in totalsArr)
            {
                if (total != 0)
                {
                    totalsString += total.ToString("C") + "\n";
                }
            }

            MessageBox.Show(totalsString, "Order Totals - Array");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // TODO: add code that displays dialog boxes here
            showTotals();
            this.Close();
        }

    }
}
