using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChangeCalculator
{
    enum Coin
    {
        QUARTER = 25,
        DIME = 10,
        NICKEL = 5,
        PENNY = 1
    }

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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int changeDue = Convert.ToInt32(txtChangeDue.Text);

            int quarters = changeDue / (int)Coin.QUARTER;
            changeDue %= (int)Coin.QUARTER;
            int dimes = changeDue / (int)Coin.DIME;
            changeDue %= (int)Coin.DIME;
            int nickels = changeDue / (int)Coin.NICKEL;
            changeDue %= (int)Coin.NICKEL;
            int pennies = changeDue / (int)Coin.PENNY;

            txtQuarters.Text = quarters.ToString();
            txtDimes.Text = dimes.ToString();
            txtNickels.Text = nickels.ToString();
            txtPennies.Text = pennies.ToString();

        }
    }
}
