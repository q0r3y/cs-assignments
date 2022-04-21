using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFinalProject {
    public partial class Calculator {

        private void HandleInput(string key) {
            EntryBox.HandleKey(key);
            HistoryBox.HandleKey(key);
            EntryBox.TextBox.Focus();
            EntryBox.TextBox.SelectionStart = EntryBox.Text.Length;
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

    }
}