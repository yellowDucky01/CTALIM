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
            btnPeriod = new Button();
            btnZero = new Button();
            button19 = new Button();
            label1 = new Label();
            textbInput = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
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
            btnDel.Click += btnFunction_Click;
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
            btnDivide.Click += btnFunction_Click;
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
            btnTimes.Click += btnFunction_Click;
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
            btnMinus.Click += btnFunction_Click;
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
            btnPlus.Click += btnFunction_Click;
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
            btnEqual.Click += btnFunction_Click;
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
            btn7.Click += btnNumber_Click;
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
            btnClear.Click += btnFunction_Click;
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
            btn8.Click += btnNumber_Click;
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
            btn9.Click += btnNumber_Click;
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
            btn6.Click += btnNumber_Click;
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
            btn5.Click += btnNumber_Click;
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
            btn4.Click += btnNumber_Click;
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
            btn1.Click += btnNumber_Click;
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
            btn2.Click += btnNumber_Click;
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
            btn3.Click += btnNumber_Click;
            // 
            // btnPeriod
            // 
            btnPeriod.BackColor = Color.DimGray;
            btnPeriod.FlatAppearance.BorderColor = Color.Black;
            btnPeriod.FlatAppearance.BorderSize = 0;
            btnPeriod.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeriod.ForeColor = SystemColors.ControlLight;
            btnPeriod.Location = new Point(25, 378);
            btnPeriod.Name = "btnPeriod";
            btnPeriod.Size = new Size(78, 52);
            btnPeriod.TabIndex = 19;
            btnPeriod.Text = ".";
            btnPeriod.UseVisualStyleBackColor = false;
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
            btnZero.Click += btnNumber_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.DimGray;
            button19.FlatAppearance.BorderColor = Color.Black;
            button19.FlatAppearance.BorderSize = 0;
            button19.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button19.ForeColor = SystemColors.ControlLight;
            button19.Location = new Point(193, 377);
            button19.Name = "button19";
            button19.Size = new Size(78, 52);
            button19.TabIndex = 21;
            button19.Text = "+/-";
            button19.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(285, 32);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 22;
            // 
            // textbInput
            // 
            textbInput.BorderStyle = BorderStyle.FixedSingle;
            textbInput.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbInput.Location = new Point(5, 5);
            textbInput.Name = "textbInput";
            textbInput.Size = new Size(312, 93);
            textbInput.TabIndex = 0;
            textbInput.TextChanged += textBox1_TextChanged_1;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 17);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 24;
            label2.Text = "HAHAHA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(389, 450);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button19);
            Controls.Add(btnZero);
            Controls.Add(btnPeriod);
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
        private Button btnPeriod;
        private Button btnZero;
        private Button button19;
        private Label label1;
        private TextBox textbInput;
        private Panel panel1;
        private Label label2;
        private Button btn7;
    }
}
