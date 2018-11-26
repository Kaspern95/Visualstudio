using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace WPFDatabase
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

            string functionName = "Create";
            InputChecking(functionName);
        }


        private void Read_Click(object sender, RoutedEventArgs e)
        {
            List<Person> people = DAL.AllPeople();

            ListBox.ItemsSource = people;
            DatabaseLB.Content = "";
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            DatabaseLB.Content = "";
            List<Person> people = DAL.AllPeople();
            int value;
            string name = TextUpdateName.Text;
            string newName = TextName.Text;
            int newAge = int.Parse(TextAge.Text);
            for (int i = 0; i < people.Count; i++)
            {

                if ((int.TryParse(TextUpdateAge.Text, out value) && people[i].Age == value && people[i].Name == name))
                {
                    DAL.UpdatePerson(name, value, newName, newAge);
                    DatabaseLB.Content = "Database Updated!";
                    NameUpdate.Content = "Name Updated!";
                    AgeUpdate.Content = "Age Updated!";
                }
            }


        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            string functionName = "Delete";
            InputChecking(functionName);
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            string functionName = "Select";
            InputChecking(functionName);
        }


        private void InputChecking(string functionName)
        {
            string name = TextName.Text;
            int value;
            int age;
            string check = Regex.Replace(name, @"[\d-]", string.Empty);
            DatabaseLB.Content = "";
            if (check == "")
            {
                NameFail.Content = "Name required";
                TextName.Text = "";
            }
            else
            {
                NameFail.Content = "";
            }
            if (int.TryParse(TextAge.Text, out value) && value != 0)
            {
                age = int.Parse(TextAge.Text);
                AgeFail.Content = "";
            }
            else
            {
                AgeFail.Content = "Age required";
                TextAge.Text = "";
            }
            if (functionName == "Create")
            {
                if (value > 0 && check != "")
                {
                    age = int.Parse(TextAge.Text);
                    DAL.CreatePerson(name, age);
                    DatabaseLB.Content = "Database updated!";

                    NameFail.Content = "";
                    AgeFail.Content = "";
                }
            }
            else if (functionName == "Delete")
            {
                if (value > 0 && check != "")
                {
                    age = int.Parse(TextAge.Text);
                    DAL.DeletePerson(name, age);
                    DatabaseLB.Content = "Database updated!";

                    NameFail.Content = "";
                    AgeFail.Content = "";
                }
            }
            else if (functionName == "Select")
            {
                if (value > 0 && check != "")
                {
                    age = int.Parse(TextAge.Text);
                    DAL.SelectPerson(name, age);
                    List<Person> selectPerson = DAL.SelectPerson(name, age);
                    ListBox.ItemsSource = selectPerson;

                    NameFail.Content = "";
                    AgeFail.Content = "";
                }
            }
        }
    }
}
