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

namespace labb4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.choice.Items.Add("до 5");
            this.choice.Items.Add("5-10");
            this.choice.Items.Add("10-15");
            this.choice.Items.Add("15-20");
            this.choice.Items.Add("20-25");
            this.choice.Items.Add("25 более");
        }

        // Задание2
        private void a1_Click(object sender, RoutedEventArgs e)
        {
            int n = 1;
            int r = 1;
            n = Convert.ToInt32(c1.Text);
            for (int i = 1; i <= n; i++)
            {
                r = r * i;
            }
            d1.Content = r;
        }
        //Задание 4
        private void a2_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(c2.Text);
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                a += i;
                d2.Content = a;
            }
        }
        // Задание 6
        private void a3_Click(object sender, RoutedEventArgs e)
        {
            int s = 1;
            int s1 = 1;
            try
            {
                int f = Convert.ToInt32(FA.Text);
                if (s == f | f == 0)
                    l.Text = "1";
                else
                {
                by:
                    {
                        s = s * (s1 + 1);
                        s1++;
                    }

                    if (s1 == f)
                        l.Text = Convert.ToString(s);
                    else
                        goto by;
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат данных!");
            }
        }


        // Задание 3
        private void Butt_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 10; i <= 20; i++)
            {
                d4.Content += $"{Math.Pow(i, 2)}" + " ";
            }
        }
        



       // Задание 5


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (choice.SelectedIndex)
                {
                    case 0:
                        double x = Convert.ToDouble(payment.Text);
                        g1.Content = x * 1.0;
                        break;
                    case 1:
                        double y = Convert.ToDouble(payment.Text);
                        g1.Content = y * 1.5;
                        break;
                    case 2:
                        double z = Convert.ToDouble(payment.Text);
                        g1.Content = z * 2.5;
                        break;
                    case 3:
                        double h = Convert.ToDouble(payment.Text);
                        g1.Content = h * 3.5;
                        break;
                    case 4:
                        double v = Convert.ToDouble(payment.Text);
                        g1.Content = v * 4.5;
                        break;
                    case 5:
                        double m = Convert.ToDouble(payment.Text);
                        g1.Content = m * 5.0;
                        break;


                }
            }
            catch
            {
                g2.Content = "";
            }
        }
        // Задание 1

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int A = Convert.ToInt32(a.Text);
            int B = Convert.ToInt32(b.Text);
            int summ = 0;
            for (int i = A + 1; i < B; i++)
            {
                summ += i;
            }
            c5.Content = summ;


            for (int i = A + 1; i < B; i++)
            {
                if (i % 2 == 0)
                {
                    c6.Content += $"{i}:";
                }
            }
        }
    }
    }

