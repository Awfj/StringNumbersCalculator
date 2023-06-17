using StringNumbersMath;
using System.Windows;

namespace StringNumbersCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string result;
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
            result = result is null ? operand : Summation.Sum(result, operand);
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

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (intermediateResult) CurrentInput.Text = "0";
            else CurrentInput.Text += "0";
        }
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (intermediateResult) CurrentInput.Text = "1";
            else CurrentInput.Text += "1";
        }
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (intermediateResult)
            {
                CurrentInput.Text = "2";
                intermediateResult = false;
            }
            else CurrentInput.Text += "2";
        }
        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (intermediateResult)
            {
                CurrentInput.Text = "3";
                intermediateResult = false;
            }
            else CurrentInput.Text += "3";
        }
        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (intermediateResult)
            {
                CurrentInput.Text = "4";
                intermediateResult = false;
            }
            else CurrentInput.Text += "4";
        }
        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (intermediateResult)
            {
                CurrentInput.Text = "5";
                intermediateResult = false;
            }
            else CurrentInput.Text += "5";
        }
        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (intermediateResult) {
                CurrentInput.Text = "6";
                intermediateResult = false;
            }
            else CurrentInput.Text += "6";
        }
        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (intermediateResult) {
                CurrentInput.Text = "7";
                intermediateResult = false;
            }
            else CurrentInput.Text += "7";
        }
        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (intermediateResult) {
                CurrentInput.Text = "8";
                intermediateResult = false;
            }
            else CurrentInput.Text += "8";
        }
        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (intermediateResult) {
                CurrentInput.Text = "9";
                intermediateResult = false;
            }
            else CurrentInput.Text += "9";
        }
    }
}
