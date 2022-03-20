using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool IsValidData()
        {
            DateTime dateTimeMin = DateTime.Today;
            DateTime dateTimeMax = dateTimeMin.AddYears(5);
            string arrivalDateName = txtArrivalDate.Tag.ToString();
            string departureDateName = txtDepartureDate.Tag.ToString();

            if (IsPresent(txtArrivalDate, arrivalDateName) &&
                IsPresent(txtDepartureDate, departureDateName))
            {
                if (IsDateTime(txtArrivalDate, arrivalDateName) &&
                    IsDateTime(txtDepartureDate, departureDateName))
                {

                    if (IsWithinRange(txtArrivalDate, arrivalDateName, 
                        dateTimeMin, dateTimeMax) 
                        &&
                        IsWithinRange(txtDepartureDate, departureDateName, 
                        dateTimeMin, dateTimeMax))
                    {
                        DateTime arrival = DateTime.Parse(txtArrivalDate.Text);
                        DateTime departure = DateTime.Parse(txtDepartureDate.Text);
                        if (isArrivalBeforeDeparture(arrival, departure))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private bool isArrivalBeforeDeparture(DateTime arive, DateTime depart)
        {
            if (arive > depart)
            {
                MessageBox.Show("Arival date must be before depature date.", 
                    "Entry Error");
                return false;
            }
            return true;
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

        public bool IsDateTime(TextBox textBox, string name)
        {
            if (DateTime.TryParse(textBox.Text, out DateTime _))
            {
                return true;
            } 
            else
            {
                MessageBox.Show(name + " is an invalid date.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name,
            DateTime min, DateTime max)
        {
            DateTime inputDate = DateTime.Parse(textBox.Text);
            if (inputDate < min || inputDate > max)
            {
                MessageBox.Show(
                    name + $" must be between {min.ToShortDateString()} " +
                    $"and {max.ToShortDateString()}.", "Entry Error");
                return false;
            }
            return true;
        }

        private int calcTotalPrice(DateTime arive, DateTime depart)
        {
            int fridays = 0;
            int saturdays = 0;
            int standardPrice = 120;
            int premiumPrice = 150;
            int allDays = (depart - arive).Days;

            while (arive < depart)
            {
                if (arive.DayOfWeek == DayOfWeek.Friday)
                    fridays++;
                if (arive.DayOfWeek == DayOfWeek.Saturday)
                    saturdays++;
                arive = arive.AddDays(1);
            }

            int standardPriceDays = allDays - (fridays + saturdays);
            int price = 
                (standardPriceDays * standardPrice) + 
                ((fridays + saturdays) * premiumPrice);

            return price;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                DateTime arivalDate = DateTime.Parse(txtArrivalDate.Text);
                DateTime departureDate = DateTime.Parse(txtDepartureDate.Text);

                int days = (departureDate - arivalDate).Days;
                int totalPrice = calcTotalPrice(arivalDate, departureDate);
                int averagePrice = (totalPrice / days);

                txtNights.Text = days.ToString();
                txtTotalPrice.Text = totalPrice.ToString("c");
                txtAvgPrice.Text = averagePrice.ToString("c");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime todayPlusThree = today.AddDays(3);

            txtArrivalDate.Text = today.ToShortDateString();
            txtDepartureDate.Text = todayPlusThree.ToShortDateString();
        }
    }
}
