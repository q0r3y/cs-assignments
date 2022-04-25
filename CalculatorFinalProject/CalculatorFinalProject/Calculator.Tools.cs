using System.Data;

namespace CalculatorFinalProject {
    public partial class Calculator {

        private void HandleInput(string key) {
            if (InputBox.Text.Length < 10) {
                InputBox.HandleKey(key);
                OutputBox.HandleKey(key);
            }
        }

        private void HandleKeyPress(KeyPressEventArgs e) {
            e.Handled = true;
            if (isValidKey(e))
                HandleInput(e.KeyChar.ToString());
        }

        private void HandleCalculation() {
            try {
                string equation = InputBox.Text;
                string result = new DataTable().Compute(equation, null).ToString();
                InputBox.HandleValue(result);
                OutputBox.HandleValue(result);
                OutputBox.SetLastValidOp();
            }
            catch (Exception ex) {
                EnableErrorState();
                OutputBox.Text = ex.Message;
            }
        }

        private bool isValidKey(KeyPressEventArgs e) {
            bool validEntry = false;
            List<char> validKeys = InputBox.ValidKeys;
            foreach (char c in validKeys) {
                if (c == (e.KeyChar)) {
                    validEntry = true;
                    break;
                }
            }
            return validEntry;
        }
        private void ClearState() {
            if (ErrorState)
                DisableErrorState();
            InputBox.ClearState();
            OutputBox.ClearState();
        }

        private void EnableErrorState() {
            ErrorState = true;
            InputBox.TextBox.Enabled = false;
            btnBack.Visible = false;
            btnUndo.Visible = true;
            DeactivateButtons();
        }
        private void DeactivateButtons() {
            foreach (Control ctrl in pnlButtons.Controls) {
                if (ctrl.GetType() == typeof(Panel)) {
                    foreach (Control c in ctrl.Controls) {
                        if (c.GetType() == typeof(Button)) {
                            if (c.Name != "btnClear" &&
                                c.Name != "btnUndo")
                                c.Enabled = false;
                        }
                    }
                }
                if (ctrl.GetType() == typeof(Button)) {
                    if (ctrl.Name != "btnClear" &&
                        ctrl.Name != "btnUndo")
                        ctrl.Enabled = false;
                }
            }
        }
        private void DisableErrorState() {
            InputBox.TextBox.Enabled = true;
            btnBack.Visible = true;
            btnUndo.Visible = false;
            InputBox.RevertState();
            OutputBox.RevertState();
            ActivateButtons();
        }
        private void ActivateButtons() {
            foreach (Control ctrl in pnlButtons.Controls) {
                if (ctrl.GetType() == typeof(Panel)) {
                    foreach (Control c in ctrl.Controls) {
                        c.Enabled = true;
                    }
                }
                ctrl.Enabled = true;
            }
        }
        private void SetOutputModeDec() {
            OutputBox.Mode = "decimal";
            btnDivide.Enabled = true;
            btnDecimal.Enabled = true;
            btnSubtract.Enabled = true;
            InputBox.ValidKeys = new List<char> {
                '1','2','3','4','5','6','7','8','9','0',
                '/','*','+','-','.'
            };
            InputBox.ClearState();
            OutputBox.ClearState();
        }
        private void SetOutputModeBin() {
            OutputBox.Mode = "binary";
            btnDivide.Enabled = false;
            btnDecimal.Enabled = false;
            btnSubtract.Enabled = false;
            InputBox.ValidKeys = new List<char> {
                '1','2','3','4','5','6','7','8','9','0',
                '*','+'
            };
            InputBox.ClearState();
            OutputBox.ClearState();
        }
        private void SetOutputModeHex() {
            OutputBox.Mode = "hexidecimal";
            btnDivide.Enabled = false;
            btnDecimal.Enabled = false;
            btnSubtract.Enabled = false;
            InputBox.ValidKeys = new List<char> {
                '1','2','3','4','5','6','7','8','9','0',
                '*','+'
            };
            InputBox.ClearState();
            OutputBox.ClearState();
        }
    }
}