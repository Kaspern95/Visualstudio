using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //LocalVarDeclarations();
            //DefaultDeclarations();
            //NewingDataTypes();
            //ObjectFunctionality();
            //DataTypeFunctionality();
            //CharFunctionality();
            //ParseFromStrings();
            //ParseFromStringsWithTryParse();

            float tal = 0f;
            string input = Console.ReadLine();
            tal = float.Parse(input);

            Console.WriteLine(tal);
            //System.Boolean
            Console.WriteLine("bool.FalseString: {0}", System.Boolean.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
            Console.ReadLine();
        }
        private static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations:");
            // local variables are declared as so:
            // dataType varName;
            int myInt;
            myInt = 0;

            //declaring variables on 2 lines
            //However it is best to declare variables when making them
            string myString;
            myString = "This is my character data";

            bool b1 = true, b2 = false, b3 = b1;

            //User system.boolean data type to declare a bool
            System.Boolean b4 = false;

            Console.WriteLine("Your data: {0},{1},{2},{3},{4},{5}",
            myInt, myString, b1, b2, b3, b4);
            Console.WriteLine();
        }
        private static void DefaultDeclarations()
        {
            Console.WriteLine("=> Default Declarations: ");
            int myInt = default;
            Console.WriteLine();
            
        }
        private static void NewingDataTypes()
        {
            Console.WriteLine("=> User new to create variables:");
            bool b = new bool(); //false by default
            int i = new int(); //0 by default
            double d = new double(); //0 by default
            DateTime dt = new DateTime(); // 1/1/0001 12 am by default
            Console.WriteLine("{0},{1},{2},{3}", b, i, d, dt);
            Console.WriteLine();
        }
        private static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality");

            // a C# int is really short for System.Int32
            // Which contains the following members from System.Object
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }
        private static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type Functionality:");

            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of Double {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInifinity: {0}", double.NegativeInfinity);
            Console.WriteLine();
        }
        private static void CharFunctionality()
        {
            Console.WriteLine("=> char type Functionality: ");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }
        private static void ParseFromStrings()
        {
            Console.WriteLine("=> Data type Parsing:");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);
            double d = double.Parse("99.884");
            Console.WriteLine("Value of d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
            char c = Char.Parse("W");
            Console.WriteLine("Value of c: {0}", c);
            Console.WriteLine();

        }
        private static void ParseFromStringsWithTryParse()
        {
            Console.WriteLine("=> Data type parsing with TryParse");
            if (bool.TryParse("True", out bool b))
            {
                Console.WriteLine("Value of b: {0}", b);
            }
            string value = "Hello";
            if (double.TryParse(value, out double d))
            {
                Console.WriteLine("Value of d: {0}", d);
            }
            else
            {
                Console.WriteLine("Failed to convert the input ({0}) to a double", value);
            }
            Console.WriteLine();
        }
    }
}       
