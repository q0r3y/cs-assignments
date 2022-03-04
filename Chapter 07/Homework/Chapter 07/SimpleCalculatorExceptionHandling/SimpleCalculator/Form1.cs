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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
                string operator1 = txtOperator.Text;
                decimal operand2 = Convert.ToDecimal(txtOperand2.Text);
                decimal result = Calculate(operand1, operator1, operand2);

                result = Math.Round(result, 4);
                this.txtResult.Text = result.ToString();
                txtOperand1.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("FormatException. Operands may only contain numbers.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("OverflowException. Please use smaller numbers.");

            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("You cannot divide by zero. Please change operand 2.");
                txtOperand2.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message + "\n\n" + 
                    ex.GetType().ToString() + "\n\n" + 
                    ex.StackTrace);
            }
        }

        private decimal Calculate(decimal operand1, string operator1,
            decimal operand2)
        {
            decimal result = 0;
            if (operator1 == "+")
                result = operand1 + operand2;
            else if (operator1 == "-")
                result = operand1 - operand2;
            else if (operator1 == "*")
                result = operand1 * operand2;
            else if (operator1 == "/")
                result = operand1 / operand2;
            return result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearResult(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
        }
    }
}
