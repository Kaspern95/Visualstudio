using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Audi", 5);
            Car car2 = new Car("Bus", 20);
            Person p1 = new Person();
            Person p2 = new Person();
            
            Car.wet = true;
            
        }
    }
    class Car
    {
        //This is the constructor
        public Car(string name, int carSeats)
        {
            //This.name is declared in the class, = name is the argument in the constructor.
            this.name = name;
            this.seats = new Person[carSeats];
        }
        public static bool wet = false;
        public string name = "Undefined";
        public Person[] seats;
    }
}
