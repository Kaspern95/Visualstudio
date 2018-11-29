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
        Puzzle mix;
        Puzzle win;
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
            mix = new Puzzle();
            mix.Mix();
            
            game = new Puzzle();
            DataContext = game;
            LabelWin.Content = "";
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
                game.TestAndSwap(0, 0, 1, 0);
            }
            else if (game.GamePieces[1][1].PieceValue == 0)
            {
                game.TestAndSwap(1, 1, 1, 0);
            }
            else if (game.GamePieces[2][0].PieceValue == 0)
            {
                game.TestAndSwap(2, 0, 1, 0);
            }
        }

        private void btn04_Click(object sender, RoutedEventArgs e)
        {
            if (game.GamePieces[0][1].PieceValue == 0)
            {
                game.TestAndSwap(0, 1, 1, 1);
            }
            else if (game.GamePieces[1][0].PieceValue == 0)
            {
                game.TestAndSwap(1, 0, 1, 1);
            }
            else if (game.GamePieces[1][2].PieceValue == 0)
            {
                game.TestAndSwap(1, 2, 1, 1);
            } 
            else if (game.GamePieces[2][1].PieceValue == 0)
            {
                game.TestAndSwap(2, 1, 1, 1);
            }
        }

        private void btn05_Click(object sender, RoutedEventArgs e)
        {
            if (game.GamePieces[0][2].PieceValue == 0)
            {
                game.TestAndSwap(0, 2, 1, 2);
            }
            else if (game.GamePieces[1][1].PieceValue == 0)
            {
                game.TestAndSwap(1, 1, 1, 2);
            }
            else if (game.GamePieces[2][2].PieceValue == 0)
            {
                game.TestAndSwap(2, 2, 1, 2);
            }
            LabelWin.Content = "";
        }

        private void btn06_Click(object sender, RoutedEventArgs e)
        {
            if (game.GamePieces[1][0].PieceValue == 0)
            {
                game.TestAndSwap(1, 0, 2, 0);
            }
            else if (game.GamePieces[2][1].PieceValue == 0)
            {
                game.TestAndSwap(2, 1, 2, 0);
            }
        }

        private void btn07_Click(object sender, RoutedEventArgs e)
        {
            if (game.GamePieces[1][1].PieceValue == 0)
            {
                game.TestAndSwap(1, 1, 2, 1);
            }
            else if (game.GamePieces[2][0].PieceValue == 0)
            {
                game.TestAndSwap(2, 0, 2, 1);
            }
            else if (game.GamePieces[2][2].PieceValue == 0)
            {
                game.TestAndSwap(2, 2, 2, 1);
            }
            LabelWin.Content = "";
        }

        private void btn08_Click(object sender, RoutedEventArgs e)
        {
            if (game.GamePieces[1][2].PieceValue == 0)
            {
                game.TestAndSwap(1, 2, 2, 2);
            }
            else if (game.GamePieces[2][1].PieceValue == 0)
            {
                game.TestAndSwap(2, 1, 2, 2);
            }
            if (game.GamePieces[0][0].PieceValue == 1 && game.GamePieces[0][1].PieceValue == 2 && game.GamePieces[0][2].PieceValue == 3
                            && game.GamePieces[1][0].PieceValue == 4 && game.GamePieces[1][1].PieceValue == 5 && game.GamePieces[1][2].PieceValue == 6
                            && game.GamePieces[2][0].PieceValue == 7 && game.GamePieces[2][1].PieceValue == 8 && game.GamePieces[2][2].PieceValue == 0)
            {
                LabelWin.Content = "YOU WIN!";
                
            }

        }
    }
}
