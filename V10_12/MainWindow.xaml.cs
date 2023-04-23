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

namespace V10_12
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
            if (a < 0)
            {
                NumberA.Text = "A !< 0";
            }
            double b = Convert.ToDouble(NumberB.Text);
            if (b < 0)
            {
                NumberA.Text = "B !< 0";
            }

            if (a >= 0 && b >= 0)
            {
                double c = Math.Sqrt(a * b);
                NAnswer.Content = c;
            }


        }

    }
}
