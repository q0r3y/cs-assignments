using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFinalProject {
    public class OutputBox {

        public string Mode = "decimal";
        private string CurrentNumber = "";
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
                CurrentNumber += val;
                LastOperation[LastOperation.Count - 1] = CurrentNumber;
            }
            else {
                CurrentNumber = "";
                LastOperation.Add(key);
                LastOperation.Add(CurrentNumber);
            }
            DisplayOpArray();
        }

        public void HandleValue(string value) {
            if (value.Length > 10) {
                value = value.Substring(0, 10);
            }
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
            else {
                TextBox.Text = value;
            }
        }
        private void DisplayOpArray() {
            TextBox.Text = "";
            foreach (string value in LastOperation) {
                if (int.TryParse(value, out int result)) {
                    if (Mode == "decimal") {
                        TextBox.Text += result.ToString();
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
                ScrollToEnd();
            }
        }
        public void ClearState() {
            CurrentNumber = "";
            TextBox.Text = "";
            LastOperation = new List<string>() { "" };
            LastValidOperation = new List<string>() { "" };
        }
        private void ScrollToEnd() {
            TextBox.SelectionStart = Text.Length;
            TextBox.ScrollToCaret();
        }
        public void SetLastValidOp() {
           LastValidOperation.Clear();
            foreach (string s in LastOperation)
                LastValidOperation.Add(s);
        }
        public void RevertState() {
            Text = "";
            LastOperation.Clear();
            foreach (string s in LastValidOperation) {
                Text += s;
                LastOperation.Add(s);
            }
        }
    }
}
