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
using static System.Math;

namespace v10_4
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
            double Lya = Convert.ToDouble(NumberLya.Text);
            double l = Convert.ToDouble(Numberl.Text);
            double L = 1 + 24.86 * Pow(10, -2);

            double D = (L + Sin(l * Lya)) / (2 + Cos(Pow(Lya, 2))) + Lya - Pow(10, Lya);

            NAnswer.Content = D;
        }

    }
}
