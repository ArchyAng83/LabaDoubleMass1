using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJawingMass
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int indexMin = 0;
            int[] sumRow = new int[4];
            int[][] myArray = new int[4][];
            Random rnd = new Random();
            Random r = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = new int[r.Next(1, 7)];
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = rnd.Next(20);
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    sum += myArray[i][j];
                    indexMin = i;
                }
                sumRow[i] = sum;

                Console.WriteLine(i + " : " + sum);

                sum = 0;
            }

            int imin = 0;
            for (int i = 1; i < sumRow.Length; i++)
            {
                if (sumRow[i] < sumRow[imin])
                {
                    imin = i;
                }
            }

            
            
                for (int j = 0; j < myArray[imin].Length; j++)
                {
                    Console.Write(myArray[imin][j] + "\t");
                }

            Console.WriteLine();
            Console.WriteLine("{1} строка , сумма {0}", sumRow[imin], imin);


            Console.ReadKey();
        }
    }
}
