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

namespace v10_3
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

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(NumberA.Text);

            if (a >= 0 && a < 2 * 3.14)
            {
                double b = a * 180;


                NAnswer.Content = b;
            }
            else
            {
                NAnswer.Content = "a !>= 0 || a !< 2 * 3.14";
            }

        }
    }
}
