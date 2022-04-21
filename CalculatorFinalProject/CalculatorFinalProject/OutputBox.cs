using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFinalProject {
    public class OutputBox : IOBox {

        public List<string> LastOperation;
        public List<string> LastValidOperation;

        public OutputBox(ref TextBox TextBox) : base(ref TextBox) {
            this.TextBox = TextBox;
            LastOperation = new List<string>() { "" };
            LastValidOperation = new List<string>() { "" };
        }
        public new void HandleKey(string key) {
            if (int.TryParse(key, out int val)) {
                CurrentValue += val;
                LastOperation[LastOperation.Count - 1] = CurrentValue;
            }
            else {
                CurrentValue = "";
                LastOperation.Add(key);
                LastOperation.Add(CurrentValue);
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
                        TextBox.Text += Converter.ConvertIntToHex(result);
                    }
                } else {
                    TextBox.Text += value;
                }
            }
        }
        public new void ClearState() {
            CurrentValue = "";
            TextBox.Text = "";
            LastOperation = new List<string>() { "" };
        }
    }
}
