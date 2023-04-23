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

namespace Dop_2_1
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

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            int A1 = Convert.ToInt32(polA1.Text);
            int B1 = Convert.ToInt32(polB1.Text);
            int C1 = Convert.ToInt32(polC1.Text);
            int A2 = Convert.ToInt32(polA2.Text);
            int B2 = Convert.ToInt32(polB2.Text);
            int C2 = Convert.ToInt32(polC2.Text);
            int D = (A1 * B2) - (B1 * A2);
            double x = (double)(C1 * B2 - C2 * B1) / D;
            double y = (double)(A1 * C2 - A2 * C1) / D;
            Otvx.Content = $" x = {x}";
            Otvy.Content = $" y = {y}";
        }
    }
}
