using System.Collections.Generic;
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
            string name = TextName.Text;
            int age = int.Parse(TextAge.Text);
            DAL.CreatePerson(name, age);
        }

        private void Read_Click(object sender, RoutedEventArgs e)
        {
            List<Person> people = DAL.AllPeople();

            ListBox.ItemsSource = people;
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
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
                }
                else if (people[i]. Age == value)
                {
                    DAL.UpdatePerson(value, newName, newAge);
                }
                else if (people[i].Name == name)
                {
                    DAL.UpdatePerson(name, newName, newAge);
                }
            }
            
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            string name = TextName.Text;
            int age = int.Parse(TextAge.Text);
            DAL.DeletePerson(name, age);
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            string name = TextName.Text;
            int age = int.Parse(TextAge.Text);
            List<Person> selectPerson = DAL.SelectPerson(name, age);
            ListBox.ItemsSource = selectPerson;
        }
    }
}
