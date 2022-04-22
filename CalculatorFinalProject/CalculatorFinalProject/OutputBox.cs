using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFinalProject {
    public class OutputBox {

        public string Mode = "decimal";
        public string CurrentValue = "";
        public List<string> LastOperation;
        public List<string> LastValidOperation;
        public TextBox TextBox { get; set; }

        public string Text {
            get {
                return TextBox.Text;
            }
            set {
                TextBox.Text = value;
            }
        }

        public OutputBox(ref TextBox TextBox) {
            this.TextBox = TextBox;
            LastOperation = new List<string>() { "" };
            LastValidOperation = new List<string>() { "" };
        }
        public void HandleKey(string key) {
            if (int.TryParse(key, out int val)) {
                CurrentValue += val;
                LastOperation[LastOperation.Count - 1] = CurrentValue;
            }
            else {
                CurrentValue = "";
                LastOperation.Add(key);
                LastOperation.Add(CurrentValue);
            }
            SetTextBox();
        }

        private void SetTextBox() {
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
                }
                else {
                    TextBox.Text += value;
                }
            }
        }

        public void SetResultText(string value) {
            if (int.TryParse(value, out int result)) {
                if (Mode == "decimal") {
                    TextBox.Text = result.ToString();
                }
                else if (Mode == "binary") {
                    TextBox.Text = Converter.ConvertIntToBinary(result);
                }
                else if (Mode == "hexidecimal") {
                    TextBox.Text = Converter.ConvertIntToHex(result);
                }
            }
        }

        public void ClearState() {
            CurrentValue = "";
            TextBox.Text = "";
            LastOperation = new List<string>() { "" };
            LastValidOperation = new List<string>() { "" };
        }
    }
}
