using System;

namespace DelegateAndEventOPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Thermometer t1 = new Thermometer();
            p1.body += t1.InsertThermometer;
            p1.body += t1.VitalAlarm;
            p1.body += t1.Wasted;

            for (int i = 0; i < 10; i++)
            {
                p1.GetSick();

            }
            Console.ReadLine();
        }



        //previous day
        #region
        /*
        static void Main(string[] args)
        {
            Person p1 = new Person();

            
            p1.body += OnTempChange;
            p1.bodyMed += OnTempChange;
            p1.bodyHigh += OnTempChange;
            for (int i = 0; i < 10; i++)
            {
                p1.GetSick(i);
                Console.WriteLine(p1.BodyTemp);
            }
            Console.ReadLine();
        }

        public static void OnTempChange(string msg)
        {
            Console.WriteLine($"message = {msg}");
        }
        */
        #endregion
    }
}
