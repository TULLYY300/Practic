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
using System.Windows.Shapes;

namespace Task_5
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private string UniversalOpredelitel(double value)
        {
            string result = value > 0 ? "Положительное\n" : "Отрицательное\n";
            string result2 = "";
            string result3;
            if(value == 1)
            {
                result2 = "Простой\n";
            }
            else if(value == 2)
            {
                result2 = "Составной\n"; 
            }
            else
            {
                for (int i = 2; i <= value ; i++)
                {
                    if (value % i > 0 || i == value)
                    {
                        result2 = "Простой\n";
                    }
                    else
                    {
                        result2 = "Составной\n";
                        break;
                    }
                }
            }
            if(value % 2 == 0 && value % 5 == 0 && value % 3 == 0 && value % 6 == 0 && value % 9 == 0)
            {
                result3 = "Без остатка\n";
            }
            else
            {
                result3 = "С остатком\n";
            }
            result += result2 + result3;
            return result;
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double value1 = Convert.ToDouble(Value_1.Text);

                MessageBox.Show(UniversalOpredelitel(value1));
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
            Close();
        }
    }
}
