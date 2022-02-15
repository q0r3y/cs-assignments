using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndPerimeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal inputLength = Convert.ToDecimal(lengthTextBox.Text);
            decimal inputWidth = Convert.ToDecimal(widthTextBox.Text);

            areaTextBox.Text = calculateArea(inputLength, inputWidth).ToString();
            perimeterTextBox.Text = calculatePerimeter(inputLength,inputWidth).ToString();

            lengthTextBox.Focus();
        }

        private decimal calculateArea(decimal length, decimal width)
        {
            return (length * width);
        }

        private decimal calculatePerimeter(decimal length, decimal width)
        {
            return ((2 * length) + (2 * width));
        }
    }
}
