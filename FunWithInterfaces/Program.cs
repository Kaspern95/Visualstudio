using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[3];
            cars[0] = new Car("Buggati", 50);
            cars[1] = new Car("Fiat", 45);
            cars[2] = new Car("Toyota", 45);
            Array.Sort(cars);

            Garage garage = new Garage();

            foreach (Car item in garage)
            {
                Console.WriteLine(item);
            }
            Person[] people = new Person[2];
            people[0] = new Person("Palle", 5);
            people[1] = new Person("Bob", 20);

            List<IMoveable> moveables = new List<IMoveable>();
            moveables.Add(cars[0]);
            moveables.Add(cars[1]);
            moveables.Add(cars[2]);
            moveables.Add(people[0]);
            moveables.Add(people[1]);

            List<IMoveable> sortedList = moveables.OrderByDescending(x => x.Speed).ToList();
            //Car c1 = new Car();
            

            //Person p1 = new Person();
            

            //IPrintable[] canPrint = new IPrintable[2];
            //canPrint[0] = c1;
            //canPrint[1] = p1;
            

            //foreach (var item in canPrint)
            //{
            //    item.Print();
            //}

            //Console.ReadLine();
        }
    }
}
