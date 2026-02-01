namespace Calculator
{
    public partial class Form1 : Form
    {
        double value1;
        double value2;
        string op = "";
        bool isOpClicked = false;
        double result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textbInput.Text == "0" || isOpClicked)
            {
                textbInput.Text = "1";
                labelResult.Text = "1";
            }
            else
            {
                textbInput.Text += "1";
                labelResult.Text += "1";
            }

            isOpClicked = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textbInput.Text == "0" || isOpClicked)
            {
                textbInput.Text = "2";
                labelResult.Text = "2";
            }
            else
            {
                textbInput.Text += "2";
                labelResult.Text += "2";
            }
            isOpClicked = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textbInput.Text == "0" || isOpClicked)
            {
                textbInput.Text = "3";
                labelResult.Text = "3";
            }
            else
            {
                textbInput.Text += "3";
                labelResult.Text += "3";
            }
            isOpClicked = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textbInput.Text == "0" || isOpClicked)
            {
                textbInput.Text = "4";
                labelResult.Text = "4";
            }
            else
            {
                textbInput.Text += "4";
                labelResult.Text += "4";
            }
            isOpClicked = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textbInput.Text == "0" || isOpClicked)
            {
                textbInput.Text = "5";
                labelResult.Text = "5";
            }
            else
            {
                textbInput.Text += "5";
                labelResult.Text += "5";
            }
            isOpClicked = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textbInput.Text == "0" || isOpClicked)
            {
                textbInput.Text = "6";
                labelResult.Text = "6";
            }
            else
            {
                textbInput.Text += "6";
                labelResult.Text += "6";
            }
            isOpClicked = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textbInput.Text == "0" || isOpClicked)
            {
                textbInput.Text = "7";
                labelResult.Text = "7";
            }
            else
            {
                textbInput.Text += "7";
                labelResult.Text += "7";
            }
                isOpClicked = false;
        }
        

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textbInput.Text == "0" || isOpClicked)
            {
                textbInput.Text = "8";
                labelResult.Text = "8";
            }
            else
            {
                textbInput.Text += "8";
                labelResult.Text += "8";
            }
            isOpClicked = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textbInput.Text == "0" || isOpClicked)
            {
                textbInput.Text = "9";
                labelResult.Text = "9";
            }
            else
            {
                textbInput.Text += "9";
                labelResult.Text += "9";
            }
            isOpClicked = false;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (isOpClicked || textbInput.Text == "0")
            {
                textbInput.Text = "0";
                labelResult.Text = "0";
            }
            else
            {
                textbInput.Text += "0";
                labelResult.Text += "0";
            }
            isOpClicked = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textbInput.Text = "0";
            labelResult.Text = "";
            value1 = 0;
            value2 = 0;
            isOpClicked = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (textbInput.Text.Length > 0)
            {
                textbInput.Text = textbInput.Text.Remove(textbInput.Text.Length - 1);
                labelResult.Text = labelResult.Text.Remove(labelResult.Text.Length - 1);
            }
            if (textbInput.Text == "")
            {
                textbInput.Text = "0";
                labelResult.Text = "";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            value1 = double.Parse(textbInput.Text);
            op = "/";
            textbInput.Text += "";
            isOpClicked = true;
            labelResult.Text = value1.ToString() + " /";
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            value1 = double.Parse(textbInput.Text);
            op = "*";
            textbInput.Text += "";
            isOpClicked = true;
            labelResult.Text = value1.ToString() + " *";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            value1 = double.Parse(textbInput.Text);
            op = "-";
            textbInput.Text += "";
            isOpClicked = true;
            labelResult.Text = value1.ToString() + " -";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            value1 = double.Parse(textbInput.Text);
            op = "+";
            textbInput.Text += "";
            isOpClicked = true;
            labelResult.Text = value1.ToString() + " +";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbInput.Text)) return;
            
            value2 = double.Parse(textbInput.Text);

            switch (op)
            {
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
                case "*":
                    result = value1 * value2;
                    break;
                case "/":
                    result = value1 / value2;
                    break;
                default:
                    break;
            }
            labelResult.Text = value1 + " " + op + " " + value2 + " = " + result;
            textbInput.Text = "";
            isOpClicked = false;
        }
    }
}
