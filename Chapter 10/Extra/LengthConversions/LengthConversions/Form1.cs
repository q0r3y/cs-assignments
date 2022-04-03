using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LengthConversions
{
    public partial class Form1 : Form
    {
        string[,] conversionTable = {
            {"Miles to kilometers", "Miles:", "Kilometers:", "1.6093"},
            {"Kilometers to miles", "Kilometers:", "Miles:", "0.6214"},
            {"Feet to meters", "Feet:", "Meters:", "0.3048"},
            {"Meters to feet", "Meters:", "Feet:", "3.2808"},
            {"Inches to centimeters", "Inches:", "Centimeters:", "2.54"},
            {"Centimeters to inches", "Centimeters:", "Inches:", "0.3937"}
        };

        public Form1()
        {
            InitializeComponent();
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < conversionTable.GetLength(0); i++)
            {
                cboConversions.Items.Add(conversionTable[i, 0]);
            }
            cboConversions.SelectedIndex = 0;
        }

        private void cboConversions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = cboConversions.SelectedIndex;            
            lblFromLength.Text = conversionTable[position, 1];
            lblToLength.Text = conversionTable[position, 2];
            txtCalculatedLength.Clear();
            txtLength.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (isValidNumber(txtLength.Text, txtLength.Tag.ToString()))
            {
                int position = cboConversions.SelectedIndex;
                decimal conversion = Convert.ToDecimal(conversionTable[position, 3]);
                decimal input = Convert.ToDecimal(txtLength.Text);
                decimal calculation = conversion * input;
                txtCalculatedLength.Text = calculation.ToString("N");
            }

        }

        bool isValidNumber(string input, string tag)
        {
            bool success = false;

            if (Decimal.TryParse(input, out decimal _))
            {
                success = true;
            } 
            else
            {
                string msg = $"{tag} needs to be a numeric value.";
                MessageBox.Show(msg, "Unable to convert to decimal");
            }

            return success;
        }
    }
}
