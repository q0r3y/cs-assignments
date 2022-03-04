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

            txtResult.Text = IsOperator(txtOperator.Text).ToString();

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
                MessageBox.Show(
                    "Invalid numeric format. Please check all entries.",
                    "Entry Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show(
                    "Overflow error. Please enter smaller values.",
                    "Entry Error");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show(
                    "Divide-by-zero error. Please enter a non-zero value for operand 2.",
                    "Entry Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }
        }

        /*
         *  I've decided to modify these functions to return bools
         *  instead of strings because usally functions that start 
         *  with "is" return a bool and it felt incorrect to have 
         *  them returning a string.
         *  
         *  Also the book functions were very "single use" in that
         *  they returned a specialized string that would only be
         *  used in one place. With the below modifications the 
         *  functions can be used in multiple places.
         */ 

        private bool IsOperator(string op)
        {
            return (op == "+" || op == "-" || op == "*" || op == "/");
        }

        private bool IsValidOperation(string op, decimal operand2)
        {
            return (!(op == "/" && operand2 == 0));
        }

        private bool IsPresent(string value)
        {
            return (value == "");
        }

        private bool IsDecimal(string value)
        {
            return (Decimal.TryParse(value, out _));
        }

        private bool IsWithinRange(string value, decimal min, decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {

                }
            }
            return false;
        }

        private bool IsValidData(string operand1, string operand2, string op)
        {
            int operandMin = 0;
            int operandMax = 1_000_000;
            string errorMessage = "";

            // (smooth) Operator
            if (!IsOperator(op)) 
                errorMessage += "Operator must be: + - * /";
           // if (IsValidOperation(op, operand2))

            // Operand 1
            if (!IsPresent(operand1)) 
                errorMessage += "Operand1 must be present.";
            if (!IsDecimal(operand1)) 
                errorMessage += "Operand1 must be a decimal value.";
            if (!IsWithinRange(operand1, operandMin, operandMax))
                errorMessage += "Operand1 must be between " + operandMin + " and " + operandMax;

            // Operand 2
            if (!IsPresent(operand2))
                errorMessage += "Operand2 must be present.";
            if (!IsDecimal(operand2))
                errorMessage += "Operand2 must be a decimal value.";
            if (!IsWithinRange(operand2, operandMin, operandMax))
                errorMessage += "Operand2 must be between " + operandMin + " and " + operandMax;



            errorMessage += IsWithinRange()
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
