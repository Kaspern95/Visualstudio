using System;
using System.Windows;
using System.Windows.Media.Imaging;

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

            BitmapImage playerimg = new BitmapImage();
            playerimg.BeginInit();
            playerimg.UriSource = new Uri(@"C:\Users\kasper\Documents\GitHub\Visualstudio\WPFTry\WPFTry\bin\Debug\img\rock.png");
            playerimg.EndInit();
            playerImage.Source = playerimg;

            int number = InstantiatingRPS(name, 0);
            int aiNumber = CreateNumber();
            string url = CreateImg(aiNumber);

            BitmapImage aiimg = new BitmapImage();
            aiimg.BeginInit();

            if (aiNumber == number)
            {
                Output.Content = "Tied!";
                aiimg.UriSource = new Uri(url);
            }
            else if (aiNumber == 2)
            {
                Output.Content = "You Lost!";
                aiimg.UriSource = new Uri(url);
            }
            else if (aiNumber == 3)
            {
                Output.Content = "You Win!";
                aiimg.UriSource = new Uri(url);
            }
            aiimg.EndInit();
            aiImage.Source = aiimg;

            DisableButtons();
        }

        private void Paper_Click(object sender, RoutedEventArgs e)
        {
            string name = "paper";

            BitmapImage playerimg = new BitmapImage();
            playerimg.BeginInit();
            playerimg.UriSource = new Uri(@"C:\Users\kasper\Documents\GitHub\Visualstudio\WPFTry\WPFTry\bin\Debug\img\paper.png");
            playerimg.EndInit();
            playerImage.Source = playerimg;

            int number = InstantiatingRPS(name, 0);
            int aiNumber = CreateNumber();
            string url = CreateImg(aiNumber);

            BitmapImage aiimg = new BitmapImage();
            aiimg.BeginInit();

            if (aiNumber == number)
            {
                Output.Content = "Tied!";
                aiimg.UriSource = new Uri(url);
            }
            else if (aiNumber == 1)
            {
                Output.Content = "You Win!";
                aiimg.UriSource = new Uri(url);
            }
            else if (aiNumber == 3)
            {
                Output.Content = "You Lost!";
                aiimg.UriSource = new Uri(url);
            }
            aiimg.EndInit();
            aiImage.Source = aiimg;

            DisableButtons();
        }

        private void Scissor_Click(object sender, RoutedEventArgs e)
        {
            string name = "scissor";

            BitmapImage playerimg = new BitmapImage();
            playerimg.BeginInit();
            playerimg.UriSource = new Uri(@"C:\Users\kasper\Documents\GitHub\Visualstudio\WPFTry\WPFTry\bin\Debug\img\scissor.png");
            playerimg.EndInit();
            playerImage.Source = playerimg;


            int number = InstantiatingRPS(name, 0);
            int aiNumber = CreateNumber();
            string url = CreateImg(aiNumber);

            BitmapImage aiimg = new BitmapImage();
            aiimg.BeginInit();

            if (aiNumber == number)
            {
                Output.Content = "Tied!";
                aiimg.UriSource = new Uri(url);
                
            }
            else if (aiNumber == 1)
            {
                Output.Content = "You Lost!";
                aiimg.UriSource = new Uri(url);
                
            }
            else if (aiNumber == 2)
            {
                Output.Content = "You Win!";
                aiimg.UriSource = new Uri(url);
                
            }
            aiimg.EndInit();
            aiImage.Source = aiimg;

            DisableButtons();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Paper.IsEnabled = true;
            Rock.IsEnabled = true;
            Scissor.IsEnabled = true;
            Output.Content = "Result";

            BlankImages();
        }
        private string CreateImg(int aiNumber)
        {
            string url = "";
            if (aiNumber == 1)
            {
                url = @"C:\Users\kasper\Documents\GitHub\Visualstudio\WPFTry\WPFTry\bin\Debug\img\rock.png";
            }
            else if (aiNumber == 2)
            {
                url = @"C:\Users\kasper\Documents\GitHub\Visualstudio\WPFTry\WPFTry\bin\Debug\img\paper.png";
            }
            else if (aiNumber == 3)
            {
                url = @"C:\Users\kasper\Documents\GitHub\Visualstudio\WPFTry\WPFTry\bin\Debug\img\scissor.png";
            }
            return url;
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
        private void BlankImages()
        {
            BitmapImage playerimg = new BitmapImage();
            playerimg.BeginInit();
            playerimg.UriSource = new Uri(@"C:\Users\kasper\Documents\GitHub\Visualstudio\WPFTry\WPFTry\bin\Debug\img\blank.png");
            playerimg.EndInit();
            playerImage.Source = playerimg;

            BitmapImage aiimg = new BitmapImage();
            aiimg.BeginInit();
            aiimg.UriSource = new Uri(@"C:\Users\kasper\Documents\GitHub\Visualstudio\WPFTry\WPFTry\bin\Debug\img\blank.png");
            aiimg.EndInit();
            aiImage.Source = aiimg;
        }
    }
}
