using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFinalProject {
    public class CalcBox {

        public ModeTracker CurrentMode;
        public TextBox Box;

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
                getNumeralSystem(value);
                Box.Text = value;
            } 
        }

        public CalcBox(ref TextBox inputTextBox) {
            Box = inputTextBox;
            CurrentMode = new ModeTracker();
        }

        private void getNumeralSystem(string value) {

        }
    }
}
