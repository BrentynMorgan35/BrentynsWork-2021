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

namespace CS_ASP_022
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // string[] values = new string[5];

            //values[0] = textBox0.Text;
            //values[1] = textBox1.Text;
            //values[2] = textBox2.Text;
            // values[3] = textBox3.Text;
            // values[4] = textBox4.Text;

            //resultsLabel.Content = values[2];
            // resultsLabel.Content = values.Length.ToString();

            string[] values = new string[5] { "Bob", "Steve", "Mike", "bill", "Don" };

            resultsLabel.Content = values[2];

        }

        private void buttonRetrive_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
    