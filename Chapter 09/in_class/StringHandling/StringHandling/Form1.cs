#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string adjustNameCasing(string name)
        {
            return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
        }

        private void btnParseName_Click(object sender, System.EventArgs e)
        {
            string msg = "";
            string? middleName = "";
            string firstName = "", lastName = "";
            string fullName = txtFullName.Text;
            string[] names = fullName.Trim().Split(' ');

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] != null)
                {
                    names[i] = adjustNameCasing(names[i]);
                }
            }

            if (names.Length >= 1)
            {
                firstName = names[0];

                if (names.Length >= 2)
                {
                    lastName = names[1];

                    if (names.Length >= 3)
                    {
                        middleName = names[1];
                        lastName = names[2];
                    }
                }
            }

            msg = "First Name:\t" + firstName +
                "\n\nMiddle Name:\t" + middleName +
                "\n\nLast Name:\t" + lastName;

            MessageBox.Show(msg, "Parse Name");
        }

        private void btnEditPhoneNumber_Click(object sender, System.EventArgs e)
        {
            string msg = "";
            string digitOnlyNumber = "";
            string standardFormatNumber = "";
            string enteredPhoneNumber = txtPhoneNumber.Text;

            foreach (char number in enteredPhoneNumber)
            {
                if (char.IsDigit(number))
                {
                    digitOnlyNumber += number;
                }
            }

            standardFormatNumber = digitOnlyNumber.Insert(3, "-").Insert(7, "-");

            msg = "Entered:\t\t" + enteredPhoneNumber +
                "\n\nDigits Only:\t" + digitOnlyNumber +
                "\n\nStandard Format:\t" + standardFormatNumber;

            MessageBox.Show(msg, "Edit Phone Number");

        }

        // TODO: Add ToInitialCap method here

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
