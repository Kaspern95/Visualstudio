using System.Collections;

namespace FunWithInterfaces
{
    class Garage : IEnumerable
    {
        private Car[] GarageCars = new Car[4];

        public Garage()
        {
            for (int i = 0; i < 4; i++)
            {
                GarageCars[i] = new Car($"bil{i+1}", 10 + i);

            }
        }

        public IEnumerator GetEnumerator()
        {
            return GarageCars.GetEnumerator();
        }
    }
}
