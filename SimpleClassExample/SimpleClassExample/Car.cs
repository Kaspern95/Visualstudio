using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        public string petName;
        public int currSpeed;

        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }
        public Car(string name, int speed)
        {
            petName = name;
            currSpeed = speed;
        }

        public void Printstate()
        {
            Console.WriteLine($"{petName} is going {currSpeed} MPH.");
        }
        public void SpeedUp(int delta)
            => currSpeed += delta;


    }
}
