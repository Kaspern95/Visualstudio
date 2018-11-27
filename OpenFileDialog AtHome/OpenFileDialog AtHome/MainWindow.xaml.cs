using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace OpenFileDialog_AtHome
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

        private void FindSong_Click(object sender, RoutedEventArgs e)
        {
            string line;
            string[] fields;
            int charCount = 0;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "TextFiles|*.txt";
            bool? checkingFile = openFileDialog.ShowDialog();
            if (checkingFile == true)
            {
                ListBox.Items.Clear();
                StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                while (!streamReader.EndOfStream)
                {
                    int i = 0;
                    line = streamReader.ReadLine();
                    fields = line.Split(' ');
                    for (int j = 0; j < fields.Length; j++)
                    {
                        ListBox.Items.Add(fields[i].ToString());

                        foreach (char item in fields[i])
                        {
                            charCount++;
                        }
                        i++;
                    }

                }
                textcount.Content = charCount + "Tegn i teksten";
            }
        }

        private void FindWord_Click(object sender, RoutedEventArgs e)
        {
            string findWord = FindWordText.Text;
            int counter = 0;
            for (int i = 0; i < ListBox.Items.Count; i++)
            {
                if (findWord.ToLower() == ListBox.Items[i].ToString().ToLower())
                {
                    counter++;
                }
                if (counter >= 1)
                {
                    WordExistText.Text = $"{findWord} is in the text, and it happens {counter} times";
                }
                else
                {
                    WordExistText.Text = $"{findWord} did not exist in the text";
                }

            }
        }
    }
}
