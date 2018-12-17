using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterfaces
{
    class Person : IPrintable, IMoveable
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public Person(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public void Print()
        {
            Console.WriteLine("This is a person instead of a car");
        }
    }
}
