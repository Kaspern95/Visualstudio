using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_9_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
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
}
