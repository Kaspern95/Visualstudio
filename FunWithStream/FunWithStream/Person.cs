using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStream
{
    [Serializable]
    class Person
    {
        public string firstName = "john";
        public string lastName = "doe";
        public int age;
        public int yearsExperience;
        public Person(string name, int age, int years)
        {
            this.firstName = name;
            this.age = age;
            yearsExperience = years;
        }
        public Person()
        {

        }
        public string FullName
        {
            get { return $"{firstName} {lastName}"; }
        }
        private int salary;

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value > 5000)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    salary = value;
                }
            }
        }

    }
}
