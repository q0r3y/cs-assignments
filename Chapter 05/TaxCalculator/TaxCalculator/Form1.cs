using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{

    public class Income
    {
        private decimal income;
        public Income(decimal income)
        {
            this.income = income;
        }
        public decimal getIncome()
        {
            return this.income;
        }

        public bool between(int min, int max)
        {
            return this.income >= min && this.income <= max;
        }

        public decimal calcIncomeTax(int min, decimal percent, decimal baseAmount)
        {
            // Prevents -1 in the case of the first tax bracket
            int excessAmmount = (min > 0) ? min - 1 : min; 
            return (((this.income - excessAmmount) * (.01m * percent) + baseAmount));
        }

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
            Income inputIncome = new Income(Math.Round(Convert.ToDecimal(txtTaxableIncome.Text), 0));

            int tenPercentMin = 0, tenPercentMax = 9_875;
            int twelvePercentMin = 9_876, twelvePercentMax = 40_125;
            int twentyTwoPercentMin = 40_126, twentyTwoPercentMax = 85_525;
            int twentyFourPercentMin = 85_526, twentyFourPercentMax = 163_300;
            int thirtyTwoPercentMin = 163_301, thirtyTwoPercentMax = 207_350;
            int thirtyFivePercentMin = 207_351, thirtyFivePercentMax = 518_400;
            int thirtySevenPercentMin = 518_401;

            if (inputIncome.between(tenPercentMin, tenPercentMax))
            {
                txtTaxOwed.Text = inputIncome.calcIncomeTax(tenPercentMin, 10, 0).ToString();
            }
            else if (inputIncome.between(twelvePercentMin, twelvePercentMax))
            {
                txtTaxOwed.Text = inputIncome.calcIncomeTax(twelvePercentMin, 12, 987.50m).ToString();
            }
            else if (inputIncome.between(twentyTwoPercentMin, twentyTwoPercentMax))
            {
                txtTaxOwed.Text = inputIncome.calcIncomeTax(twentyTwoPercentMin, 22, 4617.50m).ToString();
            }
            else if (inputIncome.between(twentyFourPercentMin, twentyFourPercentMax))
            {
                txtTaxOwed.Text = inputIncome.calcIncomeTax(twentyFourPercentMin, 24, 14605.50m).ToString();
            } 
            else if (inputIncome.between(thirtyTwoPercentMin, thirtyTwoPercentMax))
            {
                txtTaxOwed.Text = inputIncome.calcIncomeTax(thirtyTwoPercentMin, 32, 33271.50m).ToString();
            }
            else if (inputIncome.between(thirtyFivePercentMin, thirtyFivePercentMax))
            {
                txtTaxOwed.Text = inputIncome.calcIncomeTax(thirtyFivePercentMin, 35, 47367.50m).ToString();
            }
            else if (inputIncome.getIncome() >= thirtySevenPercentMin) 
            {
                txtTaxOwed.Text = inputIncome.calcIncomeTax(thirtySevenPercentMin, 37, 156235).ToString();
            }
        }
    }
}
