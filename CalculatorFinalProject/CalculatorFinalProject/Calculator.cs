using System.Data;

namespace CalculatorFinalProject
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            rdoDecimal.Checked = true;
            
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            string equation = txtResult.Text;
            string ?result = new DataTable().Compute(equation, null).ToString();
            txtResult.Text = result;
            txtResult.Focus();
            txtResult.SelectionStart = txtResult.Text.Length;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearResultBox();
        }

        private void clearResultBox()
        {
            txtResult.Text = "";
            txtResult.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtResult.Text += ".";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtResult.Text += "+";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            txtResult.Text += "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtResult.Text += "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtResult.Text += "/";
        }

        private void rdoDecimal_CheckedChanged(object sender, EventArgs e)
        {
            clearResultBox();
        }

        private void rdoBinary_CheckedChanged(object sender, EventArgs e)
        {
            clearResultBox();
        }

        private void rdoHex_CheckedChanged(object sender, EventArgs e)
        {
            clearResultBox();
        }

        private void txtResult_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                e.Handled = true;
            }
        }
    }
}