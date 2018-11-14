using System;
using System.Windows;

namespace WPFTry
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
            string name = "rock";

            int number = InstantiatingRPS(name, 0);
            int aiNumber = CreateNumber();

            if (aiNumber == number)
            {
                Output.Content = "Tied!";
            }
            else if (aiNumber == 2)
            {
                Output.Content = "You Lost!";
            }
            else if (aiNumber == 3)
            {
                Output.Content = "You Win!";
            }
            DisableButtons();
        }
        private void Paper_Click(object sender, RoutedEventArgs e)
        {
            string name = "paper";
            
            int number = InstantiatingRPS(name, 0);
            int aiNumber = CreateNumber();

            if (aiNumber == number)
            {
                Output.Content = "Tied!";
            }
            else if (aiNumber == 1)
            {
                Output.Content = "You Win!";
            }
            else if (aiNumber == 3)
            {
                Output.Content = "You Lost!";
            }
            DisableButtons();
        }

        private void Scissor_Click(object sender, RoutedEventArgs e)
        {
            string name = "scissor";
            
            int number = InstantiatingRPS(name, 0);
            int aiNumber = CreateNumber();

            if (aiNumber == number)
            {
                Output.Content = "Tied!";
            }
            else if (aiNumber == 1)
            {
                Output.Content = "You Lost!";
            }
            else if (aiNumber == 3)
            {
                Output.Content = "You Win!";
            }
            DisableButtons();
        }

        private void DisplayAINumber()
        {
            
        }

        private int InstantiatingRPS(string name, int number)
        {
            if (name == "rock")
            {
                Rock rock = new Rock("Rock", 1);
                number = rock.number;
            }
            else if (name == "paper")
            {
                Paper paper = new Paper("Paper", 2);
                number = paper.number;
            }
            else if (name == "scissor")
            {
                Scissor scissor = new Scissor("Scissor", 3);
                number = scissor.number;
            }
            return number;
        }
        private void DisableButtons()
        {
            Paper.IsEnabled = false;
            Rock.IsEnabled = false;
            Scissor.IsEnabled = false;
        }
        private int CreateNumber()
        {
            Random rnd = new Random();
            int PCNR = rnd.Next(1, 4);
            AI ai = new AI(PCNR);
            return ai.number;
        }
    }
}
