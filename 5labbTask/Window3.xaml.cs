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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        private double credit = 700;
        public Window3()
        {
            InitializeComponent();
        }
        private void Plata(double suma)
        {
            credit -= suma;
            string result = ($"Сумма долга: {700}\nВнесенно: {suma}\n") + (credit <= 0 ? $"Кредит погашен\nПереплата: {Math.Abs(credit)}": $"Осталось внести: {credit}");
            MessageBox.Show(result);
        }
        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double value1 = Convert.ToDouble(Value_1.Text);

                Plata(value1);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
            Close();
        }
    }
}
