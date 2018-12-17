using System;

namespace DelegateAndEventOPG
{
    class Thermometer
    {
        public void InsertThermometer(int bodyTemp)
        {
            Console.WriteLine($"Your temperature is {bodyTemp}");
        }

        public void VitalAlarm(int bodyTemp)
        {
            if (bodyTemp > 37 && bodyTemp <= 42)
            {
                Console.WriteLine("Getting Sick");
                Console.Beep();
            }
        }
        public void Wasted(int bodyTemp)
        {
            if (bodyTemp > 42)
            {
                Console.WriteLine("WASTED!");
            }
        }




        //Previous day
        #region
        /*
        public int InsertThermometer(int bodyTemp)
        {
            bodyTemp = 36;
            return bodyTemp;
        }
        */
        #endregion
    }
}
