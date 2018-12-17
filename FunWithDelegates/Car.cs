using System;

namespace FunWithDelegates
{
    class Car
    {
        public int MaxSpeed { get; set; }
        public int CurrentSpeed { get; set; }
        public string Name { get; set; }
        private bool carIsDead = false;

        public Car(int maxSpeed, int currentSpeed, string name)
        {
            MaxSpeed = maxSpeed;
            CurrentSpeed = currentSpeed;
            Name = name;
        }
        public delegate void CarEngineHandler(string msg);
        
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToExplode;

        public void Accelerate(int deltaV)
        {
            if (carIsDead == true)
            {
                Exploded?.Invoke("The Car is dead");
                //handler?.Invoke("The Car is dead");
            }
            else
            {
                CurrentSpeed += deltaV;
                if ((MaxSpeed - CurrentSpeed) == 10 && AboutToExplode != null)
                {
                    AboutToExplode?.Invoke("Slow down son");
                }
                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                }
                else
                {
                    Console.WriteLine($"Current speed is {CurrentSpeed}");
                }
            }
        }
    }
}
