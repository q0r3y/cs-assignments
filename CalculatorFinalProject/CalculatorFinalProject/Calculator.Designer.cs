namespace CalculatorFinalProject
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInputBox = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.pnlNumbers = new System.Windows.Forms.Panel();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.grpOutputBox = new System.Windows.Forms.GroupBox();
            this.rdoOutputHex = new System.Windows.Forms.RadioButton();
            this.rdoOutputBin = new System.Windows.Forms.RadioButton();
            this.rdoOutputDec = new System.Windows.Forms.RadioButton();
            this.txtOutputBox = new System.Windows.Forms.TextBox();
            this.pnlButtons.SuspendLayout();
            this.pnlNumbers.SuspendLayout();
            this.grpOutputBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputBox
            // 
            this.txtInputBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInputBox.Location = new System.Drawing.Point(12, 54);
            this.txtInputBox.Name = "txtInputBox";
            this.txtInputBox.Size = new System.Drawing.Size(228, 39);
            this.txtInputBox.TabIndex = 0;
            this.txtInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntryBox_KeyPress);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Controls.Add(this.btnBack);
            this.pnlButtons.Controls.Add(this.btnEquals);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnDivide);
            this.pnlButtons.Controls.Add(this.btnSubtract);
            this.pnlButtons.Controls.Add(this.btnMultiply);
            this.pnlButtons.Controls.Add(this.pnlNumbers);
            this.pnlButtons.Controls.Add(this.btnUndo);
            this.pnlButtons.Location = new System.Drawing.Point(12, 142);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(228, 230);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUndo.Location = new System.Drawing.Point(0, 3);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(89, 40);
            this.btnUndo.TabIndex = 24;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Visible = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(95, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 40);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(0, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 40);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEquals.Location = new System.Drawing.Point(188, 49);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(40, 178);
            this.btnEquals.TabIndex = 19;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(141, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(141, 49);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(40, 40);
            this.btnDivide.TabIndex = 18;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtract.Location = new System.Drawing.Point(141, 141);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(40, 40);
            this.btnSubtract.TabIndex = 16;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.Location = new System.Drawing.Point(141, 95);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(40, 40);
            this.btnMultiply.TabIndex = 17;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // pnlNumbers
            // 
            this.pnlNumbers.Controls.Add(this.btn9);
            this.pnlNumbers.Controls.Add(this.btn0);
            this.pnlNumbers.Controls.Add(this.btn1);
            this.pnlNumbers.Controls.Add(this.btn8);
            this.pnlNumbers.Controls.Add(this.btn6);
            this.pnlNumbers.Controls.Add(this.btn4);
            this.pnlNumbers.Controls.Add(this.btn5);
            this.pnlNumbers.Controls.Add(this.btnDecimal);
            this.pnlNumbers.Controls.Add(this.btn3);
            this.pnlNumbers.Controls.Add(this.btn7);
            this.pnlNumbers.Controls.Add(this.btn2);
            this.pnlNumbers.Location = new System.Drawing.Point(1, 49);
            this.pnlNumbers.Name = "pnlNumbers";
            this.pnlNumbers.Size = new System.Drawing.Size(134, 178);
            this.pnlNumbers.TabIndex = 25;
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(94, 0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 40);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(0, 138);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(87, 40);
            this.btn0.TabIndex = 7;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(0, 92);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 40);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(47, 0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 40);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(94, 46);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 40);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(0, 46);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 40);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(47, 46);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 40);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecimal.Location = new System.Drawing.Point(94, 138);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(40, 40);
            this.btnDecimal.TabIndex = 14;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(94, 92);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 40);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(0, 0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 40);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(47, 92);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 40);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // grpOutputBox
            // 
            this.grpOutputBox.Controls.Add(this.rdoOutputHex);
            this.grpOutputBox.Controls.Add(this.rdoOutputBin);
            this.grpOutputBox.Controls.Add(this.rdoOutputDec);
            this.grpOutputBox.Location = new System.Drawing.Point(12, 12);
            this.grpOutputBox.Name = "grpOutputBox";
            this.grpOutputBox.Size = new System.Drawing.Size(228, 37);
            this.grpOutputBox.TabIndex = 2;
            this.grpOutputBox.TabStop = false;
            this.grpOutputBox.Text = "Output Mode";
            // 
            // rdoOutputHex
            // 
            this.rdoOutputHex.AutoSize = true;
            this.rdoOutputHex.Location = new System.Drawing.Point(176, 14);
            this.rdoOutputHex.Name = "rdoOutputHex";
            this.rdoOutputHex.Size = new System.Drawing.Size(46, 19);
            this.rdoOutputHex.TabIndex = 2;
            this.rdoOutputHex.TabStop = true;
            this.rdoOutputHex.Text = "Hex";
            this.rdoOutputHex.UseVisualStyleBackColor = true;
            this.rdoOutputHex.CheckedChanged += new System.EventHandler(this.rdoTopHex_CheckedChanged);
            // 
            // rdoOutputBin
            // 
            this.rdoOutputBin.AutoSize = true;
            this.rdoOutputBin.Location = new System.Drawing.Point(96, 14);
            this.rdoOutputBin.Name = "rdoOutputBin";
            this.rdoOutputBin.Size = new System.Drawing.Size(58, 19);
            this.rdoOutputBin.TabIndex = 1;
            this.rdoOutputBin.TabStop = true;
            this.rdoOutputBin.Text = "Binary";
            this.rdoOutputBin.UseVisualStyleBackColor = true;
            this.rdoOutputBin.CheckedChanged += new System.EventHandler(this.rdoTopBin_CheckedChanged);
            // 
            // rdoOutputDec
            // 
            this.rdoOutputDec.AutoSize = true;
            this.rdoOutputDec.Location = new System.Drawing.Point(6, 14);
            this.rdoOutputDec.Name = "rdoOutputDec";
            this.rdoOutputDec.Size = new System.Drawing.Size(68, 19);
            this.rdoOutputDec.TabIndex = 0;
            this.rdoOutputDec.TabStop = true;
            this.rdoOutputDec.Text = "Decimal";
            this.rdoOutputDec.UseVisualStyleBackColor = true;
            this.rdoOutputDec.CheckedChanged += new System.EventHandler(this.rdoTopDec_CheckedChanged);
            // 
            // txtOutputBox
            // 
            this.txtOutputBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutputBox.Location = new System.Drawing.Point(12, 99);
            this.txtOutputBox.Name = "txtOutputBox";
            this.txtOutputBox.ReadOnly = true;
            this.txtOutputBox.Size = new System.Drawing.Size(228, 39);
            this.txtOutputBox.TabIndex = 3;
            // 
            // Calculator
            // 
            this.AcceptButton = this.btnEquals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 379);
            this.Controls.Add(this.txtOutputBox);
            this.Controls.Add(this.grpOutputBox);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.txtInputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.pnlButtons.ResumeLayout(false);
            this.pnlNumbers.ResumeLayout(false);
            this.grpOutputBox.ResumeLayout(false);
            this.grpOutputBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtInputBox;
        private Panel pnlButtons;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button btnAdd;
        private Button btnDecimal;
        private Button btn3;
        private Button btn6;
        private Button btn9;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private Button btn0;
        private Button btn7;
        private Button btn1;
        private Button btn4;
        private Button btnEquals;
        private Button btnClear;
        private Button btnBack;
        private GroupBox grpOutputBox;
        private RadioButton rdoOutputHex;
        private RadioButton rdoOutputBin;
        private RadioButton rdoOutputDec;
        private TextBox txtOutputBox;
        private Button btnUndo;
        private Panel pnlNumbers;
    }
}