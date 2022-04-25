using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFinalProject {
    public class InputBox {

        public string LastValue = "";
        public TextBox TextBox { get; set; }
        public List<char> ValidKeys = new List<char> {
            '1','2','3','4','5','6','7','8','9','0',
            '/','*','+','-','.'
        };
        public InputBox(ref TextBox TextBox) {
            this.TextBox = TextBox;
        }
        public string Text {
            get {
                return TextBox.Text;
            }
            set {
                TextBox.Text = value;
            }
        }
        public void Backspace() {
            if (TextBox.Text.Length > 0)
                TextBox.Text = 
                    TextBox.Text.Remove(TextBox.Text.Length - 1);
            else
                TextBox.Text = "";

            if (LastValue.Length > 0) 
                LastValue = 
                    LastValue.Remove(LastValue.Length - 1);
            else
                LastValue = "";

            Focus();
        }
        public void ClearState() {
            LastValue = "";
            TextBox.Text = "";
        }
        public void RevertState() {
            Text = LastValue;
            Focus();
        }
        public void HandleKey(string key) {
            Text += key;
            Focus();
        }
        public void HandleValue(string value) {
            if (value.Length > 10) {
                value = value.Substring(0, 10);
            }
            Text = value;
            LastValue = value;
            Focus();
        }
        public void Focus() {
            TextBox.Focus();
            TextBox.SelectionStart = Text.Length;
        }
    }
}
