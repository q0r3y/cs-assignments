using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFinalProject {
    public partial class Calculator {

        private void HandleInput(string key) {
            InputBox.HandleKey(key);
            OutputBox.HandleKey(key);
            InputBox.TextBox.Focus();
            InputBox.TextBox.SelectionStart = InputBox.Text.Length;
        }
        private bool isValidKey(KeyPressEventArgs e) {
            bool validEntry = false;
            List<char> validKeys = InputBox.CurrentMode.ValidKeys;
            foreach (char c in validKeys) {
                if (c == (e.KeyChar)) {
                    validEntry = true;
                    break;
                }
            }
            return validEntry;
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
            InputBox.TextBox.Focus();
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

        private void SetDecimalInputMode() {
            InputBox.Mode = DEC;
            SetActiveInputButtons();
/*            btnDecimal.Enabled = true;
            btnSqrt.Enabled = true;
            btnRecip.Enabled = true;
            btnPosNeg.Enabled = true;*/
            InputBox.ClearState();
            OutputBox.ClearState();
        }

        private void SetBinaryInputMode() {
            InputBox.Mode = BIN;
            SetActiveInputButtons();
/*            btnDecimal.Enabled = false;
            btnSqrt.Enabled = false;
            btnRecip.Enabled = false;
            btnPosNeg.Enabled = false;*/
            InputBox.ClearState();
            OutputBox.ClearState();
        }

        private void SetHexInputMode() {
            InputBox.Mode = HEX;
            SetActiveInputButtons();
/*            btnDecimal.Enabled = false;
            btnSqrt.Enabled = false;
            btnRecip.Enabled = false;
            btnPosNeg.Enabled = false;*/
            InputBox.ClearState();
            OutputBox.ClearState();
        }

        private void SetActiveInputButtons() {
            List<char> validKeys = InputBox.CurrentMode.ValidKeys;
            foreach (Button b in pnlNumbers.Controls) {
                bool valid = false;
                foreach (char k in validKeys) {
                    if (b.Text == k.ToString())
                        valid = true;
                }
                if (!valid) {
                    b.Enabled = false;
                }
                else {
                    b.Enabled = true;
                }
            }
        }

        private void SetOutputModeDec() {
            OutputBox.Mode = DEC;
            InputBox.ClearState();
            OutputBox.ClearState();
        }

        private void SetOutputModeBin() {
            OutputBox.Mode = BIN;
            InputBox.ClearState();
            OutputBox.ClearState();
        }

        private void SetOutputModeHex() {
            OutputBox.Mode = HEX;
            InputBox.ClearState();
            OutputBox.ClearState();
        }
    }
}