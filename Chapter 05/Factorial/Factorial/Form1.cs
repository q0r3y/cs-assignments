﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
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

        private void bntCalculate_Click(object sender, EventArgs e)
        {
            long factorial = 1;
            int inputNumber = Convert.ToInt32(txtNumber.Text);

            for (; inputNumber > 0; inputNumber--)
            {
                factorial *= inputNumber;
            }

            txtFactorial.Text = factorial.ToString("n0");

            txtNumber.Focus();
        }
    }
}
