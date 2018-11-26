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

namespace FunWithXaml
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            List<Person> list = new List<Person>() { new Person("Peter", 20), new Person("Klaus", 25), new Person("Pernille", 25)};
        public MainWindow()
        {
            InitializeComponent();
            TBFILL.Text = "This IS A MEGA LONG STRING" +
                "This IS A MEGA LONG STRING" +
                "This IS A MEGA LONG STRING" +
                "This IS A MEGA LONG STRING";
            LB.ItemsSource = list;
        }

        private void MyButton(object sender, RoutedEventArgs e)
        {

        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
        }
    }
}
