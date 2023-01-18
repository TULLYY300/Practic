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

namespace Laba3
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

        private void Weather_Click(object sender, RoutedEventArgs e)
        {
            string w = Convert.ToString(WordTB.Text);
            switch (w)
            {
                case "Солнечно":
                    TrLB.Content = "Sunny";
                    break;
                case "Дождливо":
                    TrLB.Content = "Rainy";
                    break;
                case "Снежно":
                    TrLB.Content = "Snowy";
                    break;
                case "Холодно":
                    TrLB.Content = "Cold";
                    break;
                case "Тепло":
                    TrLB.Content = "Warm";
                    break;
                case "Облачно":
                    TrLB.Content = "Cloudy";
                    break;
                case "Туманно":
                    TrLB.Content = "Foggy";
                    break;
                case "Снегопад":
                    TrLB.Content = "Snow Fall";
                    break;
                case "Ветренно":
                    TrLB.Content = "Windy";
                    break;
                case "Пасмурно":
                    TrLB.Content = "Murke";
                    break;
                default:
                    TrLB.Content = "Такого слова нет";
                    break;

            }
        }

        private void Chislo_Click(object sender, RoutedEventArgs e)
        {
            Double a = Convert.ToDouble(ChisloVvod.Text);
            if (0 <= a & a < 15)
            {
                ChisloVivod.Content = "0 - 14";

            }
            else if (14 < a & a < 36)
            {
                ChisloVivod.Content = "15 - 35";
            }
            else if (35 < a & a < 51)
            {
                ChisloVivod.Content = "36 - 50";
            }
            else if (49 < a & a < 101)
            {
                ChisloVivod.Content = "50 - 100";
            }
            else
            {
                ChisloVivod.Content = "Цифра/число не входит ни в один из промежутков";
            }
        }

        private void schet_Click(object sender, RoutedEventArgs e)
        {
            string sign = Convert.ToString(znak.Text);
            int a = Convert.ToInt32(ch1.Text);
            int b = Convert.ToInt32(ch2.Text);

            switch (sign)
            {
                case "+":
                    vivod.Content = a + b;
                    break;
                case "-":
                    vivod.Content = a - b;
                    break;
                case "*":
                    vivod.Content = a * b;
                    break;
                case "/":
                    if (a < 1)
                    {
                        vivod.Content = "Ошибка , на ноль делить нельзя";
                        vivod.Foreground = Brushes.Red;
                    }
                    else if (b < 1)
                    {
                        vivod.Content = "Ошибка , на ноль делить нельзя";
                        vivod.Foreground = Brushes.Red;
                    }
                    else
                    {
                        vivod.Content = a / b;
                    }
                    break;

            }
        }
        string gg = "gg";
        private void passw_Click(object sender, RoutedEventArgs e)
        {
            string a = Convert.ToString(paspas.Text);
            if (a == gg)
            {
                massage.Text = "Ураааа";
            }
            else
                massage.Text = "Пароль неправильный";
        }
    }
}
