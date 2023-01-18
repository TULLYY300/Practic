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

namespace Task_5
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
        private double Add(double value1, double value2)
        {
            return value1 + value2;
        }
        private double Sub(double value1, double value2)
        {
            return value1 - value2;
        }
        private double Mul(double value1, double value2)
        {
            return value1 * value2;
        }
        private double Div(double value1, double value2)
        {
            if (value1 == 0 || value2 == 0)
            {
                MessageBox.Show("Деление на ноль", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return 0;
            }
            else
            {

                return Math.Round(value1 / value2, 4);
            }
        }
        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double value1 = Value_1.Text != "" ? Convert.ToDouble(Value_1.Text) : 0;
                double value2 = Convert.ToDouble(Value_2.Text);

                switch (Combo_Function.SelectedIndex)
                {
                    case 0:
                        ResultLabel.Content = "" + Add(value1, value2);
                        break;
                    case 1:
                        ResultLabel.Content = "" + Sub(value1, value2);
                        break;
                    case 2:
                        ResultLabel.Content = "" + Div(value1, value2);
                        break;
                    case 3:
                        ResultLabel.Content = "" + Mul(value1, value2);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Неккоректный ввод данных", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            Close();
        }
    }
}
