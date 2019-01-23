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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int first = int.Parse(tbFrtNumber.Text);
            int second = int.Parse(tbSecNumber.Text);

            lblCalculateResAdd.Content = first + "+" + second + "=" + (first + second);
            lblCalculateResSub.Content = first + "-" + second + "=" + (first - second);
            lblCalculateResMult.Content = first + "x" + second + "=" + (first * second);
            lblCalculateResDiv.Content = first + "/" + second + "=" + (first / second);
        }
    }
}
