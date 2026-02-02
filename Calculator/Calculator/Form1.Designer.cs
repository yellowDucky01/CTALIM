namespace Calculator
{
    partial class Form1
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
            btnDel = new Button();
            btnDivide = new Button();
            btnTimes = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnEqual = new Button();
            btn7 = new Button();
            btnClear = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnDecimalPoint = new Button();
            btnZero = new Button();
            btnPlusMinus = new Button();
            textbInput = new TextBox();
            panel1 = new Panel();
            labelResult = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Sienna;
            btnDel.FlatAppearance.BorderColor = Color.Black;
            btnDel.FlatAppearance.BorderSize = 0;
            btnDel.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel.ForeColor = SystemColors.ControlLight;
            btnDel.Location = new Point(109, 186);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(78, 52);
            btnDel.TabIndex = 1;
            btnDel.Text = "Del";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.Sienna;
            btnDivide.FlatAppearance.BorderColor = Color.Black;
            btnDivide.FlatAppearance.BorderSize = 0;
            btnDivide.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.ForeColor = SystemColors.ControlLight;
            btnDivide.Location = new Point(193, 186);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(78, 52);
            btnDivide.TabIndex = 2;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnTimes
            // 
            btnTimes.BackColor = Color.Sienna;
            btnTimes.FlatAppearance.BorderColor = Color.Black;
            btnTimes.FlatAppearance.BorderSize = 0;
            btnTimes.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimes.ForeColor = SystemColors.ControlLight;
            btnTimes.Location = new Point(277, 186);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(78, 52);
            btnTimes.TabIndex = 5;
            btnTimes.Text = "X";
            btnTimes.UseVisualStyleBackColor = false;
            btnTimes.Click += btnTimes_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.Sienna;
            btnMinus.FlatAppearance.BorderColor = Color.Black;
            btnMinus.FlatAppearance.BorderSize = 0;
            btnMinus.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.ForeColor = SystemColors.ControlLight;
            btnMinus.Location = new Point(277, 230);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(78, 52);
            btnMinus.TabIndex = 6;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.Sienna;
            btnPlus.FlatAppearance.BorderColor = Color.Black;
            btnPlus.FlatAppearance.BorderSize = 0;
            btnPlus.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.ForeColor = SystemColors.ControlLight;
            btnPlus.Location = new Point(277, 271);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(78, 52);
            btnPlus.TabIndex = 7;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.DarkOrange;
            btnEqual.FlatAppearance.BorderColor = Color.Black;
            btnEqual.FlatAppearance.BorderSize = 0;
            btnEqual.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.ForeColor = SystemColors.ControlLight;
            btnEqual.Location = new Point(277, 320);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(78, 109);
            btnEqual.TabIndex = 8;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.DimGray;
            btn7.FlatAppearance.BorderColor = Color.Black;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.ForeColor = SystemColors.ControlLight;
            btn7.Location = new Point(25, 230);
            btn7.Name = "btn7";
            btn7.Size = new Size(78, 52);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Sienna;
            btnClear.FlatAppearance.BorderColor = Color.Black;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ControlLight;
            btnClear.Location = new Point(25, 186);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 52);
            btnClear.TabIndex = 10;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.DimGray;
            btn8.FlatAppearance.BorderColor = Color.Black;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.ForeColor = SystemColors.ControlLight;
            btn8.Location = new Point(109, 230);
            btn8.Name = "btn8";
            btn8.Size = new Size(78, 52);
            btn8.TabIndex = 11;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.DimGray;
            btn9.FlatAppearance.BorderColor = Color.Black;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.ForeColor = SystemColors.ButtonFace;
            btn9.Location = new Point(193, 230);
            btn9.Name = "btn9";
            btn9.Size = new Size(78, 52);
            btn9.TabIndex = 12;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.DimGray;
            btn6.FlatAppearance.BorderColor = Color.Black;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.ForeColor = SystemColors.ControlLight;
            btn6.Location = new Point(193, 279);
            btn6.Name = "btn6";
            btn6.Size = new Size(78, 52);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.DimGray;
            btn5.FlatAppearance.BorderColor = Color.Black;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.ForeColor = SystemColors.ControlLight;
            btn5.Location = new Point(109, 279);
            btn5.Name = "btn5";
            btn5.Size = new Size(78, 52);
            btn5.TabIndex = 14;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.DimGray;
            btn4.FlatAppearance.BorderColor = Color.Black;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.ForeColor = SystemColors.ControlLight;
            btn4.Location = new Point(25, 279);
            btn4.Name = "btn4";
            btn4.Size = new Size(78, 52);
            btn4.TabIndex = 15;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.DimGray;
            btn1.FlatAppearance.BorderColor = Color.Black;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.ControlLight;
            btn1.Location = new Point(25, 329);
            btn1.Name = "btn1";
            btn1.Size = new Size(78, 52);
            btn1.TabIndex = 16;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.DimGray;
            btn2.FlatAppearance.BorderColor = Color.Black;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = SystemColors.ControlLight;
            btn2.Location = new Point(109, 329);
            btn2.Name = "btn2";
            btn2.Size = new Size(78, 52);
            btn2.TabIndex = 17;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.DimGray;
            btn3.FlatAppearance.BorderColor = Color.Black;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ForeColor = SystemColors.ControlLight;
            btn3.Location = new Point(193, 329);
            btn3.Name = "btn3";
            btn3.Size = new Size(78, 52);
            btn3.TabIndex = 18;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btnDecimalPoint
            // 
            btnDecimalPoint.BackColor = Color.DimGray;
            btnDecimalPoint.FlatAppearance.BorderColor = Color.Black;
            btnDecimalPoint.FlatAppearance.BorderSize = 0;
            btnDecimalPoint.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecimalPoint.ForeColor = SystemColors.ControlLight;
            btnDecimalPoint.Location = new Point(25, 378);
            btnDecimalPoint.Name = "btnDecimalPoint";
            btnDecimalPoint.Size = new Size(78, 52);
            btnDecimalPoint.TabIndex = 19;
            btnDecimalPoint.Text = ".";
            btnDecimalPoint.UseVisualStyleBackColor = false;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.DimGray;
            btnZero.FlatAppearance.BorderColor = Color.Black;
            btnZero.FlatAppearance.BorderSize = 0;
            btnZero.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZero.ForeColor = SystemColors.ControlLight;
            btnZero.Location = new Point(109, 377);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(78, 52);
            btnZero.TabIndex = 20;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = Color.DimGray;
            btnPlusMinus.FlatAppearance.BorderColor = Color.Black;
            btnPlusMinus.FlatAppearance.BorderSize = 0;
            btnPlusMinus.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlusMinus.ForeColor = SystemColors.ControlLight;
            btnPlusMinus.Location = new Point(193, 377);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(78, 52);
            btnPlusMinus.TabIndex = 21;
            btnPlusMinus.Text = "+/-";
            btnPlusMinus.UseVisualStyleBackColor = false;
            // 
            // textbInput
            // 
            textbInput.BorderStyle = BorderStyle.FixedSingle;
            textbInput.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbInput.Location = new Point(5, 5);
            textbInput.Name = "textbInput";
            textbInput.ReadOnly = true;
            textbInput.Size = new Size(312, 93);
            textbInput.TabIndex = 0;
            textbInput.Text = "0";
            textbInput.TextAlign = HorizontalAlignment.Right;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(textbInput);
            panel1.Location = new Point(25, 66);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(2);
            panel1.Size = new Size(322, 101);
            panel1.TabIndex = 23;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResult.ForeColor = SystemColors.ButtonHighlight;
            labelResult.Location = new Point(30, 18);
            labelResult.Name = "labelResult";
            labelResult.RightToLeft = RightToLeft.No;
            labelResult.Size = new Size(37, 45);
            labelResult.TabIndex = 24;
            labelResult.Text = "0";
            labelResult.TextAlign = ContentAlignment.TopRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(389, 450);
            Controls.Add(labelResult);
            Controls.Add(panel1);
            Controls.Add(btnPlusMinus);
            Controls.Add(btnZero);
            Controls.Add(btnDecimalPoint);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btnClear);
            Controls.Add(btn7);
            Controls.Add(btnEqual);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btnTimes);
            Controls.Add(btnDivide);
            Controls.Add(btnDel);
            Name = "Form1";
            Text = "Calculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDel;
        private Button btnDivide;
        private Button btnTimes;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnEqual;
        private Button btnClear;
        private Button btn8;
        private Button btn9;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnDecimalPoint;
        private Button btnZero;
        private Button btnPlusMinus;
        private TextBox textbInput;
        private Panel panel1;
        private Button btn7;
        private Label labelResult;
    }
}
