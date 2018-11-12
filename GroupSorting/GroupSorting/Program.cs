using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            NameGen();
            Console.ReadLine();
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
                name = names.ReadLine().Trim();
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
