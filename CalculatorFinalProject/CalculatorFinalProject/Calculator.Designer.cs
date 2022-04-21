﻿namespace CalculatorFinalProject
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
            this.txtEntryBox = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnPosNeg = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoTopHex = new System.Windows.Forms.RadioButton();
            this.rdoTopBin = new System.Windows.Forms.RadioButton();
            this.rdoTopDec = new System.Windows.Forms.RadioButton();
            this.txtHistoryBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoBottomHex = new System.Windows.Forms.RadioButton();
            this.rdoBottomBin = new System.Windows.Forms.RadioButton();
            this.rdoBottomDec = new System.Windows.Forms.RadioButton();
            this.pnlButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEntryBox
            // 
            this.txtEntryBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEntryBox.Location = new System.Drawing.Point(12, 119);
            this.txtEntryBox.Name = "txtEntryBox";
            this.txtEntryBox.Size = new System.Drawing.Size(228, 39);
            this.txtEntryBox.TabIndex = 0;
            this.txtEntryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResult_KeyPress);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnUndo);
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Controls.Add(this.btnBack);
            this.pnlButtons.Controls.Add(this.btn9);
            this.pnlButtons.Controls.Add(this.btn6);
            this.pnlButtons.Controls.Add(this.btnSqrt);
            this.pnlButtons.Controls.Add(this.btnPosNeg);
            this.pnlButtons.Controls.Add(this.btn3);
            this.pnlButtons.Controls.Add(this.button20);
            this.pnlButtons.Controls.Add(this.btn2);
            this.pnlButtons.Controls.Add(this.btn7);
            this.pnlButtons.Controls.Add(this.btnDecimal);
            this.pnlButtons.Controls.Add(this.btnEquals);
            this.pnlButtons.Controls.Add(this.btn5);
            this.pnlButtons.Controls.Add(this.btn4);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnDivide);
            this.pnlButtons.Controls.Add(this.btn8);
            this.pnlButtons.Controls.Add(this.btn1);
            this.pnlButtons.Controls.Add(this.btnSubtract);
            this.pnlButtons.Controls.Add(this.btnMultiply);
            this.pnlButtons.Controls.Add(this.btn0);
            this.pnlButtons.Location = new System.Drawing.Point(12, 162);
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
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(95, 49);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 40);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(95, 95);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 40);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSqrt.Location = new System.Drawing.Point(188, 49);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(40, 40);
            this.btnSqrt.TabIndex = 21;
            this.btnSqrt.Text = "sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            // 
            // btnPosNeg
            // 
            this.btnPosNeg.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPosNeg.Location = new System.Drawing.Point(47, 187);
            this.btnPosNeg.Name = "btnPosNeg";
            this.btnPosNeg.Size = new System.Drawing.Size(40, 40);
            this.btnPosNeg.TabIndex = 10;
            this.btnPosNeg.Text = "+/-";
            this.btnPosNeg.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(95, 141);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 40);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button20.Location = new System.Drawing.Point(188, 95);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(40, 40);
            this.button20.TabIndex = 20;
            this.button20.Text = "1/X";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(47, 141);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 40);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(0, 49);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 40);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecimal.Location = new System.Drawing.Point(95, 187);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(40, 40);
            this.btnDecimal.TabIndex = 14;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEquals.Location = new System.Drawing.Point(188, 141);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(40, 86);
            this.btnEquals.TabIndex = 19;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(47, 95);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 40);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(0, 95);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 40);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
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
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(47, 49);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 40);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(0, 141);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 40);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
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
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(0, 187);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(40, 40);
            this.btn0.TabIndex = 7;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoTopHex);
            this.groupBox1.Controls.Add(this.rdoTopBin);
            this.groupBox1.Controls.Add(this.rdoTopDec);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 37);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Top Mode";
            // 
            // rdoTopHex
            // 
            this.rdoTopHex.AutoSize = true;
            this.rdoTopHex.Location = new System.Drawing.Point(176, 14);
            this.rdoTopHex.Name = "rdoTopHex";
            this.rdoTopHex.Size = new System.Drawing.Size(45, 19);
            this.rdoTopHex.TabIndex = 2;
            this.rdoTopHex.TabStop = true;
            this.rdoTopHex.Text = "Hex";
            this.rdoTopHex.UseVisualStyleBackColor = true;
            this.rdoTopHex.CheckedChanged += new System.EventHandler(this.rdoTopHex_CheckedChanged);
            // 
            // rdoTopBin
            // 
            this.rdoTopBin.AutoSize = true;
            this.rdoTopBin.Location = new System.Drawing.Point(96, 14);
            this.rdoTopBin.Name = "rdoTopBin";
            this.rdoTopBin.Size = new System.Drawing.Size(58, 19);
            this.rdoTopBin.TabIndex = 1;
            this.rdoTopBin.TabStop = true;
            this.rdoTopBin.Text = "Binary";
            this.rdoTopBin.UseVisualStyleBackColor = true;
            this.rdoTopBin.CheckedChanged += new System.EventHandler(this.rdoTopBinary_CheckedChanged);
            // 
            // rdoTopDec
            // 
            this.rdoTopDec.AutoSize = true;
            this.rdoTopDec.Location = new System.Drawing.Point(6, 14);
            this.rdoTopDec.Name = "rdoTopDec";
            this.rdoTopDec.Size = new System.Drawing.Size(68, 19);
            this.rdoTopDec.TabIndex = 0;
            this.rdoTopDec.TabStop = true;
            this.rdoTopDec.Text = "Decimal";
            this.rdoTopDec.UseVisualStyleBackColor = true;
            this.rdoTopDec.CheckedChanged += new System.EventHandler(this.rdoTopDecimal_CheckedChanged);
            // 
            // txtHistoryBox
            // 
            this.txtHistoryBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHistoryBox.Location = new System.Drawing.Point(12, 88);
            this.txtHistoryBox.Name = "txtHistoryBox";
            this.txtHistoryBox.ReadOnly = true;
            this.txtHistoryBox.Size = new System.Drawing.Size(228, 27);
            this.txtHistoryBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoBottomHex);
            this.groupBox2.Controls.Add(this.rdoBottomBin);
            this.groupBox2.Controls.Add(this.rdoBottomDec);
            this.groupBox2.Location = new System.Drawing.Point(12, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 37);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bottom Mode";
            // 
            // rdoBottomHex
            // 
            this.rdoBottomHex.AutoSize = true;
            this.rdoBottomHex.Location = new System.Drawing.Point(176, 14);
            this.rdoBottomHex.Name = "rdoBottomHex";
            this.rdoBottomHex.Size = new System.Drawing.Size(45, 19);
            this.rdoBottomHex.TabIndex = 2;
            this.rdoBottomHex.TabStop = true;
            this.rdoBottomHex.Text = "Hex";
            this.rdoBottomHex.UseVisualStyleBackColor = true;
            this.rdoBottomHex.CheckedChanged += new System.EventHandler(this.rdoBottomHex_CheckedChanged);
            // 
            // rdoBottomBin
            // 
            this.rdoBottomBin.AutoSize = true;
            this.rdoBottomBin.Location = new System.Drawing.Point(96, 14);
            this.rdoBottomBin.Name = "rdoBottomBin";
            this.rdoBottomBin.Size = new System.Drawing.Size(58, 19);
            this.rdoBottomBin.TabIndex = 1;
            this.rdoBottomBin.TabStop = true;
            this.rdoBottomBin.Text = "Binary";
            this.rdoBottomBin.UseVisualStyleBackColor = true;
            this.rdoBottomBin.CheckedChanged += new System.EventHandler(this.rdoBottomBin_CheckedChanged);
            // 
            // rdoBottomDec
            // 
            this.rdoBottomDec.AutoSize = true;
            this.rdoBottomDec.Location = new System.Drawing.Point(6, 14);
            this.rdoBottomDec.Name = "rdoBottomDec";
            this.rdoBottomDec.Size = new System.Drawing.Size(68, 19);
            this.rdoBottomDec.TabIndex = 0;
            this.rdoBottomDec.TabStop = true;
            this.rdoBottomDec.Text = "Decimal";
            this.rdoBottomDec.UseVisualStyleBackColor = true;
            this.rdoBottomDec.CheckedChanged += new System.EventHandler(this.rdoBottomDec_CheckedChanged);
            // 
            // Calculator
            // 
            this.AcceptButton = this.btnEquals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtHistoryBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.txtEntryBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.pnlButtons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEntryBox;
        private Panel pnlButtons;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button btnAdd;
        private Button btnDecimal;
        private Button btn3;
        private Button btn6;
        private Button btn9;
        private Button btnPosNeg;
        private Button btn2;
        private Button btn5;
        private Button btn8;
        private Button btn0;
        private Button btn7;
        private Button btn1;
        private Button btn4;
        private Button btnSqrt;
        private Button button20;
        private Button btnEquals;
        private Button btnClear;
        private Button btnBack;
        private GroupBox groupBox1;
        private RadioButton rdoTopHex;
        private RadioButton rdoTopBin;
        private RadioButton rdoTopDec;
        private TextBox txtHistoryBox;
        private Button btnUndo;
        private GroupBox groupBox2;
        private RadioButton rdoBottomHex;
        private RadioButton rdoBottomBin;
        private RadioButton rdoBottomDec;
    }
}