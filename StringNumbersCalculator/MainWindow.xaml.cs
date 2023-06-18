using StringNumbersMath;
using System.Windows;

namespace StringNumbersCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string result = "";
        private bool intermediateResult = false;
        private string operation = "";
        private bool calcResult = false;
        private string operand = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateResult()
        {
            switch(operation)
            {
                case "+":
                    result = Summation.Sum(result, operand);
                    break;
                case "*":
                    result = Multiplication.Multiply(result, operand);
                    break;
                case "/":
                    result = Division.Divide(result, operand);
                    break;
            }
        }

        private void Handle_OperationClick(string operation)
        {
            if (intermediateResult) return;

            if (this.operation is "")
            {
                this.operation = operation;
            }

            operand = CurrentInput.Text;

            if (result is "") result = operand;
            else CalculateResult();

            this.operation = operation;
            if (calcResult)
            {
                PastInput.Text = $"{CurrentInput.Text} {this.operation} ";
            }
            else
            {
                PastInput.Text += $"{CurrentInput.Text} {this.operation} ";
            }

            CurrentInput.Text = result;
            intermediateResult = true;
        }

        private void BtnDivision_Click(object sender, RoutedEventArgs e)
        {
            Handle_OperationClick("/");
        }
        private void BtnMultiplication_Click(object sender, RoutedEventArgs e)
        {
            Handle_OperationClick("*");
        }
        private void BtnSummation_Click(object sender, RoutedEventArgs e)
        {
            Handle_OperationClick("+");
        }
        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            if (result is "") result = CurrentInput.Text;
            else CalculateResult();

            if (operation is "")
            {
                string curOperand = CurrentInput.Text == "" ? "0" : CurrentInput.Text;
                PastInput.Text = $"{curOperand} = ";
            }
            else
            {
                PastInput.Text = $"{result} {operation} {operand} = ";
            }

            CurrentInput.Text = result;
            intermediateResult = true;
            calcResult = true;
        }

        private void Reset()
        {
            PastInput.Text = "";
            result = "";
            operation = "";
            calcResult = false;
        }

        private void Handle_DigitClick(string digit)
        {
            if (intermediateResult)
            {
                CurrentInput.Text = digit;
                intermediateResult = false;

                if (calcResult) Reset();
            }
            else CurrentInput.Text += digit;
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            Handle_DigitClick("0");
        }
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            Handle_DigitClick("1");
        }
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            Handle_DigitClick("2");
        }
        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            Handle_DigitClick("3");
        }
        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            Handle_DigitClick("4");
        }
        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            Handle_DigitClick("5");
        }
        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            Handle_DigitClick("6");
        }
        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            Handle_DigitClick("7");
        }
        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            Handle_DigitClick("8");
        }
        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            Handle_DigitClick("9");
        }
    }
}
