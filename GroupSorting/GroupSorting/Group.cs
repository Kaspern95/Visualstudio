using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupSorting
{
    class Group
    {
        public List<Person> members = new List<Person>();
        public string Name { get; set; }
        public Group(string name)
        {
            Name = name;
        }
    }
}
