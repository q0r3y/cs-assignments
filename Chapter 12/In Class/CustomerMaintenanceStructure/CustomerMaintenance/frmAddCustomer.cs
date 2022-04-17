using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public partial class frmAddCustomer : Form
    {
        Customer customer;

        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = "";

            msg += Validator.IsPresent(txtFirstName.Text, "First Name");
            msg += Validator.IsPresent(txtLastName.Text, "Last Name");
            msg += Validator.IsPresent(txtEmail.Text, "Email");
            msg += Validator.IsValidEmail(txtEmail.Text, "Email");

            if (msg.Length == 0)
            {
                customer = new Customer(txtFirstName.Text, 
                    txtLastName.Text, txtEmail.Text);
                this.Close();
            } 
            else
            {
                MessageBox.Show(msg);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Customer GetNewCustomer()
        {
            this.ShowDialog();
            return customer;
        }
    }
}
