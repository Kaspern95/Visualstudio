using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Basic Console I/O **");

            //DisplayMessage();
            FormatNumericalData();
            //GetUserData();
            
            Console.ReadLine();
        }
        private static void DisplayMessage()
        {
            //Using string.format to form a string literal
            string userMessage = string.Format("100000 in hex is {0:x}", 100000);
            System.Windows.MessageBox.Show(userMessage);
        }
        private static void FormatNumericalData()
        {
            Console.WriteLine("The value 99999 in various formats: ");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);

            //Upper and lowercase hex matters
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
        }
        private static void GetUserData()
        {
            // Get name and age through console.readline
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your age; ");
            string userAge = Console.ReadLine();

            // change the color of our output
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Output to console through placeholders
            Console.WriteLine("Hello {0}! Your are {1} years old.", 
            userName, userAge);

            Console.ForegroundColor = prevColor;


        }
    }
}
