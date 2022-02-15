namespace ScoreCalculator
{
    partial class ScoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreTotalLabel = new System.Windows.Forms.Label();
            this.scoreCountLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.scoreTotalTextBox = new System.Windows.Forms.TextBox();
            this.scoreCountTextBox = new System.Windows.Forms.TextBox();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.scoreLabel.Location = new System.Drawing.Point(58, 31);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(49, 17);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Score:";
            // 
            // scoreTotalLabel
            // 
            this.scoreTotalLabel.AutoSize = true;
            this.scoreTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.scoreTotalLabel.Location = new System.Drawing.Point(22, 68);
            this.scoreTotalLabel.Name = "scoreTotalLabel";
            this.scoreTotalLabel.Size = new System.Drawing.Size(85, 17);
            this.scoreTotalLabel.TabIndex = 1;
            this.scoreTotalLabel.Text = "Score Total:";
            // 
            // scoreCountLabel
            // 
            this.scoreCountLabel.AutoSize = true;
            this.scoreCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.scoreCountLabel.Location = new System.Drawing.Point(17, 105);
            this.scoreCountLabel.Name = "scoreCountLabel";
            this.scoreCountLabel.Size = new System.Drawing.Size(90, 17);
            this.scoreCountLabel.TabIndex = 2;
            this.scoreCountLabel.Text = "Score Count:";
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.averageLabel.Location = new System.Drawing.Point(42, 142);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(65, 17);
            this.averageLabel.TabIndex = 3;
            this.averageLabel.Text = "Average:";
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(113, 31);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(47, 20);
            this.scoreTextBox.TabIndex = 4;
            // 
            // scoreTotalTextBox
            // 
            this.scoreTotalTextBox.Location = new System.Drawing.Point(113, 68);
            this.scoreTotalTextBox.Name = "scoreTotalTextBox";
            this.scoreTotalTextBox.ReadOnly = true;
            this.scoreTotalTextBox.Size = new System.Drawing.Size(47, 20);
            this.scoreTotalTextBox.TabIndex = 5;
            this.scoreTotalTextBox.TabStop = false;
            // 
            // scoreCountTextBox
            // 
            this.scoreCountTextBox.Location = new System.Drawing.Point(113, 104);
            this.scoreCountTextBox.Name = "scoreCountTextBox";
            this.scoreCountTextBox.ReadOnly = true;
            this.scoreCountTextBox.Size = new System.Drawing.Size(47, 20);
            this.scoreCountTextBox.TabIndex = 6;
            this.scoreCountTextBox.TabStop = false;
            // 
            // averageTextBox
            // 
            this.averageTextBox.Location = new System.Drawing.Point(113, 142);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.ReadOnly = true;
            this.averageTextBox.Size = new System.Drawing.Size(47, 20);
            this.averageTextBox.TabIndex = 7;
            this.averageTextBox.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(32, 175);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(173, 175);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(173, 31);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(272, 213);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.averageTextBox);
            this.Controls.Add(this.scoreCountTextBox);
            this.Controls.Add(this.scoreTotalTextBox);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.scoreCountLabel);
            this.Controls.Add(this.scoreTotalLabel);
            this.Controls.Add(this.scoreLabel);
            this.Name = "Form1";
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreTotalLabel;
        private System.Windows.Forms.Label scoreCountLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.TextBox scoreTotalTextBox;
        private System.Windows.Forms.TextBox scoreCountTextBox;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addButton;
    }
}

