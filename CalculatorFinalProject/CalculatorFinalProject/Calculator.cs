using System.Data;

namespace CalculatorFinalProject {
    public partial class Calculator : Form {

        InputBox InputBox;
        OutputBox OutputBox;
        bool ErrorState = false;

        public Calculator() {
            InitializeComponent();
            InputBox = new InputBox(ref txtInputBox);
            OutputBox = new OutputBox(ref txtOutputBox);
        }
        private void Calculator_Load(object sender, EventArgs e) {
            rdoOutputDec.Checked = true;
        }

        private void txtEntryBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
            if (isValidKey(e)) {
                HandleInput(e.KeyChar.ToString());
            }
        }
        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
            => InputBox.TextBox.Focus();
        private void rdoTopDec_CheckedChanged(object sender, EventArgs e)
            => SetOutputModeDec();
        private void rdoTopBin_CheckedChanged(object sender, EventArgs e)
            => SetOutputModeBin();
        private void rdoTopHex_CheckedChanged(object sender, EventArgs e)
            => SetOutputModeHex();
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
            if (ErrorState)
                DisableErrorState();
            InputBox.ClearState();
            OutputBox.ClearState();
        }
        private void btnEquals_Click(object sender, EventArgs e) {
            try {
                string equation = InputBox.Text;
                string ?result = new DataTable().Compute(equation, null).ToString();
                InputBox.Text = result;
                InputBox.LastValue = result;
                InputBox.TextBox.Focus();
                InputBox.TextBox.SelectionStart = InputBox.Text.Length;
                OutputBox.SetResultText(result);
                OutputBox.LastValidOperation.Clear();
                foreach (string s in OutputBox.LastOperation)
                    OutputBox.LastValidOperation.Add(s);
            }
            catch (Exception ex) {
                EnableErrorState();
                OutputBox.Text = ex.Message;
            }
        }
        private void btnUndo_Click(object sender, EventArgs e) {
            OutputBox.Text = "";
            OutputBox.LastOperation.Clear();
            InputBox.Text = InputBox.LastValue;
            foreach (string s in OutputBox.LastValidOperation) {
                OutputBox.Text += s;
                OutputBox.LastOperation.Add(s);
            }
            DisableErrorState();     
        }
    }
}