using System;

namespace LottoDoWhile
{
    class Program
    {

        static void Main(string[] args)
        {
            DateOfCoupon();
            ArrayLotto();

            Console.ReadLine();

        }

        static void DateOfCoupon()
        {
            #region Lotto Facon
            string lottodate;
            lottodate = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine("\tLotto " + lottodate + "\n");
            Console.WriteLine("\t     1 - Uge");
            Console.WriteLine("\t    LYN-LOTTO \n");
            #endregion
        }

        private static void ArrayLotto()
        {
            Random rnd = new Random();
            int[] array1 = new int[7];
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                
                for (int j = 0; j < 1; j++)
                {
                    count = 0;


                    while (count < 7)

                    {
                        array1[count] = rnd.Next(1, 37);
                        count++;
                    }

                    //beklager
                    #region pls no look
                    bool arrayC1 = array1[0] == array1[1] || array1[0] == array1[2] || array1[0] == array1[3] || array1[0] == array1[4] || array1[0] == array1[5] || array1[0] == array1[6];
                    bool arrayC2 = array1[1] == array1[0] || array1[1] == array1[2] || array1[1] == array1[3] || array1[1] == array1[4] || array1[1] == array1[5] || array1[1] == array1[6];
                    bool arrayC3 = array1[2] == array1[0] || array1[2] == array1[3] || array1[2] == array1[4] || array1[2] == array1[5] || array1[2] == array1[6];
                    bool arrayC4 = array1[3] == array1[0] || array1[3] == array1[2] || array1[3] == array1[4] || array1[3] == array1[5] || array1[3] == array1[6];
                    bool arrayC5 = array1[4] == array1[0] || array1[4] == array1[2] || array1[4] == array1[3] || array1[4] == array1[5] || array1[4] == array1[6];
                    bool arrayC6 = array1[5] == array1[0] || array1[5] == array1[2] || array1[5] == array1[3] || array1[5] == array1[4] || array1[5] == array1[6];
                    bool arrayC7 = array1[6] == array1[0] || array1[6] == array1[2] || array1[6] == array1[3] || array1[6] == array1[4] || array1[6] == array1[5];
                    #endregion

                    if (arrayC1 || arrayC2 || arrayC3 || arrayC4 || arrayC5 || arrayC6 || arrayC7)
                    {
                        j--;
                    }
                    else
                    {
                        Array.Sort(array1);
                        Console.Write($"    {i+1,2}. ");
                        foreach (var item in array1)
                        {
                            Console.Write("{0:d2} ", item);

                        }
                        Console.WriteLine();
                        
                    }
                }
            }
        }
    }
}
