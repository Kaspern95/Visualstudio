using System;

namespace ExceptionHandlingFun
{
    class Car
    {
        public int MaxSpeed { get; set; }

        public int CurrentSpeed { get; set; }

        private bool carDead;

        public Car()
        {
            MaxSpeed = 100;
        }

        public void Accelerate(int deltaV)
        {

            if (carDead == true)
            {
                Console.WriteLine("WASTED!");
            }
            else
            {
                CurrentSpeed += deltaV;
                if (CurrentSpeed > MaxSpeed) 
                {
                    CarIsDeadException ex = new CarIsDeadException($"Your speed is {CurrentSpeed}", DateTime.Now,$"Your max speed is {MaxSpeed}", "You can find help at google.com"); 
                    throw ex;
                }
            }
        }
    }
}
