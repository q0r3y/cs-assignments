﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CalculatorFinalProject
{
    partial class Calculator
    {
        private string lastResult = "";
        private string lastOperation = "";

        private void btnEquals_Click(object sender, EventArgs e)
        {
            string result = "0";
            try
            {
                string equation = txtResult.Text;
                result = new DataTable().Compute(equation, null).ToString();
                txtResult.Text = result;
                lastResult = result;
                lastOperation = txtDisplayBox.Text;
            }
            catch (Exception ex)
            {
                setErrorState(ex.Message);
            }

            handleButtonClick("");
        }

        private void handleButtonClick(string buttonText)
        {
            if (mode == "decimal")
            {
                txtResult.Text += buttonText;
                txtDisplayBox.Text += buttonText;
            }
            else if (mode == "binary")
            {
                txtResult.Text += buttonText;
                txtDisplayBox.Text += buttonText;
            }
            else if (mode == "hex")
            {
                txtResult.Text += buttonText;
                txtDisplayBox.Text += buttonText;
            }
            txtResult.Focus();
            txtResult.SelectionStart = txtResult.Text.Length;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lastResult = "";
            lastOperation = "";
            if (errorState)
                clearErrorState();
            clearTextBoxes();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string resultText = txtResult.Text;
            txtDisplayBox.Text = "";

            if (resultText.Length > 0)
                txtResult.Text = resultText.Remove(resultText.Length - 1, 1);

            txtDisplayBox.Text = txtResult.Text;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            txtDisplayBox.Text = lastOperation;
            txtResult.Text = lastResult;
            clearErrorState();
        }

        private void btn1_Click(object sender, EventArgs e) => handleButtonClick("1");
        private void btn2_Click(object sender, EventArgs e) => handleButtonClick("2");
        private void btn3_Click(object sender, EventArgs e) => handleButtonClick("3");
        private void btn4_Click(object sender, EventArgs e) => handleButtonClick("4");
        private void btn5_Click(object sender, EventArgs e) => handleButtonClick("5");
        private void btn6_Click(object sender, EventArgs e) => handleButtonClick("6");
        private void btn7_Click(object sender, EventArgs e) => handleButtonClick("7");
        private void btn8_Click(object sender, EventArgs e) => handleButtonClick("8");
        private void btn9_Click(object sender, EventArgs e) => handleButtonClick("9");
        private void btn0_Click(object sender, EventArgs e) => handleButtonClick("0");
        private void btnDecimal_Click(object sender, EventArgs e) => handleButtonClick(".");
        private void btnAdd_Click(object sender, EventArgs e) => handleButtonClick("+");
        private void btnSubtract_Click(object sender, EventArgs e) => handleButtonClick("-");
        private void btnMultiply_Click(object sender, EventArgs e) => handleButtonClick("*");
        private void btnDivide_Click(object sender, EventArgs e) => handleButtonClick("/");
    }
}
