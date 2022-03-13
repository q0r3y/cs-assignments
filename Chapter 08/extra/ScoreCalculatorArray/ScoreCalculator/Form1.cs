using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class Form1 : Form
    {

        int count = 0;
        int[] scoresArr = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    int total = 0;
                    int score = Convert.ToInt32(txtScore.Text);
                    
                    scoresArr[count] += score;
                    count += 1;
                    
                    foreach (int i in scoresArr)
                    {
                        total += i;
                    }

                    int average = total / count;

                    txtScoreTotal.Text = total.ToString();
                    txtScoreCount.Text = count.ToString();
                    txtAverage.Text = average.ToString();

                    txtScore.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            count = 0;
            scoresArr = new int[10];
            
            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";

            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool IsValidData()
        {
            return
                // Validate the Score text box
                IsPresent(txtScore, "Score") &&
                IsInt32(txtScore, "Score") &&
                IsWithinRange(txtScore, "Score", 01, 100);
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

        public bool IsInt32(TextBox textBox, string name)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a valid integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name,
            decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min +
                    " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private void btnDisplayScores_Click(object sender, EventArgs e)
        {
            string scores = "";

            Array.Sort(scoresArr);

            foreach (int score in scoresArr)
            {
                if (score != 0)
                {
                    scores += score.ToString() + "\n";
                }
            }

            MessageBox.Show(scores, "Sorted Scores");
            txtScore.Focus();
        }
    }
}
