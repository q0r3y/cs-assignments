using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public partial class frmCustomers : Form
    {
        private List<Customer> customers = null;

        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomerForm = new frmAddCustomer();
            Customer newCustomer = addCustomerForm.GetNewCustomer();

            string firstName = newCustomer.FirstName;
            string lastName = newCustomer.LastName;
            string email = newCustomer.Email;

            if (firstName != null && lastName != null && email != null)
            {
                customers.Add(newCustomer);
                CustomerDB.SaveCustomers(customers);
                lstCustomers.Items.Add(newCustomer.GetDisplayText);
                refreshListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstCustomers.SelectedIndex;
            customers.RemoveAt(index);
            CustomerDB.SaveCustomers(customers);
            refreshListBox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshListBox()
        {
            lstCustomers.Items.Clear();
            foreach (Customer customer in customers)
            {
                lstCustomers.Items.Add(customer.GetDisplayText);
            }
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            customers = CustomerDB.GetCustomers();
            refreshListBox();
        }
    }
}
