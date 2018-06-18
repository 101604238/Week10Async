using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AsyncClassLibrary;

namespace Task3WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void primeNumber_Click(object sender, RoutedEventArgs e)
        {
            int n = Int32.Parse(inputTextBox.Text);


            resultLabel.Text = PrimeNumbers.FindPrimeNumbersSync(n).ToString(); ;
        }
    }
}
