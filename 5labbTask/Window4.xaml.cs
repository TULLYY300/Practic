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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        private int result = 1;
        private int i = 0;
        private int n = 0;
        public Window4()
        {
            InitializeComponent();
        }
        private void Factorial(int value)
        {
            if (i < n)
            {
                i++;
                result *= i;
                Factorial(n);
            }
            else
            {
                MessageBox.Show(result.ToString());
                
            }
            
        }
        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                n = Convert.ToInt32(ResultBox.Text);
                result = 1;
                i = 0;
                Factorial(n);

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
