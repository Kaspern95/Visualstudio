using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;

namespace DatabaseWPF
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

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            string name = Name.Text;
            int value;
            int ageParse;
            string check = Regex.Replace(name, @"[\d-]", string.Empty);
            if (check == "")
            {
                nameFail.Content = "Name input is required";
                Name.Text = "";
            }
            else
            {
                nameFail.Content = "";
            }
            if (int.TryParse(Age.Text, out value) && value != 0)
            {
                ageParse = int.Parse(Age.Text);
                ageFail.Content = "";
            }
            else
            {
                ageFail.Content = "Age input is required";
                Age.Text = "";
            }
            if (value > 0 && check != "")
            {
                ageParse = int.Parse(Age.Text);
                DAL.CreatePerson(name, ageParse);
                database.Content = "Database updated!";

                nameFail.Content = "";
                ageFail.Content = "";
            }



        }

        private void Read_Click(object sender, RoutedEventArgs e)
        {
            
            List<Person> allPersons = DAL.GetAllPerson();
            ListBox.ItemsSource = allPersons;
        }

    }
}
