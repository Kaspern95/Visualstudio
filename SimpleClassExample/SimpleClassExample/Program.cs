using System;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.petName = "kasper";
            myCar.currSpeed = 10;
            Car chuck = new Car();
            Car frank = new Car("Frank", 25);
            Motorcycle mc = new Motorcycle();
            mc.PopAWheely();
            frank.Printstate();
            chuck.Printstate();
            for (int i = 0; i < 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.Printstate();
            }

            Console.ReadLine();
        }
    }
}
