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

namespace calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private (int first_Number, int second_Number) GetTupleOfNumbers()
        {
            var text_1 = text_Box_1.Text;
            var text_2 = text_Box_2.Text;

            int first_number;
            int second_number;

            try
            {
                first_number = Convert.ToInt32(text_1);
            }
            catch(FormatException)
            {
                first_number = 0;
            }

            try
            {
                second_number = Convert.ToInt32(text_2);
            }
            catch (FormatException)
            {
                second_number = 0;
            }

            return (first_number, second_number);
        }

        private void Summarize(object sender, RoutedEventArgs e)
        {
            var numbers = GetTupleOfNumbers();

            int sum = numbers.first_Number + numbers.second_Number;
            MessageBox.Show(Convert.ToString(sum));
        }

        private void Residual(object sender, RoutedEventArgs e)
        {
            var numbers = GetTupleOfNumbers();

            int res = numbers.first_Number - numbers.second_Number;
            MessageBox.Show(Convert.ToString(res));
        }

        private void Multiply(object sender, RoutedEventArgs e)
        {
            var numbers = GetTupleOfNumbers();

            int mul = numbers.first_Number * numbers.second_Number;
            MessageBox.Show(Convert.ToString(mul));
        }

        private void Divide(object sender, RoutedEventArgs e)
        {
            var numbers = GetTupleOfNumbers();

            int div = numbers.first_Number / numbers.second_Number;
        }

        private void GetSin(object sender, RoutedEventArgs e)
        {
            var numbers = GetTupleOfNumbers();
            double sin = 0;


            if (numbers.first_Number != 0)
            {
                sin = Math.Sin(numbers.first_Number);
            }

            if (numbers.second_Number != 0)
            {
                sin = Math.Sin(numbers.second_Number);
            }

            MessageBox.Show(Convert.ToString(sin));
        }

        private void GetCos(object sender, RoutedEventArgs e)
        {
            var numbers = GetTupleOfNumbers();
            double cos = 0;


            if (numbers.first_Number != 0)
            {
                cos = Math.Cos(numbers.first_Number);
            }

            if (numbers.second_Number != 0)
            {
                cos = Math.Cos(numbers.second_Number);
            }

            MessageBox.Show(Convert.ToString(cos));
        }

        private double Tang()
        {
            var numbers = GetTupleOfNumbers();
            double tan = 0;


            if (numbers.first_Number != 0)
            {
                tan = Math.Tan(numbers.first_Number);
            }

            if (numbers.second_Number != 0)
            {
                tan = Math.Tan(numbers.second_Number);
            }
            return tan;
        }

        private void GetTang(object sender, RoutedEventArgs e)
        {
            double tan = Tang();
            MessageBox.Show(Convert.ToString(tan));
        }

        private void GetCotang(object sender, RoutedEventArgs e)
        {
            double cotan_Of_Sum = 1 / Tang();
            MessageBox.Show(Convert.ToString(cotan_Of_Sum));
        }

        private void GetLargerNumber(object sender, RoutedEventArgs e)
        {
            var numbers = GetTupleOfNumbers();

            if (numbers.first_Number > numbers.second_Number)
            {
                MessageBox.Show(Convert.ToString(numbers.first_Number));
            }

            if (numbers.first_Number < numbers.second_Number)
            {
                MessageBox.Show(Convert.ToString(numbers.second_Number));
            }

            if (numbers.first_Number == numbers.second_Number)
            {
                MessageBox.Show(Convert.ToString("Числа равны"));
            }
        }

        private void GetLeastNumber(object sender, RoutedEventArgs e)
        {
            var numbers = GetTupleOfNumbers();

            if (numbers.first_Number < numbers.second_Number)
            {
                MessageBox.Show(Convert.ToString(numbers.first_Number));
            }

            if (numbers.first_Number > numbers.second_Number)
            {
                MessageBox.Show(Convert.ToString(numbers.second_Number));
            }

            if (numbers.first_Number == numbers.second_Number)
            {
                MessageBox.Show(Convert.ToString("Числа равны"));
            }
        }
    }
}
