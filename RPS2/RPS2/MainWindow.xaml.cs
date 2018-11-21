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

namespace RPS2
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

        private void Rock_Click(object sender, RoutedEventArgs e)
        {
            Game game = new Game();
            game.RockWin();
           
        }

        private void Paper_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Scissor_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
