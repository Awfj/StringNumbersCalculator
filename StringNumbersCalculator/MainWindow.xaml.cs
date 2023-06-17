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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnDivision_Click(object sender, RoutedEventArgs e)
        {
            PastInput.Text += CurrentInput.Text + " / ";
        }
        private void BtnMultiplication_Click(object sender, RoutedEventArgs e)
        {
            PastInput.Text += CurrentInput.Text + " * ";
        }
        private void BtnSummation_Click(object sender, RoutedEventArgs e)
        {
            string operand = CurrentInput.Text;

            PastInput.Text += CurrentInput.Text + " + ";
            result = string.IsNullOrEmpty(result) 
                ? operand 
                : Summation.Sum(result, operand);

            CurrentInput.Text = result;
            intermediateResult = true;
        }
        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            string operand1 = result;
            string operand2 = CurrentInput.Text;
            string operation = "+";

            string sum = Summation.Sum(operand1, operand2);
            MessageBox.Show(sum);
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
