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
    public partial class ScoreForm : Form
    {
        int scoreTotal;
        int scoreCount;
        
        public ScoreForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Gets the score the user enters
            int inputScore = Convert.ToInt32(scoreTextBox.Text);

            // Calculate and display score total
            scoreTotal += inputScore;
            scoreTotalTextBox.Text = scoreTotal.ToString();

            // Calculate and display the score count
            scoreCount += 1;
            scoreCountTextBox.Text = scoreCount.ToString();

            // Calculate and display the average score
            int averageScore = scoreTotal / scoreCount;
            averageTextBox.Text = averageScore.ToString();

            // Move focus to the score text box
            scoreTextBox.Focus();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Set class variables to zero
            scoreTotal = 0;
            scoreCount = 0;

            // Clear text boxes
            scoreTextBox.Clear();
            scoreTotalTextBox.Clear();
            scoreCountTextBox.Clear();
            averageTextBox.Clear();

            // Moves focus to score text box
            scoreTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
