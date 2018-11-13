using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace FunWithStream
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Writer();
            //StudentInfo();
            //ReadStudent();
            //Song();
            //Console.WriteLine(SongCount());
            //Linq();
            //Serialize();
            Deserialize();
            Console.ReadLine();
        }
            
        private static void Deserialize()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open("MinPerson.Skole", FileMode.Open);
            Person p1 = (Person)bf.Deserialize(file);
            
        }

        private static void Serialize()
        {
            Person p1 = new Person("kasper", 23, 2);
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create("MinPerson.skole");
            bf.Serialize(file, p1);
            file.Close();
        }

        private static void Linq()
        {
            List<Person> people = new List<Person>();
            Person p1 = new Person("kasper",23,2);
            Person p2 = new Person("john",33,10);
            people.Add(p1);
            people.Add(p2);
            people.Add(new Person("billy",43,22));
            Person p4 = new Person();
            Console.WriteLine(p4.FullName);
            p4.Salary = 1000;

            List<Person> sorted = people.Where(x => x.firstName == "kasper").ToList();
            List<Person> experience = people.Where(x => x.yearsExperience > 8).OrderBy(x => x.firstName).ToList();
        }

        private static int SongCount()
        {
            int count = 0;
            string tekst = File.ReadAllText("Song.txt");
            char[] splitting = { ' ', '\n', '\r' };
            string[] fields = tekst.Split(splitting, StringSplitOptions.RemoveEmptyEntries);
            count = fields.Length;
            return count;
        }

        private static void Song()         
        {

                StreamReader song = new StreamReader("Song.txt");
                
                    int count = 0;
                    string line;
                    string[] fields;

                    while (!song.EndOfStream)
                    {
                        line = song.ReadLine();
                        fields = line.Split(' ');
                        count += fields.Length;
                    }
                    Console.WriteLine($"der er {count} antal ord");

        }

        private static void ReadStudent()
        {
            try
            {
                using (StreamReader studentReader = new StreamReader("StudentInfo.txt"))
                {
                    string line;

                    while ((line = studentReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception)
            {

            }

            string[] alleLinjer = File.ReadAllLines("Song");
        }

        private static void StudentInfo()
        {
            //Using ("file",true) does not override file
            //StreamWriter student = new StreamWriter("StudentInfo.txt", true);
            StreamWriter student = new StreamWriter("StudentInfo.txt");
            Console.WriteLine("Indtast studentens navn");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast studentens alder");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast studentens uddannelse");
            string education = Console.ReadLine();
            Console.WriteLine("Indtast start dato på uddannelsen");
            string educationStart = Console.ReadLine();

            student.WriteLine($"Studenten hedder {name}.");
            student.WriteLine($"Studentens alder er {age}.");
            student.WriteLine($"Studenten går på {education} uddannelsen.");
            student.WriteLine($"Studenten startede på {education} den {educationStart}.");
            student.Close();
        }

        private static void Writer()
        {
            StreamWriter streamWriter = new StreamWriter("Mintekstfil.txt");
            streamWriter.WriteLine("Hej med jer");
            streamWriter.Close();
        }
    }

}
