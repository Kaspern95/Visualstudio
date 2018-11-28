using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodeCaffe2_Biler_og_classes
{
    class CarDealer
    {
        private List<Car> cars;

        public List<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        private double money = 0;

        public double Money
        {
            get { return money; }
            set { money = value; }
        }

        public void SellCar(List<Car> carsToSell)
        {
            foreach (var item in carsToSell)
            {

            Money += item.Price;
            Cars.Remove(item);
            }
        }
        public CarDealer(List<Car> initCars)
        {
            Cars = initCars;
        }
    }
}
