using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFinalProject {
    public class HistoryBox : DisplayBox {

        private string _CurrentNumber = "";
        public List<string> LastOperation;

        public HistoryBox(ref TextBox TextBox) : base(ref TextBox) {
            this.TextBox = TextBox;
            LastOperation = new List<string>() { "" };
        }

        public new void HandleKey(string key) {
            if (int.TryParse(key, out int val)) {
                _CurrentNumber += val;
                LastOperation[LastOperation.Count - 1] = _CurrentNumber;
            }
            else {
                _CurrentNumber = "";
                LastOperation.Add(key);
                LastOperation.Add(_CurrentNumber);
            }
            
            TextBox.Text = "";
            foreach (string value in LastOperation) {
                if (int.TryParse(value, out int result)) {
                    // Display in the correct MODE
                    TextBox.Text += value;
                } else {
                    TextBox.Text += value;
                }
            }
        }
    }
}
