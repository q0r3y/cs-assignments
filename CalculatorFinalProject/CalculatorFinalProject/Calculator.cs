using System.Data;

namespace CalculatorFinalProject {
    public partial class Calculator : Form {
        private string mode = "decimal";
        private bool errorState = false;
        private string lastResult = "";
        private string lastOperation = "";
        private string lastNumber = "";
        public Calculator() {
            InitializeComponent();
        }

        private void setErrorState(string msg) {
            errorState = true;
            txtHistoryBox.Text = msg;
            txtResult.Enabled = false;
            btnBack.Visible = false;
            btnUndo.Visible = true;
            foreach (Button button in pnlButtons.Controls) {
                if (button.Name != "btnClear" &&
                    button.Name != "btnUndo")
                    button.Enabled = false;
            }
        }

        private void clearErrorState() {
            errorState = false;
            txtResult.Enabled = true;
            btnBack.Visible = true;
            btnUndo.Visible = false;
            foreach (Button button in pnlButtons.Controls) {
                button.Enabled = true;
            }
        }

        // Need to fix decimal on bin and hex
        private void txtResult_KeyPress(object sender, KeyPressEventArgs e) {
            if (!isValidKey(e)) {
                e.Handled = true;
            }
            else {
                if (mode == "decimal") {
                    txtHistoryBox.Text += e.KeyChar.ToString();
                }
                else if (mode == "binary") {
                    displayBinary(e.KeyChar.ToString());
                    //txtHistoryBox.Text += e.KeyChar.ToString();
                }
                else if (mode == "hex") {
                    txtHistoryBox.Text += e.KeyChar.ToString();
                }
            }
        }

        private void displayBinary(string input) {
            if (int.TryParse(input, out _)) {
                int num = Convert.ToInt32(lastNumber + input);
                txtHistoryBox.Text = Convert.ToString(num, 2);
                lastNumber = num.ToString();
            } else {
                lastNumber = "";
                txtHistoryBox.Text += input;
            }
        }

        private bool isValidKey(KeyPressEventArgs e) {
            bool validEntry = false;
            char[] validKeys = {
                '1','2','3','4','5','6','7','8','9','0',
                '/','*','+','-','.','(',')'
            };

            foreach (char c in validKeys) {
                if (c == (e.KeyChar)) {
                    validEntry = true;
                    break;
                }
            }
            return validEntry;
        }

        private void clearTextBoxes() {
            txtResult.Clear();
            txtHistoryBox.Clear();
        }

        private void rdoDecimal_CheckedChanged(object sender, EventArgs e) {
            clearTextBoxes();
            // Convert Result box and display box to decimal
            btnDecimal.Enabled = true;
            mode = "decimal";
        }

        private void rdoBinary_CheckedChanged(object sender, EventArgs e) {
            clearTextBoxes();
            // Convert Result box and display box to binary
            btnDecimal.Enabled = false;
            mode = "binary";
        }

        private void rdoHex_CheckedChanged(object sender, EventArgs e) {
            clearTextBoxes();
            // Convert Result box and display box to hex
            btnDecimal.Enabled = false;
            mode = "hex";
        }

        private string convertBases(string number, int toBase) {
            int fromBase = 10;
            if (mode == "decimal") {
                fromBase = 10;
            } 
            else if (mode == "binary") {
                fromBase = 2;
            }
            else if (mode == "hex") {
                fromBase = 16;
            }
            return Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
        }

        private void btnEquals_Click(object sender, EventArgs e) {
            try {
                string equation = txtResult.Text;
                string result = new DataTable().Compute(equation, null).ToString();
                if (mode == "hex") {
                    convertBases(result, 16);
                }
                else if (mode == "binary") {
                    convertBases(result, 2);
                }
                txtResult.Text = result.ToString();
                lastResult = result.ToString();
                lastOperation = txtHistoryBox.Text;
            }
            catch (Exception ex) {
                setErrorState(ex.Message);
            }

            handleButtonClick("");
        }

        private void handleButtonClick(string buttonText) {
            if (mode == "decimal") {
                txtHistoryBox.Text += buttonText;
            }
            else if (mode == "binary") {
                displayBinary(buttonText);
            }
            else if (mode == "hex") {
                txtHistoryBox.Text += buttonText;
            }
            txtResult.Text += buttonText;
            txtResult.Focus();
            txtResult.SelectionStart = txtResult.Text.Length;
        }

        private void btnClear_Click(object sender, EventArgs e) {
            lastResult = "";
            lastOperation = "";
            if (errorState)
                clearErrorState();
            clearTextBoxes();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            string resultText = txtResult.Text;
            txtHistoryBox.Text = "";

            if (resultText.Length > 0)
                txtResult.Text = resultText.Remove(resultText.Length - 1, 1);

            txtHistoryBox.Text = txtResult.Text;
        }

        private void btnUndo_Click(object sender, EventArgs e) {
            txtHistoryBox.Text = lastOperation;
            txtResult.Text = lastResult;
            clearErrorState();
        }

        private void Calculator_Load(object sender, EventArgs e)
        => rdoDecimal.Checked = true;
        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        => txtResult.Focus();
        private void btn1_Click(object sender, EventArgs e) => handleButtonClick("1");
        private void btn2_Click(object sender, EventArgs e) => handleButtonClick("2");
        private void btn3_Click(object sender, EventArgs e) => handleButtonClick("3");
        private void btn4_Click(object sender, EventArgs e) => handleButtonClick("4");
        private void btn5_Click(object sender, EventArgs e) => handleButtonClick("5");
        private void btn6_Click(object sender, EventArgs e) => handleButtonClick("6");
        private void btn7_Click(object sender, EventArgs e) => handleButtonClick("7");
        private void btn8_Click(object sender, EventArgs e) => handleButtonClick("8");
        private void btn9_Click(object sender, EventArgs e) => handleButtonClick("9");
        private void btn0_Click(object sender, EventArgs e) => handleButtonClick("0");
        private void btnDecimal_Click(object sender, EventArgs e) => handleButtonClick(".");
        private void btnAdd_Click(object sender, EventArgs e) => handleButtonClick("+");
        private void btnSubtract_Click(object sender, EventArgs e) => handleButtonClick("-");
        private void btnMultiply_Click(object sender, EventArgs e) => handleButtonClick("*");
        private void btnDivide_Click(object sender, EventArgs e) => handleButtonClick("/");
    }
}