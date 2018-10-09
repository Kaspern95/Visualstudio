using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsIntro
{

    class Program
    {
        static void Main(string[] args)
        {/*
            int tal = 5;
            ChangeNumber(ref tal);
            string tekst = "hej";
            ChangeTekst(ref tekst);

            Bil skoda = new Bil("V8", 4, true, "NyBil204", 5, false);
            Mechanic jens = new Mechanic();
            jens.nyPlade(ref skoda, "Ny plade til skoda");

            skoda.RemoveDoor();

            Console.WriteLine(skoda.antalDore);
            Bil ferarri = new Bil();
            

            Console.WriteLine(skoda.motorType);

            Calculator calc = new Calculator();
            calc.Add();

            Console.WriteLine(tal);
             */

            Person p1 = new Person("Jens", 25, 1.80);

            //defining with enum
            //b1.size = BeerBox.BottleSize.Large;
            BeerBox b1 = new BeerBox(BeerBox.BottleSize.Large, "Hancock", "Hvede", 30, 40, 50, "Denmark", 4, 15.6);
            Student s1 = new Student();
            s1.name = "Martin";
            s1.age = 27;
            s1.education = "Datamatiker";
            s1.money = 500;
            s1.BuyBeer(b1);
            s1.DrinkBeer();
           

            Console.WriteLine(s1.myBeer.amount);
            

            Console.ReadLine();
        }

        private static void ChangeTekst(ref string tekst)
        {
            tekst = "ny tekst";
        }

        private static void ChangeNumber(ref int tal)
        {
            tal = 10;
        }
    }
    struct Student
    {
        public string name;
        public string education;
        public int age;
        public double money;
        public BeerBox myBeer;
        public void BuyBeer(BeerBox beerToBuy)
        {
            if (age > 17 && money >= beerToBuy.salePrice)
            {
                myBeer = beerToBuy;
                money -= beerToBuy.salePrice;
            }
        }
        public void DrinkBeer()
        {
            if (myBeer.amount > 0)
            {
                myBeer.amount--;
            }
        }
    }
    struct BeerBox
    {
        public enum BottleSize
        {
            Small = 25,
            Medium = 33,
            Large = 50
        }
        public string name;
        public string hopsType;
        public int amount;
        public double price;
        public double salePrice;
        public string country;
        public int rating;
        public double pct;
        public BottleSize size;
        public BeerBox(BottleSize size, string name, string hopsType, int amount,
        double price, double salePrice, string country, int rating, double pct)
        {
            this.size = size;
            this.name = name;
            this.hopsType = hopsType;
            this.amount = amount;
            this.price = price;
            this.salePrice = salePrice;
            this.country = country;
            this.rating = rating;
            this.pct = pct;
        }
        
    }
    struct Person
    {
        public string name;
        public int age;
        public double height;

        public Person(string name, int age, double height)
        {
            this.name = name;
            this.age = age;
            this.height = height;
        }
    }
    struct Bil
    {
        public Bil(string motorType, int antalHjul, bool _duftFrisker, string _nrPladeNr, int _antalDore, bool _runningMotor)
        {
            this.motorType = motorType;
            this.antalHjul = antalHjul;
            duftFrisker = _duftFrisker;
            nrPladeNr = _nrPladeNr;
            antalDore = _antalDore;
            runningMotor = _runningMotor;
        }
        public string motorType;
        public int antalHjul;
        public bool duftFrisker;
        public string nrPladeNr;
        public int antalDore;
        public bool runningMotor;

        public void RemoveDoor()
        {
            antalDore--;
        }
    }
    struct Mechanic
    {
        public void nyPlade(ref Bil bil, string nytNr)
        {
            bil.nrPladeNr = nytNr;
        }

    }
    struct Calculator
    {
        public void Add()
        {
            
        }
        public void Sub()
        {

        }
    }
}
