using System.Data;

namespace CalculatorFinalProject {
    public partial class Calculator : Form {

        DisplayBox EntryBox;
        HistoryBox HistoryBox;
        const string BIN = "binary";
        const string DEC = "decimal";
        const string hex = "hexidecimal";

        public Calculator() {
            InitializeComponent();
            EntryBox = new DisplayBox(ref txtEntryBox);
            HistoryBox = new HistoryBox(ref txtHistoryBox);
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        => EntryBox.TextBox.Focus();
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

        private void rdoTopDec_CheckedChanged(object sender, EventArgs e) {
            HistoryBox.Mode = DEC;
        }

        private void rdoTopBin_CheckedChanged(object sender, EventArgs e) {
            HistoryBox.Mode = BIN;
        }

        private void rdoTopHex_CheckedChanged(object sender, EventArgs e) {
            HistoryBox.Mode = hex;
        }

        private void rdoBottomDec_CheckedChanged(object sender, EventArgs e) {
            EntryBox.Mode = DEC;
        }

        private void rdoBottomBin_CheckedChanged(object sender, EventArgs e) {
            EntryBox.Mode = BIN;
        }

        private void rdoBottomHex_CheckedChanged(object sender, EventArgs e) {
            EntryBox.Mode = hex;
        }

        private void Calculator_Load(object sender, EventArgs e) {
            rdoTopDec.Checked = true;
            rdoBottomDec.Checked = true;
        }

        private void txtEntryBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (isValidKey(e)) {
                e.Handled = true;
                HandleInput(e.KeyChar.ToString());
            } else {
                e.Handled = true;
            }
        }
    }
}