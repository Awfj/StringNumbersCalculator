using StringNumbersMath;
using System.Windows;

namespace StringNumbersCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string sum = Summation.Sum("8120512598120992175118257120", "158957120951208905921182901293");
            MessageBox.Show(sum);
        }
    }
}
