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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (email.IndexOf("@") != -1)
            {
                string[] emailComponents = email.Split('@');
                string user = emailComponents[0];
                string domain = emailComponents[1];

                MessageBox.Show($"User name: {user}\nDomain name: {domain}",
                    "Parsed String");
            }
            else
            {
                MessageBox.Show("Invalid email address.", "Entry Error");
            }
        }

        // The specifics of this exercise aren't very clear

        private void btnFormat_Click(object sender, EventArgs e)
        {
            StringBuilder address = new StringBuilder();

            // Creates a string that contains the city, state, and zip code
            string addr = txtCity.Text + txtState.Text.ToUpper() + txtZipCode.Text;

            address.Append(addr);

            // Uses Insert() method to insert the appropriate characters
            address.Insert(addr.Length - 5, " ");
            address.Insert(addr.Length - 7, ", ");
            address.Insert(0, "City, State, Zip: ");

            MessageBox.Show(address.ToString(), "Formatted String");
        }
    }
}
