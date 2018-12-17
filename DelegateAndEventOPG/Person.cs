namespace DelegateAndEventOPG
{
    class Person
    {
        public delegate void ConditionHandler(int bodyTemp);
        public event ConditionHandler body;

        private int temp = 36;

        public void GetSick()
        {
            
            body?.Invoke(temp++);
        }




        //previous day
        #region
        /*
        public delegate void ConditionHandler(string msg);
        public event ConditionHandler body;
        public event ConditionHandler bodyMed;
        public event ConditionHandler bodyHigh;
        
        private bool personIsDead = false;
        private int bodyTemp;

        public int BodyTemp
        {
            get { return bodyTemp; }
            set { bodyTemp = value; }
        }

       

        public void GetSick(int deltaV)
        {
        Thermometer t1 = new Thermometer();
            BodyTemp = t1.InsertThermometer(BodyTemp) + deltaV;
            if (personIsDead == true)
            {
                body?.Invoke("rip person");
            }
            else
            {
                if (BodyTemp >= 34 && BodyTemp <= 37)
                {
                    body?.Invoke("You are fine");
                }
                else if (BodyTemp >= 38 && BodyTemp < 40)
                {
                    bodyMed?.Invoke("Fever");
                }
                else if (BodyTemp >= 40 && BodyTemp < 42)
                {
                    bodyHigh?.Invoke("gettin real sick");
                }
                else
                {
                    body?.Invoke("Person died");
                    personIsDead = true;
                }

            }
        }
        */
        #endregion
    }

}

