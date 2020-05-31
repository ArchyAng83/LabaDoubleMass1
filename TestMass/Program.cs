using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMass
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray = { 1, 2, 3, 5, 4, 1, 1, 4, 1 };
            //int min = myArray[0];

            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    if (myArray[i] < min)
            //    {
            //        min = myArray[i];

            //    }
            //}
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if(myArray[i] == min)
            //    {
            //        Console.WriteLine(myArray[i]);
            //        Console.WriteLine(i);
            //    }
            //}

            int sum = 0;
            int[] sumRow = new int[4];
            int[,] myArray = new int[4, 4];
            Random rnd = new Random();
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = rnd.Next(20);
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    sum += myArray[i, j];                    
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

            Console.WriteLine("сумма {0}", sumRow[imin]);
            Console.ReadKey();
        }

        
    }
}
