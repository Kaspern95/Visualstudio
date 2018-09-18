using System;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Console.WriteLine("** Fun with arrays **");

            //SimpleArrays();
            //ArrayInitialization();
            //DeclareImplicitArrays();
            //ArrayOfObjects();

            Console.ReadLine();
        }
        private static void SimpleArrays()
        {
            Console.WriteLine(">= Simple array creation.");
            //creates array of 3 ints 0,1,2
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }

            //creates 100 item string array 0-99
            string[] bookOnDotNet = new string[100];
            Console.WriteLine();

        }
        private static void ArrayInitialization()
        {
            Console.WriteLine(">= Array Initialization");

            // Array initialization syntax using the "new" keyword.
            string[] stringArray = new string[]
            {
                "one", "two", "three"
            };
            Console.WriteLine($"stringArray has {stringArray.Length} elements");

            // Array initialization syntax without using the new keyword.
            bool[] boolArray = { false, false, true };
            Console.WriteLine($"boolArray has {boolArray.Length} elements");

            // Array initialization with "new" keyword and size.
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine($"intArray has {intArray.Length} elements");
            Console.WriteLine();
        }
        private static void DeclareImplicitArrays()
        {
            Console.WriteLine(">= Implicit Array initialization");

            //using a as "int[]"
            var a = new[] { 1,10,100,1000 };
            Console.WriteLine($"a is a: {a.ToString()}");

            //variables selfdetect
            var b = new[] {1,1.5,2,2.5 };
            Console.WriteLine($"b is a: {b.ToString()}");

            //new[] must be used for this method
            var c = new[] { "hello", null, "world"};
            Console.WriteLine($"c is a: {c.ToString()}");
            Console.WriteLine();
        }
        private static void ArrayOfObjects()
        {
            Console.WriteLine(">= Array of Objects");

            //An array of objects can contain anything
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & void";
            foreach(object obj in myObjects)
            {
                Console.WriteLine($"Type: {obj.GetType()}, value: {obj}");
            }
            Console.WriteLine( );
        }

    }
}
