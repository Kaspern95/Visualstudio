using System;
using System.Collections.Generic;
using System.IO;

namespace GroupSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //NameGen();
            List<Group> allGroups = GenerateGroups();
            //MikkelGen();

            Console.ReadLine();
        }

        private static List<Group> GenerateGroups()
        {
            Random rnd = new Random();
            List<Group> allGroups = new List<Group>();
            List<Person> allPersons = new List<Person>();
            StreamReader names = new StreamReader("Names.txt");
            string name;
            while (!names.EndOfStream)
            {
                name = names.ReadLine();
                allPersons.Add(new Person(name));
            }

            for (int i = 0; i < 10; i++)
            {
                allGroups.Add(new Group("Gruppe " + (i + 1)));
            }

            for (int j = 0; 0 < allPersons.Count;)
            {
                if (allGroups[j].members.Count < 3)
                {
                    int number = rnd.Next(0, allPersons.Count);
                    allGroups[j].members.Add(allPersons[number]);
                    allPersons.Remove(allPersons[number]);
                }
                else
                {
                    j++;
                }
            }
            
            for (int l = 0; l < 10; l++)
            {
                Console.WriteLine("\nGruppe " + (l+1) + "\n");
                foreach (var item in allGroups[l].members)
                {
                    Console.WriteLine(item.name);

                }
            }

            return allGroups;
        }

        private static void MikkelGen()
        {

        }

        private static void NameGen()
        {
            StreamReader names = new StreamReader("Names.txt");

            string name;
            List<Person> nameList = new List<Person>();
            int count = 0;
            int group = 2;
            while (!names.EndOfStream)
            {
                name = names.ReadLine();
                nameList.Add(new Person(name));

            }
            Console.WriteLine("Group 1\n");
            foreach (var item in nameList)
            {
                if (count > 2)
                {
                    Console.WriteLine($"\nGroup {group}\n");
                    group++;
                    count = 0;
                }
                Console.WriteLine(item.name);
                count++;
            }

        }
    }
}
