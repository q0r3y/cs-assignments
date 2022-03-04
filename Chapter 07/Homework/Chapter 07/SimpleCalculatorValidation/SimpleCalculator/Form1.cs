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
                if (IsValidData())
                {
                    decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
                    string operator1 = txtOperator.Text;
                    decimal operand2 = Convert.ToDecimal(txtOperand2.Text);
                    decimal result = Calculate(operand1, operator1, operand2);

                    result = Math.Round(result, 4);
                    this.txtResult.Text = result.ToString();
                    txtOperand1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }
        }

        private string IsPresent(string value, string name)
        {
            return (value == "" ? name + " must be present.\n" : "");
        }

        private string IsOperator(string op)
        {
            bool isOperator = (op == "+" || op == "-" || op == "*" || op == "/");
            return (isOperator ? "" : "Operator must be: + - * /\n");
        }

        private string IsDecimal(string value, string name)
        {
            bool isDecimal = Decimal.TryParse(value, out _);
            return (isDecimal ? "" : name + " must be a valid decimal value.\n");
        }

        private string IsValidOperation(string op, string operand2)
        {
            string msg = "";
            if (Decimal.TryParse(operand2, out decimal number) && (op == "/" && number == 0))
                msg += "Cannot divide by zero. Change operand2.\n";
            return msg;
        }

        private string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number) && (number < min || number > max))
                msg += name + " must be between " + min + " and " + max + ".\n";
            return msg;
        }

        private bool IsValidData()
        {
            int operandMin = 0;
            int operandMax = 1_000_000;
            bool success = true;
            string errorMessage = "";
            string operand1Name = txtOperand1.Tag.ToString();
            string operand2Name = txtOperand2.Tag.ToString();

            // Operand 1
            errorMessage += IsPresent(txtOperand1.Text, operand1Name);
            errorMessage += IsDecimal(txtOperand1.Text, operand1Name);
            errorMessage += IsWithinRange(txtOperand1.Text, operand1Name, 
                operandMin, operandMax);

            // Operator
            errorMessage += IsPresent(txtOperator.Text, txtOperator.Tag.ToString());
            errorMessage += IsOperator(txtOperator.Text);
            
            // Operand 2
            errorMessage += IsPresent(txtOperand2.Text, operand2Name);
            errorMessage += IsDecimal(txtOperand2.Text, operand2Name);
            errorMessage += IsValidOperation(txtOperator.Text, txtOperand2.Text);
            errorMessage += IsWithinRange(txtOperand2.Text, operand2Name,
                operandMin, operandMax);

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
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
