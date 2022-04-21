using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFinalProject {
    public class HistoryBox : DisplayBox {

        public HistoryBox(ref TextBox TextBox) : base(ref TextBox) {
            this.TextBox = TextBox;
        }
    }
}
