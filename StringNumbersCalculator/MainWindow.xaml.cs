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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateResult()
        {
            switch(operation)
            {
                case "+":
                    result = Summation.Sum(result, CurrentInput.Text);
                    break;
                case "*":
                    result = Multiplication.Multiply(result, CurrentInput.Text);
                    break;
                case "/":
                    result = Division.Divide(result, CurrentInput.Text);
                    break;
            }
        }

        private void Handle_OperationClick(string operation)
        {
            if (this.operation is "")
            {
                this.operation = operation;
            }

            if (result is "") result = CurrentInput.Text;
            else CalculateResult();

            this.operation = operation;
            PastInput.Text += $"{CurrentInput.Text} {this.operation} ";
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
            CalculateResult();
            PastInput.Text += $"{CurrentInput.Text} = ";
            CurrentInput.Text = result;
            intermediateResult = true;
        }

        private void Handle_DigitClick(string digit)
        {
            if (intermediateResult)
            {
                CurrentInput.Text = digit;
                intermediateResult = false;
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
