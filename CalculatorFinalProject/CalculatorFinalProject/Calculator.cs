namespace CalculatorFinalProject
{
    public partial class Calculator : Form
    {
        private string mode = "decimal";
        private bool errorState = false;
        private string lastOperation = "";
        private List<Control> buttons = new List<Control>();
        
        public Calculator()
        {
            InitializeComponent();
            addButtonsToList();
        }

        private void addButtonsToList()
        {
            foreach (Button button in pnlButtons.Controls)
            {
                buttons.Add(button);
            }
        }

        private void setErrorState(string msg)
        {
            string[] err = msg.Split(":");
            errorState = true;
            txtResult.Text = err[0];
            txtDisplayBox.Text = err[1];
            txtResult.Enabled = false;
            foreach (Button button in buttons)
            {
                if (button.Name != "btnClear" && 
                    button.Name != "btnBack")
                    button.Enabled = false;
            }
        }

        private void clearErrorState()
        {
            errorState = false;
            txtResult.Enabled = true;
            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }
        }

        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isValidKey(e))
            {
                e.Handled = true;
            }
            else
            {
                if (mode == "decimal")
                {
                    txtDisplayBox.Text += e.KeyChar.ToString();
                }
                else if (mode == "binary")
                {
                    txtDisplayBox.Text += e.KeyChar.ToString();
                }
                else if (mode == "hex")
                {
                    txtDisplayBox.Text += e.KeyChar.ToString();
                }
            }
        }

        private bool isValidKey(KeyPressEventArgs e)
        {
            bool validEntry = false;
            char[] validKeys =
            {
                '1','2','3','4','5','6','7','8','9','0',
                '/','*','+','-','.','(',')'
            };

            foreach (char c in validKeys)
            {
                if (c == (e.KeyChar))
                {
                    validEntry = true;
                    break;
                }
            }
            return validEntry;
        }

        private void clearTextBoxes()
        {
            txtResult.Clear();
            txtDisplayBox.Clear();
        }

        private void rdoDecimal_CheckedChanged(object sender, EventArgs e)
        {
            //clearTextBoxes();
            mode = "decimal";
        }

        private void rdoBinary_CheckedChanged(object sender, EventArgs e)
        {
            //clearTextBoxes();
            mode = "binary";
        }

        private void rdoHex_CheckedChanged(object sender, EventArgs e)
        {
            //clearTextBoxes();
            mode = "hex";
        }

        private void Calculator_Load(object sender, EventArgs e)
        => rdoDecimal.Checked = true;
        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        => txtResult.Focus();
    }
}