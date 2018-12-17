using System;

namespace ExceptionHandlingFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            for (int i = 0; i < 10; i++)
            {
                try
                {
                c1.Accelerate(20);

                }
                catch (CarIsDeadException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.CauseOfError);
                    Console.WriteLine(e.ExceptionTime);
                    Console.WriteLine(e.HelpLink);
                    Console.WriteLine(e.Source);
                    Console.WriteLine(e.StackTrace);
                    Console.WriteLine(e.TargetSite);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    // runs if exception is caught

                }
            }
            Console.ReadLine();
        }
    }
}
