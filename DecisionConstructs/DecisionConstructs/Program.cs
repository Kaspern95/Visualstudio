using System;

namespace DecisionConstructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decision Constructs");
            Console.WriteLine();
            //ConditionalExecution();
            Login();
            Console.ReadLine();
            
        }


        private static void Login()
        {
            string password = "1234";
            Console.WriteLine("Hvad er kodeordret?: ");
            string input = Console.ReadLine();

            if (input == password)
            {
                Console.WriteLine("Du er logget ind!");
            }
            else
            {
                Console.WriteLine("Kodeordet er forkert");
            }
            Console.WriteLine();



            #region switch
            switch (input)
            {
                case "1234":
                    Console.WriteLine("Velkommen");
                    break;
                default:
                    Console.WriteLine("Rejected");
                    break;
            } 
            #endregion
        }
        private static void ConditionalExecution()
        {
            string dataString = "Hello";
            Console.WriteLine(dataString.Length <= 0
                ? "This is true"
                : "This is false"
                );
            Console.WriteLine();

            Console.WriteLine("hello or bye");
            string inSwitch = Console.ReadLine();

            switch (inSwitch)
            {
                case "hello":
                    Console.WriteLine("Hello from console");
                    break;
                case "bye":
                    Console.WriteLine("Bye then");
                    break;
                default:
                    Console.WriteLine("i dont understand");
                    break;
            }
            Console.WriteLine();


            Console.WriteLine("1 or 2?");
            string getSwitch = Console.ReadLine();
            int intSwitch = int.Parse(getSwitch);

            switch (intSwitch)
            {
                case 1:
                    Console.WriteLine("this is 1");
                    break;
                case 2: Console.WriteLine("you chose 2");
                    break;
                default:
                    Console.WriteLine("wtf r u doin");
                    break;

            }

        }
    }
}
