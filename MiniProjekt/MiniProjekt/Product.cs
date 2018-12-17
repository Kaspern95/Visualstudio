using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjekt
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Available { get; set; }

        public Product(int id, string name, bool available)
        {
            Id = id;
            Name = name;
            Available = available;
        }
        public void FlipAvailability()
        {
            Available = !Available;
        }
    }
}
