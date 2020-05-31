using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaDoubleMass1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Дана целочисленная прямоугольная матрица. Определить :
            // 1) количество столбцов, содержащих хотя бы один нулевой элемент;
            // 2) номер строки, в которой находится самая длинная серия одинаковых элементов.

            int count = 0;
            //int n = 4, m = 5;
            //int[,] dArray = new int[n, m];
            //Random r = new Random();
            //for (int i = 0; i < dArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < dArray.GetLength(1); j++)
            //    {
            //        dArray[i, j] = r.Next(-9, 9);

            //    }

            //}
            Console.WriteLine("Введите размер двумерного массива :");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] dArray = new int[n, m];

            Console.WriteLine("Введите элементы массива :");
            for (int i = 0; i < dArray.GetLength(0); i++)
                for (int j = 0; j < dArray.GetLength(1); j++)
                    dArray[i, j] = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < dArray.GetLength(0); i++) 
                
            {
                Console.WriteLine();
                for (int j = 0; j < dArray.GetLength(1); j++)
                {
                    Console.Write("{0, 3} ", dArray[i, j]);
                }
                
            }
            Console.WriteLine();

            // 1)
            for (int j = 0; j < dArray.GetLength(1); j++)
                for (int i = 0; i < dArray.GetLength(0); i++)
                    if (dArray[i, j] == 0)
                    {
                        count++;
                        break;
                    }
            Console.WriteLine("Количество столбцов : {0}", count);
            Console.WriteLine();

            //2)
            int count2;
            int max = 0;
            int number = 0;
            
            for (int i = 0; i < dArray.GetLength(0); i++)
            {
                count2 = 0;
                for (int j = 0; j < dArray.GetLength(1) - 1; j++)                
                {
                    if (dArray[i, j] != dArray[i, j + 1])
                        continue;
                    count2++;
                }
                if (max >= count2)
                     continue;
                max = count2;
                number = i;
                                  
            }
            Console.WriteLine("Номер строки : {0}", number);
            
            Console.ReadKey();
        }
    }
}
