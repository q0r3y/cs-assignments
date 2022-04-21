using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFinalProject {
    public class IOBox {

        public string LastValue = "";
        public string CurrentValue = "";
        public TextBox TextBox { get; set; }
        public ModeHandler CurrentMode = new ModeHandler();

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
                CurrentValue += val;
            } else {
                CurrentValue = "";
            }
            TextBox.Text += key;
        }
        public void ClearState() {
            CurrentValue = "";
            TextBox.Text = "";
        }
    }
}
