using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFinalProject {
    public class OutputBox : DisplayBox {

        private string _CurrentNumber = "";
        public List<string> LastOperation;
        public OutputBox(ref TextBox TextBox) : base(ref TextBox) {
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
                    if (Mode == "decimal") {
                        TextBox.Text += result;
                    }
                    else if (Mode == "binary") {
                        TextBox.Text += Converter.ConvertIntToBinary(result);
                    }
                    else if (Mode == "hexidecimal") {
                        TextBox.Text += result;
                    }
                } else {
                    TextBox.Text += value;
                }
            }
        }

        public new void ClearState() {
            _CurrentNumber = "";
            TextBox.Text = "";
            LastOperation = new List<string>() { "" };
        }
    }
}
