using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFinalProject {
    public class IOBox {
        public TextBox TextBox { get; set; }
        public ModeHandler CurrentMode = new ModeHandler();
        private string _CurrentNumber = "";
        public IOBox(ref TextBox TextBox) {
            this.TextBox = TextBox;
        }
        public string Mode {
            get {
                return CurrentMode.Mode;
            }

            set {
                CurrentMode.Mode = value;
            }
        }
        public string Text {
            get {
                return TextBox.Text;
            }
            set {
                TextBox.Text = value;
            }
        }
        public void HandleKey(string key) {
            if (int.TryParse(key, out int val)) {
                _CurrentNumber += val;
            } else {
                _CurrentNumber = "";
            }
            TextBox.Text += key;
        }
        public void ClearState() {
            _CurrentNumber = "";
            TextBox.Text = "";
        }
    }
}
