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

        private void SetDecimalInputMode() {
            InputBox.Mode = DEC;
            btnDecimal.Enabled = true;
            btnSqrt.Enabled = true;
            btnRecip.Enabled = true;
            btnPosNeg.Enabled = true;
            InputBox.ClearState();
            OutputBox.ClearState();
        }

        private void SetDecimalOutputMode() {
            OutputBox.Mode = DEC;
            InputBox.ClearState();
            OutputBox.ClearState();
        }

        private void SetBinaryInputMode() {
            InputBox.Mode = BIN;
            btnDecimal.Enabled = false;
            btnSqrt.Enabled = false;
            btnRecip.Enabled = false;
            btnPosNeg.Enabled = false;
            InputBox.ClearState();
            OutputBox.ClearState();
        }

        private void SetBinaryOutputMode() {
            OutputBox.Mode = BIN;
            InputBox.ClearState();
            OutputBox.ClearState();
        }

        private void SetHexInputMode() {
            InputBox.Mode = HEX;
            btnDecimal.Enabled = false;
            btnSqrt.Enabled = false;
            btnRecip.Enabled = false;
            btnPosNeg.Enabled = false;
            InputBox.ClearState();
            OutputBox.ClearState();
        }

        private void SetHexOutputMode() {
            OutputBox.Mode = HEX;
            InputBox.ClearState();
            OutputBox.ClearState();
        }
    }
}