using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodeCaffe2_Biler_og_classes
{
    class Car
    {
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private int miles;

        public int Miles
        {
            get { return miles; }
            set { miles = value; }
        }

        public Car(string model, double price, int age, int miles)
        {
            Model = model;
            Price = price;
            Age = age;
            Miles = miles;
        }
        public override string ToString()
        {
            return $"{Model}, {Price:C0}";
        }
    }
}
