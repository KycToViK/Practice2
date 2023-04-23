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

namespace dop1
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
            int A = Convert.ToInt32(polA.Text);
            int B = Convert.ToInt32(polB.Text);
            int C = Convert.ToInt32(polC.Text);

            int S = A * B;
            int ObS1 = A / C;
            int ObS2 = B / C;
            int pol = ObS1 * ObS2;
            double pon = Pow(C,2);
            double S1 = S - pol * pon;
            
            Otv.Content = $"Ответ:полных {pol} пустых {S1}";
            

        }
    }
}
