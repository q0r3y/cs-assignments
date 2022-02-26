using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal operandOne = Convert.ToDecimal(txtOperandOne.Text);
            decimal operandTwo = Convert.ToDecimal(txtOperandTwo.Text);
            string operatorOne = txtOperator.Text;
            decimal result = Calculate(operandOne, operatorOne, operandTwo);
            txtResult.Text = result.ToString("n4");
            txtOperandOne.Focus();
        }

        private decimal Calculate(decimal operandOne, string operatorOne, decimal operandTwo)
        {
            if (operatorOne == "+")
            {
                return operandOne + operandTwo;
            }
            else if (operatorOne == "-")
            {
                return operandOne - operandTwo;
            }
            else if (operatorOne == "*")
            {
                return operandOne * operandTwo;
            }
            else if (operatorOne == "/")
            {
                return operandOne / operandTwo;
            }
            else
            {
                return 0;
            }
        }

        private void clearResultTextBox(object sender, EventArgs e)
        {
            txtResult.Clear();
        }
    }
}
