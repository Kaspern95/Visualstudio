using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArraysV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            array[1] = 41;

            int[,] mit2DArray = new int[5, 3];
            mit2DArray[0, 0] = 51;

            int[,,] mit3DArray = new int[5, 5, 5];
            mit3DArray[0, 0, 0] = 41;

            int[][] mitJaggedArray = new int[3][];
            mitJaggedArray[0] = new int[3];
            mitJaggedArray[1] = new int[5];
            mitJaggedArray[2] = new int[6];
            mitJaggedArray[1][2] = 5;
            mitJaggedArray[2][3] = 5;

        }
    }
}
