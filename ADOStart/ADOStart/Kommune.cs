using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOStart
{
    class Kommune
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int population;

        public int Population
        {
            get { return population; }
            set { population = value; }
        }

        public Kommune(string name, int population)
        {
            Name = name;
            Population = population;
        }
    }
}
