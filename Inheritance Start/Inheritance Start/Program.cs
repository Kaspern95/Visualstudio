using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Start
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Vehicle v1 = new Car();
            Vehicle m1 = new MotorCycle();
            Console.WriteLine(c1.GetType());
            Console.WriteLine(v1.GetType());
            DelvisClass1 del1 = new DelvisClass1();
            del1.name = "Kasper";
            v1.engine = "V8";
            Console.WriteLine(v1.ToString());
            Vehicle[] vehicles = new Vehicle[3];
            vehicles[0] = c1;
            vehicles[1] = v1;
            vehicles[2] = m1;


            Console.ReadLine();
        }
    }
}
