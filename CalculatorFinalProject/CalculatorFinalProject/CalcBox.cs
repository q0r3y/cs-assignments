using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFinalProject {
    public class CalcBox {
                
        public TextBox Box;
        public string CurrentNumber;
        public ModeHandler CurrentMode;
        public List<string> LastOperation;
        public string lastResult = "";
        //public string lastOperation = "";
        public string lastNumber = "";

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
                return Box.Text;
            } 

            set {
                //SetLastNumber(value);
                Box.Text = value;
            } 
        }

        public CalcBox(ref TextBox inputTextBox) {
            Box = inputTextBox;
            CurrentMode = new ModeHandler();
            LastOperation = new List<string>() { "" };
        }

        private void SetLastNumber(string value) {
            if (int.TryParse(value, out int num)) {
                lastNumber += num;
                LastOperation[LastOperation.Count - 1] += num;
            }
            else {
                lastNumber = "";
                LastOperation.Add(value);
            }
        }

        private void DisplayLastNumber() {
            if (int.TryParse(lastNumber, out int num)) {
                Box.Text += num.ToString();
            }
        }
    }
}
