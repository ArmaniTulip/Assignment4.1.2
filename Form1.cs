namespace Assignment4._1._2
{
    public partial class Calculator : Form, ICalculator
    {
        double firstNumber = 0;
        string Operation = "";

        public Calculator()
        {
            InitializeComponent();
        }

        public void Add()
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            Operation = "+";

        }

        public void Subtract()
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            Operation = "-";
        }

        public void Multiply()
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            Operation = "*";
        }

        public void Divide()
        {
            firstNumber = Convert.ToDouble(ResultTextBox.Text);
            ResultTextBox.Text = "0";
            Operation = "/";
        }

        private void Onebutton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "1";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "1";
            }

        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "2";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "2";
            }
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "3";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "3";
            }
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "4";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "4";
            }
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "5";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "5";
            }
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "6";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "6";
            }
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "7";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "7";
            }
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "8";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "8";
            }
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "9";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "9";
            }
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "0";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + "0";
            }
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = ".";
            }
            else
            {
                ResultTextBox.Text = ResultTextBox.Text + ".";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == "0" && ResultTextBox.Text != null)
            {
                ResultTextBox.Text = "0";
            }
            else
            {
                ResultTextBox.Text = "0";
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void SubrtactButton_Click(object sender, EventArgs e)
        {
            Subtract();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            Multiply();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            Divide();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            double secondNumber = 0;
            double result;
            result = firstNumber;

            secondNumber = Convert.ToDouble(ResultTextBox.Text);

            if (Operation == "+")
            {
                result = (firstNumber + secondNumber);
                ResultTextBox.Text = result.ToString();
            }
            if (Operation == "-")
            {
                result = secondNumber - firstNumber;
                ResultTextBox.Text = result.ToString();
            }
            if (Operation == "*")
            {
                result = secondNumber * firstNumber;
                ResultTextBox.Text = result.ToString();
            }
            if (Operation == "/")
            {
                if (secondNumber == 0)
                {
                    ResultTextBox.Text = "Cannot Divide by 0";
                }
                else
                {
                    result = secondNumber / firstNumber;
                    ResultTextBox.Text = result.ToString();
                }
            }
            return;
             
        }
        
    }
    
}


