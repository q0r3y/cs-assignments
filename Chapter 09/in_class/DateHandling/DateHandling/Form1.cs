using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateDueDays_Click(object sender, System.EventArgs e)
        {
            DateTime currentDate = DateTime.Today;
            DateTime futureDate = DateTime.Parse(txtFutureDate.Text);
            int daysUntilDue = futureDate.Subtract(currentDate).Days;

            string msg = 
                "Current Date:\t" + currentDate.ToShortDateString() 
                + "\n\nFuture Date:\t" + futureDate.ToShortDateString() 
                + "\n\nDays until due:\t" + daysUntilDue;

            MessageBox.Show(msg, "Due Days Calculation");
        }

        private void btnCalculateAge_Click(object sender, System.EventArgs e)
        {
            decimal daysInYear = 365.2425m;
            DateTime currentDate = DateTime.Today;
            DateTime birthDate = DateTime.Parse(txtBirthDate.Text);
            int age = (int)(Math.Floor(currentDate.Subtract(birthDate).Days / daysInYear));

            string msg =
                "Current Date:\t" + currentDate.ToLongDateString()
                + "\n\nBirth Date:\t" + birthDate.ToLongDateString()
                + "\n\nAge:\t" + age;

            MessageBox.Show(msg, "Due Days Calculation");
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
