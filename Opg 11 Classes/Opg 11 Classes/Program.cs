using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_11_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Opgave11_4();
            Opgave11_5();
            Console.ReadLine();
        }

        private static void Opgave11_5()
        {
            
        }

        private static void Opgave11_4()
        {
            Person p1 = new Person();
            Worker p2 = new Worker();
            
            p1.name = "Kasper";
            p1.ToString();
            p2.salary = 10;
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.GetHashCode());
        }
    }
}
