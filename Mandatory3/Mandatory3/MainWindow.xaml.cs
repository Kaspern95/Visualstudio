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

namespace Mandatory3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Puzzle game;
        public MainWindow()
        {
            InitializeComponent();
            game = new Puzzle();
            DataContext = game;
        }
        /// <summary>
        /// Reset all and mixes pieces on gameboard
        /// </summary>
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Implementet a test which shows how to swap values (content) on two buttons 
        /// </summary>
        private void btn00_Click(object sender, RoutedEventArgs e)
        {
            if (game.GamePieces[0][1].PieceValue == 0)
            {
                game.TestAndSwap(0, 1, 0, 0);
            }
            if (game.GamePieces[1][0].PieceValue == 0)
            {
                game.TestAndSwap(1, 0, 0, 0);
            }
        }

        private void btn01_Click(object sender, RoutedEventArgs e)
        {
            if (game.GamePieces[0][0].PieceValue == 0)
            {
                game.TestAndSwap(0, 0, 0, 1);
            }
            else if (game.GamePieces[0][2].PieceValue == 0)
            {
                game.TestAndSwap(0, 2, 0, 1);
            }
            else if (game.GamePieces[1][1].PieceValue == 0)
            {
                game.TestAndSwap(1, 1, 0, 1);
            }
        }

        private void btn02_Click(object sender, RoutedEventArgs e)
        {
            if (game.GamePieces[0][1].PieceValue == 0)
            {
                game.TestAndSwap(0, 1, 0, 2);
            }
            else if (game.GamePieces[1][2].PieceValue == 0)
            {
                game.TestAndSwap(1, 2, 0, 2);
            }
        }

        private void btn03_Click(object sender, RoutedEventArgs e)
        {
            if (game.GamePieces[0][0].PieceValue == 0)
            {
                game.TestAndSwap(0, 0, 1, 1);
            }
            else if (game.GamePieces[1][1].PieceValue == 0)
            {
                game.TestAndSwap(1,1,1,2);
            }
        }
    }
}
