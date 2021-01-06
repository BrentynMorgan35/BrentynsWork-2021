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

namespace ASP_019
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Text1.Text = "100";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            double answer;
            // get answer for box dimensions 
            try
            {
                a = int.Parse(Text1.Text);
                b = ((int)double.Parse(Text2.Text));
                c = int.Parse(Text3.Text);
                answer = a * b * c / 3;
                AnswerLabel.Content = answer.ToString();
            }
            catch (Exception)
            {
                AnswerLabel.Content = "Error 404 Anwser is Unknown";
            }
        }
    }
}


