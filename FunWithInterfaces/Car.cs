using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterfaces
{
    class Car : IPrintable, IMoveable, IComparable
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public void Print()
        {
            Console.WriteLine("This is a car");
        }

        public int CompareTo(object obj)
        {

            Car tmp = obj as Car;
            if (tmp != null)
            {
                if (this.Speed > tmp.Speed)
                {
                    return 1;
                }
                if (this.Speed < tmp.Speed)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new ArgumentException("This isnt a car");
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Speed: {Speed}";
        }

        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
    }
}
