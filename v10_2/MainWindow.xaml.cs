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

namespace v10_2
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
            double x1 = Convert.ToDouble(NumberX1.Text);
            double x2 = Convert.ToDouble(NumberX2.Text);
            double x3 = Convert.ToDouble(NumberX3.Text);
            double y1 = Convert.ToDouble(NumberY1.Text);
            double y2 = Convert.ToDouble(NumberY2.Text);
            double y3 = Convert.ToDouble(NumberY3.Text);

            double a = Sqrt(Pow(x2 - x1, 2) + Pow(y2 - y1, 2));
            double b = Sqrt(Pow(x3 - x2, 2) + Pow(y3 - y2, 2));
            double c = Sqrt(Pow(x1 - x3, 2) + Pow(y1 - y3, 2));

            double p = (a + b + c) / 2;
            double S = Sqrt(p * (p - a) * (p - b) * (p - c));
            double P = a + b + c;

            NAnswer.Content = $"S = {S} \nP = {P}";
        }
    }
}
