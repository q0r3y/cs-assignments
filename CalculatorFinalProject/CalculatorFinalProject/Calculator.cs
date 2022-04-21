using System.Data;

namespace CalculatorFinalProject {
    public partial class Calculator : Form {

        private bool errorState = false;
        private string lastResult = "";
        private string lastOperation = "";
        private string lastNumber = "";
        CalcBox HistoryBox;
        CalcBox EntryBox;

        public Calculator() {
            InitializeComponent();
            EntryBox = new CalcBox(ref txtEntryBox);
            HistoryBox = new CalcBox(ref txtHistoryBox);
        }

        private void setErrorState(string msg) {
            errorState = true;
            HistoryBox.Text = msg;
            EntryBox.Box.Enabled = false;
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
            EntryBox.Box.Enabled = true;
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
                if (EntryBox.Mode == "decimal") {
                    HistoryBox.Text += e.KeyChar.ToString();
                }
                else if (EntryBox.Mode == "binary") {
                    displayBinary(e.KeyChar.ToString());
                    //txtHistoryBox.Text += e.KeyChar.ToString();
                }
                else if (EntryBox.Mode == "hex") {
                    HistoryBox.Text += e.KeyChar.ToString();
                }
            }
        }

        private void displayBinary(string input) {
            if (int.TryParse(input, out _)) {
                int num = Convert.ToInt32(lastNumber + input);
                HistoryBox.Text = Convert.ToString(num, 2);
                lastNumber = num.ToString();
            }
            else {
                lastNumber = "";
                HistoryBox.Text += input;
            }
        }

        private bool isValidKey(KeyPressEventArgs e) {
            bool validEntry = false;
            List<char> validKeys = EntryBox.CurrentMode.ValidKeys;
            foreach (char c in validKeys) {
                if (c == (e.KeyChar)) {
                    validEntry = true;
                    break;
                }
            }
            return validEntry;
        }

        private void clearTextBoxes() {
            EntryBox.Text = "";
            HistoryBox.Text = "";
        }



        private string convertBases(string number, int toBase) {
            int fromBase = 10;
            if (EntryBox.Mode == "decimal") {
                fromBase = 10;
            }
            else if (EntryBox.Mode == "binary") {
                fromBase = 2;
            }
            else if (EntryBox.Mode == "hex") {
                fromBase = 16;
            }
            return Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
        }

        private void btnEquals_Click(object sender, EventArgs e) {
            try {
                string equation = EntryBox.Text;
                string result = new DataTable().Compute(equation, null).ToString();
                if (EntryBox.Mode == "hex") {
                    convertBases(result, 16);
                }
                else if (EntryBox.Mode == "binary") {
                    convertBases(result, 2);
                }
                EntryBox.Text = result.ToString();
                lastResult = result.ToString();
                lastOperation = HistoryBox.Text;
            }
            catch (Exception ex) {
                setErrorState(ex.Message);
            }

            handleButtonClick("");
        }

        private void handleButtonClick(string buttonText) {
            if (EntryBox.Mode == "decimal") {
                HistoryBox.Text += buttonText;
            }
            else if (EntryBox.Mode == "binary") {
                displayBinary(buttonText);
            }
            else if (EntryBox.Mode == "hex") {
                HistoryBox.Text += buttonText;
            }
            EntryBox.Text += buttonText;
            EntryBox.Box.Focus();
            EntryBox.Box.SelectionStart = EntryBox.Text.Length;
        }

        private void btnClear_Click(object sender, EventArgs e) {
            lastResult = "";
            lastOperation = "";
            if (errorState)
                clearErrorState();
            clearTextBoxes();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            string entryText = EntryBox.Text;
            HistoryBox.Text = "";

            if (entryText.Length > 0)
                EntryBox.Text = entryText.Remove(entryText.Length - 1, 1);

            HistoryBox.Text = EntryBox.Text;
        }

        private void btnUndo_Click(object sender, EventArgs e) {
            HistoryBox.Text = lastOperation;
            EntryBox.Text = lastResult;
            clearErrorState();
        }
        private void rdoTopDecimal_CheckedChanged(object sender, EventArgs e) {
            //clearTextBoxes();
            HistoryBox.Mode = "decimal";
        }
        private void rdoTopBinary_CheckedChanged(object sender, EventArgs e) {
            //clearTextBoxes();
            HistoryBox.Mode = "binary";
        }
        private void rdoTopHex_CheckedChanged(object sender, EventArgs e) {
            //clearTextBoxes();
            HistoryBox.Mode = "hex";
        }
        private void rdoBottomDec_CheckedChanged(object sender, EventArgs e) {
            btnDecimal.Enabled = true;
            EntryBox.Mode = "decimal";
        }
        private void rdoBottomBin_CheckedChanged(object sender, EventArgs e) {
            btnDecimal.Enabled = false;
            EntryBox.Mode = "binary";
        }
        private void rdoBottomHex_CheckedChanged(object sender, EventArgs e) {
            btnDecimal.Enabled = false;
            EntryBox.Mode = "hex";
        }
        private void Calculator_Load(object sender, EventArgs e)
        => rdoTopDec.Checked = true;
        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        => EntryBox.Box.Focus();
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