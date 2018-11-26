using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace OFP___OpenFileDialog
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
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            string path;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(path = openFileDialog1.FileName);
                System.Windows.Forms.MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }
        }



        private void FindWord_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Return)
            {
                DoesWordExist.Content = "";
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.ShowDialog();
                string song = File.ReadAllText(openFileDialog1.FileName);
                char[] splitter = { ' ', '\n', '\r' };
                string[] text = song.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < text.Length; i++)
                {

                    if (text[i] == FindWord.Text)
                    {
                        DoesWordExist.Content = "YES!!";
                        break;
                    }
                    else
                    {
                        DoesWordExist.Content = "NO!!!";
                    }
                }
            }
        }

        private void openfile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Text Files|*.txt;|Pictures|*.png;*.jpeg;";
            openFileDialog.ShowDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] alleLinjer = File.ReadAllLines(openFileDialog.FileName);
            }
        }
    }
}
