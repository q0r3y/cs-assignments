using System.Data;

namespace CalculatorFinalProject {
    public partial class Calculator : Form {

        DisplayBox InputBox;
        OutputBox OutputBox;
        const string BIN = "binary";
        const string DEC = "decimal";
        const string HEX = "hexidecimal";
        public Calculator() {
            InitializeComponent();
            InputBox = new DisplayBox(ref txtInputBox);
            OutputBox = new OutputBox(ref txtOutputBox);
        }
        private void Calculator_Load(object sender, EventArgs e) {
            rdoOutputDec.Checked = true;
            rdoInputDec.Checked = true;
        }
        private void txtEntryBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
            if (isValidKey(e)) {
                HandleInput(e.KeyChar.ToString());
            }
        }
        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
            => InputBox.TextBox.Focus();
        private void rdoBottomDec_CheckedChanged(object sender, EventArgs e)
            => SetDecimalInputMode();
        private void rdoBottomBin_CheckedChanged(object sender, EventArgs e)
            => SetBinaryInputMode();
        private void rdoBottomHex_CheckedChanged(object sender, EventArgs e)
            => SetHexInputMode();
        private void rdoTopDec_CheckedChanged(object sender, EventArgs e)
            => SetDecimalOutputMode();
        private void rdoTopBin_CheckedChanged(object sender, EventArgs e)
            => OutputBox.Mode = BIN;
        private void rdoTopHex_CheckedChanged(object sender, EventArgs e)
            => OutputBox.Mode = HEX;
        private void btn1_Click(object sender, EventArgs e) => HandleInput("1");
        private void btn2_Click(object sender, EventArgs e) => HandleInput("2");
        private void btn3_Click(object sender, EventArgs e) => HandleInput("3");
        private void btn4_Click(object sender, EventArgs e) => HandleInput("4");
        private void btn5_Click(object sender, EventArgs e) => HandleInput("5");
        private void btn6_Click(object sender, EventArgs e) => HandleInput("6");
        private void btn7_Click(object sender, EventArgs e) => HandleInput("7");
        private void btn8_Click(object sender, EventArgs e) => HandleInput("8");
        private void btn9_Click(object sender, EventArgs e) => HandleInput("9");
        private void btn0_Click(object sender, EventArgs e) => HandleInput("0");
        private void btnDecimal_Click(object sender, EventArgs e) => HandleInput(".");
        private void btnAdd_Click(object sender, EventArgs e) => HandleInput("+");
        private void btnSubtract_Click(object sender, EventArgs e) => HandleInput("-");
        private void btnMultiply_Click(object sender, EventArgs e) => HandleInput("*");
        private void btnDivide_Click(object sender, EventArgs e) => HandleInput("/");
        private void btnClear_Click(object sender, EventArgs e) {
            InputBox.ClearState();
            OutputBox.ClearState();
        }
    }
}