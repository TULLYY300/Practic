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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double value1 = Convert.ToDouble(Value_1.Text);

                if (ValutaCombo.SelectedIndex == 0)
                {
                    MessageBox.Show($"{value1}р = {value1 * 0.015d}usd");
                }
                else
                {

                    MessageBox.Show($"{value1}р : {value1 * 0.013d}eur");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            Close();
        }
    }
}
