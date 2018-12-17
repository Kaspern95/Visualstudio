using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithDelegates
{
    class Program
    {
        public delegate int Operation(int tal1, int tal2);


        static void Main(string[] args)
        {
            //Operation o = new Operation(Calculator.Add);
            //Console.WriteLine($"10 + 10 = {o(10,10)}");
            Car c1 = new Car(100, 20, "Fiat");
            //c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            //c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));
            c1.Exploded += OnCarEngineEventExplode;
            c1.AboutToExplode += OnCarEngineEventExplode;
            c1.AboutToExplode += OnCarEngineEvent2;
            for (int i = 0; i < 10; i++)
            {
                c1.Accelerate(10);

            }
            Console.ReadLine();
        }


        public static void OnCarEngineEventExplode(string msg)
        {
            Console.WriteLine("\n***** Message from car*******");
            Console.WriteLine($"message = {msg}");
            Console.WriteLine("*******************************");
        }public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("\n***** Message from car*******");
            Console.WriteLine($"message = {msg.ToUpper()}");
            Console.WriteLine("*******************************");
        }
        public static void ShowDelegateInfo(Delegate del)
        {
            Console.WriteLine(del.Method);
            Console.WriteLine(del.Target);
        }
    }
}
